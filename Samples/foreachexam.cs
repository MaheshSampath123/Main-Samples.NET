using System;
using System.Collections.Generic;
using System.Text;

namespace MainClass
{
    class foreachexam
    { 
        public void foreach1()
        {
            string[] names = new string[] { "Sampath", "Mahesh", "Goteti" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        private void sampathforeach(string v, object name, string[] names)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            foreachexam n = new foreachexam();
            n.foreach1();
        }
    }
}
