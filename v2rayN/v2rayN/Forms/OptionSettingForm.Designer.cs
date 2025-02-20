﻿namespace v2rayN.Forms
{
    partial class OptionSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionSettingForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chksniffingEnabled2 = new System.Windows.Forms.CheckBox();
            this.chksniffingEnabled = new System.Windows.Forms.CheckBox();
            this.txtremoteDNS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkmuxEnabled = new System.Windows.Forms.CheckBox();
            this.chkAllowIn2 = new System.Windows.Forms.CheckBox();
            this.chkudpEnabled2 = new System.Windows.Forms.CheckBox();
            this.cmbprotocol2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocalPort2 = new System.Windows.Forms.TextBox();
            this.cmbprotocol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkudpEnabled = new System.Windows.Forms.CheckBox();
            this.chklogEnabled = new System.Windows.Forms.CheckBox();
            this.cmbloglevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlocalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtUseragent = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUserdirect = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUserblock = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSetDefRountingRule = new System.Windows.Forms.Button();
            this.cmbdomainStrategy = new System.Windows.Forms.ComboBox();
            this.labRoutingTips = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbroutingMode = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkKcpcongestion = new System.Windows.Forms.CheckBox();
            this.txtKcpwriteBufferSize = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKcpreadBufferSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKcpdownlinkCapacity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKcpuplinkCapacity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKcptti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKcpmtu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.cbFreshrate = new System.Windows.Forms.ComboBox();
            this.tbCacheDays = new System.Windows.Forms.TextBox();
            this.lbFreshrate = new System.Windows.Forms.Label();
            this.lbCacheDays = new System.Windows.Forms.Label();
            this.chkEnableStatistics = new System.Windows.Forms.CheckBox();
            this.chkAllowLANConn = new System.Windows.Forms.CheckBox();
            this.txturlGFWList = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAutoRun = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chksniffingEnabled2);
            this.groupBox1.Controls.Add(this.chksniffingEnabled);
            this.groupBox1.Controls.Add(this.txtremoteDNS);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.chkmuxEnabled);
            this.groupBox1.Controls.Add(this.chkAllowIn2);
            this.groupBox1.Controls.Add(this.chkudpEnabled2);
            this.groupBox1.Controls.Add(this.cmbprotocol2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocalPort2);
            this.groupBox1.Controls.Add(this.cmbprotocol);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkudpEnabled);
            this.groupBox1.Controls.Add(this.chklogEnabled);
            this.groupBox1.Controls.Add(this.cmbloglevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtlocalPort);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chksniffingEnabled2
            // 
            resources.ApplyResources(this.chksniffingEnabled2, "chksniffingEnabled2");
            this.chksniffingEnabled2.Name = "chksniffingEnabled2";
            this.chksniffingEnabled2.UseVisualStyleBackColor = true;
            // 
            // chksniffingEnabled
            // 
            resources.ApplyResources(this.chksniffingEnabled, "chksniffingEnabled");
            this.chksniffingEnabled.Name = "chksniffingEnabled";
            this.chksniffingEnabled.UseVisualStyleBackColor = true;
            // 
            // txtremoteDNS
            // 
            resources.ApplyResources(this.txtremoteDNS, "txtremoteDNS");
            this.txtremoteDNS.Name = "txtremoteDNS";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // chkmuxEnabled
            // 
            resources.ApplyResources(this.chkmuxEnabled, "chkmuxEnabled");
            this.chkmuxEnabled.Name = "chkmuxEnabled";
            this.chkmuxEnabled.UseVisualStyleBackColor = true;
            // 
            // chkAllowIn2
            // 
            resources.ApplyResources(this.chkAllowIn2, "chkAllowIn2");
            this.chkAllowIn2.Name = "chkAllowIn2";
            this.chkAllowIn2.UseVisualStyleBackColor = true;
            this.chkAllowIn2.CheckedChanged += new System.EventHandler(this.chkAllowIn2_CheckedChanged);
            // 
            // chkudpEnabled2
            // 
            resources.ApplyResources(this.chkudpEnabled2, "chkudpEnabled2");
            this.chkudpEnabled2.Name = "chkudpEnabled2";
            this.chkudpEnabled2.UseVisualStyleBackColor = true;
            // 
            // cmbprotocol2
            // 
            this.cmbprotocol2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprotocol2.FormattingEnabled = true;
            this.cmbprotocol2.Items.AddRange(new object[] {
            resources.GetString("cmbprotocol2.Items"),
            resources.GetString("cmbprotocol2.Items1")});
            resources.ApplyResources(this.cmbprotocol2, "cmbprotocol2");
            this.cmbprotocol2.Name = "cmbprotocol2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtlocalPort2
            // 
            resources.ApplyResources(this.txtlocalPort2, "txtlocalPort2");
            this.txtlocalPort2.Name = "txtlocalPort2";
            // 
            // cmbprotocol
            // 
            this.cmbprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbprotocol, "cmbprotocol");
            this.cmbprotocol.FormattingEnabled = true;
            this.cmbprotocol.Items.AddRange(new object[] {
            resources.GetString("cmbprotocol.Items"),
            resources.GetString("cmbprotocol.Items1")});
            this.cmbprotocol.Name = "cmbprotocol";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // chkudpEnabled
            // 
            resources.ApplyResources(this.chkudpEnabled, "chkudpEnabled");
            this.chkudpEnabled.Name = "chkudpEnabled";
            this.chkudpEnabled.UseVisualStyleBackColor = true;
            // 
            // chklogEnabled
            // 
            resources.ApplyResources(this.chklogEnabled, "chklogEnabled");
            this.chklogEnabled.Name = "chklogEnabled";
            this.chklogEnabled.UseVisualStyleBackColor = true;
            // 
            // cmbloglevel
            // 
            this.cmbloglevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloglevel.FormattingEnabled = true;
            this.cmbloglevel.Items.AddRange(new object[] {
            resources.GetString("cmbloglevel.Items"),
            resources.GetString("cmbloglevel.Items1"),
            resources.GetString("cmbloglevel.Items2"),
            resources.GetString("cmbloglevel.Items3"),
            resources.GetString("cmbloglevel.Items4")});
            resources.ApplyResources(this.cmbloglevel, "cmbloglevel");
            this.cmbloglevel.Name = "cmbloglevel";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtlocalPort
            // 
            resources.ApplyResources(this.txtlocalPort, "txtlocalPort");
            this.txtlocalPort.Name = "txtlocalPort";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl2);
            this.groupBox2.Controls.Add(this.panel3);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            resources.ApplyResources(this.tabControl2, "tabControl2");
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtUseragent);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtUseragent
            // 
            resources.ApplyResources(this.txtUseragent, "txtUseragent");
            this.txtUseragent.Name = "txtUseragent";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUserdirect);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUserdirect
            // 
            resources.ApplyResources(this.txtUserdirect, "txtUserdirect");
            this.txtUserdirect.Name = "txtUserdirect";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUserblock);
            resources.ApplyResources(this.tabPage5, "tabPage5");
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUserblock
            // 
            resources.ApplyResources(this.txtUserblock, "txtUserblock");
            this.txtUserblock.Name = "txtUserblock";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSetDefRountingRule);
            this.panel3.Controls.Add(this.cmbdomainStrategy);
            this.panel3.Controls.Add(this.labRoutingTips);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cmbroutingMode);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnSetDefRountingRule
            // 
            resources.ApplyResources(this.btnSetDefRountingRule, "btnSetDefRountingRule");
            this.btnSetDefRountingRule.Name = "btnSetDefRountingRule";
            this.btnSetDefRountingRule.UseVisualStyleBackColor = true;
            this.btnSetDefRountingRule.Click += new System.EventHandler(this.btnSetDefRountingRule_Click);
            // 
            // cmbdomainStrategy
            // 
            this.cmbdomainStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdomainStrategy.FormattingEnabled = true;
            this.cmbdomainStrategy.Items.AddRange(new object[] {
            resources.GetString("cmbdomainStrategy.Items"),
            resources.GetString("cmbdomainStrategy.Items1"),
            resources.GetString("cmbdomainStrategy.Items2")});
            resources.ApplyResources(this.cmbdomainStrategy, "cmbdomainStrategy");
            this.cmbdomainStrategy.Name = "cmbdomainStrategy";
            // 
            // labRoutingTips
            // 
            this.labRoutingTips.ForeColor = System.Drawing.Color.Brown;
            resources.ApplyResources(this.labRoutingTips, "labRoutingTips");
            this.labRoutingTips.Name = "labRoutingTips";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cmbroutingMode
            // 
            this.cmbroutingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbroutingMode.FormattingEnabled = true;
            this.cmbroutingMode.Items.AddRange(new object[] {
            resources.GetString("cmbroutingMode.Items"),
            resources.GetString("cmbroutingMode.Items1"),
            resources.GetString("cmbroutingMode.Items2"),
            resources.GetString("cmbroutingMode.Items3")});
            resources.ApplyResources(this.cmbroutingMode, "cmbroutingMode");
            this.cmbroutingMode.Name = "cmbroutingMode";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkKcpcongestion);
            this.tabPage6.Controls.Add(this.txtKcpwriteBufferSize);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.txtKcpreadBufferSize);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txtKcpdownlinkCapacity);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.txtKcpuplinkCapacity);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.txtKcptti);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.txtKcpmtu);
            this.tabPage6.Controls.Add(this.label6);
            resources.ApplyResources(this.tabPage6, "tabPage6");
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkKcpcongestion
            // 
            resources.ApplyResources(this.chkKcpcongestion, "chkKcpcongestion");
            this.chkKcpcongestion.Name = "chkKcpcongestion";
            this.chkKcpcongestion.UseVisualStyleBackColor = true;
            // 
            // txtKcpwriteBufferSize
            // 
            resources.ApplyResources(this.txtKcpwriteBufferSize, "txtKcpwriteBufferSize");
            this.txtKcpwriteBufferSize.Name = "txtKcpwriteBufferSize";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // txtKcpreadBufferSize
            // 
            resources.ApplyResources(this.txtKcpreadBufferSize, "txtKcpreadBufferSize");
            this.txtKcpreadBufferSize.Name = "txtKcpreadBufferSize";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtKcpdownlinkCapacity
            // 
            resources.ApplyResources(this.txtKcpdownlinkCapacity, "txtKcpdownlinkCapacity");
            this.txtKcpdownlinkCapacity.Name = "txtKcpdownlinkCapacity";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // txtKcpuplinkCapacity
            // 
            resources.ApplyResources(this.txtKcpuplinkCapacity, "txtKcpuplinkCapacity");
            this.txtKcpuplinkCapacity.Name = "txtKcpuplinkCapacity";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // txtKcptti
            // 
            resources.ApplyResources(this.txtKcptti, "txtKcptti");
            this.txtKcptti.Name = "txtKcptti";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtKcpmtu
            // 
            resources.ApplyResources(this.txtKcpmtu, "txtKcpmtu");
            this.txtKcpmtu.Name = "txtKcpmtu";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.cbFreshrate);
            this.tabPage7.Controls.Add(this.tbCacheDays);
            this.tabPage7.Controls.Add(this.lbFreshrate);
            this.tabPage7.Controls.Add(this.lbCacheDays);
            this.tabPage7.Controls.Add(this.chkEnableStatistics);
            this.tabPage7.Controls.Add(this.chkAllowLANConn);
            this.tabPage7.Controls.Add(this.txturlGFWList);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.chkAutoRun);
            resources.ApplyResources(this.tabPage7, "tabPage7");
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // cbFreshrate
            // 
            this.cbFreshrate.FormattingEnabled = true;
            resources.ApplyResources(this.cbFreshrate, "cbFreshrate");
            this.cbFreshrate.Name = "cbFreshrate";
            // 
            // tbCacheDays
            // 
            resources.ApplyResources(this.tbCacheDays, "tbCacheDays");
            this.tbCacheDays.Name = "tbCacheDays";
            // 
            // lbFreshrate
            // 
            resources.ApplyResources(this.lbFreshrate, "lbFreshrate");
            this.lbFreshrate.Name = "lbFreshrate";
            // 
            // lbCacheDays
            // 
            resources.ApplyResources(this.lbCacheDays, "lbCacheDays");
            this.lbCacheDays.Name = "lbCacheDays";
            // 
            // chkEnableStatistics
            // 
            resources.ApplyResources(this.chkEnableStatistics, "chkEnableStatistics");
            this.chkEnableStatistics.Name = "chkEnableStatistics";
            this.chkEnableStatistics.UseVisualStyleBackColor = true;
            // 
            // chkAllowLANConn
            // 
            resources.ApplyResources(this.chkAllowLANConn, "chkAllowLANConn");
            this.chkAllowLANConn.Name = "chkAllowLANConn";
            this.chkAllowLANConn.UseVisualStyleBackColor = true;
            // 
            // txturlGFWList
            // 
            resources.ApplyResources(this.txturlGFWList, "txturlGFWList");
            this.txturlGFWList.Name = "txturlGFWList";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // chkAutoRun
            // 
            resources.ApplyResources(this.chkAutoRun, "chkAutoRun");
            this.chkAutoRun.Name = "chkAutoRun";
            this.chkAutoRun.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnOK);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnOK
            // 
            resources.ApplyResources(this.btnOK, "btnOK");
            this.btnOK.Name = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataSource = typeof(v2rayN.Mode.Config);
            // 
            // OptionSettingForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OptionSettingForm";
            this.Load += new System.EventHandler(this.OptionSettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbloglevel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlocalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chklogEnabled;
        private System.Windows.Forms.CheckBox chkudpEnabled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbprotocol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbprotocol2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocalPort2;
        private System.Windows.Forms.CheckBox chkudpEnabled2;
        private System.Windows.Forms.CheckBox chkAllowIn2;
        private System.Windows.Forms.CheckBox chkmuxEnabled;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label labRoutingTips;
        private System.Windows.Forms.TextBox txtUseragent;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtUserdirect;
        private System.Windows.Forms.TextBox txtUserblock;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtKcpmtu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKcptti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKcpwriteBufferSize;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKcpreadBufferSize;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtKcpdownlinkCapacity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKcpuplinkCapacity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkKcpcongestion;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox chkAutoRun;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txturlGFWList;
        private System.Windows.Forms.CheckBox chkAllowLANConn;
        private System.Windows.Forms.TextBox txtremoteDNS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbdomainStrategy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbroutingMode;
        private System.Windows.Forms.CheckBox chksniffingEnabled;
        private System.Windows.Forms.CheckBox chksniffingEnabled2;
        private System.Windows.Forms.Button btnSetDefRountingRule;
        private System.Windows.Forms.CheckBox chkEnableStatistics;
        private System.Windows.Forms.TextBox tbCacheDays;
        private System.Windows.Forms.Label lbCacheDays;
        private System.Windows.Forms.ComboBox cbFreshrate;
        private System.Windows.Forms.Label lbFreshrate;
        private System.Windows.Forms.BindingSource configBindingSource;
    }
}