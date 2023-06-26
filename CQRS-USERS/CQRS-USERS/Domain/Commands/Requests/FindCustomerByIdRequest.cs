namespace CQRS_USERS.Domain.Commands.Requests
{
    public class FindCustomerByIdRequest
    {
        public Guid Id { get; set; }
    }
}