
SELECT SUM([TotalValue]) AS 'TotalValue', SUM([TotalCost]) AS 'TotalCost' 

FROM [Transaction] 

WHERE [Date] BETWEEN '{0}' AND '{1}' 
