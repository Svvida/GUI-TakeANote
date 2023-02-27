namespace GUI_TakeANote
{
    partial class formCreateNewNote
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
            this.lblNewNoteTitle = new System.Windows.Forms.Label();
            this.lblNewNoteDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnNewNoteSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewNoteTitle
            // 
            this.lblNewNoteTitle.AutoSize = true;
            this.lblNewNoteTitle.Location = new System.Drawing.Point(20, 32);
            this.lblNewNoteTitle.Name = "lblNewNoteTitle";
            this.lblNewNoteTitle.Size = new System.Drawing.Size(30, 13);
            this.lblNewNoteTitle.TabIndex = 0;
            this.lblNewNoteTitle.Text = "Title:";
            // 
            // lblNewNoteDescription
            // 
            this.lblNewNoteDescription.AutoSize = true;
            this.lblNewNoteDescription.Location = new System.Drawing.Point(20, 63);
            this.lblNewNoteDescription.Name = "lblNewNoteDescription";
            this.lblNewNoteDescription.Size = new System.Drawing.Size(63, 13);
            this.lblNewNoteDescription.TabIndex = 1;
            this.lblNewNoteDescription.Text = "Description:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 63);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(251, 233);
            this.textBox2.TabIndex = 3;
            // 
            // btnNewNoteSave
            // 
            this.btnNewNoteSave.Location = new System.Drawing.Point(13, 272);
            this.btnNewNoteSave.Name = "btnNewNoteSave";
            this.btnNewNoteSave.Size = new System.Drawing.Size(75, 23);
            this.btnNewNoteSave.TabIndex = 4;
            this.btnNewNoteSave.Text = "Save";
            this.btnNewNoteSave.UseVisualStyleBackColor = true;
            this.btnNewNoteSave.Click += new System.EventHandler(this.btnNewNoteSave_Click);
            // 
            // formCreateNewNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 308);
            this.Controls.Add(this.btnNewNoteSave);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNewNoteDescription);
            this.Controls.Add(this.lblNewNoteTitle);
            this.Name = "formCreateNewNote";
            this.Text = "formCreateNewNote";
            this.Load += new System.EventHandler(this.formCreateNewNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewNoteTitle;
        private System.Windows.Forms.Label lblNewNoteDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnNewNoteSave;
    }
}