using System;

namespace MatrizRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursive r = new Recursive();
            //Declarando matriz
            int[,] matrix = new int[3,4] {
                {3,2,3,5} ,
                {3,2,3,5}, 
                {3,2,3,5}
            };
            int[,] matrix2 = new int[3,2] {
                {3,3},
                {1,1}, 
                {1,1}
            };
            int k = 5;

            int[,] transposeMatrix = r.GetTransposeOfMatrix(matrix2);
            
            int[,] matrix3 = new int[3,4] {
                {3,2,3,5} ,
                {3,2,3,5}, 
                {3,2,3,5}
            };
            
            //System.Console.WriteLine(r.printMatrixWithFor(matrix));
            //System.Console.WriteLine(r.printMatrixRecursivily(matrix));
            // r.multiplicateMatrixRecursivily(matrix,k);
            //System.Console.WriteLine(r.printMatrixRecursivily(matrix));
            // System.Console.WriteLine(r.printMatrixRecursivily(transposeMatrix));
            // Console.WriteLine(r.CheckSquareMatrix(matrix));
            // Console.WriteLine(r.getMatrixAverage(matrix));
            //Console.WriteLine(r.getMatrixColumsAverage(matrix));
            //Console.WriteLine(r.GetMatrixRowsAverage(matrix));
            // int[,] newmatrix = r.GetMatrixSum(matrix,matrix3);
            // Console.WriteLine(r.printMatrixRecursivily(newmatrix));
            int[,] m1 = new int[4, 4]
            {
                {3, 3, 1 ,1},
                {1, 1, 1 ,1},
                {1, 1, 1 ,1},
                {1, 1, 1 ,1}
            };            
            int[,] m2 = new int[4, 4]
            {
                {3, 3, 1 ,1},
                {1, 1, 1 ,1},
                {1, 1, 1 ,1},
                {1, 1, 1 ,1}
            };
//            int[,] newmatrix = r.GetSubtractionMatrix(matrix);
//            Console.WriteLine(r.printMatrixRecursivily(newmatrix));
//            int[,] spiralMatrix = r.GetSpiralMatrix(5);
//            Console.WriteLine(spiralMatrix);
            int[,] matrixProduct = r.GetMatrixProduct(m1, m2);
            Console.WriteLine(r.printMatrixRecursivily(matrixProduct));
        }
    }
}