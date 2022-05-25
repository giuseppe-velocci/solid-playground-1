var loggerFactory = new LogServiceFactory();
var logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Starting message processor");

#region Digital factory Platform overview
//                                   ________________________
//      (((((((((((((((((((() --->  |                        |
//     Booking messages queue       |                        |
//                                  |       validation       |
//                                  |       enrichment       | ---> (((((((((((((((((((((((((()
//                                  |     transformation     |          Equipment messages 
//      (((((((((((((((((((() --->  |                        |        in DCSA standard format
//    Equipment messages queue      |________________________|
//                                        Digital Factory
//                                           Platform
#endregion

#region Create Booking Subscriber
//
// 1. create a Subscriber for Booking queue
//                                   ________________
//      (((((((((((((((((((() --->  |                |
//     Booking messages queue       | handle Booking |
//                                  |________________|
//                                  Messages Processor
//
#endregion


#region Create EquipmentActivities Subscriber
//
// 2. create a Subscriber for EquipmentActivites queue
//                                   __________________
//      (((((((((((((((((((() --->  |                  |
//     Equipment messages queue     | handle Equipment |
//                                  |__________________|
//                                   Messages Processor
//
#endregion

Console.ReadLine();