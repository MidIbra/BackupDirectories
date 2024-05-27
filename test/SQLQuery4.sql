SELECT NomeCliente, Indirizzo, Nazione, DataOrdine
FROM ((Clienti
FULL JOIN Ordini ON Clienti.ID_Cliente=Ordini.ID_Cliente))
WHERE NomeCliente LIKE 'a%' AND Nazione='Messico'
ORDER BY Indirizzo DESC