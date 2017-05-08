using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestureLevenstein
{
  public partial class InputForm : Form
  {
    List<Point> points = new List<Point>();
    bool isMouseDown = false;

    public InputForm(int timeout) {
      InitializeComponent();
      timer.Interval = timeout;
    }

    public delegate void GestureInputHandler(object sender, GestureInputEventArgs e);

    public event GestureInputHandler GestureInput;

    private void ItemForm_MouseDown(object sender, MouseEventArgs e) {
      timer.Stop();
      points.Add(e.Location);
      isMouseDown = true;
    }

    private void ItemForm_MouseMove(object sender, MouseEventArgs e) {
      if (isMouseDown) {
        points.Add(e.Location);
        Pen pen = new Pen(Color.Green, 5);
        Graphics graphics = CreateGraphics();
        graphics.DrawLine(pen, points[points.Count - 2], e.Location);
        pen.Dispose();
        graphics.Dispose();
      }
    }

    private void ItemForm_MouseUp(object sender, MouseEventArgs e) {
      timer.Start();
      points.Add(e.Location);
      isMouseDown = false;
    }

    private void timer_Tick(object sender, EventArgs e) {
      timer.Stop();
      Close();
      GestureInput(this, new GestureInputEventArgs(points));
      points = new List<Point>();
    }
  }

  public class GestureInputEventArgs : EventArgs
  {
    public GestureInputEventArgs(List<Point> points) {
      this.Points = points;
    }

    public List<Point> Points { get; private set; }
  }
}
