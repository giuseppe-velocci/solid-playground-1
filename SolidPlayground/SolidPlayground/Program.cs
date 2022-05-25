// See https://aka.ms/new-console-template for more information
using Core.DTO;
using MessagesFramework;
using Microsoft.Extensions.Logging;

var loggerFactory = new Infrastructure.Logging.LogServiceFactory();
var logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Starting message processor");
Console.ReadLine();


//                               ___________________________
//   (((((((((((((((((((() ---> |                           |
//  Booking messages queue      |                           |
//                              |                           |
//                              |                           | ---> (((((((((((((((((((((((((()
//                              |                           |          Equipment messages 
//   (((((((((((((((((((() ---> |                           |        in DCSA standard format
//  Equipment messages queue    |___________________________|
//                                     Digital Factory
//                                        Platform