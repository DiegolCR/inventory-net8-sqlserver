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
