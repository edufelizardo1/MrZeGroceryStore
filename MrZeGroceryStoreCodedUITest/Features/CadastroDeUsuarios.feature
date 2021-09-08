# language: pt-br
# encoding; utf-8


Funcionalidade: Como usuário já logado no sistema e acessando o cadastro de usuário,
Eu quero poder cadastrar novo usuário, alterar, deletar e ver os dados deste usuário, desde que tenha o acesso administrativo,
Eu quero poder alterar meu usuário e ver os meus dados desde que tenha acesso "comum",
Para controlar as minhas informações e as de outros usuários.

@mytag
Cenário: Teste 01 - acessar usuários como administrador
	Dado que esteja logado no sistema
	E a tela principal esteja visiível
	Quando pressionar o botão "Usuário"
	Então é esperado que a tela de "Lista de Usuários" seja mostrado no contatiner filho da tela principal
	E liste todos os usuários já cadastrados

@mytag
Cenário: Teste 02 - Como administrador acessar novo usuário
	Dado que a tela de "Lista de Usuários" seja visivel
	Quando pressionar o botão "Novo"
	Então é esperado que a tela de "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 03 - Como administrador cadastrar novo usuário
	Dado que a que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "José..."
	E digite no campo nome de usuário "jose"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente

@mytag
Cenário: Teste 04 - Como administrador acessar novo usuário
	Dado que a que a tela de "Lista de Usuários" seja visivel
	Quando pressionar o botão "Novo"
	Então é esperado que a tela de "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 05 - Como administrador cadastrar novo usuário
	Dado que a que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Tereza Albuquerque"
	E digite no campo nome de usuário "tereza"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente atualizado

@mytag
Cenário: Teste 06 - Como administrador acessar novo usuário
	Dado que a que a tela de "Lista de Usuários" seja visivel
	Quando pressionar o botão "Novo"
	Então é esperado que a tela de "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 07 - Como administrador cadastrar novo usuário
	Dado que a que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Julia..."
	E digite no campo nome de usuário "julia"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente atualizado

@mytag
Cenário: Teste 08 - Como administrador acessar novo usuário
	Dado que a que a tela de "Lista de Usuários" seja visivel
	Quando pressionar o botão "Novo"
	Então é esperado que a tela de "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 09 - Como administrador cadastrar novo usuário
	Dado que a que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Julia..."
	E digite no campo nome de usuário "julia"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente atualizado

@mytag
Cenário: Teste 10 - Como administrador deletar usuário
	Dado que a que a tela de "Lista de Usuários" seja visivel
	E selecione o na lista de usuários o nome "Tereza Albuquerque"
	Quando pressionar o botão "Deletar"
	Então é esperado que apareça poup-up "Usuário deletado com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente atualizado

@mytag
Cenário: Teste 10 - Como administrador acessar a tela atualizar cadastro de usuário
	Dado que a que a tela de "Lista de Usuários" seja visivel
	E selecione o na lista de usuários o nome "Julia..."
	Quando pressionar o botão "Atualizar"
	Então é esperado que a tela de "Cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 11 - Como administrador atualizar cadastro de usuário
	Dado que a que a tela de "Cadastro de Usuário" esteja visível
	E digite no campo nome "Julia..."
	E digite no campo nome de usuário "juliafilha"
	E digite no campo senha "254167"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário atualizado com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E retorna para a tela de "Lista de Usuários" novamente atualizado

@mytag
Cenário: Teste 12 - Como usuário padrão acessar a tela cadastro de usuário
	Dado que esteja logado no sistema
	E a tela principal esteja visiível
	Quando pressionar o botão "Usuário"
	Então é esperado que a tela de "Cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 13 - Como usuário padrão atualizar cadastro de usuário
	Dado que a que a tela de "Cadastro de Usuário" esteja visível
	E no campo nome seja "Julia..."
	E no campo nome de usuário sela "juliafilhamais bonita"
	E no campo senha "987654"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário atualizado com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E atualiza a tela de "Cadastro de Usuário"