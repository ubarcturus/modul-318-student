// <copyright file="StartTest.cs">Copyright ©  2018</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwissTransportUI;

namespace SwissTransportUI.Tests
{
    /// <summary>Diese Klasse enthält parametrisierte Komponententests für Start.</summary>
    [PexClass(typeof(Start))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class StartTest
    {
        /// <summary>Test-Stub für SearchStart(String)</summary>
        [PexMethod]
        internal List<string> SearchStartTest([PexAssumeUnderTest]Start target, string TextStart)
        {
            List<string> result = target.SearchStart(TextStart);
            return result;
            // TODO: Assertionen zu Methode StartTest.SearchStartTest(Start, String) hinzufügen
        }
    }
}
