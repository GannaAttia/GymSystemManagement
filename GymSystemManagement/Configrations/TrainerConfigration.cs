using GymSystemManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemManagement.Configrations
{
    public class TrainerConfigration : GymUserConfigration<Trainer> ,IEntityTypeConfiguration<Trainer>
    {
         public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(x => x.CreatedAt).HasColumnName("HireDate").HasDefaultValueSql("GETDATE()");
            base.Configure(builder);
         }
    }
}
