using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class CollectionsStrings2
    {
        /*
         * 2026-08-12
         * 
         * Lab Exercie: Server Performance Registry & Batch Auditor
         * AI Generated Exercise but Manually Coded :) \m/ 
         * 
         * Dime is processing diagnostic log entries from a cluster of servers. Each 
         * log string is formatted as:
         *
         * "SERVER_NAME:PING_MS:MEMORY_USAGE_PERCENT"
         *   
         * He needs to parse these strings, evaluate server metrics using if / else if / 
         * else conditions, and store the output in a Dictionary<string, string> where:
         *   
         * Key = Server Name (string)
         * Value = Evaluated Status ("OFFLINE", "CRITICAL", "WARNING", or "HEALTHY")
         * 
         */

        public void exercise()
        {
 
            List<string> rawServerData = new List<string>
            {
                "Server-Alpha:25:45",
                "Server-Beta:180:92",
                "Server-Gamma:-1:0",   // -1 ping means Server is Offline
                "Server-Delta:40:60",
                "Server-Epsilon:450:88"
            };

            Dictionary<string, string> serverStatusRegistry = new Dictionary<string, string>();

            foreach (string serverLogs in rawServerData)
            {
                string[] parts = serverLogs.Split(':');

                string serverName = parts[0];
                int ping = int.Parse(parts[1]);
                int memory = int.Parse(parts[2]);

                string status;

                if (ping == -1)
                {
                    status = "OFFLINE";
                }
                else if (ping > 300 || memory > 90)
                {
                    status = "CRITICAL";
                }
                else if (ping > 100 || memory > 75)
                {
                    status = "WARNING";
                }
                else
                {
                    status = "HEALTHY";

                }
                
                serverStatusRegistry[serverName] = status;                   
            
            }

            foreach (KeyValuePair<string, string> kvp in serverStatusRegistry)
            {
                if (kvp.Value == "CRITICAL" || kvp.Value == "OFFLINE") 
                Console.WriteLine($"Server: {kvp.Key} - Status: {kvp.Value}");
            
            }
        }

    }
}
