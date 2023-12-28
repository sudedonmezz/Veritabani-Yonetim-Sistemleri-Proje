

create or replace function YAS(dogum text)
returns integer 
AS
$$
declare 
	yas integer;
	dogum_date date;
begin
	dogum_date := dogum::date;
	select extract (year from AGE(current_date,dogum_date)) into yas;
	return yas;
end;
$$ LANGUAGE 'plpgsql' IMMUTABLE SECURITY DEFINER;

-----------------------------------------------------------------------
create procedure insert_to60yasustu
(
	in Kartid int,
	in TC_NO int,
	in Dogum_Tarihi text
)
Language plpgsql
as
$$
declare 
yas int;
begin
	yas:=Yas(Dogum_Tarihi);

	if 65 > yas and yas > 60   then
 	 insert into "Kartlar"."Kartlar"("Kartlar_ID") values (Kartid);

	 insert into "Kartlar"."60_yasiustu_Kart"("Kartlar_ID","TC_NO","Dogum_Tarihi") values(Kartid,TC_NO,Dogum_Tarihi);
	 update "Kartlar"."60_yasiustu_Kart" set "ucret"=default,"renk"=default where "Kartlar_ID"=Kartid;
	end if;
end
$$;


create procedure insert_to65yasustu
(
	in Kartid int,
	in TC_NO int,
	in Dogum_Tarihi text
)
Language plpgsql
as
$$
declare 
yas int;
begin
	yas:=Yas(Dogum_Tarihi);

	if 65 < yas  then
 	 insert into "Kartlar"."Kartlar"("Kartlar_ID") values (Kartid);

	 insert into "Kartlar"."65_yasiustu_Kart"("Kartlar_ID","TC_NO","Dogum_Tarihi") values(Kartid,TC_NO,Dogum_Tarihi);
	 update "Kartlar"."65_yasiustu_Kart" set "ucret"=default,"renk"=default where "Kartlar_ID"=Kartid;
	end if;
end
$$;

CALL insert_to60yasustu(
    1, -- Replace with actual Kartid value
    123456789, -- Replace with actual TC_NO value
    '19900101' -- Replace with actual Dogum_Tarihi value
);


create or replace procedure insert_toanonim
(
	in KartlarID int
)
Language plpgsql
as
$$
declare 
kartid int ;
begin
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	insert into "Kartlar"."Anonim"("Kartlar_ID") values(KartlarID);
	update "Kartlar"."Anonim" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
end
$$;
drop procedure insert_toK(in int);

