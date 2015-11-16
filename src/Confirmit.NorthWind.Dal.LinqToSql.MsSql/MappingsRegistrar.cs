using System.Threading;

using AutoMapper;
using Confirmit.NortWind.Model.Commands;
using Ent = NorthWind.Data.Entities;
using Confirmit.NortWind.Model.DTO;

namespace Confirmit.NorthWind.Dal.LinqToSql.MsSql
{
    static class MappingsRegistrar
    {
        static int _registered;

        public static void EnbsureRegistered()
        {
            if (Interlocked.CompareExchange(ref _registered, 1, 0) == 0)
            {
                Mapper.CreateMap<AddProductCommand, Ent.Product>()
                    .ForMember(dst => dst.ProductID, mc => mc.Ignore());
                Mapper.CreateMap<UpdateProductCommand, Ent.Product>();
                Mapper.CreateMap<AddCategoryWithProductsCommand, Ent.Category>().
                    ForSourceMember(src => src.Products, mc => mc.Ignore());

                Mapper.CreateMap<Ent.Category, Category>();
                Mapper.CreateMap<Ent.Supplier, Supplier>();
                Mapper.CreateMap<Ent.Customer, Customer>();
                Mapper.CreateMap<Ent.Product, Product>();
            }
        }
    }
}
