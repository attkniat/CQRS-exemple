using CQRS_USERS.Domain.Commands.Requests;
using CQRS_USERS.Domain.Commands.Responses;

namespace CQRS_USERS.Domain.Handlers
{
    public class FindCustomerByIdHandler : IFindCustomerByIdHandler
    {
        public FindCustomerByIdResponse Handle(FindCustomerByIdRequest request)
        {
            //ICustomerRepository _repository;

            //public FindCustomerByIdHandler(ICustomerRepository repository)
            //{
            //    _repository = repository;
            //}

            // TODO: Lógica de leitura se houver

            // Retorna o resultado
            //return _repository.GetCustomerById(command.Id);

            return new FindCustomerByIdResponse { Id = Guid.NewGuid(),  Email = "user@email.com", Name = "User01"};
        }
    }
}