namespace PUP___Lost_and_Found
{
    partial class LF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LF));
            this.lb1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.item = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.reward = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.Window;
            this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Location = new System.Drawing.Point(22, 72);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(57, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Full Name:";
            this.lb1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(92, 69);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(111, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.SystemColors.Window;
            this.lb3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb3.Location = new System.Drawing.Point(22, 129);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(53, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Item Lost:";
            this.lb3.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.SystemColors.Window;
            this.lb5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb5.Location = new System.Drawing.Point(22, 182);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(89, 13);
            this.lb5.TabIndex = 4;
            this.lb5.Text = "Places I\'ve been:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.SystemColors.Window;
            this.lb2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb2.Location = new System.Drawing.Point(22, 101);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(64, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Contact No.";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.SystemColors.Window;
            this.lb4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb4.Location = new System.Drawing.Point(22, 158);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(58, 13);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "What time:";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(92, 98);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(111, 20);
            this.contact.TabIndex = 7;
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(92, 126);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(111, 20);
            this.item.TabIndex = 8;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(92, 201);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(111, 20);
            this.place.TabIndex = 9;
            this.place.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(92, 154);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(111, 20);
            this.time.TabIndex = 10;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.SystemColors.Window;
            this.lb6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb6.Location = new System.Drawing.Point(22, 229);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(95, 13);
            this.lb6.TabIndex = 11;
            this.lb6.Text = "Reward (Optional);";
            // 
            // reward
            // 
            this.reward.Location = new System.Drawing.Point(92, 249);
            this.reward.Name = "reward";
            this.reward.Size = new System.Drawing.Size(111, 20);
            this.reward.TabIndex = 12;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(301, 229);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 40);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "Submit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // LF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 289);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.reward);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.time);
            this.Controls.Add(this.place);
            this.Controls.Add(this.item);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.lb1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP Lost and Found";
            this.Load += new System.EventHandler(this.LF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox place;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox reward;
        private System.Windows.Forms.Button btn1;
    }
}

