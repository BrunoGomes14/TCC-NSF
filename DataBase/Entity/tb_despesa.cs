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
    
    public partial class tb_despesa
    {
        public int id_despesa { get; set; }
        public string tp_despesa { get; set; }
        public Nullable<decimal> vl_despesa { get; set; }
        public Nullable<System.DateTime> dt_vencimento { get; set; }
        public Nullable<System.DateTime> dt_pagamento { get; set; }
    }
}
