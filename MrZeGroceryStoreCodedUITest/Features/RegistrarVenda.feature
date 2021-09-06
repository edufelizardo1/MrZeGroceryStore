# language: pt-br
# encoding; utf-8

Funcionalidade: Como usuário do sistema e tendo acesso ao sistema principal
Eu quero poder acessar a tela de registro de vendas,
Eu quero consultar o perfil do cliente para poder lhe vender a prazo
Eu quero poder vender à vista sem necessitar fazer nenhuma consulta,
Eu quero poder cancelar uma compra quando necessário
Para poder registrar novas vendas a vista ou dar crédito.

@mytag
Cenário: Teste 01 - Abrir a tela de registro de Venda

Dado que o usuário esteja logado no sistema
E a tela principal esteja ativa
Quando pressionar o botão "Registro de Venda"
Então é esperado que a tela de registro de venda seja aberta dentro do espação reservado e este propósito na tela principal.

@mytag
Cenário: Teste 02 - Selecionar compra a vista e buscar primeiro produto

Dado que o usuário selecione a forma de pagamento "À vista"
E o usuário selecione a caixa de texto "Pesquisar produto"
E digite "Bolacha de sal"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Bolacha de sal"

@mytag
Cenário: Teste 03 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Bolacha de sal"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Bolacha de sal Tostines" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 04 - Inserir primeiro item no carrinho de compra

Dado que o item "Bolacha de Sal Tostines" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "2,00"
E e a quantidade disgitada pelo atendente seja "2" unidades
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Bolacha de sal Tostines", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "2,00"
E no campo valor cáculado conste R$ "4,00"
E no campo SubTotal conste R$ "4,00"

@mytag
Cenário: Teste 05 - Buscar segundo produto

Dado o usuário selecione a caixa de texto "Pesquisar produto"
E digite "Arroz"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Arroz"

@mytag
Cenário: Teste 06 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Arroz"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Arroz por quilo" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 07 - Inserir segundo item no carrinho de compra

Dado que o item "Arroz por quilo" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "2,34"
E e a quantidade disgitada pelo atendente seja "5" quilos
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Arroz por quilo", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "2,34"
E no campo valor cáculado conste R$ "11,70"
E no campo SubTotal conste R$ "15,70"

@mytag
Cenário: Teste 08 - Buscar terceiro produto

Dado o usuário selecione a caixa de texto "Pesquisar produto"
E digite "Fumo"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Fumo"

@mytag
Cenário: Teste 09 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Fumo"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Fumo por metro" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 10 - Inserir segundo item no carrinho de compra

Dado que o item "Fumo por metro" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "7,67"
E e a quantidade disgitada pelo atendente seja "0,30" metros
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Fumo por metro", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "7,67"
E no campo valor cáculado conste R$ "2,30"
E no campo SubTotal conste R$ "18,00"

@mytag
Cenário: Teste 11 - Fechar o carrinho

Dado que usuário selecione "Fechar carrinho"
E apareça um poup-up "Deseja relamente fonalizar a venda"
Quando pressionionar o botão "Sim"
Então é esperado que seja pedido o valor em dinheiro a ser creditado de R$ "20,00"
E que o SubTotal seja R$ "18,00".
E o valor do troco seja R$ "2,00"
E pressione o botão "Finalizar venda"
E a tela limpa aguardando nova venda

@mytag
Cenário: Teste 12 - Nova compra a crédito

Dado que o usuário selecione a forma de pagamento "Crédito"
Quando confirmar a abertura da venda 
Então é esperado que apareça um poup-up para fazer a busca ativa dos dados
E condições do crédito do cliente

@mytag
Cenário: Teste 13 - Pesquisar situação cadastral do cliente Aprovado

Dado que o pou-up esteja aberto
E acesse o campo "Busca do cliente"
E insira o nome completo do cliente ou parte do nome "Juarez Nascimento"
Quando pressionar o botão "Buscar"
Então é esperado que o campo "Nome" seja preenchidom, "Juarez Nascimento"
E é esperado que o campo "Endereço" seja preenchidom, "Rua Teste nº 1"
E é esperado que o campo "Telefone" seja preenchidom, "(11) 54545-8978"
E é esperado que o campo "Status do Crédito" seja preenchidom, "Aprovado"
E é esperado que o campo "Limite" seja preenchidom, R$ "150,00"
E é esperado que o campo "Disponível" seja preenchidom, R$ "130,00"


