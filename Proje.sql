create schema "Kartlar";

create table "Kartlar"."Kartlar"
(
	"Kartlar_ID" serial,
	"ucret" int,
	"renk" text ,
	constraint "kartlarID" primary key("Kartlar_ID")
);
ALTER TABLE "Kartlar"."Kartlar" ADD COLUMN cikartmaTarihi timestamp with time zone;


create table "Kartlar"."Anonim"
(
	"Kartlar_ID" int,
	"ucret" int default 13 ,
	"renk" text default 'Kirmizi',
	constraint "anonimPK" primary key("Kartlar_ID"),
	constraint "anonimFK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);


create table "Kartlar"."65_yasiustu_Kart"
(
	"Kartlar_ID" int,
	"TC_NO" BIGINT UNIQUE NOT NULL,
	"Dogum_Tarihi" date NOT NULL,
	"ucret" int default 0 ,
	"renk" text default 'sari',
	constraint "65_PK" primary key("Kartlar_ID"),
	constraint "65FK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
alter table  "Kartlar"."65_yasiustu_Kart" alter column "Dogum_Tarihi" type text ;

create table "belge"
(
	"belge_ID" int,
	"hastane_Adi" text,
	constraint "Belge_PK" primary key("belge_ID"),
	constraint "Belge_Fk" foreign key("hastane_Adi") references "Hastane"("hastane_Adi")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);


create table "Kartlar"."Engelli_Kart"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"Belge_ID" int unique ,
	"ucret" int default 0 ,
	"renk" text default 'yesil',
	constraint "EngelliK_PK" primary key("Kartlar_ID"),
	constraint "engelliFK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	
	constraint "belgeFK" foreign key ("Belge_ID") references "belge"("belge_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
	
	
create table "Kartlar"."sehitAilesi_Kart"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"BelgeID" serial not null ,
	"ucret" int default 0 ,
	"renk" text default 'sari',
	constraint "sehitAilesi_PK" primary key("Kartlar_ID"),
	constraint "sehitAilesiFK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
	
);


	
create table "Kartlar"."Ogrenci"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"OkulAdi" text NOT NULL,
	"ogrenci_No" int NOT NULL,
	"ucret" int default 7 ,
	"renk" text default 'mor',
	constraint "ogrenci_PK" primary key("Kartlar_ID"),
	constraint "OgrenciFK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	
	constraint "OgrenciBelgesi" foreign key ("OkulAdi") references "okul" ("okul_Adi")
	on delete CASCADE
	on update CASCADE
);

		

create table "Kartlar"."Ogretmen"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"OkulAdi" text NOT NULL,
	"personal_No" int NOT NULL,
	"ucret" int default 10 ,
	"renk" text default 'kahverengi',
	constraint "ogretmen_PK" primary key("Kartlar_ID"),
	constraint "OgretmenFK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	
	constraint "OkulOgretmeni" foreign key ("OkulAdi") references "okul" ("okul_Adi")
	on delete CASCADE
	on update CASCADE
);

create table "Kartlar"."60_yasiustu_Kart"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"Dogum_Tarihi" date NOT NULL,
	"ucret" int default 10 ,
	"renk" text default 'yesil',
	constraint "60_PK" primary key("Kartlar_ID"),
	constraint "60FK" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE	
);
alter table  "Kartlar"."60_yasiustu_Kart" alter column "Dogum_Tarihi" type text ;


create table "Kartlar"."TamAylik"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"ucret" int default 1177,
	"renk" text default 'gri',
	constraint "TamAylik_PK" primary key("Kartlar_ID"),
	constraint "MaviTamFk" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);


	
create table "Kartlar"."OgrenciAylik"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"OkulAdi" text , --unique NOT NULL,
	"ogrenci_No" int NOT NULL,
	"ucret" int default 212,
	"renk" text default 'mor',
	constraint "OgrenciAylik_PK" primary key("Kartlar_ID"),
	constraint "MaviOgrenciFk" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	
	constraint "OgrenciBelgesi" foreign key ("OkulAdi") references "okul" ("okul_Adi")
	on delete CASCADE
	on update CASCADE
)
alter table "Kartlar"."OgrenciAylik" add column "OkulAdi" TEXT ,add constraint "OgrenciBelgesi" foreign key ("OkulAdi") references "okul" ("okul_Adi")
	on delete CASCADE
	on update CASCADE;


create table "Kartlar"."sosyalAylik"
(
	"Kartlar_ID" int,
	"TC_NO" int unique NOT NULL,
	"Okul_No" int,
	"Dogum_Tarihi" date NOT NULL,
	"ucret" int default 483,
	"renk" text default 'kirmizi',
	constraint "SosyalAylik_PK" primary key("Kartlar_ID"),
	constraint "MaviSosyalFk" foreign key ("Kartlar_ID") references "Kartlar"."Kartlar"("Kartlar_ID")
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
alter table "Kartlar"."sosyalAylik" rename column "Okul_No" to "OkulAdi" ;
alter table "Kartlar"."sosyalAylik" alter column "OkulAdi" type text;
alter table "Kartlar"."sosyalAylik"  add constraint "Okulda eleman" foreign key ("OkulAdi") references "okul"("okul_Adi") on delete cascade on update cascade;	
alter table  "Kartlar"."sosyalAylik" alter column "Dogum_Tarihi" type text ;

create table "Hastane"
(
	"hastane_Adi" text,
	adress text,
	constraint "Hastane_PK" primary key("hastane_Adi")
);

create table "okul"
(
	"okul_Adi" text,
	adress text,
	constraint "okul_PK" primary key("okul_Adi")
);