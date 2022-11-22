using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void newNoteBtn_Click(object sender, EventArgs e)
        {
            NewNote newNoteForm = new NewNote();
            newNoteForm.Show();
        }

        private void viewNotesBtn_Click(object sender, EventArgs e)
        {
            ViewNote viewNote = new ViewNote();
            viewNote.Show();
        }

        private void editNotesBtn_Click(object sender, EventArgs e)
        {
            EditNote editNote = new EditNote();
            editNote.Show();
        }
    }
}
