using Core.Interfaces;
using System.Runtime.InteropServices;

namespace Core.Entities
{
    public abstract class Supplier: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public string CUIT { get; set; }
        public string? ContactPerson { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; }
        
        public int ProductSupplierId { get; set; }
        public int AccountId { get; set; }
        public int PurchaseId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual ProductSupplier ProductSupplier { get; set; }
        public virtual Account Account { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
