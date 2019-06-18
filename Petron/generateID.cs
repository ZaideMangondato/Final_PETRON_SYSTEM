using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petron
{
    class generateID
    {
        public static String generateNewID(){
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            return unixTimestamp.ToString();
        }
    }
}
