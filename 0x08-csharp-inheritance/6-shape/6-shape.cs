using System;

    /// <summary> </summary>
    class Shape
    {
        /// <summary> </summary>
        public virtual int Area()
        {
        throw new NotImplementedException("Area() is not implemented");
        }
    }
    /// <summary> class rectangle inh(shape) </summary>
    class Rectangle : Shape {
        private int width;
        private int height;
        /// <summary> public int width </summary>
        public int Width {
            get{return width;}
            set{if (value < 0)
            {throw new ArgumentException("Width must be greater than or equal to 0");
            }else{width = value;}}
        }
        /// <summary> public height </summary>
        public int Height {
            get{return height;}
            set{if (value < 0)
            {throw new ArgumentException("Height must be greater than or equal to 0");
            }else{height = value;}}
        }
    }
