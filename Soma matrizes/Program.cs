using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_matrizes {
    class Program {
        static void Main(string[] args) {

            int m, n, i, j, soma;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            m = int.Parse(Console.ReadLine());

            int[,] matA = new int[n, m];
            int[,] matB = new int[n, m];
            int[,] matC = new int[n, m];

            Console.WriteLine("Digite os valores da matriz A:");////// ATRIBUI MATRIZ A
            for (i = 0; i < n; i++) {
                for (j = 0; j < m; j++) {
                    Console.Write("Elementos [" + i + "," + j + "]: ");
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B:");///// ATRIBUI MATRIZ B
            for (i = 0; i < n; i++) {
                for (j = 0; j < m; j++) {
                    Console.Write("Elementos [" + i + "," + j + "]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < n; i++) {//////////////////////// SOMA A COM B E GERA C
                soma = 0;
                for (j = 0; j < m; j++) {
                    matC[i, j] = matA[i, j] + matB[i, j];
                }
            }

            Console.WriteLine("MATRIZ SOMA:");
            for (i = 0; i < n; i++) {/////////////////////// IMPRIME A C
                for (j = 0; j < m; j++) {
                    Console.Write(matC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
