using System;
using System.Collections.Generic;
using System.Text;

namespace verificadordecpf
{
    class Verificador
    {
        public int Verificador1 { get; set; }
        public int Verificador2 { get; set; }

        int j = 10;
        public void Verifica(string cpf)
        {
            for (int i = 0; i < 9; i++)
            {
                Verificador1 += int.Parse(cpf[i].ToString()) * j;
                Console.WriteLine(Verificador1);
                j--;
            }
            Verificador1 = (Verificador1 * 10) % 11;
            Console.WriteLine(Verificador1);
            if (Verificador1 == int.Parse(cpf[9].ToString()))
            {
                j = 11;
                for (int i = 0; i<10;i++)
                {
                    Verificador2 += int.Parse(cpf[i].ToString()) * j;
                    Console.WriteLine(Verificador2);
                    j--;
                }
                Verificador2 = (Verificador2 * 10) % 11;
                Console.WriteLine(Verificador2);
                if (Verificador2 == int.Parse(cpf[10].ToString()))
                {
                    Console.WriteLine("CPF Válido");
                }
                else
                {
                    Console.WriteLine("CPF Inválido");
                }
            }
            else
            {
                Console.WriteLine("CPF inválido");
            }
        }
    }
}
