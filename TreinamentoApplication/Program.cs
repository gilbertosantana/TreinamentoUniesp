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
            var listCarro = new List<Carro>();

            //Instanciando um carro invocando o construtor default
            Carro veiculo = new Carro();

            //Povoando a lista...
            listCarro.Add(new Carro("verde", "fusca", 1));
            listCarro.Add(new Carro("azul", "fusca", 1));
            listCarro.Add(new Carro("azul", "vectra", 2));
            //listCarro.Add(new Carro("branco", "gol", 1));
            //Instanciando um objeto carro utilizando um inicializador de objetos
            //Ao invés de invocar um construtor
            //listCarro.Add(new Carro
            //{
            //    Cor = "branco",
            //    Nome = "uno"
            //});

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
            var carroRepositorio = new CarroRepositorio();
            
            //carroRepositorio.AddCarro(listCarro);
            
            try
            {
                Carro c;
                //ObterPorId
                //c = carroRepositorio.ObterPorId(31);
                //Console.WriteLine($"Id: {c.Id}, Nome: {c.Nome}, Cor: {c.Cor}, IdMarca {c.IdMarca}");

                //ObterPorNome
                var c1 = carroRepositorio.ObterPorNome("gol");
                foreach(var carros in c1)
                {
                    Console.WriteLine($"Id: {carros.Id}, Nome: {carros.Nome}, Cor: {carros.Cor}, IdMarca {carros.IdMarca}");
                }

                //ObterPorMarca
                //var c2 = carroRepositorio.ObterPorMarca("vw");
                //aforeach(var marca in c2)
                //{
                //    Console.WriteLine($"Nome {marca}");
                //}

                //AdicionarVarios
                //carroRepositorio.AdicionarVarios(listCarro);

                //Atualizar
                //var carro = carroRepositorio.ObterPorId(31);
                //carro.Cor = "Preto";
                //carroRepositorio.Atualizar(carro);
               //carro = carroRepositorio.ObterPorId(31);
               // Console.WriteLine(carro.Cor);

                //carroRepositorio.Deletar(carro);

                foreach(var todos in carroRepositorio.ObterTodos())
                {
                    Console.WriteLine(todos.Cor);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}
