SELECT rb_Aircraft.[Id],rb_Aircraft.[Name]
FROM [Galaxy_db].[dbo].[rb_Aircraft], com_Airport_Aircraft,rb_Airport
WHERE rb_Aircraft.Id = com_Airport_Aircraft.Id_Aircraft 
	and  rb_Airport.Id = com_Airport_Aircraft.Id_Airport 
	and rb_Airport.[Name] = 'Международный аэропорт Денвера'