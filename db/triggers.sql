
--insert into products ("name","desc",brand_id) values('name','анонс',1);

CREATE or alter  TRIGGER [u0569488_tehnoadmin].prod_insert_nobrandid
	ON Products
	FOR INSERT, update
	AS
	BEGIN
	  DECLARE  @cur cursor;
	  DECLARE  @curcat cursor;
	  DECLARE @i int;
	  DECLARE @n nvarchar(200);
	  
	  set @cur = cursor scroll for
		select id,brand_name from inserted where brand_id is null and brand_name is not null;

	open @cur;
	fetch next from @cur into @i,@n;
	while @@FETCH_STATUS = 0
	  begin
		update products set brand_id = 
			(select id from brands where name=@n)
		where id = @i;
		fetch next from @cur into @i,@n;
	  end;
	close @cur;

	set @curcat = cursor scroll for
		select id,cat_name from inserted where cat_id is null and cat_name is not null;

	open @curcat;
	fetch next from @curcat into @i,@n;
	while @@FETCH_STATUS = 0
	  begin
		update products set cat_id = 
			(select id from cats where name=@n)
		where id = @i;
		fetch next from @curcat into @i,@n;
	  end;
	close @curcat; a

END;