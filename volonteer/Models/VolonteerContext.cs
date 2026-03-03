using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace volonteer.Models;

public partial class VolonteerContext : DbContext
{
    public VolonteerContext()
    {
    }

    public VolonteerContext(DbContextOptions<VolonteerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<RegisterVolonteer> RegisterVolonteers { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<StatusEvent> StatusEvents { get; set; }

    public virtual DbSet<StatusRegister> StatusRegisters { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=volonteer;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("categories_pkey");

            entity.ToTable("categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("events_pkey");

            entity.ToTable("events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateOfStart).HasColumnName("date_of_start");
            entity.Property(e => e.EventName).HasColumnName("event_name");
            entity.Property(e => e.IdCategory)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_category");
            entity.Property(e => e.IdStatusEvent)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_status_event");
            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_user");
            entity.Property(e => e.NeedVolonteer).HasColumnName("need_volonteer");
            entity.Property(e => e.Place).HasColumnName("place");

            entity.HasOne(d => d.Category).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdCategory)
                .HasConstraintName("fk_events_to_categories");

            entity.HasOne(d => d.StatusEvent).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdStatusEvent)
                .HasConstraintName("fk_events_to_status_events");

            entity.HasOne(d => d.User).WithMany(p => p.Events)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_events_to_users");
        });

        modelBuilder.Entity<RegisterVolonteer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("register_volonteer_pkey");

            entity.ToTable("register_volonteers");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('register_volonteer_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.DateRegister).HasColumnName("date_register");
            entity.Property(e => e.IdEvent)
                .HasDefaultValueSql("nextval('register_volonteer_id_event_seq'::regclass)")
                .HasColumnName("id_event");
            entity.Property(e => e.IdStatusRegister)
                .HasDefaultValueSql("nextval('register_volonteer_id_status_register_seq'::regclass)")
                .HasColumnName("id_status_register");
            entity.Property(e => e.IdUser)
                .HasDefaultValueSql("nextval('register_volonteer_id_user_seq'::regclass)")
                .HasColumnName("id_user");

            entity.HasOne(d => d.Event).WithMany(p => p.RegisterVolonteers)
                .HasForeignKey(d => d.IdEvent)
                .HasConstraintName("fk_register_volonteer_to_events");

            entity.HasOne(d => d.StatusRegister).WithMany(p => p.RegisterVolonteers)
                .HasForeignKey(d => d.IdStatusRegister)
                .HasConstraintName("fk_register_volonteer_to_status_register");

            entity.HasOne(d => d.User).WithMany(p => p.RegisterVolonteers)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("fk_register_volonteer_to_users");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<StatusEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_event_volonteers_pkey");

            entity.ToTable("status_events");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('status_event_volonteers_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<StatusRegister>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("status_registers_pkey");

            entity.ToTable("status_registers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Pass).HasColumnName("pass");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
