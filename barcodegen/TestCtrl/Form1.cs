using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestCtrl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private DSBarCode.BarCodeCtrl userControl11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			this.userControl11 = new DSBarCode.BarCodeCtrl();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// userControl11
			// 
			this.userControl11.BarCode = "1234567";
			this.userControl11.BarCodeHeight = 80;
			this.userControl11.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.userControl11.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.userControl11.HeaderFont = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.userControl11.HeaderText = "Header Text";
			this.userControl11.LeftMargin = 10;
			this.userControl11.Location = new System.Drawing.Point(8, 8);
			this.userControl11.Name = "userControl11";
			this.userControl11.ShowFooter = true;
			this.userControl11.ShowHeader = true;
			this.userControl11.Size = new System.Drawing.Size(336, 176);
			this.userControl11.TabIndex = 0;
			this.userControl11.TopMargin = 5;
			this.userControl11.VertAlign = DSBarCode.BarCodeCtrl.AlignType.Center;
			this.userControl11.Weight = DSBarCode.BarCodeCtrl.BarCodeWeight.Small;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 200);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "Print";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(88, 200);
			this.button2.Name = "button2";
			this.button2.TabIndex = 2;
			this.button2.Text = "Save";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(352, 229);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.userControl11);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click_1(object sender, System.EventArgs e)
		{
			this.userControl11.Print();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			userControl11.SaveImage("c:\\test.bmp");
		}
	}
}
