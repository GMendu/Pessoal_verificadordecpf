using System;
using System.Collections.Generic;
using System.Text;

namespace verificadorcpfform
{
    class verificador
    {
        public int Verificador1 { get; set; }
        public int Verificador2 { get; set; }

        int j = 10;
        public string Verifica(string cpf)
        {
            for (int i = 0; i < 9; i++)
            {
                char cpfzin = cpf[i];
                Verificador1 += int.Parse(cpfzin.ToString()) * j;
                j--;
            }
            Verificador1 = (Verificador1 * 10) % 11;
            if (Verificador1 == int.Parse(cpf[9].ToString()))
            {
                j = 11;
                for (int i = 0; i < 10; i++)
                {
                    Verificador2 += int.Parse(cpf[i].ToString()) * j;
                    j--;
                }
                Verificador2 = (Verificador2 * 10) % 11;
                if (Verificador2 == int.Parse(cpf[10].ToString()))
                {
                    return "CPF Válido";
                }
                else
                {
                    return "CPF Inválido";
                }
            }
            else
            {
                return "CPF inválido";
            }
        }
    }
}
