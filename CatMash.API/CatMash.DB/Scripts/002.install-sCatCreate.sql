create procedure cm.sCatCreate
(
	@CatId int out,
	@CatScore int
)
as 
begin
	set transaction isolation level serializable;
	begin tran;

	begin
		rollback;
		return 1;		
	end;

    insert into cm.tCat(CatScore) values(0);
	set @CatId = scope_identity();
	commit;
	return 0;
end;