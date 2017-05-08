using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Globalization;
using Komendant;

namespace GestureLevenstein
{
  public class Storage
  {
    public Storage() {
      Gestures = new List<Gesture>();
    }

    public void Load(string fileName) {
      try {
        XmlReader reader = XmlReader.Create(fileName);
        try {
          Gestures.Clear();
          reader.Read();
          reader.ReadStartElement("GestureLevenshtain");

          reader.ReadStartElement("MaxSegmentCount");
          MaxSegmentCount = reader.ReadContentAsInt();
          reader.ReadEndElement(); // </maxSegmentCount>

          reader.ReadStartElement("Timeout");
          Timeout = reader.ReadContentAsInt();
          reader.ReadEndElement(); // </Timeout>

          while (reader.IsStartElement("Gesture")) {
            reader.ReadStartElement("Gesture");
            Gesture gesture = new Gesture();

            reader.ReadStartElement("Name");
            gesture.Name = reader.ReadContentAsString();
            reader.ReadEndElement(); // </Name>

            reader.ReadStartElement("Direction");
            gesture.Direction = reader.ReadContentAsString();
            reader.ReadEndElement(); // </Direction>

            reader.ReadEndElement(); // </Gesture>
            Gestures.Add(gesture);
          }
          if (reader.NodeType != XmlNodeType.EndElement) // </Gestures>
            throw new XmlException("Wait for </GestureLevenshtain>");
        }
        finally {
          reader.Close();
        }
      }
      catch (Exception e) {
        string message = string.Format("Error load file: \n {0}", e.Message);
        MessageBox.Show(message);
      }
    }

    public void Save(string fileName) {
      XmlWriter writer = XmlWriter.Create(fileName);
      writer.WriteStartDocument();
      writer.WriteStartElement("GestureLevenshtain");
      writer.WriteElementString("MaxSegmentCount", MaxSegmentCount.ToString());
      writer.WriteElementString("Timeout", Timeout.ToString());
      foreach (Gesture gesture in Gestures) {
        writer.WriteStartElement("Gesture");
        writer.WriteElementString("Name", gesture.Name);
        writer.WriteElementString("Direction", gesture.Direction);
        writer.WriteEndElement(); // </Gesture>
      }
      writer.WriteEndElement(); // </GestureLevenshtain>
      writer.Close();
    }
    
    public Gesture Find(string direction) {
      Gesture bestGesture = null;
      int bestGestureDistance = int.MaxValue;
      foreach (Gesture gesture in Gestures) {
        int distance = LevenshteinGestureRecognition.LevenshteinDistance(direction, gesture.Direction);
        if (distance < bestGestureDistance) {
          bestGesture = gesture;
          bestGestureDistance = distance;
        }
      }
      return bestGesture;
    }

    public List<Gesture> Gestures { get; private set; }
    public int MaxSegmentCount { get; set; }
    public int Timeout { get; set; }
  }
}
