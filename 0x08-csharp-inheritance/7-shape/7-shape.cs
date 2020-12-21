using System;

    /// <summary> class shape </summary>
    class Shape
    {
        /// <summary> virtual int </summary>
        public virtual int Area()
        {
        throw new NotImplementedException("Area() is not implemented");
        }
    }
    /// <summary> rectangle inh(shape) </summary>
    class Rectangle : Shape {
        private int width;
        private int height;
        /// <summary> integer widht </summary>
        public int Width {
            get{return width;}
            set{if (value < 0)
            {throw new ArgumentException("Width must be greater than or equal to 0");
            }else{width = value;}}
        }
        /// <summary> height </summary>
        public int Height {
            get{return height;}
            set{if (value < 0)
            {throw new ArgumentException("Height must be greater than or equal to 0");
            }else{height = value;}}
        }
        /// <summary> area override </summary>
         public override int Area(){
                return(this.width * this.height);
         }
        /// <summary> override to string </summary>
        public override string ToString()
        {
            return string.Format("[{0}] {1} / {2}",this.GetType(), width, height);
        }
    }
    