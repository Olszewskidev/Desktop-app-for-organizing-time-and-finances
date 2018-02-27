using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
   public class SavingUserSettinginXML
    {
        public static void SaveData(object obj, string filename)
        {
            XmlSerializer serialize = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            serialize.Serialize(writer, obj);
            writer.Close();
        }
    }
}
