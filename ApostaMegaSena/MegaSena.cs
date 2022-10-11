using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostaMegaSena
{
    internal class MegaSena
    {
        public int[] numerosAposta = new int[10];
        public int[] resultado = new int[6];


        public void leAposta(int[] numerosAposta)
        {
            for(int i = 0; i < numerosAposta.Length; i++)
            {
                this.numerosAposta[i] = numerosAposta[i];
            }
        }

        public int[] apuraResultado()
        {
            Random random = new Random();
            int numeroSorteado;

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    numeroSorteado = random.Next();
                } while (numeroSorteado > 60);

                if (!resultado.Contains(numeroSorteado))
                    resultado[i] = numeroSorteado;
                else
                    i--;
            }

            return resultado;
        }

        public int pontosFinais()
        {
            int contPontos = 0;
            foreach(int j in numerosAposta)
            {
                if (resultado.Contains(j))
                    contPontos++;
            }
            return contPontos;
        }
    }
}
