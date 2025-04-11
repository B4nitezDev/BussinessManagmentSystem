using Core.Interfaces;

namespace Core.Entities
{
    public class PaymentMethods: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string OfficialBillingCode { get; set; }
        public bool IsActive { get; set; }
        public bool RequiredCardsDetails { get; set; }
        public bool IsDefault { get; set; }
        public int Type { get; set; } //TODO:  Agregar Enum. EB 10/04/2025

        public int SalesId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        public virtual Sales Sales { get; set; }
    }
}
