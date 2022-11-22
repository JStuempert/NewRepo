using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Xml.Linq;

namespace NoteTaker2
{
    internal class Note
    {
        public string? Subject;
        public string? Body;
        public DateTime Date;



        public Note(string subject, string body, DateTime date)
        {
            Subject = subject;
            Body = body;
            Date = date;

        }


        public void SaveNote()
        {

            List<string> subjectList = new List<string>();
            List<string> bodyList = new List<string>();
            List<string> dateList = new List<string>();

            subjectList.Add(Subject);
            bodyList.Add(Body);
            dateList.Add(Date.ToString());

            File.AppendAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\subjects.txt", subjectList);
            File.AppendAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\notes.txt", bodyList);
            File.AppendAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\dates.txt", dateList);

            var message = MessageBox.Show("Note has been saved!", "Confirmation", MessageBoxButtons.OK);


        }

        public void DeleteNote()
        {
            List<string> oldSubjects = new List<string>();
            List<string> newSubjects = new List<string>();  
            
            oldSubjects = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\subjects.txt").ToList();
            oldSubjects.Remove(Subject);
            newSubjects = oldSubjects;

            File.WriteAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\subjects.txt", newSubjects);

            List<string> oldNotes = new List<string>();
            List<string> newNotes = new List<string>();

            oldNotes = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\notes.txt").ToList();
            oldNotes.Remove(Body);
            newNotes = oldNotes;

            File.WriteAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\notes.txt", newNotes);


            List<string> oldDates = new List<string>();
            List<string> newDates = new List<string>();


            oldDates = File.ReadAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\dates.txt").ToList();
            oldDates.Remove(Date.ToString());
            newDates = oldDates;

            File.WriteAllLines("C:\\Users\\jstue\\source\\repos\\NoteTaker2\\NoteTaker2\\txt\\dates.txt", newDates);


        }
    }
}
