create database Empresax2a_bd;
use Empresax2a_bd;

create table Funcionario(
id_fun integer primary key auto_increment,
nome_fun varchar(100),
data_nascimento_fun date,
cpf_fun varchar(20),
rg_fun varchar(20),
telefone_fun varchar(50),
email_fun varchar(100),
rua_fun varchar(200),
bairro_fun varchar(200),
numero_fun int,
pais_fun varchar(100),
estado_civil_fun varchar(100),
funcao_fun varchar(100),
salario_fun double,
estado_fun varchar(200),
cidade_fun varchar(200)
);

insert into Funcionario values (null, 'linlindavida da costa', '2005-11-11', '767-654-646-13','525465-54', '898045904', 'lilin@gmail.com', 'são', 'limoes',3422,'toquio','solteira','maniquim', 2000,'churumim','alecrim');
insert into Funcionario values (null, 'lucana batista', '1987-11-12', '798-444-646-17','7685667-4', '653756890', 'croniq@gmail.com', 'luoi', 'chuveiro','4352','rondonia','viuva','gerente', '3500','jaguaramirim','filadelfia');
insert into Funcionario values (null, 'Carla Souza', '1987-08-30', '777.888.999-11', '7779998-7', '4113579-2468', 'carla@example.com', 'Avenida Central', 'Centro', 500, 'Brasil', 'Casado', 'Engenheira de Software', 8000.00, 'Curitiba', 'Paraná');
insert into Funcionario values (null, 'Pedro Fernandes', '1980-12-25', '555.444.333-22', '5553332-1', '54321-9876', 'pedro@example.com', 'Rua do Comércio', 'Centro', 400, 'Brasil', 'Divorciado', 'Analista Financeiro', 6000.00, 'Belo Horizonte', 'Minas Gerais');
insert into Funcionario values (null, 'Ana Oliveira', '1995-03-08', '333.111.222-44', '3332221-5', '12345-6789', 'ana@example.com', 'Rua da Paz', 'Centro', 300, 'Brasil', 'Solteiro', 'Assistente Administrativo', 3000.00, 'Brasília', 'Distrito Federal');

select * from Funcionario;

create table Empresa(
id_emp int primary key auto_increment,
cnpj_emp varchar(200),
razao_social_emp varchar(200),
nome_fantasia_emp varchar(200),
situacao_cadastral_emp varchar(200),
regime_tributario_emp varchar(200),
data_inicio_atividade_emp date,
telefone_emp varchar(200),
capital_social_emp double,
endereco_completo_emp varchar(200),
estado_emp varchar(200),
tipo_emp varchar(100),
porte_empresa_emp varchar(200),
natureza_juridica_emp varchar(200),
nome_propietario_emp varchar(200),
cpf_proprietario_emp varchar(200)
);

insert into Empresa values (null,'00.123.456/0001-01', 'Empresa A Ltda', 'Empresa A', 'Ativa', 'Simples Nacional', '2010-01-15', 
' 98765-4321', 100000.00, 'Rua Principal, 100, Centro', 'São Paulo', 'Tecnologia', 'Pequena', 'Sociedade Limitada', 'José da Silva', '111.222.333-44' );
insert into Empresa values (null, '11.222.333/0001-02', 'Empresa B S.A.', 'Empresa B', 'Ativa', 'Lucro Real', '2005-07-20',
 ' 99999-8888', 250000.00, 'Avenida Secundária, 50, Centro', 'Rio de Janeiro', 'Varejo', 'Média', 'Sociedade Anônima', 'Maria Oliveira', '222.333.444-55');
insert into Empresa values (null, '22.333.444/0001-03', 'Empresa C MEI', 'Empresa C', 'Ativa', 'Simples Nacional', '2018-03-10',
 '54321-9876', 50000.00, 'Rua do Comércio, 200, Centro', 'Minas Gerais', 'Serviços', 'Microempresa', 'Microempreendedor Individual', 'Carlos Pereira', '333.444.555-66');
insert into Empresa values (null,'33.444.555/0001-04', 'Empresa D & Filhos', 'Empresa D', 'Ativa', 'Lucro Presumido', '2012-09-05', 
'13579-2468', 750000.00, 'Avenida Principal, 300, Centro', 'Paraná', 'Consultoria', 'Grande', 'Sociedade Empresária Limitada', 'Fernanda Almeida', '444.555.666-77' );
insert into Empresa values (null, '44.555.666/0001-05', 'Empresa E Ltda', 'Empresa E', 'Ativa', 'Simples Nacional', '2015-12-30', 
'98765-4321', 200000.00, 'Rua Nova, 400, Centro', 'Rio Grande do Sul', 'Indústria', 'Média', 'Sociedade Limitada', 'Gabriel Barbosa', '555.666.777-88');

select * from Empresa;

