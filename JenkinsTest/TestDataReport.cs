/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 23-06-2020
 * Time: 02:20 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace JenkinsTest
{
    /// <summary>
    /// Description of TestDataReport.
    /// </summary>
    [TestModule("2E29088F-44CE-4331-ACD2-4767DE964DCD", ModuleType.UserCode, 1)]
    public class TestDataReport : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TestDataReport()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
           Report.Success("Test Report from "+TestSuite.Current.Name+" => "+TestSuite.CurrentTestContainer.Name);
        }
    }
}
