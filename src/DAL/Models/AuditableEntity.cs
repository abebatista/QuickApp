﻿// ====================================================
// More Templates: https://www.ebenmonney.com/templates
// Email: support@ebenmonney.com
// ====================================================

using DAL.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class AuditableEntity : IAuditableEntity
    {
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}