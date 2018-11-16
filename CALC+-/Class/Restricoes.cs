using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC__.Class
{
    public class Restricoes
    {

        public string RestricaoCompleta { get; set; }

        #region Operação
        private string _operacao;

        public string Operacao
        {
            get { return _operacao; }
            set
            {
                if (value.Equals("") || value == null)
                {
                    throw new InvalidOperationException("Não existe comparativo para esta restrição(>=, <=, =)");
                }
                _operacao = value;
            }
        }
        #endregion

        #region Variável X
        private double _valorX;
        public double ValorX
        {
            get { return _valorX; }
            set
            {

                if (value < 0)
                {
                    throw new InvalidOperationException("Valor não pode ser menor que zero!");
                }
                _valorX = value;

            }
        }
        #endregion

        #region Variável Y
        private double _valorY;

        public double ValorY
        {
            get { return _valorY; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Valor não pode ser menor que zero!");
                }
                _valorY = value;
            }
        }
        #endregion

        #region Total Restrição
        private double _limiteRestricao;

        public double LimiteRestricao
        {
            get { return _limiteRestricao; }
            set
            {
                if (value < 0)
                {
                    throw new InvalidOperationException("Valor total da restrição não pode ser menor que 0");
                }
                _limiteRestricao = value;
            }
        }
        #endregion

        public bool RestricaoBool { get; set; }

        ///// <summary>
        ///// Método para atribuir comparativo bool para restrições com os dados previamente coletados
        ///// </summary>
        ///// <param name="restricao"></param>
        ///// <param name="x"></param>
        ///// <param name="y"></param>
        ///// <returns></returns>
        //public Restricoes AtribuirRestricoes(Restricoes restricao, Coord coordenadas)
        //{
        //    Restricoes restrtratada = restricao;
        //    switch (restricao.Operacao)
        //    {
        //        case ">=":
        //            restrtratada.RestricaoBool = (restricao.ValorX * coordenadas.CoordX + restricao.ValorY * coordenadas.CoordY >= restricao.LimiteRestricao);
        //            break;
        //        case "<=":
        //            restrtratada.RestricaoBool = (restricao.ValorX * coordenadas.CoordX + restricao.ValorY * coordenadas.CoordY <= restricao.LimiteRestricao);
        //            break;
        //        case "=":
        //            restrtratada.RestricaoBool = (restricao.ValorX * coordenadas.CoordX + restricao.ValorY * coordenadas.CoordY == restricao.LimiteRestricao);
        //            break;
        //        default:
        //            throw new InvalidOperationException("Erro ao tratar restrição");
        //    }
        //    return restrtratada;
        //}

        /// <summary>
        /// Método validando coordenadas na restrição já transformada em booleana
        /// </summary>
        /// <param name="restricoes"></param>
        /// <returns></returns>
        public static bool ValidarRestricoesMaximizacao(List<Restricoes> restricoes, bool flg)
        {
            foreach (var item in restricoes)
            {
                if (item.Operacao.Equals(">=") && flg == true) throw new InvalidOperationException("Esta operação não pode ser maximizada");
            }
            return true;
        }
        public static bool ValidarRestricoesMinimizacao(List<Restricoes> restricoes, bool flg)
        {
            foreach (var item in restricoes)
            {
                if (item.Operacao.Equals("<=")&& flg == false) throw new InvalidOperationException("Esta operação não pode ser minimizada");
            }
            return true;
        }
    }
}
