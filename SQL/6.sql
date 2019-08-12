SELECT [Name], COUNT(t2.Id_Airport)
  FROM [Galaxy_db].[dbo].[rb_Airport] t1
  INNER JOIN rb_Pilot t2 on t1.Id=t2.Id_Airport
  GROUP BY (t1.[Name])
  HAVING COUNT(t2.Id_Airport) >2