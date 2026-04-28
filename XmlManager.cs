using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace CSE445Project
{
    public class XmlManager
    {
        // This class is responsible for managing XML data
        // If the user exists, it will return "Staff" or "Member", otherwise it will return null
        // If it doesn't exist, it will return null

        public static string VerifyUser(string username, string password)
        {
            try
            {
                // Find the exact path to the Accounts.xml file on the server
                string filePath = HttpContext.Current.Server.MapPath("~/App_Data/Accounts.xml");

                // Load the XML file
                XDocument doc = XDocument.Load(filePath);

                // Search for a user that matches the username and password
                var matchingUser = doc.Descendants("User")
                    .FirstOrDefault(u => u.Element("Username").Value == username &&
                                         u.Element("Password").Value == password);

                if (matchingUser != null)
                {
                    // Role is found
                    return matchingUser.Element("Role").Value;
                }
            }
            catch (Exception ex)
            {
                // If no file exists, return null
                return null;
            }

            // User not found
            return null;
        }
    }
}