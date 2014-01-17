using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SimpleIO;

namespace TEST01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const uint mcp2200_VID = 0x04D8; //VID for MCP2200 
            const uint mcp2200_PID = 0x00DF; //PID for MCP2200 
            bool isConnected = false; //Connection status of MCP2200

            //STEP 2: Make function call using class name
            //Initialize the MCP2200
            SimpleIOClass.InitMCP2200(mcp2200_VID, mcp2200_PID);
            //Check connection status
            isConnected = SimpleIOClass.IsConnected();

            Console.WriteLine(isConnected ? "The device is connected." : "The device is NOT connected.");
            if(isConnected)
            {
                if(SimpleIOClass.ConfigureMCP2200(0, 115200, 0, 0, false, false, false, false))
                {
                    Console.WriteLine("Configuration set");
                    if(SimpleIOClass.WritePort(0xff))
                    {
                        Console.WriteLine("All LED Switched on");
                    }
                    else
                    {
                        Console.WriteLine("Transmission Error");
                    }
                }
                else
                {
                    Console.WriteLine("Transmission Error");
                }
            }
        }
    }
}



