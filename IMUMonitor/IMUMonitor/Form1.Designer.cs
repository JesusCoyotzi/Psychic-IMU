namespace IMUMonitor
{
    partial class Monitor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportData = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPuertosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sender = new System.Windows.Forms.Button();
            this.SenderBox = new System.Windows.Forms.TextBox();
            this.ReceiverBox = new System.Windows.Forms.TextBox();
            this.AcelGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GyroGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graph = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.br = new System.Windows.Forms.TextBox();
            this.baudRates = new System.Windows.Forms.ComboBox();
            this.comPorts = new System.Windows.Forms.ComboBox();
            this.brk = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcelGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GyroGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip1_KeyDown);
            // 
            // exportData
            // 
            this.exportData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.terminarToolStripMenuItem,
            this.listarPuertosToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.exportData.Name = "exportData";
            this.exportData.Size = new System.Drawing.Size(60, 20);
            this.exportData.Text = "Archivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // terminarToolStripMenuItem
            // 
            this.terminarToolStripMenuItem.Name = "terminarToolStripMenuItem";
            this.terminarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.terminarToolStripMenuItem.Text = "Terminar";
            this.terminarToolStripMenuItem.Click += new System.EventHandler(this.terminarToolStripMenuItem_Click);
            // 
            // listarPuertosToolStripMenuItem
            // 
            this.listarPuertosToolStripMenuItem.Name = "listarPuertosToolStripMenuItem";
            this.listarPuertosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.listarPuertosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listarPuertosToolStripMenuItem.Text = "Listar Puertos";
            this.listarPuertosToolStripMenuItem.Click += new System.EventHandler(this.listarPuertosToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // sender
            // 
            this.sender.Location = new System.Drawing.Point(216, 32);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(75, 23);
            this.sender.TabIndex = 1;
            this.sender.Text = "Send";
            this.sender.UseVisualStyleBackColor = true;
            this.sender.Click += new System.EventHandler(this.sender_Click);
            // 
            // SenderBox
            // 
            this.SenderBox.Location = new System.Drawing.Point(16, 32);
            this.SenderBox.Name = "SenderBox";
            this.SenderBox.Size = new System.Drawing.Size(192, 20);
            this.SenderBox.TabIndex = 2;
            this.SenderBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ReceiverBox
            // 
            this.ReceiverBox.Location = new System.Drawing.Point(16, 64);
            this.ReceiverBox.Multiline = true;
            this.ReceiverBox.Name = "ReceiverBox";
            this.ReceiverBox.Size = new System.Drawing.Size(280, 184);
            this.ReceiverBox.TabIndex = 3;
            // 
            // AcelGraph
            // 
            chartArea1.Name = "ChartArea1";
            this.AcelGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AcelGraph.Legends.Add(legend1);
            this.AcelGraph.Location = new System.Drawing.Point(328, 40);
            this.AcelGraph.Name = "AcelGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Ax";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Ay";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Az";
            this.AcelGraph.Series.Add(series1);
            this.AcelGraph.Series.Add(series2);
            this.AcelGraph.Series.Add(series3);
            this.AcelGraph.Size = new System.Drawing.Size(600, 224);
            this.AcelGraph.TabIndex = 4;
            this.AcelGraph.Text = "chart1";
            // 
            // GyroGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.GyroGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GyroGraph.Legends.Add(legend2);
            this.GyroGraph.Location = new System.Drawing.Point(328, 280);
            this.GyroGraph.Name = "GyroGraph";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Ax";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Ay";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.IsXValueIndexed = true;
            series6.Legend = "Legend1";
            series6.Name = "Az";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Gx";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Gy";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "Gz";
            this.GyroGraph.Series.Add(series4);
            this.GyroGraph.Series.Add(series5);
            this.GyroGraph.Series.Add(series6);
            this.GyroGraph.Series.Add(series7);
            this.GyroGraph.Series.Add(series8);
            this.GyroGraph.Series.Add(series9);
            this.GyroGraph.Size = new System.Drawing.Size(600, 232);
            this.GyroGraph.TabIndex = 5;
            this.GyroGraph.Text = "chart2";
            // 
            // graph
            // 
            this.graph.AutoSize = true;
            this.graph.Location = new System.Drawing.Point(16, 32);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(63, 17);
            this.graph.TabIndex = 6;
            this.graph.Text = "Graficar";
            this.graph.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.br);
            this.groupBox1.Controls.Add(this.baudRates);
            this.groupBox1.Controls.Add(this.comPorts);
            this.groupBox1.Controls.Add(this.brk);
            this.groupBox1.Controls.Add(this.graph);
            this.groupBox1.Location = new System.Drawing.Point(16, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // br
            // 
            this.br.Location = new System.Drawing.Point(139, 110);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(121, 20);
            this.br.TabIndex = 10;
            // 
            // baudRates
            // 
            this.baudRates.FormattingEnabled = true;
            this.baudRates.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.baudRates.Location = new System.Drawing.Point(139, 72);
            this.baudRates.Name = "baudRates";
            this.baudRates.Size = new System.Drawing.Size(121, 21);
            this.baudRates.TabIndex = 9;
            this.baudRates.Text = "Baud Rates";
            this.baudRates.SelectedIndexChanged += new System.EventHandler(this.baudRates_SelectedIndexChanged);
            // 
            // comPorts
            // 
            this.comPorts.FormattingEnabled = true;
            this.comPorts.Location = new System.Drawing.Point(139, 32);
            this.comPorts.Name = "comPorts";
            this.comPorts.Size = new System.Drawing.Size(121, 21);
            this.comPorts.TabIndex = 8;
            this.comPorts.Text = "COM Ports";
            this.comPorts.SelectedIndexChanged += new System.EventHandler(this.comPorts_SelectedIndexChanged);
            // 
            // brk
            // 
            this.brk.AutoSize = true;
            this.brk.Location = new System.Drawing.Point(16, 56);
            this.brk.Name = "brk";
            this.brk.Size = new System.Drawing.Size(65, 17);
            this.brk.TabIndex = 7;
            this.brk.Text = "Frenado";
            this.brk.UseVisualStyleBackColor = true;
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GyroGraph);
            this.Controls.Add(this.AcelGraph);
            this.Controls.Add(this.ReceiverBox);
            this.Controls.Add(this.SenderBox);
            this.Controls.Add(this.sender);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monitor";
            this.Text = "IMUMonitor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Monitor_FormClosed);
            this.Load += new System.EventHandler(this.Monitor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcelGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GyroGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportData;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarToolStripMenuItem;
        private System.Windows.Forms.Button sender;
        private System.Windows.Forms.TextBox SenderBox;
        private System.Windows.Forms.TextBox ReceiverBox;
        private System.Windows.Forms.ToolStripMenuItem listarPuertosToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart AcelGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart GyroGraph;
        private System.Windows.Forms.CheckBox graph;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox brk;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ComboBox comPorts;
        private System.Windows.Forms.ComboBox baudRates;
        private System.Windows.Forms.TextBox br;
    }
}

