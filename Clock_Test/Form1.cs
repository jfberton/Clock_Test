using Clock_Test.Data;
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
    public partial class Form1 : Form
    {
        /// <summary>
        /// al iniciar el programa obtiene las alarmas almacenadas
        /// </summary>
        private List<Alarma> alarmas_almacenadas;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mostrar_alarmas();
            timer1.Start();
        }
        /// <summary>
        /// Obtengo las alarmas almacenadas, cargo la variable de la clase y muestro en el datagridview segun formato seleccionado
        /// </summary>
        private void Mostrar_alarmas()
        {
            alarmas_almacenadas = Contexto.Instance.Obtener_alarmas();

            ds_alarmas ds_Alarmas = new ds_alarmas();
            ds_Alarmas.Alarmas.Clear();

            dgv_alarmas.Columns[2].Visible = !chk_24_hs.Checked;
            foreach (Alarma alarma in alarmas_almacenadas)
            {
                DataRow dr = ds_Alarmas.Alarmas.NewRow();

                string hora_alarma = alarma.Hora.Split(':')[0];
                string minuto_alarma = alarma.Hora.Split(':')[1];
                int hora = int.Parse(hora_alarma);

                //Las alarmas son guardadas siempre con formato 12 hs y las convierto a 24 segun el check
                if (chk_24_hs.Checked)
                {
                    if (alarma.AM_PM == "p. m." && hora < 12)
                    {
                        hora += 12;
                    }
                }

                dr["Id"] = alarma.Id;
                dr["Hora"] = hora.ToString("D2") + ":" + minuto_alarma;
                dr["AM_PM"] = alarma.AM_PM;
                dr["Descripcion"] = alarma.Descripcion;

                ds_Alarmas.Alarmas.Rows.Add(dr);

            }

            dgv_alarmas.DataSource = ds_Alarmas.Alarmas;
        }

        /// <summary>
        /// Muestra la hora segun el formato seleccionado y chequea si se cumplio alguna alarma
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            DateTime dt = DateTime.Now;
            if (chk_24_hs.Checked)
            {
                lbl_hora.Text = dt.ToString("HH:mm:ss");
                lbl_am_pm.Text = dt.ToString("tt");
            }
            else
            {
                lbl_hora.Text = dt.ToString("hh:mm:ss");
                lbl_am_pm.Text = dt.ToString("tt");
            }

            Chequear_Alarmas();

            timer1.Start();
        }

        /// <summary>
        /// Chequeo si se cumplio alguna alarma, en caso de que se haya cumplido, informo y la elimino de la lista de alarmas almacenadas
        /// </summary>
        private void Chequear_Alarmas()
        {
            string hora = DateTime.Now.ToString("hh:mm");
            string am_pm = DateTime.Now.ToString("tt");

            Alarma al = alarmas_almacenadas.FirstOrDefault(x => x.Hora == hora && x.AM_PM[0] == am_pm[0]);

            if (al != null)
            {
                Contexto.Instance.Eliminar_alarma(al.Id);
                if (al.Descripcion != string.Empty)
                {
                    MessageBox.Show("Descripcion: " + al.Descripcion, "Ha llegado la hora de la alarma.", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Ha llegado la hora de la alarma.", "Ha llegado la hora de la alarma.", MessageBoxButtons.OK);
                }

                Mostrar_alarmas();
            }
        }
        /// <summary>
        /// Llama al formulario para agregar alarma de manera modal
        /// </summary>
        private void btn_nueva_alarma_Click(object sender, EventArgs e)
        {
            Form2 f_alarma = new Form2();

            DialogResult respuesta = f_alarma.ShowDialog();
            switch (respuesta)
            {
                case DialogResult.OK:
                    //MessageBox.Show("Alarma agregada");
                    Mostrar_alarmas();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Error al agregar alarma");
                    break;
                case DialogResult.Cancel:
                    //MessageBox.Show("Se cancelo la operación");
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Llamo a mostrar alarmas para actualizar la forma en que se visualizan las alarmas almacenadas
        /// </summary>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Mostrar_alarmas();
        }

        /// <summary>
        /// Elimino la alarma seleccionada
        /// </summary>
        private void dgv_alarmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columa = e.ColumnIndex;
            if (columa == 4)
            {
                string hora = dgv_alarmas.Rows[e.RowIndex].Cells[1].Value.ToString();
                string descripcion = dgv_alarmas.Rows[e.RowIndex].Cells[3].Value.ToString();

                DialogResult confirmacion;

                if (descripcion == string.Empty)
                {
                    confirmacion = MessageBox.Show("Está seguro de eliminar la alarma " + hora + " ??", "Confirmar eliminación!!", MessageBoxButtons.YesNo);
                }
                else
                {
                    confirmacion = MessageBox.Show("Está seguro de eliminar la alarma " + hora + " \"" + descripcion + "\" ??", "Confirmar eliminación!!", MessageBoxButtons.YesNo);
                }

                if (confirmacion == DialogResult.Yes)
                {
                    Guid id = Guid.Parse(dgv_alarmas.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Contexto.Instance.Eliminar_alarma(id);
                    Mostrar_alarmas();
                }
            }
        }
    }
}
