using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Core21_BenchApp.Models
{
    class BenchObjectReader
    {


        /// <summary>
        /// Read bench object with in path
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
        public static T ReadBenchObject<T>(string path)
        {
            T benchObject = default(T);

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                StreamReader reader = new StreamReader(path);
                benchObject = (T)serializer.Deserialize(reader);
                reader.Close();

            }
            catch { }
           
            return benchObject;
        }

        /// <summary>
        /// Read all bench object with specified extension tyle (eg .xdev)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public static List<T> ReadAllBenchObjects<T>(string path,string pattern)
        {

            List<String> allBenchObjectsPath = Directory.GetFiles(path, pattern, SearchOption.AllDirectories).ToList<String>();

            List<T> allBenchObjects = new List<T>();

            foreach (var benchObjectPath in allBenchObjectsPath)
            {
                var device = BenchObjectReader.ReadBenchObject<T>(benchObjectPath);
                if (device != null)
                {
                   
                    allBenchObjects.Add(device);
                    device.GetType().GetProperty("Path").SetValue(device,benchObjectPath);
                    device.GetType().GetProperty("FolderPath").SetValue(device, Directory.GetParent(benchObjectPath).ToString());

               }

            }

            return allBenchObjects;
        }

        /// <summary>
        /// List all object to console output
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listOfComponents"></param>
        public static void ListAllBenchObjects<T>(List<T> listOfComponents)
        {
            foreach (var item in listOfComponents)
            {
                var currentItemName =item.GetType().GetProperty("Name").GetValue(item);
                var currentItemPath = item.GetType().GetProperty("Path").GetValue(item).ToString();
                Console.Write(currentItemName);
                if (currentItemPath != null)
                    Console.WriteLine("\tPATH: \t" + System.IO.Directory.GetParent(currentItemPath).FullName);
                else Console.WriteLine("Path is null");
            }
        }

        
    }

}
