﻿namespace BlazorEcomerce.Server.Data
{
    public class DataContext: DbContext
    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product()
                 {
                     Id = 1,
                     Title = "Birds of America",
                     Description = $"Birds of America (1998) is a collection of short stories by American writer Lorrie Moore. The stories in this collection originally appeared in The New Yorker, Elle, The New York Times, and The Paris Review. The story \"People Like That Are the Only People Here\" won an O. Henry Award in 1998. The book became a New York Times bestseller, a rarity for a short story collection. The book was included in the New York Times Book Review books of the year list in 1998.[1] Winner of the Irish Times international fiction prize. A Village Voice book of the year (1998). Winner of the Salon Book Award.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg",
                     Price = 9.99m
                 },
                 new Product()
                 {
                     Id = 2,
                     Title = "The Love of a Good Woman",
                     Description = "The eight stories of this collection (one of which was originally published in Saturday Night; five others were originally published in The New Yorker) deal with Munro's typical themes: secrets, love, betrayal, and the stuff of ordinary lives.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8c/TheLoveOfAGoodWoman.jpg",
                     Price = 5.99m
                 },
                 new Product()
                 {
                     Id = 3,
                     Title = "Being Dead",
                     Description = "Its principal characters are married zoologists Joseph and Celice and their daughter Syl. The story tells of how Joseph and Celice, on a day trip to the dunes where they met as students, are murdered by an opportunistic thief. Their bodies lie undiscovered for several days, during the course of which their estranged daughter is made aware of their disappearance and, eventually, discovery. The novel dwells heavily on the themes of bodily decomposition and filial bereavement.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9b/BeingDead.jpg",
                     Price = 3.99m
                 }
                );
        }

        public DbSet<Product> Products { get; set; }
    }
}
