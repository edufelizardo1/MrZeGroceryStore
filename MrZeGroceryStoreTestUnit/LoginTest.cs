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
            //  Dado que seja inserido usuário no campo de texto “Usuário” ,
            //  E senha no campo de texto “Senha”, 
            //  E estejam corretos.

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter

            //*************************************************************************************//
            //  Assert
            //  Então é esperado que a tela de login feche,
            //  E abra a tela principal com menu sem previlégios administrativos.
        }

        [Fact]
        public void Cenario2()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E estejam incorretos.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario3()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E esteja incorreto o “Usuário”.
            //  E esteja correta a “Senha”.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario4()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E esteja correto o “Usuário”.
            //  E esteja incorreta a “Senha”.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario5()
        {
            //  Arrange
            //  Dado que não seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E estando os campos de texto vazios.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario6()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E e não seja inserida a senha no campo de texto “Senha”,
            //  E ignorando se o usuário está correto.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario7()
        {
            //  Arrange
            //  Dado que não seja inserido usuário no campo de texto “Usuário” 
            //  E e seja inserida a senha no campo de texto “Senha”,


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [Fact]
        public void Cenario8()
        {
            //  Arrange
            //  Dado que seja inserido usuário administrativo  no campo de texto “Usuário” ,
            //  E senha administrativa no campo de texto “Senha”, 
            //  E estejam corretos.


            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que a tela de login feche,
            //  E abra a tela principal com previlégios administrativos.
        }
    }
}
