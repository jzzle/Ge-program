use tool_manangement
CREATE TABLE category
(	tool_cate varchar(50) PRIMARY KEY NOT NULL,
	tool_life int NOT NULL,
	_reparable bit NOT NULL
);
CREATE TABLE tool_inf
(	tool_id varchar(50) PRIMARY KEY NOT NULL,
	tool_cate varchar(50) FOREIGN KEY REFERENCES category(tool_cate) NOT NULL,
	tool_status varchar(20) NOT NULL check(tool_status='RETURNED'OR tool_status='BROKEN'OR tool_status='LOST'),
	tool_intro_date date NOT NULL
);
CREATE TABLE engineer
(	eng_id varchar(50) PRIMARY KEY NOT NULL,
	eng_name varchar(100) NOT NULL,
	eng_phonenum varchar(20) UNIQUE
);
CREATE TABLE tool_lend
(	eng_id varchar(50) FOREIGN KEY REFERENCES engineer(eng_id)NOT NULL,
	tool_id varchar(50) FOREIGN KEY REFERENCES tool_inf(tool_id)NOT NULL,
	lend_date smalldatetime NOT NULL
	PRIMARY KEY(eng_id,tool_id,lend_date)
);
CREATE TABLE tool_repair
(	eng_id varchar(50) FOREIGN KEY REFERENCES engineer(eng_id)NOT NULL,
	tool_id varchar(50) FOREIGN KEY REFERENCES tool_inf(tool_id)NOT NULL,
	repair_date smalldatetime NOT NULL
	PRIMARY KEY(eng_id,tool_id,repair_date)
);


