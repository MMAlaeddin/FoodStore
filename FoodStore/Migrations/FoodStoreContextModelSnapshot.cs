﻿// <auto-generated />
using FoodStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodStore.Migrations
{
    [DbContext(typeof(FoodStoreContext))]
    partial class FoodStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodStore.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ItemName");

                    b.Property<int>("Quantity");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FoodStore.Models.ItemStore", b =>
                {
                    b.Property<int>("ItemStoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ItemId");

                    b.Property<int>("StoreId");

                    b.HasKey("ItemStoreId");

                    b.HasIndex("ItemId");

                    b.HasIndex("StoreId");

                    b.ToTable("ItemStore");
                });

            modelBuilder.Entity("FoodStore.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("StoreName");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("FoodStore.Models.ItemStore", b =>
                {
                    b.HasOne("FoodStore.Models.Item", "Item")
                        .WithMany("Stores")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodStore.Models.Store", "Store")
                        .WithMany("Items")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
