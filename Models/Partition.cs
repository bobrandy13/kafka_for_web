namespace Kafka_for_web.Models;

public class Partition
{
    // One consumer per  partition
    // This id should just be from 1, 2, 3, 4, 5 ...
    private long id;
    private long? consumer_id;

    // Set the max to 5; 
    // Dictates how many different portitions will store the same data 
    private long replication_factor; 
}