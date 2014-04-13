INSERT INTO jogosultsagi_szintek (Id,megnevezes) VALUES (1,'vendég');
INSERT INTO jogosultsagi_szintek (Id,megnevezes) VALUES (2,'felhasználó');
INSERT INTO jogosultsagi_szintek (Id,megnevezes) VALUES (3,'csoport admin');
INSERT INTO jogosultsagi_szintek (Id,megnevezes) VALUES (4,'rendszer admin');

INSERT INTO csoportok
 (Id,cegnev,telephely,cegvezeto,levelezesi_cim, alapitas_datuma,logo,leiras)
VAlUES (1,'DevIT','Budapest',null,null,null,null,null);

INSERT INTO felhasznalok 
(Id,azonosito,jelszo,jogosultsagi_szint,nev,lakhely,szuletesi_hely,szuletesi_ido,csoport,beosztas,leiras,profilkep) 
VALUES (1,'AdminGabor','nimda',4,'Nagy Gábor','Budapest','Gyöngyös','1991-09-17',1,'Projekt adminisztrátor, Kapcsolattartó',null,null);

INSERT INTO felhasznalok 
(Id,azonosito,jelszo,jogosultsagi_szint,nev,lakhely,szuletesi_hely,szuletesi_ido,csoport,beosztas,leiras,profilkep) 
VALUES (2,'guest','guest',1,'VENDÉG',null,'vendég','1991-09-17',null,'vendég','vendég',null);
