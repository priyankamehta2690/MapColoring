namespace MapColoring
{
    partial class Form1
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
            this.lblNoOfStates = new System.Windows.Forms.Label();
            this.txtNoOfStates = new System.Windows.Forms.TextBox();
            this.lblStates = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.btnColorMap = new System.Windows.Forms.Button();
            this.btnAddNeighbor = new System.Windows.Forms.Button();
            this.tblLPNeighbor = new System.Windows.Forms.TableLayoutPanel();
            this.btnDone = new System.Windows.Forms.Button();
            this.lbNeighbor = new System.Windows.Forms.ListBox();
            this.lblNeighbor = new System.Windows.Forms.Label();
            this.rbForwardChecking = new System.Windows.Forms.RadioButton();
            this.rbMinConflict = new System.Windows.Forms.RadioButton();
            this.pnlMapColoring = new System.Windows.Forms.Panel();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tblLPNeighbor.SuspendLayout();
            this.pnlMapColoring.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoOfStates
            // 
            this.lblNoOfStates.AutoSize = true;
            this.lblNoOfStates.Location = new System.Drawing.Point(37, 61);
            this.lblNoOfStates.Name = "lblNoOfStates";
            this.lblNoOfStates.Size = new System.Drawing.Size(131, 13);
            this.lblNoOfStates.TabIndex = 0;
            this.lblNoOfStates.Text = "Enter the number of states";
            // 
            // txtNoOfStates
            // 
            this.txtNoOfStates.Location = new System.Drawing.Point(184, 54);
            this.txtNoOfStates.Name = "txtNoOfStates";
            this.txtNoOfStates.Size = new System.Drawing.Size(100, 20);
            this.txtNoOfStates.TabIndex = 1;
            // 
            // lblStates
            // 
            this.lblStates.AutoSize = true;
            this.lblStates.Location = new System.Drawing.Point(37, 93);
            this.lblStates.Name = "lblStates";
            this.lblStates.Size = new System.Drawing.Size(63, 13);
            this.lblStates.TabIndex = 3;
            this.lblStates.Text = "Enter states";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(184, 93);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(100, 20);
            this.txtStates.TabIndex = 4;
            // 
            // btnColorMap
            // 
            this.btnColorMap.Location = new System.Drawing.Point(309, 195);
            this.btnColorMap.Name = "btnColorMap";
            this.btnColorMap.Size = new System.Drawing.Size(93, 27);
            this.btnColorMap.TabIndex = 33;
            this.btnColorMap.Text = "Color Map";
            this.btnColorMap.UseVisualStyleBackColor = true;
            this.btnColorMap.Visible = false;
            this.btnColorMap.Click += new System.EventHandler(this.btnColorMap_Click);
            // 
            // btnAddNeighbor
            // 
            this.btnAddNeighbor.Location = new System.Drawing.Point(327, 67);
            this.btnAddNeighbor.Name = "btnAddNeighbor";
            this.btnAddNeighbor.Size = new System.Drawing.Size(93, 29);
            this.btnAddNeighbor.TabIndex = 34;
            this.btnAddNeighbor.Text = "Add Neighbor";
            this.btnAddNeighbor.UseVisualStyleBackColor = true;
            this.btnAddNeighbor.Click += new System.EventHandler(this.btnAddNeighbor_Click);
            // 
            // tblLPNeighbor
            // 
            this.tblLPNeighbor.ColumnCount = 3;
            this.tblLPNeighbor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPNeighbor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblLPNeighbor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLPNeighbor.Controls.Add(this.btnDone, 2, 0);
            this.tblLPNeighbor.Controls.Add(this.lbNeighbor, 1, 0);
            this.tblLPNeighbor.Controls.Add(this.lblNeighbor, 0, 0);
            this.tblLPNeighbor.Location = new System.Drawing.Point(464, 12);
            this.tblLPNeighbor.Name = "tblLPNeighbor";
            this.tblLPNeighbor.RowCount = 1;
            this.tblLPNeighbor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLPNeighbor.Size = new System.Drawing.Size(271, 120);
            this.tblLPNeighbor.TabIndex = 35;
            // 
            // btnDone
            // 
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.Location = new System.Drawing.Point(219, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(49, 114);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            // 
            // lbNeighbor
            // 
            this.lbNeighbor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNeighbor.FormattingEnabled = true;
            this.lbNeighbor.Location = new System.Drawing.Point(57, 3);
            this.lbNeighbor.Name = "lbNeighbor";
            this.lbNeighbor.Size = new System.Drawing.Size(156, 114);
            this.lbNeighbor.TabIndex = 1;
            this.lbNeighbor.Visible = false;
            // 
            // lblNeighbor
            // 
            this.lblNeighbor.AutoSize = true;
            this.lblNeighbor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNeighbor.Location = new System.Drawing.Point(3, 0);
            this.lblNeighbor.Name = "lblNeighbor";
            this.lblNeighbor.Size = new System.Drawing.Size(48, 120);
            this.lblNeighbor.TabIndex = 2;
            this.lblNeighbor.Text = "Select the neighbor for state 1";
            this.lblNeighbor.Visible = false;
            // 
            // rbForwardChecking
            // 
            this.rbForwardChecking.AutoSize = true;
            this.rbForwardChecking.Location = new System.Drawing.Point(111, 3);
            this.rbForwardChecking.Name = "rbForwardChecking";
            this.rbForwardChecking.Size = new System.Drawing.Size(111, 17);
            this.rbForwardChecking.TabIndex = 36;
            this.rbForwardChecking.TabStop = true;
            this.rbForwardChecking.Text = "Forward Checking";
            this.rbForwardChecking.UseVisualStyleBackColor = true;
            this.rbForwardChecking.Visible = false;
            // 
            // rbMinConflict
            // 
            this.rbMinConflict.AutoSize = true;
            this.rbMinConflict.Location = new System.Drawing.Point(13, 3);
            this.rbMinConflict.Name = "rbMinConflict";
            this.rbMinConflict.Size = new System.Drawing.Size(85, 17);
            this.rbMinConflict.TabIndex = 37;
            this.rbMinConflict.TabStop = true;
            this.rbMinConflict.Text = "Min-Conflicts";
            this.rbMinConflict.UseVisualStyleBackColor = true;
            this.rbMinConflict.Visible = false;
            // 
            // pnlMapColoring
            // 
            this.pnlMapColoring.Controls.Add(this.rbForwardChecking);
            this.pnlMapColoring.Controls.Add(this.rbMinConflict);
            this.pnlMapColoring.Location = new System.Drawing.Point(243, 164);
            this.pnlMapColoring.Name = "pnlMapColoring";
            this.pnlMapColoring.Size = new System.Drawing.Size(237, 25);
            this.pnlMapColoring.TabIndex = 38;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(194, 228);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(334, 267);
            this.rtbOutput.TabIndex = 39;
            this.rtbOutput.Text = "";
            this.rtbOutput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 507);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.pnlMapColoring);
            this.Controls.Add(this.tblLPNeighbor);
            this.Controls.Add(this.btnAddNeighbor);
            this.Controls.Add(this.btnColorMap);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.lblStates);
            this.Controls.Add(this.txtNoOfStates);
            this.Controls.Add(this.lblNoOfStates);
            this.Name = "Form1";
            this.Text = "Map Coloring";
            this.tblLPNeighbor.ResumeLayout(false);
            this.tblLPNeighbor.PerformLayout();
            this.pnlMapColoring.ResumeLayout(false);
            this.pnlMapColoring.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoOfStates;
        private System.Windows.Forms.TextBox txtNoOfStates;
        private System.Windows.Forms.Label lblStates;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.Button btnColorMap;
        private System.Windows.Forms.Button btnAddNeighbor;
        private System.Windows.Forms.TableLayoutPanel tblLPNeighbor;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.ListBox lbNeighbor;
        private System.Windows.Forms.Label lblNeighbor;
        private System.Windows.Forms.RadioButton rbForwardChecking;
        private System.Windows.Forms.RadioButton rbMinConflict;
        private System.Windows.Forms.Panel pnlMapColoring;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

