using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC__.Class
{
    public class Coord
    {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public double[] MatrizDeterminante { get; set; }
        public Coord()
        {

        }
        
        #region PorCoordenada

        //public Coord(double x, double y)
        //{
        //    this.CoordX = x;
        //    this.CoordY = y;
        //}
        //
        ///// <summary>
        ///// Método para atribuir a coordenada de X
        ///// </summary>
        ///// <param name="restricao"></param>
        ///// <returns></returns>
        //public static double AtribuirCoordX(Restricoes restricao)
        //{
        //    double coordX = 0;
        //    if (restricao.ValorY != 0)
        //    {
        //        coordX = restricao.LimiteRestricao / restricao.ValorX;
        //        if (double.IsInfinity(coordX))
        //        {
        //            coordX = 0;
        //        }
        //    }
        //    else if (restricao.ValorY == 0)
        //    {
        //        coordX = restricao.LimiteRestricao;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Não foi possível encontrar coordenada para X");
        //    }

        //    return coordX;
        //}

        //public static double AtribuirCoordYComValordeX(Restricoes restricao, double x)
        //{
        //    double coordY = 0;
        //    if (x != 0)
        //    {
        //        coordY = restricao.LimiteRestricao - restricao.ValorX * x;
        //        if (double.IsInfinity(coordY))
        //        {
        //            coordY = 0;
        //        }
        //        else if(double.IsNaN(coordY))
        //        {
        //            coordY = restricao.LimiteRestricao - restricao.ValorX * x;
        //        }
        //    }
        //    else if (x == 0)
        //    {
        //        coordY = restricao.LimiteRestricao;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Não foi possível encontrar coordenada para Y");
        //    }

        //    return coordY;
        //}

        ///// <summary>
        ///// Método para atribuir a coordenada de Y
        ///// </summary>
        ///// <param name="restricao"></param>
        ///// <returns></returns>
        //public static double AtribuirCoordY(Restricoes restricao, double coordxext)
        //{
        //    double coordY = 0;
        //    if (restricao.ValorY != 0)
        //    {
        //        coordY = restricao.LimiteRestricao / restricao.ValorY;
        //        if (double.IsInfinity(coordY)||double.IsNaN(coordY))
        //        {
        //            coordY = (restricao.LimiteRestricao - coordxext) / restricao.ValorY;
        //        }
        //    }
        //    else if (restricao.ValorY == 0)
        //    {
        //        coordY = restricao.LimiteRestricao;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Não foi possível encontrar o valor de Y");
        //    }

        //    return coordY;
        //}

        ///// <summary>
        ///// Método para calcular o valor da coordenada x com o valor de Y
        ///// </summary>
        ///// <param name="restricao"></param>
        ///// <param name="y"></param>
        ///// <returns></returns>
        //public static double AtribuirCoordXComValorY(Restricoes restricao, double y)
        //{
        //    double coordX = 0;
        //    if (y != 0)
        //    {
        //        coordX = restricao.LimiteRestricao - restricao.ValorY * y;
        //        if (double.IsInfinity(coordX))
        //        {
        //            coordX = 0;
        //        }
        //    }
        //    else if (y == 0)
        //    {
        //        coordX = restricao.LimiteRestricao;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Não foi possível encontrar coordenada para Y");
        //    }

        //    return coordX;
        //} 
        #endregion
    }
}
