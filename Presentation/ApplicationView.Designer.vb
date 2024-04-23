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
        tab_teams = New TabPage()
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
        GroupBox1.SuspendLayout()
        TabControl1.SuspendLayout()
        tab_countries.SuspendLayout()
        tab_teams.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(688, 514)
        TabControl1.TabIndex = 2
        ' 
        ' tab_countries
        ' 
        tab_countries.Controls.Add(GroupBox1)
        tab_countries.Location = New Point(4, 29)
        tab_countries.Name = "tab_countries"
        tab_countries.Padding = New Padding(3)
        tab_countries.Size = New Size(680, 481)
        tab_countries.TabIndex = 0
        tab_countries.Text = "Countries"
        tab_countries.UseVisualStyleBackColor = True
        ' 
        ' tab_drivers
        ' 
        tab_drivers.Location = New Point(4, 29)
        tab_drivers.Name = "tab_drivers"
        tab_drivers.Padding = New Padding(3)
        tab_drivers.Size = New Size(680, 481)
        tab_drivers.TabIndex = 1
        tab_drivers.Text = "Drivers"
        tab_drivers.UseVisualStyleBackColor = True
        ' 
        ' tab_teams
        ' 
        tab_teams.Controls.Add(GroupBox2)
        tab_teams.Location = New Point(4, 29)
        tab_teams.Name = "tab_teams"
        tab_teams.RightToLeft = RightToLeft.No
        tab_teams.Size = New Size(680, 481)
        tab_teams.TabIndex = 2
        tab_teams.Text = "Teams"
        tab_teams.UseVisualStyleBackColor = True
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
        tab_gps.Location = New Point(4, 29)
        tab_gps.Name = "tab_gps"
        tab_gps.Size = New Size(680, 481)
        tab_gps.TabIndex = 3
        tab_gps.Text = "GPs"
        tab_gps.UseVisualStyleBackColor = True
        ' 
        ' ApplicationView
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(691, 549)
        Controls.Add(TabControl1)
        Name = "ApplicationView"
        Text = "Formula 1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tab_countries.ResumeLayout(False)
        tab_teams.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents TextBox1 As TextBox
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

End Class
