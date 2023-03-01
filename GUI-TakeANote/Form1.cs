using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TakeANote
{
    public partial class TakeANoteForm : Form
    {
        DataTable notes = new DataTable();
        bool editing = true;
        public TakeANoteForm()
        {
            InitializeComponent();
        }

        private void TakeANoteForm_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Description");

            viewNotes.DataSource = notes;

            DataRow inputNote = notes.NewRow();
        }
        private void viewNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelNote_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseTakeANote_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewNote_Click(object sender, EventArgs e)
        {
            //DialogResult btnNewNoteResult = MessageBox.Show("Do you want to create a new note?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (btnNewNoteResult == DialogResult.Yes)
            //{
            //    formCreateNewNote Form2 = new formCreateNewNote();
            //    Form2.ShowDialog();
            //}
            if (txtboxTitle.Text == "")
            {
                MessageBox.Show("Title or Description shouldn't be empty!");
            }
            else
            {
                notes.Rows.Add(txtboxTitle.Text, txtBoxDescription.Text);
            }
                

        }

        private void btnLoadNote_Click(object sender, EventArgs e)
        {

        }
    }
}
