using Core.Interfaces;

namespace Core.Entities
{
    public class AccountConfig: BaseEntity, IAuditApproval
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }
    } 
}
