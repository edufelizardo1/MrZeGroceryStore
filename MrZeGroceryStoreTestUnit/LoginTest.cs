using System;
using Xunit;

namespace MrZeGroceryStoreTestUnit
{
    public class LoginTest
    {
        [Fact]
        public void Cenario1()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio no campo de texto �Usu�rio� ,
            //  E senha no campo de texto �Senha�, 
            //  E estejam corretos.

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter

            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que a tela de login feche,
            //  E abra a tela principal com menu sem previl�gios administrativos.
        }

        [Fact]
        public void Cenario2()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E senha no campo de texto �Senha�,
            //  E estejam incorretos.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha incorretos�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario3()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E senha no campo de texto �Senha�,
            //  E esteja incorreto o �Usu�rio�.
            //  E esteja correta a �Senha�.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha incorretos�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario4()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E senha no campo de texto �Senha�,
            //  E esteja correto o �Usu�rio�.
            //  E esteja incorreta a �Senha�.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha incorretos�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario5()
        {
            //  Arrange
            //  Dado que n�o seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E senha no campo de texto �Senha�,
            //  E estando os campos de texto vazios.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha em branco.Favor digitar Usu�rio e Senha�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario6()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E e n�o seja inserida a senha no campo de texto �Senha�,
            //  E ignorando se o usu�rio est� correto.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha em branco.Favor digitar Usu�rio e Senha�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario7()
        {
            //  Arrange
            //  Dado que n�o seja inserido usu�rio no campo de texto �Usu�rio� 
            //  E e seja inserida a senha no campo de texto �Senha�,


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que apare�a na tela de login a mensagem �Usu�rio ou Senha em branco.Favor digitar Usu�rio e Senha�,
            //  E n�o permita que o login seja realizado.
        }

        [Fact]
        public void Cenario8()
        {
            //  Arrange
            //  Dado que seja inserido usu�rio administrativo  no campo de texto �Usu�rio� ,
            //  E senha administrativa no campo de texto �Senha�, 
            //  E estejam corretos.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Ent�o � esperado que a tela de login feche,
            //  E abra a tela principal com previl�gios administrativos.
        }
    }
}
