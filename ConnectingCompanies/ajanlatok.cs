//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConnectingCompanies
{
    using System;
    using System.Collections.Generic;
    
    public partial class ajanlatok
    {
        public int Id { get; set; }
        public int kezdo_ceg { get; set; }
        public int fogado_ceg { get; set; }
        public string megnevezes { get; set; }
        public System.DateTime kezdes_datum { get; set; }
        public Nullable<System.DateTime> zaras_datum { get; set; }
        public int osszeg { get; set; }
        public string leiras { get; set; }
    
        public virtual csoportok csoportok { get; set; }
        public virtual csoportok csoportok1 { get; set; }
    }
}
