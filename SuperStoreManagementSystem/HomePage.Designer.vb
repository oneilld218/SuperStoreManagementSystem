<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.id = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.idtext = New System.Windows.Forms.TextBox()
        Me.size = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.compName = New System.Windows.Forms.TextBox()
        Me.unitprice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuperStoreManagementSystemDataSet3 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3()
        Me.AddItems_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddItems_TableTableAdapter = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.AddItems_TableTableAdapter()
        Me.TableAdapterManager = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager()
        Me.AddItems_TableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddItems_TableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AddItems_TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddItems_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddItems_TableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddItems_TableBindingNavigator.SuspendLayout()
        CType(Me.AddItems_TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.White
        Me.id.Location = New System.Drawing.Point(151, 90)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(23, 18)
        Me.id.TabIndex = 32
        Me.id.Text = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(144, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 57)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "STORE'S RECORD"
        '
        'custName
        '
        Me.custName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custName.ForeColor = System.Drawing.Color.Black
        Me.custName.Location = New System.Drawing.Point(154, 135)
        Me.custName.Multiline = True
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(263, 45)
        Me.custName.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Name"
        '
        'type
        '
        Me.type.AutoSize = True
        Me.type.BackColor = System.Drawing.Color.Transparent
        Me.type.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.ForeColor = System.Drawing.Color.White
        Me.type.Location = New System.Drawing.Point(41, 204)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(93, 24)
        Me.type.TabIndex = 36
        Me.type.Text = "Company"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Qty"
        '
        'qty
        '
        Me.qty.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty.ForeColor = System.Drawing.Color.Black
        Me.qty.Location = New System.Drawing.Point(154, 304)
        Me.qty.Multiline = True
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(263, 43)
        Me.qty.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(423, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 367)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(17, 283)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(225, 55)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(17, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(225, 54)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(17, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(225, 55)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(17, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 56)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Controls.Add(Me.idtext)
        Me.GroupBox2.Controls.Add(Me.size)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.compName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.unitprice)
        Me.GroupBox2.Controls.Add(Me.qty)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.custName)
        Me.GroupBox2.Controls.Add(Me.type)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(296, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(685, 460)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        '
        'idtext
        '
        Me.idtext.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtext.ForeColor = System.Drawing.Color.Black
        Me.idtext.Location = New System.Drawing.Point(154, 83)
        Me.idtext.Multiline = True
        Me.idtext.Name = "idtext"
        Me.idtext.Size = New System.Drawing.Size(39, 39)
        Me.idtext.TabIndex = 46
        Me.idtext.Visible = False
        '
        'size
        '
        Me.size.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.size.ForeColor = System.Drawing.Color.Black
        Me.size.Location = New System.Drawing.Point(154, 249)
        Me.size.Multiline = True
        Me.size.Name = "size"
        Me.size.Size = New System.Drawing.Size(263, 43)
        Me.size.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 24)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Size"
        '
        'compName
        '
        Me.compName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compName.ForeColor = System.Drawing.Color.Black
        Me.compName.Location = New System.Drawing.Point(154, 192)
        Me.compName.Multiline = True
        Me.compName.Name = "compName"
        Me.compName.Size = New System.Drawing.Size(263, 45)
        Me.compName.TabIndex = 43
        '
        'unitprice
        '
        Me.unitprice.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitprice.ForeColor = System.Drawing.Color.Black
        Me.unitprice.Location = New System.Drawing.Point(154, 359)
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.Size = New System.Drawing.Size(263, 42)
        Me.unitprice.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Unit Price"
        '
        'SuperStoreManagementSystemDataSet3
        '
        Me.SuperStoreManagementSystemDataSet3.DataSetName = "SuperStoreManagementSystemDataSet3"
        Me.SuperStoreManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AddItems_TableBindingSource
        '
        Me.AddItems_TableBindingSource.DataMember = "AddItems_Table"
        Me.AddItems_TableBindingSource.DataSource = Me.SuperStoreManagementSystemDataSet3
        '
        'AddItems_TableTableAdapter
        '
        Me.AddItems_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddItems_TableTableAdapter = Me.AddItems_TableTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_TableTableAdapter = Nothing
        Me.TableAdapterManager.Employee_TableTableAdapter = Nothing
        Me.TableAdapterManager.Place_Order_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AddItems_TableBindingNavigator
        '
        Me.AddItems_TableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AddItems_TableBindingNavigator.BindingSource = Me.AddItems_TableBindingSource
        Me.AddItems_TableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AddItems_TableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AddItems_TableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AddItems_TableBindingNavigatorSaveItem})
        Me.AddItems_TableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AddItems_TableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AddItems_TableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AddItems_TableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AddItems_TableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AddItems_TableBindingNavigator.Name = "AddItems_TableBindingNavigator"
        Me.AddItems_TableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AddItems_TableBindingNavigator.Size = New System.Drawing.Size(1070, 25)
        Me.AddItems_TableBindingNavigator.TabIndex = 45
        Me.AddItems_TableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'AddItems_TableBindingNavigatorSaveItem
        '
        Me.AddItems_TableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddItems_TableBindingNavigatorSaveItem.Image = CType(resources.GetObject("AddItems_TableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AddItems_TableBindingNavigatorSaveItem.Name = "AddItems_TableBindingNavigatorSaveItem"
        Me.AddItems_TableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AddItems_TableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AddItems_TableDataGridView
        '
        Me.AddItems_TableDataGridView.AutoGenerateColumns = False
        Me.AddItems_TableDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AddItems_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AddItems_TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AddItems_TableDataGridView.DataSource = Me.AddItems_TableBindingSource
        Me.AddItems_TableDataGridView.Location = New System.Drawing.Point(322, 484)
        Me.AddItems_TableDataGridView.Name = "AddItems_TableDataGridView"
        Me.AddItems_TableDataGridView.Size = New System.Drawing.Size(639, 260)
        Me.AddItems_TableDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "company"
        Me.DataGridViewTextBoxColumn3.HeaderText = "company"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "size"
        Me.DataGridViewTextBoxColumn4.HeaderText = "size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn6.HeaderText = "unit_price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 771)
        Me.GroupBox3.TabIndex = 46
        Me.GroupBox3.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(0, 138)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(200, 92)
        Me.Button9.TabIndex = 34
        Me.Button9.Text = "HOME"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SuperStoreManagementSystem.My.Resources.Resources.trolly1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, -16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 175)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(0, 228)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(200, 92)
        Me.Button8.TabIndex = 33
        Me.Button8.Text = "CUSTOMER DETAIL"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(0, 315)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(200, 92)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "PLACE ORDER"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 404)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(200, 92)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "EMPLOYEE DETAIL"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-3, 636)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(203, 80)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 756)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.AddItems_TableDataGridView)
        Me.Controls.Add(Me.AddItems_TableBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "HomePage"
        Me.Text = "Super Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddItems_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddItems_TableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddItems_TableBindingNavigator.ResumeLayout(False)
        Me.AddItems_TableBindingNavigator.PerformLayout()
        CType(Me.AddItems_TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents custName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents type As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents qty As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents size As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents compName As TextBox
    Friend WithEvents unitprice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents idtext As TextBox
    Friend WithEvents SuperStoreManagementSystemDataSet3 As SuperStoreManagementSystemDataSet3
    Friend WithEvents AddItems_TableBindingSource As BindingSource
    Friend WithEvents AddItems_TableTableAdapter As SuperStoreManagementSystemDataSet3TableAdapters.AddItems_TableTableAdapter
    Friend WithEvents TableAdapterManager As SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents AddItems_TableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AddItems_TableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AddItems_TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
