using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Ortiz_Victor
{
    class Game
    {
        // A public string field that initilizes a title and genre
        public string title, genre;
        // 
        public Game(string titleArea = "Unkown Title", string genreArea = "Something") 
        {
            title = titleArea;
            genre = genreArea;
        }

        
    }
}
