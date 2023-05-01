using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerduraoDoJoao2._0
{
    internal class Cliente
    {
        public static bool IsValidCpf(string CPF)
        {
            List<byte> digitosCPF = new List<byte>();
            string DigitosVerificadores;
            byte PrimeiroVerificador, SegundoVerificador;
            string cpfPattern = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            if (Regex.IsMatch(CPF, cpfPattern))
            {
                var cpfDividido = CPF.Split('-');
                DigitosVerificadores = cpfDividido[1];
                PrimeiroVerificador = byte.Parse(DigitosVerificadores[0].ToString());
                SegundoVerificador = byte.Parse(DigitosVerificadores[1].ToString());
                var NoveDigitos = cpfDividido[0].Split('.');
                foreach (var TresDigitos in NoveDigitos)
                {
                    foreach (var Digito in TresDigitos)
                    {
                        digitosCPF.Add(byte.Parse(Digito.ToString()));
                    }
                }
                var PrimeiroVerificadorCalculado = ((digitosCPF[0] +
                                                     digitosCPF[1] * 2 +
                                                     digitosCPF[2] * 3 +
                                                     digitosCPF[3] * 4 +
                                                     digitosCPF[4] * 5 +
                                                     digitosCPF[5] * 6 +
                                                     digitosCPF[6] * 7 +
                                                     digitosCPF[7] * 8 +
                                                     digitosCPF[8] * 9) % 11) % 10;

                var SegundoVerificadorCalculado = ((digitosCPF[1] +
                                                     digitosCPF[2] * 2 +
                                                     digitosCPF[3] * 3 +
                                                     digitosCPF[4] * 4 +
                                                     digitosCPF[5] * 5 +
                                                     digitosCPF[6] * 6 +
                                                     digitosCPF[7] * 7 +
                                                     digitosCPF[8] * 8 +
                                                     PrimeiroVerificadorCalculado * 9) % 11) % 10;
                if (PrimeiroVerificadorCalculado == PrimeiroVerificador &&
                    SegundoVerificadorCalculado == SegundoVerificador)
                {
                    return true;
                }
                else return false;

            }
            else return false;
        }
        public static bool IsValidCnpj(string cnpj)
        {
            string cnpjPattern = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
            if (!Regex.IsMatch(cnpj, cnpjPattern)) { return false; }

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            int[] weights1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] weights2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int sum1 = 0;
            for (int i = 0; i < weights1.Length; i++)
            {
                sum1 += weights1[i] * int.Parse(cnpj[i].ToString());
            }

            int sum2 = sum1;
            for (int i = 0; i < weights2.Length; i++)
            {
                sum2 += weights2[i] * int.Parse(cnpj[i].ToString());
            }

            int digit1 = sum1 % 11;
            digit1 = digit1 < 2 ? 0 : 11 - digit1;

            int digit2 = sum2 % 11;
            digit2 = digit2 < 2 ? 0 : 11 - digit2;

            return int.Parse(cnpj[12].ToString()) == digit1 && int.Parse(cnpj[13].ToString()) == digit2;
        }
    }

}
