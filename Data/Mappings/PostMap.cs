using BlogEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEntity.Data.Mappings
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Post> builder)
        {

        }
    }
}