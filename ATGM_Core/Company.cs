using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ATGM_Core
{
    public class Company
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public bool Supplier { get; set; }

        public bool Manufacturer { get; set; }

        public bool Maintainer { get; set; }
    }
}
