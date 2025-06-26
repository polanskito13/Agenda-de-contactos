# 📘 Agenda de Contactos (.NET Console App)
Aplicación de consola en C# para gestionar una lista de contactos: puedes agregar, buscar, eliminar y listar, todo desde la terminal. La información se guarda automáticamente en un archivo `.json`.

---

## ▶ ¿Cómo ejecutar la app?

1. Asegúrate de tener [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado.
2. Abre la terminal y navega a la carpeta raíz del proyecto:

```bash
cd agenda-contactos
Ejecuta la aplicación:

bash
dotnet run --project AgendaContactos/AgendaContactos.csproj
💾 ¿Qué hace?
✅ Agrega contactos (nombre, email, teléfono)

🔎 Busca contactos por nombre, email o teléfono

🗑 Elimina contactos por nombre

📝 Guarda automáticamente en data/contactos.json en formato JSON

📁 Estructura
agenda-contactos/
├── AgendaContactos.sln
├── AgendaContactos/
│   ├── Program.cs
│   ├── Models/
│   │   └── Contacto.cs
│   ├── Services/
│   │   └── AgendaService.cs
│   ├── data/
│   │   └── contactos.json
│   └── AgendaContactos.csproj
└── .gitignore
🧠 ¿Ideas para futuras mejoras?
Validación de emails y teléfonos

Exportar a CSV

Interfaz gráfica en WinForms o WPF

⚖️ Licencia
MIT – Puedes usar, modificar y compartir este proyecto libremente.