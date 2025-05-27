DROP DATABASE IF EXISTS magazinpieseautopaoo;
CREATE DATABASE magazinpieseautopaoo;
USE magazinpieseautopaoo;

-- ============================
-- 1. TABLE STRUCTURE
-- ============================

-- Users
CREATE TABLE Users (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    username   VARCHAR(50)  NOT NULL UNIQUE,
    password   VARCHAR(100) NOT NULL,
    role       VARCHAR(20)  NOT NULL  -- 'CLIENT' sau 'EMPLOYEE'
);

-- Clients (linked to Users)
CREATE TABLE Clienti (
    id_client INT PRIMARY KEY,
    nume      VARCHAR(100),
    prenume   VARCHAR(100),
    telefon   VARCHAR(20),
    email     VARCHAR(100),
    FOREIGN KEY (id_client) REFERENCES Users(id_user)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- Departments
CREATE TABLE Departamente (
    id_dept    INT AUTO_INCREMENT PRIMARY KEY,
    nume_dept  VARCHAR(100) NOT NULL
);

-- Roles/Functions
CREATE TABLE Functii (
    id_functie    INT AUTO_INCREMENT PRIMARY KEY,
    nume_functie  VARCHAR(100) NOT NULL
);

-- Employees (linked to Users, Departments, Functions)
CREATE TABLE Angajati (
    id_angajat   INT PRIMARY KEY,
    id_dept      INT,
    id_functie   INT,
    data_angajare DATE,
    salariu      DOUBLE,
    FOREIGN KEY (id_angajat)  REFERENCES Users(id_user)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_dept)     REFERENCES Departamente(id_dept)
        ON DELETE RESTRICT ON UPDATE CASCADE,
    FOREIGN KEY (id_functie)  REFERENCES Functii(id_functie)
        ON DELETE RESTRICT ON UPDATE CASCADE
);

-- Categories for parts
CREATE TABLE CategoriiPiese (
    id_categorie   INT AUTO_INCREMENT PRIMARY KEY,
    nume_categorie VARCHAR(100) NOT NULL
);

-- Manufacturers for parts
CREATE TABLE Producatori (
    id_producator     INT AUTO_INCREMENT PRIMARY KEY,
    nume_producator   VARCHAR(100) NOT NULL
);

-- Auto Parts
CREATE TABLE PieseAuto (
    id_piesa       INT AUTO_INCREMENT PRIMARY KEY,
    denumire       VARCHAR(100),
    producator     VARCHAR(100),
    stoc           INT DEFAULT 0,
    pret           DOUBLE,
    id_categorie   INT,
    id_producator  INT,
    FOREIGN KEY (id_categorie)  REFERENCES CategoriiPiese(id_categorie)
        ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (id_producator) REFERENCES Producatori(id_producator)
        ON DELETE SET NULL ON UPDATE CASCADE
);

