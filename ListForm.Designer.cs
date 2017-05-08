namespace GestureLevenstein
{
  partial class ListForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListForm));
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.GestureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.buttonRecognize = new System.Windows.Forms.Button();
      this.trackBarTimeout = new System.Windows.Forms.TrackBar();
      this.trackBarMaxSegmentCount = new System.Windows.Forms.TrackBar();
      this.upDownTimeout = new System.Windows.Forms.NumericUpDown();
      this.upDownMaxSegmentCount = new System.Windows.Forms.NumericUpDown();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
      this.bindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxSegmentCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownTimeout)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMaxSegmentCount)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToOrderColumns = true;
      this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView.AutoGenerateColumns = false;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Direction,
            this.GestureName});
      this.dataGridView.DataSource = this.bindingSource;
      this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.dataGridView.Location = new System.Drawing.Point(0, 177);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.dataGridView.Size = new System.Drawing.Size(348, 139);
      this.dataGridView.TabIndex = 1;
      this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
      // 
      // Direction
      // 
      this.Direction.DataPropertyName = "Direction";
      this.Direction.HeaderText = "Direction";
      this.Direction.Name = "Direction";
      // 
      // GestureName
      // 
      this.GestureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.GestureName.DataPropertyName = "Name";
      this.GestureName.HeaderText = "Name";
      this.GestureName.Name = "GestureName";
      // 
      // bindingNavigator
      // 
      this.bindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bindingNavigator.BindingSource = this.bindingSource;
      this.bindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.bindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
      this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.bindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bindingNavigator.Name = "bindingNavigator";
      this.bindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.bindingNavigator.Size = new System.Drawing.Size(348, 25);
      this.bindingNavigator.TabIndex = 2;
      this.bindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Добавить";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 22);
      this.bindingNavigatorCountItem.Text = "для {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Удалить";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Положение";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // buttonRecognize
      // 
      this.buttonRecognize.Location = new System.Drawing.Point(261, 0);
      this.buttonRecognize.Name = "buttonRecognize";
      this.buttonRecognize.Size = new System.Drawing.Size(75, 23);
      this.buttonRecognize.TabIndex = 3;
      this.buttonRecognize.Text = "Recognize";
      this.buttonRecognize.UseVisualStyleBackColor = true;
      this.buttonRecognize.Click += new System.EventHandler(this.buttonRecognize_Click);
      // 
      // trackBarTimeout
      // 
      this.trackBarTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarTimeout.Location = new System.Drawing.Point(76, 17);
      this.trackBarTimeout.Maximum = 2000;
      this.trackBarTimeout.Name = "trackBarTimeout";
      this.trackBarTimeout.Size = new System.Drawing.Size(242, 45);
      this.trackBarTimeout.SmallChange = 100;
      this.trackBarTimeout.TabIndex = 4;
      this.trackBarTimeout.TickFrequency = 200;
      this.trackBarTimeout.ValueChanged += new System.EventHandler(this.trackBarTimeout_ValueChanged);
      // 
      // trackBarMaxSegmentCount
      // 
      this.trackBarMaxSegmentCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBarMaxSegmentCount.Location = new System.Drawing.Point(76, 19);
      this.trackBarMaxSegmentCount.Maximum = 51;
      this.trackBarMaxSegmentCount.Minimum = 1;
      this.trackBarMaxSegmentCount.Name = "trackBarMaxSegmentCount";
      this.trackBarMaxSegmentCount.Size = new System.Drawing.Size(242, 45);
      this.trackBarMaxSegmentCount.TabIndex = 5;
      this.trackBarMaxSegmentCount.TickFrequency = 5;
      this.trackBarMaxSegmentCount.Value = 1;
      this.trackBarMaxSegmentCount.ValueChanged += new System.EventHandler(this.trackBarMinSegmentLength_ValueChanged);
      // 
      // upDownTimeout
      // 
      this.upDownTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.upDownTimeout.Location = new System.Drawing.Point(6, 17);
      this.upDownTimeout.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
      this.upDownTimeout.Name = "upDownTimeout";
      this.upDownTimeout.Size = new System.Drawing.Size(64, 20);
      this.upDownTimeout.TabIndex = 8;
      this.upDownTimeout.ValueChanged += new System.EventHandler(this.upDownTimeout_ValueChanged);
      // 
      // upDownMaxSegmentCount
      // 
      this.upDownMaxSegmentCount.Location = new System.Drawing.Point(6, 19);
      this.upDownMaxSegmentCount.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
      this.upDownMaxSegmentCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.upDownMaxSegmentCount.Name = "upDownMaxSegmentCount";
      this.upDownMaxSegmentCount.Size = new System.Drawing.Size(64, 20);
      this.upDownMaxSegmentCount.TabIndex = 9;
      this.upDownMaxSegmentCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.upDownMaxSegmentCount.ValueChanged += new System.EventHandler(this.upDownMinSegmentLength_ValueChanged);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.upDownTimeout);
      this.groupBox1.Controls.Add(this.trackBarTimeout);
      this.groupBox1.Location = new System.Drawing.Point(12, 29);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(324, 68);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Timeout, ms";
      // 
      // groupBox2
      // 
      this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox2.Controls.Add(this.upDownMaxSegmentCount);
      this.groupBox2.Controls.Add(this.trackBarMaxSegmentCount);
      this.groupBox2.Location = new System.Drawing.Point(12, 103);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(324, 68);
      this.groupBox2.TabIndex = 13;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Max segment count";
      // 
      // ListForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(348, 316);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.buttonRecognize);
      this.Controls.Add(this.bindingNavigator);
      this.Controls.Add(this.dataGridView);
      this.Name = "ListForm";
      this.Text = "Gesture Levenshtein";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListForm_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
      this.bindingNavigator.ResumeLayout(false);
      this.bindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTimeout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarMaxSegmentCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownTimeout)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.upDownMaxSegmentCount)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.BindingSource bindingSource;
    private System.Windows.Forms.BindingNavigator bindingNavigator;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.Button buttonRecognize;
    private System.Windows.Forms.TrackBar trackBarTimeout;
    private System.Windows.Forms.TrackBar trackBarMaxSegmentCount;
    private System.Windows.Forms.NumericUpDown upDownTimeout;
    private System.Windows.Forms.NumericUpDown upDownMaxSegmentCount;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
    private System.Windows.Forms.DataGridViewTextBoxColumn GestureName;

  }
}