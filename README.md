# Inventory API (ASP.NET Core 8 + SQL Server + EF Core)

Proyecto de sistema de inventario orientado a portafolio y entrevistas técnicas. Incluye:
- Productos, categorías, proveedores
- Movimientos de inventario (IN/OUT)
- Stock actual y alertas por mínimo
- Reportes por rango

## ✅ Estado del día 1
- MVP definido, ERD documentado y backlog inicial en GitHub Issues.
- Próximo paso (Día 2): crear solución .NET por capas y configurar EF Core.
## ✅ Estado del día 2
- Solución por capas creada en Visual Studio 2022 (Api, Domain, Application, Infrastructure).
- API corriendo con Swagger en `https://localhost:xxxx/swagger`.
- Endpoint `/health` disponible para pruebas rápidas.

## 🗺️ Alcance (MVP)
- Regla: no permitir salidas con stock negativo.
- SKU único por producto.
- Paginación y búsqueda en listados.

## 📐 ERD
Ver `docs/erd.md` (diagrama Mermaid).

## 🛣️ Roadmap
Ver `docs/roadmap.md`.

---
