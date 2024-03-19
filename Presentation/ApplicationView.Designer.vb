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
        GroupBox1.SuspendLayout()
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
        GroupBox1.Location = New Point(12, 12)
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
        ' ApplicationView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(948, 498)
        Controls.Add(GroupBox1)
        Name = "ApplicationView"
        Text = "Formula 1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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

End Class
