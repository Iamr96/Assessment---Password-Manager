// <auto-generated />
using System;
using LoginsManagerAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LoginsManagerAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Arabic_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DLL.Models.Privilege", b =>
                {
                    b.Property<int>("PrivilegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PrivilegeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrivilegeId"), 1L, 1);

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("PrivilegeFriendlyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivilegeName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("PrivilegeId");

                    b.ToTable("Privilege", (string)null);
                });

            modelBuilder.Entity("DLL.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfileID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileId"), 1L, 1);

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("ProfileName")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.HasKey("ProfileId");

                    b.ToTable("Profile", (string)null);
                });

            modelBuilder.Entity("DLL.Models.ProfilePrivilege", b =>
                {
                    b.Property<int>("ProfilePrivilegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProfilePrivilegeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfilePrivilegeId"), 1L, 1);

                    b.Property<int?>("PrivilegeId")
                        .HasColumnType("int")
                        .HasColumnName("PrivilegeID");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int")
                        .HasColumnName("ProfileID");

                    b.HasKey("ProfilePrivilegeId");

                    b.HasIndex("PrivilegeId");

                    b.HasIndex("ProfileId");

                    b.ToTable("ProfilePrivilege", (string)null);
                });

            modelBuilder.Entity("DLL.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<bool?>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((1))");

                    b.Property<DateTime?>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool?>("EmailVeryFied")
                        .HasColumnType("bit");

                    b.Property<bool?>("ForceLogin")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int")
                        .HasColumnName("ProfileID");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DLL.Models.ProfilePrivilege", b =>
                {
                    b.HasOne("DLL.Models.Privilege", "Privilege")
                        .WithMany("ProfilePrivileges")
                        .HasForeignKey("PrivilegeId")
                        .HasConstraintName("FK_Privilege_Privilege");

                    b.HasOne("DLL.Models.Profile", "Profile")
                        .WithMany("ProfilePrivileges")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Profile_Privilege");

                    b.Navigation("Privilege");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("DLL.Models.User", b =>
                {
                    b.HasOne("DLL.Models.Profile", "Profile")
                        .WithMany("Users")
                        .HasForeignKey("ProfileId")
                        .HasConstraintName("FK_Users_PROFILE");

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("DLL.Models.Privilege", b =>
                {
                    b.Navigation("ProfilePrivileges");
                });

            modelBuilder.Entity("DLL.Models.Profile", b =>
                {
                    b.Navigation("ProfilePrivileges");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
