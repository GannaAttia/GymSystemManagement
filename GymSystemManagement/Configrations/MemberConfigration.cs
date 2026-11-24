using GymSystemManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymSystemManagement.Configrations
{
    public class MemberConfigration : GymUserConfigration<Member> ,IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder) 
        {
            builder.Property(x => x.CreatedAt)
                   .HasColumnName("JoinDate")
                   .HasDefaultValueSql("GETDATE()");
            base.Configure(builder);// Apply Config Of GymUser
        }
    }
}
