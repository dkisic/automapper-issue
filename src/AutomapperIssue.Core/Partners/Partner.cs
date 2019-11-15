using Abp.Domain.Entities;
using System;

namespace AutomapperIssue.Partners
{
    public class Partner : Entity<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string FullName => $"{Code}-{Name}";
    }
}
