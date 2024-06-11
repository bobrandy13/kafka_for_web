namespace Kafka_for_web.Models; 

public class Consumer {
    private long id;
    private string name;

    private long offset;
    private List<string> subscriptions;
}