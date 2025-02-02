/*
 * Created by SharpDevelop.
 * User: NA42051
 * Date: 25-06-2012
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CountDownApp
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.txtNoOfMin = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblRemainingtime = new System.Windows.Forms.Label();
      this.btnStart = new System.Windows.Forms.Button();
      this.btnPause = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rdbPomodoro = new System.Windows.Forms.RadioButton();
      this.rdbCountDown = new System.Windows.Forms.RadioButton();
      this.btnHide = new System.Windows.Forms.Button();
      this.chkLastMinitus = new System.Windows.Forms.CheckBox();
      this.btnGt = new System.Windows.Forms.Button();
      this.btnls = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lblTask = new System.Windows.Forms.Label();
      this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.noOfPomodorrowsReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.noOfPomodorrowPendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.taskIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnDelete = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // txtNoOfMin
      // 
      this.txtNoOfMin.Location = new System.Drawing.Point(241, 16);
      this.txtNoOfMin.Name = "txtNoOfMin";
      this.txtNoOfMin.Size = new System.Drawing.Size(39, 20);
      this.txtNoOfMin.TabIndex = 0;
      this.txtNoOfMin.Text = "0";
      this.txtNoOfMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtNoOfMin.TextChanged += new System.EventHandler(this.TxtNoOfMinTextChanged);
      this.txtNoOfMin.Leave += new System.EventHandler(this.TxtNoOfMinLeave);
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(112, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(108, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Number of minutes";
      // 
      // lblRemainingtime
      // 
      this.lblRemainingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRemainingtime.Location = new System.Drawing.Point(118, 42);
      this.lblRemainingtime.Name = "lblRemainingtime";
      this.lblRemainingtime.Size = new System.Drawing.Size(240, 36);
      this.lblRemainingtime.TabIndex = 2;
      this.lblRemainingtime.Text = "0";
      this.lblRemainingtime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(154, 81);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 3;
      this.btnStart.Text = "&Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
      // 
      // btnPause
      // 
      this.btnPause.Location = new System.Drawing.Point(229, 81);
      this.btnPause.Name = "btnPause";
      this.btnPause.Size = new System.Drawing.Size(75, 23);
      this.btnPause.TabIndex = 4;
      this.btnPause.Text = "&Pause";
      this.btnPause.UseVisualStyleBackColor = true;
      this.btnPause.Click += new System.EventHandler(this.BtnPauseClick);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(154, 106);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 5;
      this.btnStop.Text = "S&top";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.BtnStopClick);
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.Click += new System.EventHandler(this.NotifyIcon1Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.showToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(106, 92);
      // 
      // startToolStripMenuItem
      // 
      this.startToolStripMenuItem.Name = "startToolStripMenuItem";
      this.startToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.startToolStripMenuItem.Text = "Start";
      this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItemClick);
      // 
      // pauseToolStripMenuItem
      // 
      this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
      this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.pauseToolStripMenuItem.Text = "Pause";
      this.pauseToolStripMenuItem.Click += new System.EventHandler(this.PauseToolStripMenuItemClick);
      // 
      // stopToolStripMenuItem
      // 
      this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
      this.stopToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.stopToolStripMenuItem.Text = "Stop";
      this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItemClick);
      // 
      // showToolStripMenuItem
      // 
      this.showToolStripMenuItem.Name = "showToolStripMenuItem";
      this.showToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
      this.showToolStripMenuItem.Text = "Show";
      this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItemClick);
      // 
      // rdbPomodoro
      // 
      this.rdbPomodoro.Location = new System.Drawing.Point(248, 135);
      this.rdbPomodoro.Name = "rdbPomodoro";
      this.rdbPomodoro.Size = new System.Drawing.Size(104, 24);
      this.rdbPomodoro.TabIndex = 6;
      this.rdbPomodoro.Text = "Pomodoro";
      this.rdbPomodoro.UseVisualStyleBackColor = true;
      this.rdbPomodoro.CheckedChanged += new System.EventHandler(this.RadioButton1CheckedChanged);
      // 
      // rdbCountDown
      // 
      this.rdbCountDown.Checked = true;
      this.rdbCountDown.Location = new System.Drawing.Point(138, 135);
      this.rdbCountDown.Name = "rdbCountDown";
      this.rdbCountDown.Size = new System.Drawing.Size(104, 24);
      this.rdbCountDown.TabIndex = 7;
      this.rdbCountDown.TabStop = true;
      this.rdbCountDown.Text = "Count Down";
      this.rdbCountDown.UseVisualStyleBackColor = true;
      this.rdbCountDown.CheckedChanged += new System.EventHandler(this.RadioButton2CheckedChanged);
      // 
      // btnHide
      // 
      this.btnHide.Location = new System.Drawing.Point(229, 106);
      this.btnHide.Name = "btnHide";
      this.btnHide.Size = new System.Drawing.Size(75, 23);
      this.btnHide.TabIndex = 8;
      this.btnHide.Text = "&Hide";
      this.btnHide.UseVisualStyleBackColor = true;
      this.btnHide.Click += new System.EventHandler(this.BtnHideClick);
      // 
      // chkLastMinitus
      // 
      this.chkLastMinitus.Checked = true;
      this.chkLastMinitus.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkLastMinitus.Location = new System.Drawing.Point(154, 165);
      this.chkLastMinitus.Name = "chkLastMinitus";
      this.chkLastMinitus.Size = new System.Drawing.Size(161, 24);
      this.chkLastMinitus.TabIndex = 9;
      this.chkLastMinitus.Text = "Show Last-minute prompts ";
      this.chkLastMinitus.UseVisualStyleBackColor = true;
      // 
      // btnGt
      // 
      this.btnGt.Location = new System.Drawing.Point(275, 14);
      this.btnGt.Name = "btnGt";
      this.btnGt.Size = new System.Drawing.Size(29, 23);
      this.btnGt.TabIndex = 10;
      this.btnGt.Text = ">>";
      this.btnGt.UseVisualStyleBackColor = true;
      this.btnGt.Click += new System.EventHandler(this.btnGt_Click);
      // 
      // btnls
      // 
      this.btnls.Location = new System.Drawing.Point(213, 14);
      this.btnls.Name = "btnls";
      this.btnls.Size = new System.Drawing.Size(29, 23);
      this.btnls.TabIndex = 11;
      this.btnls.Text = "<<";
      this.btnls.UseVisualStyleBackColor = true;
      this.btnls.Click += new System.EventHandler(this.btnls_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AutoGenerateColumns = false;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.noOfPomodorrowsReqDataGridViewTextBoxColumn,
            this.noOfPomodorrowPendingDataGridViewTextBoxColumn,
            this.taskIdDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.taskBindingSource;
      this.dataGridView1.Location = new System.Drawing.Point(12, 219);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(438, 218);
      this.dataGridView1.TabIndex = 12;
      this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(13, 190);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(35, 23);
      this.btnAdd.TabIndex = 13;
      this.btnAdd.Text = "+";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblTask
      // 
      this.lblTask.AutoSize = true;
      this.lblTask.Location = new System.Drawing.Point(78, 199);
      this.lblTask.Name = "lblTask";
      this.lblTask.Size = new System.Drawing.Size(0, 13);
      this.lblTask.TabIndex = 14;
       // 
      // nameDataGridViewTextBoxColumn
      // 
      this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
      this.nameDataGridViewTextBoxColumn.Frozen = true;
      this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
      this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
      // 
      // descriptionDataGridViewTextBoxColumn
      // 
      this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
      this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
      this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
      // 
      // noOfPomodorrowsReqDataGridViewTextBoxColumn
      // 
      this.noOfPomodorrowsReqDataGridViewTextBoxColumn.DataPropertyName = "NoOfPomodorrowsReq";
      this.noOfPomodorrowsReqDataGridViewTextBoxColumn.HeaderText = "Pomodorrows";
      this.noOfPomodorrowsReqDataGridViewTextBoxColumn.Name = "noOfPomodorrowsReqDataGridViewTextBoxColumn";
      // 
      // noOfPomodorrowPendingDataGridViewTextBoxColumn
      // 
      this.noOfPomodorrowPendingDataGridViewTextBoxColumn.DataPropertyName = "NoOfPomodorrowPending";
      this.noOfPomodorrowPendingDataGridViewTextBoxColumn.HeaderText = "Remaining";
      this.noOfPomodorrowPendingDataGridViewTextBoxColumn.Name = "noOfPomodorrowPendingDataGridViewTextBoxColumn";
      // 
      // taskIdDataGridViewTextBoxColumn
      // 
      this.taskIdDataGridViewTextBoxColumn.DataPropertyName = "TaskId";
      this.taskIdDataGridViewTextBoxColumn.HeaderText = "TaskId";
      this.taskIdDataGridViewTextBoxColumn.Name = "taskIdDataGridViewTextBoxColumn";
      this.taskIdDataGridViewTextBoxColumn.Visible = false;
      // 
      // taskBindingSource
      // 
      this.taskBindingSource.DataSource = typeof(CountDownApp.Models.Task);
      // 
      // btnDelete
      // 
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(43, 190);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(35, 23);
      this.btnDelete.TabIndex = 15;
      this.btnDelete.Text = "X";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(450, 464);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.lblTask);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnls);
      this.Controls.Add(this.btnGt);
      this.Controls.Add(this.chkLastMinitus);
      this.Controls.Add(this.btnHide);
      this.Controls.Add(this.rdbCountDown);
      this.Controls.Add(this.rdbPomodoro);
      this.Controls.Add(this.lblRemainingtime);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnPause);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.txtNoOfMin);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Count Down timer app";
      this.Load += new System.EventHandler(this.MainFormLoad);
      this.Resize += new System.EventHandler(this.MainFormResize);
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkLastMinitus;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.RadioButton rdbCountDown;
		private System.Windows.Forms.RadioButton rdbPomodoro;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label lblRemainingtime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNoOfMin;
    private System.Windows.Forms.Button btnGt;
    private System.Windows.Forms.Button btnls;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.BindingSource taskBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noOfPomodorrowsReqDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noOfPomodorrowPendingDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn taskIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label lblTask;
    private System.Windows.Forms.Button btnDelete;
  }
}
