# language: pt-br
# encoding; utf-8

Funcionalidade: Como usuário admin/padrão
Eu quero registrar produtos coma as seguintes caracteristicas: nome, unidade de medida, item;
Sendo nome = nome do produto, unidade de medida = unid, kg, g, etc..., item = merceária, bomboniere, limpeza, bebida alcóolica, etc...
Para pode ter controle sobre itens de consumo de meus clientes

@mytag
Cenário: Teste 01 - Acessar a tela cadastro de produto
	Dado que o usuário esteja logado no sistema
	E a tela principal esteja ativa
	Quando pressionar o botão "Cadastro de Produto"
	Então é esperado que a tela de "Cadastro de Produto" seja aberta dentro do espação reservado e este propósito na tela principal.
	E liste todos os produtos já cadastrados

@mytag
Cenário: Teste 02 - 