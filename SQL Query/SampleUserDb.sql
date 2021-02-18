
Create database SampleLoginDb 

use SampleLoginDb

CREATE TABLE Users(id INTEGER PRIMARY KEY, FirstName VARCHAR(20) , LastName VARCHAR(20), Place VARCHAR(20));

INSERT INTO Users VALUES(101 , 'Akhil' , 'Mohan' , 'Erode' ),  
						(102 , 'Arjun' , 'Kumar' , 'Chennai' ),
						(103 , 'Ram' , 'Sai' , 'Bangalore' ),
						(104 , 'Bala' , 'Das' , 'Hyderabad' ),
						(105 , 'Raj' , 'Kumar' , 'Kochi' ) 

select * from Users