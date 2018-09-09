using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Typo_PoP
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel barPanel;
		private System.Windows.Forms.TextBox typoTextBox;
		private System.Windows.Forms.Timer timerLane1;
		private System.Windows.Forms.Timer timerPop;
		private System.Windows.Forms.Timer timerLane2;
		private System.Windows.Forms.Timer timerLane3;
		private System.Windows.Forms.Timer timerLane4;
		private System.Windows.Forms.Timer timerLane5;
		private System.Windows.Forms.Timer MainTimer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Timer timerLane6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Timer startTimer;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			InitializeComponent();			
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.barPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.typoTextBox = new System.Windows.Forms.TextBox();
			this.timerLane1 = new System.Windows.Forms.Timer(this.components);
			this.timerPop = new System.Windows.Forms.Timer(this.components);
			this.timerLane2 = new System.Windows.Forms.Timer(this.components);
			this.timerLane3 = new System.Windows.Forms.Timer(this.components);
			this.timerLane4 = new System.Windows.Forms.Timer(this.components);
			this.timerLane5 = new System.Windows.Forms.Timer(this.components);
			this.MainTimer = new System.Windows.Forms.Timer(this.components);
			this.timerLane6 = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.startTimer = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label = new System.Windows.Forms.Label();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.barPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem3,
																					  this.menuItem4});
			this.menuItem1.Text = "Game";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem8,
																					  this.menuItem9});
			this.menuItem2.Text = "New";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 0;
			this.menuItem8.Text = "Recorded";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.Text = "Custom";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.Text = "Stop";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "Highscores";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 3;
			this.menuItem10.Text = "-";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 4;
			this.menuItem11.Text = "Options";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 5;
			this.menuItem3.Text = "-";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 6;
			this.menuItem4.Text = "Exit";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(984, 376);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
			// 
			// barPanel
			// 
			this.barPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.barPanel.BackColor = System.Drawing.Color.Gray;
			this.barPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barPanel.BackgroundImage")));
			this.barPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.barPanel.Controls.Add(this.label1);
			this.barPanel.Controls.Add(this.label4);
			this.barPanel.Controls.Add(this.label3);
			this.barPanel.Controls.Add(this.label2);
			this.barPanel.Controls.Add(this.typoTextBox);
			this.barPanel.Location = new System.Drawing.Point(0, 376);
			this.barPanel.Name = "barPanel";
			this.barPanel.Size = new System.Drawing.Size(984, 40);
			this.barPanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkRed;
			this.label1.Location = new System.Drawing.Point(840, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 22);
			this.label1.TabIndex = 6;
			this.label1.Text = "Interval: 2";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.LawnGreen;
			this.label4.Location = new System.Drawing.Point(584, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 22);
			this.label4.TabIndex = 5;
			this.label4.Text = "0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(176, 22);
			this.label3.TabIndex = 4;
			this.label3.Text = "Current Level: 1";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(320, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 22);
			this.label2.TabIndex = 3;
			this.label2.Text = "?";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// typoTextBox
			// 
			this.typoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.typoTextBox.BackColor = System.Drawing.Color.White;
			this.typoTextBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.typoTextBox.ForeColor = System.Drawing.Color.Brown;
			this.typoTextBox.Location = new System.Drawing.Point(376, 8);
			this.typoTextBox.Name = "typoTextBox";
			this.typoTextBox.Size = new System.Drawing.Size(206, 20);
			this.typoTextBox.TabIndex = 0;
			this.typoTextBox.Text = "";
			this.typoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.typoTextBox_KeyPress);
			// 
			// timerLane1
			// 
			this.timerLane1.Interval = 50;
			this.timerLane1.Tick += new System.EventHandler(this.timerLane1_Tick);
			// 
			// timerPop
			// 
			this.timerPop.Interval = 50;
			this.timerPop.Tick += new System.EventHandler(this.timerPop_Tick);
			// 
			// timerLane2
			// 
			this.timerLane2.Interval = 50;
			this.timerLane2.Tick += new System.EventHandler(this.timerLane2_Tick);
			// 
			// timerLane3
			// 
			this.timerLane3.Interval = 50;
			this.timerLane3.Tick += new System.EventHandler(this.timerLane3_Tick);
			// 
			// timerLane4
			// 
			this.timerLane4.Interval = 50;
			this.timerLane4.Tick += new System.EventHandler(this.timerLane4_Tick);
			// 
			// timerLane5
			// 
			this.timerLane5.Interval = 50;
			this.timerLane5.Tick += new System.EventHandler(this.timerLane5_Tick);
			// 
			// MainTimer
			// 
			this.MainTimer.Interval = 3000;
			this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
			// 
			// timerLane6
			// 
			this.timerLane6.Interval = 50;
			this.timerLane6.Tick += new System.EventHandler(this.timerLane6_Tick);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label6.Location = new System.Drawing.Point(400, 320);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 40);
			this.label6.TabIndex = 2;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.Visible = false;
			// 
			// startTimer
			// 
			this.startTimer.Interval = 2000;
			this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 200);
			this.panel1.TabIndex = 3;
			this.panel1.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Done";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label);
			this.groupBox1.Controls.Add(this.trackBar3);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 152);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(160, 80);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(32, 23);
			this.label.TabIndex = 2;
			this.label.Text = "2";
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(8, 72);
			this.trackBar3.Maximum = 8;
			this.trackBar3.Minimum = 2;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(144, 45);
			this.trackBar3.TabIndex = 1;
			this.trackBar3.Value = 2;
			this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(184, 40);
			this.label9.TabIndex = 0;
			this.label9.Text = "Interval between balloons: (in seconds)";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DarkGray;
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(8, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(184, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Edit custom words";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 414);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.barPanel);
			this.Controls.Add(this.pictureBox1);
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Typo-PoP";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.barPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private Balloon[] balloons = new Balloon[6]; // Lane buffer

		// --- FACTORY variables
		// The offset for invalidating
		private int refreshOffsetHeight = 23;
		private int refreshOffsetWidth = 100;
		private int refreshOffsetX = 45;
		private int refreshOffsetY = 5;

		private byte balloonRiseAmount = 4; // Amount that balloons rise
		// --- End of FACTORY variables

		private bool youLoose = false;
	
		private int popDistance = 50; // Distance from top before balloon pops
		private byte level = 1; // Current level	
		private int balloonsPerLevel = 3; // Number of balloons for each level
		private int balloonsPopped; // Amount of baloons popped each level
		private int totalPopped = 0; // Total balloons popped for all levels
		private string[] wordFiles = new string[4]; // Where to get the words
		private int[] randomWordFileIndex; // To randomize the word files for each level

		#region Timer lane 1
		private byte direction1; // 0 = Left, 1 = Right
		private byte amount1;
		private byte count1 = 7;
		private void timerLane1_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[0].Frame.Y < popDistance )
			{								
				timerLane1.Enabled = false;
				popFrame = -1;
				popIndex = 0;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

		// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[0].Frame.X == 150 && amount1 != 0 )
			{
				direction1 = 0;
				count1 = 0;
			}
			if ( balloons[0].Frame.X == 110 && amount1 != 0 )
			{
				direction1 = 1;
				count1 = 0;
			}

			if ( count1 > 5 )
				amount1 = 1;
			else
			{
				amount1 = 0;
				count1++;
			}
		// ===========================================

			if ( direction1 == 0 )			
				balloons[0].setLocation ( balloons[0].Frame.X - amount1, 
					balloons[0].Frame.Y - balloonRiseAmount );			
			else 
				balloons[0].setLocation ( balloons[0].Frame.X + amount1, 
					balloons[0].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[0].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );
		}
		#endregion

		#region Timer lane 2
		private byte direction2; // 0 = Left, 1 = Right
		private byte amount2;
		private byte count2 = 7;
		private void timerLane2_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[1].Frame.Y < popDistance )
			{								
				timerLane2.Enabled = false;
				popFrame = -1;
				popIndex = 1;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

			// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[1].Frame.X == 290 && amount2 != 0 )
			{
				direction2 = 0;
				count2 = 0;
			}
			if ( balloons[1].Frame.X == 250 && amount2 != 0 )
			{
				direction2 = 1;
				count2 = 0;
			}

			if ( count2 > 5 )
				amount2 = 1;
			else
			{
				amount2 = 0;
				count2++;
			}
			// ===========================================

			if ( direction2 == 0 )			
				balloons[1].setLocation ( balloons[1].Frame.X - amount2, 
					balloons[1].Frame.Y - balloonRiseAmount );			
			else 
				balloons[1].setLocation ( balloons[1].Frame.X + amount2, 
					balloons[1].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[1].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );
		}
		#endregion

		#region Timer lane 3
		private byte direction3; // 0 = Left, 1 = Right
		private byte amount3;
		private byte count3 = 7;
		private void timerLane3_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[2].Frame.Y < popDistance )
			{								
				timerLane3.Enabled = false;
				popFrame = -1;
				popIndex = 2;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

			// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[2].Frame.X == 430 && amount3 != 0 )
			{
				direction3 = 0;
				count3 = 0;
			}
			if ( balloons[2].Frame.X == 390 && amount3 != 0 )
			{
				direction3 = 1;
				count3 = 0;
			}

			if ( count3 > 5 )
				amount3 = 1;
			else
			{
				amount3 = 0;
				count3++;
			}
			// ===========================================

			if ( direction3 == 0 )			
				balloons[2].setLocation ( balloons[2].Frame.X - amount3, 
					balloons[2].Frame.Y - balloonRiseAmount );			
			else 
				balloons[2].setLocation ( balloons[2].Frame.X + amount3, 
					balloons[2].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[2].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );	
		}
		#endregion

		#region Timer lane 4
		private byte direction4; // 0 = Left, 1 = Right
		private byte amount4;
		private byte count4 = 7;
		private void timerLane4_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[3].Frame.Y < popDistance )
			{								
				timerLane4.Enabled = false;
				popFrame = -1;
				popIndex = 3;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

			// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[3].Frame.X == 570 && amount4 != 0 )
			{
				direction4 = 0;
				count4 = 0;
			}
			if ( balloons[3].Frame.X == 530 && amount4 != 0 )
			{
				direction4 = 1;
				count4 = 0;
			}

			if ( count4 > 5 )
				amount4 = 1;
			else
			{
				amount4 = 0;
				count4++;
			}
			// ===========================================

			if ( direction4 == 0 )			
				balloons[3].setLocation ( balloons[3].Frame.X - amount4, 
					balloons[3].Frame.Y - balloonRiseAmount );			
			else 
				balloons[3].setLocation ( balloons[3].Frame.X + amount4, 
					balloons[3].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[3].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );	
		}
		#endregion

		#region Timer lane 5
		private byte direction5; // 0 = Left, 1 = Right
		private byte amount5;
		private byte count5 = 7;
		private void timerLane5_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[4].Frame.Y < popDistance )
			{								
				timerLane5.Enabled = false;
				popFrame = -1;
				popIndex = 4;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

			// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[4].Frame.X == 710 && amount5 != 0 )
			{
				direction5 = 0;
				count5 = 0;
			}
			if ( balloons[4].Frame.X == 670 && amount5 != 0 )
			{
				direction5 = 1;
				count5 = 0;
			}

			if ( count5 > 5 )
				amount5 = 1;
			else
			{
				amount5 = 0;
				count5++;
			}
			// ===========================================

			if ( direction5 == 0 )			
				balloons[4].setLocation ( balloons[4].Frame.X - amount5, 
					balloons[4].Frame.Y - balloonRiseAmount );			
			else 
				balloons[4].setLocation ( balloons[4].Frame.X + amount5, 
					balloons[4].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[4].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );
		}
		#endregion

		#region Timer lane 6
		private byte direction6; // 0 = Left, 1 = Right
		private byte amount6;
		private byte count6 = 7;
		private void timerLane6_Tick(object sender, System.EventArgs e)
		{
			if ( balloons[5].Frame.Y < popDistance )
			{								
				timerLane6.Enabled = false;
				popFrame = -1;
				popIndex = 5;
				timerPop.Enabled = true;
				youLoose = true;
				return;
			}

			// ========== MOVEMENT CALCULATIONS ==========
			if ( balloons[5].Frame.X == 850 && amount6 != 0 )
			{
				direction6 = 0;
				count6 = 0;
			}
			if ( balloons[5].Frame.X == 810 && amount6 != 0 )
			{
				direction6 = 1;
				count6 = 0;
			}

			if ( count6 > 5 )
				amount6 = 1;
			else
			{
				amount6 = 0;
				count6++;
			}
			// ===========================================

			if ( direction6 == 0 )			
				balloons[5].setLocation ( balloons[5].Frame.X - amount6, 
					balloons[5].Frame.Y - balloonRiseAmount );			
			else 
				balloons[5].setLocation ( balloons[5].Frame.X + amount6, 
					balloons[5].Frame.Y - balloonRiseAmount );
			
			Rectangle rectangle = balloons[5].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;
			pictureBox1.Invalidate ( rectangle );
		}
		#endregion

		#region New level
		private void newLevel ()
		{
			disableTimers();
			for ( int i = 0; i < balloons.Length; i++ )
				if ( balloons[i] != null )
					balloons[i] = null;
			pictureBox1.Invalidate();			

			Words.loadWordFile ( wordFiles [ randomWordFileIndex [ level - 1 ] ] );
			balloonsPerLevel = Words.amountOfWords;

			randomLanes = MyRandom.randomize ( 6, 6 );
			laneIndex = 0;

			string word = Words.nextWord();
			switch ( randomLanes [ laneIndex ] )
			{
				case 0: balloons[0] = new Balloon ( 130, pictureBox1.Height, word );
					timerLane1.Enabled = true;
					break;
				case 1: balloons[1] = new Balloon ( 270, pictureBox1.Height, word );
					timerLane2.Enabled = true;
					break;
				case 2: balloons[2] = new Balloon ( 410, pictureBox1.Height, word );
					timerLane3.Enabled = true;
					break;
				case 3: balloons[3] = new Balloon ( 550, pictureBox1.Height, word );
					timerLane4.Enabled = true;
					break;
				case 4: balloons[4] = new Balloon ( 690, pictureBox1.Height, word );
					timerLane5.Enabled = true;
					break;
				case 5: balloons[5] = new Balloon ( 830, pictureBox1.Height, word );
					timerLane6.Enabled = true;
					break;
			}
			laneIndex++;

			label2.Text = "" + balloonsPerLevel;
			balloonsPopped = 0;
			MainTimer.Enabled = true;
		}
		#endregion

		private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			for ( int i = 0; i < balloons.Length; i++ )
				if ( balloons[i] != null )
					balloons[i].draw ( e.Graphics );
		}

		#region Balloon pop animation
		private int popIndex;
		private int popFrame;	
		private void timerPop_Tick(object sender, System.EventArgs e)
		{		
			Rectangle rectangle = balloons [ popIndex ].Frame;
			rectangle.Height += refreshOffsetHeight;
			rectangle.Width += refreshOffsetWidth;
			rectangle.X -= refreshOffsetX;
			rectangle.Y -= refreshOffsetY;

			if ( popFrame == 2 )
			{
				timerPop.Enabled = false;	
				pictureBox1.Invalidate( rectangle );
				balloons [ popIndex ] = null;
				balloonsPopped++;
				totalPopped++;
				label2.Text = "" + ( balloonsPerLevel - balloonsPopped );
				label4.Text = "" + totalPopped;
				
				if ( youLoose )
					gameOver();
				else if ( balloonsPopped == balloonsPerLevel )
					if ( level >= 4 )
						gameCompleted();
					else
						nextLevel();								
				return;				
			}

			popFrame++;
			balloons[ popIndex ].pop ( popFrame );
			
			pictureBox1.Invalidate( rectangle );
		}
		#endregion

		#region Game over
		private void gameOver()
		{
			disableTimers();
			for ( int i = 0; i < balloons.Length; i++ )
				if ( balloons[i] != null )
					balloons[i] = null;
			pictureBox1.Invalidate();
			youLoose = false;
			totalPopped--;
			Highscores highscores = new Highscores();
			for ( int i = 0; i < 4; i++ )
			{
				int n = wordFiles[i].LastIndexOf ( '\\' );
				wordFiles[i] = wordFiles[i].Substring ( n + 1 );
			}
			string wordFilesUsed;
			if ( wordFiles[0] == "default**1" )
				wordFilesUsed = "default**1";
			else
			{
				wordFilesUsed = wordFiles[0] + ", " + 
					wordFiles[1] + ", " +
					wordFiles[2] + ", " +
					wordFiles[3];
			}
			highscores.calculate( totalPopped, MainTimer.Interval, wordFilesUsed );
			highscores.Show();
		}
		#endregion

		#region Game completed
		private void gameCompleted()
		{
			disableTimers();
			Highscores highscores = new Highscores();
			for ( int i = 0; i < 4; i++ )
			{
				int n = wordFiles[i].LastIndexOf ( '\\' );
				wordFiles[i] = wordFiles[i].Substring ( n + 1 );
			}
			string wordFilesUsed = wordFiles[0] + ", " + 
				wordFiles[1] + ", " +
				wordFiles[2] + ", " +
				wordFiles[3];
			highscores.calculate( totalPopped, MainTimer.Interval, wordFilesUsed );
			highscores.Show();
			pictureBox1.Invalidate();
		}
		#endregion

		#region Next level
		private void nextLevel()
		{
			level++;
			this.BackgroundImage = Image.FromFile ( "Images//level" + 
				level + ".bmp" );
			label6.Text = "LEVEL " + level;
			label6.Visible = true;
			popDistance += 130;
			label3.Text = "Current level: " + level;						
			startTimer.Enabled = true;
		}
		#endregion

		#region TextBox listener
		private void typoTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{			
			if ( e.KeyChar == 13 )
			{
				string str = typoTextBox.Text;
				str = str.ToUpper();
				for ( int i = 0; i < balloons.Length; i++ )
				{
					if ( balloons[i] != null )
					{
						if ( str.Equals ( balloons[i].Word ) )
						{
							switch ( i )
							{
								case 0: timerLane1.Enabled = false; 
									popIndex = 0;
									break;
								case 1: timerLane2.Enabled = false; 
									popIndex = 1;
									break;
								case 2: timerLane3.Enabled = false; 
									popIndex = 2;
									break;
								case 3: timerLane4.Enabled = false; 
									popIndex = 3;
									break;
								case 4: timerLane5.Enabled = false; 
									popIndex = 4;
									break;
								case 5: timerLane6.Enabled = false; 
									popIndex = 5;
									break;
							}
							popFrame = -1;
							timerPop.Enabled = true;
						}
					}
					typoTextBox.Text = "";
				}
			}
		}
		#endregion

		#region Main timer
		private int laneIndex;
		private int[] randomLanes = new int[6];
		private void MainTimer_Tick(object sender, System.EventArgs e)
		{
			string word = Words.nextWord();
			if ( word == "-" )
			{
				MainTimer.Enabled = false;
				return;
			}

			switch ( randomLanes [ laneIndex ] )
			{
				case 0: balloons[0] = new Balloon ( 130, pictureBox1.Height, word );
					timerLane1.Enabled = true;
					break;
				case 1: balloons[1] = new Balloon ( 270, pictureBox1.Height, word );
					timerLane2.Enabled = true;
					break;
				case 2: balloons[2] = new Balloon ( 410, pictureBox1.Height, word );
					timerLane3.Enabled = true;
					break;
				case 3: balloons[3] = new Balloon ( 550, pictureBox1.Height, word );
					timerLane4.Enabled = true;
					break;
				case 4: balloons[4] = new Balloon ( 690, pictureBox1.Height, word );
					timerLane5.Enabled = true;
					break;
				case 5: balloons[5] = new Balloon ( 830, pictureBox1.Height, word );
					timerLane6.Enabled = true;
					break;
			}

			laneIndex = ( laneIndex + 1 ) % 6;
		}
		#endregion

		#region New recorded Game
		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			setToDefaults();

			wordFiles[0] = "default**1";
			wordFiles[1] = "default**2";
			wordFiles[2] = "default**3";
			wordFiles[3] = "default**4";			
			startTimer.Enabled = true;
		}
		#endregion

		#region Custom Game
		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			try
			{
				for ( int i = 0; i < 4; i++ )
					if ( Words.customWordFiles[i] == null )
						wordFiles[i] = "Custom\\custom.txt";
					else
						wordFiles[i] = Words.customWordFiles[i];

				setToDefaults();
				startTimer.Enabled = true;
			}
			catch ( Exception exception )
			{
				MessageBox.Show ( exception + "" );
			}
		}
		#endregion

		#region Set to defaults for the start of a brand new Game
		private void setToDefaults()
		{
			randomWordFileIndex = MyRandom.randomize ( 4, 4 );
			typoTextBox.Select();
			this.BackgroundImage = Image.FromFile ( "Images//level1.bmp" );
			level = 1;
			totalPopped = 0;
			popDistance = 50;
			label3.Text = "Current level: 1";
			label4.Text = "0";
			label6.Text = "LEVEL " + level;
			label6.Visible = true;
			MainTimer.Interval = ( int ) ( trackBar3.Value ) * 1000;
			youLoose = false;
		}
		#endregion

		private void startTimer_Tick(object sender, System.EventArgs e)
		{
			label6.Visible = false;
			startTimer.Enabled = false;
			newLevel();
		}

		private void disableTimers()
		{
			MainTimer.Enabled = false;
			timerLane1.Enabled = false;
			timerLane2.Enabled = false;
			timerLane3.Enabled = false;
			timerLane4.Enabled = false;
			timerLane5.Enabled = false;
			timerLane6.Enabled = false;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			disableTimers();
			label6.Visible = false;
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			Highscores highscores = new Highscores();			
			highscores.Show();
			highscores.updateHighscores();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			panel1.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			panel1.Hide();
		}

		private void trackBar3_Scroll(object sender, System.EventArgs e)
		{
			label.Text = "" + trackBar3.Value;
			label1.Text = "Interval: " + trackBar3.Value;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Custom fileChooser = new Custom();
			fileChooser.Show();
		}
	}
}
