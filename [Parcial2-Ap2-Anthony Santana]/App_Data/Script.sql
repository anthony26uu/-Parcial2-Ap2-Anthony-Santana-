
CREATE TABLE [dbo].[Presupuestos] (
    [PresupuestoId] INT          IDENTITY (1, 1) NOT NULL,
    [Fecha]         DATETIME     NULL,
    [Monto]         DECIMAL (18) NULL,
    [Descripcion]   VARCHAR (80) NULL,

    PRIMARY KEY CLUSTERED ([PresupuestoId] ASC)
);


CREATE TABLE [dbo].[PresupuestosDetalles] (
    [Id] INT          IDENTITY (1, 1) NOT NULL,
    [PresupuestoId] INT,   
    [Descripcion]   VARCHAR (80) NULL,    
	[Logrado]         DECIMAL (18) NULL,
    [Meta]            DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([PresupuestoId] ASC)
);
