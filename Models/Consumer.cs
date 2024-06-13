namespace Kafka_for_web.Models; 

// Consumers can be part of things known as consumer groups; 

public class Consumer {
    private long id;
    private string name;

    // Consumers can push their offset to the saved in the same location as the output. 
    private long offset;
    private List<string> subscriptions;
    private string groupId;
    private bool enableAutoCommit; 
}

// Store what the consumer is subscribed to
public class Subscription
{
    private Consumer _consumer;
    private Topic _topic; 
    private long _offset; 
}