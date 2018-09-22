using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;

            while (go)
            {
                Console.Write("Enter the name of the project: ");
                string project = Console.ReadLine();
                Console.Write("Enter the activity name: ");
                string activity = Console.ReadLine();

                string url = ("https://companyserver.com/content/" + project + "/files/" + activity + "/" + activity + "Report.pdf");
                url = Uri.EscapeUriString(url);
                Console.Write(url);
                Console.Write("\nWould you like to make anothert document? (y/n): ");
                go = Console.ReadLine().ToLower().Equals("y");
              

            }
        }
      
        
            }
        }
    
