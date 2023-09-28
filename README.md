# IntuitChallenge
### Backend
* Crear una API para mantener una tabla de clientes (ABM de Clientes)

### Frontend
* Desarrollar un frontend sencillo para operar
ese ABM de clientes

> Nota: Opte por el frontend para utilizar el ABM de clientes, ya que la api de https://www.metaweather.com/ esta dada de baja.

![metaweather_off](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/242b0d81-0189-4ebf-8196-ec2097b1f30e)



# Proyecto de CRUD de Clientes

Este proyecto consiste en un CRUD (Crear, Leer, Actualizar, Eliminar) para la entidad "Cliente". El frontend está desarrollado utilizando Blazor WebAssembly, mientras que el backend se basa en una API construida en .NET 7.

## Solución

![solucion](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/a492c859-e08d-48cf-a82d-3dc413996541)


## Especificaciones de la API

La API está estructurada en tres capas:

### 1. Intuit.Challenge.Core

En esta capa, se definen los modelos de datos que se utilizan en la aplicación y modelo DB.

### 2. Intuit.Challenge.DataAccess

La capa DataAccess utiliza los modelos definidos en la capa Core y contiene las migraciones de Entity Framework Core, así como el contexto de la base de datos. 
Contiene la configuracion de la entidad para su mapeo en BD

### 3. IntuitChallenge.WebAPI (Proyecto de inicio)

La capa WebAPI es la parte principal de la aplicación. Aquí se encuentran los controllers de la API, donde estan los endpoints que permiten realizar operaciones CRUD en la entidad Cliente. Algunas características clave de esta capa incluyen:

- Documentación básica con Swagger UI para facilitar la exploración de la API.
- Autenticación mediante API Key para garantizar la seguridad de la API.
- Registro de errores en archivos de texto (.txt) para el seguimiento de problemas.

## Blazor Web Assembly

El frontend de la aplicación se desarrolla utilizando Blazor WebAssembly, que consume la API para realizar operaciones CRUD en los clientes. Además, se han implementado notificaciones visuales utilizando SweetAlert2 para proporcionar una experiencia de usuario más agradable.
El proyecto esta en la carpetata /ClientApp/Intuit.Challenge.Web

## Ejecución local de los proyectos

Para probar el proyecto localmente, sigue estos pasos:

1. Configurar base de datos localmente:
   * Modificar la cadena de conexión en el archivo `appsettings.json` del proyecto **IntuitChallenge.WebAPI** para apuntar a tu instancia local de SQL Server o LocalDB.

Ej. en mi caso tengo una instancia de sqllocaldb

```json
  "ConnectionStrings": {
    "IntuitChallenge": "Data Source=(localdb)\\localdb;Initial Catalog=IntuitAppDb; Integrated Security=True;"
  },
```

2. En la consola de NuGet, ejecuta el comando `update-database` específicando el proyecto DataAccess para crear la base de datos y aplicar las migraciones.
   * Consola NuGet (Visual Studio): Tools > Nuget Package manager > Package Manage console
   * Ejecutar siguiente comando
     ```shell
     Update-Database -Project Intuit.Challenge.DataAccess
     ```

3. Configurar múltiples proyectos de inicio seleccionando tanto la Web API como la aplicación Blazor.
* Click derecho en Solución (.sln) > Propiedades > Seleccionar Multiple Startup 
* Seleccionar los proyectos a ejecutar **IntuitChallenge.WebAPI** y **Intuit.Challenge.Web**

![mulstartup](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/a5bb0f7b-43f0-4e37-a0be-0d74233b5551)
  

4. Utiliza Swagger, Postman o los archivos `.http` en la carpeta `Example/Request` del proyecto de API para interactuar y probar la API de manera local.

* Si desea utilizar Postman, Insomnia o Swagger, al crear la request deberá agregar el header **x-api-key** con la clave de API que está en `appsettings.json`. Si no es proporcionada recibirá un `401 - Unauthorized`.

* Puede utilizar los `.http` archivos que dejé en el proyecto de API para probar directamente desde Visual Studio

![httpfile](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/86b9c84d-9c56-403f-9691-9efcae877e8b)


> Nota: Validar en que puerto se levanta la API,  modificar el mismo en la URL en la App Blazor, específicamente el archivo **Intuit.Challenge.Web\Utilities\AppConstants.cs** 

![appport](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/f863a89a-d9dd-4a26-b9a5-426677db6905)


5. El proyecto Blazor utiliza todas las operaciones CRUD

![blazorapp](https://github.com/LeonelQuiroga14/IntuitChallenge/assets/59056460/025937be-a416-401b-be78-e4a848babe8b)


* Index Clientes: Utiliza `GET` para obtener todos los clientes
* Nuevo Cliente: Utiliza `POST` para crear un nuevo cliente
* Editar: Utiliza `GET` para obtener el cliente seleccionado y `PUT` para actualizar el cliente
* Buscar clientes: Utiliza `GET` para buscar/filtrar clientes por nombre.
* Borrar: Utiliza `DELETE` para eliminar el cliente seleccionado. (Borrado físico)


Con estos pasos, deberías poder ejecutar y probar el proyecto de CRUD de Clientes en tu entorno local.
