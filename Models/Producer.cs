namespace Kafka_for_web.Models; 

public class Producer {
    private long id;
    private string name;

    private string recent_messages;

    // When a user produces a new message 
    private List<string> messages; 

    public Producer(long id, string name, string recentMessages, List<string> messages)
    {
        this.id = id;
        this.name = name;
        recent_messages = recentMessages;
        this.messages = messages;
    }
}