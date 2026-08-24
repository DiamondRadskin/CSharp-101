/* 
 * 2026-08-12
 *  
 *  Lab Exercise: CSV Log Parser & Elevated Access Filtering(Focus: Arrays -> List<T>, for loop, 
 *  switch statement, .Split())
 *  AI Generated Exercise but Manually Coded :) \m/
 *  
 *  Scenario - Dime receives a raw CSV-formatted log string exported from an 
 *  authentication server. He needs to parse the lines, split the columns into an array, and use a 
 *  switch statement to route users into an active access list based on their role.
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises1
{
    internal class CollectionsStrings1
    {
        public void exercise()
        {

            string rawCsvData = "USER_ID,USERNAME,ROLE,STATUS|101,dime_admin,ADMIN,ACTIVE|102,eryk_dev,DEV,ACTIVE|103,guest_01,GUEST,INACTIVE|104,tochi_lead,LEAD,ACTIVE|105,temp_user,GUEST,ACTIVE";
            
            string[] lines = rawCsvData.Split('|');
            
            List<string> elevatedUsers = new List<string>();

            for (int i = 1; i < lines.Length; i++)
            {
                
                string[] columns = lines[i].Split(',');
                string Id = columns[0];
                string name = columns[1];
                string role = columns[2];
                string status = columns[3];

                if (status == "INACTIVE")
                {
                    continue;
                }
                              
                switch (role)
                {
                    case "ADMIN":                        
                        elevatedUsers.Add($"{name} [ELEVATED]");
                        break;

                    case "DEV":                        
                        elevatedUsers.Add($"{name} [STANDARD]");
                        break;
                    
                    default:                        
                        elevatedUsers.Add($"{name} [GUEST]");
                        break;
                }     
                
            }

            string elevatedUsersL = string.Join("|", elevatedUsers);

            Console.WriteLine(elevatedUsersL);

        }
    }
}


