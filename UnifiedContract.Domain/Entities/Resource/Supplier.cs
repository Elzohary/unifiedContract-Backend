using System;
using System.Collections.Generic;
using UnifiedContract.Domain.Common;
using UnifiedContract.Domain.ValueObjects;

namespace UnifiedContract.Domain.Entities.Resource
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AlternatePhone { get; set; }
        public Address Address { get; set; }
        public string Website { get; set; }
        public string Category { get; set; } // Materials, Equipment, Services, etc.
        public string VatNumber { get; set; }
        public string PaymentTerms { get; set; }
        public string BankAccount { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public decimal Rating { get; set; } // 1-5 rating
        
        // Navigation properties
        public virtual ICollection<PurchasableMaterial> Materials { get; set; }
        
        public Supplier()
        {
            Materials = new HashSet<PurchasableMaterial>();
        }
    }
} 