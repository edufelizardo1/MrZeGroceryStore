# language: pt-br
# encoding; utf-8

Funcionalidade: Como usuário do sistema e tendo acesso ao sistema principal
Eu quero poder acessar a tela de registro de vendas
Para poder registrar novas vendas e cancela-las quando necessário

@mytag
Cenário: Teste 01 - Abrir a tela de registro de Venda

Dado que o usuário esteja logado no sistema
E a tela principal esteja ativa
Quando pressionar o botão "Registro de Venda"
Então é esperado que a tela de registro de venda seja aberta dentro do espação reservado e este propósito na tela principal.

