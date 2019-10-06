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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFile = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.uploadPlc = new System.Windows.Forms.Button();
            this.downloadPlc = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.returnStroke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forgeThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dwell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forgeSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.swageOffset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traverseStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixedRotateStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableRotateStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travrotStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotTravStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongsClampForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.variableRotateStep,
            this.travrotStep,
            this.rotTravStep,
            this.tongsClampForce});
            this.grid.Location = new System.Drawing.Point(3, 53);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(755, 245);
            this.grid.TabIndex = 2;
            // 
            // returnStroke
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.returnStroke.DefaultCellStyle = dataGridViewCellStyle1;
            this.returnStroke.HeaderText = "Return stroke";
            this.returnStroke.Name = "returnStroke";
            this.returnStroke.ReadOnly = true;
            this.returnStroke.Width = 60;
            // 
            // forgeThickness
            // 
            this.forgeThickness.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.forgeThickness.DefaultCellStyle = dataGridViewCellStyle2;
            this.forgeThickness.HeaderText = "Forge thickness";
            this.forgeThickness.Name = "forgeThickness";
            this.forgeThickness.ReadOnly = true;
            this.forgeThickness.Width = 98;
            // 
            // dwell
            // 
            this.dwell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dwell.HeaderText = "Dwell";
            this.dwell.Name = "dwell";
            this.dwell.ReadOnly = true;
            this.dwell.Width = 58;
            // 
            // returnSpeed
            // 
            this.returnSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.returnSpeed.HeaderText = "Return speed";
            this.returnSpeed.Name = "returnSpeed";
            this.returnSpeed.ReadOnly = true;
            this.returnSpeed.Width = 88;
            // 
            // forgeSpeed
            // 
            this.forgeSpeed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.forgeSpeed.HeaderText = "Forge speed";
            this.forgeSpeed.Name = "forgeSpeed";
            this.forgeSpeed.ReadOnly = true;
            this.forgeSpeed.Width = 84;
            // 
            // swageOffset
            // 
            this.swageOffset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.swageOffset.HeaderText = "Swage offset";
            this.swageOffset.Name = "swageOffset";
            this.swageOffset.ReadOnly = true;
            this.swageOffset.Width = 87;
            // 
            // toolLocation
            // 
            this.toolLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.toolLocation.HeaderText = "Tool location";
            this.toolLocation.Name = "toolLocation";
            this.toolLocation.ReadOnly = true;
            this.toolLocation.Width = 86;
            // 
            // traverseStep
            // 
            this.traverseStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.traverseStep.HeaderText = "Traverse step";
            this.traverseStep.Name = "traverseStep";
            this.traverseStep.ReadOnly = true;
            this.traverseStep.Width = 89;
            // 
            // fixedRotateStep
            // 
            this.fixedRotateStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fixedRotateStep.HeaderText = "Fixed rotate step";
            this.fixedRotateStep.Name = "fixedRotateStep";
            this.fixedRotateStep.ReadOnly = true;
            this.fixedRotateStep.Width = 83;
            // 
            // variableRotateStep
            // 
            this.variableRotateStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.variableRotateStep.HeaderText = "Var rotate step";
            this.variableRotateStep.Name = "variableRotateStep";
            this.variableRotateStep.ReadOnly = true;
            this.variableRotateStep.Width = 93;
            // 
            // travrotStep
            // 
            this.travrotStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.travrotStep.HeaderText = "Trav/rot step";
            this.travrotStep.Name = "travrotStep";
            this.travrotStep.ReadOnly = true;
            this.travrotStep.Width = 87;
            // 
            // rotTravStep
            // 
            this.rotTravStep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.rotTravStep.HeaderText = "Rot/trav step";
            this.rotTravStep.Name = "rotTravStep";
            this.rotTravStep.ReadOnly = true;
            this.rotTravStep.Width = 87;
            // 
            // tongsClampForce
            // 
            this.tongsClampForce.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tongsClampForce.HeaderText = "Tongs clamp force";
            this.tongsClampForce.Name = "tongsClampForce";
            this.tongsClampForce.ReadOnly = true;
            this.tongsClampForce.Width = 88;
            // 
            // openDialog
            // 
            this.openDialog.FileName = "openFileDialog1";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn returnStroke;
        private System.Windows.Forms.DataGridViewTextBoxColumn forgeThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn dwell;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn forgeSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn swageOffset;
        private System.Windows.Forms.DataGridViewTextBoxColumn toolLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn traverseStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn fixedRotateStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn variableRotateStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn travrotStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotTravStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongsClampForce;
        private System.Windows.Forms.OpenFileDialog openDialog;
    }
}
