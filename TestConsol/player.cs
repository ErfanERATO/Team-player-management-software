using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayesTeam

{
    class Player
    {
        string names;
        string field;
         int age ;
        string nationality;

        public string Names { get => names; set => names = value; }
        public string Field { get => field; set => field = value; }
        public int Age { get => age; set => age = value; }
        public string Nationality { get => nationality; set => nationality = value; }

        internal static int Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}