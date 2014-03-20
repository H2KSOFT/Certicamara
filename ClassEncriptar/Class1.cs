using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassEncriptar
{
    class Class1
    {
        public static void Main(string[] args)
        {
            ClassEncriptar clEncriptar = new ClassEncriptar();
            String pTexto = "Colombia2014";
            String pRuta = @"C:\CreacionLlaves\200320140129009051_pp.xml";
            String pResultado = clEncriptar.EncriptarTexto(pRuta, pTexto);
            Console.WriteLine("Ruta:");
            Console.WriteLine(pRuta);
            Console.WriteLine("Texto:");
            Console.WriteLine(pTexto);
            Console.WriteLine("Texto Firmado:");
            Console.WriteLine(pResultado);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------");
            String p = Console.ReadLine();
        }
    }
}
