# 📌 Proyecto Inventory .NET 8 + SQL Server
Checklist de avances diarios (plan 14 días)

---

## ✅ Día 1 - Setup del proyecto
- [x] Crear repositorio en GitHub: `inventory-net8-sqlserver`.
- [x] Agregar licencia MIT y README inicial.
- [x] Definir estructura de carpetas:
  - `/src` → código fuente.
  - `/docs` → documentación.
  - `.github` → workflows futuros.
- [x] Crear solución en Visual Studio 2022 (`Inventory.sln`).
- [x] Confirmar primer commit en GitHub.

**Entregable del Día 1:**
Repositorio con estructura base y solución vacía lista.

---

## ✅ Día 2 - API base con Swagger y Healthcheck
- [x] Crear proyecto `Inventory.Api` dentro de `/src`.
- [x] Configurar Web API en .NET 8 con:
  - Swagger (documentación automática).
  - Endpoint `/health` de prueba.
  - CORS habilitado (AllowAll).
- [x] Crear proyectos de capas:
  - `Inventory.Application`
  - `Inventory.Domain`
  - `Inventory.Infrastructure`
- [x] Configurar referencias entre proyectos (sin dependencias circulares).
- [x] Ejecutar API en Swagger → validación de `/health` funcionando.
- [x] Hacer commit con mensaje:  
  `feat(api): solución por capas creada; Swagger y /health funcionando`

**Entregable del Día 2:**
API funcionando con Swagger y endpoint de salud disponible.
