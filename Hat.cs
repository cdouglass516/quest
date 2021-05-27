using System;
using System.Collections.Generic;

namespace Quest
{
    // An instance of the Challenge class is an occurrence of a single challenge
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription
        {
            get
            {
                if (this.ShininessLevel < 2)
                {
                    return "dull";
                }
                else if (this.ShininessLevel < 5)
                {
                    return "noticeable";
                }
                else if (this.ShininessLevel < 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }
            }
        }
            public Hat(int shininessLevel)
    {
        ShininessLevel = shininessLevel;
    }
    }

}