# language: pt-br
# encoding; utf-8


Funcionalidade: Como usuário já logado no sistema e acessando o cadastro de usuário,
Eu quero poder cadastrar novo usuário, alterar, deletar e ver os dados deste usuário, desde que tenha o acesso administrativo,
Eu quero poder alterar meu usuário e ver os meus dados desde que tenha acesso "comum",
Para controlar as minhas informações e as de outros usuários.

@mytag
Cenário: Teste 01 - acessar tela de usuários com perfíl de administrador
	Dado que esteja logado no sistema
	E a tela principal esteja visível
	Quando pressionar o botão "Usuário"
	Então é esperado que a tela "Lista de Usuários" seja mostrado no contatiner filho da tela principal
	E liste todos os usuários já cadastrados

@mytag
Cenário: Teste 02 - Com perfíl de administrador acessar tela "Novo cadastro de Usuário"
	Dado que a tela "Lista de Usuários" seja visível
	Quando pressionar o botão "Novo"
	Então é esperado que a tela "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 03 - Com perfíl de administrador cadastrar novo usuário
	Dado que a tela "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "José..."
	E digite no campo nome de usuário "jose"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up com os dizeres "Usuário salvo com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 04 - Com perfíl de administrador acessar tela "Novo cadastro de Usuário"
	Dado que a tela "Lista de Usuários" seja visível
	Quando pressionar o botão "Novo"
	Então é esperado que a tela "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 05 - Com perfíl de administrador cadastrar novo usuário
	Dado que a tela "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Tereza Albuquerque"
	E digite no campo nome de usuário "tereza"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 06 - Com perfíl de administrador acessar tela "Novo cadastro de Usuário"
	Dado que a tela "Lista de Usuários" seja visível
	Quando pressionar o botão "Novo"
	Então é esperado que a tela "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 07 - Com perfíl de administrador cadastrar novo usuário
	Dado que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Julia..."
	E digite no campo nome de usuário "julia"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 08 - Com perfíl de administrador acessar tela "Novo cadastro de Usuário"
	Dado que a tela "Lista de Usuários" seja visível
	Quando pressionar o botão "Novo"
	Então é esperado que a tela "Novo cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 09 - Com perfíl de administrador cadastrar novo usuário
	Dado que a tela de "Novo cadastro de Usuário" esteja visível
	E digite no campo nome "Julia..."
	E digite no campo nome de usuário "julia"
	E digite no campo senha "123456"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário salvo com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 10 - Como administrador deletar usuário
	Dado que a tela "Lista de Usuários" seja visivel
	E selecione o na lista de usuários o nome "Tereza Albuquerque"
	Quando pressionar o botão "Deletar"
	Então é esperado que apareça poup-up "Usuário deletado com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 10 - Com o perfíl de administrador acessar a tela "Cadastro de Usuário" 
	Dado que a tela de "Lista de Usuários" seja visível
	E selecione o na lista de usuários o nome "Julia..."
	Quando pressionar o botão "Atualizar"
	Então é esperado que a tela de "Cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 11 - Com o perfíl de administrador atualizar cadastro de usuário
	Dado que a tela de "Cadastro de Usuário" esteja visível
	E e no campo nome "Julia..."
	E digite no campo nome de usuário "juliafilha"
	E digite no campo senha "254167"
	Quando pressionar o botão "Atualizar"
	Então é esperado que apareça poup-up "Usuário atualizado com sucesso!!!"
	E este é fechado pressionando o botão "OK" do poup-up 
	E retornando para a tela "Lista de Usuários" atualizada

@mytag
Cenário: Teste 12 - Com o perfíl de  usuário padrão acessar a tela "Cadastro de Usuário"
	Dado que esteja logado no sistema
	E a tela principal esteja visiível
	Quando pressionar o botão "Usuário"
	Então é esperado que a tela de "Cadastro de Usuário" seja mostrado no contatiner filho da tela principal

@mytag
Cenário: Teste 13 - Com o perfíl de usuário padrão atualizar "Cadastro de Usuário"
	Dado que a que a tela de "Cadastro de Usuário" esteja visível
	E no campo nome seja "Julia..."
	E no campo nome de usuário seja "juliafilhamaisbonita"
	E no campo senha "987654"
	Quando pressionar o botão "Salvar"
	Então é esperado que apareça poup-up "Usuário atualizado com sucesso!!!"
	E fechando este pressionando o botão "OK" do poup-up 
	E atualiza a tela de "Cadastro de Usuário"