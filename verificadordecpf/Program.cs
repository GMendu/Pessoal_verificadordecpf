using System;

namespace verificadordecpf
{
    class Program
    {
        static void Main(string[] args)
        {
            Verificador a = new Verificador();
            Console.Write("digite o cpf(apenas números): ");
            string cepefe = Console.ReadLine();
            a.Verifica(cepefe);
        }
    }
}
