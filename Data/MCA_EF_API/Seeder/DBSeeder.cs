using MCA_EF.Data.DbContext;
using MCA_EF.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MCA_EF_API.Seeder
{
    public class DBSeeder
    {
        public static async Task Seed(WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            await InsertPersonData(context);
            await InsertFormData(context);
        }


        public static async Task InsertPersonData(ApplicationDbContext context)
        {
            if (!await context.Person.AnyAsync())
            {
                context.Person.Add(new Person
                {
                    PersonId = 1,
                    LanId = "abcd",
                    Email = "Dileep@gmail.com"
                });
                await context.SaveChangesAsync();
            }
        }
        public static async Task InsertFormData(ApplicationDbContext context)
        {
            var person = await context.Person.FirstOrDefaultAsync(x=> x.PersonId == 1);
            if (person != null && !await context.Form.AnyAsync())
            {
                await context.Form.AddAsync(new Form()
                {
                    FormExternalId = Guid.NewGuid(),
                    CreatedBy = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true
                });
                await context.SaveChangesAsync();
            }
        }
    }
}
