create database Contatos;
use contatos;

create table Usuario(
idUsuario int primary key not null auto_increment,
login varchar(45) not null unique,
nome varchar(45) not null,
senha varchar(60) not null,
salt varchar(29) not null
);

create table Contato(
idContato int primary key not null auto_increment,
nome varchar(45) not null,
sobrenome varchar(45) not null,
idUsuario int not null,
foreign key (idUsuario) references Usuario (idUsuario)
);

create table TipoCOntato(
idTipoContato int primary key not null auto_increment,
tipo varchar(45) not null unique,
decricao varchar(45)
);

create table EnderecoContato(
idEnderecoContato int primary key not null auto_increment,
valor varchar(45) not null,
principal tinyint not null,
observacao varchar(45),
idTipoContato int not null,
idContato int not null,
foreign key (idTipoContato) references TipoContato (idTipoContato),
foreign key (idContato) references Contato (idContato)
);

