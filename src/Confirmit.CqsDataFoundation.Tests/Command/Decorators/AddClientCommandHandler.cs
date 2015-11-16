using Confirmit.CqsDataFoundation.Tests.Dto;
using Confirmit.CqsDataFoundation.Tests.Query.Decorators;
using Firmglobal.Framework.CqsDataFoundation.Command;

namespace Confirmit.CqsDataFoundation.Tests.Command.Decorators
{
    class AddClientCommandHandler : CommandHandlerBase<ClientDataContext, AddClientCommand>
    {
        public AddClientCommandHandler(ClientDataContext context, bool sharedContext = false): base(context, sharedContext)
        {
        }

        public override void Handle(AddClientCommand cmd)
        {
            DbContextUser.DataSource.Add(new Client()
            {
                GivenName = cmd.GivenName,
                MiddleName = cmd.MiddleName,
                SurName = cmd.SurName,
                Address = cmd.Address == null ? null:new Address2() {Zip=cmd.Address.Zip, City = cmd.Address.City, Street = cmd.Address.Street}
            });
        }
    }
}
