
SELECT c.ID, c.RazaoSocial, t.Numero
FROM Cliente c
JOIN Endereco e ON c.ID = e.ClienteID
JOIN Telefone t ON c.ID = t.ClienteID
JOIN Estado es ON e.EstadoID = es.ID
WHERE es.Nome = 'SP';
