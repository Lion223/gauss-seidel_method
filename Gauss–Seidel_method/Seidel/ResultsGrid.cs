using System;
using System.Collections.Generic;
using System.Linq;

namespace Seidel
{
    public partial class ResultsGrid : MetroFramework.Forms.MetroForm
    {
        private List<int> iterationList;
        private List<double> x1List;
        private List<double> x2List;
        private List<double> x3List;
        private List<double> d1List;
        private List<double> d2List;
        private List<double> d3List;
        private List<double> dmaxList;

        public ResultsGrid(List<List<double>> lists, List<int> iteration)
        {
            InitializeComponent();

            iterationList = new List<int>(iteration);
            x1List = new List<double>(lists.ElementAt(0));
            x2List = new List<double>(lists.ElementAt(1));
            x3List = new List<double>(lists.ElementAt(2));
            d1List = new List<double>(lists.ElementAt(3));
            d2List = new List<double>(lists.ElementAt(4));
            d3List = new List<double>(lists.ElementAt(5));
            dmaxList = new List<double>(lists.ElementAt(6));
        }

        private void ResultsGrid_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < iterationList.Count; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].HeaderCell.Value = iterationList.ElementAt(i).ToString();
                dgv.Rows[i].Cells["x1Col"].Value = x1List.ElementAt(i);
                dgv.Rows[i].Cells["x2Col"].Value = x2List.ElementAt(i);
                dgv.Rows[i].Cells["x3Col"].Value = x3List.ElementAt(i);
                dgv.Rows[i].Cells["d1Col"].Value = d1List.ElementAt(i);
                dgv.Rows[i].Cells["d2Col"].Value = d2List.ElementAt(i);
                dgv.Rows[i].Cells["d3Col"].Value = d3List.ElementAt(i);
                dgv.Rows[i].Cells["dmaxCol"].Value = dmaxList.ElementAt(i);
            }
        }
    }
}
