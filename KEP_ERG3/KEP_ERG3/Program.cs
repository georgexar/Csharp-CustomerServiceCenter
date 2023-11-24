using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEP_ERG3
{
    

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static Filemanager fileManager;
        public static RichTextBox richtextbox;
        public static Form1 form1;
        public static Form form4;
        public static string uniqueId;
        static void Main()
        {   fileManager = new Filemanager();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }


        public static string generateId()
        {

            string characters = "#$!0ABCDE1FGHIJ2KLMNOP5Q64RS3TUV8WX9Y0Zabcdefghijklmnopqrstuvwxyz0123456789#$!";
            string genstr = "";
            for (int i = 0; i < 8; i++)
            {

                genstr += characters[x.Next(0, characters.ToArray().Length - 1)];

            }
            return genstr;
        }



      
        public static string output = "";
        public static Filemanager getFileManager() { return fileManager; }
        public static Random x = new Random();




    }


}
