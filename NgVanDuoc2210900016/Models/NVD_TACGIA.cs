﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NgVanDuoc2210900016.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NVD_TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NVD_TACGIA()
        {
            this.NVD_SACH = new HashSet<NVD_SACH>();
        }
        [Display(Name ="Mã tác giả")]
    
        public string Nvd_MaTG { get; set; }
        [Display(Name = "Tên tác giả")]
        public string Nvd_TenTacGia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NVD_SACH> NVD_SACH { get; set; }
    }
}
