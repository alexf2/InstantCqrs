using AutoMapper;
using Confirmit.NortWind.Model.Commands;
using Firmglobal.Framework.CqsDataFoundation.Command;
using Ent = NorthWind.Data.Entities;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql.Handlers.Command
{
    public sealed class AddProductCommandHandler : CommandHandlerBase<NorthWindContextMgr, AddProductCommand>
    {
        public AddProductCommandHandler(NorthWindContextMgr ctx)
            : base(ctx)
        {
        }

        #region ICommandHandler
        public override void Handle(AddProductCommand command)
        {
            var ent = Mapper.Map<AddProductCommand, Ent.Product>(command);
            DbContextUser.DbContext.Products.InsertOnSubmit(ent);
            DbContextUser.ChangesSubmitted += (snd) => command.ProductID = ent.ProductID; //gettinc auto increment field back
        }
        #endregion ICommandHandler
    }
}
