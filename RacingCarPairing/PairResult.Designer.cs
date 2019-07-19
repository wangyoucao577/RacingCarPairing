namespace RacingCarPairing
{
    partial class PairResult
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
            this.pairResultListView = new System.Windows.Forms.ListView();
            this.columnHeaderTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // pairResultListView
            // 
            this.pairResultListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pairResultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTeam,
            this.columnHeaderCar});
            this.pairResultListView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pairResultListView.Location = new System.Drawing.Point(0, 0);
            this.pairResultListView.Name = "pairResultListView";
            this.pairResultListView.Size = new System.Drawing.Size(527, 561);
            this.pairResultListView.TabIndex = 0;
            this.pairResultListView.TabStop = false;
            this.pairResultListView.UseCompatibleStateImageBehavior = false;
            this.pairResultListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTeam
            // 
            this.columnHeaderTeam.Text = "车队/车手";
            this.columnHeaderTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTeam.Width = 150;
            // 
            // columnHeaderCar
            // 
            this.columnHeaderCar.Text = "赛车";
            this.columnHeaderCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCar.Width = 150;
            // 
            // PairResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 561);
            this.Controls.Add(this.pairResultListView);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PairResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配对结果";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView pairResultListView;
        private System.Windows.Forms.ColumnHeader columnHeaderTeam;
        private System.Windows.Forms.ColumnHeader columnHeaderCar;
    }
}