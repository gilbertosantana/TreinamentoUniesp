﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Carro : IVeiculo
    {
        public Carro()
        {

        }
        public Carro(string cor, string nome)
        {
            this.Cor = cor;
            this.Nome = nome;
        }

        public string Cor { get; set; }
        public string Nome { get; set; }

        public string Tipo => "Carro";

        public string Buzinar() => "Biii";

        public string Buzinar(string buzina)
        {
            return buzina;
        }
    }
}