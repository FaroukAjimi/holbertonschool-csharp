using System;
using System.Reflection;
    /// <summary> class shape </summary>
    class Shape
    {
        /// <summary> </summary>
        public virtual int Area()
        {
        throw new NotImplementedException("Area() is not implemented");
        }
    }
    /// <summary> class rectangle ing(shape) </summary>
    class Rectangle : Shape {
        private int width;
        private int height;
        /// <summary> int width </summary>
        public int Width {
            get{return width;}
            set{if (value < 0)
            {throw new ArgumentException("Width must be greater than or equal to 0");
            }else{width = value;}}
        }
        /// <summary> int height </summary>
        public int Height {
            get{return height;}
            set{if (value < 0)
            {throw new ArgumentException("Height must be greater than or equal to 0");
            }else{height = value;}}
        }
        /// <summary> override area </summary>
        public new int Area(){
                return(this.width * this.height);
        }
        /// <summary> overrode to string </summary>
        public override string ToString()
        {
            return string.Format("[{0}] {1} / {2}",this.GetType(), width, height);
        }
    }
    /// <summary> squre rectanlge </summary>
    class Square : Rectangle
    {
        private int size;
        /// <summary> int size </summary>
        public int Size{
            get{return size;}
            set{
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Height = value;
            Width = value;
        }
    }
    }