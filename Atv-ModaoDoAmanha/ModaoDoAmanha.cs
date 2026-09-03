using System;
using System.Collections.Generic;
using System.Text;

namespace Atv_ModaoDoAmanha
{
    internal class AlunoMusica
    {
        public string Nome { get; set; } = string.Empty;
        public double MensalidadeBase { get; set; }
        public double HorasPraticaSemanal { get; set; }
        public int NivelHabilidade { get; set; }


        public double DescontoHoras()
        {
            bool descontoMensalidade = HorasPraticaSemanal > 10.0;
            return descontoMensalidade ? (HorasPraticaSemanal * 0.15) - MensalidadeBase : MensalidadeBase;
        }

        public double HorasFaltantesProximoNivel()
        {
            double Nivel1 = NivelHabilidade * 60;
            double Nivel2 = NivelHabilidade * 80;
            double Nivel3 = NivelHabilidade * 85;
            double Nivel4 = NivelHabilidade * 90;
            double Nivel5 = NivelHabilidade * 100;
            return  HorasPraticaSemanal * 4;
        }

        public double MensalidadeFinal()
        {
            double valorFinal = DescontoHoras() / MensalidadeBase;
            return valorFinal;
        }

        public bool BolsaOrquestral()
        {
            return (NivelHabilidade >= 3) || (HorasPraticaSemanal > 8);
        }
    }
}       
