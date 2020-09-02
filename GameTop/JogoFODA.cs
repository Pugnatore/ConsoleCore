using System;
using GameTop.Interface;

namespace GameTop
{
    public class JogoFODA
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;


        public JogoFODA(IJogador jogadorA, IJogador jogadorB)
        {
            _jogadorA = jogadorA;
            _jogadorB=jogadorB; 

        }
        public void IniciarJogo()
        {
           Console.WriteLine( _jogadorA.Corre());
           Console.WriteLine( _jogadorA.Chutar());
           Console.WriteLine( _jogadorA.Passe());

           Console.WriteLine( _jogadorB.Corre());
           Console.WriteLine( _jogadorB.Chutar());
           Console.WriteLine( _jogadorB.Passe());
        }
    }
}