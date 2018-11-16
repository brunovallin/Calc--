using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC__.Class
{
    class Matriz
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Total { get; set; }

        /// <summary>
        /// Método para definir a matriz do problema através das restrições
        /// </summary>
        /// <param name="restricoes">Restrições do Problema</param>
        /// <returns>Retorna um objeto com uma lista de linhas de uma matriz</returns>
        public static IEnumerable<Matriz> DefinirMatriz(IEnumerable<Restricoes> restricoes)
        {
            List<Matriz> matriz = new List<Matriz>();
            int i = 0;
            i = restricoes.Count();
            foreach (var item in restricoes)
            {
                Matriz linha = new Matriz()
                {
                    X = item.ValorX,
                    Y = item.ValorY,
                    Z = 0,
                    Total = item.LimiteRestricao,
                };
                matriz.Add(linha);
            }

            return matriz;
        }

        #region Determinantes 2x2
        /// <summary>
        /// Método para definir a determinante A de uma matriz 2x2
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna a determinante A da matriz</returns>
        public static double MatrizDeterminanteA2x2(IEnumerable<Matriz> matrizext)
        {
            double detA = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.X;
                matriz[i, 1] = item.Y;
                i++;
            }
            detA = ((matriz[0, 0] * matriz[1, 1]) - (matriz[1, 0] * matriz[0, 1]));

            return detA;
        }

        /// <summary>
        /// Método para definir a determinante X de uma matriz 2x2
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna a determinante X da matriz</returns>
        public static double MatrizDeterminanteX2x2(IEnumerable<Matriz> matrizext)
        {
            double detX = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.Total;
                matriz[i, 1] = item.Y;
                i++;
            }
            detX = ((matriz[0, 0] * matriz[1, 1]) - (matriz[1, 0] * matriz[0, 1]));

            return detX;
        }
        /// <summary>
        /// Método para definir a determinante Y de uma matriz 2x2
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna a determinante Y da matriz</returns>
        public static double MatrizDeterminanteY2x2(IEnumerable<Matriz> matrizext)
        {
            double detY = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.X;
                matriz[i, 1] = item.Total;
                i++;
            }
            detY = ((matriz[0, 0] * matriz[1, 1]) - (matriz[1, 0] * matriz[0, 1]));

            return detY;
        }
        #endregion

        #region Determinantes 3x3       
        /// <summary>
        /// Método para definir a determinante A de uma matriz
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna o valor da determinante Absoluta</returns>
        public static double MatrizDeterminanteA3x3(IEnumerable<Matriz> matrizext)
        {
            double detA = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.X;
                matriz[i, 1] = item.Y;
                matriz[i, 2] = (item.X > 0 && item.Y == 0) || (item.X > 0 && item.Y > 0 && i == 2) ? 1 : 0;
                i++;
            }

            detA = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
                (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) +
                (matriz[2, 0] * matriz[0, 1] * matriz[1, 2])) -
                ((matriz[2, 0] * matriz[1, 1] * matriz[0, 2]) +
                (matriz[0, 0] * matriz[2, 1] * matriz[1, 2]) +
                (matriz[1, 0] * matriz[0, 1] * matriz[2, 2]));

            return detA;
        }

        /// <summary>
        /// Método para definir a determinante X de uma matriz
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna o valor da determinante X</returns>
        public static double MatrizDeterminanteX3x3(IEnumerable<Matriz> matrizext)
        {
            double detX = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.Total;
                matriz[i, 1] = item.Y;
                matriz[i, 2] = (item.X > 0 && item.Y == 0) || (item.X > 0 && item.Y > 0 && i == 2) ? 1 : 0;
                i++;
            }
            detX = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
                (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) +
                (matriz[2, 0] * matriz[0, 1] * matriz[1, 2])) -
                ((matriz[2, 0] * matriz[1, 1] * matriz[0, 2]) +
                (matriz[0, 0] * matriz[2, 1] * matriz[1, 2]) +
                (matriz[1, 0] * matriz[0, 1] * matriz[2, 2]));

            return detX;
        }

        /// <summary>
        /// Método para definir a determinante Y de uma Matriz
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna o valor da determinante Y</returns>
        public static double MatrizDeterminanteY3x3(IEnumerable<Matriz> matrizext)
        {
            double detY = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.X;
                matriz[i, 1] = item.Total;
                matriz[i, 2] = (item.X > 0 && item.Y == 0) || (item.X > 0 && item.Y > 0 && i == 2) ? 1 : 0;
                i++;
            }
            detY = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
                (matriz[1, 0] * matriz[2, 1] * matriz[0, 2]) +
                (matriz[2, 0] * matriz[0, 1] * matriz[1, 2])) -
                ((matriz[2, 0] * matriz[1, 1] * matriz[0, 2]) +
                (matriz[0, 0] * matriz[2, 1] * matriz[1, 2]) +
                (matriz[1, 0] * matriz[0, 1] * matriz[2, 2]));

            return detY;
        }

        /// <summary>
        /// Método para definir a determinante Z de uma Matriz
        /// </summary>
        /// <param name="matrizext"></param>
        /// <returns>Retorna o valor da determinante Z</returns>
        public static double MatrizDeterminanteZ3x3(IEnumerable<Matriz> matrizext)
        {
            double detZ = 0;
            int i = 0;
            double[,] matriz = new double[matrizext.Count(), matrizext.Count()];
            foreach (var item in matrizext)
            {
                matriz[i, 0] = item.X;
                matriz[i, 1] = item.Y;
                matriz[i, 2] = item.Total;
                i++;
            }
            detZ = ((matriz[0, 0] * matriz[1, 1] * matriz[2, 2]) +
                (matriz[0, 1] * matriz[1, 2] * matriz[2, 0]) +
                (matriz[0, 2] * matriz[1, 0] * matriz[2, 1])) -
                ((matriz[0, 2] * matriz[1, 1] * matriz[2, 0]) +
                (matriz[0, 0] * matriz[1, 2] * matriz[2, 1]) +
                (matriz[0, 1] * matriz[1, 0] * matriz[2, 2]));

            return detZ;
        }
        #endregion
    }
}
