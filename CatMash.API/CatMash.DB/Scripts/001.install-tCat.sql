create table cm.tCat
(
	CatId int identity(0,1),
	CatScore int not null,

	constraint PK_tCat primary key(catId),
);

	  DECLARE @i int = 0
  WHILE @i < 100
  BEGIN
	SET @i = @i + 1
		insert into cm.tCat values(0)
	END

