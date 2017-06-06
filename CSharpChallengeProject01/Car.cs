using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiles
{
    public class Car
    {
        private string make, model, color;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void driving()
        {
            Console.WriteLine("In Motion");
        }
        public void stopping()
        {
            Console.WriteLine("Stopped");
        }
    }
}
