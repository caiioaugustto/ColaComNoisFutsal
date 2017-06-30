using System;
using System.ComponentModel;

namespace ColaComNois.Entidades
{
    public class Jogos : EntityBase
    {
        public Quadro Quadro { get; set; }

        public DateTime Data { get; set; }

        public int ResultadoColaComNois { get; set; }

        public int ResultadoAdversario { get; set; }

        public bool Mandante { get; set; }

        public Referente Referente { get; set; }

        public string Observacao { get; set; }

        public int IdAdversario { get; set; }

        public virtual Adversarios Adversario { get; set; }
    }

    public enum Quadro
    {
        [Description("1° Quadro")]
        PrimeiroQuadro = '1',
        [Description("2° Quadro")]
        SegundoQuadro = '2'
    }

    public enum Referente
    {
        [Description("Amistoso")]
        Amistoso = '1',
        [Description("Campeonato")]
        Campeonato = '2',
        [Description("Festival")]
        Festival = '3',
        [Description("Fut Liga")]
        FutLiga = '4'
    }
}