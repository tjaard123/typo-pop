using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Typo_PoP
{
	public class Highscores : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Panel panel1;

		private System.ComponentModel.Container components = null;

		public Highscores()
		{
			InitializeComponent();

			loadScores();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.RoyalBlue;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = " 1.";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.RoyalBlue;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(416, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = " 2.";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.RoyalBlue;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(8, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(416, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = " 3.";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.RoyalBlue;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(8, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(416, 24);
			this.label4.TabIndex = 4;
			this.label4.Text = " 4.";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.RoyalBlue;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(416, 24);
			this.label5.TabIndex = 5;
			this.label5.Text = " 5.";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.RoyalBlue;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(8, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(416, 24);
			this.label6.TabIndex = 6;
			this.label6.Text = " 6.";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.RoyalBlue;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(8, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(416, 24);
			this.label7.TabIndex = 7;
			this.label7.Text = " 7.";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.RoyalBlue;
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(8, 264);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(416, 24);
			this.label8.TabIndex = 8;
			this.label8.Text = " 8.";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.RoyalBlue;
			this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label9.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(8, 296);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(416, 24);
			this.label9.TabIndex = 9;
			this.label9.Text = " 9.";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.RoyalBlue;
			this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label10.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(8, 328);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(416, 24);
			this.label10.TabIndex = 10;
			this.label10.Text = " 10.";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.RoyalBlue;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(8, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(416, 24);
			this.label11.TabIndex = 11;
			this.label11.Text = "  RANK   NAME        BALLOONS    INTERVAL";
			// 
			// button3
			// 
			this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.button3.Location = new System.Drawing.Point(120, 56);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "OK";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label12.Location = new System.Drawing.Point(8, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(224, 32);
			this.label12.TabIndex = 1;
			this.label12.Text = "You have earned a ranking on the top ten! Please enter your name:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 56);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(104, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.Location = new System.Drawing.Point(8, 360);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Reset scores";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(8, 64);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(664, 432);
			this.tabControl1.TabIndex = 14;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(656, 404);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Recorded";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(80, 104);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 88);
			this.panel1.TabIndex = 14;
			this.panel1.Visible = false;
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.label14);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.label17);
			this.tabPage2.Controls.Add(this.label18);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.label21);
			this.tabPage2.Controls.Add(this.label22);
			this.tabPage2.Controls.Add(this.label23);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(656, 404);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Custom";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.RoyalBlue;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.White;
			this.label13.Location = new System.Drawing.Point(8, 72);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(1300, 24);
			this.label13.TabIndex = 15;
			this.label13.Text = " 2.";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.RoyalBlue;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(8, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(1300, 24);
			this.label14.TabIndex = 14;
			this.label14.Text = " 1.";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.Location = new System.Drawing.Point(8, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(144, 23);
			this.button2.TabIndex = 25;
			this.button2.Text = "Reset scores";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.RoyalBlue;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label15.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(8, 328);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(1300, 24);
			this.label15.TabIndex = 23;
			this.label15.Text = " 10.";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.RoyalBlue;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label16.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.White;
			this.label16.Location = new System.Drawing.Point(8, 8);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(1300, 24);
			this.label16.TabIndex = 24;
			this.label16.Text = "  RANK   NAME        BALLOONS    INTERVAL       WORDS";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.RoyalBlue;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label17.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.White;
			this.label17.Location = new System.Drawing.Point(8, 296);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(1300, 24);
			this.label17.TabIndex = 22;
			this.label17.Text = " 9.";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.RoyalBlue;
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label18.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.White;
			this.label18.Location = new System.Drawing.Point(8, 264);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(1300, 24);
			this.label18.TabIndex = 21;
			this.label18.Text = " 8.";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.RoyalBlue;
			this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label19.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.White;
			this.label19.Location = new System.Drawing.Point(8, 232);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(1300, 24);
			this.label19.TabIndex = 20;
			this.label19.Text = " 7.";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.RoyalBlue;
			this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label20.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.White;
			this.label20.Location = new System.Drawing.Point(8, 200);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(1300, 24);
			this.label20.TabIndex = 19;
			this.label20.Text = " 6.";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.RoyalBlue;
			this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label21.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.White;
			this.label21.Location = new System.Drawing.Point(8, 168);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(1300, 24);
			this.label21.TabIndex = 18;
			this.label21.Text = " 5.";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.RoyalBlue;
			this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label22.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(8, 136);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(1300, 24);
			this.label22.TabIndex = 17;
			this.label22.Text = " 4.";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.RoyalBlue;
			this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label23.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.White;
			this.label23.Location = new System.Drawing.Point(8, 104);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(1300, 24);
			this.label23.TabIndex = 16;
			this.label23.Text = " 3.";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.RoyalBlue;
			this.label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label24.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label24.Location = new System.Drawing.Point(16, 16);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(424, 40);
			this.label24.TabIndex = 15;
			this.label24.Text = "THE TOP TEN";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Highscores
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 502);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.tabControl1);
			this.Name = "Highscores";
			this.Opacity = 0.8;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TransparencyKey = System.Drawing.Color.Black;
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private int rankingIndex;
		private string wordFile;

		#region Highscore calculation
		private ArrayList recordedPlayers = new ArrayList(11);
		private ArrayList customPlayers = new ArrayList(11);
		private Player aPlayer;		
		public void calculate ( int totalPopped, int interval, string wordFile )
		{
			this.wordFile = wordFile;
			rankingIndex = -1;
			interval /= 1000;
			aPlayer = new Player ( totalPopped, interval, wordFile );
			if ( wordFile == "default**1" )
				for ( int i = 0; i < 10; i++ )
				{
					Player testPlayer = ( Player ) recordedPlayers[i];
					if ( testPlayer.rank <= aPlayer.rank )
					{	
						rankingIndex = i;
						break;
					}
				}
			else
				for ( int i = 0; i < 10; i++ )
				{
					Player testPlayer = ( Player ) customPlayers[i];
					if ( testPlayer.rank <= aPlayer.rank )
					{	
						rankingIndex = i;
						break;
					}
				}
			if ( rankingIndex != -1 )
			{
				textBox1.Select();
				panel1.Visible = true;
			}
			else
				updateHighscores();
		}

		public void updateHighscores()
		{
			Player showPlayer = ( Player ) recordedPlayers[0];
			label1.Text = "   1.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[1];
			label2.Text = "   2.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[2];
			label3.Text = "   3.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[3];
			label4.Text = "   4.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[4];
			label5.Text = "   5.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[5];
			label6.Text = "   6.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[6];
			label7.Text = "   7.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[7];
			label8.Text = "   8.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[8];
			label9.Text = "   9.    " + showPlayer.getPlayerInfo();
			showPlayer = ( Player ) recordedPlayers[9];
			label10.Text = "  10.    " + showPlayer.getPlayerInfo();

			showPlayer = ( Player ) customPlayers[0];
			label14.Text = "   1.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[1];
			label13.Text = "   2.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[2];
			label23.Text = "   3.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[3];
			label22.Text = "   4.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[4];
			label21.Text = "   5.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[5];
			label20.Text = "   6.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[6];
			label19.Text = "   7.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[7];
			label18.Text = "   8.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[8];
			label17.Text = "   9.    " + showPlayer.getCustomPlayerInfo();
			showPlayer = ( Player ) customPlayers[9];
			label15.Text = "  10.    " + showPlayer.getCustomPlayerInfo();
		}
		#endregion

		#region Insert a player
		private void insertPlayer()
		{
			panel1.Visible = false;
			aPlayer.PlayerName = textBox1.Text;
			if ( wordFile == "default**1" )
			{
				recordedPlayers.Insert ( rankingIndex, aPlayer );
				tabControl1.SelectedIndex = 0;
			}
			else
			{
				customPlayers.Insert ( rankingIndex, aPlayer );
				tabControl1.SelectedIndex = 1;
			}

			saveScores();
			updateHighscores();
		}
		#endregion

		#region HS.dat
		private void saveScores()
		{
			try
			{
				if ( customPlayers.Count > 9 )
					customPlayers.RemoveRange ( 10, customPlayers.Count - 10 );
				if ( recordedPlayers.Count > 9 )
					recordedPlayers.RemoveRange ( 10, recordedPlayers.Count - 10 );

				BinaryFormatter formatter = new BinaryFormatter();
				FileStream recorded = new FileStream ( "HS.dat", FileMode.Create, FileAccess.Write );
				FileStream custom = new FileStream ( "CustomHS.dat", FileMode.Create, FileAccess.Write );

				formatter.Serialize ( recorded, recordedPlayers );
				formatter.Serialize ( custom, customPlayers );

				recorded.Close();
				custom.Close();
			}
			catch ( Exception exception )
			{
				MessageBox.Show ( exception + "" );
			}
		}

		private void loadScores()
		{
			try
			{
				BinaryFormatter reader = new BinaryFormatter();
				FileStream recorded = new FileStream ( "HS.dat", FileMode.Open, FileAccess.Read );
				FileStream custom = new FileStream ( "CustomHS.dat", FileMode.Open, FileAccess.Read );

				recordedPlayers = ( ArrayList ) reader.Deserialize ( recorded );
				customPlayers = ( ArrayList ) reader.Deserialize ( custom );

				recorded.Close();
				custom.Close();
			}
			catch ( Exception exception )
			{
				MessageBox.Show ( exception + "" );
			}
		}

		private void resetScores( byte tabIndex )
		{
			if ( tabIndex == 0 )
			{
				recordedPlayers = new ArrayList ( 11 );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
				recordedPlayers.Add ( new Player() );
			}
			else
			{
				customPlayers = new ArrayList ( 11 );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
				customPlayers.Add ( new Player() );
			}
			saveScores();
			updateHighscores();			
		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if ( MessageBox.Show ( "Erase the Top Ten highest recorded scores?", "RESET", 
				MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation ) ==
				DialogResult.OK )
			{
				resetScores( 0 );
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if ( MessageBox.Show ( "Erase the Top Ten highest custom scores?", "RESET", 
				MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation ) ==
				DialogResult.OK )
			{
				resetScores( 1 );
			}
		}

		private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if ( e.KeyChar == 13 )	
				insertPlayer();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			insertPlayer();
		}
	}
}
