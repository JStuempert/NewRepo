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
    public partial class NewNote : Form
    {
        public NewNote()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(subjectInputBox.Text, noteBodyInputBox.Text, noteDateTimePicker.Value);
            newNote.SaveNote();
            Hide();
        }

        private void subjectInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you want to discard this note?", "Message", MessageBoxButtons.YesNo);
            if (message == DialogResult.Yes)
            {
                Hide();
            }

        }
    }
}
