using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ViewNote : Form
    {
        public ViewNote()
        {
            InitializeComponent();

            viewSubjectListBox.DataSource = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\subjects.txt").ToList();

        }

        private void viewSubjectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> notes = new List<string>();
            List<string> dates = new List<string>();

            notes = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\notes.txt").ToList();
            dates = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\dates.txt").ToList();

            viewNoteBox.Text = notes[viewSubjectListBox.SelectedIndex];
            viewDateBox.Text = dates[viewSubjectListBox.SelectedIndex];
            

           

        }
    }
}
