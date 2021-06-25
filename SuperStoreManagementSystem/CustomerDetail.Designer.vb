<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerDetail
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.custName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.SuperStoreManagementSystemDataSet3 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3()
        Me.Customer_TableBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Customer_TableTableAdapter1 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.Customer_TableTableAdapter()
        Me.TableAdapterManager1 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager()
        Me.Customer_TableDataGridView1 = New System.Windows.Forms.DataGridView()
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
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_TableBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_TableDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Swis721 BlkEx BT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(448, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER DETAIL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(342, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(342, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(342, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(342, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(342, 333)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contact"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(342, 399)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Email"
        '
        'city
        '
        Me.city.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city.Location = New System.Drawing.Point(441, 262)
        Me.city.Multiline = True
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(253, 36)
        Me.city.TabIndex = 10
        '
        'contact
        '
        Me.contact.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(441, 326)
        Me.contact.Multiline = True
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(253, 33)
        Me.contact.TabIndex = 11
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(441, 199)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(253, 35)
        Me.address.TabIndex = 13
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(441, 387)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(253, 34)
        Me.email.TabIndex = 14
        '
        'custName
        '
        Me.custName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custName.Location = New System.Drawing.Point(441, 136)
        Me.custName.Multiline = True
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(253, 35)
        Me.custName.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(806, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 332)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(15, 261)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 44)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(15, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 44)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(15, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 40)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(15, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 43)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Label8"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.BackColor = System.Drawing.Color.Transparent
        Me.id.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(441, 100)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(17, 15)
        Me.id.TabIndex = 28
        Me.id.Text = "id"
        '
        'SuperStoreManagementSystemDataSet3
        '
        Me.SuperStoreManagementSystemDataSet3.DataSetName = "SuperStoreManagementSystemDataSet3"
        Me.SuperStoreManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Customer_TableBindingSource2
        '
        Me.Customer_TableBindingSource2.DataMember = "Customer_Table"
        Me.Customer_TableBindingSource2.DataSource = Me.SuperStoreManagementSystemDataSet3
        '
        'Customer_TableTableAdapter1
        '
        Me.Customer_TableTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AddItems_TableTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Customer_TableTableAdapter = Me.Customer_TableTableAdapter1
        Me.TableAdapterManager1.Employee_TableTableAdapter = Nothing
        Me.TableAdapterManager1.Place_Order_TableTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_TableDataGridView1
        '
        Me.Customer_TableDataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_TableDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Customer_TableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customer_TableDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Customer_TableDataGridView1.DataSource = Me.Customer_TableBindingSource2
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Customer_TableDataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Customer_TableDataGridView1.Location = New System.Drawing.Point(352, 480)
        Me.Customer_TableDataGridView1.Name = "Customer_TableDataGridView1"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_TableDataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Customer_TableDataGridView1.Size = New System.Drawing.Size(640, 220)
        Me.Customer_TableDataGridView1.TabIndex = 28
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn4.HeaderText = "city"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "contcat"
        Me.DataGridViewTextBoxColumn5.HeaderText = "contcat"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "email"
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
        Me.GroupBox3.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 771)
        Me.GroupBox3.TabIndex = 47
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
        'CustomerDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1030, 753)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Customer_TableDataGridView1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.custName)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.city)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CustomerDetail"
        Me.Text = "Super Store  Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_TableBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_TableDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents city As TextBox
    Friend WithEvents contact As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents email As TextBox
    Friend WithEvents custName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CoffeeShopManagementSystemDataSet As SuperStoreManagementSystemDataSet
    Friend WithEvents Customer_TableTableAdapter As SuperStoreManagementSystemDataSetTableAdapters.Customer_TableTableAdapter
    Friend WithEvents TableAdapterManager As SuperStoreManagementSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label8 As Label
    Friend WithEvents id As Label
    Friend WithEvents SuperStoreManagementSystemDataSet3 As SuperStoreManagementSystemDataSet3
    Friend WithEvents Customer_TableBindingSource2 As BindingSource
    Friend WithEvents Customer_TableTableAdapter1 As SuperStoreManagementSystemDataSet3TableAdapters.Customer_TableTableAdapter
    Friend WithEvents TableAdapterManager1 As SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Customer_TableDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
End Class
