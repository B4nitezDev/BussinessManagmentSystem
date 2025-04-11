using Core.Interfaces;
using Core.VOs;

namespace Core.Entities
{
    public class InventoryAdjustments: BaseEntity, IAuditApproval
    {
        public DateTime AdjusmentDate { get; set; }
        
        public int UserId { get; set; }
        public int ReasonId { get; set; }

        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual User User { get; set; }
        public virtual Reason Reason { get; set; }
    }
}
