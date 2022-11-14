using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    //Por patron Adapter
    public class Adapter : TimerClient
    {
        public Recipe recipe;
        public void TimeOut()
        {
            recipe.Cooked = true;
        }
    }
}