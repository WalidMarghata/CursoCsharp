using System;

namespace BethesdaCarRental1
{
    [Serializable]
    public class Empregado
    {
        public string PrimeiroNome;
        public string SobreNome;
        public string Titulo;
        public double SalarioPorHora;

        public string Nome
        {
            get { return SobreNome + ", " + PrimeiroNome; }
        }

        public Empregado()
        {
            PrimeiroNome = "Desconhecido";
            SobreNome = "Desconhecido";
            Titulo = "N/A";
            SalarioPorHora = 0.00;
        }

        // construtor define um empregado
        public Empregado(string fname, string lname,
                        string title, double salary)
        {
            PrimeiroNome = fname;
            SobreNome = lname;
            Titulo = title;
            SalarioPorHora = salary;
        }
    }
}
