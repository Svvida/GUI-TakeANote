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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreateNewNote));
            this.lblNewNoteTitle = new System.Windows.Forms.Label();
            this.lblNewNoteDescription = new System.Windows.Forms.Label();
            this.txtboxNewNoteTitle = new System.Windows.Forms.TextBox();
            this.txtboxNewNoteDesc = new System.Windows.Forms.TextBox();
            this.btnNewNoteSave = new System.Windows.Forms.Button();
            this.btnNewNoteCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewNoteTitle
            // 
            resources.ApplyResources(this.lblNewNoteTitle, "lblNewNoteTitle");
            this.lblNewNoteTitle.Name = "lblNewNoteTitle";
            // 
            // lblNewNoteDescription
            // 
            resources.ApplyResources(this.lblNewNoteDescription, "lblNewNoteDescription");
            this.lblNewNoteDescription.Name = "lblNewNoteDescription";
            // 
            // txtboxNewNoteTitle
            // 
            resources.ApplyResources(this.txtboxNewNoteTitle, "txtboxNewNoteTitle");
            this.txtboxNewNoteTitle.Name = "txtboxNewNoteTitle";
            // 
            // txtboxNewNoteDesc
            // 
            resources.ApplyResources(this.txtboxNewNoteDesc, "txtboxNewNoteDesc");
            this.txtboxNewNoteDesc.Name = "txtboxNewNoteDesc";
            // 
            // btnNewNoteSave
            // 
            resources.ApplyResources(this.btnNewNoteSave, "btnNewNoteSave");
            this.btnNewNoteSave.Name = "btnNewNoteSave";
            this.btnNewNoteSave.UseVisualStyleBackColor = true;
            this.btnNewNoteSave.Click += new System.EventHandler(this.btnNewNoteSave_Click);
            // 
            // btnNewNoteCancel
            // 
            resources.ApplyResources(this.btnNewNoteCancel, "btnNewNoteCancel");
            this.btnNewNoteCancel.Name = "btnNewNoteCancel";
            this.btnNewNoteCancel.UseVisualStyleBackColor = true;
            this.btnNewNoteCancel.Click += new System.EventHandler(this.btnNewNoteCancel_Click);
            // 
            // formCreateNewNote
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.btnNewNoteCancel);
            this.Controls.Add(this.btnNewNoteSave);
            this.Controls.Add(this.txtboxNewNoteDesc);
            this.Controls.Add(this.txtboxNewNoteTitle);
            this.Controls.Add(this.lblNewNoteDescription);
            this.Controls.Add(this.lblNewNoteTitle);
            this.Name = "formCreateNewNote";
            this.Load += new System.EventHandler(this.formCreateNewNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewNoteTitle;
        private System.Windows.Forms.Label lblNewNoteDescription;
        private System.Windows.Forms.TextBox txtboxNewNoteTitle;
        private System.Windows.Forms.TextBox txtboxNewNoteDesc;
        private System.Windows.Forms.Button btnNewNoteSave;
        private System.Windows.Forms.Button btnNewNoteCancel;
    }
}