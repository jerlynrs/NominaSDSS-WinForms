
# 🧾 ASIGNACIÓN 2 — Generación y Lectura de Archivos TSS  
**Desarrollo de Software con Tecnología Propietaria**  
**202610 — ISO810-1201**

## 👤 Sustentado por
**Jerlyn Rodríguez**  
**Matrícula:** A00113235

## 👨‍🏫 Facilitador
**Juan Valdez Reyes**

## 📅 Fecha
22/01/2026

---

# 📘 Descripción del Proyecto

Este proyecto implementa una aplicación **Windows Forms en C#** que permite **generar** y **leer** los archivos de texto requeridos por la **Tesorería de la Seguridad Social (TSS)** de la República Dominicana.

Los archivos generados son los utilizados para reportar información de nómina según el **Sistema Dominicano de Seguridad Social (SDSS)**:

- Autodeterminación Mensual (**AM**)
- Novedades (**NV**)

La aplicación lee estos archivos, los muestra en interfaz y puede importarlos hacia **SQL Server** para análisis y almacenamiento en tablas de staging.

---

# 🎯 Objetivo General

Desarrollar una solución tipo **push–pull**:

### ✔ Push  
Generar archivos AM y NV en formato de **longitud fija**, usando datos almacenados en SQL Server.

### ✔ Pull  
Leer archivos AM/NV recibidos, interpretarlos y almacenarlos en SQL Server para consulta y validación.

---

# 🏗 Tecnologías Utilizadas

- **C# / .NET Framework**
- **Windows Forms**
- **SQL Server**
