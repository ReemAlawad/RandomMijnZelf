using Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomMijnZelf
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();

        }
        private List<Studenten> studentList = Info.PopulateStudents();
        private List<Studenten> naRandom = new List<Studenten>();
        List<Studenten> randomStudent;
        Random random;
      
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in studentList)
            {
                lstAllStudents.Items.Add(item);

            }

        }
       
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            #region voor mee
            //random = new Random();
            //if(int.TryParse(textBox1.Text, out int count) && count > 0 && count <4)
            //{
            //    List<Studenten> randomStudent = GetStudentens(count);
            //    lstGroup.Items.Clear();
            //    foreach (var item in randomStudent)
            //    {
            //        lstGroup.Items.Add(item);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Enter numer tussen 0 en 4 aub","error" );
            //   // naRandom.AddRange(randomStudent);
            //}
            #endregion

            lstGroup.Items.Clear();
            List<Studenten> randomisedGroup = Info.RandomisedGroup(studentList, int.Parse(textBox1.Text));
            foreach (var student in randomisedGroup)
            {
                lstGroup.Items.Add(student);
            }

        }
        #region voor me
        //private List<Studenten> GetStudentens(int count)
        //{
        //    List<Studenten> availableStudents = studentList.Except(naRandom).ToList();
        //    if(availableStudents.Count < count)
        //    {
        //        MessageBox.Show("Dit aantal studenten is niet beschikbaar");
        //        return new  List<Studenten>();
        //    }
        //     randomStudent = availableStudents.OrderBy(s => random.Next()).Take(count).ToList();
        //    naRandom.AddRange(randomStudent);
        //    return randomStudent;
        //}
        #endregion

    }
}
