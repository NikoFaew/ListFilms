using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFilms
{
    class DBContext
    {
        public static FilmsDatabaseEntities filmsentity = new FilmsDatabaseEntities();
        public static int IdFilm;
    }
}
