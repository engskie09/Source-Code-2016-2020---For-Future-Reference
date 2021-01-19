using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace theFACTisYOU
{
    class lalalahlah
    {

        public static string kuneksyun = "";

        public static void istringkoneksyon()
        {

            string notepad = @"T:\bulbulito\theFACTisYOU\theFACTisYOU\teleburnskie.txt";
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(notepad))
            {

                while (sr.Peek() >= 0)
                {

                    sb.Append(sr.ReadLine());


                }

            }

            kuneksyun =  sb.ToString();
            

        }

    }
}
