//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoBai4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        public int MA_NV { get; set; }
        public string TEN_NV { get; set; }
        public string DIA_CHI { get; set; }
        public string SO_DIEN_THOAI { get; set; }
        public int MA_PB { get; set; }
    
        public virtual PHONGBAN PHONGBAN { get; set; }
    }
}
