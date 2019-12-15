namespace Seidel
{
    public class SLE
    {
        private double[] a;
        private double[] x;
        private double[] b;

        public SLE(double[] a, double[] b, double[] x)
        {
            this.a = a;
            this.b = b;
            this.x = x;
        }

        public double[] getA()
        {
            return a;
        }

        public double[] getX()
        {
            return x;
        }

        public double[] getB()
        {
            return b;
        }
    }
}
