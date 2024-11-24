using AwesomeNetwork.Models.Users;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AwesomeNetwork.Configs
{
    public class MessageConfuiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.ToTable("Mesages").HasKey(p => p.Id);

            builder.Property(x => x.Id).UseIdentityColumn();
        }
    }
}
