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
    
    public partial class esemenyek
    {
        public int Id { get; set; }
        public string megnevezes { get; set; }
        public System.DateTime idopont { get; set; }
        public string leiras { get; set; }
        public string helyszin { get; set; }
        public bool csoportos { get; set; }
        public int letrehozo { get; set; }
        public Nullable<int> meghivott_szemely { get; set; }
        public Nullable<int> meghivott_csoport { get; set; }
    
        public virtual csoportok csoportok { get; set; }
        public virtual felhasznalok felhasznalok { get; set; }
        public virtual felhasznalok felhasznalok1 { get; set; }
    }
}