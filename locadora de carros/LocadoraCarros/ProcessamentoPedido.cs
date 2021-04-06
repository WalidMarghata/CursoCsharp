using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BethesdaCarRental1
{
    public partial class ProcessamentoPedido : Form
    {
        int NumeroRecibo;
        SortedList<int, PedidoLocacao> listaPedidosLocacao;

        public ProcessamentoPedido()
        {
            InitializeComponent();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Value = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            int _dias;

            DateTime dteStart = this.dtpStartDate.Value;
            DateTime dteEnd = this.dtpEndDate.Value;

            // calcula a diferença de dias
            TimeSpan tme = dteEnd - dteStart;
            _dias = tme.Days;

            // Se o cliente devolve o carro no mesmo dia
            // consideremos que o carro foi alugado por 1 dia
            if (_dias == 0)
                _dias = 1;

            txtDays.Text = _dias.ToString();
            // Em qualquer caso vamos deixar o funcionario especifciar o numero de dias
        }

        private void btnRentalRates_Click(object sender, EventArgs e)
        {
            TaxasLocacao _taxasLoca = new TaxasLocacao();
            _taxasLoca.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Dias = 0;
            double TaxaAplicada = 0.00;
            double SubTotal = 0.00;
            double TaxaImposto = 0.00;
            double ValorImposto = 0.00;
            double ValorTotal = 0.00;

            try
            {
                Dias = int.Parse(this.txtDays.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número de dias inválido");
            }

            try
            {
                TaxaAplicada = double.Parse(txtRateApplied.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor inválido para a taxa aplicada");
            }

            SubTotal = Dias * TaxaAplicada;
            txtSubTotal.Text = SubTotal.ToString("F");

            try
            {
                TaxaImposto = double.Parse(txtTaxRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Taxa de Imposto inválida.");
            }

            ValorImposto = SubTotal * TaxaImposto / 100;
            txtTaxAmount.Text = ValorImposto.ToString("F");

            ValorTotal = SubTotal + ValorImposto;
            txtOrderTotal.Text = ValorTotal.ToString("F");
        }

        private void docPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 90, 750, 90);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 93, 750, 93);

            string strDisplay = "JcmSoft - Locação de Veículos";
            System.Drawing.Font fntString = new Font("Times New Roman", 28,
                                FontStyle.Bold);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 240, 100);

            strDisplay = "Pedido de Locação de Veículo";
            fntString = new System.Drawing.Font("Times New Roman", 22,
                                FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                Brushes.Black, 320, 150);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), 80, 187, 750, 187);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 80, 190, 750, 190);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Recibo #:  ", fntString,
                        Brushes.Black, 100, 220);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(txtReceiptNumber.Text, fntString,
                                          Brushes.Black, 260, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 240, 380, 240);

            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Bold);
            e.Graphics.DrawString("Processado Por:  ", fntString,
                        Brushes.Black, 420, 220);
            fntString = new System.Drawing.Font("Times New Roman", 12,
                        FontStyle.Regular);
            e.Graphics.DrawString(txtNomeEmpregado.Text, fntString,
                                          Brushes.Black, 550, 220);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 240, 720, 240);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 260, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 260, 620, 20));

            e.Graphics.DrawString("Cliente", fntString,
                                          Brushes.White, 100, 260);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Registro CNH #: ", fntString,
                                          Brushes.Black, 100, 300);
            e.Graphics.DrawString("Nome: ", fntString,
                                         Brushes.Black, 420, 300);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtNumeroRegistroCNH.Text, fntString,
                                          Brushes.Black, 260, 300);
            e.Graphics.DrawString(txtNomeCliente.Text, fntString,
                                          Brushes.Black, 540, 300);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 320, 720, 320);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Endereco: ", fntString,
                                          Brushes.Black, 100, 330);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtEnderecoCliente.Text, fntString,
                                          Brushes.Black, 260, 330);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 350, 720, 350);

            strDisplay = txtCidadeCliente.Text + " " +
                                 cboClientesEstados.Text + " " +
                                 txtCepCliente.Text;
            fntString = new System.Drawing.Font("Times New Roman",
                12, FontStyle.Regular);
            e.Graphics.DrawString(strDisplay, fntString,
                                          Brushes.Black, 260, 360);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 260, 380, 720, 380);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Gray,
                new Rectangle(100, 410, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(100, 410, 620, 20));

            e.Graphics.DrawString("Informação Veículo", fntString,
                                          Brushes.White, 100, 410);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Número #: ", fntString,
                                          Brushes.Black, 100, 450);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtTagNumber.Text, fntString,
                                          Brushes.Black, 260, 450);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 470, 380, 470);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Ano: ", fntString,
                                          Brushes.Black, 420, 450);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtCarYear.Text, fntString,
                                  Brushes.Black, 530, 450);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 470, 720, 470);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Fabricante: ", fntString,
                                  Brushes.Black, 100, 480);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtMake.Text, fntString,
                                  Brushes.Black, 260, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 500, 380, 500);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Modelo: ", fntString,
                                  Brushes.Black, 420, 480);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtModel.Text, fntString,
                                  Brushes.Black, 530, 480);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 500, 720, 500);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Carro Condition: ", fntString,
                                  Brushes.Black, 100, 510);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(cbxCarConditions.Text, fntString,
                                  Brushes.Black, 260, 510);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 530, 380, 530);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Nível Tanque: ", fntString,
                                  Brushes.Black, 420, 510);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(cbxTankLevels.Text, fntString,
                                  Brushes.Black, 530, 510);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 530, 720, 530);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Milhagem Inicio:", fntString,
                                  Brushes.Black, 100, 540);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtMileageStart.Text, fntString,
                                  Brushes.Black, 260, 540);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 560, 380, 560);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Milhagem Final:", fntString,
                                  Brushes.Black, 420, 540);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtMileageEnd.Text, fntString,
                                  Brushes.Black, 530, 540);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 560, 720, 560);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 590, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 590, 620, 20));

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Order Timing Information", fntString,
                                  Brushes.White, 100, 590);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Data Início:", fntString,
                                  Brushes.Black, 100, 620);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(dtpStartDate.Value.ToString("D"), fntString,
                                  Brushes.Black, 260, 620);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 640, 720, 640);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Data Final:", fntString,
                                  Brushes.Black, 100, 650);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(dtpEndDate.Value.ToString("D"), fntString,
                                  Brushes.Black, 260, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 670, 520, 670);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Dias:", fntString,
                                  Brushes.Black, 550, 650);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtDays.Text, fntString,
                                  Brushes.Black, 640, 650);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 550, 670, 720, 670);

            e.Graphics.FillRectangle(Brushes.Gray, new Rectangle(100, 700, 620, 20));
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(100, 700, 620, 20));

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Avaliação Pedido", fntString,
                                  Brushes.White, 100, 700);

            StringFormat fmtString = new StringFormat();
            fmtString.Alignment = StringAlignment.Far;

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Traxa Aplicada:", fntString,
                                  Brushes.Black, 100, 740);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtRateApplied.Text, fntString,
                                  Brushes.Black, 300, 740, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 760, 380, 760);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Taxa Imposto:", fntString,
                                  Brushes.Black, 420, 740);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtTaxRate.Text, fntString,
                                  Brushes.Black, 640, 740, fmtString);
            e.Graphics.DrawString("%", fntString,
                                  Brushes.Black, 640, 740);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 760, 720, 760);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Sub-Total:", fntString,
                                  Brushes.Black, 100, 770);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtSubTotal.Text, fntString,
                                  Brushes.Black, 300, 770, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 100, 790, 380, 790);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Valor Imposto:", fntString,
                                          Brushes.Black, 420, 770);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtTaxAmount.Text, fntString,
                                          Brushes.Black, 640, 770, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 790, 720, 790);

            fntString = new Font("Times New Roman", 12, FontStyle.Bold);
            e.Graphics.DrawString("Total Locação:", fntString,
                                          Brushes.Black, 420, 800);
            fntString = new Font("Times New Roman", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtOrderTotal.Text, fntString,
                                          Brushes.Black, 640, 800, fmtString);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), 420, 820, 720, 820);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dlgPrint.ShowDialog() == DialogResult.OK)
                docPrint.Print();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
        }

        private void txtNumeroRegistroCNH_Leave(object sender, EventArgs e)
        {
            Cliente locador = null;
            string strNumeroCNH = txtNumeroRegistroCNH.Text;

            if (strNumeroCNH.Length == 0)
            {
                MessageBox.Show("Informe o número de registro da carteira de habilitação do Cliente.");
                txtNumeroRegistroCNH.Focus();
                return;
            }

            Dictionary<string, Cliente> listaClientes =
                        new Dictionary<string, Cliente>();
            BinaryFormatter bfmClientes = new BinaryFormatter();

            string strNomeArquivo = @"C:\JcmSoft_Carros\Clientes.crc";

            if (File.Exists(strNomeArquivo))
            {
                FileStream stmClientes = new FileStream(strNomeArquivo,
                                                         FileMode.Open,
                                                         FileAccess.Read,
                                                         FileShare.Read);

                try
                {
                    // retorna lista de clientes
                    listaClientes =
                                (Dictionary<string, Cliente>)
                                    bfmClientes.Deserialize(stmClientes);
                    if (listaClientes.ContainsKey(strNumeroCNH) == true)
                    {
                        foreach (KeyValuePair<string, Cliente> cli in listaClientes)
                        {
                            if (cli.Key == strNumeroCNH)
                            {
                                locador = cli.Value;
                                txtNomeCliente.Text = locador.Nome;
                                txtEnderecoCliente.Text = locador.Endereco;
                                txtCidadeCliente.Text = locador.Cidade;
                                cboClientesEstados.Text = locador.Estado;
                                txtCepCliente.Text = locador.CodigoPostal;
                            }
                        }
                    }
                    else
                    {
                        txtNomeCliente.Text = "";
                        txtEnderecoCliente.Text = "";
                        txtCidadeCliente.Text = "";
                        cboClientesEstados.Text = "";
                        txtCepCliente.Text = "";
                        MessageBox.Show("Não existe cliente com o registro de " +
                                        " CNH informado no banco de dados");
                        return;
                    }
                }
                finally
                {
                    stmClientes.Close();
                }
            }
        }

        private void btnNewRentalOrder_Click(object sender, EventArgs e)
        {
            txtNumeroEmpregado.Text = "";
            txtNomeEmpregado.Text = "";
            txtNumeroRegistroCNH.Text = "";
            txtNomeCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtCidadeCliente.Text = "";
            cboClientesEstados.Text = "";
            txtCepCliente.Text = "";
            txtTagNumber.Text = "";
            cbxCarConditions.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtCarYear.Text = "";
            cbxTankLevels.Text = "Empty";
            txtMileageStart.Text = "0";
            txtMileageEnd.Text = "0";
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            txtDays.Text = "";
            cbxOrderStatus.Text = "";
            txtRateApplied.Text = "0.00";
            txtSubTotal.Text = "0.00";
            txtTaxRate.Text = "7.75";
            txtTaxAmount.Text = "0.00";
            txtOrderTotal.Text = "0.00";

            BinaryFormatter bfmRentalOrders = new BinaryFormatter();

            string strNomeArquivo = @"C:\JcmSoft_Carros\PedidosLocacao.cro";

            if (File.Exists(strNomeArquivo))
            {
                FileStream stmPedidosLocacao = new FileStream(strNomeArquivo,
                                                            FileMode.Open,
                                                            FileAccess.Read,
                                                            FileShare.Read);

                try
                {
                    listaPedidosLocacao =
                        (SortedList<int, PedidoLocacao>)
                            bfmRentalOrders.Deserialize(stmPedidosLocacao);
                    NumeroRecibo =
                listaPedidosLocacao.Keys[listaPedidosLocacao.Count - 1] + 1;
                }
                finally
                {
                    stmPedidosLocacao.Close();
                }
            }
            else
            {
                NumeroRecibo = 100001;
                listaPedidosLocacao = new SortedList<int, PedidoLocacao>();
            }

            txtReceiptNumber.Text = NumeroRecibo.ToString();
        }

        private void OrderProcessing_Load(object sender, EventArgs e)
        {
            btnNewRentalOrder_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtReceiptNumber.Text == "")
            {
                MessageBox.Show("O número do registro esta ausente.");
                return;
            }

            // Não salva se não sabe que processou o pedido
            if (txtNumeroEmpregado.Text == "")
            {
                MessageBox.Show("Informe o numero do empregado que " +
                                "processou este pedido.");
                return;
            }

            // Não salva o pedido se não sabe quem é o locador
            if (txtNumeroRegistroCNH.Text == "")
            {
                MessageBox.Show("Informe o numero de registro da carteira de habilitação " +
                                "do cliente que esta alugando o carro");
                return;
            }

            // não salva o pedido de locação se não sabemos qual carro vai ser locado
            if (txtTagNumber.Text == "")
            {
                MessageBox.Show("Informe o numero de registro do carro " +
                                " que esta sendo alugado");
                return;
            }

            // Cria o numero do pedido baseado na informação do formulãrio
            PedidoLocacao pedidoLocacaoAtual = new PedidoLocacao();

            pedidoLocacaoAtual.NumeroEmpregado = txtNumeroEmpregado.Text;
            pedidoLocacaoAtual.StatusPedido = cbxOrderStatus.Text;
            pedidoLocacaoAtual.NumeroCarro = txtTagNumber.Text;
            pedidoLocacaoAtual.NumeroCNHCliente = txtNumeroRegistroCNH.Text;
            pedidoLocacaoAtual.NomeCliente = txtNomeCliente.Text;
            pedidoLocacaoAtual.EnderecoCliente = txtEnderecoCliente.Text;
            pedidoLocacaoAtual.CidadeCliente = txtCidadeCliente.Text;
            pedidoLocacaoAtual.EstadoCliente = cboClientesEstados.Text;
            pedidoLocacaoAtual.CepCliente = txtCepCliente.Text;
            pedidoLocacaoAtual.EstadoDoVeiculo = cbxCarConditions.Text;
            pedidoLocacaoAtual.NivelTanque = cbxTankLevels.Text;

            try
            {
                pedidoLocacaoAtual.MilhagemInicial = int.Parse(txtMileageStart.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor da milhagem inicial inválida");
            }

            try
            {
                pedidoLocacaoAtual.MilhagemFinal = int.Parse(txtMileageEnd.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor da milhagem final inválida");
            }

            try
            {
                pedidoLocacaoAtual.DataInicio = dtpStartDate.Value;
            }
            catch (FormatException)
            {
                MessageBox.Show("Data de início inválida");
            }

            try
            {
                pedidoLocacaoAtual.DataFinal = dtpEndDate.Value;
            }
            catch (FormatException)
            {
                MessageBox.Show("Data final inválida");
            }

            try
            {
                pedidoLocacaoAtual.Dias = int.Parse(txtDays.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Número de dias inválidos");
            }

            try
            {
                pedidoLocacaoAtual.TaxaAplicada = double.Parse(txtRateApplied.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor da taxa inválida");
            }

            pedidoLocacaoAtual.SubTotal = double.Parse(txtSubTotal.Text);

            try
            {
                pedidoLocacaoAtual.TaxaImposto = double.Parse(txtTaxRate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Valor do imposto invlálido");
            }

            pedidoLocacaoAtual.ValorImposto = double.Parse(txtTaxAmount.Text);
            pedidoLocacaoAtual.ValorTotal = double.Parse(txtOrderTotal.Text);
            // a ordem de locacao esta pronta

            // Pega o numero de recibo
            try
            {
                NumeroRecibo = int.Parse(txtReceiptNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Informe o número do recibo");
            }

            // Pega alisa de pedidos de locação e
            // verifica se ja existe uma locacao com o numero de recibo
            if (listaPedidosLocacao.ContainsKey(NumeroRecibo) == true)
            {
                // atualiza o valor
                listaPedidosLocacao[NumeroRecibo] = pedidoLocacaoAtual;
            }
            else
            {
                // Se não tem pedido com esse numero
                // cria um novo pedido de locação
                listaPedidosLocacao.Add(NumeroRecibo, pedidoLocacaoAtual);
            }

            // A lista de pedidos de locacao
            string strNomeArquivo = @"C:\JcmSoft_Carros\PedidosLocacao.cro";
            FileStream bcrStream = new FileStream(strNomeArquivo,
                                                  FileMode.Create,
                                                  FileAccess.Write,
                                                  FileShare.Write);
            BinaryFormatter bcrBinary = new BinaryFormatter();
            try
            {
                bcrBinary.Serialize(bcrStream, listaPedidosLocacao);
            }
            finally
            {
                bcrStream.Close();
            }
        }

        private void txtEmployeeNumber_Leave(object sender, EventArgs e)
        {
            Empregado funcionario;
            string strNumeroEmpregado = txtNumeroEmpregado.Text;

            if (strNumeroEmpregado.Length == 0)
            {
                MessageBox.Show("Informe o número do empregado");
                txtNumeroEmpregado.Focus();
                return;
            }

            SortedDictionary<string, Empregado> listaEmpregados =
                new SortedDictionary<string, Empregado>();
            BinaryFormatter bfmEmpregados = new BinaryFormatter();

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
                    listaEmpregados =
                        (SortedDictionary<string, Empregado>)
                            bfmEmpregados.Deserialize(stmEmpregados);
                    if (listaEmpregados.TryGetValue(strNumeroEmpregado, out funcionario))
                    {
                        txtNomeEmpregado.Text = funcionario.Nome;
                    }
                    else
                    {
                        txtNomeEmpregado.Text = "";
                        MessageBox.Show("Não existe empregado com este número.");
                        return;
                    }
                }
                finally
                {
                    stmEmpregados.Close();
                }
            }
        }

        private void txtTagNumber_Leave(object sender, EventArgs e)
        {
            Carro _selecionado;
            string strTabNumero = txtTagNumber.Text;

            if (strTabNumero.Length == 0)
            {
                MessageBox.Show("Voce deve informar o numero de registro do veículo");
                txtTagNumber.Focus();
                return;
            }

            Dictionary<string, Carro> listaCarros =
                        new Dictionary<string, Carro>();
            BinaryFormatter bfmCarros = new BinaryFormatter();

            string strNomeArquivo = @"C:\JcmSoft_Carros\Carros.crs";

            if (File.Exists(strNomeArquivo))
            {
                FileStream stnCarros = new FileStream(strNomeArquivo,
                                                    FileMode.Open,
                                                    FileAccess.Read,
                                                    FileShare.Read);
                try
                {
                    // retorna lista
                    listaCarros =
                        (Dictionary<string, Carro>)
                                bfmCarros.Deserialize(stnCarros);
                    if (listaCarros.TryGetValue(strTabNumero, out _selecionado))
                    {
                        txtMake.Text = _selecionado.Fabricante;
                        txtModel.Text = _selecionado.Modelo;
                        txtCarYear.Text = _selecionado.Ano.ToString();
                    }
                    else
                    {
                        txtMake.Text = "";
                        txtModel.Text = "";
                        txtCarYear.Text = "";
                        MessageBox.Show("Não existe carro com este número " +
                                        " de registro na base de dados");
                        return;
                    }
                }
                finally
                {
                    stnCarros.Close();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            PedidoLocacao _pedido = null;

            if (txtReceiptNumber.Text == "")
            {
                MessageBox.Show("Informe o número do recibo");
                return;
            }

            NumeroRecibo = int.Parse(txtReceiptNumber.Text);

            if (listaPedidosLocacao.TryGetValue(NumeroRecibo, out _pedido))
            {
                txtNumeroEmpregado.Text = _pedido.NumeroEmpregado;
                txtEmployeeNumber_Leave(sender, e);
                cbxOrderStatus.Text = _pedido.StatusPedido;
                txtTagNumber.Text = _pedido.NumeroCarro;
                txtTagNumber_Leave(sender, e);
                txtNumeroRegistroCNH.Text = _pedido.NumeroCNHCliente;
                txtNomeCliente.Text = _pedido.NomeCliente;
                txtEnderecoCliente.Text = _pedido.EnderecoCliente;
                txtCidadeCliente.Text = _pedido.CidadeCliente;
                cboClientesEstados.Text = _pedido.EstadoCliente;
                txtCepCliente.Text = _pedido.CepCliente;
                cbxCarConditions.Text = _pedido.EstadoDoVeiculo;
                cbxTankLevels.Text = _pedido.NivelTanque;
                txtMileageStart.Text = _pedido.MilhagemInicial.ToString();
                txtMileageEnd.Text = _pedido.MilhagemFinal.ToString();
                dtpStartDate.Value = _pedido.DataInicio;
                dtpEndDate.Value = _pedido.DataFinal;
                txtDays.Text = _pedido.Dias.ToString();
                txtRateApplied.Text = _pedido.TaxaAplicada.ToString("F");
                txtSubTotal.Text = _pedido.SubTotal.ToString("F");
                txtTaxRate.Text = _pedido.TaxaImposto.ToString("F");
                txtTaxAmount.Text = _pedido.ValorImposto.ToString("F");
                txtOrderTotal.Text = _pedido.ValorTotal.ToString("F");
            }
            else
            {
                MessageBox.Show("Não existe pedido de locação com este número de recibo.");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}