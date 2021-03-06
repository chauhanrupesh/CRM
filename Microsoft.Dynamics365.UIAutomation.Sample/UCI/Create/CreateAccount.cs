﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Dynamics365.UIAutomation.Sample.UCI
{
    [TestClass]
    public class CreateAccount : TestsBase
    {
        [TestInitialize]
        public override void InitTest() => base.InitTest();

        [TestCleanup]
        public override void FinishTest() => base.FinishTest();

        public override void NavigateToHomePage() => _xrmApp.Navigation.OpenSubArea("Sales", "Accounts");

        [TestMethod]
        public void UCITestCreateAccount()
        {
            _xrmApp.Navigation.OpenSubArea("Sales", "Accounts");

            _xrmApp.CommandBar.ClickCommand("New");

            _xrmApp.Entity.SetValue("name", TestSettings.GetRandomString(5, 15));

            _xrmApp.Entity.Save();
        }
    }
}