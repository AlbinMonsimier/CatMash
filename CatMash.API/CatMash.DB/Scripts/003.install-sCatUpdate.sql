create procedure cm.sCatUpdate
(
    @CatId int,
	@CatScore int
)
as
begin
    update cm.tCat
	set CatScore += @CatScore where CatId = @CatId;
	return 0;
end;