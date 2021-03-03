namespace Core.Entities.Concrete
{
    public class UserOperationClaim:IEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string OperationClaimId { get; set; }
    }
}
