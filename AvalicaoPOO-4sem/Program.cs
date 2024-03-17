using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalicaoPOO_4sem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando objetos da interface ILog pro exemplo do polimorfismo pedido no exercicio 5
            ILog consoleLog = new ConsoleLog();
            ILog consoleAndFileLog = new ConsoleAndFileLog("avaliacao1poo.txt");

            try
            {
                int dividendo = 10;
                int divisor = 0;

                int variavelTesteProfessor1; //Aqui é caso vc queira testar outros valores, mas troque os valores de referência no código. Ou troque diretamente os valores ali em cima (dividendo e divisor).
                int variavelTesteProfessor2; //Aqui é caso vc queira testar outros valores, mas troque os valores de referência no código. Ou troque diretamente os valores ali em cima (dividendo e divisor).

                // Tentativa de fazer a divisão
                int resultado = dividendo / divisor;

                // Se a divisão der certo, registra uma informação
                consoleLog.LogInformation($"A divisão de {dividendo} por {divisor} é igual a {resultado}");
                consoleAndFileLog.LogInformation($"A divisão de {dividendo} por {divisor} é igual a {resultado}");
            }
            catch (DivideByZeroException ex)
            {
                // Se houver alguma exceção de divisão por zero, registra um erro
                consoleLog.LogError($"Erro ao dividir: {ex.Message}");
                consoleAndFileLog.LogError($"Erro ao dividir: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Se houver qualquer outra exceção, registra um erro
                consoleLog.LogError($"Erro inesperado: {ex.Message}");
                consoleAndFileLog.LogError($"Erro inesperado: {ex.Message}");
            }

            Console.WriteLine("Operação de divisão concluída.");
            Console.ReadLine(); //Como eu uso Visual Studio, este comando ajuda a não fechar o programa se eu não clicar em nenhuma tecla. Mas no VSCode não é necessário o uso desse comando.
        }
    }

}
