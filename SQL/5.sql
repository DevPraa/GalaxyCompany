SELECT rb_Pilot.[Id],[FirstName],[LastName],[Id_Airport]
FROM [Galaxy_db].[dbo].[rb_Pilot], com_Pilot_Aircraft, rb_Aircraft
WHERE rb_Aircraft.Id = com_Pilot_Aircraft.Id_Aircraft 
	and  rb_Pilot.Id = com_Pilot_Aircraft.Id_Pilot 
	and rb_Aircraft.[Name] = 'Saab 340'