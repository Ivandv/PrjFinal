//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoKioski
{
    using System;
    using System.Collections.Generic;
    
    public partial class produto
    {
        public produto()
        {
            this.pedidoprodutoes = new HashSet<pedidoproduto>();
        }
    
        public int id { get; set; }
        public string descricao { get; set; }
        public string medida { get; set; }
        public float valor { get; set; }
    
        public virtual ICollection<pedidoproduto> pedidoprodutoes { get; set; }
    }
}