//XMLWrite.CS handles writing to XML files to save basic data.

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

            //DEFINING A CLASS TO STORE BASIC VARIABLE VALUES
            public class GankCommandInfo
            {
                public string who; //WHAT COMMAND HAS BEEN CALLED
                public int commandAmount; //HOW MANY TIMES IT'S BEEN CALLED
                public string victim; //!banned specific. NAME OF PERSON "BANNED"
                public float days; //!banned specific. LIFETIME AMOUNT OF DAYS "BANNED"
            }

            //WRITING TO AN XML FILE FUNCTION
            public static void WriteXML(string who, int amount)
            {
                
                GankCommandInfo overview = new GankCommandInfo(); //DEFINE A NEW INSTANCE
                overview.who = who; //SET THE COMMAND CALLED
                overview.commandAmount = amount; //SET THE INITIAL CALLED AMOUNT
                System.Xml.Serialization.XmlSerializer writer =
                    new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo)); //SETUP SERILIZATION OF DATA
                string whopath = "//gankbot" + who + "BotVariables.xml"; //DEFINE A FILE NAME BASED ON INFORMATION PASSED
                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; //SETUP A FILE PATH
                System.IO.FileStream file = System.IO.File.Create(path); //CREATE THE PATH

                writer.Serialize(file, overview); //WRITE THE DATA TO THE FILE
                file.Close();//CLOSE THE FILE
            }

        //SAME AS ABOVE BUT WE PERFORM A FILE READ BEFORE HAND TO GET CORRECT AMOUNT VALUES.
        public static void ReadThenWrite(string who, int amount)
        {
            XMLRead.ReadXML(who); //READ THE FILE
            int initialAmount = XMLRead.commandAmountRead;

            GankCommandInfo overview = new GankCommandInfo();
            overview.who = who;
            overview.commandAmount = initialAmount + amount; //<<<< --- THIS IS CHANGED TO ADD TO THE PREVIOUS AMOUNT
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));
            string whopath = "//gankbot/" + who + "BotVariables.xml";
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath;
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }

        //!banned SPECIFIC HANDLING. WE JUST HANDLE MORE VARIABLES HERE.
        public static void BannedXML(string command, string who, float days, int amount)
        {
            XMLRead.BannedReadXML(who);
            int initialAmount = XMLRead.commandAmountRead;
            float initialDays = XMLRead.daysRead;
           
            GankCommandInfo overview = new GankCommandInfo();
            overview.who = command;
            overview.commandAmount = initialAmount + amount;
            overview.days = initialDays + days; //ADD TO THE TOTAL DAYS COUNT
            overview.victim = who; //SETTING A VICTIM

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(GankCommandInfo));

            //AS THIS IS BANNED SPECIFIC WE PREDEFINE BANNED, AND INSTEAD USE THE VICTIM TO CHANGE THE FILENAME
            string whopath = "//gankbot/banned" + who + "BotVariables.xml"; 
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + whopath; 
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, overview);
            file.Close();
        }
    }
}
