SELECT T.[Date], T.[DiscountValue],T.[TotalValue], C.[CardNumber],C.[Surname] ,T.[ID]  FROM [Transaction] T
left join  [Customer] C ON  T.[CustomerID] = C.[ID] 
