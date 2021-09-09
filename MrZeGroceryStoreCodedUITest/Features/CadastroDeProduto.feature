# language: pt-br
# encoding; utf-8

Funcionalidade: Como usuário admin/padrão
Eu quero registrar produtos coma as seguintes caracteristicas: nome, unidade de medida, item;
Sendo nome = nome do produto, unidade de medida = unid, kg, g, etc..., categoria = merceária, bomboniere, limpeza, bebida alcóolica, etc...
Para pode ter controle sobre itens de consumo de meus clientes

@mytag
Cenário: Teste 01 - Acessar a tela cadastro de produto
	Dado que o usuário esteja logado no sistema
	E a tela principal esteja ativa
	Quando pressionar o botão "Cadastro de Produto"
	Então é esperado que a tela de "Cadastro de Produto" seja mostrado no contatiner filho da tela principal
	E liste todos os produtos já cadastrados

@mytag
Cenário: Teste 02 - Cadastro de novo  produto
	Dado que a tela "Cadastro de Produto" esteja visível
	E digite no campo "Nome do produto", "Arroz por quilo"
	E escolha no campo "Unidade de Medida", "Kg"
	E digite no campo "Categoria", "Merceária"
	E digite no campo "Preço de unidade", "2,34"
	Quando pressionar o botão "Salvar Produto"
	Então é esperado que o produto seja registrado
	E apareça um poup-up com a informação "Produto registrado com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Cadastro de Produto" atualizada

@mytag
Cenário: Teste 03 - Atualização de informações do produto
	Dado que a tela "Cadastro de Produto" esteja visível
	E digite no campo "Nome do produto", "Arroz por quilo"
	E escolha no campo "Unidade de Medida", "Kg"
	E digite no campo "Categoria", "Merceária"
	E digite no campo "Preço de unidade", "3,00"
	Quando pressionar o botão "Atualizar Produto"
	Então é esperado que o produto seja atualizado
	E apareça um poup-up com a informação "Produto registrado com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Cadastro de Produto" atualizada

@mytag
Cenário: Teste 04 - Deletar o produto
	Dado que a tela "Cadastro de Produto" esteja visível
	E selecione o produto "Arroz por  quilo"
	Quando pressionar o botão "Deletar produto"
	Então é esperado que o produto seja deletado
	E  a tela "Cadastro de Produto" seja atualizada