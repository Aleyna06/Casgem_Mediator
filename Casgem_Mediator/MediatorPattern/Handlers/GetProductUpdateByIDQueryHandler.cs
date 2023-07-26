using Casgem_Mediator.DAL;
using Casgem_Mediator.MediatorPattern.Queries;
using Casgem_Mediator.MediatorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Casgem_Mediator.MediatorPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler : IRequestHandler<GetProductUpdateByIDqUery, GetProductUpdateByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductUpdateByIDQueryResult> Handle(GetProductUpdateByIDqUery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductUpdateByIDQueryResult
            {
                Brand = values.Brand,
                Category = values.Category,
                Name = values.Name,
                Price = values.Price,
                ProductID = values.ProductID,
                Stock = values.Stock,
            };
        }
    }
}
