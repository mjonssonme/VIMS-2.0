<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        searchTab = New TabControl()
        TabPageSearch = New TabPage()
        btnSearch = New Button()
        btnReset = New Button()
        txtVIN = New TextBox()
        Label1 = New Label()
        vDataTab = New TabPage()
        txtYear = New TextBox()
        txtModel = New TextBox()
        txtMake = New TextBox()
        txtVINData = New TextBox()
        LabelYear = New Label()
        LabelModel = New Label()
        LabelMake = New Label()
        LabelVin = New Label()
        searchTab.SuspendLayout()
        TabPageSearch.SuspendLayout()
        vDataTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' searchTab
        ' 
        searchTab.Controls.Add(TabPageSearch)
        searchTab.Controls.Add(vDataTab)
        searchTab.Location = New Point(0, 0)
        searchTab.Name = "searchTab"
        searchTab.SelectedIndex = 0
        searchTab.Size = New Size(2250, 1298)
        searchTab.TabIndex = 0
        searchTab.Tag = ""' 
        ' TabPageSearch
        ' 
        TabPageSearch.Controls.Add(btnSearch)
        TabPageSearch.Controls.Add(btnReset)
        TabPageSearch.Controls.Add(txtVIN)
        TabPageSearch.Controls.Add(Label1)
        TabPageSearch.Location = New Point(8, 46)
        TabPageSearch.Name = "TabPageSearch"
        TabPageSearch.Padding = New Padding(3)
        TabPageSearch.Size = New Size(2234, 1244)
        TabPageSearch.TabIndex = 0
        TabPageSearch.Text = "Search"
        TabPageSearch.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.Location = New Point(443, 192)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(150, 46)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(271, 192)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(150, 46)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' txtVIN
        ' 
        txtVIN.Location = New Point(149, 113)
        txtVIN.Name = "txtVIN"
        txtVIN.PlaceholderText = "VIN"
        txtVIN.Size = New Size(444, 39)
        txtVIN.TabIndex = 1
        txtVIN.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 32)
        Label1.TabIndex = 0
        Label1.Text = "VIN:"' 
        ' vDataTab
        ' 
        vDataTab.Controls.Add(txtYear)
        vDataTab.Controls.Add(txtModel)
        vDataTab.Controls.Add(txtMake)
        vDataTab.Controls.Add(txtVINData)
        vDataTab.Controls.Add(LabelYear)
        vDataTab.Controls.Add(LabelModel)
        vDataTab.Controls.Add(LabelMake)
        vDataTab.Controls.Add(LabelVin)
        vDataTab.Location = New Point(8, 46)
        vDataTab.Name = "vDataTab"
        vDataTab.Padding = New Padding(3)
        vDataTab.Size = New Size(2234, 1244)
        vDataTab.TabIndex = 1
        vDataTab.Text = "Vehicle Data"
        vDataTab.UseVisualStyleBackColor = True
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(149, 331)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(444, 39)
        txtYear.TabIndex = 9
        txtYear.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtModel
        ' 
        txtModel.Location = New Point(149, 255)
        txtModel.Name = "txtModel"
        txtModel.Size = New Size(444, 39)
        txtModel.TabIndex = 7
        txtModel.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtMake
        ' 
        txtMake.Location = New Point(149, 184)
        txtMake.Name = "txtMake"
        txtMake.Size = New Size(444, 39)
        txtMake.TabIndex = 5
        txtMake.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtVINData
        ' 
        txtVINData.Location = New Point(149, 113)
        txtVINData.Name = "txtVINData"
        txtVINData.PlaceholderText = "VIN"
        txtVINData.Size = New Size(444, 39)
        txtVINData.TabIndex = 3
        txtVINData.TextAlign = HorizontalAlignment.Center
        ' 
        ' LabelYear
        ' 
        LabelYear.AutoSize = True
        LabelYear.Location = New Point(85, 334)
        LabelYear.Name = "LabelYear"
        LabelYear.Size = New Size(63, 32)
        LabelYear.TabIndex = 8
        LabelYear.Text = "Year:"
        LabelYear.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelModel
        ' 
        LabelModel.AutoSize = True
        LabelModel.Location = New Point(60, 258)
        LabelModel.Name = "LabelModel"
        LabelModel.Size = New Size(88, 32)
        LabelModel.TabIndex = 6
        LabelModel.Text = "Model:"
        LabelModel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelMake
        ' 
        LabelMake.AutoSize = True
        LabelMake.Location = New Point(70, 187)
        LabelMake.Name = "LabelMake"
        LabelMake.Size = New Size(78, 32)
        LabelMake.TabIndex = 4
        LabelMake.Text = "Make:"
        LabelMake.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LabelVin
        ' 
        LabelVin.AutoSize = True
        LabelVin.Location = New Point(90, 116)
        LabelVin.Name = "LabelVin"
        LabelVin.Size = New Size(58, 32)
        LabelVin.TabIndex = 2
        LabelVin.Text = "VIN:"
        LabelVin.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2252, 1304)
        Controls.Add(searchTab)
        Name = "Form1"
        Text = "VIMS"
        searchTab.ResumeLayout(False)
        TabPageSearch.ResumeLayout(False)
        TabPageSearch.PerformLayout()
        vDataTab.ResumeLayout(False)
        vDataTab.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents searchTab As TabControl
    Friend WithEvents TabPageSearch As TabPage
    Friend WithEvents vDataTab As TabPage
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtVINData As TextBox
    Friend WithEvents LabelYear As Label
    Friend WithEvents LabelModel As Label
    Friend WithEvents LabelMake As Label
    Friend WithEvents LabelVin As Label
End Class
