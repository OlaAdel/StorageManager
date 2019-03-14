namespace StorageManager
{
    partial class DataVisualization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BlockTrack = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.B_Record = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SectorTrack = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Records = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BlockTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectorTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Records)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.Location = new System.Drawing.Point(514, 1);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 31);
            this.MinimizeButton.TabIndex = 15;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.DimGray;
            this.CloseButton.Location = new System.Drawing.Point(546, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(37, 31);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BlockTrack
            // 
            chartArea4.Name = "ChartArea1";
            this.BlockTrack.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.BlockTrack.Legends.Add(legend4);
            this.BlockTrack.Location = new System.Drawing.Point(0, 38);
            this.BlockTrack.Name = "BlockTrack";
            this.BlockTrack.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.BlockTrack.Series.Add(series5);
            this.BlockTrack.Size = new System.Drawing.Size(290, 295);
            this.BlockTrack.TabIndex = 16;
            this.BlockTrack.Text = "BlockTrack";
            // 
            // B_Record
            // 
            this.B_Record.AutoSize = true;
            this.B_Record.BackColor = System.Drawing.Color.Transparent;
            this.B_Record.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.B_Record.Location = new System.Drawing.Point(65, 336);
            this.B_Record.Name = "B_Record";
            this.B_Record.Size = new System.Drawing.Size(119, 23);
            this.B_Record.TabIndex = 23;
            this.B_Record.Text = "Block Track";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(391, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Sector Track";
            // 
            // SectorTrack
            // 
            chartArea5.Name = "ChartArea1";
            this.SectorTrack.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.SectorTrack.Legends.Add(legend5);
            this.SectorTrack.Location = new System.Drawing.Point(296, 38);
            this.SectorTrack.Name = "SectorTrack";
            this.SectorTrack.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.SectorTrack.Series.Add(series6);
            this.SectorTrack.Size = new System.Drawing.Size(290, 295);
            this.SectorTrack.TabIndex = 24;
            this.SectorTrack.Text = "chart1";
            // 
            // Records
            // 
            chartArea6.Name = "ChartArea1";
            this.Records.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.Records.Legends.Add(legend6);
            this.Records.Location = new System.Drawing.Point(10, 362);
            this.Records.Name = "Records";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.Records.Series.Add(series7);
            this.Records.Series.Add(series8);
            this.Records.Size = new System.Drawing.Size(498, 201);
            this.Records.TabIndex = 26;
            this.Records.Text = "Records";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(514, 503);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(51, 46);
            this.BackButton.TabIndex = 45;
            this.BackButton.Text = "↶";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DataVisualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StorageManager.Properties.Resources.Untitled_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SectorTrack);
            this.Controls.Add(this.B_Record);
            this.Controls.Add(this.BlockTrack);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataVisualization";
            this.Text = "DataVisualization";
            ((System.ComponentModel.ISupportInitialize)(this.BlockTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SectorTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart BlockTrack;
        private System.Windows.Forms.Label B_Record;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart SectorTrack;
        private System.Windows.Forms.DataVisualization.Charting.Chart Records;
        private System.Windows.Forms.Button BackButton;
    }
}