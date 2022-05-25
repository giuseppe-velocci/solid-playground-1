var loggerFactory = new LogServiceFactory();
var logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Starting message processor");

#region Digital factory Platform overview
//                                   ________________________
//                                  |                        |
//      (((((((((((((((((((() --->  |                        |
//     Booking messages queue       |       Validation       |
//                                  |       Enrichment       | ---> (((((((((((((((((((((((((()
//                                  |     Transformation     |          Equipment messages 
//      (((((((((((((((((((() --->  |                        |        in DCSA standard format
//    Equipment messages queue      |________________________|
//                                        Digital Factory
//                                           Platform
#endregion

#region Create Booking Subscriber
//
// 1. create a Subscriber for Booking queue
//                                   ________________          ____
//                                  |                |  --->  \____/
//      (((((((((((((((((((() --->  | Handle Booking |        |    |
//      Booking messages queue      |________________|  <---  \____/
//                                  Messages Processor       Database
//
#endregion


#region Create EquipmentActivities Subscriber
//
// 2. create a Subscriber for EquipmentActivites queue
//                                          ____
//                                         \____/
//                                         |    |
//                                         \____/    
//                                        Database
//                                          ^  |
//                                          |  v
//                                   __________________
//                                  |                  |
//      (((((((((((((((((((() --->  | Handle Equipment |  ---> (((((((((((((((((((((((((()
//    Equipment messages queue      |__________________|            Equipment messages 
//                                   Messages Processor          in DCSA standard format
//
#endregion

Console.ReadLine();