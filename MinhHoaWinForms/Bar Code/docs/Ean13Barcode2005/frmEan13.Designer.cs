namespace Ean13Barcode2005
{
	partial class frmEan13
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
            this.butDraw = new System.Windows.Forms.Button();
            this.butPrint = new System.Windows.Forms.Button();
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.txtManufacturerCode = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtChecksumDigit = new System.Windows.Forms.TextBox();
            this.cboScale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.butCreateBitmap = new System.Windows.Forms.Button();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // butDraw
            // 
            this.butDraw.Location = new System.Drawing.Point(170, 45);
            this.butDraw.Name = "butDraw";
            this.butDraw.Size = new System.Drawing.Size(100, 23);
            this.butDraw.TabIndex = 0;
            this.butDraw.Text = "Draw Barcode";
            this.butDraw.Click += new System.EventHandler(this.butDraw_Click);
            // 
            // butPrint
            // 
            this.butPrint.Location = new System.Drawing.Point(170, 88);
            this.butPrint.Name = "butPrint";
            this.butPrint.Size = new System.Drawing.Size(100, 23);
            this.butPrint.TabIndex = 1;
            this.butPrint.Text = "Print Barcode";
            this.butPrint.Click += new System.EventHandler(this.butPrint_Click);
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(292, 12);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(350, 249);
            this.picBarcode.TabIndex = 2;
            this.picBarcode.TabStop = false;
            // 
            // txtManufacturerCode
            // 
            this.txtManufacturerCode.Location = new System.Drawing.Point(13, 93);
            this.txtManufacturerCode.Name = "txtManufacturerCode";
            this.txtManufacturerCode.Size = new System.Drawing.Size(121, 20);
            this.txtManufacturerCode.TabIndex = 3;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(13, 141);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(121, 20);
            this.txtProductCode.TabIndex = 4;
            // 
            // txtChecksumDigit
            // 
            this.txtChecksumDigit.Location = new System.Drawing.Point(13, 187);
            this.txtChecksumDigit.Name = "txtChecksumDigit";
            this.txtChecksumDigit.Size = new System.Drawing.Size(121, 20);
            this.txtChecksumDigit.TabIndex = 6;
            // 
            // cboScale
            // 
            this.cboScale.FormattingEnabled = true;
            this.cboScale.Items.AddRange(new object[] {
            "0.8",
            "0.9",
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "2.0"});
            this.cboScale.Location = new System.Drawing.Point(170, 186);
            this.cboScale.Name = "cboScale";
            this.cboScale.Size = new System.Drawing.Size(100, 21);
            this.cboScale.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Country Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Manufacturer Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Checksum Digit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale Factor";
            // 
            // butCreateBitmap
            // 
            this.butCreateBitmap.Location = new System.Drawing.Point(170, 131);
            this.butCreateBitmap.Name = "butCreateBitmap";
            this.butCreateBitmap.Size = new System.Drawing.Size(100, 23);
            this.butCreateBitmap.TabIndex = 13;
            this.butCreateBitmap.Text = "Create Bitmap";
            this.butCreateBitmap.Click += new System.EventHandler(this.butCreateBitmap_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(13, 45);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(121, 20);
            this.txtCountryCode.TabIndex = 14;
            // 
            // frmEan13
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(681, 280);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.butCreateBitmap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboScale);
            this.Controls.Add(this.txtChecksumDigit);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtManufacturerCode);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.butPrint);
            this.Controls.Add(this.butDraw);
            this.Name = "frmEan13";
            this.Text = "EAN13 Barcode 2005";
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button butDraw;
		private System.Windows.Forms.Button butPrint;
		private System.Windows.Forms.PictureBox picBarcode;
		private System.Windows.Forms.TextBox txtManufacturerCode;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.TextBox txtChecksumDigit;
		private System.Windows.Forms.ComboBox cboScale;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button butCreateBitmap;
		private System.Windows.Forms.TextBox txtCountryCode;
	}
}

