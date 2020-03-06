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

namespace OquvKursi
{
    public partial class AbiturientForm : Form
    {
        public Abiturient Abiturient { get; set; }
        
        public event EventHandler GetAbiturient;
        public virtual void OnGetAbiturient(EventArgs e)
        {
            if (GetAbiturient != null)
                GetAbiturient(this, e);
        }
        public AbiturientForm()
        {
            InitializeComponent();
        }
        public AbiturientForm(ToolStripComboBox tscmb)
        {
            InitializeComponent();
            foreach (var a in tscmb.ComboBox.Items)
            {
                cmbFan.Items.Add(a);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var abiturient = new Abiturient
                {
                    Address = txtAddress.Text,
                    LastName = txtLastName.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PasportNumber = txtPasportNumber.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Pol = rbErkak.Checked ? "Erkak" : rbAyol.Checked ? "Ayol" : "",
                    Subject = cmbFan.SelectedItem.ToString(),
                };


                Abiturient = abiturient;
                this.OnGetAbiturient(e);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }

        }
    }
}
