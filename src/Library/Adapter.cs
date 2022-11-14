using System;
using System.Collections.Generic;

namespace Full_GRASP_And_SOLID
{
    //Por patron Adapter, para cumplir con Open/Closed
    public class Adapter : TimerClient
    {
        public Recipe recipe;
        public void TimeOut()
        {
            recipe.SetCooked();
        }
    }
}