using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BethesdaCarRental1
{
    public partial class Empregados : Form
    {
        SortedDictionary<string, Empregado> listaEmpregados;

        public Empregados()
        {
            InitializeComponent();
        }

        internal void ExibeEmpregados()
        {
            if (listaEmpregados.Count == 0)
                return;

            // Antes de exibir limpa o list view
            lvwEmpregados.Items.Clear();
            // Esta variavel permite identificar os indices impares e pares
            int i = 1;

            // Usamos a classe KeyValuePair para visitar cara item key/value
            foreach (KeyValuePair<string, Empregado> kvp in listaEmpregados)
            {
                ListViewItem lviEmpregado = new ListViewItem(kvp.Key);

                Empregado empl = kvp.Value;

                lviEmpregado.SubItems.Add(empl.Nome);
                lviEmpregado.SubItems.Add(empl.SobreNome);
                lviEmpregado.SubItems.Add(empl.Nome);
                lviEmpregado.SubItems.Add(empl.Titulo);
                lviEmpregado.SubItems.Add(empl.SalarioPorHora.ToString("F"));

                if (i % 2 == 0)
                {
                    lviEmpregado.BackColor = Color.FromArgb(255, 128, 0);
                    lviEmpregado.ForeColor = Color.White;
                }
                else
                {
                    lviEmpregado.BackColor = Color.FromArgb(128, 64, 64);
                    lviEmpregado.ForeColor = Color.White;
                }

                lvwEmpregados.Items.Add(lviEmpregado);

                i++;
            }
        }

        private void Empregados_Load(object sender, EventArgs e)
        {
            listaEmpregados = new SortedDictionary<string, Empregado>();
            BinaryFormatter bfmEmpregados = new BinaryFormatter();

            //armazena a lista de empregados
            string strNomeArquivo = @"C:\JcmSoft_Carros\Empregados.cre";

            if (File.Exists(strNomeArquivo))
            {
                FileStream stmEmpregados = new FileStream(strNomeArquivo,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read);

                try
                {
                    // retorna lista de empregados
                    listaEmpregados =(SortedDictionary<string,Empregado>)
                    bfmEmpregados.Deserialize(stmEmpregados);
                }
                finally
                {
                    stmEmpregados.Close();
                }
            }

            ExibeEmpregados();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            EmpregadoEditor editor = new EmpregadoEditor();
            Directory.CreateDirectory(@"C:\JcmSoft_Carros");

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtEmployeeNumber.Text == "")
                {
                    MessageBox.Show("Informe o número do empregado");
                    return;
                }

                if (editor.txtLastName.Text == "")
                {
                    MessageBox.Show("Informe o sobrenome do empregado");
                    return;
                }

                string strNomeArquivo = @"C:\JcmSoft_Carros\Empregados.cre";

                Empregado empl = new Empregado();

                empl.PrimeiroNome = editor.txtFirstName.Text;
                empl.SobreNome = editor.txtLastName.Text;
                empl.Titulo = editor.txtTitle.Text;
                empl.SalarioPorHora = double.Parse(editor.txtHourlySalary.Text);
                listaEmpregados.Add(editor.txtEmployeeNumber.Text, empl);

                FileStream bcrStream = new FileStream(strNomeArquivo,
                                                      FileMode.Create,
                                                      FileAccess.Write,
                                                      FileShare.Write);
                BinaryFormatter bcrBinary = new BinaryFormatter();
                bcrBinary.Serialize(bcrStream, listaEmpregados);
                bcrStream.Close();

                ExibeEmpregados();
            }
        }
    }
}