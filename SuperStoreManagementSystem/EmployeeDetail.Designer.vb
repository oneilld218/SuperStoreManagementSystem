<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeDetail
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.custName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.city = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.doj = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.salary = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.idLbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DojDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperStoreManagementSystemDataSet2 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet2()
        Me.Employee_TableTableAdapter = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet2TableAdapters.Employee_TableTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.idtext = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperStoreManagementSystemDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(532, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 341)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(40, 282)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(171, 48)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(40, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 46)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Update"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(40, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 49)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(40, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 46)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(96, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 21)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(222, -10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 60)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Employee Detail"
        '
        'custName
        '
        Me.custName.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custName.ForeColor = System.Drawing.Color.Black
        Me.custName.Location = New System.Drawing.Point(249, 99)
        Me.custName.Multiline = True
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(204, 37)
        Me.custName.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(96, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Name"
        '
        'contact
        '
        Me.contact.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.ForeColor = System.Drawing.Color.Black
        Me.contact.Location = New System.Drawing.Point(249, 143)
        Me.contact.Multiline = True
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(204, 37)
        Me.contact.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(96, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 21)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Contact"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(249, 187)
        Me.email.Multiline = True
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(204, 38)
        Me.email.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(96, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 21)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(96, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 21)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Gender"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(250, 234)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 22)
        Me.RadioButton1.TabIndex = 38
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(369, 234)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(78, 22)
        Me.RadioButton2.TabIndex = 39
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(249, 261)
        Me.address.Multiline = True
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(204, 39)
        Me.address.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(96, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Address"
        '
        'city
        '
        Me.city.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city.Location = New System.Drawing.Point(249, 307)
        Me.city.Multiline = True
        Me.city.Name = "city"
        Me.city.Size = New System.Drawing.Size(204, 37)
        Me.city.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(96, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "City"
        '
        'doj
        '
        Me.doj.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doj.Location = New System.Drawing.Point(249, 351)
        Me.doj.Multiline = True
        Me.doj.Name = "doj"
        Me.doj.Size = New System.Drawing.Size(204, 39)
        Me.doj.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(96, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 21)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Date of Joining"
        '
        'salary
        '
        Me.salary.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salary.ForeColor = System.Drawing.Color.Black
        Me.salary.Location = New System.Drawing.Point(250, 397)
        Me.salary.Multiline = True
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(203, 38)
        Me.salary.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(96, 399)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 21)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Salary"
        '
        'idLbl
        '
        Me.idLbl.AutoSize = True
        Me.idLbl.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLbl.ForeColor = System.Drawing.Color.Black
        Me.idLbl.Location = New System.Drawing.Point(258, 75)
        Me.idLbl.Name = "idLbl"
        Me.idLbl.Size = New System.Drawing.Size(14, 18)
        Me.idLbl.TabIndex = 48
        Me.idLbl.Text = " "
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.DojDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeeTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(207, 460)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(945, 216)
        Me.DataGridView1.TabIndex = 49
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'DojDataGridViewTextBoxColumn
        '
        Me.DojDataGridViewTextBoxColumn.DataPropertyName = "doj"
        Me.DojDataGridViewTextBoxColumn.HeaderText = "doj"
        Me.DojDataGridViewTextBoxColumn.Name = "DojDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'EmployeeTableBindingSource
        '
        Me.EmployeeTableBindingSource.DataMember = "Employee_Table"
        Me.EmployeeTableBindingSource.DataSource = Me.SuperStoreManagementSystemDataSet2
        '
        'SuperStoreManagementSystemDataSet2
        '
        Me.SuperStoreManagementSystemDataSet2.DataSetName = "SuperStoreManagementSystemDataSet2"
        Me.SuperStoreManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_TableTableAdapter
        '
        Me.Employee_TableTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.idtext)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.salary)
        Me.GroupBox2.Controls.Add(Me.idLbl)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.doj)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.city)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.custName)
        Me.GroupBox2.Controls.Add(Me.address)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.contact)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.email)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(286, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(790, 449)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        '
        'idtext
        '
        Me.idtext.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtext.ForeColor = System.Drawing.Color.Black
        Me.idtext.Location = New System.Drawing.Point(250, 66)
        Me.idtext.Multiline = True
        Me.idtext.Name = "idtext"
        Me.idtext.Size = New System.Drawing.Size(54, 27)
        Me.idtext.TabIndex = 49
        Me.idtext.Visible = False
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
        Me.GroupBox3.Location = New System.Drawing.Point(1, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 771)
        Me.GroupBox3.TabIndex = 52
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
        'EmployeeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.SuperStoreManagementSystem.My.Resources.Resources._63165186_pattaya_thailand_circa_february_2016_inside_big_c_extra_hypermarket_it_offers_a_wider_range_of_premi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1193, 688)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "EmployeeDetail"
        Me.Text = "Super Store Menagement System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperStoreManagementSystemDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents custName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents contact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents city As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents doj As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents salary As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents idLbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SuperStoreManagementSystemDataSet2 As SuperStoreManagementSystemDataSet2
    Friend WithEvents EmployeeTableBindingSource As BindingSource
    Friend WithEvents Employee_TableTableAdapter As SuperStoreManagementSystemDataSet2TableAdapters.Employee_TableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DojDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents idtext As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
End Class
