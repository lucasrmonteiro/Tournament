using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tournament.DAO
{
    public partial class DB_Torneio_DEVContext : DbContext
    {
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<Tournament> Tournament { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"server=db-torneio-server.database.windows.net;database=DB-Torneio-DEV;user id=lucas.monteiro;password=Denise123!@#;persist security info=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>(entity =>
            {
                entity.HasOne(d => d.Team1Navigation)
                    .WithMany(p => p.MatchTeam1Navigation)
                    .HasForeignKey(d => d.Team1)
                    .HasConstraintName("FK_Match_Team1");

                entity.HasOne(d => d.Team2Navigation)
                    .WithMany(p => p.MatchTeam2Navigation)
                    .HasForeignKey(d => d.Team2)
                    .HasConstraintName("FK_Match_Team2");

                entity.HasOne(d => d.Tournament)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.TournamentId)
                    .HasConstraintName("FK_Match_Tournament");

                entity.HasOne(d => d.WinnerNavigation)
                    .WithMany(p => p.MatchWinnerNavigation)
                    .HasForeignKey(d => d.Winner)
                    .HasConstraintName("FK_Match_Winner");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Genre)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.IdPosition)
                    .HasConstraintName("FK_Player_Position");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_Player_Team");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.NamePosition)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tournament>(entity =>
            {
                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });
        }
    }
}
