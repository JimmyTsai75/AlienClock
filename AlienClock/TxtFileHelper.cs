using System.IO;
using System.Text;

namespace AlienClock
{
    public class TxtFileHelper
    {
        /// <summary>
        /// Read out the content of the text file
        /// </summary>
        /// <param name="filename">File Name</param>        
        public static string FileToString(string filename)
        {
            if (File.Exists(filename) == false)
            {
                return string.Empty;
            }
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            string line = sr.ReadToEnd();
            sr.Close();
            return line;
        }
        /// <summary>
        /// Write the text into a txt file
        /// </summary>
        /// <param name="str"></param>
        /// <param name="fileName"></param>
        public static void StringToFile(string str, string fileName)
        {
            StreamWriter sw = File.CreateText(fileName);
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
