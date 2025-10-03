# Student management system migration  
This is the first compolsory assigment which have the main foxus of different migration methods (State-based vs Change-based)  
Vecause the two have different pros and cons i have used them both at different times i will point out when in this text.
  
## Initial DB schema  
<img width="1051" height="236" alt="image" src="https://github.com/user-attachments/assets/31d7094f-6c0d-4b4b-8c6c-70bbdc06fdf9" />  
  
## 1. Initial model setup for use entity frame work (state-based)
I first created the inital databae schema Which is seen above the I created the different models for the migrations after wards I use the Entety 
The idea    
## 2. Migration Testing and migraition being aplied.
All migrations is first tested by using the "UseInMemoryDatabase" this is done to not harm or change the already excisting Database.   
Afterward there where used a SQL server for storage.

<img width="217" height="236" alt="image" src="https://github.com/user-attachments/assets/c570d010-d230-4907-a658-9e929bdf47e7" />

## 3. Use EF for DB migration for models tables set up  
Complete the migration for the database setup.    

After the different models are created i use the command  
__dotnet ef migrations add InitialCreate__

To create migration which can be applied to the database by using the command
__dotnet ef database update__

## 4. What do you gain by using Change or State-based  
Change based migration  
Change based migartion is when you want changes with the the chema.  
You could see the migration as smaller pathes the the whole database.  
In the scenario of the student managment system it would be best used when adden tabled for Tearcher or Departments.    
  
State based migrations
Statebased is where you firste write the desired outcome for the schema by the end of the migration.  
The strengt of stabased is it "force" you to design first before you start to create the schema.
  
## Conclusion
By using the Entity framework it enables a user/developer to combine the comcept of object orientated programming.  

