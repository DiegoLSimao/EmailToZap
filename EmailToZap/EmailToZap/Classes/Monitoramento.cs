using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EmailToZap.Classes
{
    public class Monitoramento
    {
        public Monitoramento(List<string> EmailsMonitorar, List<string> ContatosNotificar, int tempo_m)
        {
            IniciarTimer(tempo_m);
        }

        private void IniciarTimer(int tempo_m = 1)
        {
            int tempo_ms = tempo_m * 60 * 1000;
            var timer = new System.Timers.Timer(tempo_ms);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            //***leitura do email
        }
    }
}
