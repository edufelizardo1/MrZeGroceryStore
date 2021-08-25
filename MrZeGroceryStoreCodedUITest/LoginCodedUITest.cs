using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;


namespace MrZeGroceryStoreCodedUITest
{
    /// <resumo>
    /// Descrição resumida para CodedUITest1
    /// </resumo>
    [CodedUITest]
    public class LoginCodedUITest
    {
        public LoginCodedUITest()
        {
        }

        public void LoginInterfaceTest()
        {
            ApplicationUnderTest.Launch(@"C:\Users\edufe_54usi3q\OneDrive\Documentos\GitHub\MrZeGroceryStore\MrZeGroceryStore\bin\Debug\netcoreapp3.1\MrZeGroceryStore.exe");
        }

        [TestMethod]
        public void CenarioCodedUITest1()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” ,
            //  E senha no campo de texto “Senha”, 
            //  E estejam corretos.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter

            //*************************************************************************************//
            //  Assert
            //  Então é esperado que a tela de login feche,
            //  E abra a tela principal com menu sem previlégios administrativos.
        }

        [TestMethod]
        public void CenarioCodedUITest2()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E estejam incorretos.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest3()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E esteja incorreto o “Usuário”.
            //  E esteja correta a “Senha”.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest4()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E esteja correto o “Usuário”.
            //  E esteja incorreta a “Senha”.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha incorretos”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest5()
        {
            //  Arrange
            //  Dado que não seja inserido usuário no campo de texto “Usuário” 
            //  E senha no campo de texto “Senha”,
            //  E estando os campos de texto vazios.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest6()
        {
            //  Arrange
            //  Dado que seja inserido usuário no campo de texto “Usuário” 
            //  E e não seja inserida a senha no campo de texto “Senha”,
            //  E ignorando se o usuário está correto.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest7()
        {
            //  Arrange
            //  Dado que não seja inserido usuário no campo de texto “Usuário” 
            //  E e seja inserida a senha no campo de texto “Senha”,

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que apareça na tela de login a mensagem “Usuário ou Senha em branco.Favor digitar Usuário e Senha”,
            //  E não permita que o login seja realizado.
        }

        [TestMethod]
        public void CenarioCodedUITest8()
        {
            //  Arrange
            //  Dado que seja inserido usuário administrativo  no campo de texto “Usuário” ,
            //  E senha administrativa no campo de texto “Senha”, 
            //  E estejam corretos.

            LoginInterfaceTest();
            WinWindow winWindow = new WinWindow();
            winWindow.SearchProperties[UITestControl.PropertyNames.ControlType] = "Login";

            //*************************************************************************************//
            //  Act
            //  Quando apertar a tecla enter


            //*************************************************************************************//
            //  Assert
            //  Então é esperado que a tela de login feche,
            //  E abra a tela principal com previlégios administrativos.
        }

        #region Atributos de teste adicionais

        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:

        ////Use TestInitialize para executar código antes de executar cada teste 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Para gerar código para este teste, selecione "Gerar Código para Teste de Interface do Usuário Codificado" no menu de atalho e selecione um dos itens do menu.
        //}

        ////Use TestCleanup para executar código depois de cada execução de teste
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Para gerar código para este teste, selecione "Gerar Código para Teste de Interface do Usuário Codificado" no menu de atalho e selecione um dos itens do menu.
        //}

        #endregion

        /// <resumo>
        ///Obtém ou define o contexto do teste que provê
        ///informação e funcionalidade da execução de teste atual.
        ///</resumo>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
