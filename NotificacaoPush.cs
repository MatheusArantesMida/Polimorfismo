using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class NotificacaoPush : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação push para o app...");
        }
    }
}
