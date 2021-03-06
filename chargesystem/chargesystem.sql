SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_chargeWay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_chargeWay](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[unit_price] [float] NULL,
 CONSTRAINT [PK_T_CHARGEWAY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_function]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_function](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[function_name] [varchar](50) NULL,
 CONSTRAINT [PK_T_FUNCTION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_group](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [varchar](50) NULL,
 CONSTRAINT [PK_T_GROUP] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_group_function]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_group_function](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[group_id] [int] NULL,
	[function_id] [int] NULL,
 CONSTRAINT [PK_T_GROUP_FUNCTION] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_invoice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_invoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [varchar](50) NULL,
	[enterprise_name] [varchar](50) NULL,
	[amount] [float] NULL,
	[add_date] [datetime] NULL,
	[batchInvoice_id] [int] NULL,
	[status] [int] NULL,
	[project1] [varchar](50) NULL,
	[project2] [varchar](50) NULL,
	[project3] [varchar](50) NULL,
	[amount1] [float] NULL,
	[amount2] [float] NULL,
	[amount3] [float] NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_T_INVOICE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_meter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_meter](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[address] [varchar](50) NULL,
	[meter_num] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[state] [varchar](50) NULL,
 CONSTRAINT [PK_T_METER] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_meterInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_meterInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[meter_num] [varchar](50) NULL,
	[type] [varchar](50) NULL,
	[heat] [varchar](50) NULL,
	[flow] [varchar](50) NULL,
	[flash_flow] [varchar](50) NULL,
	[out_temp] [varchar](50) NULL,
	[in_temp] [varchar](50) NULL,
	[record_time] [varchar](50) NULL,
 CONSTRAINT [PK_T_METERINFO] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_returnedFee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_returnedFee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[building] [varchar](50) NULL,
	[unit] [varchar](50) NULL,
	[room_num] [varchar](50) NULL,
	[amount] [float] NULL,
	[add_date] [datetime] NULL,
	[reason] [text] NULL,
	[area] [varchar](50) NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_T_RETURNEDFEE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_returnedInvoice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_returnedInvoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[invoice_id] [int] NULL,
	[reason] [text] NULL,
	[user_id] [int] NULL,
 CONSTRAINT [PK_T_RETURNEDINVOICE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_room]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_room](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[owner] [varchar](50) NULL,
	[square] [float] NULL,
	[telephone] [varchar](50) NULL,
	[mobile1] [varchar](50) NULL,
	[mobile2] [varchar](50) NULL,
	[identification] [varchar](50) NULL,
	[unit_id] [int] NULL,
	[meter_id] [int] NULL,
	[chargeWay_id] [int] NULL,
	[lastChargeRecord_id] [int] NULL,
	[room_number] [varchar](50) NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[amount] [float] NULL,
 CONSTRAINT [PK_T_ROOM] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_unit]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[area] [varchar](50) NULL,
	[building] [int] NULL,
	[unit] [int] NULL,
 CONSTRAINT [PK_T_UNIT] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_updateAndChargeRecord]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_updateAndChargeRecord](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[date] [datetime] NULL,
	[meter_reading_date] [datetime] NULL,
	[meter_reading_value] [float] NULL,
	[meterInfo_id] [int] NULL,
	[amount] [float] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_T_UPDATEANDCHARGERECORD] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_complaintForm]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_complaintForm](
	[id] [int] NOT NULL,
	[c_time] [datetime] NULL,
	[c_name] [nchar](10) NULL,
	[c_address] [nchar](100) NULL,
	[c_tel] [int] NULL,
	[c_type] [int] NULL,
	[c_text] [text] NULL,
	[c_state] [nchar](10) NULL,
 CONSTRAINT [PK_t_complaintForm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_suggestionForm]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_suggestionForm](
	[id] [int] NOT NULL,
	[s_time] [datetime] NULL,
	[s_name] [nchar](10) NULL,
	[s_tel] [int] NULL,
	[s_address] [nchar](100) NULL,
	[s_type] [int] NULL,
	[s_text] [text] NULL,
 CONSTRAINT [PK_t_suggestionForm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_maintainForm]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_maintainForm](
	[id] [int] NOT NULL,
	[m_time] [datetime] NULL,
	[m_name] [nchar](10) NULL,
	[m_address] [nchar](100) NULL,
	[m_type] [int] NULL,
	[m_text] [text] NULL,
	[m_state] [int] NULL,
	[m_worker] [nchar](10) NULL,
	[m_feederivate] [int] NULL,
	[m_fee] [float] NULL,
 CONSTRAINT [PK_t_maintainForm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_heatInstallForm]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_heatInstallForm](
	[id] [int] NOT NULL,
	[meter_id] [int] NULL,
	[h_state] [int] NULL,
 CONSTRAINT [PK_t_heatInstallForm] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_user]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[real_name] [varchar](50) NULL,
	[position] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[group_id] [int] NULL,
 CONSTRAINT [PK_T_USER] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_batchInvoice]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_batchInvoice](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_num] [varchar](50) NULL,
	[end_num] [varchar](50) NULL,
	[total_num] [int] NULL,
	[single_limit_amount] [float] NULL,
	[total_limit_amount] [float] NULL,
	[add_date] [datetime] NULL,
	[remain_amount] [float] NULL,
	[effective_date] [datetime] NULL,
	[user_id] [int] NULL,
	[count] [int] NULL,
 CONSTRAINT [PK_T_BATCHINVOICE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_changeChargeWay]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_changeChargeWay](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[chargeWay_id] [int] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK_T_CHANGECHARGEWAY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
