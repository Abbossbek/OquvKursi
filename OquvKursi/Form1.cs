using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OquvKursi.Models;
using System.IO;

namespace OquvKursi
{
    public partial class Form1 : Form
    {
        string file1 = "DataAbit.txt", file2 = "DataTeacher.txt", file3 = "DataCourse.txt", file4 = "DataSub.txt";
        public Form1()
        {
            InitializeComponent();
            DataRead();
        }

        void DataRead()
        {
            using (StreamReader sw = new StreamReader(file1))
            {
                string str;

                while ((str = sw.ReadLine()) != null)
                {
                    dgvAbiturient.Rows.Add(str.Split('#'));
                }
            }
            using (StreamReader sw = new StreamReader(file2))
            {
                string str;

                while ((str = sw.ReadLine()) != null)
                {
                    dgvTeacher.Rows.Add(str.Split('#'));
                }
            }
            using (StreamReader sw = new StreamReader(file3))
            {
                string str;

                while ((str = sw.ReadLine()) != null)
                {
                    dgvCourse.Rows.Add(str.Split('#'));
                }
            }
            using (StreamReader sw = new StreamReader(file4))
            {
                string str;

                while ((str = sw.ReadLine()) != null)
                {
                    tscmbSubject.Items.AddRange(str.Split('#'));
                }
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            if (sender == mnuNewTeacher || sender == tsmnuTeacher)
            {
                OqituvchiForm frmTeach = new OqituvchiForm(tscmbSubject);
                frmTeach.GetTeacher+=frmTeach_GetTeacher;
                frmTeach.ShowDialog();
            }
            else if (sender == mnuNewSubject || sender == tsmnuNewSubject)
            {
                SubjectForm frmSub = new SubjectForm();
                frmSub.GetSubject+=frmSub_GetSubject;
                frmSub.ShowDialog();
            }
            else if (sender == mnuNewAbiturient || sender == tsmnuNewAbiturient)
            {
                AbiturientForm frmAbit = new AbiturientForm(tscmbSubject);
                frmAbit.GetAbiturient += frmAbit_GetAbiturient;
                frmAbit.ShowDialog();
            }
            else if (sender == mnuNewCourse || sender == tsmnuCourse)
            {
                //CourseForm frmCourse = new CourseForm(tscmbSubject, );
                //frmCourse.GetCourse+=frmCourse_GetCourse;
                //frmCourse.ShowDialog();
            }
            else if (sender == mnuSave || sender == tsbSave)
            {
                using (StreamWriter sw = new StreamWriter(file1))
                {
                    foreach (DataGridViewRow row in dgvAbiturient.Rows)
                    {
                        string str = "";

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                str += row.Cells[i].Value.ToString()+"#";
                            }
                            else
                            {
                                str += " #";
                            }
                        }
                        str = str.Remove(str.Length - 1,1);

                            sw.WriteLine(str);
                    }
                }
                using (StreamWriter sw = new StreamWriter(file2))
                {
                    foreach (DataGridViewRow row in dgvTeacher.Rows)
                    {
                        string str = "";

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                str += row.Cells[i].Value.ToString() + "#";
                            }
                            else
                            {
                                str += " #";
                            }
                        }
                        str = str.Remove(str.Length - 1, 1);

                        sw.WriteLine(str);
                    }
                }
                using (StreamWriter sw = new StreamWriter(file3))
                {
                    foreach (DataGridViewRow row in dgvCourse.Rows)
                    {
                        string str = "";

                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null)
                            {
                                str += row.Cells[i].Value.ToString() + "#";
                            }
                            else
                            {
                                str += " #";
                            }
                        }
                        str = str.Remove(str.Length - 1, 1);

                        sw.WriteLine(str);
                    }
                }
                using (StreamWriter sw = new StreamWriter(file4))
                {
                    string str = "";
                    foreach (var a in tscmbSubject.Items)
                    {
                        str += a + "#";
                    }
                        str = str.Remove(str.Length - 1, 1);
                        sw.WriteLine(str);
                    
                }          
            }
        }

        void frmAbit_GetAbiturient(object sender, EventArgs e)
        {
            var a = ((AbiturientForm)sender).Abiturient;
            dgvAbiturient.Rows.Add(a.Id, a.LastName, a.Name, a.SurName, a.PasportNumber, a.Pol, a.Address, a.PhoneNumber, a.Subject);
                     
        }
        void frmSub_GetSubject(object sender, EventArgs e)
        {
            var a = ((SubjectForm)sender).Subject;
            tscmbSubject.Items.Add(a.Name);
        }
        void frmTeach_GetTeacher(object sender, EventArgs e)
        {
            var a = ((OqituvchiForm)sender).Teacher;
            dgvTeacher.Rows.Add(a.Id, a.LastName, a.Name, a.SurName, a.PasportNumber, a.Pol, a.Address, a.PhoneNumber, a.Subject);
        }
        void frmCourse_GetCourse(object sender, EventArgs e)
        {
            var a = ((CourseForm)sender).Course;
            dgvCourse.Rows.Add(a.Id, a.Name, a.Subject);
        }
        private void dgvAbiturient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


       

        
    }
}
