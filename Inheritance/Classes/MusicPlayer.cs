using Inheritance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    public class MusicPlayer : Personnel, IPlay
    {
        public string Play()
        {
            return "Not implemented yet, my friend!";
        }
    }
}
