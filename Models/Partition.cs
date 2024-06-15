using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Kafka_for_web.Models;

public enum PartitionStatus
{
   Online,
   Offline,
   Error,
   Recovery,
   Unknown
}

public class Partition
{
    // One consumer per  partition
    // This id should just be from 1, 2, 3, 4, 5 ...
    [Key]
    public long Id { get; set; }
    
    public List<long>? consumers{ get; set; }

    // Set the max to 5, default to 3; 
    // Dictates how many different partitions will store the same data 
    public long replication_factor { get; set; }

    // Stores the size in bytes;
    public long size;

    // Log file name
    public string log_dir;

    // Stores the consumer offset when reading
    public long offset; 
    
    // The status of the partition
    public PartitionStatus status { get; set; }
    
    // Stores the most recent messages in an array
    public List<Message> Messages { get; set; } = [];
}