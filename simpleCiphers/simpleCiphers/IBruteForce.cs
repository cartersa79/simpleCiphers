// This interface is somewhat "artificial". I could easily have just implemented
// this function in the respective classes and it probably would have made more 
// sense to do so but I wanted practice implementing an interface. Also, the
// SOLID principles talked a great deal about the preference for using multiple
// small interfaces for multiple inheritance. This certainly fits the category of "small".


using System;
using System.Collections.Generic;
using System.Text;

namespace simpleCiphers
{
    public interface IBruteForce
    {
        void bruteForceDecipher(string inputText);
    }
}
