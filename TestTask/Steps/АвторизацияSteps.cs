using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace TestTask.Steps
{
    [Binding]
    public class АвторизацияSteps
    {
        public string token;
        public string error;

        [When(@"отправлен запрос на авторизацию с валидными параметрами")]
        public void ЕслиСозданЗапросНаАвторизациюСВалиднымиПараметрами()
        {
            token = GlobalVariables.reqresClient.PostLogin().token;
        }
        
        [Then(@"получен токен")]
        public void ТоПолученТокен()
        {
            Assert.IsTrue(token == "QpwL5tke4Pnpja7X4", "Токен не получен или неверный");
        }

        [When(@"отправлен запрос на авторизацию с не валидным паролем")]
        public void ЕслиСозданЗапросНаАвторизациюСНеВалиднымПаролем()
        {
            error = GlobalVariables.reqresClient.PostLogin("eve.holt@reqres.in", "").error;
        }

        [When(@"отправлен запрос на авторизацию с не валидным логином")]
        public void ЕслиОтправленЗапросНаАвторизациюСНеВалиднымЛогином()
        {
            error = GlobalVariables.reqresClient.PostLogin("eve", "cityslicka").error;
        }

        [When(@"отправлен запрос на авторизацию без логина")]
        public void ЕслиОтправленЗапросНаАвторизациюБезЛогина()
        {
            error = GlobalVariables.reqresClient.PostLogin("", "cityslicka").error;
        }

        [Then(@"получена ошибка ""(.*)""")]
        public void ТоПолученаОшибка(string p0)
        {
            Assert.IsTrue(error == p0 , "Ожидаемая ошибка не получена");
        }
    }
}
