using ASProject.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ASProject.DAL.Configurations;

public class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(2000);
        
        builder.HasData(new List<Report>()
        {
            new Report()
            {
                Id = 1,
                Name = "Report1",
                Description = "Test",
                UserId = 1,
                CreatedBy = 1,
            }
        });
    }
}