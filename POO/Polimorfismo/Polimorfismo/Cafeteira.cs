using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Cafeteira : Eletrodomestico
    {
        public Cafeteira(string nome) : base(nome)
        {
        }
        private static void AquecerAgua()
        {
            Console.WriteLine("Aquecendo a água...");
        }

        private static void ColocarCapsula()
        {
            Console.WriteLine("Colocando a cápsula de café...");
        }

        public void PrepararCafe()
        {
            AquecerAgua();
            ColocarCapsula();
            Console.WriteLine("Café preparado!");
        }

        //Override significa que eu posso sobrescrever ele, ou seja, eu posso implementar ele de uma forma diferente do que foi definido na classe abstrata
        public override void Ligar()
        {
            //regra de negócio para ligar a cafeteira
            throw new NotImplementedException();
        }

        public override void Desligar()
        {
            //regra de negócio para desligar a cafeteira
            throw new NotImplementedException();
        }
    }
}
