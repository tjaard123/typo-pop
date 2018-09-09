using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Typo_PoP
{
	public class Custom : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.ComponentModel.Container components = null;

		public Custom()
		{
			InitializeComponent();
			
			string[] files = Directory.GetFiles ( "Custom" );
			for ( int i = 0; i < files.Length; i++ )
			{
				int n = files[i].LastIndexOf ( '\\' );
				files[i] = files[i].Substring ( n + 1 );
				listBox1.Items.Add ( files[i] );
			}
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(8, 32);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(144, 212);
			this.listBox1.TabIndex = 0;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Available word files:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Word files to be used:";
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox2.ItemHeight = 16;
			this.listBox2.Location = new System.Drawing.Point(168, 80);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(160, 68);
			this.listBox2.TabIndex = 3;
			this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 24);
			this.button1.TabIndex = 4;
			this.button1.Text = "Edit custom word files";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 192);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(160, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(168, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "Doubleclick to add/remove";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Custom
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(336, 254);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Custom";
			this.Text = "Choose custom word files";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show ( "Enter the words beneath one another, in one single column.\nMax words = 50, Max characters = 13",
				"Editing custom words", MessageBoxButtons.OK, MessageBoxIcon.Information );
			System.Diagnostics.Process.Start ( "notepad", "Custom//custom.txt" );
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if ( listBox2.Items.Count != 4 )
				MessageBox.Show ( "You must choose 4 word files for each level",
					"Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			else	
			{
				for ( int i = 0; i < 4; i++ )
					Words.customWordFiles[i] = "Custom\\" + listBox2.Items[i];
				this.Close();
			}
		
		}

		private void listBox1_DoubleClick(object sender, System.EventArgs e)
		{			
			listBox2.Items.Add ( listBox1.SelectedItem );
			if ( listBox2.Items.Count >= 4 )
				listBox1.Enabled = false;
		}

		private void listBox2_DoubleClick(object sender, System.EventArgs e)
		{			
			listBox2.Items.Remove ( listBox2.SelectedItem );
			if ( listBox2.Items.Count <= 4 )
				listBox1.Enabled = true;
		}
	}
}
