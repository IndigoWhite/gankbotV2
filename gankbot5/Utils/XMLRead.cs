using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace gankbot5
{
    public class XMLRead
    {
        public static string whoRead;
        public static int commandAmountRead;
        public static int daysRead;

        public class GankCommandInfo
        {
            public String who;
            public int commandAmount;
            public int days;
        }

        public static void ReadXML(string who)
        {
            string whopath = "//gankbot" + who + "BotVariables.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath;
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));

            if (File.Exists(path))
            {
                System.IO.StreamReader files = new System.IO.StreamReader(path);
                Console.WriteLine("PATH FOUND!");
                GankCommandInfo overview = (GankCommandInfo)reader.Deserialize(files);
                files.Close();

                Console.WriteLine(overview.who + overview.commandAmount);
                whoRead = overview.who;
                commandAmountRead = overview.commandAmount;
            }
            else
            {
                Console.WriteLine("CREATING NEW XML FILE");
                GankCommandInfo overview = new GankCommandInfo();
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
                System.IO.FileStream file = System.IO.File.Create(path);
                writer.Serialize(file, overview);
                file.Close();
            }

        }

        public static void BannedReadXML(string who)
        {
            string whopath = "//gankbot/banned" + who + "BotVariables.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath;
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));

            if (File.Exists(path))
            {
                System.IO.StreamReader files = new System.IO.StreamReader(path);
                Console.WriteLine("PATH FOUND!");
                GankCommandInfo overview = (GankCommandInfo)reader.Deserialize(files);
                files.Close();

                Console.WriteLine(overview.who + overview.commandAmount);
                whoRead = overview.who;
                commandAmountRead = overview.commandAmount;
                daysRead = overview.days;
            }
            else
            {
                Console.WriteLine("CREATING NEW XML FILE");
                commandAmountRead = 0;
                daysRead = 0;
                GankCommandInfo overview = new GankCommandInfo();
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
                System.IO.FileStream file = System.IO.File.Create(path);
                writer.Serialize(file, overview);
                file.Close();
                return;
            }

        }

    }
}
