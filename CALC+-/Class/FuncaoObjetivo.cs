using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALC__.Class
{
    public class FuncaoObjetivo
    {

        #region Propriedades
        #region Valor Ótimo
        private double _valorotimo;
        public double ValorOtimo
        {
            get { return _valorotimo; }
            set
            {
                if (value < 0 || value.Equals(""))
                {
                    throw new InvalidOperationException("Valor ótimo Inválido");
                }
                _valorotimo = value;

            }
        }

        public string ValidaOperacao { get; set; }

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

        private double _x;
        public double X
        {
            get { return _x; }
            set
            {
                if (_x < 0)
                {
                    throw new InvalidOperationException("Variável não pode ser negativa");
                }
                _x = value;
            }
        }

        private string _nomevarx;

        public string NomeVarX
        {
            get { return _nomevarx; }
            set
            {
                if (value.Equals(""))
                {
                    _nomevarx = "X";
                }
                else
                {
                    _nomevarx = value;
                }
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
                if (value <= 0)
                {
                    throw new InvalidOperationException("Valor não pode ser menor que zero!");
                }
                _valorY = value;
            }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
            set
            {
                if (_y < 0)
                {
                    throw new InvalidOperationException("Variável não pode ser negativa");
                }
                _y = value;
            }
        }

        private string _nomevary;

        public string NomeVarY
        {
            get { return _nomevary; }
            set
            {
                if (value.Equals(""))
                {
                    _nomevary = "Y";
                }
                else
                {
                    _nomevary = value;
                }
            }
        }

        #endregion
        #endregion        
    }
}
