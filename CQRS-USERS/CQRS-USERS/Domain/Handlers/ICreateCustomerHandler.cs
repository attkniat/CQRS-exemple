using CQRS_USERS.Domain.Commands.Requests;
using CQRS_USERS.Domain.Commands.Responses;

namespace CQRS_USERS.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}