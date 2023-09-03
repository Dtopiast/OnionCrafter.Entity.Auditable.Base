# OnionCrafter.Entity.Auditable.Base

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.0-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Entity.Auditable.Base.svg)](https://www.nuget.org/packages/OnionCrafter.Entity.Auditable.Base/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Entity.Auditable.Base/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

La librería **OnionCrafter.Entity.Auditable.Base** es una herramienta que facilita la creación de entidades audibles en aplicaciones .NET. Esta librería proporciona una estructura sólida para integrar capacidades de auditoría de acceso, creación y modificación en tus proyectos de desarrollo.

## Características

- **Auditoría de acceso:** Registra información sobre el acceso a las entidades, incluidos detalles como la fecha y el usuario que accedió.
- **Auditoría de creación:** Permite el seguimiento de cuándo se crearon las entidades y quién fue el responsable de su creación.
- **Auditoría de modificación:** Registra cambios realizados en las entidades, incluyendo la fecha de modificación y el usuario que efectuó los cambios.
- **Personalizable:** Puedes adaptar la librería según las necesidades específicas de tu proyecto al implementar las interfaces proporcionadas.

## Requisitos

- .NET 7

## Instalación

Puedes agregar esta librería a tu proyecto .NET 7 a través de NuGet. Usa el siguiente comando de NuGet para instalarla:

```bash
dotnet add package OnionCrafter.Entity.Auditable.Base
```

## Uso

1. Agrega la librería OnionCrafter.Entity.Auditable.Base a tu proyecto.

2. Implementa las interfaces proporcionadas en tus clases de entidad para habilitar la auditoría.

3. Personaliza la auditoría de acuerdo a los requerimientos de tu aplicación.

**Ejemplo de uso:**

```csharp
// Implementación de una entidad auditable
public class MiEntidad : IAuditableEntity<int>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    // Implementa las propiedades de auditoría según tus necesidades
    public DateTime? CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public string? ModifiedBy { get; set; }
    // Implementa las demás propiedades y métodos de tu entidad
}

// Luego, puedes utilizar la entidad en tu aplicación y las capacidades de auditoría estarán habilitadas.
```

Para obtener ejemplos detallados sobre cómo utilizar esta librería, consulta la [documentación](https://github.com/Dtopiast/OnionCrafter.Entity.Auditable.Base/wiki).


## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/dtopiast/OnionCrafter.Entity.Auditable.Base/issues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/dtopiast/OnionCrafter.Entity.Auditable.Base/pulls).

## Licencia

Este proyecto está bajo la [Licencia Mozilla Public v. 2](LICENSE.txt). Consulta el archivo LICENSE.txt para obtener más información.
