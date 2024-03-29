USE [Edulms]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_answers]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_answers](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[assessment_id] [bigint] NOT NULL,
	[question_id] [bigint] NOT NULL,
	[answer] [nvarchar](max) NULL,
	[user_id] [bigint] NOT NULL,
	[score] [tinyint] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_answers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_data]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_data](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[assessment_id] [bigint] NOT NULL,
	[data] [nvarchar](max) NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_department]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_department](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[group_id] [bigint] NULL,
	[assessment_id] [bigint] NOT NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_department] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_enrols]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_enrols](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[assessment_id] [bigint] NOT NULL,
	[user_id] [bigint] NOT NULL,
	[result] [int] NULL,
	[score] [tinyint] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_enrols] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_match]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_match](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[answer_id_key] [nvarchar](max) NULL,
	[question_id_key] [nvarchar](max) NULL,
	[option] [nvarchar](max) NULL,
	[answer] [nvarchar](max) NULL,
	[question_id] [bigint] NOT NULL,
	[order] [int] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_match] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_meta]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_meta](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[assessment_id] [bigint] NOT NULL,
	[type] [nvarchar](max) NULL,
	[value] [nvarchar](max) NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_meta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_options]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_options](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[option] [nvarchar](max) NULL,
	[question_id] [bigint] NOT NULL,
	[correct] [tinyint] NULL,
	[order] [int] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_options] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_questions]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_questions](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[question] [nvarchar](max) NOT NULL,
	[category_id] [bigint] NULL,
	[level] [int] NULL,
	[order] [int] NULL,
	[type] [nvarchar](max) NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_questions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_questions_relation]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_questions_relation](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[question_id] [bigint] NOT NULL,
	[assessment_id] [bigint] NOT NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_questions_relation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_sections]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_sections](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[assessment_id] [bigint] NOT NULL,
	[order] [int] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_sections] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_text]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_text](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[answer] [nvarchar](max) NULL,
	[question_id] [bigint] NOT NULL,
	[order] [int] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_text] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessment_true_false]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessment_true_false](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[question_id] [bigint] NOT NULL,
	[is_true] [bit] NOT NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessment_true_false] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[assessments]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[assessments](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[short_description] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[slug] [nvarchar](max) NULL,
	[created_by] [nvarchar](max) NULL,
	[updated_by] [nvarchar](max) NULL,
	[duration] [datetime2](7) NULL,
	[category_id] [bigint] NULL,
	[thumbnail] [nvarchar](max) NULL,
	[published] [tinyint] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_assessments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 1/26/2024 1:30:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[api_key] [nvarchar](max) NULL,
	[username] [nvarchar](max) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[first_name] [nvarchar](max) NOT NULL,
	[last_name] [nvarchar](max) NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[is_banned] [tinyint] NULL,
	[is_verified] [tinyint] NULL,
	[confirm_code] [nvarchar](max) NULL,
	[confirmed_at] [datetime2](7) NULL,
	[password_changed_at] [datetime2](7) NULL,
	[display_name] [nvarchar](max) NULL,
	[user_url] [nvarchar](max) NULL,
	[is_ldap] [tinyint] NULL,
	[created_by] [bigint] NULL,
	[updated_by] [bigint] NULL,
	[remember_token] [nvarchar](max) NULL,
	[deleted_at] [datetime2](7) NULL,
	[otp] [nvarchar](max) NULL,
	[otp_created_at] [datetime2](7) NULL,
	[profile_picture_id] [bigint] NULL,
	[created_at] [datetime2](7) NULL,
	[updated_at] [datetime2](7) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240125143238_init', N'7.0.12')
GO
SET IDENTITY_INSERT [dbo].[assessment_answers] ON 

INSERT [dbo].[assessment_answers] ([id], [assessment_id], [question_id], [answer], [user_id], [score], [created_at], [updated_at]) VALUES (1, 1, 4, N'4', 1, 1, NULL, NULL)
INSERT [dbo].[assessment_answers] ([id], [assessment_id], [question_id], [answer], [user_id], [score], [created_at], [updated_at]) VALUES (2, 1, 6, NULL, 1, 0, CAST(N'2024-01-26T00:20:19.5519377' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[assessment_answers] OFF
GO
SET IDENTITY_INSERT [dbo].[assessment_match] ON 

INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (1, NULL, NULL, N'513d84b4-cf21-457d-8877-8e79b7b788ad', N'1', 1, NULL, NULL, NULL)
INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (2, NULL, NULL, N'1238465-56657hg', N'0', 1, NULL, NULL, NULL)
INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (3, NULL, NULL, N'342c32fb-f03b-4d1d-88c5-135aa390b817', N'1', 2, NULL, NULL, NULL)
INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (4, NULL, NULL, N'ghjh567-hgf76', N'0', 2, NULL, NULL, NULL)
INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (5, NULL, NULL, N'23lk-uyu899', N'0', 3, NULL, NULL, NULL)
INSERT [dbo].[assessment_match] ([id], [answer_id_key], [question_id_key], [option], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (6, NULL, NULL, N'a53bbf05-c075-4904-a1eb-f687781c8b1f', N'1', 3, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessment_match] OFF
GO
SET IDENTITY_INSERT [dbo].[assessment_options] ON 

INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (1, N'4', 4, 1, NULL, NULL, NULL)
INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (2, N'3', 4, 0, NULL, NULL, NULL)
INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (3, N'5', 4, 1, NULL, NULL, NULL)
INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (4, N'44', 13, 0, NULL, NULL, NULL)
INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (5, N'13', 13, 0, NULL, NULL, NULL)
INSERT [dbo].[assessment_options] ([id], [option], [question_id], [correct], [order], [created_at], [updated_at]) VALUES (6, N'2', 13, 1, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessment_options] OFF
GO
SET IDENTITY_INSERT [dbo].[assessment_questions] ON 

INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (1, N'726d21c5-87ba-4384-b97a-d8ce7c0b191c', NULL, NULL, NULL, N'match', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (2, N'5a39c567-0fa8-44fb-aae6-055bc2d7e9f3', NULL, NULL, NULL, N'match', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (3, N'c53ab084-87f5-4faa-a655-7569e09e2870', NULL, NULL, NULL, N'match', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (4, N'How many', NULL, NULL, NULL, N'ms', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (5, N'Like that', NULL, NULL, NULL, N'true_false', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (6, N'Short note about', NULL, NULL, NULL, N'short', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (7, N'Write in details about', NULL, NULL, NULL, N'long', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (8, N'70620925-f592-4ef8-a5dc-8d8d186d5791', NULL, NULL, NULL, N'fill', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (9, N'b18d402a-0140-4913-8f9a-b3b9469a1840', NULL, NULL, NULL, N'fill', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (10, N'1583bef9-44a1-4c95-9bf6-703e4940c390', NULL, NULL, NULL, N'fill', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (11, N'781e17ea-cfed-4730-93b7-05075525f5a4', NULL, NULL, NULL, N'fill', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (12, N'b5f561a2-cdc3-4884-a6e8-2732d619c659', NULL, NULL, NULL, N'fill', NULL, NULL)
INSERT [dbo].[assessment_questions] ([id], [question], [category_id], [level], [order], [type], [created_at], [updated_at]) VALUES (13, N'choose one', NULL, NULL, NULL, N'mc', NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessment_questions] OFF
GO
SET IDENTITY_INSERT [dbo].[assessment_text] ON 

INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (1, N'N', 6, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (2, N'N3', 7, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (3, N'8c74fed8', 8, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (4, N'b317', 9, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (5, N'5d1b9a34', 10, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (6, N'eb34', 11, NULL, NULL, NULL)
INSERT [dbo].[assessment_text] ([id], [answer], [question_id], [order], [created_at], [updated_at]) VALUES (7, N'3cc252eb175a', 12, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessment_text] OFF
GO
SET IDENTITY_INSERT [dbo].[assessment_true_false] ON 

INSERT [dbo].[assessment_true_false] ([id], [question_id], [is_true], [created_at], [updated_at]) VALUES (1, 5, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessment_true_false] OFF
GO
SET IDENTITY_INSERT [dbo].[assessments] ON 

INSERT [dbo].[assessments] ([id], [title], [short_description], [description], [slug], [created_by], [updated_by], [duration], [category_id], [thumbnail], [published], [created_at], [updated_at]) VALUES (1, N'java', N'java exam', N'java midterm exam', NULL, NULL, NULL, NULL, NULL, NULL, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[assessments] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [api_key], [username], [password], [first_name], [last_name], [email], [is_banned], [is_verified], [confirm_code], [confirmed_at], [password_changed_at], [display_name], [user_url], [is_ldap], [created_by], [updated_by], [remember_token], [deleted_at], [otp], [otp_created_at], [profile_picture_id], [created_at], [updated_at]) VALUES (1, NULL, N'ali ahmed', N'12345678', N'ali', N'ahmed', N'ali@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[assessment_answers]  WITH CHECK ADD  CONSTRAINT [FK_assessment_answers_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_answers] CHECK CONSTRAINT [FK_assessment_answers_assessment_questions_question_id]
GO
ALTER TABLE [dbo].[assessment_answers]  WITH CHECK ADD  CONSTRAINT [FK_assessment_answers_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_answers] CHECK CONSTRAINT [FK_assessment_answers_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_answers]  WITH CHECK ADD  CONSTRAINT [FK_assessment_answers_user_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[assessment_answers] CHECK CONSTRAINT [FK_assessment_answers_user_user_id]
GO
ALTER TABLE [dbo].[assessment_data]  WITH CHECK ADD  CONSTRAINT [FK_assessment_data_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_data] CHECK CONSTRAINT [FK_assessment_data_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_department]  WITH CHECK ADD  CONSTRAINT [FK_assessment_department_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_department] CHECK CONSTRAINT [FK_assessment_department_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_enrols]  WITH CHECK ADD  CONSTRAINT [FK_assessment_enrols_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_enrols] CHECK CONSTRAINT [FK_assessment_enrols_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_enrols]  WITH CHECK ADD  CONSTRAINT [FK_assessment_enrols_user_user_id] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[assessment_enrols] CHECK CONSTRAINT [FK_assessment_enrols_user_user_id]
GO
ALTER TABLE [dbo].[assessment_match]  WITH CHECK ADD  CONSTRAINT [FK_assessment_match_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_match] CHECK CONSTRAINT [FK_assessment_match_assessment_questions_question_id]
GO
ALTER TABLE [dbo].[assessment_meta]  WITH CHECK ADD  CONSTRAINT [FK_assessment_meta_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_meta] CHECK CONSTRAINT [FK_assessment_meta_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_options]  WITH CHECK ADD  CONSTRAINT [FK_assessment_options_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_options] CHECK CONSTRAINT [FK_assessment_options_assessment_questions_question_id]
GO
ALTER TABLE [dbo].[assessment_questions_relation]  WITH CHECK ADD  CONSTRAINT [FK_assessment_questions_relation_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_questions_relation] CHECK CONSTRAINT [FK_assessment_questions_relation_assessment_questions_question_id]
GO
ALTER TABLE [dbo].[assessment_questions_relation]  WITH CHECK ADD  CONSTRAINT [FK_assessment_questions_relation_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_questions_relation] CHECK CONSTRAINT [FK_assessment_questions_relation_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_sections]  WITH CHECK ADD  CONSTRAINT [FK_assessment_sections_assessments_assessment_id] FOREIGN KEY([assessment_id])
REFERENCES [dbo].[assessments] ([id])
GO
ALTER TABLE [dbo].[assessment_sections] CHECK CONSTRAINT [FK_assessment_sections_assessments_assessment_id]
GO
ALTER TABLE [dbo].[assessment_text]  WITH CHECK ADD  CONSTRAINT [FK_assessment_text_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_text] CHECK CONSTRAINT [FK_assessment_text_assessment_questions_question_id]
GO
ALTER TABLE [dbo].[assessment_true_false]  WITH CHECK ADD  CONSTRAINT [FK_assessment_true_false_assessment_questions_question_id] FOREIGN KEY([question_id])
REFERENCES [dbo].[assessment_questions] ([id])
GO
ALTER TABLE [dbo].[assessment_true_false] CHECK CONSTRAINT [FK_assessment_true_false_assessment_questions_question_id]
GO
