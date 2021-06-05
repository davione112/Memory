CREATE PROCEDURE dbo.spChapters_Insert
	@ChapterName nvarchar(100),
	@id int = 1 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into dbo.Chapters (ChapterName) values(@ChapterName);

	select @id = SCOPE_IDENTITY();
END
GO
