using System;

namespace ClasesyObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase1 = new Clase();
            clase1.Metodo();             
        }
    }

    class  Clase{
        public void Metodo(){

            console.writeline("esto es un metodo");
        }
    }
}
