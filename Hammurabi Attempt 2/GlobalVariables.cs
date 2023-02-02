using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hammurabi_Attempt_2
{
    class GlobalVariables
    {
        private static int v_score = 0;

        public static int score
        {
            get { return v_score; }
            set { v_score = value; }
        }

        private static string v_name = "";

        public static string name
        {
            get { return v_name; }
            set => v_name = value;
        }



    }
}
