namespace Demo
{
    public class Calculadora
    {
        #region Public Constructors

        public Calculadora()
        {

        }

        #endregion Public Constructors

        #region Public Properties

        public int InteiroA { get; set; }
        public int InteiroB { get; set; }
        public decimal DecimalA { get; set; }
        public decimal DecimalB { get; set; }

        #endregion Public Properties

        #region Public Methods

        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }

        #endregion Public Methods
    }
}
