namespace Tvl.DebugCommandLine
{
    partial class CommandLineEditor
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lstLines = new System.Windows.Forms.ListView();
            this.colLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCounter = new System.Windows.Forms.Label();
            this.ctxGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(478, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstLines
            // 
            this.lstLines.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstLines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLine});
            this.lstLines.ContextMenuStrip = this.ctxGeneral;
            this.lstLines.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lstLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLines.FullRowSelect = true;
            this.lstLines.GridLines = true;
            this.lstLines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstLines.HideSelection = false;
            this.lstLines.LabelEdit = true;
            this.lstLines.Location = new System.Drawing.Point(12, 12);
            this.lstLines.MultiSelect = false;
            this.lstLines.Name = "lstLines";
            this.lstLines.ShowGroups = false;
            this.lstLines.Size = new System.Drawing.Size(541, 327);
            this.lstLines.TabIndex = 4;
            this.lstLines.UseCompatibleStateImageBehavior = false;
            this.lstLines.View = System.Windows.Forms.View.Details;
            this.lstLines.ItemActivate += new System.EventHandler(this.lstLines_ItemActivate);
            // 
            // ctxGeneral
            // 
            this.ctxGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ctxGeneral.Name = "ctxGeneral";
            this.ctxGeneral.Size = new System.Drawing.Size(124, 48);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(267, 359);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(36, 13);
            this.lblCounter.TabIndex = 6;
            this.lblCounter.Text = "0 / 15";
            this.lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandLineEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 389);
            this.ControlBox = false;
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lstLines);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "CommandLineEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Debug Command Line Editor";
            this.ResizeEnd += new System.EventHandler(this.CommandLineEditor_ResizeEnd);
            this.ctxGeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListView lstLines;
        private System.Windows.Forms.ColumnHeader colLine;
        private System.Windows.Forms.ContextMenuStrip ctxGeneral;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Label lblCounter;
    }
}