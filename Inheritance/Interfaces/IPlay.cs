using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Interfaces
{
    /// <summary>
    /// The person can play an instrument
    /// </summary>
    public interface IPlay
    {
        /// <summary>
        /// Play instrument
        /// </summary>
        /// <returns></returns>
        string Play();
    }
}
