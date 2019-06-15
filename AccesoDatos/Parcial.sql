
use master
go
-- drop database MAGOS_DB
create database MAGOS_DB
go
use MAGOS_DB
go

USE [MAGOS_DB]
GO

/****** Object:  Table [dbo].[CASAS]    Script Date: 14/6/2019 17:09:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CASAS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_CASAS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [MAGOS_DB]
GO

/****** Object:  Table [dbo].[HECHIZOS]    Script Date: 14/6/2019 17:10:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HECHIZOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[IdHechizoQueLoVence] [int] NULL,
 CONSTRAINT [PK_HECHIZOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [MAGOS_DB]
GO

/****** Object:  Table [dbo].[MAGOS]    Script Date: 14/6/2019 17:10:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MAGOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[IdCasa] [int] NULL,
 CONSTRAINT [PK_MAGOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [MAGOS_DB]
GO

/****** Object:  Table [dbo].[HECHIZOSMAGOS]    Script Date: 14/6/2019 17:10:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HECHIZOSMAGOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMago] [int] NULL,
	[IdHechizo] [int] NULL,
 CONSTRAINT [PK_HECHIZOSMAGOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [MAGOS_DB]
GO

/****** Object:  Table [dbo].[USUARIOS]    Script Date: 14/6/2019 17:10:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USUARIOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NULL,
	[Clave] [varchar](50) NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



insert into CASAS values ('Gryffindor')
insert into CASAS values ('Hufflepuff')
insert into CASAS values ('Ravenclaw')
insert into CASAS values ('Slytherin')

insert into magos values ('Severus Snape', 4)
insert into magos values ('Harry Potter', 1)
insert into magos values ('Hermione Granger', 1)
insert into magos values ('Luna Lovegood', 3)
insert into magos values ('Cedric Diggory', 2)
insert into magos values ('Albus Dumbledore', 1)

 insert into HECHIZOS values ('Expecto Patronum', 'Para zafar de los dementores!', 7)
 insert into HECHIZOS values ('Accio', 'Este encantamiento permite atraer un objeto', 4)
 insert into HECHIZOS values ('Wingardium Leviosa', 'Para elevar cosas...', 9)
 insert into HECHIZOS values ('Expelliarmus', 'Desarmar al rival', 8)
 insert into HECHIZOS values ('Lumos', '', 10)
 insert into HECHIZOS values ('Alohomora', 'permite abrir y desbloquear cerraduras.', 10)
 insert into HECHIZOS values ('Avada Kedavra', '', 4)
 insert into HECHIZOS values ('Sectumsempra', '', 3)
 insert into HECHIZOS values ('Aguamenti', 'Genera un chorro de agua', 3)
 insert into HECHIZOS values ('Alarte ascendare', 'Eleva a su objetivo por los aires', 4)

insert into HECHIZOSMAGOS values (1, 8)
insert into HECHIZOSMAGOS values (2, 1)
insert into HECHIZOSMAGOS values (3, 6)
insert into HECHIZOSMAGOS values (4, 10)
insert into HECHIZOSMAGOS values (5, 9)
insert into HECHIZOSMAGOS values (6, 7)

insert into USUARIOS values ('admin','admin')
