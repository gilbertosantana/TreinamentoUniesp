using Backend;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreinamentoApplication
{
    class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("Bem Vindos ao Treinamento .NET");

            //Criando uma lista de objetos que implementam a interface IVeiculo
            var listCarro = new List<IVeiculo>();

            //Instanciando um carro invocando o construtor default
            Carro veiculo = new Carro();

            //Povoando a lista...
            listCarro.Add(new Carro("verde", "fusca"));
            listCarro.Add(new Carro("azul", "fusca"));
            listCarro.Add(new Carro("azul", "vectra"));
            listCarro.Add(new Carro("branco", "gol"));

            //Instanciando um objeto carro utilizando um inicializador de objetos
            //Ao invés de invocar um construtor
            listCarro.Add(new Carro
            {
                Cor = "branco",
                Nome = "uno"
            });

            //Consulta LINQ no formato method query
            //OBS.: Atenção para a transformação que está sendo feita através do método Select()
            var listOrdenada = listCarro
                                .OrderBy(x => x.Cor)
                                .Select(carr =>
                                new Moto
                                {
                                    Cor = carr.Cor,
                                    Nome = carr.Nome
                                });

            //Consulta LINQ no formato query based
            var listaOrdenada2 = from list in listCarro
                                 orderby list.Cor
                                 select new Moto
                                 {
                                     Cor = list.Cor,
                                     Nome = list.Nome
                                 };

            //Iterando sob a lista e imprimindo no console os valores das propriedades do objetos.
            foreach (var v in listaOrdenada2)
            {
                Console.WriteLine($"{v.Tipo}: {v.Cor}");
                Console.WriteLine($"Nome: {v.Nome}");
            }

            Console.ReadKey();
        }
    }
}
