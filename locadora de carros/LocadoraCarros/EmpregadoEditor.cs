using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BethesdaCarRental1
{
    public partial class EmpregadoEditor : Form
    {
        public EmpregadoEditor()
        {
            InitializeComponent();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            string strPrimeiroNome = txtFirstName.Text;
            string strSobrenome = txtLastName.Text;
            string strNomeCompleto;

            if (strPrimeiroNome.Length == 0)
                strNomeCompleto = strSobrenome;
            else
                strNomeCompleto = strSobrenome + ", " + strPrimeiroNome;

            txtFullName.Text = strNomeCompleto;
        }
    }
}