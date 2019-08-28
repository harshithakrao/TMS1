create database tmsdb

use tmsdb

create table TM_VehicleDetails
(veh_id int primary key identity(100,1),
veh_type varchar(20) not null,
engine_no varchar(10) unique,
model_no varchar(10) not null,
veh_name varchar(20) not null,
veh_color varchar(20),
manufacturer_name varchar(20) not null,
date_of_manufacture date not null,
no_of_cylinders int,
cubic_capacity int,
fuel_used varchar(10))

create table TM_OwnerDetails
(owner_id varchar(10) primary key,
fname varchar(20) not null,
lname varchar(20) not null,
date_of_birth varchar(10) not null,
landline_number bigint,
mobile_no bigint,
gender varchar(6) not null,
temp_address varchar(200),
permanent_address varchar(200) not null,
pincode bigint not null,
occupation varchar(30),
pancard_no varchar(20) not null,
addressproof_name varchar(20) not null)

create table TM_RegDetails
(appl_no int primary key identity(1,1),
veh_no varchar(10) unique,
veh_id int foreign key references TM_VehicleDetails(veh_id),
owner_id varchar(10) foreign key references TM_OwnerDetails(owner_id),
date_of_purchase datetime not null,
distributer_name varchar(20) not null)

drop table 

create table TM_Offence
(offence_id int primary key identity(10,1),
offence_type varchar(20) unique ,
veh_type varchar(20) not null ,
penalty int not null)

create table Offence_Details
(veh_no varchar(10) foreign key references TM_RegDetails(veh_no),
time datetime not null,
place varchar(30) not null,
offence_id int foreign key references TM_Offence(offence_id),
reported_by varchar(30) not null)

create table TM_UserMaster
(username varchar(20) primary key, 
password varchar(20) not null, 
rolename varchar(20) not null)
