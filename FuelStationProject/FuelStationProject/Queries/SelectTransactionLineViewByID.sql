SELECT I.[Description], I.[ItemType],T.[Quantity], T.[ItemPrice],T.[Value] ,T.[ID] ,I.[Cost] FROM [Item] I 
left join  [TransactionLine] T ON  I.[ID] = T.[ItemID] 
WHERE T.[TransactionID]='{0}'
