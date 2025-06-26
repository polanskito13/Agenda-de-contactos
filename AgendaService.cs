using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AgendaContactos.Models;

namespace AgendaContactos.Services
{
    public class AgendaService
    {
        private readonly string _rutaArchivo = "data/contactos.json";
        public List<Contacto> Contactos { get; private set; }

        public AgendaService()
        {
            if (File.Exists(_rutaArchivo))
            {
                string json = File.ReadAllText(_rutaArchivo);
                Contactos = JsonSerializer.Deserialize<List<Contacto>>(json) ?? new List<Contacto>();
            }
            else
            {
                Contactos = new List<Contacto>();
            }
        }

        public void Guardar()
        {
            string json = JsonSerializer.Serialize(Contactos, new JsonSerializerOptions { WriteIndented = true });
            Directory.CreateDirectory("data");
            File.WriteAllText(_rutaArchivo, json);
        }

        public void Agregar(Contacto c)
        {
            Contactos.Add(c);
            Guardar();
        }

        public bool Eliminar(string nombre)
        {
            var encontrado = Contactos.Find(c => c.Nombre.ToLower() == nombre.ToLower());
            if (encontrado != null)
            {
                Contactos.Remove(encontrado);
                Guardar();
                return true;
            }
            return false;
        }

        public List<Contacto> Buscar(string texto)
        {
            return Contactos.FindAll(c =>
                c.Nombre.ToLower().Contains(texto.ToLower()) ||
                c.Email.ToLower().Contains(texto.ToLower()) ||
                c.Telefono.Contains(texto));
        }
    }
}
