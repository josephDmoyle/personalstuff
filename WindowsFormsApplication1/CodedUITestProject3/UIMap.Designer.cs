﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject3
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Gotta test it works man
        /// </summary>
        public void TestTip()
        {
            #region Variable Declarations
            WinListItem uIVisualStudio2015ListItem = this.UIProgramManagerWindow.UIDesktopList.UIVisualStudio2015ListItem;
            WinButton uIOpenButton = this.UIOpenFileSecurityWarnWindow.UIOpenWindow.UIOpenButton;
            WpfText uITeamExplorerText = this.UIStartPageMicrosoftViWindow.UITabGroupST006b0fdc0aTabList.UITeamExplorerHomeTabPage.UITeamExplorerHomeTitleBar.UITeamExplorerText;
            WpfToggleButton uIHomeToggleButton = this.UIStartPageMicrosoftViWindow.UITabGroupST006b0fdc0aTabList.UITeamExplorerToolbarToolBar.UIHomeToggleButton;
            WpfToggleButton uIManageConnectionsToggleButton = this.UIStartPageMicrosoftViWindow.UITabGroupST006b0fdc0aTabList.UITeamExplorerToolbarToolBar.UIManageConnectionsToggleButton;
            WpfList uIRepositoriesList = this.UIStartPageMicrosoftViWindow.UIRepositoryListSectioCustom.UIRepositoriesList;
            WpfListItem uIMicrosoftVisualStudiListItem = this.UIStartPageMicrosoftViWindow.UIProjectSectionViewCustom.UISolutionListList.UIMicrosoftVisualStudiListItem;
            WpfText uISolutionExplorerText = this.UIStartPageMicrosoftViWindow.UITabGroupST006b0fdc0aTabList.UISolutionExplorerTabPage.UISolutionExplorerTitleBar.UISolutionExplorerText;
            WpfTreeItem uIProgramcsTreeItem = this.UIStartPageMicrosoftViWindow.UITabGroupST006b0fdc0aTabList.UISolutionExplorerTabPage.UIProgramcsTreeItem;
            WpfMenuItem uIDebugTargetMenuItem = this.UIStartPageMicrosoftViWindow.UIDebugTargetMenu.UIDebugTargetMenuItem;
            WinEdit uIBillTextBoxEdit = this.UIFreeTipWindow.UIBillTextBoxWindow.UIBillTextBoxEdit;
            WinEdit uIPercentageTextBoxEdit = this.UIFreeTipWindow.UIPercentageTextBoxWindow.UIPercentageTextBoxEdit;
            #endregion

            // Double-Click 'Visual Studio 2015' list item
            Mouse.DoubleClick(uIVisualStudio2015ListItem, new Point(48, 26));

            // Click '&Open' button
            Mouse.Click(uIOpenButton, new Point(26, 9));

            // Click 'Team Explorer' label
            Mouse.Click(uITeamExplorerText, new Point(22, 7));

            // Click 'Home' toggle button
            Mouse.Click(uIHomeToggleButton, new Point(12, 4));

            // Click 'Manage Connections' toggle button
            Mouse.Click(uIManageConnectionsToggleButton, new Point(10, 10));

            // Select '' in 'Repositories' list box
            uIRepositoriesList.SelectedItemsAsString = this.TestTipParams.UIRepositoriesListSelectedItemsAsString;

            // Double-Click 'Microsoft.VisualStudio.TeamFoundation.TeamExplorer...' list item
            Mouse.DoubleClick(uIMicrosoftVisualStudiListItem, new Point(81, 6));

            // Click 'Solution Explorer' label
            Mouse.Click(uISolutionExplorerText, new Point(19, 8));

            // Double-Click 'Program.cs' tree item
            Mouse.DoubleClick(uIProgramcsTreeItem, new Point(105, 10));

            // Click 'Debug Target' menu item
            Mouse.Click(uIDebugTargetMenuItem, new Point(25, 12));

            // Type '5' in 'billTextBox' text box
            uIBillTextBoxEdit.Text = this.TestTipParams.UIBillTextBoxEditText;

            // Type '20' in 'percentageTextBox' text box
            uIPercentageTextBoxEdit.Text = this.TestTipParams.UIPercentageTextBoxEditText;

            // Type '{Enter}' in 'percentageTextBox' text box
            Keyboard.SendKeys(uIPercentageTextBoxEdit, this.TestTipParams.UIPercentageTextBoxEditSendKeys, ModifierKeys.None);
        }
        
        #region Properties
        public virtual TestTipParams TestTipParams
        {
            get
            {
                if ((this.mTestTipParams == null))
                {
                    this.mTestTipParams = new TestTipParams();
                }
                return this.mTestTipParams;
            }
        }
        
        public UIProgramManagerWindow UIProgramManagerWindow
        {
            get
            {
                if ((this.mUIProgramManagerWindow == null))
                {
                    this.mUIProgramManagerWindow = new UIProgramManagerWindow();
                }
                return this.mUIProgramManagerWindow;
            }
        }
        
        public UIOpenFileSecurityWarnWindow UIOpenFileSecurityWarnWindow
        {
            get
            {
                if ((this.mUIOpenFileSecurityWarnWindow == null))
                {
                    this.mUIOpenFileSecurityWarnWindow = new UIOpenFileSecurityWarnWindow();
                }
                return this.mUIOpenFileSecurityWarnWindow;
            }
        }
        
        public UIStartPageMicrosoftViWindow UIStartPageMicrosoftViWindow
        {
            get
            {
                if ((this.mUIStartPageMicrosoftViWindow == null))
                {
                    this.mUIStartPageMicrosoftViWindow = new UIStartPageMicrosoftViWindow();
                }
                return this.mUIStartPageMicrosoftViWindow;
            }
        }
        
        public UIFreeTipWindow UIFreeTipWindow
        {
            get
            {
                if ((this.mUIFreeTipWindow == null))
                {
                    this.mUIFreeTipWindow = new UIFreeTipWindow();
                }
                return this.mUIFreeTipWindow;
            }
        }
        #endregion
        
        #region Fields
        private TestTipParams mTestTipParams;
        
        private UIProgramManagerWindow mUIProgramManagerWindow;
        
        private UIOpenFileSecurityWarnWindow mUIOpenFileSecurityWarnWindow;
        
        private UIStartPageMicrosoftViWindow mUIStartPageMicrosoftViWindow;
        
        private UIFreeTipWindow mUIFreeTipWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'TestTip'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TestTipParams
    {
        
        #region Fields
        /// <summary>
        /// Select '' in 'Repositories' list box
        /// </summary>
        public string UIRepositoriesListSelectedItemsAsString = "";
        
        /// <summary>
        /// Type '5' in 'billTextBox' text box
        /// </summary>
        public string UIBillTextBoxEditText = "5";
        
        /// <summary>
        /// Type '20' in 'percentageTextBox' text box
        /// </summary>
        public string UIPercentageTextBoxEditText = "20";
        
        /// <summary>
        /// Type '{Enter}' in 'percentageTextBox' text box
        /// </summary>
        public string UIPercentageTextBoxEditSendKeys = "{Enter}";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIProgramManagerWindow : WinWindow
    {
        
        public UIProgramManagerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Program Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Progman";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public UIDesktopList UIDesktopList
        {
            get
            {
                if ((this.mUIDesktopList == null))
                {
                    this.mUIDesktopList = new UIDesktopList(this);
                }
                return this.mUIDesktopList;
            }
        }
        #endregion
        
        #region Fields
        private UIDesktopList mUIDesktopList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDesktopList : WinList
    {
        
        public UIDesktopList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinList.PropertyNames.Name] = "Desktop";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public WinListItem UIVisualStudio2015ListItem
        {
            get
            {
                if ((this.mUIVisualStudio2015ListItem == null))
                {
                    this.mUIVisualStudio2015ListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUIVisualStudio2015ListItem.SearchProperties[WinListItem.PropertyNames.Name] = "Visual Studio 2015";
                    this.mUIVisualStudio2015ListItem.WindowTitles.Add("Program Manager");
                    #endregion
                }
                return this.mUIVisualStudio2015ListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUIVisualStudio2015ListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOpenFileSecurityWarnWindow : WinWindow
    {
        
        public UIOpenFileSecurityWarnWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Open File - Security Warning";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Open File - Security Warning");
            #endregion
        }
        
        #region Properties
        public UIOpenWindow UIOpenWindow
        {
            get
            {
                if ((this.mUIOpenWindow == null))
                {
                    this.mUIOpenWindow = new UIOpenWindow(this);
                }
                return this.mUIOpenWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIOpenWindow mUIOpenWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIOpenWindow : WinWindow
    {
        
        public UIOpenWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "4426";
            this.WindowTitles.Add("Open File - Security Warning");
            #endregion
        }
        
        #region Properties
        public WinButton UIOpenButton
        {
            get
            {
                if ((this.mUIOpenButton == null))
                {
                    this.mUIOpenButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIOpenButton.SearchProperties[WinButton.PropertyNames.Name] = "Open";
                    this.mUIOpenButton.WindowTitles.Add("Open File - Security Warning");
                    #endregion
                }
                return this.mUIOpenButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIOpenButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIStartPageMicrosoftViWindow : WpfWindow
    {
        
        public UIStartPageMicrosoftViWindow()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "Start Page - Microsoft Visual Studio";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            this.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UITabGroupST006b0fdc0aTabList UITabGroupST006b0fdc0aTabList
        {
            get
            {
                if ((this.mUITabGroupST006b0fdc0aTabList == null))
                {
                    this.mUITabGroupST006b0fdc0aTabList = new UITabGroupST006b0fdc0aTabList(this);
                }
                return this.mUITabGroupST006b0fdc0aTabList;
            }
        }
        
        public UIRepositoryListSectioCustom UIRepositoryListSectioCustom
        {
            get
            {
                if ((this.mUIRepositoryListSectioCustom == null))
                {
                    this.mUIRepositoryListSectioCustom = new UIRepositoryListSectioCustom(this);
                }
                return this.mUIRepositoryListSectioCustom;
            }
        }
        
        public UIProjectSectionViewCustom UIProjectSectionViewCustom
        {
            get
            {
                if ((this.mUIProjectSectionViewCustom == null))
                {
                    this.mUIProjectSectionViewCustom = new UIProjectSectionViewCustom(this);
                }
                return this.mUIProjectSectionViewCustom;
            }
        }
        
        public UIDebugTargetMenu UIDebugTargetMenu
        {
            get
            {
                if ((this.mUIDebugTargetMenu == null))
                {
                    this.mUIDebugTargetMenu = new UIDebugTargetMenu(this);
                }
                return this.mUIDebugTargetMenu;
            }
        }
        #endregion
        
        #region Fields
        private UITabGroupST006b0fdc0aTabList mUITabGroupST006b0fdc0aTabList;
        
        private UIRepositoryListSectioCustom mUIRepositoryListSectioCustom;
        
        private UIProjectSectionViewCustom mUIProjectSectionViewCustom;
        
        private UIDebugTargetMenu mUIDebugTargetMenu;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITabGroupST006b0fdc0aTabList : WpfTabList
    {
        
        public UITabGroupST006b0fdc0aTabList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "TabGroup|ST:0:0:{6b0fdc0a-f28e-47a0-8eed-cc296beff6d2}|ST:0:0:{3ae79031-e1bc-11d0" +
                "-8f78-00a0c9110057}|ST:0:0:{131369f2-062d-44a2-8671-91ff31efb4f4}|ST:0:0:{c9c0ae" +
                "26-aa77-11d2-b3f0-0000f87570ee}";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            this.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UITeamExplorerHomeTabPage UITeamExplorerHomeTabPage
        {
            get
            {
                if ((this.mUITeamExplorerHomeTabPage == null))
                {
                    this.mUITeamExplorerHomeTabPage = new UITeamExplorerHomeTabPage(this);
                }
                return this.mUITeamExplorerHomeTabPage;
            }
        }
        
        public UITeamExplorerToolbarToolBar UITeamExplorerToolbarToolBar
        {
            get
            {
                if ((this.mUITeamExplorerToolbarToolBar == null))
                {
                    this.mUITeamExplorerToolbarToolBar = new UITeamExplorerToolbarToolBar(this);
                }
                return this.mUITeamExplorerToolbarToolBar;
            }
        }
        
        public UISolutionExplorerTabPage UISolutionExplorerTabPage
        {
            get
            {
                if ((this.mUISolutionExplorerTabPage == null))
                {
                    this.mUISolutionExplorerTabPage = new UISolutionExplorerTabPage(this);
                }
                return this.mUISolutionExplorerTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UITeamExplorerHomeTabPage mUITeamExplorerHomeTabPage;
        
        private UITeamExplorerToolbarToolBar mUITeamExplorerToolbarToolBar;
        
        private UISolutionExplorerTabPage mUISolutionExplorerTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITeamExplorerHomeTabPage : WpfTabPage
    {
        
        public UITeamExplorerHomeTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.AutomationId] = "TAB_ST:0:0:{131369f2-062d-44a2-8671-91ff31efb4f4}";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UITeamExplorerHomeTitleBar UITeamExplorerHomeTitleBar
        {
            get
            {
                if ((this.mUITeamExplorerHomeTitleBar == null))
                {
                    this.mUITeamExplorerHomeTitleBar = new UITeamExplorerHomeTitleBar(this);
                }
                return this.mUITeamExplorerHomeTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UITeamExplorerHomeTitleBar mUITeamExplorerHomeTitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITeamExplorerHomeTitleBar : WpfTitleBar
    {
        
        public UITeamExplorerHomeTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTitleBar.PropertyNames.AutomationId] = "TitleBar";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfText UITeamExplorerText
        {
            get
            {
                if ((this.mUITeamExplorerText == null))
                {
                    this.mUITeamExplorerText = new WpfText(this);
                    #region Search Criteria
                    this.mUITeamExplorerText.SearchProperties[WpfText.PropertyNames.Name] = "Team Explorer";
                    this.mUITeamExplorerText.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUITeamExplorerText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUITeamExplorerText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITeamExplorerToolbarToolBar : WpfToolBar
    {
        
        public UITeamExplorerToolbarToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfToolBar.PropertyNames.Name] = "Team Explorer Toolbar";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfToggleButton UIHomeToggleButton
        {
            get
            {
                if ((this.mUIHomeToggleButton == null))
                {
                    this.mUIHomeToggleButton = new WpfToggleButton(this);
                    #region Search Criteria
                    this.mUIHomeToggleButton.SearchProperties[WpfToggleButton.PropertyNames.Name] = "Home";
                    this.mUIHomeToggleButton.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIHomeToggleButton;
            }
        }
        
        public WpfToggleButton UIManageConnectionsToggleButton
        {
            get
            {
                if ((this.mUIManageConnectionsToggleButton == null))
                {
                    this.mUIManageConnectionsToggleButton = new WpfToggleButton(this);
                    #region Search Criteria
                    this.mUIManageConnectionsToggleButton.SearchProperties[WpfToggleButton.PropertyNames.Name] = "Manage Connections";
                    this.mUIManageConnectionsToggleButton.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIManageConnectionsToggleButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfToggleButton mUIHomeToggleButton;
        
        private WpfToggleButton mUIManageConnectionsToggleButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISolutionExplorerTabPage : WpfTabPage
    {
        
        public UISolutionExplorerTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.AutomationId] = "TAB_ST:0:0:{3ae79031-e1bc-11d0-8f78-00a0c9110057}";
            this.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UISolutionExplorerTitleBar UISolutionExplorerTitleBar
        {
            get
            {
                if ((this.mUISolutionExplorerTitleBar == null))
                {
                    this.mUISolutionExplorerTitleBar = new UISolutionExplorerTitleBar(this);
                }
                return this.mUISolutionExplorerTitleBar;
            }
        }
        
        public WpfTreeItem UIProgramcsTreeItem
        {
            get
            {
                if ((this.mUIProgramcsTreeItem == null))
                {
                    this.mUIProgramcsTreeItem = new WpfTreeItem(this);
                    #region Search Criteria
                    this.mUIProgramcsTreeItem.SearchProperties[WpfTreeItem.PropertyNames.Name] = "Program.cs";
                    this.mUIProgramcsTreeItem.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIProgramcsTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UISolutionExplorerTitleBar mUISolutionExplorerTitleBar;
        
        private WpfTreeItem mUIProgramcsTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISolutionExplorerTitleBar : WpfTitleBar
    {
        
        public UISolutionExplorerTitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTitleBar.PropertyNames.AutomationId] = "TitleBar";
            this.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfText UISolutionExplorerText
        {
            get
            {
                if ((this.mUISolutionExplorerText == null))
                {
                    this.mUISolutionExplorerText = new WpfText(this);
                    #region Search Criteria
                    this.mUISolutionExplorerText.SearchProperties[WpfText.PropertyNames.Name] = "Solution Explorer";
                    this.mUISolutionExplorerText.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUISolutionExplorerText;
            }
        }
        #endregion
        
        #region Fields
        private WpfText mUISolutionExplorerText;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIRepositoryListSectioCustom : WpfCustom
    {
        
        public UIRepositoryListSectioCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.RepositoryListSectionView";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "repositoryListSectionView";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfList UIRepositoriesList
        {
            get
            {
                if ((this.mUIRepositoriesList == null))
                {
                    this.mUIRepositoriesList = new WpfList(this);
                    #region Search Criteria
                    this.mUIRepositoriesList.SearchProperties[WpfList.PropertyNames.AutomationId] = "repositoriesList";
                    this.mUIRepositoriesList.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIRepositoriesList;
            }
        }
        #endregion
        
        #region Fields
        private WpfList mUIRepositoriesList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIProjectSectionViewCustom : WpfCustom
    {
        
        public UIProjectSectionViewCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SolutionsSectionView";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "projectSectionView";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public UISolutionListList UISolutionListList
        {
            get
            {
                if ((this.mUISolutionListList == null))
                {
                    this.mUISolutionListList = new UISolutionListList(this);
                }
                return this.mUISolutionListList;
            }
        }
        #endregion
        
        #region Fields
        private UISolutionListList mUISolutionListList;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISolutionListList : WpfList
    {
        
        public UISolutionListList(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfList.PropertyNames.AutomationId] = "solutionList";
            this.WindowTitles.Add("Start Page - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfListItem UIMicrosoftVisualStudiListItem
        {
            get
            {
                if ((this.mUIMicrosoftVisualStudiListItem == null))
                {
                    this.mUIMicrosoftVisualStudiListItem = new WpfListItem(this);
                    #region Search Criteria
                    this.mUIMicrosoftVisualStudiListItem.SearchProperties[WpfListItem.PropertyNames.Name] = "Microsoft.VisualStudio.TeamFoundation.TeamExplorer.Home.SolutionInfo";
                    this.mUIMicrosoftVisualStudiListItem.SearchProperties[WpfListItem.PropertyNames.Instance] = "2";
                    this.mUIMicrosoftVisualStudiListItem.WindowTitles.Add("Start Page - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIMicrosoftVisualStudiListItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfListItem mUIMicrosoftVisualStudiListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDebugTargetMenu : WpfMenu
    {
        
        public UIDebugTargetMenu(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfMenu.PropertyNames.Name] = "Debug Target";
            this.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
            #endregion
        }
        
        #region Properties
        public WpfMenuItem UIDebugTargetMenuItem
        {
            get
            {
                if ((this.mUIDebugTargetMenuItem == null))
                {
                    this.mUIDebugTargetMenuItem = new WpfMenuItem(this);
                    #region Search Criteria
                    this.mUIDebugTargetMenuItem.SearchProperties[WpfMenuItem.PropertyNames.AutomationId] = "PART_FocusTarget";
                    this.mUIDebugTargetMenuItem.WindowTitles.Add("WindowsFormsApplication1 - Microsoft Visual Studio");
                    #endregion
                }
                return this.mUIDebugTargetMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private WpfMenuItem mUIDebugTargetMenuItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFreeTipWindow : WinWindow
    {
        
        public UIFreeTipWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "FreeTip";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("FreeTip");
            #endregion
        }
        
        #region Properties
        public UIBillTextBoxWindow UIBillTextBoxWindow
        {
            get
            {
                if ((this.mUIBillTextBoxWindow == null))
                {
                    this.mUIBillTextBoxWindow = new UIBillTextBoxWindow(this);
                }
                return this.mUIBillTextBoxWindow;
            }
        }
        
        public UIPercentageTextBoxWindow UIPercentageTextBoxWindow
        {
            get
            {
                if ((this.mUIPercentageTextBoxWindow == null))
                {
                    this.mUIPercentageTextBoxWindow = new UIPercentageTextBoxWindow(this);
                }
                return this.mUIPercentageTextBoxWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIBillTextBoxWindow mUIBillTextBoxWindow;
        
        private UIPercentageTextBoxWindow mUIPercentageTextBoxWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBillTextBoxWindow : WinWindow
    {
        
        public UIBillTextBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "billTextBox";
            this.WindowTitles.Add("FreeTip");
            #endregion
        }
        
        #region Properties
        public WinEdit UIBillTextBoxEdit
        {
            get
            {
                if ((this.mUIBillTextBoxEdit == null))
                {
                    this.mUIBillTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIBillTextBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Enter Bill:";
                    this.mUIBillTextBoxEdit.WindowTitles.Add("FreeTip");
                    #endregion
                }
                return this.mUIBillTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIBillTextBoxEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIPercentageTextBoxWindow : WinWindow
    {
        
        public UIPercentageTextBoxWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "percentageTextBox";
            this.WindowTitles.Add("FreeTip");
            #endregion
        }
        
        #region Properties
        public WinEdit UIPercentageTextBoxEdit
        {
            get
            {
                if ((this.mUIPercentageTextBoxEdit == null))
                {
                    this.mUIPercentageTextBoxEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIPercentageTextBoxEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Tip Percentage:";
                    this.mUIPercentageTextBoxEdit.WindowTitles.Add("FreeTip");
                    #endregion
                }
                return this.mUIPercentageTextBoxEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIPercentageTextBoxEdit;
        #endregion
    }
}
