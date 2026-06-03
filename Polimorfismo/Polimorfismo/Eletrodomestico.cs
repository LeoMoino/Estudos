using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Eletrodomestico
    {

        private readonly string _nome;

        public Eletrodomestico(string nome)
        {
            _nome = nome;
        }


        //abstract pq não tem implementação, cada classe filha tem que implementar
        public abstract void Ligar();   
        public abstract void Desligar();

    }
}
