-- associates per state
select count(id) as "Associate Count", associatelocale as "Associate Locale"
from associates 
group by associatelocale 
order by count(id) desc; 

-- select statment examples
select * from batch;

select * from associates full join batch 
on associates.id = batch.associateid;
select trainername, count(associateid) from trainers 
full join batch on batch.trainerid = trainers.id 
group by trainername
order by count(associateid) desc;

-- cross join
select associatename, trainername from associates cross join trainers;

--getting trainers not in batch
select trainername from trainers full join batch
on batch.trainerid = trainers.id
where trainerid is null;

select trainername from trainers
EXCEPT
select trainername from trainers inner join batch on
batch.trainerid = trainers.id;

select trainername from trainers
where id not in (select trainerid from batch);

-- getting associates not in batch
select associatename from associates  full join batch
on batch.associateid = associates.id
where associateid is null;

select associatename from associates
EXCEPT
select associatename from associates inner join batch on
batch.associateid = associates.id;

select associatename from associates
where id not in (select associateid from batch);

select count(id) as "No. of trainers", campus from
trainers 
group by campus
order by count(id) desc;

-- all assoc mapped to trainer
--join

select associatename, trainername from associates inner join batch
on batch.associateid = associates.id
inner join trainers 
on trainers.id = batch.trainerid;

-- set operation
select associatename from associates
INTERSECT
select associatename from associates inner join batch
on batch.associateid = associates.id;

-- subquery
select associatename from associates where id
in (select associateid from batch);

-- getting trainers from a certain state
select trainername from trainers where campus = 'USF';