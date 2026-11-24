using GymSystemManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemManagement.Configrations
{
    public class SessionConfigration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(x => x.CreatedAt)
                    .HasDefaultValueSql("GETDATE()");
            builder.HasOne(x => x.Trainer)
                    .WithMany(x => x.Sessions)
                    .OnDelete(DeleteBehavior.Restrict);

            builder.ToTable(T=>{
                T.HasCheckConstraint("SessionCapacityCheck", "Capacity between 1 and 25");
                T.HasCheckConstraint("SessionEndDateAfterStartDate" , "EndDate > StartDate");
            });
        }
    }
}
