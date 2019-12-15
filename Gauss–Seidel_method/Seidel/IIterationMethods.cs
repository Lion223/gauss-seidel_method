namespace Seidel
{
    interface IIterativeMethods
    {
        int getIterationCount();
        double[] Solve(int iter);
        double[] Solve(double eps);
        void showResultsGrid();
    }
}
