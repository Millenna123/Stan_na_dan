create database Stan_na_dan;
use Stan_na_dan;

create table Osoba(
id int primary key identity(1,1),
email varchar(50) not null,
lozinka varchar(30) not null,
ime varchar(20) not null,
prezime varchar(50) not null,
uloga_id int not null
);

create table Stan(
id int primary key identity(1,1),
adresa varchar(100) not null,
broj_stana int not null,
broj_kreveta int
);

create table Rezervacija(
id int primary key identity(1,1),
osoba_id int foreign key references Osoba(id),
stan_id int foreign key references Stan(id),
datum_pocetak date not null,
datum_kraj date not null
);

create table Cena(
id int primary key identity(1,1),
stan_id int foreign key references Stan(id),
datum date not null,
cena_po_danu int not null
);

insert into Osoba values('milenarakita@z.com', 'milena003', 'Milena', 'Rakita', 2);
insert into Osoba values('tanjasavic@k.com', 'tanja1', 'Tanja', 'Savic', 1);
insert into Osoba values('lenadimitrijevic@k.com', '1234', 'Lena', 'Dimitrijevic', 1);
insert into Osoba values('irenapopin@k.com', 'popin25', 'Irena', 'Popin', 1);
select * from Osoba;

insert into stan values('Cara Dusana 11', 37, 2);
insert into stan values('Cara Dusana 11', 41, 4);
insert into stan values('Ruzveltova 25', 12, 1);
insert into stan values('Ruzveltova 25', 21, 3);
select * from stan;

insert into cena values(1, '2022-05-25', 35);
insert into cena values(1, '2022-05-26', 35);
insert into cena values(1, '2022-05-27', 40);
select * from cena;

create procedure rezervacija_dodaj
@osoba_id int,
@stan_id int,
@datum_pocetak date,
@datum_kraj date
as
begin
  if(exists(select top 1 id from rezervacija where osoba_id = @osoba_id)) return -2;
  begin
    if(exists(select top 1 id from rezervacija where stan_id = @stan_id and (@datum_pocetak >= datum_pocetak and @datum_pocetak <= datum_kraj) or (@datum_kraj >= datum_pocetak and @datum_kraj <= datum_kraj))) return -1;
    begin
      insert into rezervacija values (@osoba_id, @stan_id, @datum_pocetak, @datum_kraj);
      return 0;
    end;
  end;
end;

create procedure cena_dodaj
@stan_id int,
@datum date,
@cena_po_danu int
as
begin
  if(exists(select top 1 id from cena where stan_id = @stan_id and datum = @datum)) return -1;
  begin
  insert into cena values(@stan_id, @datum, @cena_po_danu);
  return 0;
  end;
end;