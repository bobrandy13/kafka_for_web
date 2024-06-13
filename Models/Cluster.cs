namespace Kafka_for_web.Models;

public class Cluster
{
   private long id;
   private string name; 
   
   // The number of brokers
   private int num_brokers;
   private List<Broker> brokers;

   private int replication_count;
   private string securityProtocol; 
   
   // each cluser should have a relation to any number of topics; 
   private List<Topic> _topics;

   public Cluster(long id, string name, int nbrokers, int replicationCount, List<Topic> topics)
   {
      this.id = id;
      this.name = name;
      this.num_brokers = nbrokers;
      this.replication_count = replicationCount;
      this._topics = topics;
   }
}
