 CREATE DATABASE dbpro73
ON PRIMARY
(
NAME=dbsutstore_DAT,
FILENAME='C:\pro73\dbpro73.mdf',
SIZE=4,
MAXSIZE=20,
FILEGROWTH=1
)
LOG ON
(
NAME= dbsutstore_LOG,
FILENAME='C:\pro73\dbpro73 .ldf',
SIZE=2,
MAXSIZE=5,
FILEGROWTH=1
)


CREATE TABLE staffs (
    staffs_id char(4) not null,
    staffs_name nvarchar(60) null,
    staffs_address nvarchar(50) null,
    staffs_tel nvarchar(20) null,
    staffs_birth datetime null,
    staffs_sex nvarchar(6) null,
    staffs_nin nvarchar(11) null,
    staffs_position nvarchar(30) null,
    staffs_current int null,
    staffs_scale nvarchar(11) null,
    qualifacation_type nvarchar(50) null,
    qualifacation_date datetime null,
    qualifacation_ins nvarchar(40) null,
    workexp_position nvarchar(30) null,
	workexp_startdate datetime null,
    workexp_finishdate datetime null,
	name_ogn nvarchar(60) null,
    workexp_surgury nvarchar(30) null,

    constraint s_id_PK primary key (staffs_id)
)

CREATE TABLE workexp (
    workexp_id char(4) not null,
	staffs_id char(4)  null,
	workexp_position nvarchar(30) null,
	workexp_startdate datetime null,
    workexp_finishdate datetime null,
	name_ogn nvarchar(60) null,
    workexp_surgury nvarchar(30) null,

    constraint wx_id_PK primary key (workexp_id),
	constraint s_id_FK1 foreign key (staffs_id) references staffs (staffs_id)
)
CREATE TABLE qualifacation (
    qualifacation_id char(4) not null,
	staffs_id char(4)  null,
	qualifacation_type nvarchar(50) null,
    qualifacation_date datetime null,
    qualifacation_ins nvarchar(40) null,

    constraint q_id_PK primary key (qualifacation_id),
	constraint s_id_FK2 foreign key (staffs_id) references staffs (staffs_id)
)

CREATE TABLE wards (
    wards_id char(4) not null,
	wards_name nvarchar(60) null,
    wards_location nvarchar(60) null,
    wards_tel int null,

    constraint w_id_PK primary key (wards_id)
)


CREATE TABLE shifts (
    shifts nvarchar(10) null,
	startdate datetime null,
    staffs_id char(4) not null,
	wards_id char(4) null,

	primary key (staffs_id),
	constraint s_id_FK foreign key (staffs_id) references staffs (staffs_id),
	constraint w_id_FK foreign key (wards_id) references wards (wards_id)

)

CREATE TABLE clinic (
    clinic_ID char(4)  not null,
    ldoc_name nvarchar(60) null,
    ldoc_tel nvarchar(20) null,
    ldoc_address nvarchar(60) null,

    constraint c_id_PK primary key (clinic_ID)
)


CREATE TABLE patients (
    patients_id char(4) not null,
    patients_name nvarchar(60) null,
    patients_birth datetime null,
	patients_sex nvarchar(6) null,
    patients_address nvarchar(60) null,   
    patients_tel nvarchar(20) null,
	patients_Dateregistered datetime null,
	patients_Status nvarchar(10) null,
    k_name nvarchar(60) null,
    k_tel nvarchar(20) null,
    k_address nvarchar(60) null,
    k_relationship nvarchar(30) null,
	clinic_ID char(4)  null,

    constraint p_id_PK primary key (patients_id),
	constraint c_id_PK1 foreign key (clinic_ID) references clinic (clinic_ID)
)



CREATE TABLE IN_patients (
    patients_id char(4) not null,
	wards_id char(4)  null,
    On_WaitingList datetime null,
    Expectedstay int null,
    date_placed datetime null,
    date_leave datetime null,
    actual_leave datetime Null,
    bed_number char(4) null,

	primary key (patients_id),
	constraint w_id2_FK foreign key (wards_id) 
	references wards (wards_id),
    constraint p_id2_FK foreign key (patients_id) 
	references patients (patients_id)
)


CREATE TABLE medications (
    medications_id char(4) Not null,
    medications_name nvarchar(60)  null,
	dosage nvarchar(60)  null,
	method_of_Admin text  null,
    unit_per_day nvarchar(60)  null,
    startdate datetime  null,
    finishdate datetime  null,

	constraint medications_id_PK primary key (medications_id),
)



