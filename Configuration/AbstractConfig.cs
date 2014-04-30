using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Reflection;
using System.Text.RegularExpressions;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Configuration
{
    public abstract class AbstractConfig<T>
    {

        public void Load()
        {
            String fullfilename = CONFIG_FILE_PATH + Path.DirectorySeparatorChar + XML_FILENAME;
            if (!File.Exists(fullfilename))
            {
                SetObject(GetObject());
                return;
            }
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (XmlTextReader reader = new XmlTextReader(fullfilename))
                {
                    var elem = (T)ser.Deserialize(reader);
                    SetObject(elem); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The XML object could not be deserialized from file! \n" + ex.ToString());
                SetObject(GetDefault());
                return;
            }
        }

        public void Save()
        {
            String fullfilename = CONFIG_FILE_PATH + Path.DirectorySeparatorChar + XML_FILENAME;

            XmlSerializer xmlGen = new XmlSerializer(typeof(T));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = System.Text.Encoding.UTF8;
            using (XmlWriter writer = XmlWriter.Create(fullfilename, settings))
            {
                xmlGen.Serialize(writer, GetObject());
                writer.Close();
            }
        }

        protected abstract T GetObject();

        protected abstract T GetDefault();

        protected abstract void SetObject(T obj);

        private static String XML_FILENAME = "Strategy.config.xml";

        private static String CONFIG_FILE_PATH =
             Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}