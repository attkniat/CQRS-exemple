using CQRS_USERS.Domain.Commands.Requests;
using CQRS_USERS.Domain.Commands.Responses;

namespace CQRS_USERS.Domain.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest  request);
    }
}