using System;
using UnifiedContract.Domain.Common;

namespace UnifiedContract.Domain.Entities.Document
{
    public class DocumentTemplate : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } // WorkOrder, Invoice, Report, Form, etc.
        public string ContentType { get; set; } // HTML, PDF, DOCX, etc.
        public string TemplateUrl { get; set; }
        public string TemplateContent { get; set; }
        public bool IsActive { get; set; }
        public int Version { get; set; }
        public Guid CreatedById { get; set; }
        public Guid? LastModifiedById { get; set; }
        
        // Navigation properties
        public virtual User CreatedBy { get; set; }
        public virtual User LastModifiedBy { get; set; }
    }
} 