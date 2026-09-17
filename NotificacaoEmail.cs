using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class NotificacaoEmail : INotificacao
    {
        public void Enviar()
        {
            Console.WriteLine("Enviando notificação por email...");
        }
        public void Enviar(string anexo)
        {
            Console.WriteLine($"Enviando email com anexo: {anexo}");
        }
    }
}
