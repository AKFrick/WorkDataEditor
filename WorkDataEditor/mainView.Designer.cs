namespace WorkDataEditor
{
    partial class mainView
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.uploadPlc = new System.Windows.Forms.Button();
            this.downloadPlc = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.returnStroke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forgeThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forgeSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swageOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traverseStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedRotateStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varRotateStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travRotStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotTravStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsClampForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.buttonPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.saveFile);
            this.buttonPanel.Controls.Add(this.openFile);
            this.buttonPanel.Controls.Add(this.uploadPlc);
            this.buttonPanel.Controls.Add(this.downloadPlc);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(755, 44);
            this.buttonPanel.TabIndex = 1;
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(3, 3);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(63, 38);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Save";
            this.saveFile.UseVisualStyleBackColor = true;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(72, 3);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(63, 38);
            this.openFile.TabIndex = 3;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            // 
            // uploadPlc
            // 
            this.uploadPlc.Location = new System.Drawing.Point(141, 3);
            this.uploadPlc.Name = "uploadPlc";
            this.uploadPlc.Size = new System.Drawing.Size(63, 38);
            this.uploadPlc.TabIndex = 1;
            this.uploadPlc.Text = "Upload";
            this.uploadPlc.UseVisualStyleBackColor = true;
            // 
            // downloadPlc
            // 
            this.downloadPlc.Location = new System.Drawing.Point(210, 3);
            this.downloadPlc.Name = "downloadPlc";
            this.downloadPlc.Size = new System.Drawing.Size(63, 38);
            this.downloadPlc.TabIndex = 0;
            this.downloadPlc.Text = "Download";
            this.downloadPlc.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.returnStroke,
            this.forgeThickness,
            this.dwell,
            this.returnSpeed,
            this.forgeSpeed,
            this.swageOffset,
            this.toolLocation,
            this.traverseStep,
            this.fixedRotateStep,
            this.varRotateStep,
            this.travRotStep,
            this.rotTravStep,
            this.tongsClampForce});
            this.grid.Location = new System.Drawing.Point(3, 53);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(755, 245);
            this.grid.TabIndex = 2;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
            // 
            // returnStroke
            // 
            this.returnStroke.DataPropertyName = "returnStroke";
            this.returnStroke.HeaderText = "Return Stroke";
            this.returnStroke.Name = "returnStroke";
            this.returnStroke.ReadOnly = true;
            this.returnStroke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // forgeThickness
            // 
            this.forgeThickness.DataPropertyName = "forgeThickness";
            this.forgeThickness.HeaderText = "Forge Thickness";
            this.forgeThickness.Name = "forgeThickness";
            this.forgeThickness.ReadOnly = true;
            this.forgeThickness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dwell
            // 
            this.dwell.DataPropertyName = "dwell";
            this.dwell.HeaderText = "Dwell";
            this.dwell.Name = "dwell";
            this.dwell.ReadOnly = true;
            this.dwell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // returnSpeed
            // 
            this.returnSpeed.DataPropertyName = "returnSpeed";
            this.returnSpeed.HeaderText = "Return Speed";
            this.returnSpeed.Name = "returnSpeed";
            this.returnSpeed.ReadOnly = true;
            this.returnSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // forgeSpeed
            // 
            this.forgeSpeed.DataPropertyName = "forgeSpeed";
            this.forgeSpeed.HeaderText = "Forge Speed";
            this.forgeSpeed.Name = "forgeSpeed";
            this.forgeSpeed.ReadOnly = true;
            this.forgeSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // swageOffset
            // 
            this.swageOffset.DataPropertyName = "swageOffset";
            this.swageOffset.HeaderText = "Swage Offset";
            this.swageOffset.Name = "swageOffset";
            this.swageOffset.ReadOnly = true;
            this.swageOffset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // toolLocation
            // 
            this.toolLocation.DataPropertyName = "toolLocation";
            this.toolLocation.HeaderText = "Tool Location";
            this.toolLocation.Name = "toolLocation";
            this.toolLocation.ReadOnly = true;
            this.toolLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // traverseStep
            // 
            this.traverseStep.DataPropertyName = "traverseStep";
            this.traverseStep.HeaderText = "Traverse Step";
            this.traverseStep.Name = "traverseStep";
            this.traverseStep.ReadOnly = true;
            this.traverseStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fixedRotateStep
            // 
            this.fixedRotateStep.DataPropertyName = "fixedRotateStep";
            this.fixedRotateStep.HeaderText = "Fixed Rotate Step";
            this.fixedRotateStep.Name = "fixedRotateStep";
            this.fixedRotateStep.ReadOnly = true;
            this.fixedRotateStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // varRotateStep
            // 
            this.varRotateStep.DataPropertyName = "varRotateStep";
            this.varRotateStep.HeaderText = "Var Rotate Step";
            this.varRotateStep.Name = "varRotateStep";
            this.varRotateStep.ReadOnly = true;
            this.varRotateStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // travRotStep
            // 
            this.travRotStep.DataPropertyName = "travRotStep";
            this.travRotStep.HeaderText = "Trav/Rot Step";
            this.travRotStep.Name = "travRotStep";
            this.travRotStep.ReadOnly = true;
            this.travRotStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // rotTravStep
            // 
            this.rotTravStep.DataPropertyName = "rotTravStep";
            this.rotTravStep.HeaderText = "Rot/Trav Step";
            this.rotTravStep.Name = "rotTravStep";
            this.rotTravStep.ReadOnly = true;
            this.rotTravStep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tongsClampForce
            // 
            this.tongsClampForce.DataPropertyName = "tongsClampForce";
            this.tongsClampForce.HeaderText = "Tongs Clamp Force";
            this.tongsClampForce.Name = "tongsClampForce";
            this.tongsClampForce.ReadOnly = true;
            this.tongsClampForce.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "mainView";
            this.Size = new System.Drawing.Size(761, 301);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel buttonPanel;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button uploadPlc;
        private System.Windows.Forms.Button downloadPlc;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnStroke;
        private System.Windows.Forms.DataGridViewTextBoxColumn forgeThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn dwell;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn forgeSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn swageOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn traverseStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedRotateStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn varRotateStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn travRotStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotTravStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsClampForce;
    }
}
