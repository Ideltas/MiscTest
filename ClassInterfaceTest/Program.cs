using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInterfaceTest
{
    public class Note
    {
        int _NoteIx = 0;


        Note(int IX)
        {
            _NoteIx = IX;
        }


        public class Line
        {
            int _NoteLineIx = 0;

            Line(int IX)
            {
                _NoteLineIx = IX;
            }
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
