using System.Collections.Generic;
using UnifiedContract.Domain.Entities.Common;

namespace UnifiedContract.Domain.Entities.Resource.Lookups
{
    /// <summary>
    /// Status options for equipment (Available, InUse, UnderMaintenance, Damaged, Retired)
    /// </summary>
    public class EquipmentStatus : Lookup
    {
        /// <summary>
        /// Whether equipment with this status can be assigned to work orders
        /// </summary>
        public bool CanBeAssigned { get; set; }
        
        /// <summary>
        /// Whether equipment with this status incurs daily costs
        /// </summary>
        public bool IncursCost { get; set; } = true;
        
        /// <summary>
        /// Whether this is an operational status
        /// </summary>
        public bool IsOperational { get; set; } = true;
        
        /// <summary>
        /// Color code for UI representation (hex or named color)
        /// </summary>
        public string ColorCode { get; set; }
        
        /// <summary>
        /// Navigation property for equipment with this status
        /// </summary>
        public virtual ICollection<Equipment> Equipment { get; set; }

        public EquipmentStatus()
        {
            Equipment = new HashSet<Equipment>();
        }
    }
} 