using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.Interfaces;

namespace Inheritance.Classes
{
    public class MusicalPerformer : Personnel, IDance, ISing
    {
        public MusicalPerformer()
        {
        }

        /// <summary>
        /// Musical performer counts while dancing
        /// </summary>
        /// <returns></returns>
        public string Dance()
        {
            return "And one, and two, and three, and four... turn!";
        }

        /// <summary>
        /// Musical performer sings basic tunes
        /// </summary>
        /// <returns></returns>
        public string Sing()
        {
            return "Do, Mi, Sol, Do, Sol, Mi, Doooooo";
        }

        /// <summary>
        /// Musical performer is given the tune to sing
        /// </summary>
        /// <param name="tune"></param>
        /// <returns></returns>
        public string Sing(string tune)
        {
            return $"I can also sing this: {tune}";
        }
    }
}
