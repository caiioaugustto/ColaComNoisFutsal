using System.ComponentModel;

namespace ColaComNois.Entidades
{
    public class Adversarios : EntityBase
    {
        public string Nome { get; set; }

        public string Responsavel { get; set; }

        public string Telefone { get; set; }

        public Nota Nota { get; set; }

        public string Observacao { get; set; }
    }

    public enum Nota
    {
        [Description("Péssimo de 0 a 3")]
        Pessimo = 'P',
        [Description("Bom de 4 a 7")]
        Bom = 'B',
        [Description("Excelente de 8 a 10")]
        Excelente = 'E'
    }
}