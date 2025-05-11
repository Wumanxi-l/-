create proc add_log
@username nvarchar(50),@type nvarchar(50),@action_date datetime,@action_table nvarchar(50)
as
insert into log(username,type,action_date,action_table)
values(@username,@type,@action_date,@action_table)