using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvalicaoPOO_4sem
{
    public interface ILog
    {
        void LogInformation(string mensagem);

        void LogError(string mensagem);

        void LogInformation(string mensagem, string mode);

        void LogError(string mensagem, string mode);
    }
}