CREATE TABLE treatment(
    treatment_id  int IDENTITY(01, 1)  not null,
	staffs_id char(4) not null,
	medications_id char(4)  null,
    patients_id char(4) null,
	quantity  int null,
	treatmentdate datetime   DEFAULT current_timestamp

	constraint t_id_PK primary key (treatment_id),
)



CREATE TABLE suppiles (
    suppiles_id char(4) Not null,
    drug_name nvarchar(60)  null,
    drug_costperunit int  null,
    drug_dosage int  null,
    drug_reorder_level nvarchar(60)  null,
    drug_quantity_in_stock int  null,
    drug_desc text  null,
    drug_method text  null,

	constraint drug_id_PK primary key (suppiles_id)

)



CREATE TABLE suppilers (
    sup_id char(4) Not null,
    sup_name nvarchar(60)  null,
    sup_fax_number char(4)  null,
    sup_tel nvarchar(20)  null,
    sup_address nvarchar(60)  null,

    constraint sup_id_PK primary key (sup_id)

)



CREATE TABLE requisitions (
    requisitions_id nvarchar(20) Not null,
	wards_name nvarchar(60)  null,
    requisitions_date datetime  null,
    staffs_name nvarchar(60)  null,
    drug_id char(4)  null,
    drug_name nvarchar(60)  null,
    drug_description text  null,
    drug_dosage nvarchar(60)  null,
    drug_method text  null,
    drug_costperunit int  null,
    quantity_required int  null,


    constraint r2_id_PK primary key (requisitions_id),

)

CREATE view View_patientsS
as
SELECT        dbo.patients.patients_id, dbo.patients.patients_name, dbo.patients.patients_birth, dbo.patients.patients_sex, dbo.patients.patients_address, dbo.patients.patients_tel, dbo.patients.patients_Dateregistered, 
                         dbo.patients.patients_Status, dbo.patients.k_name, dbo.patients.k_tel, dbo.patients.k_address, dbo.patients.k_relationship, dbo.patients.clinic_ID, dbo.clinic.ldoc_name, dbo.clinic.ldoc_tel, dbo.clinic.ldoc_address
FROM            dbo.patients INNER JOIN
                         dbo.clinic ON dbo.patients.clinic_ID = dbo.clinic.clinic_ID

CREATE view View_Shifts
as
SELECT        dbo.shifts.staffs_id, dbo.staffs.staffs_name, dbo.staffs.staffs_position, dbo.shifts.wards_id, dbo.wards.wards_name, dbo.shifts.shifts, dbo.shifts.startdate
FROM            dbo.shifts INNER JOIN
                         dbo.staffs ON dbo.shifts.staffs_id = dbo.staffs.staffs_id INNER JOIN
                         dbo.wards ON dbo.shifts.wards_id = dbo.wards.wards_id


CREATE view View_staffsS
as
SELECT        dbo.staffs.staffs_id, dbo.staffs.staffs_name, dbo.staffs.staffs_address, dbo.staffs.staffs_tel, dbo.staffs.staffs_birth, dbo.staffs.staffs_sex, dbo.staffs.staffs_nin, dbo.staffs.staffs_position, dbo.staffs.staffs_current, 
                         dbo.staffs.staffs_scale, dbo.qualifacation.qualifacation_type, dbo.qualifacation.qualifacation_date, dbo.qualifacation.qualifacation_ins, dbo.workexp.workexp_position, dbo.workexp.workexp_startdate, 
                         dbo.workexp.workexp_finishdate, dbo.workexp.name_ogn, dbo.workexp.workexp_surgury
FROM            dbo.staffs INNER JOIN
                         dbo.qualifacation ON dbo.staffs.staffs_id = dbo.qualifacation.staffs_id INNER JOIN
                         dbo.workexp ON dbo.staffs.staffs_id = dbo.workexp.staffs_id


CREATE view View_staffsS
as
SELECT        dbo.treatment.staffs_id, dbo.staffs.staffs_name, dbo.treatment.patients_id, dbo.patients.patients_name, dbo.treatment.medications_id, dbo.medications.medications_name, dbo.treatment.quantity, 
                         dbo.treatment.treatmentdate
FROM            dbo.treatment INNER JOIN
                         dbo.patients ON dbo.treatment.patients_id = dbo.patients.patients_id INNER JOIN
                         dbo.staffs ON dbo.treatment.staffs_id = dbo.staffs.staffs_id INNER JOIN
                         dbo.medications ON dbo.treatment.medications_id = dbo.medications.medications_id




