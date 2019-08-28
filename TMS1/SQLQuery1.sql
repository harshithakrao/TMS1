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

