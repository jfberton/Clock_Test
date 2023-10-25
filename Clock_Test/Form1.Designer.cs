using Clock_Test.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clock_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alarmasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_am_pm = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_alarmas = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_nueva_alarma = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chk_24_hs = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_column = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.alarmasBindingSource)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alarmas)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alarmasBindingSource
            // 
            this.alarmasBindingSource.DataMember = "Alarmas";
            this.alarmasBindingSource.DataSource = typeof(Clock_Test.Data.ds_alarmas);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel1);
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(491, 400);
            this.panel8.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lbl_am_pm);
            this.panel7.Controls.Add(this.lbl_hora);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(491, 129);
            this.panel7.TabIndex = 4;
            // 
            // lbl_am_pm
            // 
            this.lbl_am_pm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_am_pm.AutoSize = true;
            this.lbl_am_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_am_pm.Location = new System.Drawing.Point(376, 75);
            this.lbl_am_pm.Name = "lbl_am_pm";
            this.lbl_am_pm.Size = new System.Drawing.Size(54, 25);
            this.lbl_am_pm.TabIndex = 5;
            this.lbl_am_pm.Text = "a. m.";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hora.Font = new System.Drawing.Font("Segoe UI", 47F);
            this.lbl_hora.Location = new System.Drawing.Point(35, 5);
            this.lbl_hora.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(361, 116);
            this.lbl_hora.TabIndex = 4;
            this.lbl_hora.Text = "00:00:00";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 271);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_alarmas);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 235);
            this.panel3.TabIndex = 1;
            // 
            // dgv_alarmas
            // 
            this.dgv_alarmas.AllowUserToAddRows = false;
            this.dgv_alarmas.AllowUserToDeleteRows = false;
            this.dgv_alarmas.AutoGenerateColumns = false;
            this.dgv_alarmas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_alarmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alarmas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.delete_column});
            this.dgv_alarmas.DataSource = this.alarmasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alarmas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alarmas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_alarmas.Location = new System.Drawing.Point(0, 0);
            this.dgv_alarmas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_alarmas.Name = "dgv_alarmas";
            this.dgv_alarmas.ReadOnly = true;
            this.dgv_alarmas.RowHeadersVisible = false;
            this.dgv_alarmas.RowHeadersWidth = 51;
            this.dgv_alarmas.RowTemplate.Height = 29;
            this.dgv_alarmas.Size = new System.Drawing.Size(491, 191);
            this.dgv_alarmas.TabIndex = 1;
            this.dgv_alarmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_alarmas_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_nueva_alarma);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 191);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 44);
            this.panel4.TabIndex = 0;
            // 
            // btn_nueva_alarma
            // 
            this.btn_nueva_alarma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nueva_alarma.Location = new System.Drawing.Point(329, 11);
            this.btn_nueva_alarma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nueva_alarma.Name = "btn_nueva_alarma";
            this.btn_nueva_alarma.Size = new System.Drawing.Size(150, 23);
            this.btn_nueva_alarma.TabIndex = 1;
            this.btn_nueva_alarma.Text = "Nueva alarma";
            this.btn_nueva_alarma.UseVisualStyleBackColor = true;
            this.btn_nueva_alarma.Click += new System.EventHandler(this.btn_nueva_alarma_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 36);
            this.panel2.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chk_24_hs);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(287, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 36);
            this.panel6.TabIndex = 1;
            // 
            // chk_24_hs
            // 
            this.chk_24_hs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_24_hs.AutoSize = true;
            this.chk_24_hs.Location = new System.Drawing.Point(129, 9);
            this.chk_24_hs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_24_hs.Name = "chk_24_hs";
            this.chk_24_hs.Size = new System.Drawing.Size(63, 20);
            this.chk_24_hs.TabIndex = 0;
            this.chk_24_hs.Text = "24 hs.";
            this.chk_24_hs.UseVisualStyleBackColor = true;
            this.chk_24_hs.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 36);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alarmas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AM_PM";
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 23;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.ToolTipText = "Descripcion";
            // 
            // delete_column
            // 
            this.delete_column.HeaderText = "";
            this.delete_column.MinimumWidth = 6;
            this.delete_column.Name = "delete_column";
            this.delete_column.ReadOnly = true;
            this.delete_column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete_column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete_column.Text = "Eliminar";
            this.delete_column.ToolTipText = "Elimina alarma";
            this.delete_column.UseColumnTextForLinkValue = true;
            this.delete_column.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 400);
            this.Controls.Add(this.panel8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Mis alarmas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alarmasBindingSource)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alarmas)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aMPMDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn repiteDataGridViewTextBoxColumn;
        private BindingSource alarmasBindingSource;
        private Panel panel8;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dgv_alarmas;
        private Panel panel4;
        private Button btn_nueva_alarma;
        private Panel panel2;
        private Panel panel6;
        private CheckBox chk_24_hs;
        private Panel panel5;
        private Label label1;
        private Panel panel7;
        private Label lbl_am_pm;
        private Label lbl_hora;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewLinkColumn delete_column;
    }
}

