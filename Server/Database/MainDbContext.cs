using Common.Base;
using Common.Enums;
using Common.Factories;
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

            #region character mapping

            modelBuilder.Entity<Character>(b =>
            {
                b.HasKey(c => c.Id);

                b.HasOne(c => c.Race)
                 .WithMany()
                 .HasForeignKey(c => c.RaceId)
                 .IsRequired();

                b.HasMany(x => x.Inventory)
                .WithOne()
                .HasForeignKey(c => c.CharacterId)
                .OnDelete(DeleteBehavior.Cascade);

                b.OwnsOne(c => c.Class, cc =>
                {
                    cc.Property(x => x.Name)
                      .HasColumnName("ClassName")
                      .IsRequired();
                });

                b.OwnsOne(c => c.Stats);

                modelBuilder.Entity<Character>().HasOne(c => c.CharacterSkills).WithOne();

            });
            #endregion

            

            modelBuilder.Entity<Drow>().HasBaseType<Race>();
            modelBuilder.Entity<Orc>().HasBaseType<Race>();
            modelBuilder.Entity<Dwarf>().HasBaseType<Race>();
            modelBuilder.Entity<Goblin>().HasBaseType<Race>();
            modelBuilder.Entity<Human>().HasBaseType<Race>();
            modelBuilder.Entity<Khajiit>().HasBaseType<Race>();
            modelBuilder.Entity<Underwater>().HasBaseType<Race>();
            modelBuilder.Entity<Winged>().HasBaseType<Race>();
            modelBuilder.Entity<WoodElf>().HasBaseType<Race>();

            var races = Enum.GetValues(typeof(RaceEnum))
                         .Cast<RaceEnum>()
                         .Select(RaceFactory.CreateRace)
                         .ToArray();

            // 2) сеедим только корневые свойства Race
            modelBuilder.Entity<Race>().HasData(
                races.Select(r => new {
                    r.Id,
                    r.Name,
                    r.NameRu,
                    r.Type,
                    r.TypeRu,
                    r.BaseHP
                })
                .ToArray()
            );

            // 3) конфигурируем BasicStats как owned-тип
            modelBuilder.Entity<Race>().OwnsOne(r => r.BasicStats, bs =>
            {
                // опционально: задаём имена колонок
                bs.Property(x => x.Strength).HasColumnName("BaseStrength");
                bs.Property(x => x.Agility).HasColumnName("BaseAgility");
                bs.Property(x => x.Intelligence).HasColumnName("BaseIntelligence");
                bs.Property(x => x.Utility).HasColumnName("BaseUtility");

                // 4) теперь сеедим сами поля BasicStats
                bs.HasData(
                    races.Select(r => new {
                        RaceId = r.Id,                  // FK на таблицу Race
                        r.BasicStats.Strength,
                        r.BasicStats.Agility,
                        r.BasicStats.Intelligence,
                        r.BasicStats.Utility
                    })
                    .ToArray()
                );
            });


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
