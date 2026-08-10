using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class Exercise1
    {
        public void Run()
        {
            //2026-08-10 Lab 3
            string[] userLogs = new string[6] { "admin", "UNKNOWN", "dime", "guest", "UNKNOWN", "operator" };
            
            int validUserCount = 0;
            for (int i = 0; i < userLogs.Length; i++) 
            {
                if (userLogs[i] == "UNKNOWN")
                {
                    Console.WriteLine($"Log entry {i + 1}: Invalid user detected.");
                }
                else
                {
                    validUserCount++;
                    Console.WriteLine($"Log entry {i + 1}: Valid user - {userLogs[i]}");
                }
            }

            Console.WriteLine($"Total valid users processed: {validUserCount}");


            /*2026-08-10 Lab 2
            
            Dictionary<string, string> serverCluster = new Dictionary<string, string>()
            {
                {"Web-Server-01" ,"ONLINE"},
                {"DB-Server-PRIMARY" ,"OFFLINE"},
                {"App-Server-01" ,"ONLINE"},
                {"Backup-Node" ,"OFFLINE"},
                {"Auth-Service" ,"ONLINE"}
              
            };
            
            int onlineCount = 0;
            int offlineCount = 0;

            foreach (var server in serverCluster)
            {
                Console.WriteLine($"Server: {server.Key}, Status: {server.Value}");
            
                if (server.Value == "ONLINE")
                {
                    onlineCount++;
                    Console.WriteLine($"Server {server.Key} is operational.");
                }
                else if (server.Value == "OFFLINE")
                {
                    offlineCount++;
                    Console.WriteLine($"Server {server.Key} is offline.");
                }
            }
                      
            Console.WriteLine($"Total ONLINE servers: {onlineCount}");
            Console.WriteLine($"Total OFFLINE servers: {offlineCount}");
            */


            /* 2026-08-10 Lab 1

            int[] responseTimes = new int[6] { 120, 85, 310, 950, 420, 150 };
        
            int count = 1;

            foreach (int responseTime in responseTimes)
            {
                if (responseTime < 200)
                {
                    Console.WriteLine($"[OK] Fast response: {responseTime} ms");
                }
                else if (responseTime >= 200 && responseTime <= 800)
                {
                    Console.WriteLine($"[WARN] Slow response: {responseTime} ms");
                }
                else if (responseTime > 800)
                {
                    Console.WriteLine($"[CRITICAL] Timeout detected at: {responseTime} ms");
                    break;
                }
                count++;
            }   
            
            Console.WriteLine($"Total response times processed: {count}");
            */




            /*
            double[] numbers = new double[5] { 1.5, 2.5, 3.5, 4.5, 5.5 };

            int count = 0;
            
            foreach (double number in numbers)
            {
                if (count == 3)
                {
                    break;
                }
                Console.WriteLine(number);
                count++;
            
            }*/




            /*
            Dictionary<int, string> guitars = new Dictionary<int, string>()
            {
                { 1, "Fender" },
                { 2, "Jackson" },
                { 3, "Ibanez" },
                { 4, "Gibson" },
                { 5, "Epiphone" }
            };
            Console.WriteLine(guitars[4]);
            */
            //int[] numbers = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            //Console.Write(numbers[6]);

            //int age = 18;
            //Console.Write(age);

            //Console.WriteLine("Dime is here!");
            // Add your exercise logic here
        }
    }
}
