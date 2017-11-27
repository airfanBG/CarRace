using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Engine
    {
        private CarManager manager;
        public Engine()
        {
            manager = new CarManager();
        }

        public void Run()
        {
            var commands = String.Empty;
        
            while ((commands=Console.ReadLine())!="Cops Are Here")
            {
                string[] cmdArgs = commands.Split(' ');
                ExecuteCommand(cmdArgs);
            }
        }
        private void ExecuteCommand(string[] cmdArgs)
        {
           
            switch (cmdArgs[0])
            {
                case "register":
                    int id = int.Parse(cmdArgs[1]);
                    string type = cmdArgs[2];
                    string brand = cmdArgs[3];
                    string model = cmdArgs[4];
                    int year = int.Parse(cmdArgs[5]);
                    int horseP = int.Parse(cmdArgs[6]);
                    int acceleration = int.Parse(cmdArgs[7]);
                    int suspension = int.Parse(cmdArgs[8]);
                    int durability = int.Parse(cmdArgs[9]);

                    manager.Register(id, type, brand, model, year, horseP, acceleration, suspension, durability);
                        break;
                case "check":
                    id = int.Parse(cmdArgs[1]);
                    Console.WriteLine(manager.Check(id));
                    break;
                case "open":
                    id = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    int length = int.Parse(cmdArgs[3]);
                    string route = cmdArgs[4];
                    int prizepool = int.Parse(cmdArgs[5]);

                    manager.Open(id, type, length, route, prizepool);
                    break;

                case "participate":
                    int carId = int.Parse(cmdArgs[1]);
                    int raceId = int.Parse(cmdArgs[2]);

                    manager.Participate(carId,raceId);
                    break;
                case "start":
                    raceId = int.Parse(cmdArgs[1]);
                    Console.WriteLine(manager.Start(raceId));
                    break;
                case "park":
                    carId =int.Parse(cmdArgs[1]);
                    manager.Park(carId);
                    break;
                case "unpark":
                    carId = int.Parse(cmdArgs[1]);
                    manager.Unpark(carId);
                    break;
                case "tune":
                    var index = int.Parse(cmdArgs[1]);
                    var addOn = cmdArgs[2];

                    manager.Tune(index,addOn);
                    break;

                default:
                    break;
            }
        }
    }
}
