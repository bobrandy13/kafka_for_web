using Kafka_for_web.Models;
using Microsoft.EntityFrameworkCore;

namespace Kafka_for_web.DataAccess;

public class KafkaContext : DbContext
{
    public KafkaContext(DbContextOptions<KafkaContext> options) : base (options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cluster>().ToTable("Cluster");
        modelBuilder.Entity<Topic>().ToTable("Topic");
        modelBuilder.Entity<Partition>().ToTable("Partition");
    }

    public DbSet<Cluster> Clusters { get; set; } = null;
    public DbSet<Topic> Topics { get; set; } = null;
    public DbSet<Partition> Partitions { get; set; } = null;

}