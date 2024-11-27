
using System;

class Matrix {
    static void Main() {
        double[,] A = new double[,] { { 1, 2 }, { 3, 4 } };
        double[,] B = new double[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        double[,] C = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        // Apresentamos a matriz A
        Matrix_Print("A", A);

        // Uma linha em branco
        Console.WriteLine();

        // Apresentamos a matriz B
        Matrix_Print("B", B);

        // Uma linha em branco
        Console.WriteLine();

        // Apresentamos a matriz C
        Matrix_Print("C", C);
    }

    /**
    /*  Função que dada uma matriz apresenta o seu conteúdo no terminal
    **/
    static void Matrix_Print(string matrixName, double[,] matrix) {
        Console.WriteLine($"Matriz {matrixName}:");
        for (int i = 0; i < matrix.GetLength(0); i++) { // Percorre as linhas
            for (int j = 0; j < matrix.GetLength(1); j++) { // Percorre as colunas
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine(); // Quebra de linha ao fim de cada linha da matriz
        }
    }
}