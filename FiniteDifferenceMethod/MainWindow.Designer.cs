using System.Windows.Forms;

namespace FiniteDifferenceMethod
{
    partial class MainWindow
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
            this.ApplicationMainWindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApplicationToolBox = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyValuesButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.betaTextBox = new System.Windows.Forms.TextBox();
            this.BetaLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linePotentialTextBox = new System.Windows.Forms.TextBox();
            this.LinePotentialLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DisplayColorMapButton = new System.Windows.Forms.Button();
            this.ResultButton = new System.Windows.Forms.Button();
            this.DrawArea = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.DrawingFinishedButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IterationsLabel = new System.Windows.Forms.Label();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LegendLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel12 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel13 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelLevel0 = new System.Windows.Forms.Label();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.BackgroundLabel = new System.Windows.Forms.Label();
            this.ApplicationMainWindowLayout.SuspendLayout();
            this.ApplicationToolBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel11.SuspendLayout();
            this.flowLayoutPanel12.SuspendLayout();
            this.flowLayoutPanel13.SuspendLayout();
            this.flowLayoutPanel14.SuspendLayout();
            this.flowLayoutPanel15.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationMainWindowLayout
            // 
            this.ApplicationMainWindowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationMainWindowLayout.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ApplicationMainWindowLayout.ColumnCount = 3;
            this.ApplicationMainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.ApplicationMainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ApplicationMainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.ApplicationMainWindowLayout.Controls.Add(this.ApplicationToolBox, 2, 0);
            this.ApplicationMainWindowLayout.Controls.Add(this.DrawArea, 1, 0);
            this.ApplicationMainWindowLayout.Controls.Add(this.ResetButton, 1, 1);
            this.ApplicationMainWindowLayout.Controls.Add(this.DrawingFinishedButton, 2, 1);
            this.ApplicationMainWindowLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ApplicationMainWindowLayout.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.ApplicationMainWindowLayout.Location = new System.Drawing.Point(0, 0);
            this.ApplicationMainWindowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.ApplicationMainWindowLayout.Name = "ApplicationMainWindowLayout";
            this.ApplicationMainWindowLayout.RowCount = 2;
            this.ApplicationMainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ApplicationMainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ApplicationMainWindowLayout.Size = new System.Drawing.Size(884, 563);
            this.ApplicationMainWindowLayout.TabIndex = 0;
            // 
            // ApplicationToolBox
            // 
            this.ApplicationToolBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationToolBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ApplicationToolBox.ColumnCount = 1;
            this.ApplicationToolBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.16667F));
            this.ApplicationToolBox.Controls.Add(this.ApplyValuesButton, 0, 2);
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.ApplicationToolBox.Controls.Add(this.label2, 0, 6);
            this.ApplicationToolBox.Controls.Add(this.tableLayoutPanel4, 0, 7);
            this.ApplicationToolBox.Location = new System.Drawing.Point(3, 3);
            this.ApplicationToolBox.Name = "ApplicationToolBox";
            this.ApplicationToolBox.RowCount = 8;
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.ApplicationToolBox.Size = new System.Drawing.Size(174, 517);
            this.ApplicationToolBox.TabIndex = 0;
            // 
            // ApplyValuesButton
            // 
            this.ApplyValuesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ApplyValuesButton.Location = new System.Drawing.Point(5, 83);
            this.ApplyValuesButton.Name = "ApplyValuesButton";
            this.ApplyValuesButton.Size = new System.Drawing.Size(166, 24);
            this.ApplyValuesButton.TabIndex = 8;
            this.ApplyValuesButton.Text = "Apply Values";
            this.ApplyValuesButton.UseVisualStyleBackColor = true;
            this.ApplyValuesButton.Click += new System.EventHandler(this.ApplyValuesButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.betaTextBox);
            this.flowLayoutPanel2.Controls.Add(this.BetaLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 31);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // betaTextBox
            // 
            this.betaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.betaTextBox.Location = new System.Drawing.Point(97, 6);
            this.betaTextBox.Name = "betaTextBox";
            this.betaTextBox.Size = new System.Drawing.Size(59, 22);
            this.betaTextBox.TabIndex = 3;
            // 
            // BetaLabel
            // 
            this.BetaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BetaLabel.AutoSize = true;
            this.BetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BetaLabel.Location = new System.Drawing.Point(55, 9);
            this.BetaLabel.Name = "BetaLabel";
            this.BetaLabel.Size = new System.Drawing.Size(36, 16);
            this.BetaLabel.TabIndex = 2;
            this.BetaLabel.Text = "Beta";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.linePotentialTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LinePotentialLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 35);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // linePotentialTextBox
            // 
            this.linePotentialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linePotentialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linePotentialTextBox.Location = new System.Drawing.Point(97, 7);
            this.linePotentialTextBox.Name = "linePotentialTextBox";
            this.linePotentialTextBox.Size = new System.Drawing.Size(59, 22);
            this.linePotentialTextBox.TabIndex = 3;
            // 
            // LinePotentialLabel
            // 
            this.LinePotentialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinePotentialLabel.AutoSize = true;
            this.LinePotentialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LinePotentialLabel.Location = new System.Drawing.Point(3, 10);
            this.LinePotentialLabel.Name = "LinePotentialLabel";
            this.LinePotentialLabel.Size = new System.Drawing.Size(88, 16);
            this.LinePotentialLabel.TabIndex = 2;
            this.LinePotentialLabel.Text = "Line Potential";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.Controls.Add(this.epsilonTextBox);
            this.flowLayoutPanel3.Controls.Add(this.EpsilonLabel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 44);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(165, 31);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epsilonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.epsilonTextBox.Location = new System.Drawing.Point(97, 6);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(59, 22);
            this.epsilonTextBox.TabIndex = 3;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EpsilonLabel.Location = new System.Drawing.Point(38, 9);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(53, 16);
            this.EpsilonLabel.TabIndex = 2;
            this.EpsilonLabel.Text = "Epsilon";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.DisplayColorMapButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.ResultButton, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 220);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(168, 100);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // DisplayColorMapButton
            // 
            this.DisplayColorMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DisplayColorMapButton.Location = new System.Drawing.Point(3, 53);
            this.DisplayColorMapButton.Name = "DisplayColorMapButton";
            this.DisplayColorMapButton.Size = new System.Drawing.Size(162, 44);
            this.DisplayColorMapButton.TabIndex = 12;
            this.DisplayColorMapButton.Text = "Display Color Map";
            this.DisplayColorMapButton.UseVisualStyleBackColor = true;
            this.DisplayColorMapButton.Click += new System.EventHandler(this.DisplayColorMapButton_Click);
            // 
            // ResultButton
            // 
            this.ResultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultButton.Location = new System.Drawing.Point(3, 3);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(162, 44);
            this.ResultButton.TabIndex = 11;
            this.ResultButton.Text = "Calculate Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.Result_Click);
            // 
            // DrawArea
            // 
            this.DrawArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawArea.BackColor = System.Drawing.Color.White;
            this.DrawArea.Location = new System.Drawing.Point(183, 3);
            this.DrawArea.Name = "DrawArea";
            this.DrawArea.Size = new System.Drawing.Size(548, 517);
            this.DrawArea.TabIndex = 2;
            this.DrawArea.TabStop = false;
            this.DrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            this.DrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetButton.Location = new System.Drawing.Point(183, 526);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(548, 34);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DrawingFinishedButton
            // 
            this.DrawingFinishedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DrawingFinishedButton.Location = new System.Drawing.Point(3, 526);
            this.DrawingFinishedButton.Name = "DrawingFinishedButton";
            this.DrawingFinishedButton.Size = new System.Drawing.Size(174, 34);
            this.DrawingFinishedButton.TabIndex = 11;
            this.DrawingFinishedButton.Text = "Drawing Finished";
            this.DrawingFinishedButton.UseVisualStyleBackColor = true;
            this.DrawingFinishedButton.Click += new System.EventHandler(this.Finished_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.30556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.69444F));
            this.tableLayoutPanel1.Controls.Add(this.IterationsLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.IterationsTextBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(737, 526);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(144, 34);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // IterationsLabel
            // 
            this.IterationsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IterationsLabel.AutoSize = true;
            this.IterationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IterationsLabel.Location = new System.Drawing.Point(6, 9);
            this.IterationsLabel.Name = "IterationsLabel";
            this.IterationsLabel.Size = new System.Drawing.Size(62, 16);
            this.IterationsLabel.TabIndex = 0;
            this.IterationsLabel.Text = "Iterations";
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IterationsTextBox.Location = new System.Drawing.Point(76, 6);
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(65, 22);
            this.IterationsTextBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(737, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.576402F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.4236F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 517);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LegendLabel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 27);
            this.panel1.TabIndex = 0;
            // 
            // LegendLabel
            // 
            this.LegendLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LegendLabel.AutoSize = true;
            this.LegendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LegendLabel.Location = new System.Drawing.Point(42, 3);
            this.LegendLabel.Name = "LegendLabel";
            this.LegendLabel.Size = new System.Drawing.Size(56, 18);
            this.LegendLabel.TabIndex = 0;
            this.LegendLabel.Text = "Legend";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel7, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel8, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel9, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel10, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel11, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel12, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel13, 0, 9);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel14, 0, 10);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel15, 0, 11);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.tableLayoutPanel3.RowCount = 14;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(138, 478);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Red;
            this.flowLayoutPanel4.Controls.Add(this.LabelLevel10);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(6, 7);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // LabelLevel10
            // 
            this.LabelLevel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel10.AutoSize = true;
            this.LabelLevel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLevel10.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel10.Name = "LabelLevel10";
            this.LabelLevel10.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel10.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel10.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.OrangeRed;
            this.flowLayoutPanel5.Controls.Add(this.LabelLevel9);
            this.flowLayoutPanel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel5.Location = new System.Drawing.Point(6, 42);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // LabelLevel9
            // 
            this.LabelLevel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel9.CausesValidation = false;
            this.LabelLevel9.Location = new System.Drawing.Point(0, 0);
            this.LabelLevel9.Name = "LabelLevel9";
            this.LabelLevel9.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel9.Size = new System.Drawing.Size(123, 29);
            this.LabelLevel9.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.Orange;
            this.flowLayoutPanel6.Controls.Add(this.LabelLevel8);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(6, 77);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel6.TabIndex = 2;
            // 
            // LabelLevel8
            // 
            this.LabelLevel8.AutoSize = true;
            this.LabelLevel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelLevel8.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel8.Name = "LabelLevel8";
            this.LabelLevel8.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel8.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel8.TabIndex = 0;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.Gold;
            this.flowLayoutPanel7.Controls.Add(this.LabelLevel7);
            this.flowLayoutPanel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel7.Location = new System.Drawing.Point(6, 112);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel7.TabIndex = 3;
            // 
            // LabelLevel7
            // 
            this.LabelLevel7.AutoSize = true;
            this.LabelLevel7.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel7.Name = "LabelLevel7";
            this.LabelLevel7.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel7.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel7.TabIndex = 0;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.BackColor = System.Drawing.Color.Yellow;
            this.flowLayoutPanel8.Controls.Add(this.LabelLevel6);
            this.flowLayoutPanel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel8.Location = new System.Drawing.Point(6, 147);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel8.TabIndex = 4;
            // 
            // LabelLevel6
            // 
            this.LabelLevel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel6.AutoSize = true;
            this.LabelLevel6.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel6.Name = "LabelLevel6";
            this.LabelLevel6.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel6.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel6.TabIndex = 0;
            this.LabelLevel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.BackColor = System.Drawing.Color.GreenYellow;
            this.flowLayoutPanel9.Controls.Add(this.LabelLevel5);
            this.flowLayoutPanel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel9.Location = new System.Drawing.Point(6, 182);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel9.TabIndex = 5;
            // 
            // LabelLevel5
            // 
            this.LabelLevel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel5.AutoSize = true;
            this.LabelLevel5.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel5.Name = "LabelLevel5";
            this.LabelLevel5.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel5.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel5.TabIndex = 0;
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.BackColor = System.Drawing.Color.Aquamarine;
            this.flowLayoutPanel10.Controls.Add(this.LabelLevel4);
            this.flowLayoutPanel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel10.Location = new System.Drawing.Point(6, 217);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel10.TabIndex = 6;
            // 
            // LabelLevel4
            // 
            this.LabelLevel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel4.AutoSize = true;
            this.LabelLevel4.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel4.Name = "LabelLevel4";
            this.LabelLevel4.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel4.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel4.TabIndex = 0;
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.BackColor = System.Drawing.Color.Aqua;
            this.flowLayoutPanel11.Controls.Add(this.LabelLevel3);
            this.flowLayoutPanel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel11.Location = new System.Drawing.Point(6, 252);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel11.TabIndex = 7;
            // 
            // LabelLevel3
            // 
            this.LabelLevel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel3.AutoSize = true;
            this.LabelLevel3.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel3.Name = "LabelLevel3";
            this.LabelLevel3.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel3.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel3.TabIndex = 0;
            // 
            // flowLayoutPanel12
            // 
            this.flowLayoutPanel12.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.flowLayoutPanel12.Controls.Add(this.LabelLevel2);
            this.flowLayoutPanel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel12.Location = new System.Drawing.Point(6, 287);
            this.flowLayoutPanel12.Name = "flowLayoutPanel12";
            this.flowLayoutPanel12.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel12.TabIndex = 8;
            // 
            // LabelLevel2
            // 
            this.LabelLevel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel2.AutoSize = true;
            this.LabelLevel2.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel2.Name = "LabelLevel2";
            this.LabelLevel2.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel2.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel2.TabIndex = 0;
            // 
            // flowLayoutPanel13
            // 
            this.flowLayoutPanel13.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel13.Controls.Add(this.LabelLevel1);
            this.flowLayoutPanel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel13.Location = new System.Drawing.Point(6, 322);
            this.flowLayoutPanel13.Name = "flowLayoutPanel13";
            this.flowLayoutPanel13.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel13.TabIndex = 9;
            // 
            // LabelLevel1
            // 
            this.LabelLevel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLevel1.AutoSize = true;
            this.LabelLevel1.BackColor = System.Drawing.Color.Blue;
            this.LabelLevel1.ForeColor = System.Drawing.Color.White;
            this.LabelLevel1.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel1.Name = "LabelLevel1";
            this.LabelLevel1.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel1.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel1.TabIndex = 0;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.BackColor = System.Drawing.Color.DarkBlue;
            this.flowLayoutPanel14.Controls.Add(this.LabelLevel0);
            this.flowLayoutPanel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLayoutPanel14.Location = new System.Drawing.Point(6, 357);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel14.TabIndex = 10;
            // 
            // LabelLevel0
            // 
            this.LabelLevel0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLevel0.AutoSize = true;
            this.LabelLevel0.ForeColor = System.Drawing.Color.White;
            this.LabelLevel0.Location = new System.Drawing.Point(113, 0);
            this.LabelLevel0.Name = "LabelLevel0";
            this.LabelLevel0.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.LabelLevel0.Size = new System.Drawing.Size(10, 21);
            this.LabelLevel0.TabIndex = 0;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel15.BackColor = System.Drawing.Color.Black;
            this.flowLayoutPanel15.Controls.Add(this.BackgroundLabel);
            this.flowLayoutPanel15.Location = new System.Drawing.Point(6, 392);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(126, 29);
            this.flowLayoutPanel15.TabIndex = 11;
            // 
            // BackgroundLabel
            // 
            this.BackgroundLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackgroundLabel.AutoEllipsis = true;
            this.BackgroundLabel.AutoSize = true;
            this.BackgroundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BackgroundLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.BackgroundLabel.Location = new System.Drawing.Point(22, 0);
            this.BackgroundLabel.Name = "BackgroundLabel";
            this.BackgroundLabel.Padding = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.BackgroundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackgroundLabel.Size = new System.Drawing.Size(101, 21);
            this.BackgroundLabel.TabIndex = 0;
            this.BackgroundLabel.Text = "Background";
            this.BackgroundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.ApplicationMainWindowLayout);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "Finite Difference Method";
            this.ApplicationMainWindowLayout.ResumeLayout(false);
            this.ApplicationToolBox.ResumeLayout(false);
            this.ApplicationToolBox.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            this.flowLayoutPanel12.ResumeLayout(false);
            this.flowLayoutPanel12.PerformLayout();
            this.flowLayoutPanel13.ResumeLayout(false);
            this.flowLayoutPanel13.PerformLayout();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel ApplicationMainWindowLayout;
        private Button ResetButton;
        private TableLayoutPanel ApplicationToolBox;
        private Label label2;
        private PictureBox DrawArea;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox betaTextBox;
        private Label BetaLabel;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox epsilonTextBox;
        private Label EpsilonLabel;
        private Button ApplyValuesButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox linePotentialTextBox;
        private Label LinePotentialLabel;
        private Button DrawingFinishedButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Label IterationsLabel;
        private TextBox IterationsTextBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Label LegendLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label LabelLevel10;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label LabelLevel9;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label LabelLevel8;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label LabelLevel7;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label LabelLevel6;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label LabelLevel5;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label LabelLevel4;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label LabelLevel3;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label LabelLevel2;
        private FlowLayoutPanel flowLayoutPanel13;
        private Label LabelLevel1;
        private FlowLayoutPanel flowLayoutPanel14;
        private Label LabelLevel0;
        private FlowLayoutPanel flowLayoutPanel15;
        private Label BackgroundLabel;
        private Button ResultButton;
        private TableLayoutPanel tableLayoutPanel4;
        private Button DisplayColorMapButton;
    }
}

