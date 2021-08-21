using Clients.Clients;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Clients.EntityFrameworkCore
{
    public static class ClientsDbContextModelCreatingExtensions
    {
        public static void ConfigureClients(
            this ModelBuilder builder,
            Action<ClientsModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ClientsModelBuilderConfigurationOptions(
                ClientsDbProperties.DbTablePrefix,
                ClientsDbProperties.DbSchema
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

            builder.Entity<Client>(c => {
                c.ToTable(options.TablePrefix + "Clients", options.Schema);
                c.ConfigureByConvention();
            });
        }
    }
}