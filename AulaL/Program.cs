using System;

class Matrix {
    static void Main() {
        double[,] A = new double[,] { { 1, 2 }, { 3, 4 } };
        double[,] B = new double[,] { { 5, 6 }, { 7, 8 } };

        // Apresentamos as matrizes A e B
        Console.WriteLine("Matrizes de entrada:");
        Matrix_Print("A", A);
        Console.WriteLine();
        Matrix_Print("B", B);
        Console.WriteLine();

        // Calculamos a soma das matrizes
        double[,] C = Matrix_Add(A, B);

        // Apresentamos a matriz resultante
        if (C != null) {
            Console.WriteLine("Resultado da soma:");
            Matrix_Print("A + B", C);
        } else {
            Console.WriteLine("Erro: As matrizes não possuem as mesmas dimensões.");
        }
    }

   
    static void Matrix_Print(string matrixName, double[,] matrix) {
        Console.WriteLine($"Matriz {matrixName}:");
        for (int i = 0; i < matrix.GetLength(0); i++) { // Percorre as linhas
            for (int j = 0; j < matrix.GetLength(1); j++) { // Percorre as colunas
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine(); // Quebra de linha ao fim de cada linha da matriz
        }
    }

  
    static double[,] Matrix_Add(double[,] A, double[,] B) {
        // Verifica se as dimensões das matrizes são compatíveis
        if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1)) {

            return null; // Retorna null se as dimensões forem incompatíveis
        }

        int rows = A.GetLength(0);
        int cols = A.GetLength(1);
        double[,] result = new double[rows, cols];

        // Realiza a soma elemento a elemento
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                result[i, j] = A[i, j] + B[i, j];
            }
        }

        return result;
    }
//Calcular determinante
    static double Matrix_Determinant2x2(double[,] M) {
if (M.GetLength(0)!=M.GetLength(1))
throw new ArgumentException("Matrix must be square");
return M[0,0]*M[1,1]-M[0,1]*M[1,0];
}
}
