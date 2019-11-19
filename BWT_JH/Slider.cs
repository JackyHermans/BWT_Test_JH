using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BWT_JH
{
    public class Slider
    {
        public int Input { get; set; }

        public string Waarde { get; set; }

        public Slider()
        {
            Waarde = Input.ToString();
        }
    }
}
