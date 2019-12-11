using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Library.UniqueValueProviders
{
    public interface IRandomGenerator
    {
        // Generate a random number between two numbers    
         int RandomNumber(int min, int max);


        // Generate a random string with a given size    
         string RandomString(int size, bool lowerCase);


        // Generate a random password    
         string RandomPassword();
       
    }
}

