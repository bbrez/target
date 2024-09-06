tabela UF
---------
PK idUF INT
nomeUF VARCHAR
siglaUF VARCHAR


tabela cliente
--------------
PK idCliente INT
nomeCliente VARCHAR
razaoSocialCliente VARCHAR
FK idUF INT


tabela tipoTelefone
-------------------
PK idTipoTelefone INT
nomeTipoTelefone VARCHAR


tabela telefone
---------------
PK idTelefone INT
dddTelefone VARCHAR
numTelefone VARCHAR
FK idTipoTelefone INT
FK idCliente INT


select nomeCliente,razaoSocialCliente,numTelefone
from cliente
join telefone t on t.idCliente = idCliente
join UF u on u.idUF = idUF
where u.siglaUF = 'SP'