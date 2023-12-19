using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singletone_DP
{
    public class GCard
    {
        public int Data { get; set; }

        ///1-) Singeltone Design pattern private Contractor
        private GCard(int data)
        {
            Data = data  ;
        }

        //Solution Two Static ReadOnly Property
       public static GCard SingletoneObj { get; } = new GCard(123);

        #region Solution 2 Statick Method
        //3-)Static Attribute with The Defult Value  = Null 
        //private static GCard singletoneObj;
        ////4-)
        //static GCard()
        //{
        //    singletoneObj = new GCard(123);
        //}


        ////2-) create Method To return Constarctore
        //public static GCard GetCard()
        //{
        //    // Replace to use static Constractore doesnot need to check every time using Step (4)
        //    //if (singletoneObj is null)
        //    //    singletoneObj = new GCard(123);

        //    return singletoneObj;
        //} 
        #endregion

    }
}
