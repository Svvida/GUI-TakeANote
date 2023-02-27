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
    public partial class formCreateNewNote : Form
    {
        public formCreateNewNote()
        {
            InitializeComponent();
        }

        private void formCreateNewNote_Load(object sender, EventArgs e)
        {

        }

        private void btnNewNoteSave_Click(object sender, EventArgs e)
        {
            DialogResult resultSaveNewNote = MessageBox.Show("Do you want to save your note?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultSaveNewNote == DialogResult.Yes)
            {
                MessageBox.Show("Your note was saved succesfully!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Okey :(");
                this.Close();
            }
        }
    }
}
