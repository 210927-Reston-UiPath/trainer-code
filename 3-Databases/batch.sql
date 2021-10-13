-- note that SQL is not case sensitive, it is case insensitive for keywords 
-- doesn't really care if I create a table via CREATE TABLE, create table, cReAte TaBlE
create table associates 
(
    associateName varchar(100) not null,
    associateLocale varchar(2) not null,
    revaPoints int not null,
    id serial primary key
);

create table trainers
(
    id serial primary key,
    trainerName varchar(100) not null,
    campus varchar(3) not null,
    caffeineLevel int not null
);

create table batch 
(
    id serial primary KEY,
    associateID int REFERENCES associates(id),
    trainerID int references trainers(id)
);

insert into associates (associateName, associateLocale, revaPoints) values 
('Ai', 'CA', -20), ('Osiris', 'CA', -20), ('Jacob', 'FL', 50),  ('Janel', 'AZ', 50), ('Colton', 'OK', -180), ('Niles', 'AL', 200), ('Timothy', 'CT', -20), ('Aaron', 'RI', 200);
insert into trainers (trainerName, campus, caffeineLevel) values
('Marielle', 'USF', 60), ('Pushpinder', 'UTA', 50), ('Nick', 'UTA', 75), ('Mark', 'WVU', 16), ('Fred', 'UTA', 25), ('Juniper', 'USF', 197);
insert into batch (associateID, trainerID) values
(1,5), (2,3), (5,5), (6,1),(7, 4), (8,1);

