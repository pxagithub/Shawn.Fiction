using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Shawn.Fiction.EntityFrameworkCore
{
    public static class FictionDbContextModelCreatingExtensions
    {
        public static void ConfigureFiction(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FictionConsts.DbTablePrefix + "YourEntities", FictionConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}