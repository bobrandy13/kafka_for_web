Build it into a web API. For example

Api endpoints
# Producer 
 - /events - POST
Body 
{ 
    "topic": "liked" 
}
 
Posting data to /events should persist in a log file. 

# Consumer
 - /events - GET 
Body { 
    "topic": "likied"
}
Subscribes to the liked topic.

 - /offset - POST  
 {
    consumer_id: Number
 }
 Commits the current offset of the consumer manually


In order to build a Kafka Clone, the software must have the following features:
 - Publisher/Consumer model 
 - Partion tolerance
 - Different topics that consumers can subscribe to
 - Saving data to a sequential log file
 - Off set management - Seeing where the consumer is up to when consuming
 - Allow for batch processing, and also single report processing
 - Message durability. Saving the log file to multiple locations

Maybe features
 - Different brokers within those topics
 - Data replication and sharding on local storage





