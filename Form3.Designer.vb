<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildrenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseholdQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeoplesTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBankDataSet4 = New FoodBank.FoodBankDataSet4()
        Me.VisitorNametxt = New System.Windows.Forms.TextBox()
        Me.VisitorLastxt = New System.Windows.Forms.TextBox()
        Me.VisitorAddresstxt = New System.Windows.Forms.TextBox()
        Me.VisitorChildrenstxt = New System.Windows.Forms.TextBox()
        Me.AddnewBt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VisitorHouseQtytxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PeoplesTableTableAdapter = New FoodBank.FoodBankDataSet4TableAdapters.peoplesTableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeoplesTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBankDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ChildrenDataGridViewTextBoxColumn, Me.HouseholdQtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PeoplesTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 307)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 188)
        Me.DataGridView1.TabIndex = 0
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ChildrenDataGridViewTextBoxColumn
        '
        Me.ChildrenDataGridViewTextBoxColumn.DataPropertyName = "Children"
        Me.ChildrenDataGridViewTextBoxColumn.HeaderText = "Children"
        Me.ChildrenDataGridViewTextBoxColumn.Name = "ChildrenDataGridViewTextBoxColumn"
        '
        'HouseholdQtyDataGridViewTextBoxColumn
        '
        Me.HouseholdQtyDataGridViewTextBoxColumn.DataPropertyName = "HouseholdQty"
        Me.HouseholdQtyDataGridViewTextBoxColumn.HeaderText = "HouseholdQty"
        Me.HouseholdQtyDataGridViewTextBoxColumn.Name = "HouseholdQtyDataGridViewTextBoxColumn"
        '
        'PeoplesTableBindingSource
        '
        Me.PeoplesTableBindingSource.DataMember = "peoplesTable"
        Me.PeoplesTableBindingSource.DataSource = Me.FoodBankDataSet4
        '
        'FoodBankDataSet4
        '
        Me.FoodBankDataSet4.DataSetName = "FoodBankDataSet4"
        Me.FoodBankDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitorNametxt
        '
        Me.VisitorNametxt.Location = New System.Drawing.Point(121, 40)
        Me.VisitorNametxt.Name = "VisitorNametxt"
        Me.VisitorNametxt.Size = New System.Drawing.Size(169, 20)
        Me.VisitorNametxt.TabIndex = 1
        '
        'VisitorLastxt
        '
        Me.VisitorLastxt.Location = New System.Drawing.Point(121, 82)
        Me.VisitorLastxt.Name = "VisitorLastxt"
        Me.VisitorLastxt.Size = New System.Drawing.Size(169, 20)
        Me.VisitorLastxt.TabIndex = 2
        '
        'VisitorAddresstxt
        '
        Me.VisitorAddresstxt.Location = New System.Drawing.Point(121, 124)
        Me.VisitorAddresstxt.Name = "VisitorAddresstxt"
        Me.VisitorAddresstxt.Size = New System.Drawing.Size(169, 20)
        Me.VisitorAddresstxt.TabIndex = 3
        '
        'VisitorChildrenstxt
        '
        Me.VisitorChildrenstxt.Location = New System.Drawing.Point(161, 171)
        Me.VisitorChildrenstxt.Name = "VisitorChildrenstxt"
        Me.VisitorChildrenstxt.Size = New System.Drawing.Size(52, 20)
        Me.VisitorChildrenstxt.TabIndex = 4
        '
        'AddnewBt
        '
        Me.AddnewBt.Location = New System.Drawing.Point(121, 263)
        Me.AddnewBt.Name = "AddnewBt"
        Me.AddnewBt.Size = New System.Drawing.Size(169, 23)
        Me.AddnewBt.TabIndex = 6
        Me.AddnewBt.Text = "&Add New Visitor"
        Me.AddnewBt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Children:"
        '
        'VisitorHouseQtytxt
        '
        Me.VisitorHouseQtytxt.Location = New System.Drawing.Point(161, 213)
        Me.VisitorHouseQtytxt.Name = "VisitorHouseQtytxt"
        Me.VisitorHouseQtytxt.Size = New System.Drawing.Size(52, 20)
        Me.VisitorHouseQtytxt.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Houshold # Persons"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(407, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Volunteer:"
        '
        'PeoplesTableTableAdapter
        '
        Me.PeoplesTableTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 27)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Log &Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(312, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(247, 242)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 528)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.VisitorHouseQtytxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddnewBt)
        Me.Controls.Add(Me.VisitorChildrenstxt)
        Me.Controls.Add(Me.VisitorAddresstxt)
        Me.Controls.Add(Me.VisitorLastxt)
        Me.Controls.Add(Me.VisitorNametxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Visitor Log"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeoplesTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBankDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents VisitorNametxt As TextBox
    Friend WithEvents VisitorLastxt As TextBox
    Friend WithEvents VisitorAddresstxt As TextBox
    Friend WithEvents VisitorChildrenstxt As TextBox
    Friend WithEvents AddnewBt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents VisitorHouseQtytxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents FoodBankDataSet4 As FoodBankDataSet4
    Friend WithEvents PeoplesTableBindingSource As BindingSource
    Friend WithEvents PeoplesTableTableAdapter As FoodBankDataSet4TableAdapters.peoplesTableTableAdapter
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChildrenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HouseholdQtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
