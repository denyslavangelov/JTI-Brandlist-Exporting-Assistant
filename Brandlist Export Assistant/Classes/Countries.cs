using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Brandlist_Export_Assistant.Classes
{
    public class Countries
    {
        public static Dictionary<string, string> ExportCountries(string excelCountry)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            string fileName = "Resources\\Countries.txt";

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(fileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var country = line.Substring(0, line.Length - 3);
                    var countryCode = line.Substring(line.Length - 3, 3);

                    if (country.Contains(excelCountry))
                    {
                        countries.Add(country, countryCode);
                        break;
                    }
                }
                streamReader.Close();
            }


            return countries;
        }

        public static Dictionary<string, string> ExportLanguages()
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            string fileName = "Resources\\Countries_iField.txt";

            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(fileName))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                String line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    var countryCode = line.Split('$')[0].Trim();

                    var country = line.Split('$')[1].Trim();

                    countries.Add(countryCode, country);
                }
                streamReader.Close();
            }


            return countries;
        }
    }
}
