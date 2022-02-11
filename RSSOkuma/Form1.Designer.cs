
namespace RSSOkuma
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btngetir = new System.Windows.Forms.Button();
            this.lsthaberler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSS URL";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(117, 40);
            this.txturl.Multiline = true;
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(311, 31);
            this.txturl.TabIndex = 1;
            this.txturl.Text = "https://www.haberturk.com/rss/ekonomi.xml";
            // 
            // btngetir
            // 
            this.btngetir.Location = new System.Drawing.Point(468, 43);
            this.btngetir.Name = "btngetir";
            this.btngetir.Size = new System.Drawing.Size(86, 30);
            this.btngetir.TabIndex = 2;
            this.btngetir.Text = "GETİR";
            this.btngetir.UseVisualStyleBackColor = true;
            this.btngetir.Click += new System.EventHandler(this.btngetir_Click);
            // 
            // lsthaberler
            // 
            this.lsthaberler.FormattingEnabled = true;
            this.lsthaberler.ItemHeight = 16;
            this.lsthaberler.Location = new System.Drawing.Point(10, 31);
            this.lsthaberler.Name = "lsthaberler";
            this.lsthaberler.Size = new System.Drawing.Size(416, 388);
            this.lsthaberler.TabIndex = 4;
            this.lsthaberler.SelectedIndexChanged += new System.EventHandler(this.lsthaberler_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsthaberler);
            this.groupBox1.Location = new System.Drawing.Point(43, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 443);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Haber Başlıkları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(528, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 443);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haberler";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(352, 422);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btngetir);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSS OKUMA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btngetir;
        private System.Windows.Forms.ListBox lsthaberler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

