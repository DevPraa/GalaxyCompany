SELECT [rb_Pilot].Id,[FirstName],[LastName],[Id_Airport]
FROM [Galaxy_db].[dbo].[rb_Pilot],rb_Airport
WHERE rb_Pilot.Id_Airport = rb_Airport.Id and rb_Airport.[Name] = 'Международный аэропорт Маккаран'