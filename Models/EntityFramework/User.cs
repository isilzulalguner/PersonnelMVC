//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonnelMVC.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int ID { get; set; }

        [Display(Name = "Kullan�c� Ad�")]
        [Required(ErrorMessage = "Kullan�c� ad� bilgisi zorunludur!")]
        public string Username { get; set; }

        [Display(Name = "�ifre")]
        [Required(ErrorMessage = "�ifre zorunludur!")]
        public string Password { get; set; }

        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Rol bilgisi zorunludur!")]
        public string Role { get; set; }
    }
}
