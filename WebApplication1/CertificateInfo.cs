//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class CertificateInfo
    {
        public int Id { get; set; }
        [DisplayName("Certification Number")]
        public string CertificateNo { get; set; }
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Company Address")]
        public string CompanyAddress { get; set; }
        public string Country { get; set; }
        public string Scope { get; set; }
        [DisplayName("Registration Date")]
        public string RegistrationDate { get; set; }
        [DisplayName("Re-Registration Date")]
        public string ReRegistrationDate { get; set; }
        public string Standard { get; set; }
        public string Status { get; set; }
    }
}
