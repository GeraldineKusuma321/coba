using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitur_Contact_us
{
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima Kasih Atas Kritik dan Saran.");
            this.DialogResult = DialogResult.OK;
        }
    }
    }
