using GymSystemManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemManagement.Configrations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(x =>x.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.ToTable(T => {
                T.HasCheckConstraint("PlanDurationConstraint","DurationDays Between 1 And 365"); 
            });
        }
    }
}
