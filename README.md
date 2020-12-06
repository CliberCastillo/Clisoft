# API REST en .NET Core
Esta desarrollado en .NET Core 3.1 y Entity Framework Core con la arquitectura DDD, donde aplico conceptos de buenas practicas y algunos patrones de diseño.

La arquitectura es similar como se ve en la siguiente imagen.

![alt text](https://1.bp.blogspot.com/-f9QYYWLc1Uk/UoKzpDHYkkI/AAAAAAAACA4/OD1bq9MLYFY/s1600/DDD_png_pure.png)

### Conceptos, Tecnologias, Herramientas Aplicados en el proyecto:

* Clean Code
* Patron de diseño Repository
* Inyeccion de dependencias
* Swagger
* JWT
* AutoMapper

### Pasos a seguir para ejecutar el proyecto

una vez clonado el proyecto en Visual Studio lo que aremos sera ir al menu de > herramientas > Administrador de paquetes NuGet > Consola de administrador de paquetes y escribir el siguiente comando. (recuerda cambiar la cadena de conexion en appsettings.json)

```
Add-Migration FirstMigration
```
seguidamente
```
Update-Database
```
lo que hicimos fue crear una base de datos a partir del codigo c# utilizando Entity Framework Core. (Code First), si todo fue correcto procede a ejecutar la solucion.
