using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hm02.Models
{
    public class DatabaseContext : DbContext
    {
        DbSet<Person> Persons { get; set; }
        DbSet<FriendWith> FriendsWith { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<PostImages> PostImages { get; set; }
        DbSet<Comments> Comments { get; set; }
        DbSet<Reaction> Reactions { get; set; }
        DbSet<ReactionType> ReactionType { get; set; }
        DbSet<Chat> Chats { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Profile> Profile { get; set; }
        DbSet<Story> Stories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql("host=localhost;port=5432;userid=postgres;password=postgres;database=db_homework02");
        }
    }
}
