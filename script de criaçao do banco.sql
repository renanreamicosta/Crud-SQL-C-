USE [CADASTRO]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[ID_Cli] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Logotipo] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOGRADOURO]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOGRADOURO](
	[COD_Log] [int] IDENTITY(1,1) NOT NULL,
	[COD_Cli] [int] NOT NULL,
	[Logradouro] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[COD_Log] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Login] [varchar](30) NOT NULL,
	[Senha] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LOGRADOURO]  WITH CHECK ADD  CONSTRAINT [FK_CLI_LOG] FOREIGN KEY([COD_Cli])
REFERENCES [dbo].[CLIENTE] ([ID_Cli])
GO
ALTER TABLE [dbo].[LOGRADOURO] CHECK CONSTRAINT [FK_CLI_LOG]
GO
/****** Object:  StoredProcedure [dbo].[AddCliente]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddCliente] @Nome varchar(100) , @Email varchar(100),@logotipo varbinary(max)
as
insert into CLIENTE (Nome,Email,Logotipo) values (@Nome,@Email,@logotipo)
GO
/****** Object:  StoredProcedure [dbo].[ADDLogradouro]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ADDLogradouro]  @COD_Cli int  , @Logradouro varchar(100)
as
insert into LOGRADOURO (COD_Cli,Logradouro) values (@COD_Cli,@Logradouro)
GO
/****** Object:  StoredProcedure [dbo].[addUsuarios]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addUsuarios]  @Login varchar(30) ,@Senha varchar(20)
as
insert into Usuarios (Login, Senha) values (@Login, @Senha)
GO
/****** Object:  StoredProcedure [dbo].[AlteraCliente]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlteraCliente] @Nome varchar(100) , @Email varchar(100),@logotipo varbinary(max),@ID_Cli int 
as
update CLIENTE set Nome = @Nome, Email = @Email , Logotipo = @logotipo where ID_Cli = @ID_Cli
GO
/****** Object:  StoredProcedure [dbo].[AlteraLogradouro]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AlteraLogradouro]   @Logradouro varchar(100), @COD_Log int
as
update LOGRADOURO set Logradouro = @Logradouro  where COD_Log = @COD_Log
GO
/****** Object:  StoredProcedure [dbo].[buscalogin]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[buscalogin]   @Login varchar(30),@Senha varchar(20)
as
select * from Usuarios where Login like @Login and Senha = @Senha
GO
/****** Object:  StoredProcedure [dbo].[Deletecliente]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Deletecliente]  @ID_Cli int 
as
delete from CLIENTE where ID_Cli = @ID_Cli
GO
/****** Object:  StoredProcedure [dbo].[deleteLogradouro]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteLogradouro]  @COD_Log int
as
delete from LOGRADOURO where COD_Log = @COD_Log
GO
/****** Object:  StoredProcedure [dbo].[ExcluirAllLogradouro]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExcluirAllLogradouro]  @COD_Cli int
as
delete from LOGRADOURO where COD_Cli = @COD_Cli;
GO
/****** Object:  StoredProcedure [dbo].[selec]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selec] @Nome varchar(100) , @Email varchar(100),@logotipo varbinary(max)
as
insert into CLIENTE (Nome,Email,Logotipo) values (@Nome,@Email,@logotipo)
GO
/****** Object:  StoredProcedure [dbo].[select_Cliente]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_Cliente] @Nome varchar(100)
as
select l.COD_Cli,c.Nome,c.Email,c.Logotipo,l.COD_Log,l.Logradouro from LOGRADOURO as l
 inner join CLIENTE as c 
 on c.ID_Cli = l.COD_Cli  where Nome like @Nome
GO
/****** Object:  StoredProcedure [dbo].[selectAllCliente]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectAllCliente]   
as
select * from CLIENTE
GO
/****** Object:  StoredProcedure [dbo].[selectclienteOne]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectclienteOne]  @ID_Cli int 
as
select * from CLIENTE where ID_Cli like @ID_Cli
GO
/****** Object:  StoredProcedure [dbo].[verificaEmail]    Script Date: 17/04/2020 23:36:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[verificaEmail]  @Email varchar(100)
as
select * from CLIENTE where Email like @Email
GO
