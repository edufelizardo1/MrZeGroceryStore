# language: pt-br
# encoding; utf-8

Funcionalidade: Como cliente eu acesso a tela de login.
Eu quero colocar usuário e senha válido e clicando no botão "acessar sistema".
Para ecessar o sistema da merceária do Seu Zé.

@mytag
Cenário: Teste 01 - Usuário e Senha válida

	Dado que a tela de Autorização a acesso ao sistema estaja visível
	E que seja inserido no campo Usuário "jose"
	E que seja inserido no campo Senha "123456"
	Quando pressionar o botão "Acessar o Sistema"
	Então é esperado que a tela de Autorização a acesso ao sistema feche
	E abrirá a tela principal com o menu sem previlégios administrativos.

@mytag
Cenário: Test 02 - Usuário válido e senha inválida

	Dado que a tela de Autorização a acesso ao sistema estaja visível
	E que seja inserido no campo Usuário "jose"
	E que seja inserido no campo Senha "126788992"
	Quando pressionar o botão "Acessar o Sistema"
	Então é esperado que a tela de Autorização a acesso ao sistema não feche
	E apareça uma mensagem "Usuário ou senha incorretos"
	E não permita que o acesso seja realizado