create or replace procedure insert_toEngelli_Kart
(
	in KartlarID int,
	in TC_NO int,
	in Belge_ID int
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	if exists (SELECT * FROM "public"."belge" WHERE "belge_ID" = Belge_ID) then
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."Engelli_Kart"("Kartlar_ID","TC_NO","Belge_ID") values(kartid,TC_NO,Belge_ID);
	update "Kartlar"."Engelli_Kart" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	end if;
end
$$;
SELECT proname, proargtypes
FROM pg_proc
WHERE proname = 'insert_toEngelli_Kart';

create or replace procedure insert_toOgrenciK
(
	in KartlarID int,
	in TC_NO int,
	in OkulAdi text,
	in ogrenci_No int
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	if exists (SELECT * FROM "public"."okul" WHERE "okul_Adi" = OkulAdi) then
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."Ogrenci"("Kartlar_ID","TC_NO","OkulAdi","ogrenci_No") values(kartid,TC_NO,OkulAdi,ogrenci_No);
	update "Kartlar"."Ogrenci" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	
	end if;
end
$$;

create or replace procedure insert_ogretmenK
(
in KartlarID int,
	in TC_NO int,
	in OkulAdi text,
	in personal_No int
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	if exists (SELECT * FROM "public"."okul" WHERE "okul_Adi" = OkulAdi) then
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."Ogretmen"("Kartlar_ID","TC_NO","OkulAdi","personal_No") values(kartid,TC_NO,OkulAdi,personal_No);
	update "Kartlar"."Ogretmen" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	end if;
end
$$;



create or replace procedure insert_toOgrenciAylik
(
	in KartlarID int,
	in TC_NO int,
	in OkulAdi text,
	in ogrenci_No int
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	if  exists (SELECT * FROM "public"."okul" WHERE "okul_Adi" = OkulAdi) then
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."OgrenciAylik"("Kartlar_ID","TC_NO","OkulAdi","ogrenci_No") values(kartid,TC_NO,OkulAdi,ogrenci_No);
	update "Kartlar"."OgrenciAylik" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	end if;
end
$$;

create or replace procedure insert_toTamAylik
(
	in KartlarID int,
	in TC_NO int
	
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."TamAylik"("Kartlar_ID","TC_NO") values(kartid,TC_NO);
	update "Kartlar"."TamAylik" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	
end
$$;

create or replace procedure insert_toSosyalAylik
(
	in KartlarID int,
	in TC_NO int,
	in OkulAdi text,
	in Dogum_Tarihi text
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	
	if  exists (SELECT * FROM "public"."okul" WHERE "okul_Adi" = OkulAdi) then
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."sosyalAylik"("Kartlar_ID","TC_NO","OkulAdi","Dogum_Tarihi") values(kartid,TC_NO,OkulAdi,Dogum_Tarihi);
	update "Kartlar"."sosyalAylik" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	end if;
	end
$$;



create or replace procedure insert_toSehitAilesiK
(
	in KartlarID int,
	in TC_NO int,
	in Belge_ID int
)
Language plpgsql
as
$$
declare 
kartid int;
begin
	insert into "Kartlar"."Kartlar"("Kartlar_ID") values (KartlarID) returning"Kartlar_ID" INTO kartid ;
	
	insert into "Kartlar"."sehitAilesi_Kart"("Kartlar_ID","TC_NO","BelgeID") values(kartid,TC_NO,Belge_ID);
	update "Kartlar"."sehitAilesi_Kart" set "ucret"=default,"renk"=default where "Kartlar_ID"=kartid;
	
end
$$;
-----------------------------------------------------------------------

-- Engelli Kart'ın belge ID'sini güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_EngelliK_belge
(
    IN kartid INT,
    IN belgeid INT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."Engelli_Kart"
    SET
        "Belge_ID" = belgeid
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

-- Şehit Ailesi Kart'ın belge ID'sini güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_sehitAilesiK_belge
(
    IN kartid INT,
    IN belgeid INT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."sehitAilesi_Kart"
    SET
        "BelgeID" = belgeid
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

-- Öğrenci Kart'ın OkulAdi ve ogrenci_No'sunu güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_OgrenciK
(
    IN kartid INT,
    IN Okul_Adi TEXT,
    IN OgrenciNo INT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."Ogrenci"
    SET
        "OkulAdi" = Okul_Adi,
        "ogrenci_No" = OgrenciNo
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

-- Öğretmen Kart'ın OkulAdi ve personal_No'sunu güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_toOgretmenK
(
    IN kartid INT,
    IN Okul_Adi TEXT,
    IN personalNo INT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."Ogretmen"
    SET
        "OkulAdi" = Okul_Adi,
        "personal_No" = personalNo
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

-- Öğrenci Aylik Kart'ın OkulAdi ve ogrenci_No'sunu güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_toOgrenciAylik
(
    IN kartid INT,
    IN Okul_Adi TEXT,
    IN OgrenciNo INT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."OgrenciAylik"
    SET
        "OkulAdi" = Okul_Adi,
        "ogrenci_No" = OgrenciNo
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

-- Sosyal Aylik Kart'ın OkulAdi'sini güncelleme prosedürü
CREATE OR REPLACE PROCEDURE update_toSosyalAylik
(
    IN kartid INT,
    IN Okul_adi TEXT
)
LANGUAGE plpgsql
AS 
$$
BEGIN
    UPDATE "Kartlar"."SosyalAylik"
    SET
        "OkulAdi" = Okul_adi
    WHERE "Kartlar_ID" = kartid;	
END;
$$;

---------------------------------------------------

create or replace procedure delete_60yasiustu
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."60_yasiustu_Kart" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_65yasiustu
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."65_yasiustu_Kart" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_Anonim
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."Anonim" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_EngelliK
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."Engelli_Kart" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_Ogrenci
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."Ogrenci" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_Ogretmen
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."Ogretmen" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;


create or replace procedure delete_OgrenciAylik
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."OgrenciAylik" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_TamAylik
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."TamAylik" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

create or replace procedure delete_SosyalAylik
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."sosyalAylik" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;


create or replace procedure delete_SehitAilesiK
( 
	in kartid int
)
language plpgsql
as 
$$
begin
	delete from "Kartlar"."sehitAilesi_Kart" 
	where "Kartlar_ID"=kartid;
	
	delete from "Kartlar"."Kartlar" 
	where "Kartlar_ID"=kartid;
end;
$$;

-----------------------------------------------------------------
create or replace function arama(in kartid int, OUT result_record RECORD)
language plpgsql
as
$$
begin
  select * into result_record from "Tablolartoplami" where "KartlarID" = kartid;
end;
$$;
--SELECT * FROM arama() AS result_record("KartlarID" INT, "TC_NO" BIGINT, "60+ dogum_Tarihi" TEXT, "60_kRenk" TEXT, "60_kUcret" INT, "65+ dogum_Tarihi" TEXT, "65_kRenk" TEXT, "65_kUcret" INT, "anonimK_renk" TEXT, "anonimK_ucret" INT, "Ogrenci_okul" TEXT, "Ogrenci_no" INT, "Ogrenci_renk" TEXT, "Ogrenci_ucret" INT, "Ogrenci_okul_Aylik" TEXT, "Ogrenci_no_Aylik" INT, "Ogrenci_renk_Aylik" TEXT, "Ogrenci_ucret_Aylik" INT, "Ogretmen_okul" TEXT, "personal_no" INT, "OgretmenK_renk" TEXT, "OgretmenK_ucret" INT, "TamAylik_renk" TEXT, "TamAylik_ucret" INT, "SehitAilesiK_renk" TEXT, "SehitAilesiK_belge" INT, "SehitAilesiK_ucret" INT, "sosyal_ogretmen" TEXT, "sosyal_date" TEXT, "sosyal_renk" TEXT, "sosyal_ucret" INT);
