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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.EpsilonLabel = new System.Windows.Forms.Label();
            this.ApplyValuesButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.betaTextBox = new System.Windows.Forms.TextBox();
            this.BetaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linePotentialTextBox = new System.Windows.Forms.TextBox();
            this.LinePotentialLabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Button();
            this.DrawArea = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Finished = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IterationsLabel = new System.Windows.Forms.Label();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.ApplicationMainWindowLayout.SuspendLayout();
            this.ApplicationToolBox.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.ApplicationMainWindowLayout.Controls.Add(this.Finished, 2, 1);
            this.ApplicationMainWindowLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
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
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.ApplicationToolBox.Controls.Add(this.ApplyValuesButton, 0, 2);
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.ApplicationToolBox.Controls.Add(this.label2, 0, 5);
            this.ApplicationToolBox.Controls.Add(this.flowLayoutPanel1, 0, 4);
            this.ApplicationToolBox.Controls.Add(this.Result, 0, 6);
            this.ApplicationToolBox.Location = new System.Drawing.Point(3, 3);
            this.ApplicationToolBox.Name = "ApplicationToolBox";
            this.ApplicationToolBox.RowCount = 8;
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
            this.ApplicationToolBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.ApplicationToolBox.Size = new System.Drawing.Size(174, 517);
            this.ApplicationToolBox.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel3.Controls.Add(this.epsilonTextBox);
            this.flowLayoutPanel3.Controls.Add(this.EpsilonLabel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(5, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(165, 31);
            this.flowLayoutPanel3.TabIndex = 7;
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.epsilonTextBox.Location = new System.Drawing.Point(82, 7);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(74, 20);
            this.epsilonTextBox.TabIndex = 3;
            // 
            // EpsilonLabel
            // 
            this.EpsilonLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EpsilonLabel.AutoSize = true;
            this.EpsilonLabel.Location = new System.Drawing.Point(35, 10);
            this.EpsilonLabel.Name = "EpsilonLabel";
            this.EpsilonLabel.Size = new System.Drawing.Size(41, 13);
            this.EpsilonLabel.TabIndex = 2;
            this.EpsilonLabel.Text = "Epsilon";
            // 
            // ApplyValuesButton
            // 
            this.ApplyValuesButton.Location = new System.Drawing.Point(5, 77);
            this.ApplyValuesButton.Name = "ApplyValuesButton";
            this.ApplyValuesButton.Size = new System.Drawing.Size(166, 27);
            this.ApplyValuesButton.TabIndex = 8;
            this.ApplyValuesButton.Text = "Apply Values";
            this.ApplyValuesButton.UseVisualStyleBackColor = true;
            this.ApplyValuesButton.Click += new System.EventHandler(this.ApplyValuesButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel2.Controls.Add(this.betaTextBox);
            this.flowLayoutPanel2.Controls.Add(this.BetaLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(5, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(165, 31);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // betaTextBox
            // 
            this.betaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.betaTextBox.Location = new System.Drawing.Point(82, 7);
            this.betaTextBox.Name = "betaTextBox";
            this.betaTextBox.Size = new System.Drawing.Size(74, 20);
            this.betaTextBox.TabIndex = 3;
            // 
            // BetaLabel
            // 
            this.BetaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BetaLabel.AutoSize = true;
            this.BetaLabel.Location = new System.Drawing.Point(47, 10);
            this.BetaLabel.Name = "BetaLabel";
            this.BetaLabel.Size = new System.Drawing.Size(29, 13);
            this.BetaLabel.TabIndex = 2;
            this.BetaLabel.Text = "Beta";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel1.Controls.Add(this.linePotentialTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LinePotentialLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(165, 33);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // linePotentialTextBox
            // 
            this.linePotentialTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linePotentialTextBox.Location = new System.Drawing.Point(82, 7);
            this.linePotentialTextBox.Name = "linePotentialTextBox";
            this.linePotentialTextBox.Size = new System.Drawing.Size(74, 20);
            this.linePotentialTextBox.TabIndex = 3;
            // 
            // LinePotentialLabel
            // 
            this.LinePotentialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LinePotentialLabel.AutoSize = true;
            this.LinePotentialLabel.Location = new System.Drawing.Point(5, 10);
            this.LinePotentialLabel.Name = "LinePotentialLabel";
            this.LinePotentialLabel.Size = new System.Drawing.Size(71, 13);
            this.LinePotentialLabel.TabIndex = 2;
            this.LinePotentialLabel.Text = "Line Potential";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(3, 204);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(168, 41);
            this.Result.TabIndex = 10;
            this.Result.Text = "Calculate Result";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
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
            this.ResetButton.Location = new System.Drawing.Point(183, 526);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(548, 34);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Clear";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Finished
            // 
            this.Finished.Location = new System.Drawing.Point(3, 526);
            this.Finished.Name = "Finished";
            this.Finished.Size = new System.Drawing.Size(174, 34);
            this.Finished.TabIndex = 11;
            this.Finished.Text = "Drawing Finished";
            this.Finished.UseVisualStyleBackColor = true;
            this.Finished.Click += new System.EventHandler(this.Finished_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.41667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.58333F));
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
            this.IterationsLabel.Location = new System.Drawing.Point(4, 10);
            this.IterationsLabel.Name = "IterationsLabel";
            this.IterationsLabel.Size = new System.Drawing.Size(50, 13);
            this.IterationsLabel.TabIndex = 0;
            this.IterationsLabel.Text = "Iterations";
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IterationsTextBox.Location = new System.Drawing.Point(60, 7);
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(81, 20);
            this.IterationsTextBox.TabIndex = 1;
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
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawArea)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private Button Result;
        private Button Finished;
        private TableLayoutPanel tableLayoutPanel1;
        private Label IterationsLabel;
        private TextBox IterationsTextBox;
    }
}

