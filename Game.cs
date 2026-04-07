using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Ortiz_Victor
{
    class Game
    {
        // A public string field for a title and genre variable
        public string title, genre;
        // A public constructor that takes two string paramiters and sets them to the string variables title and genre
        public Game(string titleP = "Unkown Title", string genreP = "Something") 
        {
            title = titleP;
            genre = genreP;
        }

        
    }
}
