USE [Inventario]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[codCliente] [int] NOT NULL,
	[nCliente] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_clientes] PRIMARY KEY CLUSTERED 
(
	[codCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[codDepartamentos] [int] NOT NULL,
	[desdep] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_departamentos] PRIMARY KEY CLUSTERED 
(
	[codDepartamentos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles](
	[numfac] [int] NOT NULL,
	[codpro] [int] NOT NULL,
	[canven] [float] NOT NULL,
	[preven] [float] NOT NULL,
 CONSTRAINT [PK_detalles] PRIMARY KEY CLUSTERED 
(
	[numfac] ASC,
	[codpro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[numfac] [int] NOT NULL,
	[fecfac] [datetime] NOT NULL,
	[codcli] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_facturas] PRIMARY KEY CLUSTERED 
(
	[numfac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[entidad] [varchar](50) NULL,
	[descripcion] [varchar](500) NOT NULL,
	[fecha] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginRegistro]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginRegistro](
	[codUsuario] [int] NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[Result] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[codProducto] [int] NOT NULL,
	[nProducto] [varchar](200) NOT NULL,
	[Preventa] [float] NOT NULL,
	[Precompra] [float] NOT NULL,
	[ExiProducto] [float] NOT NULL,
	[Punreo] [float] NOT NULL,
	[Status] [bit] NOT NULL,
	[codDepartamento] [int] NOT NULL,
 CONSTRAINT [PK_productos] PRIMARY KEY CLUSTERED 
(
	[codProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suplidor]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suplidor](
	[codSuplidor] [int] NOT NULL,
	[nSuplidor] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Status] [bit] NOT NULL,
	[Direccion] [varchar](100) NULL,
 CONSTRAINT [PK_suplidor] PRIMARY KEY CLUSTERED 
(
	[codSuplidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unidades]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidades](
	[coduni] [int] IDENTITY(1,1) NOT NULL,
	[desuni] [varchar](100) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_unidades] PRIMARY KEY CLUSTERED 
(
	[coduni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[codUsuario] [int] NOT NULL,
	[nUsuario] [varchar](200) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[Estado] [bit] NOT NULL,
	[Nivel] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[codUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_facturas_clientes] FOREIGN KEY([codcli])
REFERENCES [dbo].[Clientes] ([codCliente])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_facturas_clientes]
GO
/****** Object:  StoredProcedure [dbo].[Actualizadetalles]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Actualizadetalles]
    @numfac	int, @codpro int, @canven float, @preven float
as
set nocount on

Begin try 
insert into Detalles(numfac, codpro, canven, preven) values (@numfac, @codpro, @canven, @preven)
End try 
Begin catch       End catch 

update Productos set ExiProducto=ExiProducto-@canven where codProducto=@codpro

select @numfac as numfac
GO
/****** Object:  StoredProcedure [dbo].[ActualizaFactura]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ActualizaFactura]
	@numfac	int, @fecfac datetime, @codcli int, @status	bit
as
set nocount on

if @numfac =0
begin
	select @numfac =max(numfac) from facturas
	if @numfac is null set @numfac=0

	set @numfac=@numfac+1
end

if not exists(select numfac from facturas where numfac=@numfac)
begin
	insert into facturas (numfac, fecfac, codcli, status) values (@numfac, @fecfac, @codcli, 0)
end
else
	update facturas set fecfac=@fecfac,status=@status where numfac=@numfac

select @numfac as numfac
GO
/****** Object:  StoredProcedure [dbo].[clientesActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[clientesActualiza]
	@codCliente int	,@nCliente varchar(100)	,@Email varchar(100), @Direccion varchar(200), @Status bit
as
set nocount on

-- Genermos un nuevo codigo
if @codCliente =0
begin
	select @codCliente =max(codCliente) from Clientes -- mayor
	if @codCliente is null set @codCliente=0

	set @codCliente=@codCliente+1
end

if not exists(select codCliente from Clientes where codCliente=@codCliente)
	insert into Clientes(codCliente,nCliente,Email,Direccion,Status) values (@codCliente,@nCliente,@Email,@Direccion,@Status)
else
	update Clientes set nCliente=@nCliente,Email=@Email,Direccion=@Direccion,status=@Status where codCliente=@codCliente

select	codCliente,nCliente,Email,Direccion,Status 
from	Clientes
where	codCliente=@codCliente
GO
/****** Object:  StoredProcedure [dbo].[DatosFactura]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DatosFactura]
	@numfac int
as
set nocount on

if(@numfac = 0)
SELECT	Facturas.numfac, Facturas.fecfac, Facturas.codcli, Facturas.status, 
		Clientes.nCliente, Clientes.email, Clientes.codCliente,
		Detalles.canven, Detalles.preven, 
		Productos.codProducto, Productos.nProducto
FROM    Facturas INNER JOIN Detalles ON Facturas.numfac = Detalles.numfac 
		INNER JOIN Clientes ON Facturas.codcli = Clientes.codCliente
		INNER JOIN Productos ON Detalles.codpro = Productos.codProducto
else
SELECT	Facturas.numfac, Facturas.fecfac, Facturas.codcli, Facturas.status, 
		Clientes.nCliente, Clientes.email, Clientes.codCliente,
		Detalles.canven, Detalles.preven, 
		Productos.codProducto, Productos.nProducto
FROM    Facturas INNER JOIN Detalles ON Facturas.numfac = Detalles.numfac 
		INNER JOIN Clientes ON Facturas.codcli = Clientes.codCliente
		INNER JOIN Productos ON Detalles.codpro = Productos.codProducto
where Facturas.numfac=@numfac
GO
/****** Object:  StoredProcedure [dbo].[departamentosActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[departamentosActualiza]
	@codDepartamentos int	,@desdep varchar(100)	,@status bit
as
set nocount on

-- Genermos un nuevo codigo
if @codDepartamentos =0
begin
	select @codDepartamentos =max(codDepartamentos) from departamentos -- mayor
	if @codDepartamentos is null set @codDepartamentos=0

	set @codDepartamentos=@codDepartamentos+1
end

if not exists(select codDepartamentos from departamentos where codDepartamentos=@codDepartamentos)
	insert into departamentos (codDepartamentos,desdep,status) values (@codDepartamentos,@desdep,@status)
else
	update departamentos set desdep=@desdep,status =@status where codDepartamentos=@codDepartamentos

select	codDepartamentos,desdep,status 
from	departamentos 
where	codDepartamentos=@codDepartamentos
GO
/****** Object:  StoredProcedure [dbo].[eliminaCliente]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[eliminaCliente]
	@codCliente int
AS 
SET NOCOUNT ON

DELETE FROM Clientes WHERE codCliente = @codCliente
GO
/****** Object:  StoredProcedure [dbo].[eliminaDepartamento]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[eliminaDepartamento]
	@codDepartamentos int

AS
SET NOCOUNT ON 

DELETE FROM Departamentos WHERE codDepartamentos = @codDepartamentos
GO
/****** Object:  StoredProcedure [dbo].[eliminaProducto]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[eliminaProducto]
	@codProducto int

AS 
SET NOCOUNT ON

DELETE FROM Productos WHERE codProducto = @codProducto

GO
/****** Object:  StoredProcedure [dbo].[eliminaUnidades]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[eliminaUnidades]
	@coduni int 

AS
SET NOCOUNT ON

DELETE FROM Unidades WHERE coduni = @coduni
GO
/****** Object:  StoredProcedure [dbo].[LoginUsuario]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     Procedure [dbo].[LoginUsuario]
    @codUsuario int, @Password nvarchar(200), @Result bit Output
As
    Declare @PassEncode As nvarchar(50)
    Declare @PassDecode As nvarchar(50)
Begin
    Select @PassEncode=Password From Usuarios Where codUsuario = @codUsuario
    Set @PassDecode = DECRYPTBYPASSPHRASE('password', @PassEncode)
End
 
Begin
    If @PassDecode = @Password
        Set @Result = 1
    Else
        Set @Result = 0
End

Select Result=@Result, Password=@PassDecode

/*if not exists(select codUsuario from LoginRegistro where codUsuario=@codUsuario)
	Insert into LoginRegistro (codUsuario, Password, Result) values (@codUsuario, @PassDecode, @Result);
else
	update LoginRegistro set Password=@PassDecode,Result=@Result where codUsuario=@codUsuario*/
GO
/****** Object:  StoredProcedure [dbo].[NumeroFactura]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NumeroFactura]
	@numfac int 
as
set nocount on

if @numfac =0
begin
	select @numfac =max(numfac) from facturas
	if @numfac is null set @numfac=0

	set @numfac=@numfac+1
end

select @numfac as numfac

GO
/****** Object:  StoredProcedure [dbo].[pa_libros_autor]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec pa_libros_autor '1'
CREATE procedure [dbo].[pa_libros_autor]
  @codcli int 
 as
  select *
   from clientes
   where codcli=@codcli
GO
/****** Object:  StoredProcedure [dbo].[procedimiento_declaracion_c]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[procedimiento_declaracion_c]
	@sp varchar(500)='cp_re'
as
set nocount on

set @sp=ltrim(rtrim(@sp))
if @sp='' set @sp='cp_re'
Declare @name varchar(100),@longitud float,@decimales float,@tipo varchar(100),@tipop varchar(100)


/*
Select	'set '+rtrim(p.name)+'='+nchar(39)+nchar(39),p.max_length as longitud,p.precision as decimales,t.name as tipo
from	sys.parameters p inner join sys.types t on p.system_type_id= t.system_type_id
where	p.object_id=object_id('Hs_Agrega_factura') and t.name !='sysname'
order by p.parameter_id
*/
Declare cursor_datos cursor for
Select	p.name,p.max_length as longitud,p.precision as decimales,t.name as tipo
from	sys.parameters p inner join sys.types t on p.system_type_id= t.system_type_id
where	p.object_id=object_id(@sp) and t.name !='sysname'
order by p.parameter_id

Declare	@declara varchar(4000),@valor varchar(50),@declarecchar varchar(50),@cantidadparametros int,@parametros varchar(4000)
Declare @listavalor varchar(4000)
set @listavalor=''

set @declara=''
open cursor_datos
fetch next from cursor_datos into @name ,@longitud ,@decimales ,@tipo 
set @cantidadparametros=-1
set @tipop=''
set @parametros=''
while @@FETCH_STATUS=0
BEGIN
	set @name=LOWER( LTRIM(rtrim(@name)))
	set @name=UPPER(SUBSTRING(@name,2,1))+LOWER(SUBSTRING(@name,3,LEN(@name)-1))
	
	set @cantidadparametros=@cantidadparametros+1
	if @parametros!=''
		set @parametros=@parametros+','
	
	if @listavalor !='' set @listavalor=@listavalor+','
	set @listavalor=@listavalor+@name
	
	set @parametros=@parametros+nchar(39)+'{'+LTRIM(rtrim(cast(@cantidadparametros as varchar(10))))+'}'+NCHAR(39)
	set @valor='=""'
	set @declarecchar='string '
	if @tipo='bit' 
	begin
		set @valor='=0'
		set @declarecchar='Int16 '
	end
	if @tipo in ('float') 
	begin
		set @valor='=0'
		set @declarecchar='double '
	end

	if @tipo in ('int') 
	begin
		set @valor='=0'
		set @declarecchar='Int32 '
	end

	if @tipo in ('datetime') 
	begin
		set @valor='=""'
		set @declarecchar='string '
	end
	
	if @name='Numemp' or @name='Pnumemp'
		set @valor='= FuncionesGenerales.numemp'
	else
	if @name='Codempuse'
		set @valor='= FuncionesGenerales.codempuse'

	if @name='Numsuc'
		set @valor='= FuncionesGenerales.NumSucursal'
	
	
	if @name='Idioma'
		set @valor='= FuncionesGenerales.objUsuarioActual.Idiomauser'
	
	

	if LEN(ltrim(rtrim(@declara)))<7
		set @declara=left(@declara+space(10),7)

	/*if LEN(ltrim(rtrim(@name)))<20
		set @name=left(@name+space(30),20)*/
	set @name=NCHAR(9)+@name
	if @tipop='' set @tipop=@tipo
	if @declara !='' set @declara=@declara+','
	
	
	set @declara=@declara+REPLACE(@name,'@','')+NCHAR(9)+NCHAR(9)+@valor
	print @declarecchar+' '+@name+NCHAR(9)+NCHAR(9)+@valor+';'
	
  	fetch next from cursor_datos into @name ,@longitud ,@decimales ,@tipo 
  	if @@FETCH_STATUS!=0 or @tipo!=@tipop
  	begin
  		set @declara= @declarecchar+@declara+';'
  		--print @declara
  		
  		
  		
  		set @declara=''
  		
  	end
  	set @tipop=@tipo
end
CLOSE cursor_datos
DEALLOCATE cursor_datos
print '// parametros'

declare @cmd varchar(4000)
set @cmd='string cmd =string.Format('+nchar(34)+'exec '+@sp+' '+@parametros+NCHAR(34)+','+NCHAR(10)+NCHAR(13)
set @cmd=@cmd+@listavalor+');'
--string cmd = string.Format("exec sb_cuentas '{0}','{1}'", DataAccessBase.numemp, DataAccessBase.codempuse);
print @cmd
print ''
print 'DataSet ds1 = FuncionesGenerales.Ejecuta(cmd);'
print 'if (FuncionesGenerales.dsTieneDatos(ds1) == false)'
print '{'
print '		mensaje.Show(11);'
print '		return;'
print ' }'


GO
/****** Object:  StoredProcedure [dbo].[productoActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[productoActualiza] 
	@codProducto int, @nProducto varchar(200), @Preventa float, @Precompra float, @ExiProducto float, @Punreo float, @Status bit, @codDepartamento int

AS
SET NOCOUNT ON

-- Genermos un nuevo codigo
if @codProducto =0
begin
	select @codProducto =max(codProducto) from Productos -- mayor
	if @codProducto is null set @codProducto=0

	set @codProducto=@codProducto+1
end

if not exists(select codProducto from Productos where codProducto=@codProducto)
	insert into Productos (codProducto,nProducto,Preventa,Precompra,ExiProducto,Punreo,Status,codDepartamento) values (@codProducto,@nProducto,@Preventa,@Precompra,@ExiProducto,@Punreo,@Status,@codDepartamento)
else
	update Productos set nProducto=@nProducto,Preventa=@Preventa,Precompra=@Precompra,ExiProducto=@ExiProducto,Punreo=@Punreo,Status=@Status,codDepartamento=@codDepartamento where codProducto=@codProducto

select	codProducto,nProducto,Preventa,Precompra,ExiProducto,Punreo,Status,codDepartamento
from	Productos 
where	codProducto=@codProducto
GO
/****** Object:  StoredProcedure [dbo].[suplidorActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[suplidorActualiza]
	@codSuplidor int ,@nSuplidor varchar(100) , @Email varchar(100), @Status bit, @Direccion varchar(100)
as
set nocount on

-- Genermos un nuevo codigo
if @codSuplidor =0
begin
	select @codSuplidor =max(codSuplidor) from Suplidor -- mayor
	if @codSuplidor is null set @codSuplidor=0

	set @codSuplidor=@codSuplidor+1
end

if not exists(select codSuplidor from Suplidor where codSuplidor=@codSuplidor)
	insert into Suplidor (codSuplidor,nSuplidor,Email,Status,Direccion) values (@codSuplidor ,@nSuplidor , @Email , @Status , @Direccion )
else
	update Suplidor set nSuplidor=@nSuplidor, Email=@Email, Status=@Status, Direccion=@Direccion where codSuplidor=@codSuplidor

select	codSuplidor,nSuplidor,Email,Status,Direccion
from	Suplidor 
where	codSuplidor=@codSuplidor
GO
/****** Object:  StoredProcedure [dbo].[unidadesActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   procedure [dbo].[unidadesActualiza]
	@coduni int ,@desuni varchar(200) , @status bit

AS
SET NOCOUNT ON

if @coduni =0
begin
	select @coduni =max(coduni) from Unidades -- mayor
	if @coduni is null set @coduni=0

	set @coduni=@coduni+1
end

if not exists(select coduni from Unidades where coduni=@coduni)
	insert into Unidades (coduni,desuni,status) values (@coduni ,@desuni ,@status)
else
	update Unidades set desuni=@desuni, status=@status where coduni=@coduni

select	coduni,desuni,status
from	Unidades 
where	coduni=@coduni
GO
/****** Object:  StoredProcedure [dbo].[usuarioActualiza]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   procedure [dbo].[usuarioActualiza] 
	@codUsuario int, @nUsuario varchar(200), @Password nvarchar(200), @Estado bit, @Nivel int

AS
SET NOCOUNT ON

-- Genermos un nuevo codigo
if @codUsuario =0
begin
	select @codUsuario =max(codUsuario) from Usuarios -- mayor
	if @codUsuario is null set @codUsuario=0

	set @codUsuario=@codUsuario+1
end

if not exists(select codUsuario from Usuarios where codUsuario=@codUsuario)
	insert into Usuarios (codUsuario,nUsuario,Password,Estado,Nivel) values (@codUsuario,@nUsuario,ENCRYPTBYPASSPHRASE('password', @Password),@Estado,@Nivel)
else
	update Usuarios set nUsuario=@nUsuario,Password=ENCRYPTBYPASSPHRASE('password', @Password),Estado=@Estado,Nivel=@Nivel where codUsuario=@codUsuario

select	codUsuario,nUsuario,Password,Estado,Nivel
from	Usuarios 
where	codUsuario=@codUsuario
GO
/****** Object:  StoredProcedure [dbo].[ventasentrefecha]    Script Date: 14/12/2020 12:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec ventasentrefecha '','',0
--exec ventasentrefecha '20200201','20201001',0
CREATE procedure [dbo].[ventasentrefecha]
	@fecini datetime	= '',
	@fechfin datetime	= '',
	@codcli int			= 0
as
set nocount on

SELECT	Facturas.numfac, Facturas.fecfac, Facturas.codcli, Facturas.status, 
		Clientes.nCliente, Clientes.Email, 
		sum(Detalles.canven* Detalles.preven) as total

FROM    Facturas INNER JOIN Detalles ON Facturas.numfac = Detalles.numfac 
		INNER JOIN Clientes ON Facturas.codcli = Clientes.codCliente
	
where  (@fecini='' or Facturas.fecfac>=@fecini )
		and (@fechfin='' or Facturas.fecfac<=@fechfin )
		and (@codcli=0 or Facturas.codcli=@codcli)
group by Facturas.numfac, Facturas.fecfac, Facturas.codcli, Facturas.status, 
		Clientes.nCliente, Clientes.Email
GO
