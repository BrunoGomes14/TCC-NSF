//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCC.DataBase.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_falta
    {
        public int id_falta { get; set; }
        public int id_funcionario { get; set; }
        public bool bl_falta_justificada { get; set; }
        public Nullable<System.DateTime> dt_falta { get; set; }
        public string ds_justificativa { get; set; }
    
        public virtual tb_funcionario tb_funcionario { get; set; }
    }
}