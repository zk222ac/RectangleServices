using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectangleServices.Model
{
    public class AreaRec
    {
       public int Length { get; set; }
       public int Width { get; set; }

        // empty constructor
        public AreaRec()
        {

        }
        // parametric constructor 
        public AreaRec(int length , int width)
        {
            Length = length;
            Width = width;                
        }
    }
}
