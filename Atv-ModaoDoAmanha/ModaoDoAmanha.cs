using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
            return descontoMensalidade ? MensalidadeBase - (MensalidadeBase * 0.15)  : MensalidadeBase - (MensalidadeBase * 0.05);
        }

        public double HorasFaltantesProximoNivel()
        {
            double Progresso = HorasPraticaSemanal * 4;
            return Progresso;
        }

        public double ProximoNivel()
        {
            bool NivelAluno = HorasFaltantesProximoNivel() >= 180;
            return NivelAluno ? (NivelHabilidade + 1) : NivelHabilidade;
        }



        public double MensalidadeFinal()
        {
            double valorFinal = (DescontoHoras() / MensalidadeBase) + DescontoHoras();
            return valorFinal;
        }

        public bool BolsaOrquestral()
        {
            double NovoNivel = ProximoNivel();
            return (NovoNivel >= 3) && (HorasPraticaSemanal > 8);
        }
    }
}       
