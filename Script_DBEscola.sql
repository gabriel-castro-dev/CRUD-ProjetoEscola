create database DBEscola;

use DBEscola;

create table tblAlunos(
   id int not null primary key auto_increment,
   nome varchar(50) not null,
   idade int not null,
   unidade char(1) not null,
   serie int not null,
   turma char(1) not null
);
