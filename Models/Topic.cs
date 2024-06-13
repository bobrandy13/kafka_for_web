namespace Kafka_for_web.Models;

public class Topic
{
   private long id;
   private string name;

   // the number of partitions each topic should have 
   private long partitions;
   private long servers;
   private long replication_count;
   
   private List<Partition> _partitions;
   
   private TimeSpan retention_period; 
}
