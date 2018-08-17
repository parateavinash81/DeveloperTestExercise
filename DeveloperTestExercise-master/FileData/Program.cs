using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        static FileDetails fd;
        private static string[] strVersion = { "-v", "--v", "/v", "--version" }; // array for version args
        private static string[] strSize = { "–s", "--s", "/s", "--size" };  // array for size args


        public static void Main(string[] args)
        {
            string strFilePath = ConfigurationManager.AppSettings["FilePath"];

            if (args == null)
            {
                Console.WriteLine("args is null"); // Check for null array
            }
            else
            {
                try
                {
                    fd = new FileDetails();
                    foreach (var arg in args)
                    {
                        FuncSizeVersion(arg, strFilePath);
                    }
                }
                catch (Exception ex)
                { throw ex; }

                Console.ReadLine();
            }

        }

        /// <summary>
        /// calling appropriate filedetils class methods based on argument
        /// Check inputval exist in version and size array and call appropriate method
        /// </summary>
        /// <param name="inputVal"></param>
        /// <param name="fileName"></param>
        public static void FuncSizeVersion(string inputVal, string fileName)
        {
            if (Array.IndexOf(strVersion, inputVal) != -1)
            {
                Console.WriteLine(fd.Version(fileName));
            }            
            else if (Array.IndexOf(strSize, inputVal) != -1)
            {
                Console.WriteLine(fd.Size(fileName));
            }
            else
            {
                Console.WriteLine("value not found");
            }

        }

    }

}