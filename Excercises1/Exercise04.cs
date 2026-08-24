/*
 * 2026-08-15
 * 
 * Lab Exercise: Firewall Access Control & Port Validator
 * AI Generated Exercise but Manually Coded :) \m/
 * 
 * Scenario
 * Dime is building an ingress firewall rule auditor. The incoming traffic logs contain raw
 * connection strings. He needs to parse each entry, validate whether the connection is allowed 
 * using boolean flags, and organize the allowed versus blocked connections into dedicated 
 * collection containers.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class Exercise04
    {
        public void exercise()
        {
                         
            string rawTrafficData = "TRAFFIC_ID:IP:PORT:PROTOCOL:IS_ENCRYPTED|T101:192.168.1.50:443:TCP:true|T102:10.0.0.12:80:TCP:false|T103:172.16.0.4:22:SSH:true|T104:192.168.1.99:8080:HTTP:false|T105:10.0.0.25:443:TCP:true|T106:172.16.0.88:3389:RDP:false";
             

            string[] trafficEntries = rawTrafficData.Split('|');

            List<string> allowedTraffic = new List<string>();
            Dictionary<string, string> blockedRegistry = new Dictionary<string, string>();           

            for ( int i = 1; i < trafficEntries.Length; i++)
            {
                string[] fields = trafficEntries[i].Split(':');
                
                string trafficID = fields[0];
                string ipAddress = fields[1];
                int port = int.Parse(fields[2]);
                string protocol = fields[3];
                bool isEncrypted = bool.Parse(fields[4]);

                bool isAllowed = false;
                string blockReason = "unknown";

                if (port == 443 && isEncrypted == true)
                {
                    isAllowed = true;          
                }
                else if(port == 22 && protocol == "SSH")
                {
                    isAllowed = true;
                }
                else if(!isEncrypted)
                {
                    isAllowed = false; blockReason = "Unencrypted Protocol Denied";
                }
                else
                {
                    isAllowed = false; blockReason = "Port/Protocol Restricted";
                }

                if (isAllowed == true)
                {
                    allowedTraffic.Add(trafficID);
                }
                else
                {
                    blockedRegistry[trafficID] = blockReason;
                }


                                             

            }

            string result = string.Join(", ", allowedTraffic);
            
            Console.WriteLine("--allowed traffic--");
            
            Console.WriteLine(result);
            
            Console.WriteLine("--blocked traffic registry--");
            
            foreach (var kvp in blockedRegistry)
            {
                Console.WriteLine($"trafficID: {kvp.Key} reason: {kvp.Value}");
            }            
        }
    }
}
