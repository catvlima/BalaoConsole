using System;
using System.Collections.Generic;
using System.Text;

namespace BalaoConsole_3._0
{
   public class Balao
    {

        #region Atributos

        private string _cor;

        private string _direcaoatual;

        private int _altura;

        private string _mensagem;

        #endregion


        #region Propriedades

        public string Cor { get; set; }


        public string DirecaoAtual { get; set; }


        public int Altura
        {
            get
            {
                return _altura;
            }

            set
            {
                if (value >= 0)
                {
                    _altura = value;
                }
                else
                {
                    _mensagem = "Não pode descer mais!";
                }

            }


        }

        public string Mensagem
        {
            get
            {
                return _mensagem;
            }
            set
            {
                _mensagem = value;
            }
        }




        #endregion

        public Balao()
        {

        }

        public Balao(string cor, string direcaoatual, int altura, string mensagem)
        {
            Cor = cor;
            DirecaoAtual = direcaoatual;
            Altura = altura;

        }


        #region Métodos

        public void Up(int metros)
        {
            _altura += metros;

        }

        public void Down(int metros)
        {
            _altura -= metros;
        }

        #endregion
    }

}
