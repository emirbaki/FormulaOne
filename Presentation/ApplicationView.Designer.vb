<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicationView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        txt_countryPop = New TextBox()
        txt_countryName = New TextBox()
        txt_countryID = New TextBox()
        lbl_countryPop = New Label()
        lbl_countryName = New Label()
        lbl_countryID = New Label()
        countryList = New ListBox()
        btn_Update = New Button()
        btn_Delete = New Button()
        btn_Add = New Button()
        TabControl1 = New TabControl()
        tab_countries = New TabPage()
        tab_drivers = New TabPage()
        GroupBox5 = New GroupBox()
        Label14 = New Label()
        selectedDriversListBox = New ListBox()
        btn_RemoveSelectedDriverContract = New Button()
        btn_AddSelectedDriverContract = New Button()
        btn_Contract = New Button()
        cbox_contractTeam = New ComboBox()
        Label12 = New Label()
        cbox_contractSeason = New ComboBox()
        Label13 = New Label()
        GroupBox4 = New GroupBox()
        txt_driverSurname = New TextBox()
        txt_driverName = New TextBox()
        Label8 = New Label()
        cbox_driverCountry = New ComboBox()
        txt_driverID = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        driverList = New ListBox()
        btn_UpdateDriver = New Button()
        btn_DeleteDriver = New Button()
        btn_AddDriver = New Button()
        tab_teams = New TabPage()
        GroupBox6 = New GroupBox()
        cbox_teamDetailsSeason = New ComboBox()
        Label15 = New Label()
        TeamDetailsListView = New ListView()
        GroupBox2 = New GroupBox()
        txt_teamName = New TextBox()
        cbox_teamCountry = New ComboBox()
        txt_teamID = New TextBox()
        Label1 = New Label()
        lbl_teamName = New Label()
        lbl_teamID = New Label()
        teamsList = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        btn_addTeam = New Button()
        tab_gps = New TabPage()
        GroupBox3 = New GroupBox()
        cbox_GP = New ComboBox()
        txt_gpName = New TextBox()
        txt_gpID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        gpList = New ListBox()
        btn_UpdateGP = New Button()
        btn_DeleteGP = New Button()
        btn_AddGP = New Button()
        TabPage1 = New TabPage()
        gp_listview = New ListView()
        ColumnHeader2 = New ColumnHeader()
        nud_gpCount = New NumericUpDown()
        nud_teamCount = New NumericUpDown()
        ListView2 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Label11 = New Label()
        btn_generateCalendar = New Button()
        teamsList_RacesPage = New ListView()
        Label10 = New Label()
        Label9 = New Label()
        cbox_Season = New ComboBox()
        ReportsPage = New TabPage()
        resultText = New Label()
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        tab_countries.SuspendLayout()
        tab_drivers.SuspendLayout()
        GroupBox5.SuspendLayout()
        GroupBox4.SuspendLayout()
        tab_teams.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox2.SuspendLayout()
        tab_gps.SuspendLayout()
        GroupBox3.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(nud_gpCount, ComponentModel.ISupportInitialize).BeginInit()
        CType(nud_teamCount, ComponentModel.ISupportInitialize).BeginInit()
        ReportsPage.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txt_countryPop)
        GroupBox1.Controls.Add(txt_countryName)
        GroupBox1.Controls.Add(txt_countryID)
        GroupBox1.Controls.Add(lbl_countryPop)
        GroupBox1.Controls.Add(lbl_countryName)
        GroupBox1.Controls.Add(lbl_countryID)
        GroupBox1.Controls.Add(countryList)
        GroupBox1.Controls.Add(btn_Update)
        GroupBox1.Controls.Add(btn_Delete)
        GroupBox1.Controls.Add(btn_Add)
        GroupBox1.Location = New Point(6, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(306, 474)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Countries"
        ' 
        ' txt_countryPop
        ' 
        txt_countryPop.Location = New Point(175, 399)
        txt_countryPop.Name = "txt_countryPop"
        txt_countryPop.Size = New Size(125, 27)
        txt_countryPop.TabIndex = 8
        ' 
        ' txt_countryName
        ' 
        txt_countryName.Location = New Point(175, 366)
        txt_countryName.Name = "txt_countryName"
        txt_countryName.Size = New Size(125, 27)
        txt_countryName.TabIndex = 7
        ' 
        ' txt_countryID
        ' 
        txt_countryID.Enabled = False
        txt_countryID.Location = New Point(175, 333)
        txt_countryID.Name = "txt_countryID"
        txt_countryID.Size = New Size(125, 27)
        txt_countryID.TabIndex = 6
        ' 
        ' lbl_countryPop
        ' 
        lbl_countryPop.AutoSize = True
        lbl_countryPop.Location = New Point(6, 406)
        lbl_countryPop.Name = "lbl_countryPop"
        lbl_countryPop.Size = New Size(138, 20)
        lbl_countryPop.TabIndex = 5
        lbl_countryPop.Text = "Country Population:"
        ' 
        ' lbl_countryName
        ' 
        lbl_countryName.AutoSize = True
        lbl_countryName.Location = New Point(6, 373)
        lbl_countryName.Name = "lbl_countryName"
        lbl_countryName.Size = New Size(107, 20)
        lbl_countryName.TabIndex = 4
        lbl_countryName.Text = "Country Name:"
        ' 
        ' lbl_countryID
        ' 
        lbl_countryID.AutoSize = True
        lbl_countryID.Location = New Point(6, 340)
        lbl_countryID.Name = "lbl_countryID"
        lbl_countryID.Size = New Size(82, 20)
        lbl_countryID.TabIndex = 2
        lbl_countryID.Text = "Country ID:"
        ' 
        ' countryList
        ' 
        countryList.FormattingEnabled = True
        countryList.Location = New Point(6, 26)
        countryList.Name = "countryList"
        countryList.Size = New Size(294, 304)
        countryList.TabIndex = 3
        ' 
        ' btn_Update
        ' 
        btn_Update.Location = New Point(206, 439)
        btn_Update.Name = "btn_Update"
        btn_Update.Size = New Size(94, 29)
        btn_Update.TabIndex = 2
        btn_Update.Text = "Update"
        btn_Update.UseVisualStyleBackColor = True
        ' 
        ' btn_Delete
        ' 
        btn_Delete.Location = New Point(106, 439)
        btn_Delete.Name = "btn_Delete"
        btn_Delete.Size = New Size(94, 29)
        btn_Delete.TabIndex = 1
        btn_Delete.Text = "Delete"
        btn_Delete.UseVisualStyleBackColor = True
        ' 
        ' btn_Add
        ' 
        btn_Add.Location = New Point(6, 439)
        btn_Add.Name = "btn_Add"
        btn_Add.Size = New Size(94, 29)
        btn_Add.TabIndex = 0
        btn_Add.Text = "Add"
        btn_Add.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tab_countries)
        TabControl1.Controls.Add(tab_drivers)
        TabControl1.Controls.Add(tab_teams)
        TabControl1.Controls.Add(tab_gps)
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(ReportsPage)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1027, 642)
        TabControl1.TabIndex = 2
        ' 
        ' tab_countries
        ' 
        tab_countries.Controls.Add(GroupBox1)
        tab_countries.Location = New Point(4, 29)
        tab_countries.Name = "tab_countries"
        tab_countries.Padding = New Padding(3)
        tab_countries.Size = New Size(1019, 609)
        tab_countries.TabIndex = 0
        tab_countries.Text = "Countries"
        tab_countries.UseVisualStyleBackColor = True
        ' 
        ' tab_drivers
        ' 
        tab_drivers.Controls.Add(GroupBox5)
        tab_drivers.Controls.Add(GroupBox4)
        tab_drivers.Location = New Point(4, 29)
        tab_drivers.Name = "tab_drivers"
        tab_drivers.Padding = New Padding(3)
        tab_drivers.Size = New Size(1019, 609)
        tab_drivers.TabIndex = 1
        tab_drivers.Text = "Drivers"
        tab_drivers.UseVisualStyleBackColor = True
        ' 
        ' GroupBox5
        ' 
        GroupBox5.Controls.Add(Label14)
        GroupBox5.Controls.Add(selectedDriversListBox)
        GroupBox5.Controls.Add(btn_RemoveSelectedDriverContract)
        GroupBox5.Controls.Add(btn_AddSelectedDriverContract)
        GroupBox5.Controls.Add(btn_Contract)
        GroupBox5.Controls.Add(cbox_contractTeam)
        GroupBox5.Controls.Add(Label12)
        GroupBox5.Controls.Add(cbox_contractSeason)
        GroupBox5.Controls.Add(Label13)
        GroupBox5.Location = New Point(320, 11)
        GroupBox5.Name = "GroupBox5"
        GroupBox5.Size = New Size(488, 506)
        GroupBox5.TabIndex = 4
        GroupBox5.TabStop = False
        GroupBox5.Text = "Contract with a team"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(7, 310)
        Label14.Name = "Label14"
        Label14.Size = New Size(119, 20)
        Label14.TabIndex = 15
        Label14.Text = "Selected Drivers:"
        ' 
        ' selectedDriversListBox
        ' 
        selectedDriversListBox.FormattingEnabled = True
        selectedDriversListBox.Location = New Point(7, 333)
        selectedDriversListBox.Name = "selectedDriversListBox"
        selectedDriversListBox.Size = New Size(475, 104)
        selectedDriversListBox.TabIndex = 14
        ' 
        ' btn_RemoveSelectedDriverContract
        ' 
        btn_RemoveSelectedDriverContract.Location = New Point(6, 94)
        btn_RemoveSelectedDriverContract.Name = "btn_RemoveSelectedDriverContract"
        btn_RemoveSelectedDriverContract.Size = New Size(151, 59)
        btn_RemoveSelectedDriverContract.TabIndex = 13
        btn_RemoveSelectedDriverContract.Text = "Remove the selected driver"
        btn_RemoveSelectedDriverContract.UseVisualStyleBackColor = True
        ' 
        ' btn_AddSelectedDriverContract
        ' 
        btn_AddSelectedDriverContract.Location = New Point(6, 29)
        btn_AddSelectedDriverContract.Name = "btn_AddSelectedDriverContract"
        btn_AddSelectedDriverContract.Size = New Size(151, 59)
        btn_AddSelectedDriverContract.TabIndex = 12
        btn_AddSelectedDriverContract.Text = "Add the selected driver"
        btn_AddSelectedDriverContract.UseVisualStyleBackColor = True
        ' 
        ' btn_Contract
        ' 
        btn_Contract.Location = New Point(331, 103)
        btn_Contract.Name = "btn_Contract"
        btn_Contract.Size = New Size(151, 29)
        btn_Contract.TabIndex = 11
        btn_Contract.Text = "Make a Contract"
        btn_Contract.UseVisualStyleBackColor = True
        ' 
        ' cbox_contractTeam
        ' 
        cbox_contractTeam.FormattingEnabled = True
        cbox_contractTeam.Location = New Point(331, 60)
        cbox_contractTeam.Name = "cbox_contractTeam"
        cbox_contractTeam.Size = New Size(151, 28)
        cbox_contractTeam.TabIndex = 10
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(188, 63)
        Label12.Name = "Label12"
        Label12.Size = New Size(48, 20)
        Label12.TabIndex = 9
        Label12.Text = "Team:"
        ' 
        ' cbox_contractSeason
        ' 
        cbox_contractSeason.FormattingEnabled = True
        cbox_contractSeason.Location = New Point(331, 26)
        cbox_contractSeason.Name = "cbox_contractSeason"
        cbox_contractSeason.Size = New Size(151, 28)
        cbox_contractSeason.TabIndex = 8
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(188, 29)
        Label13.Name = "Label13"
        Label13.Size = New Size(84, 20)
        Label13.TabIndex = 5
        Label13.Text = "For Season:"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(txt_driverSurname)
        GroupBox4.Controls.Add(txt_driverName)
        GroupBox4.Controls.Add(Label8)
        GroupBox4.Controls.Add(cbox_driverCountry)
        GroupBox4.Controls.Add(txt_driverID)
        GroupBox4.Controls.Add(Label5)
        GroupBox4.Controls.Add(Label6)
        GroupBox4.Controls.Add(Label7)
        GroupBox4.Controls.Add(driverList)
        GroupBox4.Controls.Add(btn_UpdateDriver)
        GroupBox4.Controls.Add(btn_DeleteDriver)
        GroupBox4.Controls.Add(btn_AddDriver)
        GroupBox4.Location = New Point(8, 11)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(306, 506)
        GroupBox4.TabIndex = 3
        GroupBox4.TabStop = False
        GroupBox4.Text = "Drivers"
        ' 
        ' txt_driverSurname
        ' 
        txt_driverSurname.Location = New Point(175, 403)
        txt_driverSurname.Name = "txt_driverSurname"
        txt_driverSurname.Size = New Size(125, 27)
        txt_driverSurname.TabIndex = 11
        ' 
        ' txt_driverName
        ' 
        txt_driverName.Location = New Point(175, 366)
        txt_driverName.Name = "txt_driverName"
        txt_driverName.Size = New Size(125, 27)
        txt_driverName.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 410)
        Label8.Name = "Label8"
        Label8.Size = New Size(114, 20)
        Label8.TabIndex = 10
        Label8.Text = "Driver Surname:"
        ' 
        ' cbox_driverCountry
        ' 
        cbox_driverCountry.FormattingEnabled = True
        cbox_driverCountry.Location = New Point(149, 436)
        cbox_driverCountry.Name = "cbox_driverCountry"
        cbox_driverCountry.Size = New Size(151, 28)
        cbox_driverCountry.TabIndex = 8
        ' 
        ' txt_driverID
        ' 
        txt_driverID.Location = New Point(175, 333)
        txt_driverID.Name = "txt_driverID"
        txt_driverID.Size = New Size(125, 27)
        txt_driverID.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 439)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 20)
        Label5.TabIndex = 5
        Label5.Text = "Driver Country"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 373)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 20)
        Label6.TabIndex = 4
        Label6.Text = "Driver Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 20)
        Label7.TabIndex = 2
        Label7.Text = "Driver ID:"
        ' 
        ' driverList
        ' 
        driverList.FormattingEnabled = True
        driverList.Location = New Point(6, 26)
        driverList.Name = "driverList"
        driverList.Size = New Size(294, 304)
        driverList.TabIndex = 3
        ' 
        ' btn_UpdateDriver
        ' 
        btn_UpdateDriver.Location = New Point(206, 471)
        btn_UpdateDriver.Name = "btn_UpdateDriver"
        btn_UpdateDriver.Size = New Size(94, 29)
        btn_UpdateDriver.TabIndex = 2
        btn_UpdateDriver.Text = "Update"
        btn_UpdateDriver.UseVisualStyleBackColor = True
        ' 
        ' btn_DeleteDriver
        ' 
        btn_DeleteDriver.Location = New Point(106, 471)
        btn_DeleteDriver.Name = "btn_DeleteDriver"
        btn_DeleteDriver.Size = New Size(94, 29)
        btn_DeleteDriver.TabIndex = 1
        btn_DeleteDriver.Text = "Delete"
        btn_DeleteDriver.UseVisualStyleBackColor = True
        ' 
        ' btn_AddDriver
        ' 
        btn_AddDriver.Location = New Point(6, 471)
        btn_AddDriver.Name = "btn_AddDriver"
        btn_AddDriver.Size = New Size(94, 29)
        btn_AddDriver.TabIndex = 0
        btn_AddDriver.Text = "Add"
        btn_AddDriver.UseVisualStyleBackColor = True
        ' 
        ' tab_teams
        ' 
        tab_teams.Controls.Add(GroupBox6)
        tab_teams.Controls.Add(GroupBox2)
        tab_teams.Location = New Point(4, 29)
        tab_teams.Name = "tab_teams"
        tab_teams.RightToLeft = RightToLeft.No
        tab_teams.Size = New Size(1019, 609)
        tab_teams.TabIndex = 2
        tab_teams.Text = "Teams"
        tab_teams.UseVisualStyleBackColor = True
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Controls.Add(cbox_teamDetailsSeason)
        GroupBox6.Controls.Add(Label15)
        GroupBox6.Controls.Add(TeamDetailsListView)
        GroupBox6.Location = New Point(331, 7)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Size = New Size(685, 474)
        GroupBox6.TabIndex = 3
        GroupBox6.TabStop = False
        GroupBox6.Text = "Team Details"
        ' 
        ' cbox_teamDetailsSeason
        ' 
        cbox_teamDetailsSeason.FormattingEnabled = True
        cbox_teamDetailsSeason.Location = New Point(164, 23)
        cbox_teamDetailsSeason.Name = "cbox_teamDetailsSeason"
        cbox_teamDetailsSeason.Size = New Size(151, 28)
        cbox_teamDetailsSeason.TabIndex = 10
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(21, 26)
        Label15.Name = "Label15"
        Label15.Size = New Size(84, 20)
        Label15.TabIndex = 9
        Label15.Text = "For Season:"
        ' 
        ' TeamDetailsListView
        ' 
        TeamDetailsListView.Location = New Point(21, 67)
        TeamDetailsListView.Name = "TeamDetailsListView"
        TeamDetailsListView.Size = New Size(645, 401)
        TeamDetailsListView.TabIndex = 0
        TeamDetailsListView.UseCompatibleStateImageBehavior = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txt_teamName)
        GroupBox2.Controls.Add(cbox_teamCountry)
        GroupBox2.Controls.Add(txt_teamID)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(lbl_teamName)
        GroupBox2.Controls.Add(lbl_teamID)
        GroupBox2.Controls.Add(teamsList)
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(Button2)
        GroupBox2.Controls.Add(btn_addTeam)
        GroupBox2.Location = New Point(8, 7)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(306, 474)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Teams"
        ' 
        ' txt_teamName
        ' 
        txt_teamName.Location = New Point(175, 366)
        txt_teamName.Name = "txt_teamName"
        txt_teamName.Size = New Size(125, 27)
        txt_teamName.TabIndex = 9
        ' 
        ' cbox_teamCountry
        ' 
        cbox_teamCountry.FormattingEnabled = True
        cbox_teamCountry.Location = New Point(149, 403)
        cbox_teamCountry.Name = "cbox_teamCountry"
        cbox_teamCountry.Size = New Size(151, 28)
        cbox_teamCountry.TabIndex = 8
        ' 
        ' txt_teamID
        ' 
        txt_teamID.Location = New Point(175, 333)
        txt_teamID.Name = "txt_teamID"
        txt_teamID.Size = New Size(125, 27)
        txt_teamID.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 406)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 5
        Label1.Text = "Team Country"
        ' 
        ' lbl_teamName
        ' 
        lbl_teamName.AutoSize = True
        lbl_teamName.Location = New Point(6, 373)
        lbl_teamName.Name = "lbl_teamName"
        lbl_teamName.Size = New Size(92, 20)
        lbl_teamName.TabIndex = 4
        lbl_teamName.Text = "Team Name:"
        ' 
        ' lbl_teamID
        ' 
        lbl_teamID.AutoSize = True
        lbl_teamID.Location = New Point(6, 340)
        lbl_teamID.Name = "lbl_teamID"
        lbl_teamID.Size = New Size(67, 20)
        lbl_teamID.TabIndex = 2
        lbl_teamID.Text = "Team ID:"
        ' 
        ' teamsList
        ' 
        teamsList.FormattingEnabled = True
        teamsList.Location = New Point(6, 26)
        teamsList.Name = "teamsList"
        teamsList.Size = New Size(294, 304)
        teamsList.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(206, 439)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "Update"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(106, 439)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 1
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' btn_addTeam
        ' 
        btn_addTeam.Location = New Point(6, 439)
        btn_addTeam.Name = "btn_addTeam"
        btn_addTeam.Size = New Size(94, 29)
        btn_addTeam.TabIndex = 0
        btn_addTeam.Text = "Add"
        btn_addTeam.UseVisualStyleBackColor = True
        ' 
        ' tab_gps
        ' 
        tab_gps.Controls.Add(GroupBox3)
        tab_gps.Location = New Point(4, 29)
        tab_gps.Name = "tab_gps"
        tab_gps.Size = New Size(1019, 609)
        tab_gps.TabIndex = 3
        tab_gps.Text = "GPs"
        tab_gps.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(cbox_GP)
        GroupBox3.Controls.Add(txt_gpName)
        GroupBox3.Controls.Add(txt_gpID)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(gpList)
        GroupBox3.Controls.Add(btn_UpdateGP)
        GroupBox3.Controls.Add(btn_DeleteGP)
        GroupBox3.Controls.Add(btn_AddGP)
        GroupBox3.Location = New Point(8, 7)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(306, 474)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "GPs"
        ' 
        ' cbox_GP
        ' 
        cbox_GP.FormattingEnabled = True
        cbox_GP.Location = New Point(149, 406)
        cbox_GP.Name = "cbox_GP"
        cbox_GP.Size = New Size(151, 28)
        cbox_GP.TabIndex = 8
        ' 
        ' txt_gpName
        ' 
        txt_gpName.Location = New Point(175, 366)
        txt_gpName.Name = "txt_gpName"
        txt_gpName.Size = New Size(125, 27)
        txt_gpName.TabIndex = 7
        ' 
        ' txt_gpID
        ' 
        txt_gpID.Location = New Point(175, 333)
        txt_gpID.Name = "txt_gpID"
        txt_gpID.Size = New Size(125, 27)
        txt_gpID.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 406)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 5
        Label2.Text = "GP Country"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 373)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 4
        Label3.Text = "GP Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 20)
        Label4.TabIndex = 2
        Label4.Text = "GP ID:"
        ' 
        ' gpList
        ' 
        gpList.FormattingEnabled = True
        gpList.Location = New Point(6, 26)
        gpList.Name = "gpList"
        gpList.Size = New Size(294, 304)
        gpList.TabIndex = 3
        ' 
        ' btn_UpdateGP
        ' 
        btn_UpdateGP.Location = New Point(206, 439)
        btn_UpdateGP.Name = "btn_UpdateGP"
        btn_UpdateGP.Size = New Size(94, 29)
        btn_UpdateGP.TabIndex = 2
        btn_UpdateGP.Text = "Update"
        btn_UpdateGP.UseVisualStyleBackColor = True
        ' 
        ' btn_DeleteGP
        ' 
        btn_DeleteGP.Location = New Point(106, 439)
        btn_DeleteGP.Name = "btn_DeleteGP"
        btn_DeleteGP.Size = New Size(94, 29)
        btn_DeleteGP.TabIndex = 1
        btn_DeleteGP.Text = "Delete"
        btn_DeleteGP.UseVisualStyleBackColor = True
        ' 
        ' btn_AddGP
        ' 
        btn_AddGP.Location = New Point(6, 439)
        btn_AddGP.Name = "btn_AddGP"
        btn_AddGP.Size = New Size(94, 29)
        btn_AddGP.TabIndex = 0
        btn_AddGP.Text = "Add"
        btn_AddGP.UseVisualStyleBackColor = True
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(gp_listview)
        TabPage1.Controls.Add(nud_gpCount)
        TabPage1.Controls.Add(nud_teamCount)
        TabPage1.Controls.Add(ListView2)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(btn_generateCalendar)
        TabPage1.Controls.Add(teamsList_RacesPage)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(cbox_Season)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1019, 609)
        TabPage1.TabIndex = 4
        TabPage1.Text = "Races"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' gp_listview
        ' 
        gp_listview.Columns.AddRange(New ColumnHeader() {ColumnHeader2})
        gp_listview.Location = New Point(731, 142)
        gp_listview.Name = "gp_listview"
        gp_listview.Size = New Size(229, 395)
        gp_listview.TabIndex = 10
        gp_listview.UseCompatibleStateImageBehavior = False
        ' 
        ' nud_gpCount
        ' 
        nud_gpCount.Location = New Point(595, 557)
        nud_gpCount.Name = "nud_gpCount"
        nud_gpCount.Size = New Size(150, 27)
        nud_gpCount.TabIndex = 9
        ' 
        ' nud_teamCount
        ' 
        nud_teamCount.Location = New Point(68, 93)
        nud_teamCount.Name = "nud_teamCount"
        nud_teamCount.Size = New Size(150, 27)
        nud_teamCount.TabIndex = 8
        ' 
        ' ListView2
        ' 
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView2.Location = New Point(386, 142)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(229, 395)
        ListView2.TabIndex = 7
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(386, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(55, 20)
        Label11.TabIndex = 6
        Label11.Text = "Drivers"
        ' 
        ' btn_generateCalendar
        ' 
        btn_generateCalendar.Location = New Point(777, 555)
        btn_generateCalendar.Name = "btn_generateCalendar"
        btn_generateCalendar.Size = New Size(183, 29)
        btn_generateCalendar.TabIndex = 5
        btn_generateCalendar.Text = "Generate Calendar"
        btn_generateCalendar.UseVisualStyleBackColor = True
        ' 
        ' teamsList_RacesPage
        ' 
        teamsList_RacesPage.Location = New Point(8, 142)
        teamsList_RacesPage.Name = "teamsList_RacesPage"
        teamsList_RacesPage.Size = New Size(229, 395)
        teamsList_RacesPage.TabIndex = 4
        teamsList_RacesPage.UseCompatibleStateImageBehavior = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 95)
        Label10.Name = "Label10"
        Label10.Size = New Size(54, 20)
        Label10.TabIndex = 3
        Label10.Text = "Teams:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(59, 20)
        Label9.TabIndex = 1
        Label9.Text = "Season:"
        ' 
        ' cbox_Season
        ' 
        cbox_Season.FormattingEnabled = True
        cbox_Season.Location = New Point(67, 13)
        cbox_Season.Name = "cbox_Season"
        cbox_Season.Size = New Size(151, 28)
        cbox_Season.TabIndex = 0
        ' 
        ' ReportsPage
        ' 
        ReportsPage.Controls.Add(resultText)
        ReportsPage.Location = New Point(4, 29)
        ReportsPage.Name = "ReportsPage"
        ReportsPage.Padding = New Padding(3)
        ReportsPage.Size = New Size(1019, 609)
        ReportsPage.TabIndex = 5
        ReportsPage.Text = "Reports"
        ReportsPage.UseVisualStyleBackColor = True
        ' 
        ' resultText
        ' 
        resultText.AutoSize = True
        resultText.Location = New Point(8, 31)
        resultText.Name = "resultText"
        resultText.Size = New Size(72, 20)
        resultText.TabIndex = 0
        resultText.Text = "resultText"
        ' 
        ' ApplicationView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1030, 634)
        Controls.Add(TabControl1)
        Name = "ApplicationView"
        Text = "Formula 1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tab_countries.ResumeLayout(False)
        tab_drivers.ResumeLayout(False)
        GroupBox5.ResumeLayout(False)
        GroupBox5.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        tab_teams.ResumeLayout(False)
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        tab_gps.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(nud_gpCount, ComponentModel.ISupportInitialize).EndInit()
        CType(nud_teamCount, ComponentModel.ISupportInitialize).EndInit()
        ReportsPage.ResumeLayout(False)
        ReportsPage.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Delete As Button
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_Update As Button
    Friend WithEvents countryList As ListBox
    Friend WithEvents txt_countryPop As TextBox
    Friend WithEvents txt_countryName As TextBox
    Friend WithEvents txt_countryID As TextBox
    Friend WithEvents lbl_countryPop As Label
    Friend WithEvents lbl_countryName As Label
    Friend WithEvents lbl_countryID As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tab_countries As TabPage
    Friend WithEvents tab_drivers As TabPage
    Friend WithEvents tab_teams As TabPage
    Friend WithEvents tab_gps As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_driverSurname As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txt_teamID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_teamName As Label
    Friend WithEvents lbl_teamID As Label
    Friend WithEvents teamsList As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_addTeam As Button
    Friend WithEvents cbox_teamCountry As ComboBox
    Friend WithEvents txt_teamName As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txt_gpName As TextBox
    Friend WithEvents txt_gpID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gpList As ListBox
    Friend WithEvents btn_UpdateGP As Button
    Friend WithEvents btn_DeleteGP As Button
    Friend WithEvents btn_AddGP As Button
    Friend WithEvents cbox_GP As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_driverName As TextBox
    Friend WithEvents cbox_driverCountry As ComboBox
    Friend WithEvents txt_driverID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents driverList As ListBox
    Friend WithEvents btn_UpdateDriver As Button
    Friend WithEvents btn_DeleteDriver As Button
    Friend WithEvents btn_AddDriver As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents cbox_Season As ComboBox
    Friend WithEvents teamsList_RacesPage As ListView
    Friend WithEvents Label10 As Label
    Friend WithEvents btn_generateCalendar As Button
    Friend WithEvents nud_teamCount As NumericUpDown
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label11 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents nud_gpCount As NumericUpDown
    Friend WithEvents gp_listview As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ReportsPage As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents cbox_contractTeam As ComboBox
    Friend WithEvents cbox_contractSeason As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_Contract As Button
    Friend WithEvents btn_AddSelectedDriverContract As Button
    Friend WithEvents btn_RemoveSelectedDriverContract As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents selectedDriversListBox As ListBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TeamDetailsListView As ListView
    Friend WithEvents cbox_teamDetailsSeason As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents resultText As Label

End Class
