DROP TABLE IF EXISTS "Games";

CREATE TABLE "Games" (
	"GameID" INTEGER PRIMARY KEY,
	"GameTitle" nvarchar (40) NOT NULL,
	"Genre" nvarchar (15) NOT NULL,
	"ReleaseYear" nvarchar (4),
	"Description" nvarchar (255) NOT NULL
);

INSERT INTO "Games"("GameID","GameTitle","Genre","ReleaseYear","Description") VALUES(1,'Final Fantasy VII','JRPG','1997',"The game's story follows Cloud Strife, a mercenary who joins an eco-terrorist organization to stop a world-controlling megacorporation from using the planet's life essence as an energy source.");
INSERT INTO "Games"("GameID","GameTitle","Genre","ReleaseYear","Description") VALUES(2,'Resident Evil 4','Horror','2005','Resident Evil 4 is a survival horror third-person shooter game developed by Capcom Production Studio 4 and published by Capcom. It was originally released for the GameCube in 2005.');
INSERT INTO "Games"("GameID","GameTitle","Genre","ReleaseYear","Description") VALUES(3,'Tales Of Xillia','JRPG','2011','Xillia takes place in a fictional world called Rieze Maxia where humans and spirits live in harmony. It follows Jude Mathis and Milla Maxwell who elude government officials after sabotaging a weapon of mass destruction known as the Lance of Kresnik.');
INSERT INTO "Games"("GameID","GameTitle","Genre","ReleaseYear","Description") VALUES(4,'Deus Ex: Mankind Divided','Stealth Game','2016','Set in 2029, two years after Human Revolution, the world is divided between normal humans and those with advanced, controversial artificial organs dubbed "augmentations".');
INSERT INTO "Games"("GameID","GameTitle","Genre","ReleaseYear","Description") VALUES(5,'Dead By Daylight','Horror','2016','Dead by Daylight is an asymmetrical multiplayer horror game where one player takes on the role of a brutal Killer and the other four play as Survivors.');