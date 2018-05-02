using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DateModifier
{
    public int CheckDifference(string date1, string date2)
    {
        DateTime t = DateTime.Parse(date1);
        DateTime d = DateTime.Parse(date2);

        return Math.Abs((t - d).Days);
    }
}

