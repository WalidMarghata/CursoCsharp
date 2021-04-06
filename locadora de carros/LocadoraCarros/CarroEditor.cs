using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BethesdaCarRental1
{
    public partial class CarroEditor : Form
    {
        Dictionary<string, Carro> listaCarros;

        public CarroEditor()
        {
            InitializeComponent();
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {
                lblPictureName.Text = dlgPicture.FileName;
                pbxCar.Image = Image.FromFile(lblPictureName.Text);
            }
        }

        private void CarroEditor_Load(object sender, EventArgs e)
        {
            Carro veiculo = new Carro();
            BinaryFormatter bfmCarros = new BinaryFormatter();

            // Arquivo que armazena a lista de itens
            string NomeArquivo = @"C:\JcmSoft_Carros\Carros.crs";
            lblPictureName.Text = ".";

            if (File.Exists(NomeArquivo))
            {
                FileStream stnCarros = new FileStream(NomeArquivo,
                                                    FileMode.Open,
                                                    FileAccess.Read,
                                                    FileShare.Read);
                try
                {
                    // Retorna a lista de carros
                    listaCarros =
                        (Dictionary<string, Carro>)bfmCarros.Deserialize(stnCarros);
                }
                finally
                {
                    stnCarros.Close();
                }
            }
            else
                listaCarros = new Dictionary<string, Carro>();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Carro veiculo = new Carro();
            FileStream stnCarros = null;
            BinaryFormatter bfmCarros = new BinaryFormatter();
            Directory.CreateDirectory(@"C:\JcmSoft_Carros");
            string strNomeArquivo = @"C:\JcmSoft_Carros\Carros.crs";

            if (txtTagNumber.Text.Length == 0)
            {
                MessageBox.Show("Informe o número de registro");
                return;
            }

            if (txtMake.Text.Length == 0)
            {
                MessageBox.Show("Informe o fabricante.");
                return;
            }

            if (txtModel.Text.Length == 0)
            {
                MessageBox.Show("Informe o Ano de fabricação");
                return;
            }

            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("Informe o ano");
                return;
            }

            // Cria um carro
            veiculo.Fabricante = txtMake.Text;
            veiculo.Modelo = txtModel.Text;
            veiculo.Ano = int.Parse(txtYear.Text);
            veiculo.Categoria = cbxCategories.Text;
            veiculo.TemCDPlayer = chkCDPlayer.Checked;
            veiculo.TemDVDPlayer = chkDVDPlayer.Checked;
            veiculo.EstaDisponivel = chkAvailable.Checked;

            // Chama o método Add da coleção para adicionar o carro
            listaCarros.Add(txtTagNumber.Text, veiculo);

            // salva a lista
            stnCarros = new FileStream(strNomeArquivo,
                                          FileMode.Create,
                                          FileAccess.Write,
                                          FileShare.Write);

            try
            {
                bfmCarros.Serialize(stnCarros, listaCarros);

                if (lblPictureName.Text.Length != 0)
                {
                    FileInfo flePicture = new FileInfo(lblPictureName.Text);
                    flePicture.CopyTo(@"C:\JcmSoft_Carros\" +
                                      txtTagNumber.Text +
                                      flePicture.Extension);
                }

                txtTagNumber.Text = "";
                txtMake.Text = "";
                txtModel.Text = "";
                txtYear.Text = "";
                cbxCategories.Text = "Economy";
                chkCDPlayer.Checked = false;
                chkDVDPlayer.Checked = false;
                chkAvailable.Checked = false;
                lblPictureName.Text = ".";
                pbxCar.Image = null;
            }
            finally
            {
                stnCarros.Close();
            }
        }
    }
}