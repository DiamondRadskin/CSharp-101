/*
 * 2026-08-17
 * 
 * Lab Exercise: SSL Certificate Expiry & Security Audit
 * AI Generated Exercise but Manually Coded :) \m/   
 *
 * Scenario
 * Dime, you are auditing SSL/TLS certificates across production servers. You need to 
 * parse raw certificate logs, write a helper method that extracts and cleans raw domains 
 * into a string[] array, use C# DateTime functions to check if certificates are expired 
 * or expiring soon, and sort the servers into tracking collections.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class Exercise06
    {
        public void exercise()
        {
            string rawCertData = "CERT_ID,DOMAIN,EXPIRY_DATE,AUTO_RENEW|CRT-101,api.domain.com,2026-08-10,true|CRT-102,portal.domain.com,2026-08-25,false|CRT-103,auth.domain.com,2026-12-01,true|CRT-104,billing.domain.com,2026-08-01,false|CRT-105,gateway.domain.com,2026-09-01,true";

            string[] rows = rawCertData.Split('|');

            List<string> expiredCerts = new List<string>();
            Dictionary<string,int> expiringSoon = new Dictionary<string, int>();
            DateTime auditDate = DateTime.Parse("2026-08-17");
            
            for (int i = 1; i < rows.Length; i++)
            {
                string[] fields = ParseEntry(rows[i]);
                string certID = fields[0];
                string domain = fields[1];
                DateTime expiry = DateTime.Parse(fields[2]);
                bool autoRenew = bool.Parse(fields[3]);

                int daysRemaining = (expiry - auditDate).Days;

                if(daysRemaining < 0)
                {
                    expiredCerts.Add(certID);
                }
                else if (daysRemaining <= 15)
                {
                    expiringSoon[domain] = daysRemaining;
                }
                

            }
            Console.WriteLine("---EXPIRED CERTIFICATES---");
            Console.WriteLine(string.Join(",", expiredCerts));

            Console.WriteLine("--- EXPIRING SOON (<= 15 DAYS) ---");

            foreach (var kpv in expiringSoon)
            {
                Console.WriteLine($"Domain- {kpv.Key}, Days Remaining- {kpv.Value} ");
            }
        }

        public static string[] ParseEntry(string entry)
        {
            string[] data = entry.Split(',');
            return data;
            
        }
    }
}
        