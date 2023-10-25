using Clock_Test.Models;
using Clock_Test.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_Test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cargar_comboboxes();
        }

        private bool formato_24_horas;
        /// <summary>
        /// Muestro los controles y muestro u oculto el combobox de am o pm segun corresponda
        /// </summary>
        public bool Formato_24_horas
        {
            get { return formato_24_horas; }
            set
            {
                formato_24_horas = value;
                cb_am_pm.Visible = !value;
                if (value)
                {
                    panel2.Size = new Size(Width = panel2.Width - cb_am_pm.Width, Height = panel2.Height);
                    panel2.Location = new Point(panel2.Location.X + cb_am_pm.Width, panel2.Location.Y);
                    //this.Size = new Size(Width = 600, Height = 303);

                }
                else
                {
                    panel2.Size = new System.Drawing.Size(424, 60);
                    panel2.Location = new System.Drawing.Point(59, 41);
                }

                Cargar_comboboxes();
            }
        }

        /// <summary>
        /// Cargo los valores de los comboboxes de acuerdo al formato seleccionado
        /// </summary>
        private void Cargar_comboboxes()
        {
            cb_hora.Items.Clear();
            cb_minutos.Items.Clear();

            if (Formato_24_horas)
            {
                for (int j = 0; j <= 23; j++)
                {
                    cb_hora.Items.Add(j.ToString("D2"));
                }
            }
            else
            {
                for (int j = 0; j <= 12; j++)
                {
                    cb_hora.Items.Add(j.ToString("D2"));
                }
            }

            for (int j = 0; j <= 59; j++)
            {
                cb_minutos.Items.Add(j.ToString("D2"));
            }

            cb_am_pm.Items.Clear();
            cb_am_pm.Items.Add("a. m.");
            cb_am_pm.SelectedIndex = 0;

            cb_hora.SelectedIndex = 0;
            cb_minutos.SelectedIndex = 0;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Siempre guardo la alarma con formato de 12 horas y agrego el am o pm segun corresponda
        /// </summary>
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string hora = "";
            int hora_int = 0;
            if (int.TryParse(cb_hora.SelectedItem.ToString(), out hora_int) == false)
            {
                MessageBox.Show("Error al convertir la hora a entero");
                return;
            }

            string am_pm = "a. m.";

            string minutos = cb_minutos.SelectedItem.ToString();

            if (Formato_24_horas)
            {
                if (hora_int > 11)
                {
                    if (hora_int != 12)
                    {
                        hora_int -= 12;
                    }
                    am_pm = "p. m.";
                }
                else
                {
                    am_pm = "a. m.";
                }
            }
            else
            {
                am_pm = cb_am_pm.SelectedItem.ToString();
            }

            hora = hora_int.ToString("D2") + ":" + minutos;

            string descripcion = tb_descripcion.Text;

            bool ok = Contexto.Instance.Agregar_alarma(new Alarma()
            {
                Id = Guid.NewGuid(),
                Hora = hora,
                Descripcion = descripcion,
                AM_PM = am_pm,
            });

            if (ok)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }
        }

        /// <summary>
        /// Dependiendo de la hora seleccionada, muestro el combobox de am o pm
        /// </summary>
        private void cb_hora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!formato_24_horas)
            if (cb_hora.SelectedIndex == 0)
            {
                cb_am_pm.Items.Clear();
                cb_am_pm.Items.Add("a. m.");
                cb_am_pm.SelectedIndex = 0;
            }
            else
            {
                if (cb_hora.SelectedIndex == 12)
                {
                    cb_am_pm.Items.Clear();
                    cb_am_pm.Items.Add("p. m.");
                    cb_am_pm.SelectedIndex = 0;
                }
                else
                {
                    cb_am_pm.Items.Clear();
                    cb_am_pm.Items.Add("a. m.");
                    cb_am_pm.Items.Add("p. m.");
                    cb_am_pm.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Actualiza los controles de acuerdo al formato seleccionado y los valores de los comboboxes
        /// </summary>
        private void chk_24_hs_CheckedChanged(object sender, EventArgs e)
        {
            Formato_24_horas = chk_24_hs.Checked;
        }

       
    }
}
