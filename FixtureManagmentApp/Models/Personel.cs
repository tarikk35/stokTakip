//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FixtureManagmentApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        public int perID { get; set; }
        public string perIsim { get; set; }
        public string perTCNo { get; set; }
        public Nullable<int> perTipID { get; set; }
        public Nullable<int> bolumID { get; set; }
        public Nullable<bool> perAktif { get; set; }
        public Nullable<System.DateTime> perIseGiris { get; set; }
        public Nullable<System.DateTime> perIsCikis { get; set; }
    }
}
