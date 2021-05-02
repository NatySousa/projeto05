using Projeto05.Controllers;
using System;

namespace Projeto05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSISTEMA DE CONTROLE DE EMPRESAS E FUNCIONÁRIOS\n");

            var empresaController = new EmpresaController();

            Console.WriteLine("(1) Cadastrar empresa");
            Console.WriteLine("(2) Atualizar empresa");
            Console.WriteLine("(3) Excluir empresa");
            Console.WriteLine("(4) Consultar empresas");

            try
            {
                Console.Write("\nEscolha a opção desejada: ");
                var opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        empresaController.CadastrarEmpresa();
                        Main(args); //recursividade
                        break;

                    case 2:
                        empresaController.AtualizarEmpresa();
                        Main(args); //recursividade(looping)
                        break;

                    case 3:
                        empresaController.ExcluirEmpresa();
                        Main(args); 
                        break;

                    case 4:
                        empresaController.ConsultarEmpresas();
                        Main(args); 
                        break;

                    case 0:
                        Console.WriteLine("\nFIM DO PROGRAMA!");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
