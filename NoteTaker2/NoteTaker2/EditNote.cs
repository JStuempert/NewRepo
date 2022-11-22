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
    public partial class EditNote : Form
    {
        public EditNote()
        {
            InitializeComponent();

            editSubjectListBox.DataSource = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\subjects.txt").ToList();
        }

        private void editSubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> notes = new List<string>();
            List<string> dates = new List<string>();

            notes = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\notes.txt").ToList();
            dates = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\dates.txt").ToList();

            editNoteBox.Text = notes[editSubjectListBox.SelectedIndex];
            editDateBox.Text = dates[editSubjectListBox.SelectedIndex];
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(editSubjectListBox.Text, editNoteBox.Text, DateTime.Now);

            newNote.DeleteNote();
            var message = MessageBox.Show("Note Deleted!", "Confirmation", MessageBoxButtons.OK);
            Hide();
        }

        private void EditNote_Load(object sender, EventArgs e)
        {

        }
    }
}
