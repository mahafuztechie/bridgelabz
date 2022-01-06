using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demorepo
{
    class ReplaceString
    {
        public void ReadingInputFromUser()
        {
            Console.WriteLine("Please enter your UserName");
            string uName = Console.ReadLine();
            if(uName.Length>=3)
            {
                ReplaceStringWithTemplate(uName);

            }
            else
            {
                Console.WriteLine("username should contain more than 3 characters");
            }

        }

        public static void ReplaceStringWithTemplate(string uName)
        {
            string template = "entered username is <<UserName>> ";
            if (template.Contains("<<UserName>>"))
            {
                string result = template.Replace("<<UserName>>", uName);
                Console.WriteLine("after replace: " + result);
            }
            else
            {
                Console.WriteLine("UserName does not exist");
            }
        }
    }
}
