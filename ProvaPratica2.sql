-- DML INSERT

INSERT INTO dbo.tb_condominio
VALUES
(1, 'Serra Negra', 'Vila Nova'),
(2, 'Casa Branca','Moema'),
(3, 'Bom Recanto','Vila Guarani'),
(4, 'Imaré','Capuava'),
(5, 'Andorinha','Jardim América');

INSERT INTO dbo.tb_morador
VALUES
(1,1,'Valmir',65),
(2,3,'Lúcia',27),
(3,2,'Marcelo',35),
(4,2,'Irene',78),
(5,5,'Marta',31),
(6,11,'Alberto',56),
(7,8,'Lucas',10),
(8,4,'Maria',25),
(9,9,'Mateus',5),
(10,10,'Julia',9),
(11,5,'Bernardo',2),
(12,7,'Rosa',18),
(13,3,'Helena',23),
(14,1,'Willian',15),
(15,1,'José',42),
(16,3,'Priscila',13),
(17,7,'Amanda',29),
(18,5,'Guilherme',22),
(19,4,'Roberta',2),
(20,4,'Ricardo',30),
(21,6,'Giovane',81),
(22,6,'Flavia',11),
(23,11,'Fabiana',43),
(24,8,'Marcio',20),
(25,7,'Roberto',1),
(26,9,'Marcos',4),
(27,4,'Rafael',3),
(28,10,'Bruna',1);

INSERT INTO dbo.tb_familia
VALUES
(1,'Silva',2,10),
(2,'Novaes',2,45),
(3,'Nobrega',4,110),
(4,'Campineli',1,712),
(5,'Souza',1,715),
(6,'Gonçalves',3,640),
(7,'Camargo',3,301),
(8,'Brito',5,507),
(9,'Oliveira',3,10),
(10,'Jovanelli',4,507),
(11,'Vieira',5,310);


select * from tb_condominio
select * from tb_familia
select * from tb_morador


SELECT
    tc.nome as 'Condomínio',
    COUNT(*) as Quantidade
FROM tb_condominio tc
JOIN tb_familia tf ON tc.id = tf.FK_condominio
JOIN tb_morador tm on tm.FK_familia = tf.id
WHERE tm.Idade >= 50
GROUP BY tc.nome

SELECT * FROM  tb_morador
WHERE tb_morador.Idade >= 50

SELECT
    tm.nome AS Pessoa,
    tf.nome AS Familia,
    tc.nome AS Condominio
FROM tb_morador tm
JOIN tb_familia tf ON tf.id = tm.FK_familia
JOIN tb_condominio tc ON tc.id = tf.FK_condominio

SELECT
    tc.bairro as 'Bairro',
    AVG(tm.idade) as 'Média Idade'
FROM tb_condominio tc
JOIN tb_familia tf ON tc.id = tf.FK_condominio
JOIN tb_morador tm on tm.FK_familia = tf.id
GROUP BY tc.bairro

ALTER TABLE tb_condominio
ADD areaTotal decimal(18,2);

ALTER TABLE tb_condominio
ADD valorIPTU decimal(18,2);

ALTER TABLE tb_familia
ADD areaAPTO decimal(18,2);

ALTER TABLE tb_familia
ADD IPTUprop decimal(18,2);

ALTER TABLE tb_familia
ADD fracaoIdeal decimal(18,2);
