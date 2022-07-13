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
            this.lb6 = new System.Windows.Forms.Label();
            this.reward = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.dpDateLost = new System.Windows.Forms.DateTimePicker();
            this.dpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridSearch = new System.Windows.Forms.DataGridView();
            this.btnScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.Window;
            this.lb1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb1.Location = new System.Drawing.Point(18, 72);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(57, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Full Name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(92, 69);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 20);
            this.name.TabIndex = 1;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.SystemColors.Window;
            this.lb3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb3.Location = new System.Drawing.Point(18, 129);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(53, 13);
            this.lb3.TabIndex = 2;
            this.lb3.Text = "Item Lost:";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.SystemColors.Window;
            this.lb5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb5.Location = new System.Drawing.Point(18, 182);
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
            this.lb2.Location = new System.Drawing.Point(18, 101);
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
            this.lb4.Location = new System.Drawing.Point(18, 159);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(58, 13);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "What time:";
            // 
            // contact
            // 
            this.contact.Location = new System.Drawing.Point(92, 98);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(200, 20);
            this.contact.TabIndex = 7;
            // 
            // item
            // 
            this.item.Location = new System.Drawing.Point(92, 126);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(200, 20);
            this.item.TabIndex = 8;
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(92, 200);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(200, 20);
            this.place.TabIndex = 9;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.SystemColors.Window;
            this.lb6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb6.Location = new System.Drawing.Point(18, 225);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(95, 13);
            this.lb6.TabIndex = 11;
            this.lb6.Text = "Reward (Optional);";
            // 
            // reward
            // 
            this.reward.Location = new System.Drawing.Point(92, 242);
            this.reward.Name = "reward";
            this.reward.Size = new System.Drawing.Size(200, 20);
            this.reward.TabIndex = 12;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(136, 268);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(106, 27);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "Submit";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // dpDateLost
            // 
            this.dpDateLost.CustomFormat = "dd/MM/yyyy";
            this.dpDateLost.Location = new System.Drawing.Point(92, 156);
            this.dpDateLost.Name = "dpDateLost";
            this.dpDateLost.Size = new System.Drawing.Size(200, 20);
            this.dpDateLost.TabIndex = 14;
            // 
            // dpSearch
            // 
            this.dpSearch.Location = new System.Drawing.Point(332, 25);
            this.dpSearch.Name = "dpSearch";
            this.dpSearch.Size = new System.Drawing.Size(252, 20);
            this.dpSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(470, 270);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 27);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridSearch
            // 
            this.gridSearch.AllowUserToAddRows = false;
            this.gridSearch.AllowUserToDeleteRows = false;
            this.gridSearch.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearch.Location = new System.Drawing.Point(332, 69);
            this.gridSearch.Name = "gridSearch";
            this.gridSearch.ReadOnly = true;
            this.gridSearch.Size = new System.Drawing.Size(252, 193);
            this.gridSearch.TabIndex = 17;
            this.gridSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridSearch_CellContentClick);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(332, 270);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(114, 27);
            this.btnScan.TabIndex = 18;
            this.btnScan.Text = "Scan QR";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.button1_Click);
            // 
            // LF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(616, 301);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.gridSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dpSearch);
            this.Controls.Add(this.dpDateLost);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.reward);
            this.Controls.Add(this.lb6);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridSearch)).EndInit();
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
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.TextBox reward;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.DateTimePicker dpDateLost;
        private System.Windows.Forms.DateTimePicker dpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridSearch;
        private System.Windows.Forms.Button btnScan;
    }
}

