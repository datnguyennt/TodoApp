using MongoDB.Driver;
using TodoApp.Users;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace TodoApp.MongoDB
{
    [ConnectionStringName("Default")]
    public class TodoAppMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<TodoItem> TodoItems => Collection<TodoItem>();

        public IMongoCollection<AppUser> Users => Collection<AppUser>();

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.Entity<TodoItem>(b =>
            {
                b.CollectionName = "TodoItems";
            });


            modelBuilder.Entity<AppUser>(b =>
            {
                /* Sharing the same "AbpUsers" collection
                 * with the Identity module's IdentityUser class. */
                b.CollectionName = "AbpUsers";
            });
        }
    }
}
