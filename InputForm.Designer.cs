namespace GestureLevenstein
{
  partial class InputForm
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // timer
      // 
      this.timer.Interval = 500;
      this.timer.Tick += new System.EventHandler(this.timer_Tick);
      // 
      // InputForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(471, 454);
      this.Name = "InputForm";
      this.Text = "Input gesture";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemForm_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ItemForm_MouseMove);
      this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemForm_MouseUp);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer;
  }
}