-- Orders
CREATE TABLE Comenzi (
    id_comanda    INT AUTO_INCREMENT PRIMARY KEY,
    id_client     INT,
    data_comanda  DATE,
    valoare_totala DOUBLE,
    FOREIGN KEY (id_client) REFERENCES Clienti(id_client)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- Order Details (which parts, qty & price)
CREATE TABLE DetaliiComenzi (
    id_detaliu    INT AUTO_INCREMENT PRIMARY KEY,
    id_comanda    INT,
    id_piesa      INT,
    cantitate     INT,
    pret_unitar   DOUBLE,
    FOREIGN KEY (id_comanda) REFERENCES Comenzi(id_comanda)
        ON DELETE CASCADE ON UPDATE CASCADE,
    FOREIGN KEY (id_piesa)    REFERENCES PieseAuto(id_piesa)
        ON DELETE RESTRICT ON UPDATE CASCADE
);

-- Invoices
CREATE TABLE Facturi (
    id_factura    INT AUTO_INCREMENT PRIMARY KEY,
    id_comanda    INT,
    data_emitere  DATE,
    numar_factura VARCHAR(50),
    FOREIGN KEY (id_comanda) REFERENCES Comenzi(id_comanda)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- Complaints
CREATE TABLE Reclamatii (
    id_reclamatie    INT AUTO_INCREMENT PRIMARY KEY,
    id_client        INT,
    descriere        TEXT,
    data_reclamatie  DATE,
    FOREIGN KEY (id_client) REFERENCES Clienti(id_client)
        ON DELETE CASCADE ON UPDATE CASCADE
);

-- Activity Log
CREATE TABLE LogActiuni (
    id_log      INT AUTO_INCREMENT PRIMARY KEY,
    id_user     INT,
    actiune     VARCHAR(255),
    comanda_sql TEXT,
    data_ora    DATETIME,
    FOREIGN KEY (id_user) REFERENCES Users(id_user)
        ON DELETE SET NULL ON UPDATE CASCADE
);

-- Stock History
CREATE TABLE IstoricStoc (
    id_stoc        INT AUTO_INCREMENT PRIMARY KEY,
    id_piesa       INT,
    cantitate      INT,
    tip_operatie   ENUM('INTRARE','IESIRE','AJUSTARE'),
    data_operatie  DATETIME,
    id_user        INT,
    FOREIGN KEY (id_piesa) REFERENCES PieseAuto(id_piesa),
    FOREIGN KEY (id_user)  REFERENCES Users(id_user)
);

-- XLS Imports Log
CREATE TABLE ImporturiXLS (
    id_import     INT AUTO_INCREMENT PRIMARY KEY,
    nume_fisier   VARCHAR(255),
    data_import   DATETIME,
    id_user       INT,
    FOREIGN KEY (id_user) REFERENCES Users(id_user)
);

-- Delivery Addresses for Clients
CREATE TABLE AdreseLivrare (
    id_adresa    INT AUTO_INCREMENT PRIMARY KEY,
    id_client    INT,
    adresa       TEXT,
    oras         VARCHAR(100),
    judet        VARCHAR(100),
    cod_postal   VARCHAR(20),
    tara         VARCHAR(100),
    FOREIGN KEY (id_client) REFERENCES Clienti(id_client)
);

-- ============================
-- 2. INITIAL DATA INSERTS
-- ============================

-- Departments
INSERT INTO Departamente (nume_dept) VALUES
  ('IT'), ('Vânzări'), ('Contabilitate'), ('Resurse Umane');

-- Functions
INSERT INTO Functii (nume_functie) VALUES
  ('Programator'), ('Contabil'), ('Manager'), ('Reprezentant vânzări');

-- Employees (Users + Angajati)
INSERT INTO Users (username, password, role) VALUES
  ('admin', 'admin123',    'EMPLOYEE'),
  ('ion_angajat','parolaIon','EMPLOYEE');
SET @ion_id := LAST_INSERT_ID();
INSERT INTO Angajati (id_angajat, id_dept, id_functie, data_angajare, salariu)
  VALUES (@ion_id, 1, 1, '2025-03-01', 3500);

-- Clients (Users + Clienti)
INSERT INTO Users (username, password, role) VALUES
  ('george_client','george123','CLIENT'),
  ('alex_client',  'alex123',  'CLIENT'),
  ('elena_client', 'elena123', 'CLIENT'),
  ('cristi_client','cristi123','CLIENT'),
  ('maria_client','maria123','CLIENT');
SELECT @id_george := id_user FROM Users WHERE username='george_client';
SELECT @id_alex    := id_user FROM Users WHERE username='alex_client';
SELECT @id_elena   := id_user FROM Users WHERE username='elena_client';
SELECT @id_cristi  := id_user FROM Users WHERE username='cristi_client';
SELECT @id_maria   := id_user FROM Users WHERE username='maria_client';
INSERT INTO Clienti (id_client,nume,prenume,telefon,email) VALUES
  (@id_george,'George','Ionescu','0722334455','george.io@example.com'),
  (@id_alex,   'Alexandru','Marin','0745123987','alex.marin@example.com'),
  (@id_elena,  'Elena','Radu','0733001122','elena.radu@example.com'),
  (@id_cristi, 'Cristian','Stancu','0766778899','cristi.stancu@example.com'),
  (@id_maria,  'Maria','Popescu','0712345678','maria.popescu@example.com');

-- Categories
INSERT INTO CategoriiPiese (nume_categorie) VALUES
  ('Motor și Transmisie'),
  ('Frâne și Suspensie'),
  ('Electrică și Aprindere'),
  ('Consumabile și Fluide'),
  ('Roți și Anvelope');

-- Manufacturers
INSERT INTO Producatori (nume_producator) VALUES
  ('Bosch'),    -- 1
  ('Michelin'), -- 2
  ('NGK'),      -- 3
  ('Castrol'),  -- 4
  ('Valeo');    -- 5

-- Auto Parts (toate produsele au acum si producator + id_producator)
INSERT INTO PieseAuto 
  (denumire,producator,stoc,pret,id_categorie,id_producator)
VALUES
  ('Filtru ulei','Valeo',20,  30.50, 4,5),
  ('Baterie auto Bosch','Bosch',15, 250.00, 3,1),
  ('Anvelopa iarna Michelin','Michelin',12, 400.00, 5,2),
  ('Bujie NGK','NGK',100,  18.75, 3,3),
  ('Discuri frana fata','Valeo',25, 150.00, 2,5),
  ('Placute frana spate','Valeo',30,  80.00, 2,5),
  ('Set stergatoare parbriz','Valeo',40,  45.00, 4,5),
  ('Ulei Castrol 5W-40 4L','Castrol',10, 120.00, 1,4),
  ('Antigel concentrat 1L','Castrol',35,  25.00, 4,4),
  ('Curea de distributie','Valeo',8, 210.00, 1,5);


-- Orders
INSERT INTO Comenzi (id_client, data_comanda, valoare_totala) VALUES
  (@id_maria, '2025-02-10', 350.75),
  (@id_george,'2025-02-11', 120.00),
  (@id_alex,  '2025-02-15', 980.25),
  (@id_maria, '2025-03-01',  75.50),
  (@id_cristi,'2025-03-02',1200.00),
  (@id_elena, '2025-03-05', 450.00),
  (@id_george,'2025-03-10',  60.00);

-- Order Details
INSERT INTO DetaliiComenzi (id_comanda,id_piesa,cantitate,pret_unitar) VALUES
  (1, (SELECT id_piesa FROM PieseAuto WHERE denumire='Ulei Castrol 5W-40 4L'), 2,120.00),
  (2, (SELECT id_piesa FROM PieseAuto WHERE denumire='Filtru ulei'),                1, 30.50),
  (3, (SELECT id_piesa FROM PieseAuto WHERE denumire='Baterie auto Bosch'),         2,250.00),
  (3, (SELECT id_piesa FROM PieseAuto WHERE denumire='Bujie NGK'),                  1, 18.75);

-- Invoices
INSERT INTO Facturi (id_comanda, data_emitere, numar_factura) VALUES
  (1,'2025-02-10','FA001'),
  (2,'2025-02-11','FA002'),
  (3,'2025-02-15','FA003');

-- Complaints
INSERT INTO Reclamatii (id_client, descriere, data_reclamatie) VALUES
  (@id_maria, 'Intarziere livrare piese.',                     '2025-03-12'),
  (@id_george,'Produsul primit nu corespunde specificatiilor.','2025-03-14'),
  (@id_maria, 'Greseala in factura.',                          '2025-03-15'),
  (@id_alex,  'Calitatea pieselor sub asteptari.',             '2025-03-16'),
  (@id_cristi,'Preturi mai mari decat cele afisate initial.',  '2025-03-20');

-- Activity Log
INSERT INTO LogActiuni (id_user,actiune,comanda_sql,data_ora) VALUES
  ((SELECT id_user FROM Users WHERE username='admin'),
   'Adaugare produs','INSERT INTO PieseAuto ...',NOW()),
  ((SELECT id_user FROM Users WHERE username='ion_angajat'),
   'Modificare stoc','UPDATE PieseAuto SET stoc=...',NOW()),
  ((SELECT id_user FROM Users WHERE username='admin'),
   'Stergere client','DELETE FROM Clienti WHERE id_client=...',NOW());

-- Stock History
INSERT INTO IstoricStoc (id_piesa,cantitate,tip_operatie,data_operatie,id_user) VALUES
  ((SELECT id_piesa FROM PieseAuto WHERE denumire='Filtru ulei'),50,'INTRARE','2025-03-01 09:00:00',(SELECT id_user FROM Users WHERE username='admin')),
  ((SELECT id_piesa FROM PieseAuto WHERE denumire='Bujie NGK'),   30,'INTRARE','2025-03-03 10:15:00',(SELECT id_user FROM Users WHERE username='ion_angajat')),
  ((SELECT id_piesa FROM PieseAuto WHERE denumire='Filtru ulei'), -5,'IESIRE', '2025-03-05 14:30:00',(SELECT id_user FROM Users WHERE username='ion_angajat'));

-- XLS Imports
INSERT INTO ImporturiXLS (nume_fisier,data_import,id_user) VALUES
  ('produse_martie.xlsx','2025-03-10 12:00:00',(SELECT id_user FROM Users WHERE username='admin')),
  ('actualizare_stoc_aprilie.xlsx','2025-04-05 09:45:00',(SELECT id_user FROM Users WHERE username='ion_angajat'));

-- Delivery Addresses
INSERT INTO AdreseLivrare (id_client,adresa,oras,judet,cod_postal,tara) VALUES
  (@id_george,'Str. Libertatii 12','Bucuresti','Bucuresti','010123','Romania'),
  (@id_maria, 'Bd. Independentei 45','Cluj-Napoca','Cluj','400123','Romania');
