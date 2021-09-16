using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryManagement.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool? Edit { get; set; }
        public bool? AddAdmin { get; set; }
    }
}
