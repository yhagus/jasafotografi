namespace jasafotografi
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.IDBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Loginbutt = new System.Windows.Forms.Button();
            this.ResetButt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.Window;
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Location = new System.Drawing.Point(30, 269);
            this.IDBox.MaxLength = 5;
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(320, 20);
            this.IDBox.TabIndex = 0;
            this.IDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label1.Location = new System.Drawing.Point(32, 245);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 13);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Silahkan Input ID";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Loginbutt
            // 
            this.Loginbutt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Loginbutt.FlatAppearance.BorderSize = 0;
            this.Loginbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutt.ForeColor = System.Drawing.SystemColors.Window;
            this.Loginbutt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Loginbutt.Location = new System.Drawing.Point(270, 323);
            this.Loginbutt.Name = "Loginbutt";
            this.Loginbutt.Size = new System.Drawing.Size(80, 26);
            this.Loginbutt.TabIndex = 2;
            this.Loginbutt.Text = "Login";
            this.Loginbutt.UseVisualStyleBackColor = false;
            this.Loginbutt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetButt
            // 
            this.ResetButt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButt.FlatAppearance.BorderSize = 0;
            this.ResetButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButt.ForeColor = System.Drawing.Color.Maroon;
            this.ResetButt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ResetButt.Location = new System.Drawing.Point(166, 323);
            this.ResetButt.Name = "ResetButt";
            this.ResetButt.Size = new System.Drawing.Size(80, 26);
            this.ResetButt.TabIndex = 3;
            this.ResetButt.Text = "Clear";
            this.ResetButt.UseVisualStyleBackColor = false;
            this.ResetButt.Click += new System.EventHandler(this.ResetButt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(83, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Photosintesis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(162, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(-8, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 173);
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(144, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Developed by PPE";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 384);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ResetButt);
            this.Controls.Add(this.Loginbutt);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Loginbutt;
        private System.Windows.Forms.Button ResetButt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

