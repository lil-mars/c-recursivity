using System;

namespace MatrizRecursive
{
    internal class Recursive
    {
        public Recursive()
        {
        }

        public string printMatrixWithFor(int[,] matrix, string result = "")
        {
            //La primera dimension de la matriz o la dimension 0 son las filas
            //La sengunda dimension de la matriz o la dimension 1 son las columnas
            //result += "Primera dimension de la matriz" +matrix.GetLength(0);
            //result += "Segunda dimension de la matriz" + matrix.GetLength(1);

            for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow++)
            {
                for (int indexCol = 0; indexCol < matrix.GetLength(1); indexCol++)
                {
                    result += matrix[indexRow, indexCol] + " ";
                }

                result += "\n";
            }

            return result;
        }

        internal void multiplicateMatrixRecursivily(int[,] matrix, int number, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    multiplicateMatrixRecursivily(matrix, number, indexRow, indexCol);
                }
                else
                {
                    matrix[indexRow, indexCol] = matrix[indexRow, indexCol] * number;
                    indexCol++;
                    multiplicateMatrixRecursivily(matrix, number, indexRow, indexCol);
                }
            }
        }

        public string printMatrixRecursivily(int[,] matrix, int indexRow = 0, int indexCol = 0, string result = "")
        {
            if (indexRow == matrix.GetLength(0))
            {
                return result;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    result += "\n";
                    return printMatrixRecursivily(matrix, indexRow, indexCol, result);
                }
                else
                {
                    result += " " + matrix[indexRow, indexCol];
                    indexCol++;
                    return printMatrixRecursivily(matrix, indexRow, indexCol, result);
                }
            }
        }

        public int[,] GetTransposeOfMatrix(int[,] matrix)
        {
            // Creamos una nueva matriz con los tamanados de la primera matriz pero invertidos
            int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
            // Es
            return GetTransposeOfMatrix(matrix, newMatrix);
        }

        // En este metodo llenamos la matriz que ya tiene asignado su tamano
        private int[,] GetTransposeOfMatrix(int[,] matrix, int[,] newMatrix, int indexRow = 0, int indexCol = 0)
        {
            // Condicion para finalizar el bucle
            if (indexRow == matrix.GetLength(0))
            {
                return newMatrix;
            }

            else
            {
                // Cuando acabamos de movernos por las columnas de una fila
                if (indexCol == matrix.GetLength(1))
                {
                    // Cambiamos de fila y nos vamos ala primera columna
                    indexRow++;
                    indexCol = 0;
                    // Nos llamamos recursivamente para efectuar los cambios
                    return GetTransposeOfMatrix(matrix, newMatrix, indexRow, indexCol);
                }
                // Normalmente los procesos se hace dentro del else
                else
                {
                    // Las filas de la nueva matriz se mueven con las columnas de la otra matriz
                    newMatrix[indexCol, indexRow] = matrix[indexRow, indexCol];
                    indexCol++;
                    // Efectuar los cambios
                    return GetTransposeOfMatrix(matrix, newMatrix, indexRow, indexCol);
                }
            }
        }

        public string CheckSquareMatrix(int[,] matrix)
        {
            if (matrix.GetLength(0) == matrix.GetLength(1))
            {
                return "Es cuadrada";
            }
            else
            {
                return "No es cuadrada";
            }
        }

        public double getMatrixAverage(int[,] matrix, double plus = 0, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                double average = plus / (matrix.GetLength(0) * matrix.GetLength(1));
                return average;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return getMatrixAverage(matrix, plus, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexCol++;
                    return getMatrixAverage(matrix, plus, indexRow, indexCol);
                }
            }
        }

        // metodo para hacer un for vertical
        public string getMatrixColumsAverage(int[,] matrix, double plus = 0, string result = "", int indexRow = 0,
            int indexCol = 0)
        {
            // COndicion final
            if (indexCol == matrix.GetLength(1))
            {
                return result;
            }
            else
            {
                if (indexRow == matrix.GetLength(0))
                {
                    result += "Promedio: " + plus / matrix.GetLength(0);
                    plus = 0;
                    indexCol++;
                    indexRow = 0;
                    return getMatrixColumsAverage(matrix, plus, result, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexRow++;
                    return getMatrixColumsAverage(matrix, plus, result, indexRow, indexCol);
                }
            }
        }

        public string GetMatrixRowsAverage(int[,] matrix, double plus = 0, string result = "", int indexRow = 0,
            int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return result;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    result += "Promedio: " + plus / matrix.GetLength(1);
                    plus = 0;
                    indexRow++;
                    indexCol = 0;

                    return GetMatrixRowsAverage(matrix, plus, result, indexRow, indexCol);
                }
                else
                {
                    plus += matrix[indexRow, indexCol];
                    indexCol++;
                    return GetMatrixRowsAverage(matrix, plus, result, indexRow, indexCol);
                }
            }
        }

        public int[,] GetMatrixSum(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(0) == matrix2.GetLength(0) && (matrix.GetLength(1) == matrix2.GetLength(1)))
            {
                int[,] newMatrix = new int[matrix.GetLength(0), matrix2.GetLength(1)];
                return GetMatrixSum(matrix, matrix2, newMatrix);
            }

            return null;
        }

        public int[,] GetMatrixSum(int[,] matrix, int[,] matrix2, int[,] newmatrix, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix2.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetMatrixSum(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] + matrix2[indexRow, indexCol];
                    indexCol++;
                    return GetMatrixSum(matrix, matrix2, newmatrix, indexRow, indexCol);
                }
            }
        }

        public int[,] GetSubtractionMatrix(int[,] matrix)
        {
            int[,] newMatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
            return GetSubtractionMatrix(matrix, newMatrix);
        }

        public int[,] GetSubtractionMatrix(int[,] matrix, int[,] newmatrix, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0))
            {
                return newmatrix;
            }
            else
            {
                if (indexCol == matrix.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return GetSubtractionMatrix(matrix, newmatrix, indexRow, indexCol);
                }
                else
                {
                    newmatrix[indexRow, indexCol] = matrix[indexRow, indexCol] - 3;
                    indexCol++;
                    return GetSubtractionMatrix(matrix, newmatrix, indexRow, indexCol);
                }
            }
        }

        public int[,] GetSpiralMatrix(int number)
        {
            int[,] newMatrix = new int[number, number];
            Console.WriteLine(this.printMatrixRecursivily(newMatrix));
            return GetSpiralMatrix(newMatrix);
        }

        private int[,] GetSpiralMatrix(int[,] matrix, int number = 0)
        {
            return this.FirstMoveSpiral(matrix, number);
        }

        private int[,] FirstMoveSpiral(int[,] matrix, int number, int indexRow = 0, int indexCol = 0)
        {
            if (indexCol == matrix.GetLength(1))
            {
                indexRow++;
                indexCol--;
                return this.SecondMoveSpiral(matrix,number,indexRow,indexCol);
            }

            if (matrix[indexRow,indexCol] != 0)
            {
                indexRow++;
                indexCol--;
                return this.SecondMoveSpiral(matrix,number,indexRow,indexCol);
            }
            else {
                number++;
                matrix[indexRow, indexCol] = number;
                Console.Write(matrix[indexRow, indexCol] + " ");
                return FirstMoveSpiral(matrix, number, indexRow, ++indexCol);
            }
        }

        private int[,] SecondMoveSpiral(int[,] matrix, int number, int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrix.GetLength(0) || matrix[indexRow,indexCol] != 0)
            {
                Console.WriteLine();
                return matrix;
            } else {
                number++;
                indexRow++;
                matrix[indexRow, indexCol] = number;
                Console.Write(matrix[indexRow, indexCol] + " ");
                return SecondMoveSpiral(matrix, number, indexRow, ++indexCol);
            }
        }

        public int[,] GetMatrixProduct(int[,] matrix, int[,] matrix2)
        {
            if (matrix.GetLength(1) == matrix2.GetLength(1) &&
                matrix.GetLength(1) == matrix.GetLength(0))
            {
                int[,] matrixProduct = new int[matrix.GetLength(0),matrix.GetLength(1)]; 
                return this.GetMatrixProduct(matrix, matrix2, matrixProduct);
            }

            return null;
        }

        private int[,] GetMatrixProduct(int[,] matrix, int[,] matrix2, int[,] matrixProduct)
        { 
            return FillProductMatrixRow(matrix,matrix2,matrixProduct);
        }

        private int[,] FillProductMatrixRow(int[,] matrix, int[,] matrix2, int[,] matrixProduct,
        int indexRow = 0, int indexCol = 0)
        {
            if (indexRow == matrixProduct.GetLength(0))
            {
                // ReSharper disable once RedundantJumpStatement
                return matrixProduct;
            }
            else
            {
                if (indexCol == matrixProduct.GetLength(1))
                {
                    indexRow++;
                    indexCol = 0;
                    return FillProductMatrixRow(matrix,matrix2,matrixProduct,indexRow,indexCol);
                }
                else
                {
                    matrixProduct[indexRow, indexCol] = SumOfColsAndRows(matrix, matrix2, indexRow, indexCol);
                    indexCol++;
                    return FillProductMatrixRow(matrix,matrix2,matrixProduct,indexRow,indexCol);
                }
            }
        }

        private int SumOfColsAndRows(int[,] matrix, int[,] matrix2, int row, int col 
            ,int index = 0, int plus = 0)
        {
            if (index == matrix.GetLength(0))
            {
                return plus;
            }
            else
            {
                plus += matrix[row, index] * matrix2[index, col];
                index++;
                return SumOfColsAndRows(matrix, matrix2, row, col, index, plus);
            }
        }
    }
}