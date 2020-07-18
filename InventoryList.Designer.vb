<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inventoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkNewStatus = New System.Windows.Forms.CheckBox()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwInventoryList = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Make:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Audi", "BMW", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Ford", "GMC", "Honda", "Hyundai", "Infiniti", "Jeep", "Kia", "Lexus", "Mazda", "Mitsubishi", "Nissan", "Porsche", "Subaru", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cbMake.Location = New System.Drawing.Point(55, 13)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 21)
        Me.cbMake.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbMake, "Select make of car")
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "M&odel:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(55, 40)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 20)
        Me.tbModel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbModel, "Select model of car")
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&Year:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbYear
        '
        Me.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbYear.FormattingEnabled = True
        Me.cbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbYear.Location = New System.Drawing.Point(55, 67)
        Me.cbYear.Name = "cbYear"
        Me.cbYear.Size = New System.Drawing.Size(121, 21)
        Me.cbYear.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cbYear, "Select year of car")
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Price:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(55, 94)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbPrice, "Select price of car")
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&New:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNewStatus
        '
        Me.chkNewStatus.AutoSize = True
        Me.chkNewStatus.Location = New System.Drawing.Point(55, 123)
        Me.chkNewStatus.Name = "chkNewStatus"
        Me.chkNewStatus.Size = New System.Drawing.Size(15, 14)
        Me.chkNewStatus.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.chkNewStatus, "Check if car is new")
        Me.chkNewStatus.UseVisualStyleBackColor = True
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(0, 328)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(362, 77)
        Me.lbOutput.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.lbOutput, "Displays result")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(125, 408)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Click here, press enter, or press 'e' to submit entry")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(206, 408)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click here, press 'esc', or press 'r' to reset form")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(287, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here or press 'x' to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwInventoryList
        '
        Me.lvwInventoryList.CheckBoxes = True
        Me.lvwInventoryList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.ColMake, Me.ColModel, Me.ColYear, Me.ColPrice})
        Me.lvwInventoryList.FullRowSelect = True
        Me.lvwInventoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwInventoryList.HideSelection = False
        Me.lvwInventoryList.Location = New System.Drawing.Point(0, 143)
        Me.lvwInventoryList.MultiSelect = False
        Me.lvwInventoryList.Name = "lvwInventoryList"
        Me.lvwInventoryList.Size = New System.Drawing.Size(362, 182)
        Me.lvwInventoryList.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.lvwInventoryList, "Displays list of entries")
        Me.lvwInventoryList.UseCompatibleStateImageBehavior = False
        Me.lvwInventoryList.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'ColMake
        '
        Me.ColMake.Text = "Make"
        '
        'ColModel
        '
        Me.ColModel.Text = "Model"
        '
        'ColYear
        '
        Me.ColYear.Text = "Year"
        '
        'ColPrice
        '
        Me.ColPrice.Text = "Price"
        '
        'inventoryForm
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(363, 430)
        Me.Controls.Add(Me.lvwInventoryList)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.chkNewStatus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inventoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbModel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkNewStatus As CheckBox
    Friend WithEvents lbOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lvwInventoryList As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents ColMake As ColumnHeader
    Friend WithEvents ColModel As ColumnHeader
    Friend WithEvents ColYear As ColumnHeader
    Friend WithEvents ColPrice As ColumnHeader
    Friend WithEvents ToolTip1 As ToolTip
End Class
