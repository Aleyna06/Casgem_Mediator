using Casgem_Mediator.MediatorPattern.Results;
using MediatR;

namespace Casgem_Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDqUery:IRequest<GetProductUpdateByIDQueryResult>
    {
        public GetProductUpdateByIDqUery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
