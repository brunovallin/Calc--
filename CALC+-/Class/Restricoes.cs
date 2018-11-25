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
    }
}
