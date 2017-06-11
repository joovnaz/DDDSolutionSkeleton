
-- Ids

DROP TABLE  [dbo].[Ids]

CREATE TABLE [dbo].[Ids]
(
	[EntityName] [nvarchar](100) NOT NULL,

	[NextHigh] [int] NOT NULL,

	CONSTRAINT [PK_Ids] PRIMARY KEY CLUSTERED 
					    ( 
							[EntityName] ASC 
						) 
						WITH 
						(
							PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON
						
						) ON [PRIMARY]

) ON [PRIMARY]

-- Insert Ids for Entities

INSERT [dbo].[Ids] ([EntityName], [NextHigh]) VALUES (N'Customer', 1)

-- Customer 

DROP TABLE [dbo].[Customer]

CREATE TABLE [dbo].[Customer]
(

	[CustomerID] [bigint] NOT NULL,

	[Name] [nvarchar](50) NOT NULL,

	CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
							( 
								[CustomerID] ASC 
							) 
							WITH 
							(
								PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON
							
							) ON [PRIMARY]

) ON [PRIMARY]

