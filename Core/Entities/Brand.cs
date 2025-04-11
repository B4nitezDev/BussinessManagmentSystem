using Core.Interfaces;

namespace Core.Entities
{
    public abstract class Brand: BaseEntity, IAuditApproval
    {
        public required string Name { get; set; }
        public string? Description { get; set; }
        public BrandTypes Type { get; set; }
        public bool IsActive { get; set; }

        public List<int> ProductsId { get; set; } = [];
        
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdate { get; set; }
        public int AddedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual List<Product> Products { get; set; } = [];
    }
}
