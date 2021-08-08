using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{
    private IMediator mediator;
    public ContactsController(IMediator mediator) => this.mediator = mediator;


    [HttpGet("{Id}")]
    public async Task<Contact> GetContact([FromRoute] Query query) => await mediator.Send(query);

    #region Nested Classes
    public class Query : IRequest<Contact>
    {
        public int Id { get; set; }
    }

    public class ContactHandler : IRequestHandler<Query, Contact>
    {
        private ContactsContext db;

        public ContactHandler(ContactsContext db) => this.db = db;

        public Task<Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
        }
    }
    #endregion
}
