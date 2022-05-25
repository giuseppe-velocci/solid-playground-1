var loggerFactory = new LogServiceFactory();
var logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Starting message processor");




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

Console.ReadLine();