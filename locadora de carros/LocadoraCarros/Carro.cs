using System;

namespace BethesdaCarRental1
{
    [Serializable]
    public class Carro
    {
        public string Fabricante;
        public string Modelo;
        public int Ano;
        public string Categoria;
        public bool TemCDPlayer;
        public bool TemDVDPlayer;
        public bool EstaDisponivel;

        public Carro()
        {
            Fabricante = "";
            Modelo = "";
            Ano = 0;
            Categoria = "";
            TemCDPlayer = false;
            TemDVDPlayer = false;
            EstaDisponivel = false;
        }

        public Carro(string fb, string mdl,
                   int an, string cat, bool cd,
                   bool dvd, bool disp)
        {
            Fabricante = fb;
            Modelo = mdl;
            Ano = an;
            Categoria = cat;
            TemCDPlayer = cd;
            TemDVDPlayer = dvd;
            EstaDisponivel = disp;
        }
    }
}
