using Clock_Test.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Test.Services
{
    /// <summary>
    /// Implemento esta clase para simular una base de datos.
    /// </summary>
    internal class Contexto
    {
        #region Metodos privados

        /// <summary>
        /// Instancia de la clase Context para implementar el patrón Singleton.
        /// </summary>
        private static Contexto instance;

        /// <summary>
        /// Constructor privado para implementar el patrón Singleton.
        /// </summary>
        private Contexto()
        {
            Cargar_alarmas_almacenadas();
        }

        /// <summary>
        /// Ubicación del archivo json donde se almacenan las alarmas.
        /// </summary>
        private static string path = Path.Combine(AppContext.BaseDirectory, "alarmas.json");

        /// <summary>
        /// Listado de alarmas.
        /// </summary>
        private static List<Alarma> alarmas;

        /// <summary>
        /// Guarda las alarmas en el archivo con formato JSON.
        /// </summary>
        private void Guardar_alarmas()
        {
            if (alarmas.Count == 0)
            {
                File.Delete(path);
                return;
            }
            else
            {
                string json = JsonConvert.SerializeObject(alarmas);

                File.WriteAllText(path, json);
            }
        }

        /// <summary>
        /// Obtiene las alarmas almacenadas en el archivo con formato JSON.
        /// </summary>
        /// <returns></returns>
        private void Cargar_alarmas_almacenadas()
        {
            alarmas = new List<Alarma>();

            if (!File.Exists(path))
            {
                alarmas = new List<Alarma>();
            }
            else
            {
                string json = File.ReadAllText(path);
                if (json != null && json.Length > 0)
                {
                    alarmas = JsonConvert.DeserializeObject<List<Alarma>>(json);
                }
            }
        }

        #endregion

        #region Métodos publicos

        /// <summary>
        /// Obtiene la instancia de la clase Context para administrar las alarmas.
        /// </summary>
        public static Contexto Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Contexto();
                }

                return instance;
            }
        }

        /// <summary>
        /// Agrega una alarma al listado de alarmas y guarda el listado en el archivo con formato JSON.
        /// </summary>
        public bool Agregar_alarma(Alarma alarma)
        {
            try
            {
                alarmas.Add(alarma);
                Guardar_alarmas();
                Cargar_alarmas_almacenadas();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Permite la eliminación de una alarma del listado de alarmas y guarda el listado en el archivo con formato JSON.
        /// </summary>
        /// <param name="id">GUID almacenado correspondiente a la alarma a eliminar.</param>
        /// <returns></returns>
        public bool Eliminar_alarma(Guid id)
        {
            try
            {
                alarmas.Remove(alarmas.Where(x => x.Id == id).FirstOrDefault());
                Guardar_alarmas();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene el listado de alarmas.
        /// </summary>
        /// <returns></returns>
        public List<Alarma> Obtener_alarmas()
        {
            return alarmas;
        }

        #endregion
    }
}
