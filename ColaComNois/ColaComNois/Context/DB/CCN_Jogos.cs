//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ColaComNois.Context.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class CCN_Jogos
    {
        public int Id { get; set; }
        public string Quadro { get; set; }
        public System.DateTime Data { get; set; }
        public int ResultadoColaComNois { get; set; }
        public int ResultadoAdversario { get; set; }
        public bool Mandante { get; set; }
        public string Referente { get; set; }
        public string Observacao { get; set; }
        public int IdAdversario { get; set; }
    
        public virtual CCN_Adversario CCN_Adversario { get; set; }
    }
}