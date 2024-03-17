using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalicaoPOO_4sem
{
    public class ConsoleAndFileLog : ConsoleLog
    {
        private string filePath;

        public ConsoleAndFileLog(string filePath)
        {
            this.filePath = filePath;
        }

        public override void LogInformation(string mensagem)
        {
            base.LogInformation(mensagem);
            LogToFile("[INFORMATION]", mensagem);
        }

        public override void LogError(string mensagem)
        {
            base.LogError(mensagem);
            LogToFile("[ERROR]", mensagem);
        }

        public override void LogInformation(string mensagem, string mode)
        {
            base.LogInformation(mensagem, mode);
            if (mode.ToLower() == "full")
            {
                LogToFile("[INFORMATION]", mensagem);
            }
        }

        public override void LogError(string mensagem, string mode)
        {
            base.LogError(mensagem, mode);
            if (mode.ToLower() == "full")
            {
                LogToFile("[ERROR]", mensagem);
            }
        }

        private void LogToFile(string messageType, string mensagem)
        {
            using (var fs = new FileStream(filePath, FileMode.Append))
            using (var sw = new StreamWriter(fs))
            {
                sw.WriteLine($"{messageType} {mensagem}");
            }
        }
    }
}
