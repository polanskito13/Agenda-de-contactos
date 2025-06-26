using System;
using AgendaContactos.Models;
using AgendaContactos.Services;

namespace AgendaContactos
{
    class Program
    {
        static void Main()
        {
            var servicio = new AgendaService();
            string opcion;

            do
            {
                Console.WriteLine("\n📘 AGENDA DE CONTACTOS");
                Console.WriteLine("1. Listar");
                Console.WriteLine("2. Agregar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n📜 Contactos:");
                        servicio.Contactos.ForEach(c => Console.WriteLine(c));
                        break;

                    case "2":
                        Console.Write("\nNombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Teléfono: ");
                        string telefono = Console.ReadLine();

                        var nuevo = new Contacto { Nombre = nombre, Email = email, Telefono = telefono };
                        servicio.Agregar(nuevo);
                        Console.WriteLine("✅ Contacto agregado.");
                        break;

                    case "3":
                        Console.Write("\n🔎 Buscar por nombre/email/teléfono: ");
                        string texto = Console.ReadLine();
                        var resultados = servicio.Buscar(texto);
                        if (resultados.Count == 0)
                            Console.WriteLine("❌ No se encontraron coincidencias.");
                        else
                            resultados.ForEach(c => Console.WriteLine(c));
                        break;

                    case "4":
                        Console.Write("\n🗑 Nombre exacto del contacto a eliminar: ");
                        string borrar = Console.ReadLine();
                        if (servicio.Eliminar(borrar))
                            Console.WriteLine("🗑 Contacto eliminado.");
                        else
                            Console.WriteLine("⚠️ Contacto no encontrado.");
                        break;

                    case "0":
                        Console.WriteLine("\n👋 ¡Hasta pronto!");
                        break;

                    default:
                        Console.WriteLine("❌ Opción inválida.");
                        break;
                }

            } while (opcion != "0");
        }
    }
}
