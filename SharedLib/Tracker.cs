using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLib
{
    public class Tracker
    {
        float miles = 0;
        float gallons = 0;

        public void add_miles(float entered)
        {
            miles += entered;
        }

        public void add_gallons(float entered)
        {
            gallons += entered;
        }

        public float get_miles()
        {
            return miles;
        }

        public float get_gallons()
        {
            return gallons;
        }

    }
}
