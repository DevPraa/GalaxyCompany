using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Module.Utils
{
    internal class TestDataParser
    {

        public static void ParsePilots(string TextLine, out string FirstName, out string LastName)
        {
            string[] tmp = TextLine.Split(' ');
            if (tmp.Length > 1)
            {
                FirstName = tmp[0];
                LastName = string.Join(" ", tmp.Skip(1));
            }
            else
            throw new ArgumentException($"{nameof(TextLine)} : invalid argument");
        }

    }
}
