// This interface is somewhat "contrived" and may be more practical in a bigger project.
// I could easily have just implemented this function in the respective classes and it probably
// would have made more sense for this project but I wanted practice implementing an interface.
// Also, the SOLID principles talked a great deal about the preference for using multiple
// small interfaces for multiple inheritance. This certainly fits that category.
//
// A brute force attack on simple ciphers is usually pretty easy to implement. Thus, they are
// easily broken. This interface allows for the implementation of brute force methods in
// the appropriate ciphers to try to break an enciphered code when the key is unknown.

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
