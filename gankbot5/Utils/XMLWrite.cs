using System;
using System.Collections.Generic;
using System.Text;

namespace gankbot5
{
    public class XMLWrite
    {
          //  static void Main(string[] args)
          //  {
               // WriteXML();
          //  }

            public class GankCommandInfo
            {
                public string who;
                public int commandAmount;
                public string victim;
                public float days;
            }

            public static void WriteXML(string who, int amount)
            {

                GankCommandInfo overview = new GankCommandInfo();
                overview.who = who;
                overview.commandAmount = amount; //add the click to the total amount
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
                string whopath = "//" + who + "BotVariables.xml";
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; //"//GankBotVariables.xml"
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, overview);
                file.Close();
            }

        public static void ReadThenWrite(string who, int amount)
        {
            XMLRead.ReadXML(who);
            int initialAmount = XMLRead.commandAmountRead;

            GankCommandInfo overview = new GankCommandInfo();
            overview.who = who;
            overview.commandAmount = initialAmount + amount; //add the click to the total amount
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
            string whopath = "//gankbot/" + who + "BotVariables.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; //"//GankBotVariables.xml"
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }

        public static void BannedXML(string command, string who, float days, int amount)
        {
            XMLRead.BannedReadXML(who);
            int initialAmount = XMLRead.commandAmountRead;
            float initialDays = XMLRead.daysRead;
           
            GankCommandInfo overview = new GankCommandInfo();
            overview.who = command;
            overview.commandAmount = initialAmount + amount; //add the click to the total amount
            overview.days = initialDays + days;
            overview.victim = who;

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
            string whopath = "//gankbot/banned" + who + "BotVariables.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; //"//GankBotVariables.xml"
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }
    }
}
