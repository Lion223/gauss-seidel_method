using System;
using System.Collections.Generic;
using System.Linq;

namespace Seidel
{
    class SeidelMethod : IIterativeMethods
    {
        private double[] a;
        private double[] x;
        private double[] b;
        private double[] d;
        private double[] old_x;
        private int completedIterations;

        private ResultsGrid res = null;

        private List<int> iterationList = new List<int>();
        private List<double> x1List = new List<double>();
        private List<double> x2List = new List<double>();
        private List<double> x3List = new List<double>();
        private List<double> d1List = new List<double>();
        private List<double> d2List = new List<double>();
        private List<double> d3List = new List<double>();
        private List<double> dmaxList = new List<double>();

        public SeidelMethod(SLE sle)
        {
            a = sle.getA();
            x = sle.getX();
            b = sle.getB();
        }

        public double[] Solve(int iter)
        {
            clearLists();
            d = new double[3] { x[0], x[1], x[2] };
            old_x = new double[3] { x[0], x[1], x[2] };
            for (int i = 0; i < iter; i++)
            {
                for (int j = 0; j < 3; j++)
                    old_x[j] = x[j];

                x[0] = Math.Round((b[0] - a[1] * x[1] - a[2] * x[2]) / a[0], 6);
                x[1] = Math.Round((b[1] - a[3] * x[0] - a[5] * x[2]) / a[4], 6);
                x[2] = Math.Round((b[2] - a[6] * x[0] - a[7] * x[1]) / a[8], 6);

                for (int j = 0; j < 3; j++)
                    d[j] = Math.Round(Math.Abs(old_x[j] - x[j]), 6);

                iterationList.Add(i);
                x1List.Add(x[0]);
                x2List.Add(x[1]);
                x3List.Add(x[2]);
                d1List.Add(d[0]);
                d2List.Add(d[1]);
                d3List.Add(d[2]);
                dmaxList.Add(d.Max());
                completedIterations = i;
            }
            completedIterations++;
            return new double[] { x[0], x[1], x[2] };
        }

        public double[] Solve(double eps)
        {
            clearLists();
            completedIterations = 0;
            d = new double[3] { x[0], x[1], x[2] };
            old_x = new double[3] { x[0], x[1], x[2] };
            do
            {
                for (int i = 0; i < 3; i++)
                    old_x[i] = x[i];

                x[0] = Math.Round((b[0] - a[1] * x[1] - a[2] * x[2]) / a[0], 6);
                x[1] = Math.Round((b[1] - a[3] * x[0] - a[5] * x[2]) / a[4], 6);
                x[2] = Math.Round((b[2] - a[6] * x[0] - a[7] * x[1]) / a[8], 6);

                for (int i = 0; i < 3; i++)
                    d[i] = Math.Round(Math.Abs(old_x[i] - x[i]), 6);

                iterationList.Add(completedIterations);
                x1List.Add(x[0]);
                x2List.Add(x[1]);
                x3List.Add(x[2]);
                d1List.Add(d[0]);
                d2List.Add(d[1]);
                d3List.Add(d[2]);
                dmaxList.Add(d.Max());
                completedIterations++;
            } while (d.Max() > eps);
            return new double[] { x[0], x[1], x[2] };
        }

        public int getIterationCount()
        {
            return completedIterations;
        }

        private void clearLists()
        {
            iterationList.Clear();
            x1List.Clear();
            x2List.Clear();
            x3List.Clear();
            d1List.Clear();
            d2List.Clear();
            d3List.Clear();
            dmaxList.Clear();
        }

        public void showResultsGrid()
        {
            List<List<double>> lists = new List<List<double>>();
            lists.Add(x1List);
            lists.Add(x2List);
            lists.Add(x3List);
            lists.Add(d1List);
            lists.Add(d2List);
            lists.Add(d3List);
            lists.Add(dmaxList);

            res = new ResultsGrid(lists, iterationList);
            res.ShowDialog();
        }
    }
}

