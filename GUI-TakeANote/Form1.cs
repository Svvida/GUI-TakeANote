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
    public partial class btnNewNote : Form
    {
        public btnNewNote()
        {
            InitializeComponent();
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            DialogResult btnNewNoteResult = MessageBox.Show("Do you want to create a new note?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (btnNewNoteResult == DialogResult.Yes)
            {
                formCreateNewNote Form2 = new formCreateNewNote();
                Form2.ShowDialog();
            } 
        }

        private void btnNewNote_Load(object sender, EventArgs e)
        {

        }

        private void toolBar1_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {

        }
    }
}
