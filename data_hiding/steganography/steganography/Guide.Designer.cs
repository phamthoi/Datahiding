namespace steganography
{
    partial class Guide
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
            this.txt = new System.Windows.Forms.TextBox();
            this.button_doc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(81, 48);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(501, 324);
            this.txt.TabIndex = 0;
            this.txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_doc
            // 
            this.button_doc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_doc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doc.Location = new System.Drawing.Point(629, 317);
            this.button_doc.Name = "button_doc";
            this.button_doc.Size = new System.Drawing.Size(84, 55);
            this.button_doc.TabIndex = 1;
            this.button_doc.Text = "Đọc";
            this.button_doc.UseVisualStyleBackColor = false;
            this.button_doc.Click += new System.EventHandler(this.button_doc_Click);
            // 
            // Guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 428);
            this.Controls.Add(this.button_doc);
            this.Controls.Add(this.txt);
            this.Name = "Guide";
            this.Text = "Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button button_doc;
    }
}