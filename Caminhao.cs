using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace VerduraoDoJao.Melanciometro
{
    internal class Caminhao
    {
        public static Dictionary<object, Caminhao> caminhoes = new Dictionary<object, Caminhao>();
        public static Dictionary<string, string[]> modelos = new Dictionary<string, string[]>() { {"Volvo"        , new string[] {"FH 540",
                                                                                                                                  "FH 460",
                                                                                                                                  "FH 500",
                                                                                                                                  "Titan L935",
                                                                                                                                  "N1020",
                                                                                                                                  "NL10 340",
                                                                                                                                  "VM 260"} },
                                                                                                  {"Scania"       , new string[] {"R 450",
                                                                                                                                  "R 500",
                                                                                                                                  "P",
                                                                                                                                  "L 111 S Jacaré",
                                                                                                                                  "LK 140",
                                                                                                                                  "113H",
                                                                                                                                  "P94D 260",
                                                                                                                                  "R 440" } },
                                                                                                  {"Mercedes-Benz", new string[] {"Actros 2651",
                                                                                                                                  "Actros 2546",
                                                                                                                                  "Axor 2544",
                                                                                                                                  "Axor 3344",
                                                                                                                                  "Atego 2425",
                                                                                                                                  "L 1111",
                                                                                                                                  "L 1113",
                                                                                                                                  "L-608 D",
                                                                                                                                  "L1620",
                                                                                                                                  "710", "Accelo 815"} },
                                                                                                  {"DAF"          , new string[] {"XF 105 510" } },
                                                                                                  {"Ford"         , new string[] {"Cargo",
                                                                                                                                  "F600"} },
                                                                                                  {"Volksvagen"   , new string[] {"Delivery 8-150",
                                                                                                                                  "Constellation 24-250",
                                                                                                                                  "24250",
                                                                                                                                  "8150",
                                                                                                                                  "9150",
                                                                                                                                  "13180"} },
                                                                                                  {"Iveco"        , new string[] {"Hi-Way" } },
                                                                                                  {"Chevrolet"    , new string[] {"D-60",
                                                                                                                                  "C6500",
                                                                                                                                  "3100" } }
                                                                                            };
        public string Placa { set; get; }
        public string Proprietario { set; get; }
        public string? Fabricante { set; get; }
        public string? Modelo { set; get; }
        public string? Cor { set; get; }
        public int? AnoDeFabricacao { set; get; }
        public int? KmRodado { set; get; }
        public string? Renavam { set; get; }

        public Dictionary<int, Carga> Cargas { set; get; }


        public Caminhao(string placa, string proprietario)
        {
            Placa = placa;
            Proprietario = proprietario;
            Cargas = new Dictionary<int, Carga>();
            caminhoes.Add(placa, this);

        }
        public Caminhao(Dictionary<string,string> args)
        {
            Placa = args["Placa"];
            Proprietario = args["Id"];
            if (args.ContainsKey("Fabricante"))
                Fabricante = args["Fabricante"];
            if (args.ContainsKey("Modelo"))
                Modelo = args["Modelo"];
            if (args.ContainsKey("Cor"))
                Cor = args["Cor"];
            if (args.ContainsKey("Ano de Fabricação")) 
                AnoDeFabricacao = int.Parse(args["Ano de Fabricação"]);
            if (args.ContainsKey("Km Rodado"))
                KmRodado = int.Parse(args["Km Rodado"]);
            if (args.ContainsKey("Renavam"))
                Renavam = args["Renavam"];
            Cargas = new Dictionary<int, Carga>();
            caminhoes.Add(Placa, this);
        }

        public int CriaCarga()
        {
            int idDaVenda = this.Cargas.Count;
            this.Cargas.Add(idDaVenda, new Carga(idDaVenda));
            return idDaVenda;
        }

        public void AdicionaCarga(Produto Produto, int diaDaSemana, double quantProduto, int idDaVenda)
        {
            string nomeProduto = Produto.Nome;
            this.Cargas[idDaVenda].Produtos.Add(nomeProduto, new ProdutoVendido(Produto, quantProduto, diaDaSemana));
        }
        public void ModificaCarga(Produto Produto, int diaDaSemana, double novaQuantProduto, int idDaVenda)
        {
            string nomeProduto = Produto.Nome;
            this.Cargas[idDaVenda].Produtos[nomeProduto] = new ProdutoVendido(Produto, novaQuantProduto, diaDaSemana);
        }
        public static bool IsValidPlate(string placa)
        {
            string placaMercosulPattern = "^[A-Z]{3}[0-9][0-9A-Z][0-9]{2}$";
            string placaAntigaPattern = "^[A-Z]{3}-[0-9]{4}$";
            if (Regex.IsMatch(placa, placaMercosulPattern) || Regex.IsMatch(placa, placaAntigaPattern))
            {
                return true;
            }
            else return false;
        }

        public static bool IsValidRenavam(string renavam)
        {

            if (renavam.Length != 11)
            {
                renavam = renavam.PadRight(11, '0');
            }
            if (!Regex.IsMatch(renavam, "^[0-9]{11}$")) return false;


            int[] digitos = GetDigitosInvertidos(renavam);
            var verificador = GetDigitoVerificador(renavam);
            var soma = GetSoma(digitos);
            var verificadorCalculado = GetVerificador(soma);
            return verificadorCalculado == verificador;

        }
        private static int[] GetDigitosInvertidos(string digitos)
        {
            char[] digitosChar = digitos.ToCharArray();
            Array.Reverse(digitosChar);
            return Array.ConvertAll(digitosChar, c => (int)Char.GetNumericValue(c));
        }
        private static int GetDigitoVerificador(string digitos)
        {
            string digito = digitos.Last().ToString();
            return int.Parse(digito);
        }
        private static int GetSoma(int[] digitos)
        {
            var soma = 0;
            for (var i = 0; i < digitos.Length; i++)
            {
                soma += digitos[i] * GetFactor(i);
            }
            return soma;
        }
        private static int GetFactor(int num)
        {
            int[] digits = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int index;
            if (num >= digits.Length)
            {
                index = num % digits.Length;
            }
            else
            {
                index = num;
            }
            return digits[index];
        }
        private static int GetVerificador (int soma)
        {
            var valor = 11 - (soma % 11);
            if (valor >= 10) return 0;
            return valor;
        }
    }
}
