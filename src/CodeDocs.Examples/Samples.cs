using System;
using System.Security;
using CodeDocs;

namespace CodeDocs.Examples
{
    public class Samples
    {

        [SideEffects(solid: Solid.SingleResponsibility)]
        public int Add(int x, int y)
        {
            // ...Code that updates a database/etc

            return x + y;
        }

        [Insecure("Needs to be changed to Sha512", see: "https://troyhunt.com/sha512"), Standards(see: "InternalStandardsDoc")]
        public string Hasher(string value, string salt)
        {
            var sha1Hash = ""; // assume hashing process
            return sha1Hash;
        }

        [Toxic("Can't touch this", see: "Mc Hammer", risk: Level.Massive)]
        public void SomethingTerrible()
        { 
            // cryptic code that nightmares are made of
            // nothing makes sense, but if you do anything here
            // something breaks and no one knows why
        }

        [Docs("Very cool.  Needs to be added to the core documentation please.", see: "Arch.visio", effortAmount: 3)]
        public void AwesomeCode()
        {
            // beautifully crafted code with a purpose

        }

        int counter = 1;

        [Bug("This code will crash when multiple simultaneous calls are made.")]
        [Availability("We plan on having 10K active users, this will drop the service.", risk: Level.Large), Scalability]
        [Testing("Missing test to cover parallel calls")]
        public int GetId()
        {
            counter++;
            return counter;
        }

        [DeadCode("Doesn't appear to be needed anymore, review and remove please.", effortAmount: 1)]
        public void Unusedmethod()
        { 
            // old seemingly unused code
        }
    }
}
