namespace PUP___Lost_and_Found
{
    partial class QRCodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCodeGenerator));
            this.btGenerate = new System.Windows.Forms.Button();
            this.pbGenerator = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerator)).BeginInit();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(91, 251);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(88, 23);
            this.btGenerate.TabIndex = 0;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbGenerator
            // 
            this.pbGenerator.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pbGenerator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbGenerator.Location = new System.Drawing.Point(12, 12);
            this.pbGenerator.Name = "pbGenerator";
            this.pbGenerator.Size = new System.Drawing.Size(251, 228);
            this.pbGenerator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGenerator.TabIndex = 2;
            this.pbGenerator.TabStop = false;
            this.pbGenerator.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // QRCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGenerator);
            this.Controls.Add(this.btGenerate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QRCodeGenerator";
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.QRCodeGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGenerator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.PictureBox pbGenerator;
        private System.Windows.Forms.Label label1;
    }
}

