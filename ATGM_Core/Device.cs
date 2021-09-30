using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ATGM_Core
{
    public class Device
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a productnumber")]
        public string ProductNumber { get; set; }

        public string SerialNumber { get; set; }

        public string Description { get; set; }

        public double PurchaseValue { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime DeprecationDate { get; set; }

        public int MaintenanceInterval { get; set; }

        public bool OutOfUse { get; set; }

        public bool Archived { get; set; }

        public virtual Device Parent { get; set; }

        public ICollection<Device> ChildDevices { get; set; }

        public bool CompositeDevice()
        {
            return ChildDevices.Count(c => c?.Archived == Archived) > 0;
        }

        public Company Supplier { get; set; }

        public Company Maintainer { get; set; }

        public Company Manufacturer { get; set; }

    }
}
