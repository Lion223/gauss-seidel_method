namespace Seidel
{
    partial class ResultsGrid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.x1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d1Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d2Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dmaxCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x1Col,
            this.x2Col,
            this.x3Col,
            this.d1Col,
            this.d2Col,
            this.d3Col,
            this.dmaxCol});
            this.dgv.Location = new System.Drawing.Point(23, 63);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 60;
            this.dgv.Size = new System.Drawing.Size(742, 320);
            this.dgv.TabIndex = 0;
            // 
            // x1Col
            // 
            this.x1Col.HeaderText = "x1";
            this.x1Col.Name = "x1Col";
            // 
            // x2Col
            // 
            this.x2Col.HeaderText = "x2";
            this.x2Col.Name = "x2Col";
            // 
            // x3Col
            // 
            this.x3Col.HeaderText = "x3";
            this.x3Col.Name = "x3Col";
            // 
            // d1Col
            // 
            this.d1Col.HeaderText = "d1";
            this.d1Col.Name = "d1Col";
            // 
            // d2Col
            // 
            this.d2Col.HeaderText = "d2";
            this.d2Col.Name = "d2Col";
            // 
            // d3Col
            // 
            this.d3Col.HeaderText = "d3";
            this.d3Col.Name = "d3Col";
            // 
            // dmaxCol
            // 
            this.dmaxCol.HeaderText = "dmax";
            this.dmaxCol.Name = "dmaxCol";
            // 
            // ResultsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 397);
            this.Controls.Add(this.dgv);
            this.Name = "ResultsGrid";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.ResultsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn x1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn x2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn x3Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn d1Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn d2Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn d3Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dmaxCol;
    }
}