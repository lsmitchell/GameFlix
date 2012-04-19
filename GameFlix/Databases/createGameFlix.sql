DROP DATABASE IF EXISTS gameflix;
CREATE DATABASE gameflix;
USE gameflix;

CREATE TABLE PERSON(
  ID		INT NOT NULL, 
  First_Name	VARCHAR(20),
  Last_Name	VARCHAR(20),
  Address	VARCHAR(50),
  City		VARCHAR(50),
  State		CHAR(2),
  Zip		VARCHAR(10),
  birth_date	DATE,
  Phone		VARCHAR(15),
  Email		VARCHAR(50),
  constraint person_ID_pk PRIMARY KEY (ID)
);

CREATE TABLE CUSTOMER(
  ID	INT NOT NULL,
  constraint customer_ID_pk PRIMARY KEY (ID),
  constraint customer_ID_fk FOREIGN KEY (ID) REFERENCES PERSON(ID)
);

CREATE TABLE EMPLOYEE(
  ID		INT NOT NULL,
  HireDate	DATE,
  constraint employee_ID_pk PRIMARY KEY (ID),
  constraint employee_ID_fk FOREIGN KEY (ID) REFERENCES PERSON(ID)
);

CREATE TABLE MANAGER(
  ID	INT NOT NULL,
  constraint manager_ID_pk PRIMARY KEY (ID),
  constraint manager_ID_fk FOREIGN KEY (ID) REFERENCES EMPLOYEE(ID)
);

CREATE TABLE MEDIA(
  ID		VARCHAR(10) NOT NULL,
  Title		VARCHAR(50),
  Type		VARCHAR(5),
  Rating	VARCHAR(5),
  Genre		VARCHAR(50),
  Summary	VARCHAR(200),
  System	VARCHAR(15),
  isRented	CHAR(1),
  constraint media_ID_pk PRIMARY KEY (ID)
);

CREATE TABLE RENTAL_QUEUE(
  ID		INT NOT NULL,
  CustomerID	INT NOT NULL,
  MediaID	VARCHAR(10) NOT NULL,
  constraint rental_queue_ID_CustomerID_MediaID_pk PRIMARY KEY (ID, CustomerID, MediaID),
  constraint rental_queue_CustomerID_fk FOREIGN KEY (CustomerID) REFERENCES CUSTOMER(ID),
  constraint rental_queue_MediaID_fk FOREIGN KEY (MediaID) REFERENCES MEDIA(ID)
);

INSERT INTO PERSON VALUES(1, 'Jonathan', 'Andrews', '37 Sugarbush Lane', 'Pittsford', 'NY', '14534', '1980-01-04', '585-123-4567', 'jandrews@mail.com');
INSERT INTO PERSON VALUES(2, 'Adam', 'Mason', '42 Jacobson Drive', 'Fairport', 'NY', '14450', '1980-06-14', '585-234-5678', 'amason@mail.com');
INSERT INTO PERSON VALUES(3, 'Sara', 'Delaney', '1313 Mockingbird Lane', 'Rochester', 'NY', '14623', '1980-10-24', '585-345-6789', 'sdelaney@mail.com');
INSERT INTO PERSON VALUES(4, 'Charles', 'Wilson', '939 Delaware Avenue', 'Pittsford', 'NY', '14534', '1981-03-07', '585-456-7890', 'cwilson@mail.com');
INSERT INTO PERSON VALUES(5, 'Michael', 'DiMuzzio', '88 Riverside Drive', 'Penfield', 'NY', '14623', '1979-06-30', '585-567-8901', 'mdimuzzio@mail.com');
INSERT INTO PERSON VALUES(6, 'Amanda', 'Miller', '62 Deek Creek Road', 'Pittsford', 'NY', '14534', '1980-04-17', '585-678-9012', 'amiller@mail.com');

INSERT INTO CUSTOMER VALUES(1);
INSERT INTO CUSTOMER VALUES(2);

INSERT INTO EMPLOYEE VALUES(3, '2006-07-21');
INSERT INTO EMPLOYEE VALUES(4, '2007-05-14');
INSERT INTO EMPLOYEE VALUES(5, '2008-09-30');
INSERT INTO EMPLOYEE VALUES(6, '2009-12-01');

INSERT INTO MANAGER VALUES(3);
INSERT INTO MANAGER VALUES(4);

INSERT INTO MEDIA VALUES('0001MV', 'Notting Hill', 'Movie', 'PG-13', 'Romantic Comedy', 'The life of a simple bookshop owner changes when he meets the most famous film star in the world.', '', 'n');
INSERT INTO MEDIA VALUES('0002MV', 'Aliens', 'Movie', 'R', 'Sci-Fi', 'Lt. Ripley finds her horrific account of her crew\'s fate is met with skepticism - until the disappearance of the colonists proves her worst fears have come true.', '', 'n');
INSERT INTO MEDIA VALUES('0003MV', 'Die Hard', 'Movie', 'R', 'Action', 'McClane sets out to single-handedly rescue hostages and take down terrorists.', '', 'n');
INSERT INTO MEDIA VALUES('0004MV', 'The Hand That Rocks the Cradle', 'Movie', 'R', 'Drama', 'A family chooses a sweet girl to be the baby\'s nanny - only to find her true intentions are to destroy the wife and take her place in the family.', '', 'n');
INSERT INTO MEDIA VALUES('0001GM', 'Uncharted 2', 'Game', 'M', 'Action', 'Down on his luck, Drake is lured back into the treacherous world of theives and mercenaries he sought to leave behind.', 'PlayStation 3', 'n');
INSERT INTO MEDIA VALUES('0002GM', 'Rayman Raving Rabbids', 'Game', 'E', 'Adventure', 'Rayman must dethrone demonic rabbit delinquents as they threaten to devastate his dream world.', 'Wii', 'n');
INSERT INTO MEDIA VALUES('0003GM', 'Assassin\'s Creed 2', 'Game', 'M', 'Adventure', 'The world of the assassin is one cloaked in shadow and steeped in danger.', 'XBox 360', 'n');
INSERT INTO MEDIA VALUES('0004GM', 'Bioshock 2', 'Game', 'M', 'First-Person Shooter', 'The underwater city, Rapture, is failing, and must fight for survival.', 'PC', 'n');