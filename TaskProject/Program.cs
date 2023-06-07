using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteTime(DateTime.Now);
        }

        public static void WriteTime(DateTime moment, string filePath = null)
        {
            if (filePath == null)
            {
                filePath = Path.GetTempFileName();
            }
            File.WriteAllText(filePath, moment.ToString());

        }
    }
}
