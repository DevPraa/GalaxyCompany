SELECT TOP (1000) rb_Aircraft.[Id] ,rb_Aircraft.[Name]
FROM [Galaxy_db].[dbo].[rb_Aircraft], com_Pilot_Aircraft,rb_Pilot
WHERE rb_Aircraft.Id = com_Pilot_Aircraft.Id_Aircraft 
	and rb_Pilot.Id = com_Pilot_Aircraft.Id_Pilot 
	and rb_Pilot.FirstName = 'Гарольд'