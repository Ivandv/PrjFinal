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
    
    public partial class funcionario
    {
        public funcionario()
        {
            this.pedidoes = new HashSet<pedido>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string pis { get; set; }
        public string fone { get; set; }
        public string endereco { get; set; }
        public string rg { get; set; }
        public string sexo { get; set; }
        public System.DateTime dt_nasc { get; set; }
    
        public virtual ICollection<pedido> pedidoes { get; set; }
    }
}
