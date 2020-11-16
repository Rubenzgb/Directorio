# Directorio

<b>1.- Paquetes para instalar</b>

install-package Microsoft.EntityFrameworkCore.SqlServer<br />
install-package Microsoft.EntityFrameworkCore.Tools


<b>2.- Paquete para el swagger</b>

Install-Package Swashbuckle.AspNetCore -Version 5.5.0

<b>3-. Base de datos </b>

- Crear una base de datos
- Crear la tabla con el siguiente script


CREATE TABLE [dbo].[Contacto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido_Paterno] [nvarchar](50) NULL,
	[apellido_Materno] [nvarchar](50) NULL,
	[telefonoCelular] [nvarchar](50) NULL,
	[telefonoFijo] [nvarchar](50) NULL,
	[genero] [nvarchar](15) NULL,
 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO



<b>3.- Cambiar la cadena de conexion en el archivo appsettings.json</b>

  "ConnectionStrings": {
    "DefaultConnection": "Server=[servidor];Database=[database];User Id=[usuario];Password=[contraseña];"
  },



