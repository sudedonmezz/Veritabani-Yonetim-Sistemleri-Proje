CREATE OR REPLACE FUNCTION update_total_cost()
RETURNS TRIGGER AS $$
BEGIN
    UPDATE "Kartlar"."Kartlar"
    SET "ucret" = (SELECT SUM("ucret") FROM "Kartlar"."Kartlar" WHERE "Kartlar_ID" = NEW."Kartlar_ID")
    WHERE "Kartlar_ID" = NEW."Kartlar_ID";
    
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER total_cost_update_trigger
AFTER UPDATE OF "ucret" ON "Kartlar"."Kartlar"
FOR EACH ROW EXECUTE FUNCTION update_total_cost();

drop function add_timestamp CASCADE;


CREATE OR REPLACE FUNCTION add_timestamp()
RETURNS TRIGGER AS $$
BEGIN
    NEW."cikartmatarihi" := NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER timestamp_trigger
BEFORE INSERT OR UPDATE ON "Kartlar"."Kartlar"
FOR EACH ROW EXECUTE FUNCTION add_timestamp();


-- Trigger 6: 60_yasiustu_Kart tablosuna ekleme yapıldığında, doğum tarihi kontrolü (text format)
CREATE OR REPLACE FUNCTION check_60yas_kart_dogum_tarihi_text()
RETURNS TRIGGER AS $$
DECLARE
    v_date_str TEXT;
BEGIN
    -- Doğum tarihini belirtilmemişse veya uygun formatta değilse hata mesajı yazdır
    IF NEW."Dogum_Tarihi" IS NULL OR NOT regexp_match(NEW."Dogum_Tarihi", '^\d{4}-\d{2}-\d{2}$') THEN
        RAISE EXCEPTION 'Hata: Geçersiz doğum tarihi formatı! Doğru format: YYYY-MM-DD';
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

-- Tetikleyiciyi 60_yasiustu_Kart tablosuna bağla
CREATE TRIGGER trigger_check_60yas_kart_dogum_tarihi_text
BEFORE INSERT ON "Kartlar"."60_yasiustu_Kart"
FOR EACH ROW
EXECUTE FUNCTION check_60yas_kart_dogum_tarihi_text();

CREATE OR REPLACE FUNCTION check_hastane_ad_length()
RETURNS TRIGGER AS $$
BEGIN
    IF LENGTH(NEW."hastane_Adi") > 50 THEN
       RAISE EXCEPTION 'Hata: Hastane adı 50 karakterden uzun olamaz!';
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_check_hastane_ad_length
BEFORE INSERT ON "Hastane"
FOR EACH ROW
EXECUTE FUNCTION check_hastane_ad_length();


CREATE OR REPLACE FUNCTION check_65yas_kart_dogum_tarihi_text()
RETURNS TRIGGER AS $$
DECLARE
    v_date_str TEXT;
BEGIN
    IF NEW."Dogum_Tarihi" IS NULL OR NOT regexp_match(NEW."Dogum_Tarihi", '^\d{4}-\d{2}-\d{2}$') THEN
        RAISE EXCEPTION 'Hata: Geçersiz doğum tarihi formatı! Doğru format: YYYY-MM-DD';
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_check_65yas_kart_dogum_tarihi_text
BEFORE INSERT ON "Kartlar"."65_yasiustu_Kart"
FOR EACH ROW
EXECUTE FUNCTION check_65yas_kart_dogum_tarihi_text();
