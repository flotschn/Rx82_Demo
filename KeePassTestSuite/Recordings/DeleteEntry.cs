﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace KeePassTestSuite.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteEntry recording.
    /// </summary>
    [TestModule("8a03480a-c326-4e0f-8a34-f6067f989e70", ModuleType.Recording, 1)]
    public partial class DeleteEntry : ITestModule
    {
        /// <summary>
        /// Holds an instance of the KeePassTestSuite.KeePassTestSuiteRepository repository.
        /// </summary>
        public static KeePassTestSuite.KeePassTestSuiteRepository repo = KeePassTestSuite.KeePassTestSuiteRepository.Instance;

        static DeleteEntry instance = new DeleteEntry();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteEntry()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteEntry Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varTitle.
        /// </summary>
        [TestVariable("64154ab2-5fe8-42d9-8fd7-c58f64ade382")]
        public string varTitle
        {
            get { return repo.varTitle; }
            set { repo.varTitle = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MainForm.Entry_3' at Center.", repo.MainForm.Entry_3Info, new RecordItemIndex(0));
            repo.MainForm.Entry_3.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Right Click item 'MainForm.Entry_3' at Center.", repo.MainForm.Entry_3Info, new RecordItemIndex(1));
            repo.MainForm.Entry_3.Click(System.Windows.Forms.MouseButtons.Right, 100);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'KeePass.DeleteEntry' at Center.", repo.KeePass.DeleteEntryInfo, new RecordItemIndex(2));
            repo.KeePass.DeleteEntry.Click(100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
