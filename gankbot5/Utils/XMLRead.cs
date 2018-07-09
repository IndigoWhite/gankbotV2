//XMLRead.CS handles reading from XML files to define basic variables.

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace gankbot5
{
    public class XMLRead
    {

        //SETUP SOME STATIC VARIABLES THAT CAN BE READ ELSEWHERE
        public static string whoRead;
        public static int commandAmountRead;
        public static int daysRead;

        public class GankCommandInfo
        {
            public String who;
            public int commandAmount;
            public int days;
        }

        //READ FILE FUNCTION
        public static void ReadXML(string who)
        {
            string whopath = "//gankbot" + who + "BotVariables.xml"; //FIND A FILE PATH
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; //SET THE FULL PATH
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo)); //SERIALIZE THE DATA

            if (File.Exists(path)) //IF THE FILE EXISTS
            {
                System.IO.StreamReader files = new System.IO.StreamReader(path); //READ THE FILE
                Console.WriteLine("PATH FOUND!"); //LOG TO THE CONSOLE
                GankCommandInfo overview = (GankCommandInfo)reader.Deserialize(files); //DESERIALIZE
                files.Close(); //CLOSE THE FILE

                // USE THE VALUES READ FROM THE FILE TO DEFINE THE STATIC VARIABLES
                whoRead = overview.who; 
                commandAmountRead = overview.commandAmount;
                
            }
            else //IF THE FILE DOES NOT EXIST (LIKELY WHEN THE COMMAND IS FIRST CALLED)
            {
                Console.WriteLine("CREATING NEW XML FILE"); //LOG TO THE CONSOLE
                GankCommandInfo overview = new GankCommandInfo();
                commandAmountRead = 0; //SET THIS TO 0 AS IT'S THE FIRST TIME THE COMMAND HAS BEEN USED
                //CREATE A NEW FILE
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
                System.IO.FileStream file = System.IO.File.Create(path);
                writer.Serialize(file, overview);
                file.Close();
            }

        }

        //!banned SPECIFIC HANDLING. WORKS LIKE ReadXML(), WE READ MORE DATA HERE AND FILE PATH IS SLIGHTLY DIFFERENT
        public static void BannedReadXML(string who)
        {
            string whopath = "//gankbot/banned" + who + "BotVariables.xml"; //<<<---DIFFERENT PATH
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
                daysRead = overview.days; //EXTRA DATA POINT
            }
            else
            {
                Console.WriteLine("CREATING NEW XML FILE");
                commandAmountRead = 0;
                daysRead = 0; //EXTRA DATA POINT
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
