using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalicaoPOO_4sem
{
    public class ConsoleLog : ILog
    {
        public virtual void LogInformation(string mensagem)
        {
            LogMessage("[INFORMATION]", mensagem, "Full");
        }

        public virtual void LogError(string mensagem)
        {
            LogMessage("[ERROR]", mensagem, "Full");
        }

        public virtual void LogInformation(string mensagem, string mode)
        {
            LogMessage("[INFORMATION]", mensagem, mode);
        }

        public virtual void LogError(string mensagem, string mode)
        {
            LogMessage("[ERROR]", mensagem, mode);
        }

        private void LogMessage(string messageType, string mensagem, string mode)
        {
            if (mode.ToLower() == "simple")
            {
                Console.WriteLine(mensagem);
            }
            else
            {
                Console.WriteLine($"{messageType} {mensagem}");
            }
        }
    }
}
