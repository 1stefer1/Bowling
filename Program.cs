using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiuiu.iipb_22_2.MilyayevVD.Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Match match = new Match();
            Game game1 = new Game();

            match.AddGame(game1);

            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));
            game1.RecordThrow(new Throw(10));// Это спэр в последнем фрейме
            game1.RecordThrow(new Throw(4));
            game1.RecordThrow(new Throw(5));

            int res = game1.CalculateScore();
            Console.WriteLine("res = " + res);
            
        }
    }
}
