using Common.Base;
using Common.Races;
using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Database
{
    public class MainDbContext :DbContext
    {
        public DbSet<Message> Messages { get; set; } = default!;
        public DbSet<Character> Characters { get; set; } = default!;
        public DbSet<CharacterClass> CharacterClasses { get; set; } = default!;
        public DbSet<Skill> Skills { get; set; } = default!;
        public DbSet<SkillGroup> SkillGroups { get; set; } = default!;
        public DbSet<InventoryItem> InventoryItems { get; set; } = default!;
        public DbSet<Race> Races { get; set; } = default!;



        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .Entity<Character>()
                .HasOne(c => c.Race)
                .WithMany()
                .HasForeignKey(c => c.Id); ;


            modelBuilder
                .Entity<Character>()
                .OwnsOne(c => c.Class);
            modelBuilder.Entity<Character>()
                .OwnsOne(c => c.CharacterSkills);
            modelBuilder.Entity<Character>()
                .OwnsMany(c => c.Inventory, a =>
                {
                    a.WithOwner().HasForeignKey("CharacterId");
                    a.HasKey("Id", "CharacterId");
                });

            modelBuilder.Entity<Drow>().HasBaseType<Race>();
            modelBuilder.Entity<Orc>().HasBaseType<Race>();
            modelBuilder.Entity<Dwarf>().HasBaseType<Race>();
            modelBuilder.Entity<Goblin>().HasBaseType<Race>();
            modelBuilder.Entity<Human>().HasBaseType<Race>();
            modelBuilder.Entity<Khajiit>().HasBaseType<Race>();
            modelBuilder.Entity<Underwater>().HasBaseType<Race>();
            modelBuilder.Entity<Winged>().HasBaseType<Race>();
            modelBuilder.Entity<WoodElf>().HasBaseType<Race>();
            

            //var raceTypes = typeof(Race).Assembly.GetTypes()
            //.Where(t =>
            //    t.IsClass &&
            //    !t.IsAbstract &&
            //    typeof(Race).IsAssignableFrom(t) &&
            //    t.Namespace == typeof(Race).Namespace
            //);

            //foreach (var subtype in raceTypes)
            //{
            //    modelBuilder.Entity(subtype)
            //                .HasBaseType(typeof(Race));
            //}

        }
    }
}
