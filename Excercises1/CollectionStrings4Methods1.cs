using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class CollectionStrings4Methods1
    {
        /*
         * Lab Exercie: Server Storage Fee Calculator
         * AI Generated Exercise but Manually Coded :) \m/
         * 
         * Scenario
         * Dime, you have a lst of servers with their allocated storage (in GB), used storage (in GB), 
         * and backup status. You will write one simple method that calculates extra storage costs, 
         * then use it inside your loop to populate your collections.
        */

        public int CalculateExtraCost(int allocated, int used)
        {
            if (used > allocated)
            {
                return (used - allocated) * 2;
            }
            else
            {
                return 0;
            }
        
        }

        public void exercise()
        {
            string rawData = "SERVER_ID:ALLOCATED_GB:USED_GB:HAS_BACKUP|SRV-01:100:80:true|SRV-02:50:90:true|SRV-03:200:250:false|SRV-04:100:100:true";
            
            string[] cookedData = rawData.Split('|');          

            List<string> overLimitServers = new List<string>();
            Dictionary<string, int> extraFees = new Dictionary<string, int>();

            for (int i = 1; i < cookedData.Length; i++)
            {
                string[] overcookedData = cookedData[i].Split(':');

                string serverID = overcookedData[0];
                int allocatedGB = int.Parse(overcookedData[1]);
                int usedGB = int.Parse(overcookedData[2]);
                bool hasBackup = bool.Parse(overcookedData[3]);

                /*Console.WriteLine($"SERVER_ID - {serverID} " +
                    $"ALLOCATED_GB - {allocatedGB} " +
                    $"USED_GB - {usedGB} " +
                    $"HAS_BACKUP - {hasBackup}");
                */

        int fee = CalculateExtraCost(allocatedGB, usedGB);

                //Console.WriteLine(fee);

                if (fee > 0)
                {
                    overLimitServers.Add(serverID);
                    extraFees[serverID] = fee;                  
                    
                }
            }
            Console.WriteLine("---OVER LIMIT SERVERS---");
            Console.WriteLine(string.Join(", ", overLimitServers ));

            Console.WriteLine("--- EXTRA CHARGES ---");

            foreach (var kvp in extraFees)
            {
                
                Console.WriteLine($"serverID- {kvp.Key} Fee- {kvp.Value} ");
            }
        }        

    }
}
