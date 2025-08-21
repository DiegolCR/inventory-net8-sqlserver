# ERD - Inventory API

```mermaid
erDiagram
    Categoria ||--o{ Producto : "tiene"
    Proveedor ||--o{ InventarioMovimiento : "participa"
    Producto ||--o{ InventarioMovimiento : "registra"

    Categoria {
        int Id PK
        string Nombre
    }
    Producto {
        int Id PK
        string Nombre
        string Sku
        int CategoriaId FK
        int StockMinimo
        datetime CreadoEn
    }
    Proveedor {
        int Id PK
        string Nombre
        string Email
        string Telefono
    }
    InventarioMovimiento {
        int Id PK
        int ProductoId FK
        string Tipo  // IN | OUT
        int Cantidad
        datetime Fecha
        string Comentario
        int ProveedorId FK nullable
    }

> Tip: en GitHub se renderiza automáticamente al ver el archivo.

---

## 5) Crea el roadmap (2 min)
Archivo `docs/roadmap.md`:

```markdown
# Roadmap

## Semana 1
- Día 1: Alcance, ERD, backlog, repo (✅)
- Día 2: Solución .NET por capas y Swagger
- Día 3: Dominio y DbContext (EF Core)
- Día 4: SQL Server (Docker) y migraciones

## Semana 2
- Día 5: Seed + DTOs + Application
- Día 6: CRUD Productos (paginación/filtros)
- Día 7: CRUD Categorías y Proveedores
- Día 8: Movimientos IN/OUT con reglas
- Día 9: Reportes
- Día 10: JWT y roles
- Día 11: Errores, logging y validaciones
- Día 12: Pruebas
- Día 13: Docker y CI
- Día 14: Pulido, screenshots y release
