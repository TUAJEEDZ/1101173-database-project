-- Table staffs --

INSERT INTO staffs
VALUES ('S003', 'Kittanai Chaichana', '105/449 surasawatland suranaree ','0957454575','2001-10-10','male','WB550123A','Charge Nurse','20000','1a');
INSERT INTO staffs
VALUES ('S105','Yuranan Keawma','2/218 maroi kheang-khoi','0819062545','1999-02-22','male','WB852846B','Nurse','15000','1d');
INSERT INTO staffs
VALUES ('S229','sasi punpuem',' 89 Sermsinkha Road Chakkawad','0348482634','1992-11-11','female','WB291485C','Staff Nurse','14000','1e');
INSERT INTO staffs
VALUES ('S024','nawapron fahsai',' 54/1 Sutat Road','0271120896','1984-12-17','female','WB010408t','Staff Nurse','14000','1e');
INSERT INTO staffs
VALUES ('S113','Sirapat sungthong','6/41 tandew saraburi','0448520091','2002-01-01','male','WB452854B','Nurse','15000','1d');

-- Table workexp --

INSERT INTO workexp
Values ('3562','S003','Staff Nurse','2020-09-20','2021-01-12','kasemrad hospital','No experience');
INSERT INTO workexp
Values ('4127','S105','Staff Nurse','2018-06-06','2018-10-15','kheang-khoi hospital','No experience');
INSERT INTO workexp
Values ('6852','S229','Staff Nurse','2012-10-10','2013-1-15','Phra Nang Klao Hospital','Penis experience');
INSERT INTO workexp
Values ('3584','S024','Staff Nurse','2005-07-10','2005-10-22','Khon Kaen Hospital','Leg experience');
INSERT INTO workexp
Values ('6785','S113','Staff Nurse','2019-01-20','2019-04-27','Small bear Hospital','arm experience');

-- Table qualifacation --

INSERT INTO qualifacation
Values ('7954','S113','Std Nursing Studies','2017-12-02','Bangkok University');
INSERT INTO qualifacation
Values ('4426','S024','Basic Nursing Studies','2004-08-08','chiang mai University');
INSERT INTO qualifacation
Values ('5425','S229','Adv Nursing Studies','1992-11-11','chiang mai University');
INSERT INTO qualifacation
Values ('7894','S105','BSc Nursing Studies','2015-08-08','chiang mai University');
INSERT INTO qualifacation
Values ('0125','S003','BSc Nursing Studies','2017-04-06','Suranaree University')

-- Table clinic --

INSERT INTO clinic
VALUES ('1104','anon thanom','0861910928','470 Soi Pattanakarn 44');
INSERT INTO clinic
VALUES ('1539','Darika Thaugsuban','0272146788','248/2-3 Ratchadapisek Road');
INSERT INTO clinic
VALUES ('0895','Dolsook Keacham','0624207341','40/3-5 Suwinthavong Bang Chan');
INSERT INTO clinic
VALUES ('1106','Treewit Patanapreecha ','0289514220','769/19-21 Prachachuen Road')
INSERT INTO clinic
VALUES ('1100','Watcharin Sompong ','0867532525','279/5 Suraaree Road')

-- Table patients --

INSERT INTO patients
VALUES ('P123',' kaiyang wician','1978-5-25','male','33/3 Moo 1 Soi Chaengwatana-Pakkret 45 Chaengwatana','0830799186','2001-10-31'
,'married','mootod wician','0243917427','33/3 Moo 1 Soi Chaengwatana-Pakkret 45 Chaengwatana',' wife','1104');
INSERT INTO patients
VALUES ('P368','chomkwan temirak','2007-06-22','female','Phraek Sa, Muang Samutprakarn','0898195233','2016-04-26'
,'single','mechai temirak','0818391829','Phraek Sa, Muang Samutprakarn','father','1539');
INSERT INTO patients
VALUES ('P094','thanabodi pomthong','2002-04-07','male','9/7 Soi 33 Sukhumvit Road','0624682219','2018-03-17'
,'single','pat eiei','0625855542','9/7 Soi 33 Sukhumvit Road','brother','0895');
INSERT INTO patients
VALUES ('P055','panuwat kongam','1983-08-30','male','Wat Kalaya Thon Buri','0622517821','2015-10-04'
,'married','jirapat kongam','0627143182','Wat Kalaya Thon Buri','son','1104','Treewit Patanapreecha ','0289514220','769/19-21 Prachachuen Road');
INSERT INTO patients
VALUES ('P248','yanisa buakeaw','2001-11-23','female','816 Pracha Uthit Rd.','0622224707','2022-05-02'
,'single','therapa buakeaw','0622510213','816 Pracha Uthit Rd','sister','1104');

-- Table wards --

INSERT INTO wards
VALUES ('1101','ศัลยกรรม','อาคาร 1 ชั้น 2','2012');
INSERT INTO wards
VALUES ('1003','ศัลยกรรมกระดูก','อาคาร 1 ชั้น 3','2203');
INSERT INTO wards
VALUES ('1001', 'แผนกผู้ป่วยนอก', 'อาคารผู้ป่วยนอก','1001');
INSERT INTO wards
VALUES ('1020', 'ห้องฉุกเฉิน', 'อาคาร 1 ชั้น 1','9119');
INSERT INTO wards
VALUES ('1070', 'ทันตกรรม', 'อาคาร 1 ชั้น 4','6458');

-- Table wards --

INSERT INTO shifts
VALUES ('บ่าย','2018-10-06','S003','1101');
INSERT INTO shifts
VALUES ('เช้า','2023-01-08','S024','1003');
INSERT INTO shifts
VALUES ('ดึก','2016-07-30','S229','1001');
INSERT INTO shifts
VALUES ('เช้า','2020-12-20','S105','1020');
INSERT INTO shifts
VALUES ('เช้า','2019-11-29','S113','1101');




