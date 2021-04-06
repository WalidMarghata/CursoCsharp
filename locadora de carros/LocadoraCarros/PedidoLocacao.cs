using System;

namespace BethesdaCarRental1
{
    [Serializable]
    public class PedidoLocacao
    {
        public string NumeroEmpregado;
        // A seguinte flag permite atualiza/saber se
        // * O carro esta sendo usado pelo cliente
        // * O cliente devolveu o veiculo locado
        public string StatusPedido;
        // Cada carro possui um número de registro
        // e esse número não muda
        // durante o tempo de vida do veiculo
        public string NumeroCarro;
        // O cliente será identificado pelo numero da CNH e o nome na sua CNH
        public string NumeroCNHCliente;
        public string NomeCliente;
        // Embora o numero da CNH do cliente não mude
        // O seu endereço pode mudar durante as locações que ele pode fazer
        // Por isso, embora seja retornado o endereço dalista de clientes
        // é permitido ao empregado alterar esta informação no pedido de locação
        // Assim o mesmo cliente pode ter endereço diferente em locaçoes feitas
        // Por isso, cada pedido de locação tera sua propria informação sobre o cliente
        public string EnderecoCliente;
        public string CidadeCliente;
        public string EstadoCliente;
        public string CepCliente;
        public string EstadoDoVeiculo;
        public string NivelTanque;
        // Informação registrada quando do inicio da locação do veiculo
        public int MilhagemInicial;
        // Informação registrada quando o veículo é retornado pelo cliente
        public int MilhagemFinal;
        // Informação registrada quando do inicio da locação do veiculo
        public DateTime DataInicio;
        // Informação registrada quando o veículo é retornado pelo cliente
        public DateTime DataFinal;
        public int Dias;
        // Informação registrada quando do inicio da locação do veiculo
        public double TaxaAplicada;
        // O calculo será feito quando o carro é trazido de volta pelo cliente
        public double SubTotal;
        public double TaxaImposto;
        public double ValorImposto;
        public double ValorTotal;

        public PedidoLocacao()
        {
        }
    }
}
