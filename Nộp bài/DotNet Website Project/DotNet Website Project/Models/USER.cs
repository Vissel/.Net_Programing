﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNet_Website_Project.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class USER
    {
        public int USER_ID { get; set; }

        [Required(ErrorMessage ="Username không được bỏ trống")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email không hợp lệ")]
        public string USERNAME { get; set; }

        [Required(ErrorMessage = "Password không được bỏ trống")]
        [DataType(DataType.Password)]
        public string PASSOWORD { get; set; }
        public Nullable<int> USER_STATUS { get; set; }
        public Nullable<int> ROLE_ID { get; set; }
        public string JOINED_DATE { get; set; }
        public string FACEBOOK_ID { get; set; }
        public string GMAIL_ID { get; set; }
        public string RESET_TOKEN { get; set; }

        public String LoginErrorMessage { get; set; }
    }
}
