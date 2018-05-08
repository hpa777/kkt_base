USE kkt_base;

ALTER TABLE dbo.fn_number_dir ADD deleted bit NULL;
ALTER TABLE dbo.ofd_dir ADD full_name nvarchar(255) null, inn bigint null;
ALTER TABLE dbo.doc_kkm ADD
region_code tinyint null,
zip_code int null,
district nvarchar(255) null,
city nvarchar(255) null,
settlement nvarchar(255) null,
street nvarchar(255) null,
house_number nvarchar(50) null,
building_number nvarchar(50) null,
apartment_number nvarchar(50) null,
location_full nvarchar(255) null;
ALTER TABLE dbo.doc_head ADD
full_name nvarchar(255) null,
member_im nvarchar(255) null;
ALTER TABLE dbo.fn_mp_dir alter column description nvarchar(255) NULL;