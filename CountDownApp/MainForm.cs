/*
 * Created by SharpDevelop.
 * User: NA42051
 * Date: 25-06-2012
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CountDownApp
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		#region Variables
		
		private int Minitus = 0;
		private int Secendos =0;
		private bool IsResetPeriodOver = false;
		private bool IsPaused = false;
		
		#endregion
		
		public MainForm()
		{
			
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtNoOfMinTextChanged(object sender, EventArgs e)
		{
			int min  =0;
			if (!int.TryParse(txtNoOfMin.Text , out min))
			{
				txtNoOfMin.Text= "0";
				return;
			}
			Minitus  = min;
			calculateRemainingSecenods();
		}
		
		void calculateRemainingSecenods(){
			
			
			Secendos = Minitus  * 60 ;
			ShowTimeOnLabel();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			if (Secendos <= 0) 
			{
				//Pomodoro mode
				if (rdbPomodoro.Checked) {
					if (!IsResetPeriodOver) {
						
						this.notifyIcon1.ShowBalloonTip(3000 , "Get Rest now" ,"Get rest now" ,  ToolTipIcon.Info);
						Secendos = 600;
						IsResetPeriodOver = true;
					}
					else{
						this.notifyIcon1.ShowBalloonTip(3000 , "Gare up for next thing" ,"Check your next task" ,  ToolTipIcon.Info);
						this.WindowState = FormWindowState.Normal;
						timer1.Enabled=false;
						this.Text = "Count down timer app";
						return;
						
						
					}
					
				}
				else{
					
					
					this.notifyIcon1.ShowBalloonTip(3000 , "Times up" ,"Your times up" ,  ToolTipIcon.Info);
					this.WindowState = FormWindowState.Normal;
					timer1.Enabled=false;
					return;
				}
			}
			if (rdbPomodoro.Checked) {
				if (!IsResetPeriodOver) {
					if (Secendos == 1500) {
						this.Text  = "In a pomodoro";
					}
					
				}
				else{
				
						if (Secendos == 300) {
						this.Text  = "In a pomodoro rest mode";
					}
				
				}
			}
			
			if (chkLastMinitus.Checked) {
				
			
				
				if (Secendos == 600) {
					this.notifyIcon1.ShowBalloonTip(3000 , "Hurry up" ,"Only 10 minitus remaining" ,  ToolTipIcon.Info);
					
				}
				
				
				if (Secendos == 300) {
					this.notifyIcon1.ShowBalloonTip(3000 , "Hurry up" ,"Only 5 minitus remaining" ,  ToolTipIcon.Info);
					
				}
				
				if (Secendos == 120) {
					this.notifyIcon1.ShowBalloonTip(3000 , "Hurry up" ,"Only 2 minitus remaining" ,  ToolTipIcon.Info);
					
				}
				
				if (Secendos == 60) {
					this.notifyIcon1.ShowBalloonTip(3000 , "Hurry up" ,"Only 1 minit remaining" ,  ToolTipIcon.Info);
					
				}
				
			}
			Secendos = Secendos -1 ;
			ShowTimeOnLabel();

			
		}
		
		
		void ShowTimeOnLabel(){
			
			int min = 0;
			int sec = 0;
			
			min = Math.DivRem(Secendos , 60 ,out sec);
			
			lblRemainingtime.Text = min.ToString() + ":" + sec.ToString();
			
		}
		void BtnStartClick(object sender, EventArgs e)
		{
			if (IsPaused) {
				timer1.Enabled = true;
				return;	
			}
			TxtNoOfMinTextChanged(null , null);
			timer1.Enabled = true;
			
		}
		
		void BtnPauseClick(object sender, EventArgs e)
		{
			IsPaused = true;
			timer1.Enabled= false;
		}
		
		void BtnStopClick(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			Secendos = 0;
			Minitus = 0;
			txtNoOfMin.Text  ="0";
			lblRemainingtime.Text = "0";
		}
		
		void TxtNoOfMinLeave(object sender, EventArgs e)
		{
			
			int min  =0;
			if (!int.TryParse(txtNoOfMin.Text , out min))
			{
				txtNoOfMin.Text= "0";
				return;
			}
			Minitus  = min;
			calculateRemainingSecenods();
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			notifyIcon1.Text =  "Click to see time remaining. \nRight click to load more options.";
			
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) {
				this.ShowInTaskbar = false;
			}
			else{
				this.ShowInTaskbar = true;
			}

		}
		
		void NotifyIcon1Click(object sender, EventArgs e)
		{
			if (!timer1.Enabled) {
				this.notifyIcon1.ShowBalloonTip(3000 , "Timer stopped " ,"Timer not in action" ,  ToolTipIcon.None);
				return;
			}
			
			int min = 0;
			int sec = 0;
			
			min = Math.DivRem(Secendos , 60 ,out sec);
			
			this.notifyIcon1.ShowBalloonTip(3000 , "Time Remaining " , min + ":" + sec + " seconds are remaining." ,  ToolTipIcon.Info);
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if(rdbPomodoro.Checked){
				txtNoOfMin.Text =  "25";
				TxtNoOfMinTextChanged(null, null);
				IsResetPeriodOver = false;
				chkLastMinitus.Checked = false;
			}
		}
		
		void RadioButton2CheckedChanged(object sender, EventArgs e)
		{
			txtNoOfMin.Text =  "0";
			
		}
		
		void StartToolStripMenuItemClick(object sender, EventArgs e)
		{
			BtnStartClick(null , null);
		}
		
		void PauseToolStripMenuItemClick(object sender, EventArgs e)
		{
			BtnPauseClick(null , null);
		}
		
		void StopToolStripMenuItemClick(object sender, EventArgs e)
		{
			BtnStopClick(null, null);
		}
		
		void ShowToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			
		}
		
		void BtnHideClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
