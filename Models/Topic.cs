namespace Kafka_for_web.Models;

public class Topic
{
   public long Id { get; set; }
   public string Name { get; set; }

   // the number of partitions each topic should have 
   public long NumPartitions { get; set; }
   public long ReplicationFactor { get; set; }

   public ICollection<Partition> Partitions { get; set; } = null!;
   

   public TimeSpan RetentionPeriod; 
}
