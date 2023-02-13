
SET IDENTITY_INSERT [dbo].[ChargeType] ON 

INSERT [dbo].[ChargeType] ([Id], [Name]) VALUES (1, 'Kg')
INSERT [dbo].[ChargeType] ([Id], [Name]) VALUES (2, 'Pcs')

SET IDENTITY_INSERT [dbo].[ChargeType] OFF 


SET IDENTITY_INSERT [dbo].[Charge] ON 
INSERT [dbo].[Charge] ([Id], [Name], [ChargeTypeId], [IsActive], [IsDeleted], [DateCreated], [CreatedBy], [LastUpdated], [UpdatedBy]) VALUES (1, 'Navlun', 2, 1, 0, GETDATE(),2003,GETDATE(),2003)
INSERT [dbo].[Charge] ([Id], [Name], [ChargeTypeId], [IsActive], [IsDeleted], [DateCreated], [CreatedBy], [LastUpdated], [UpdatedBy]) VALUES (2, 'Lokal Masraflar', 2, 1, 0, GETDATE(),2003,GETDATE(),2003)
INSERT [dbo].[Charge] ([Id], [Name], [ChargeTypeId], [IsActive], [IsDeleted], [DateCreated], [CreatedBy], [LastUpdated], [UpdatedBy]) VALUES (3, 'Masraflar', 2, 1, 0, GETDATE(),2003,GETDATE(),2003)
INSERT [dbo].[Charge] ([Id], [Name], [ChargeTypeId], [IsActive], [IsDeleted], [DateCreated], [CreatedBy], [LastUpdated], [UpdatedBy]) VALUES (4, 'Navlun Kg', 1, 1, 0, GETDATE(),2003,GETDATE(),2003)

SET IDENTITY_INSERT [dbo].[Charge] OFF 



SET IDENTITY_INSERT [dbo].[Currency] ON 

INSERT [dbo].[Currency] ([Id], [Name]) VALUES (1, N'USD')
INSERT [dbo].[Currency] ([Id], [Name]) VALUES (2, N'TRY')
INSERT [dbo].[Currency] ([Id], [Name]) VALUES (3, N'EUR')
INSERT [dbo].[Currency] ([Id], [Name]) VALUES (4, N'GBP')
SET IDENTITY_INSERT [dbo].[Currency] OFF

SET IDENTITY_INSERT [dbo].[ItemType] ON 

INSERT [dbo].[ItemType] ([Id], [Name]) VALUES (1, N'Cost')
INSERT [dbo].[ItemType] ([Id], [Name]) VALUES (2, N'Charge')

SET IDENTITY_INSERT [dbo].[ItemType] OFF


