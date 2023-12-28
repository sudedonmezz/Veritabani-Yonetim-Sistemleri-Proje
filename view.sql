create or replace view "Tablolartoplami" as
select 
	
	coalesce (
		       "Kartlar"."Kartlar"."Kartlar_ID",
			   "Kartlar"."60_yasiustu_Kart"."Kartlar_ID", 
			   "Kartlar"."65_yasiustu_Kart"."Kartlar_ID",
			   "Kartlar"."Anonim"."Kartlar_ID",
			   "Kartlar"."Engelli_Kart"."Kartlar_ID",
			   "Kartlar"."Ogrenci"."Kartlar_ID",
			   "Kartlar"."OgrenciAylik"."Kartlar_ID",
			   "Kartlar"."Ogretmen"."Kartlar_ID",
			   "Kartlar"."TamAylik"."Kartlar_ID",
			   "Kartlar"."sehitAilesi_Kart"."Kartlar_ID",
			   "Kartlar"."sosyalAylik"."Kartlar_ID"
			 ) as "KartlarID",
	
	coalesce (
			   "Kartlar"."60_yasiustu_Kart"."TC_NO", 
			   "Kartlar"."65_yasiustu_Kart"."TC_NO",
			   "Kartlar"."Engelli_Kart"."TC_NO",
			   "Kartlar"."Ogrenci"."TC_NO",
			   "Kartlar"."OgrenciAylik"."TC_NO",
			   "Kartlar"."Ogretmen"."TC_NO",
			   "Kartlar"."TamAylik"."TC_NO",
			   "Kartlar"."sehitAilesi_Kart"."TC_NO",
			   "Kartlar"."sosyalAylik"."TC_NO"
			 ) as "TC_NO" ,
			
	"Kartlar"."60_yasiustu_Kart"."Dogum_Tarihi" as "60+ dogum_Tarihi",
	"Kartlar"."60_yasiustu_Kart"."renk" as "60_kRenk",
	"Kartlar"."60_yasiustu_Kart"."ucret" as "60_kUcret",
	
	"Kartlar"."65_yasiustu_Kart"."Dogum_Tarihi" as "65+ dogum_Tarihi",
	"Kartlar"."65_yasiustu_Kart"."renk" as "65_kRenk",
	"Kartlar"."65_yasiustu_Kart"."ucret" as "65_kUcret",
	
	"Kartlar"."Anonim"."renk" as "anonimK_renk",
	"Kartlar"."Anonim"."ucret" as "anonimK_ucret",
	
	"Kartlar"."Ogrenci"."OkulAdi" as "Ogrenci_okul",
	"Kartlar"."Ogrenci"."ogrenci_No" as "Ogrenci_no",
	"Kartlar"."Ogrenci"."renk" as "Ogrenci_renk",
	"Kartlar"."Ogrenci"."ucret" as "Ogrenci_ucret",
	
	"Kartlar"."OgrenciAylik"."OkulAdi" as "Ogrenci_okul_Aylik",
	"Kartlar"."OgrenciAylik"."ogrenci_No" as "Ogrenci_no_Aylik",
	"Kartlar"."OgrenciAylik"."renk" as "Ogrenci_renk_Aylik",
	"Kartlar"."OgrenciAylik"."ucret" as "Ogrenci_ucret_Aylik",
	
	"Kartlar"."Ogretmen"."OkulAdi" as "Ogretmen_okul",
	"Kartlar"."Ogretmen"."personal_No" as "personal_no",
	"Kartlar"."Ogretmen"."renk" as "OgretmenK_renk",
	"Kartlar"."Ogretmen"."ucret" as "OgretmenK_ucret",
	
	"Kartlar"."TamAylik"."renk" as "TamAylik_renk",
	"Kartlar"."TamAylik"."ucret" as "TamAylik_ucret",
	
	"Kartlar"."sehitAilesi_Kart"."renk" as "SehitAilesiK_renk",
	"Kartlar"."sehitAilesi_Kart"."BelgeID" as "SehitAilesiK_belge",
	"Kartlar"."sehitAilesi_Kart"."ucret" as "SehitAilesiK_ucret",
	
	"Kartlar"."sosyalAylik"."OkulAdi" as "sosyal_ogretmen",
	"Kartlar"."sosyalAylik"."Dogum_Tarihi" as "sosyal_date",
	"Kartlar"."sosyalAylik"."renk" as "sosyal_renk",
	"Kartlar"."sosyalAylik"."ucret" as "sosyal_ucret"
	
from "Kartlar"."Kartlar"
left join 
	"Kartlar"."60_yasiustu_Kart" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."60_yasiustu_Kart"."Kartlar_ID"
left join	 
	 "Kartlar"."65_yasiustu_Kart" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."65_yasiustu_Kart"."Kartlar_ID"
left join	 
	 "Kartlar"."Anonim" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."Anonim"."Kartlar_ID"
left join	 
	 "Kartlar"."Engelli_Kart" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."Engelli_Kart"."Kartlar_ID"
left join	 
	 "Kartlar"."Ogrenci" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."Ogrenci"."Kartlar_ID"
left join	 
	 "Kartlar"."OgrenciAylik" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."OgrenciAylik"."Kartlar_ID"
left join	 
	 "Kartlar"."Ogretmen" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."Ogretmen"."Kartlar_ID"		
left join	 
	 "Kartlar"."TamAylik" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."TamAylik"."Kartlar_ID"
left join	 
	 "Kartlar"."sehitAilesi_Kart" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."sehitAilesi_Kart"."Kartlar_ID"
left join	 
	 "Kartlar"."sosyalAylik" on 
		"Kartlar"."Kartlar"."Kartlar_ID"="Kartlar"."sosyalAylik"."Kartlar_ID";

			 

SELECT * FROM "Tablolartoplami";