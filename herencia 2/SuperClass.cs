using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_2
{
    internal class SuperClass : Object
    {
        private string Carro;

        private string Bicicleta;

        public SuperClass() { }


        public SuperClass (string Carro, string Bicicleta)
        {

            this.Carro = Carro;
            this.Bicicleta = Bicicleta; 

        }

        public string getCarro()
        {
            return Carro;
        }

        public void setCarro(string Carro)
        {
            this.Carro = Carro;
        }

        public string getBicicleta()
        {
            return Bicicleta;
        }

        public void setBicicleta()
        {
            this.Bicicleta = Bicicleta;
        }
    }
}
