using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomapperIssue.Partners
{
    public class Partner : Entity<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        [NotMapped]
        public string FullName => $"{Code}-{Name}";
    }
}
