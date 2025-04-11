namespace Core.Interfaces
{
    public interface IAuditApproval
    {
        DateTime DateAdded { get; set; }
        DateTime DateUpdate { get; set; }
        int AddedBy { get; set; }
        int UpdatedBy { get; set; }
    }
}
