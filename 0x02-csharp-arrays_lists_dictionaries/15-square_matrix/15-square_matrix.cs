using System;


    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
    {
       for(int i = 0; i < myMatrix.GetLength(0); i++)
       {
           for(int y = 0; y < myMatrix.GetLength(1); y++)
           {
               myMatrix[i,y] = myMatrix[i,y] * myMatrix[i,y];
           }      
       }
       return(myMatrix);
    }
    }