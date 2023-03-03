namespace GUI_TakeANote
{
    partial class TakeANoteForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.btnLoadNote = new System.Windows.Forms.Button();
            this.viewNotes = new System.Windows.Forms.DataGridView();
            this.btnDelNote = new System.Windows.Forms.Button();
            this.btnCloseTakeANote = new System.Windows.Forms.Button();
            this.btnAddNewNote = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtboxTitle = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(100, 42);
            this.toolBar1.TabIndex = 0;
            // 
            // btnLoadNote
            // 
            this.btnLoadNote.Location = new System.Drawing.Point(19, 491);
            this.btnLoadNote.Name = "btnLoadNote";
            this.btnLoadNote.Size = new System.Drawing.Size(142, 64);
            this.btnLoadNote.TabIndex = 1;
            this.btnLoadNote.Text = "Load note";
            this.btnLoadNote.UseVisualStyleBackColor = true;
            this.btnLoadNote.Click += new System.EventHandler(this.btnLoadNote_Click);
            // 
            // viewNotes
            // 
            this.viewNotes.AllowUserToOrderColumns = true;
            this.viewNotes.AllowUserToResizeColumns = false;
            this.viewNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewNotes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.viewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewNotes.Location = new System.Drawing.Point(368, 143);
            this.viewNotes.Name = "viewNotes";
            this.viewNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.viewNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewNotes.Size = new System.Drawing.Size(350, 406);
            this.viewNotes.TabIndex = 2;
            this.viewNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewNotes_CellContentClick);
            // 
            // btnDelNote
            // 
            this.btnDelNote.Location = new System.Drawing.Point(217, 427);
            this.btnDelNote.Name = "btnDelNote";
            this.btnDelNote.Size = new System.Drawing.Size(142, 64);
            this.btnDelNote.TabIndex = 3;
            this.btnDelNote.Text = "Delete note";
            this.btnDelNote.UseVisualStyleBackColor = true;
            this.btnDelNote.Click += new System.EventHandler(this.btnDelNote_Click);
            // 
            // btnCloseTakeANote
            // 
            this.btnCloseTakeANote.Location = new System.Drawing.Point(217, 491);
            this.btnCloseTakeANote.Name = "btnCloseTakeANote";
            this.btnCloseTakeANote.Size = new System.Drawing.Size(142, 64);
            this.btnCloseTakeANote.TabIndex = 4;
            this.btnCloseTakeANote.Text = "Close";
            this.btnCloseTakeANote.UseVisualStyleBackColor = true;
            this.btnCloseTakeANote.Click += new System.EventHandler(this.btnCloseTakeANote_Click);
            // 
            // btnAddNewNote
            // 
            this.btnAddNewNote.Location = new System.Drawing.Point(19, 427);
            this.btnAddNewNote.Name = "btnAddNewNote";
            this.btnAddNewNote.Size = new System.Drawing.Size(142, 64);
            this.btnAddNewNote.TabIndex = 5;
            this.btnAddNewNote.Text = "Add new note";
            this.btnAddNewNote.UseVisualStyleBackColor = true;
            this.btnAddNewNote.Click += new System.EventHandler(this.btnAddNewNote_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(16, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(346, 17);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Title:";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(16, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(346, 17);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // txtboxTitle
            // 
            this.txtboxTitle.Location = new System.Drawing.Point(21, 33);
            this.txtboxTitle.Name = "txtboxTitle";
            this.txtboxTitle.Size = new System.Drawing.Size(340, 20);
            this.txtboxTitle.TabIndex = 8;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(19, 83);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(340, 338);
            this.txtBoxDescription.TabIndex = 9;
            this.txtBoxDescription.TextChanged += new System.EventHandler(this.txtBoxDescription_TextChanged);
            // 
            // TakeANoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(731, 561);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtboxTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnAddNewNote);
            this.Controls.Add(this.btnCloseTakeANote);
            this.Controls.Add(this.btnDelNote);
            this.Controls.Add(this.viewNotes);
            this.Controls.Add(this.btnLoadNote);
            this.Name = "TakeANoteForm";
            this.Text = "TakeANote";
            this.Load += new System.EventHandler(this.TakeANoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.Button btnLoadNote;
        private System.Windows.Forms.DataGridView viewNotes;
        private System.Windows.Forms.Button btnDelNote;
        private System.Windows.Forms.Button btnCloseTakeANote;
        private System.Windows.Forms.Button btnAddNewNote;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtboxTitle;
        private System.Windows.Forms.TextBox txtBoxDescription;
    }
}