@mytag
Cenário: Teste 14 - Buscar primeiro produto

Dado que o usuário selecione botão "Iniciar a Venda" no poup-up
E o poup-up seja fechado automaticamente
E selecione a caixa de texto "Pesquisar produto"
E digite "Bolacha de sal"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Bolacha de sal"

@mytag
Cenário: Teste 15 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Bolacha de sal"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Bolacha de sal Tostines" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 16 - Inserir primeiro item no carrinho de compra

Dado que o item "Bolacha de Sal Tostines" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "2,00"
E e a quantidade disgitada pelo atendente seja "2" unidades
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Bolacha de sal Tostines", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "2,00"
E no campo valor cáculado conste R$ "4,00"
E no campo SubTotal conste R$ "4,00"

@mytag
Cenário: Teste 17 - Buscar segundo produto

Dado o usuário selecione a caixa de texto "Pesquisar produto"
E digite "Arroz"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Arroz"

@mytag
Cenário: Teste 18 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Arroz"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Arroz por quilo" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 19 - Inserir segundo item no carrinho de compra

Dado que o item "Arroz por quilo" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "2,34"
E e a quantidade disgitada pelo atendente seja "5" quilos
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Arroz por quilo", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "2,34"
E no campo valor cáculado conste R$ "11,70"
E no campo SubTotal conste R$ "15,70"

@mytag
Cenário: Teste 20 - Buscar terceiro produto

Dado o usuário selecione a caixa de texto "Pesquisar produto"
E digite "Fumo"
Quando pressionar o botão "Buscar" da caixa de texto "Pesquisar produto"
Então é esperado que na caixa de lista suspensa "Selecione o produto" carregue intens "Fumo"

@mytag
Cenário: Teste 21 - Selecionar o produto na lista "Selecioane o produto"

Dado que na caixa de lista suspensa "Selecione o produto" carregue intens "Fumo"
Quando pressionar o botão de rolagem abrindo a lista suspensa
Então é esperado que o item "Fumo por metro" esteja registrado
E seja selecionado

@mytag
Cenário: Teste 22 - Inserir segundo item no carrinho de compra

Dado que o item "Fumo por metro" tenha sido selecionado
E o valor do produto esteja cadastrado com vaor unítário de R$ "7,67"
E e a quantidade disgitada pelo atendente seja "0,30" metros
Quando pressionar o botão "Inserir Item"
Então é esperado que o item "Fumo por metro", seja inserido a lista de carrinho de compra
E no campo valor unitário conste R$ "7,67"
E no campo valor cáculado conste R$ "2,30"
E no campo SubTotal conste R$ "18,00"

@mytag
Cenário: Teste 23 - Fechar o carrinho

Dado que usuário selecione "Fechar carrinho"
E apareça um poup-up "Deseja relamente fonalizar a venda"
Quando pressionionar o botão "Sim"
Então que o SubTotal seja R$ "18,00".
E pressione o botão "Finalizar venda"
E a tela limpa aguardando nova venda

@mytag
Cenário: Teste 24 - Nova compra a crédito

Dado que o usuário selecione a forma de pagamento "Crédito"
Quando confirmar a abertura da venda 
Então é esperado que apareça um poup-up para fazer a busca ativa dos dados
E condições do crédito do cliente

@mytag
Cenário: Teste 25 - Pesquisar situação cadastral do cliente Suspenso

Dado que o pou-up esteja aberto
E acesse o campo "Busca do cliente"
E insira o nome completo do cliente ou parte do nome "Ricardo Araujo"
Quando pressionar o botão "Buscar"
Então é esperado que o campo "Nome" seja preenchidom, "Ricardo Araujo"
E é esperado que o campo "Endereço" seja preenchidom, "Rua Teste nº 2"
E é esperado que o campo "Telefone" seja preenchidom, "(11) 97070-6060"
E é esperado que o campo "Status do Crédito" seja preenchidom, "Suspenso"
E é esperado que o campo "Limite" seja preenchidom, R$ "150,00"
E é esperado que o campo "Disponível" seja preenchidom, R$ "130,00"
E é esperado que o campo "Motivo" seja preenchido, "Falta de pagamento"

@mytag
Cenário: Teste 26 - Finalizar compra não aprovada

Dado que o botão "Iniciar a Venda" no poup-up "Não esteja hailiatado"
Quando pressionar o botão "Fechar" do poup-up
Então é esperado que o poup-up feche
E a venda não seja possível iniciar.

