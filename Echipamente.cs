//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica
{
    using System;
    using System.Collections.Generic;
    
    public partial class Echipamente
    {
        public int id_echipament { get; set; }
        public string nume_echipament { get; set; }
        public Nullable<int> id_producator { get; set; }
    
        public virtual Producatori Producatori { get; set; }
    }
}
