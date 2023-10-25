using System.Drawing;
using System.Windows.Forms;

namespace Clock_Test
{
    partial class Form2
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
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_24_hs = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_minutos = new System.Windows.Forms.ComboBox();
            this.lbl_separador = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_hora = new System.Windows.Forms.ComboBox();
            this.cb_am_pm = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aceptar.Location = new System.Drawing.Point(376, 217);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(94, 26);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(476, 217);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 26);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_descripcion.Location = new System.Drawing.Point(26, 165);
            this.tb_descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(549, 22);
            this.tb_descripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_24_hs);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_descripcion);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 253);
            this.panel1.TabIndex = 8;
            // 
            // chk_24_hs
            // 
            this.chk_24_hs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chk_24_hs.AutoSize = true;
            this.chk_24_hs.Location = new System.Drawing.Point(241, 16);
            this.chk_24_hs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_24_hs.Name = "chk_24_hs";
            this.chk_24_hs.Size = new System.Drawing.Size(63, 20);
            this.chk_24_hs.TabIndex = 9;
            this.chk_24_hs.Text = "24 hs.";
            this.chk_24_hs.UseVisualStyleBackColor = true;
            this.chk_24_hs.CheckedChanged += new System.EventHandler(this.chk_24_hs_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_minutos);
            this.panel2.Controls.Add(this.lbl_separador);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cb_hora);
            this.panel2.Controls.Add(this.cb_am_pm);
            this.panel2.Location = new System.Drawing.Point(66, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 60);
            this.panel2.TabIndex = 8;
            // 
            // cb_minutos
            // 
            this.cb_minutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_minutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_minutos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_minutos.FormattingEnabled = true;
            this.cb_minutos.IntegralHeight = false;
            this.cb_minutos.Location = new System.Drawing.Point(179, 22);
            this.cb_minutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_minutos.Name = "cb_minutos";
            this.cb_minutos.Size = new System.Drawing.Size(142, 36);
            this.cb_minutos.TabIndex = 10;
            // 
            // lbl_separador
            // 
            this.lbl_separador.AutoSize = true;
            this.lbl_separador.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_separador.Location = new System.Drawing.Point(157, 25);
            this.lbl_separador.Name = "lbl_separador";
            this.lbl_separador.Size = new System.Drawing.Size(16, 28);
            this.lbl_separador.TabIndex = 8;
            this.lbl_separador.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Minuto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hora";
            // 
            // cb_hora
            // 
            this.cb_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_hora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_hora.FormattingEnabled = true;
            this.cb_hora.IntegralHeight = false;
            this.cb_hora.ItemHeight = 28;
            this.cb_hora.Location = new System.Drawing.Point(5, 22);
            this.cb_hora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_hora.Name = "cb_hora";
            this.cb_hora.Size = new System.Drawing.Size(146, 36);
            this.cb_hora.TabIndex = 11;
            this.cb_hora.SelectedIndexChanged += new System.EventHandler(this.cb_hora_SelectedIndexChanged);
            // 
            // cb_am_pm
            // 
            this.cb_am_pm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_am_pm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_am_pm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_am_pm.FormattingEnabled = true;
            this.cb_am_pm.Location = new System.Drawing.Point(327, 22);
            this.cb_am_pm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_am_pm.Name = "cb_am_pm";
            this.cb_am_pm.Size = new System.Drawing.Size(90, 36);
            this.cb_am_pm.TabIndex = 9;
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(582, 253);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(600, 300);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form2";
            this.Text = "Nueva alarma";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_aceptar;
        private Button btn_cancelar;
        private TextBox tb_descripcion;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cb_minutos;
        private Label lbl_separador;
        private Label label5;
        private Label label4;
        private ComboBox cb_hora;
        private ComboBox cb_am_pm;
        private CheckBox chk_24_hs;
    }
}