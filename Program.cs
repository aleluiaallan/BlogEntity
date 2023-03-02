using System;
using BlogEntity.Data;
using BlogEntity.Models;

namespace BlogEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                //CREATE
                // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                //UPDATE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // tag.Name = ".Net";
                // tag.Slug = "dotnet";
                // context.Update(tag);
                // context.SaveChanges();

                var tag = context.Tags.FirstOrDefault(x => x.Id == 1);

                context.Remove(tag);
                context.SaveChanges();


            }
        }
    }
}
