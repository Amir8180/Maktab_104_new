using Microsoft.EntityFrameworkCore;
using Room_Services.Models;

namespace Room_Services
{
    public class RM_Context : DbContext
    {
        public DbSet<Billing> Billings { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Offer> offers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail_Task> OrderDetail_Tasks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Role_Claim> Role_Claims { get; set; }
        public DbSet<Task_List> Task_Lists { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_Role> User_Roles { get; set; }



        public RM_Context(DbContextOptions<RM_Context> options) : base(options)
        {

        }
    }
}
