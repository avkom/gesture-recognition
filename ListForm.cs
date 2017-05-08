using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Komendant;

namespace GestureLevenstein
{
  public partial class ListForm : Form
  {
    private Storage storage;
    private const string fileName = "GestureLevenshtein.xml";

    public ListForm() {
      InitializeComponent();
      storage = new Storage();
      if (File.Exists(fileName))
        storage.Load(fileName);
      bindingSource.DataSource = storage.Gestures;
      upDownTimeout.Value = storage.Timeout;
      upDownMaxSegmentCount.Value = storage.MaxSegmentCount;
    }

    private void ListForm_FormClosing(object sender, FormClosingEventArgs e) {
      storage.Save(fileName);
    }

    private void buttonRecognize_Click(object sender, EventArgs e) {
      InputForm inputForm = new InputForm(storage.Timeout);
      inputForm.GestureInput += Recognize;
      inputForm.Show();
    }

    private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
      InputForm inputForm = new InputForm(storage.Timeout);
      inputForm.GestureInput += Edit;
      inputForm.Show();
    }

    private void Recognize(object sender, GestureInputEventArgs e) {
      string segmentsDirections = LevenshteinGestureRecognition.SegmentsDirections(e.Points, storage.MaxSegmentCount);
      Gesture gesture = storage.Find(segmentsDirections);
      string message = string.Format("Inputted:\n  Direction: {0}\n\nFound:\n  Direction: {1}\n  Name: {2}", segmentsDirections, gesture.Direction, gesture.Name);
      MessageBox.Show(message, "Gesture Levenshtein");
    }

    private void Edit(object sender, GestureInputEventArgs e) {
      string segmentsDirections = LevenshteinGestureRecognition.SegmentsDirections(e.Points, storage.MaxSegmentCount);
      Gesture gesture = (Gesture)bindingSource.Current;
      gesture.Direction = segmentsDirections;
    }

    private void upDownTimeout_ValueChanged(object sender, EventArgs e) {
      storage.Timeout = (int)upDownTimeout.Value;
      if (trackBarTimeout.Value != storage.Timeout)
        trackBarTimeout.Value = storage.Timeout;
    }

    private void trackBarTimeout_ValueChanged(object sender, EventArgs e) {
      storage.Timeout = trackBarTimeout.Value;
      if ((int)upDownTimeout.Value != storage.Timeout)
        upDownTimeout.Value = storage.Timeout;
    }

    private void upDownMinSegmentLength_ValueChanged(object sender, EventArgs e) {
      storage.MaxSegmentCount = (int)upDownMaxSegmentCount.Value;
      if (trackBarMaxSegmentCount.Value != storage.MaxSegmentCount)
        trackBarMaxSegmentCount.Value = storage.MaxSegmentCount;
    }

    private void trackBarMinSegmentLength_ValueChanged(object sender, EventArgs e) {
      storage.MaxSegmentCount = trackBarMaxSegmentCount.Value;
      if ((int)upDownMaxSegmentCount.Value != (int)storage.MaxSegmentCount)
        upDownMaxSegmentCount.Value = storage.MaxSegmentCount;
    }
  }
}
