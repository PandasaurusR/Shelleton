using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shelleton.Commands
{
    public static class DefaultCommands
    {
        public static string Print(string text)
        {
            return string.Format("Printed '{0}'", text);
        }

        public static string Date(DateTime date)
        {
            return string.Format("Date: {0}", date);
        }

        public static string Optional(int id, string data = "No Data Provided")
        {
            var result = string.Format(
                "I did something to the record Id {0} and save the data {1}", id, data);

            if (data == "No Data Provided")
            {
                result = string.Format(
                "I did something to the record Id {0} but the optinal parameter "
                + "was not provided, so I saved the value '{1}'", id, data);
            }
            return result;
        }
    }
}
