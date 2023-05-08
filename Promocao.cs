using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerduraoDoJao.Melanciometro
{
    internal class Promocao
    {
        public static List<Promocao> promocoes = new List<Promocao>() { new Promocao(1,1),
                                                                        new Promocao(2,15,"Terça Verde"),
                                                                        new Promocao(3,17, "Quarta Verde"),
                                                                        new Promocao(4,2),
                                                                        new Promocao(5,3)
                                                                        };
        public int diaDaSemana { get; private set; }
        private double desconto;
        public string descPromocao { get; private set; }
        public Promocao(int diaDaSemana, double desconto) 
        { 
            this.diaDaSemana = diaDaSemana;
            this.desconto = desconto;
            this.descPromocao = "-";
        }
        public Promocao(int diaDaSemana, double desconto, string descPromocao)
        {
            this.diaDaSemana = diaDaSemana;
            this.desconto = desconto;
            this.descPromocao = descPromocao;
        }
        public static List<string> AplicaPromocao(Produto produto, int diaDaSemana)
        {
            Console.WriteLine("dia recebido:"+diaDaSemana);
            Console.ReadLine();
            double preco = produto.Preco;
            double desconto;
            string descPromocao;
            var promocao = promocoes.Find(x => x.diaDaSemana == diaDaSemana);
            if (promocao != null)
            {
                desconto = promocao.desconto;
                descPromocao = promocao.descPromocao;
            }
            else
            {
                desconto = 0;
                descPromocao = "-";
            }
            
            var precoPromocional = (preco - (preco * (desconto/100))).ToString();
            return new List<string> { precoPromocional, descPromocao };
        }
    }
}
