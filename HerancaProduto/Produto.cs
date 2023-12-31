using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaProduto
{
    public class Produto
    {
        protected int codigo;
        protected string nome;
        protected double preco;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public Produto(int cod, string nom, double preco)
        {
            Codigo = cod;
            Nome = nom;
            Preco = preco;
        }
        public virtual void Mostrar() 
        {
            Console.WriteLine($"Código: {Codigo} \tNome: {Nome} \tPreço: {Preco:C}");
        }
    }
}