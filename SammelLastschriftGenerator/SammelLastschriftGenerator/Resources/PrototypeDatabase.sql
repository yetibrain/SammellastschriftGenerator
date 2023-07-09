BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS "Transaktionsjahr" (
	"Jahr"	INTEGER NOT NULL,
	PRIMARY KEY("Jahr")
);
CREATE TABLE IF NOT EXISTS "Transaktionsart" (
	"Id"	INTEGER NOT NULL,
	"Method"	TEXT,
	PRIMARY KEY("Id" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Transaktionen" (
	"Id"	INTEGER NOT NULL,
	"Jahr"	INTEGER,
	"MitgliedId"	TEXT,
	"Transaktionsdatum"	TEXT,
	"Zweck"	TEXT,
	"Transaktionsart"	TEXT,
	"Betrag"	NUMERIC,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("Jahr") REFERENCES "Transaktionsjahr"("Jahr"),
	FOREIGN KEY("MitgliedId") REFERENCES "Mitglieder"("MitgliedId")
);
CREATE TABLE IF NOT EXISTS "Mitglieder" (
	"MitgliedId"	TEXT,
	"Rolle"	TEXT,
	"Jahresbeitrag"	NUMERIC,
	"Anrede"	TEXT,
	"Vorname"	TEXT,
	"Nachname"	TEXT,
	"EMail"	TEXT,
	"Strasse"	TEXT,
	"PLZ"	TEXT,
	"Ort"	TEXT,
	"Geburtsdatum"	TEXT,
	"Beitrittsdatum"	TEXT,
	"Mobilfunk"	TEXT,
	"Festnetz"	TEXT,
	"BeitrittserklärungPapier"	TEXT,
	"BeitrittserklärungDigital"	TEXT,
	"IBAN"	TEXT,
	"DatumIBANCheck"	TEXT,
	"IBANValid"	INTEGER,
	"BIC"	TEXT,
	"BankName"	TEXT,
	"Lastschrifterteilungsdatum"	TEXT,
	"Austrittsdatum"	TEXT,
	"Austrittsnachweis"	TEXT,
	"Bemerkungen"	TEXT,
	PRIMARY KEY("MitgliedId")
);
COMMIT;
