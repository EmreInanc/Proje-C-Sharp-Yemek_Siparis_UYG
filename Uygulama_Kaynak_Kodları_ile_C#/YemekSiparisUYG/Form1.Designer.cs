﻿namespace YemekSiparisUYG
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.Listeler = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(292, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Vadi Yemek, Menüsü";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(98, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Dönerler";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(153, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "İskenderler";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(118, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tatlılar";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(162, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "İçecekler";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Location = new System.Drawing.Point(39, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(311, 236);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
			this.pictureBox1.Image = global::YemekSiparisUYG.Properties.Resources.döner;
			this.pictureBox1.Location = new System.Drawing.Point(50, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(199, 155);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Location = new System.Drawing.Point(611, 63);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(372, 236);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = " ";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Help;
			this.pictureBox2.Image = global::YemekSiparisUYG.Properties.Resources.iskender;
			this.pictureBox2.Location = new System.Drawing.Point(104, 19);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(185, 168);
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.pictureBox3);
			this.groupBox3.Location = new System.Drawing.Point(39, 346);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(311, 240);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = " ";
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Help;
			this.pictureBox3.Image = global::YemekSiparisUYG.Properties.Resources.tatlilar;
			this.pictureBox3.Location = new System.Drawing.Point(53, 13);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(219, 170);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.pictureBox4);
			this.groupBox4.Location = new System.Drawing.Point(611, 317);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(371, 240);
			this.groupBox4.TabIndex = 12;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = " ";
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Help;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(113, 14);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(207, 170);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(643, 592);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(199, 116);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(720, 566);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 20);
			this.label6.TabIndex = 14;
			this.label6.Text = "Sepet";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(221, 592);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(332, 116);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 15;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// Listeler
			// 
			this.Listeler.AutoSize = true;
			this.Listeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Listeler.Location = new System.Drawing.Point(356, 566);
			this.Listeler.Name = "Listeler";
			this.Listeler.Size = new System.Drawing.Size(60, 20);
			this.Listeler.TabIndex = 16;
			this.Listeler.Text = "Listeler";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(162, 320);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(218, 20);
			this.textBox1.TabIndex = 17;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(64, 323);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(92, 13);
			this.label7.TabIndex = 18;
			this.label7.Text = "Connection Strng ";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(386, 323);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 23);
			this.button1.TabIndex = 19;
			this.button1.Text = "🔒";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 738);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Listeler);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Yemek Siparişi Verin";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label Listeler;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
	}
}

