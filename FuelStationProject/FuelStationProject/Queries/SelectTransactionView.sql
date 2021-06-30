SELECT T.[Date], T.[DiscountValue],T.[TotalValue], C.[CardNumber],C.[Surname] ,T.[ID]  FROM [Transaction] T
left join  [Customer] C on  T.[CustomerID] = C.[ID] 
