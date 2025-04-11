using Core.Interfaces;

namespace Core.Entities
{
    public class Kiosk: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        
        public int LocationId { get; set; }
        public int AccountId { get; set; }
        public int PurchaseId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Location Location { get; set; }
        public virtual Account Account { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
