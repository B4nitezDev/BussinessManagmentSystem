using Core.Interfaces;
using Core.VOs;

namespace Core.Entities
{
    public class User: BaseEntity, IAuditApproval
    {
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public Email Email { get; set; }
        public string NormalizedEmail { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string? ConcurrencyStamp { get; set; } = string.Empty;
        public Phone? PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; } = false;
        public bool? TwoFactorEnabled { get; set; } = false;
        public bool IsActive { get; set; } = true;
        
        public List<int> StockEntriesId { get; set; } = [];
        public List<int> UserRolesId { get; set; } = [];
        public List<int> InventoryAdjusmentsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual List<StockEntries> StockEntries { get; set; } = [];
        public virtual List<UserRoles> UserRoles { get; set; }
        public virtual List<InventoryAdjustments> InventoryAdjustments { get; set; }
    }
}
