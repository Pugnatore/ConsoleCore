using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public string Chutar()
        {
            return "Maradona esta chutando";
        }

        public string Corre()
        {
            return "Maradona esta correndo";
        }

        public string Passe()
        {
            return "Maradona esta passando";
        }
    }
}