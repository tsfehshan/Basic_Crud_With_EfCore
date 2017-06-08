using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Basic_Crud_With_EFCore.Utilities;

namespace Basic_Crud_With_EFCore.Migrations
{
    [DbContext(typeof(MSSQLDbContext))]
    partial class MSSQLDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Basic_Crud_With_EFCore.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 255);

                    b.Property<double>("Price");

                    b.Property<string>("Type")
                        .HasAnnotation("MaxLength", 255);

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });
        }
    }
}
