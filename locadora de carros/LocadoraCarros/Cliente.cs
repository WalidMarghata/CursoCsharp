using System;

namespace BethesdaCarRental1
{
    [Serializable]
    public class Cliente
    {
        public string Nome;
        public string Endereco;
        public string Cidade;
        public string Estado;
        public string CodigoPostal;

        public Cliente()
        {
            Nome = "";
            Endereco = "";
            Cidade = "";
            Estado = "";
            CodigoPostal = "";
        }

        // define o cliente
        public Cliente(string fNome,
                        string end, string cid,
                        string est, string cep)
        {
            Nome = fNome;
            Endereco = end;
            Cidade = cid;
            Estado = est;
            CodigoPostal = cep;
        }
    }
}
