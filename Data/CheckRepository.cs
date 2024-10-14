using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Data
{
    public class CheckRepository
    {
        private static List<Item> _item = null;
        static CheckRepository() {
            _item = new List<Item> {
            new _item{Id=1,Name="school",Text="Came back from school."}
            new _item{Id=2,Name="homework",Text="Finished homeworks."}
            new _item{Id=3,Name="asp",Text="Watched Asp.NetCore Tutorials."}
            new _item{Id=4,Name="study",Text="Lessons studied."}
            }
        }

        public static List<Item> Items {
            get {
                return _item;
            }
        }
    }
}