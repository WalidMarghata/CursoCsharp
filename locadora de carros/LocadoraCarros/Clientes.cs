using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BethesdaCarRental1
{
    public partial class Clientes : Form
    {
        Dictionary<string, Cliente> listaClientes;

        public Clientes()
        {
            InitializeComponent();
        }

        internal void ExibeClientes()
        {
            if (listaClientes.Count == 0)
                return;

            lvClientes.Items.Clear();
            int i = 1;

            foreach (KeyValuePair<string, Cliente> kvp in listaClientes)
            {
                ListViewItem lviCliente = new ListViewItem(kvp.Key);

                Cliente cli = kvp.Value;

                lviCliente.SubItems.Add(cli.Nome);
                lviCliente.SubItems.Add(cli.Endereco);
                lviCliente.SubItems.Add(cli.Cidade);
                lviCliente.SubItems.Add(cli.Estado);
                lviCliente.SubItems.Add(cli.CodigoPostal);

                if (i % 2 == 0)
                {
                    lviCliente.BackColor = Color.Navy;
                    lviCliente.ForeColor = Color.White;
                }
                else
                {
                    lviCliente.BackColor = Color.Blue;
                    lviCliente.ForeColor = Color.White;
                }

                lvClientes.Items.Add(lviCliente);

                i++;
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            listaClientes = new Dictionary<string, Cliente>();
            BinaryFormatter bfmClientes = new BinaryFormatter();

            // arquivo que trata a lista de clientes
            string strNomeArquivo = @"C:\JcmSoft_Carros\Clientes.crc";

            if (File.Exists(strNomeArquivo))
            {
                FileStream stmClientes = new FileStream(strNomeArquivo,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read);
                try
                {
                    // Retorna a lista de clientes
                    listaClientes =
                        (Dictionary<string, Cliente>)
                            bfmClientes.Deserialize(stmClientes);
                }
                finally
                {
                    stmClientes.Close();
                }
            }

            ExibeClientes();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            ClienteEditor editor = new ClienteEditor();
            Directory.CreateDirectory(@"C:\JcmSoft_Carros");

            if (editor.ShowDialog() == DialogResult.OK)
            {
                if (editor.txtDrvLicNbr.Text == "")
                {
                    MessageBox.Show("Você deve fornecer o numero de registro da " +
                                    "carteira de habilitação do cliente.");
                    return;
                }

                if (editor.txtFullName.Text == "")
                {
                    MessageBox.Show("Informe o nome completo.");
                    return;
                }

                string strNomeArquivo = @"C:\JcmSoft_Carros\Clientes.crc";

                Cliente cli = new Cliente();

                cli.Nome = editor.txtFullName.Text;
                cli.Endereco = editor.txtAddress.Text;
                cli.Cidade = editor.txtCity.Text;
                cli.Estado = editor.cbxStates.Text;
                cli.CodigoPostal = editor.txtZIPCode.Text;
                listaClientes.Add(editor.txtDrvLicNbr.Text, cli);

                FileStream bcrStream = new FileStream(strNomeArquivo,
                                                      FileMode.Create,
                                                      FileAccess.Write,
                                                      FileShare.Write);
                BinaryFormatter bcrBinary = new BinaryFormatter();
                bcrBinary.Serialize(bcrStream, listaClientes);
                bcrStream.Close();

                ExibeClientes();
            }
        }
    }
}