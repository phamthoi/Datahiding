namespace steganography
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cau2_button = new System.Windows.Forms.Button();
            this.cau3_button = new System.Windows.Forms.Button();
            this.cau4_button = new System.Windows.Forms.Button();
            this.button_cau7 = new System.Windows.Forms.Button();
            this.button_cau5 = new System.Windows.Forms.Button();
            this.button_cau6 = new System.Windows.Forms.Button();
            this.button_cau8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(220, 498);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(146, 29);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BackColor = System.Drawing.Color.White;
            this.imagePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePictureBox.BackgroundImage")));
            this.imagePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagePictureBox.Location = new System.Drawing.Point(67, 12);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(406, 317);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 7;
            this.imagePictureBox.TabStop = false;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTextBox.Location = new System.Drawing.Point(67, 345);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(406, 136);
            this.dataTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(67, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Câu 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_button.Location = new System.Drawing.Point(129, 562);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(237, 38);
            this.load_button.TabIndex = 14;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(506, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 71);
            this.button5.TabIndex = 15;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cau2_button
            // 
            this.cau2_button.BackColor = System.Drawing.SystemColors.Control;
            this.cau2_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cau2_button.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cau2_button.Location = new System.Drawing.Point(171, 640);
            this.cau2_button.Name = "cau2_button";
            this.cau2_button.Size = new System.Drawing.Size(75, 23);
            this.cau2_button.TabIndex = 16;
            this.cau2_button.Text = "Câu 2";
            this.cau2_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cau2_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cau2_button.UseVisualStyleBackColor = false;
            this.cau2_button.Click += new System.EventHandler(this.cau2_button_Click);
            // 
            // cau3_button
            // 
            this.cau3_button.BackColor = System.Drawing.SystemColors.Control;
            this.cau3_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cau3_button.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cau3_button.Location = new System.Drawing.Point(291, 640);
            this.cau3_button.Name = "cau3_button";
            this.cau3_button.Size = new System.Drawing.Size(75, 23);
            this.cau3_button.TabIndex = 17;
            this.cau3_button.Text = "Câu 3";
            this.cau3_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cau3_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cau3_button.UseVisualStyleBackColor = false;
            this.cau3_button.Click += new System.EventHandler(this.cau3_button_Click);
            // 
            // cau4_button
            // 
            this.cau4_button.BackColor = System.Drawing.SystemColors.Control;
            this.cau4_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cau4_button.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cau4_button.Location = new System.Drawing.Point(398, 640);
            this.cau4_button.Name = "cau4_button";
            this.cau4_button.Size = new System.Drawing.Size(75, 23);
            this.cau4_button.TabIndex = 18;
            this.cau4_button.Text = "Câu 4";
            this.cau4_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cau4_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cau4_button.UseVisualStyleBackColor = false;
            this.cau4_button.Click += new System.EventHandler(this.cau4_button_Click);
            // 
            // button_cau7
            // 
            this.button_cau7.BackColor = System.Drawing.SystemColors.Control;
            this.button_cau7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cau7.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cau7.Location = new System.Drawing.Point(291, 694);
            this.button_cau7.Name = "button_cau7";
            this.button_cau7.Size = new System.Drawing.Size(75, 23);
            this.button_cau7.TabIndex = 19;
            this.button_cau7.Text = "Câu 7";
            this.button_cau7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cau7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_cau7.UseVisualStyleBackColor = false;
            this.button_cau7.Click += new System.EventHandler(this.button_cau7_Click);
            // 
            // button_cau5
            // 
            this.button_cau5.BackColor = System.Drawing.SystemColors.Control;
            this.button_cau5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cau5.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cau5.Location = new System.Drawing.Point(67, 694);
            this.button_cau5.Name = "button_cau5";
            this.button_cau5.Size = new System.Drawing.Size(75, 23);
            this.button_cau5.TabIndex = 20;
            this.button_cau5.Text = "Câu 5";
            this.button_cau5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cau5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_cau5.UseVisualStyleBackColor = false;
            this.button_cau5.Click += new System.EventHandler(this.button_cau5_Click);
            // 
            // button_cau6
            // 
            this.button_cau6.BackColor = System.Drawing.SystemColors.Control;
            this.button_cau6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cau6.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cau6.Location = new System.Drawing.Point(171, 694);
            this.button_cau6.Name = "button_cau6";
            this.button_cau6.Size = new System.Drawing.Size(75, 23);
            this.button_cau6.TabIndex = 21;
            this.button_cau6.Text = "Câu 6";
            this.button_cau6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cau6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_cau6.UseVisualStyleBackColor = false;
            this.button_cau6.Click += new System.EventHandler(this.button_cau6_Click);
            // 
            // button_cau8
            // 
            this.button_cau8.BackColor = System.Drawing.SystemColors.Control;
            this.button_cau8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cau8.Font = new System.Drawing.Font("Script MT Bold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cau8.Location = new System.Drawing.Point(398, 694);
            this.button_cau8.Name = "button_cau8";
            this.button_cau8.Size = new System.Drawing.Size(75, 23);
            this.button_cau8.TabIndex = 22;
            this.button_cau8.Text = "Câu 8";
            this.button_cau8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_cau8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_cau8.UseVisualStyleBackColor = false;
            this.button_cau8.Click += new System.EventHandler(this.button_cau8_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 770);
            this.Controls.Add(this.button_cau8);
            this.Controls.Add(this.button_cau6);
            this.Controls.Add(this.button_cau5);
            this.Controls.Add(this.button_cau7);
            this.Controls.Add(this.cau4_button);
            this.Controls.Add(this.cau3_button);
            this.Controls.Add(this.cau2_button);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.dataTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Button cau2_button;
        private System.Windows.Forms.Button cau3_button;
        private System.Windows.Forms.Button cau4_button;
        private System.Windows.Forms.Button button_cau7;
        private System.Windows.Forms.Button button_cau5;
        private System.Windows.Forms.Button button_cau6;
        private System.Windows.Forms.Button button_cau8;
    }
}