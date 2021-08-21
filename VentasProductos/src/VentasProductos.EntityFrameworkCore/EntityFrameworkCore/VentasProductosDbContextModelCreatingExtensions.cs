using System;
using Microsoft.EntityFrameworkCore;
using VentasProductos.Products;
using VentasProductos.Sells;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace VentasProductos.EntityFrameworkCore
{
    public static class VentasProductosDbContextModelCreatingExtensions
    {
        public static void ConfigureVentasProductos(
            this ModelBuilder builder,
            Action<VentasProductosModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new VentasProductosModelBuilderConfigurationOptions(
                VentasProductosDbProperties.DbTablePrefix,
                VentasProductosDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureByConvention();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */

            builder.Entity<Sell>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Sells", options.Schema);

                b.ConfigureByConvention();
            });

            builder.Entity<Product>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Products", options.Schema);

                b.ConfigureByConvention();
            });

            builder.Entity<SellDetail>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "SellDetails", options.Schema);

                b.ConfigureByConvention();
            });
        }
    }
}