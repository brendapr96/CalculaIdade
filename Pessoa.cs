﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculaIdade
{
    public class Pessoa
    {
        //Para criar propfull+tab
        private int anoNascimento;

        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }


        public void ExibirDados() 
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano nascimento: " + this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("idade: " + idade);
        
        }

        private int CalcularIdade () 
        { 
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }
    }
}
