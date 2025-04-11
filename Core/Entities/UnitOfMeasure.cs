using Core.Interfaces;

namespace Core.Entities
{
    public class UnitOfMeasure: BaseEntity, IAuditApproval
    {
        public string Abbreviation { get; set; }
        public string Value { get; set; } // De momento guardamos las unidades de medida como json. EB 10/04/2025
        
        public int ProductId { get; set; }
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
        
        
        public virtual Product Product { get; set; }
    }
}
