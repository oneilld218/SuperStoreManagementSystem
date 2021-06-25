<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaceOrder
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
        Me.id = New System.Windows.Forms.Label()
        Me.itemname = New System.Windows.Forms.TextBox()
        Me.qtty = New System.Windows.Forms.TextBox()
        Me.totalprice = New System.Windows.Forms.TextBox()
        Me.unitprice = New System.Windows.Forms.TextBox()
        Me.dated = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Place_Order_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.deletTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuperStoreManagementSystemDataSet3 = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3()
        Me.Place_Order_TableBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Place_Order_TableTableAdapter = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.Place_Order_TableTableAdapter()
        Me.TableAdapterManager = New SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager()
        Me.Place_Order_TableDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Place_Order_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Place_Order_TableBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Place_Order_TableDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(185, 102)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(21, 18)
        Me.id.TabIndex = 41
        Me.id.Text = "id"
        '
        'itemname
        '
        Me.itemname.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemname.ForeColor = System.Drawing.Color.Black
        Me.itemname.Location = New System.Drawing.Point(185, 173)
        Me.itemname.Multiline = True
        Me.itemname.Name = "itemname"
        Me.itemname.Size = New System.Drawing.Size(263, 43)
        Me.itemname.TabIndex = 40
        '
        'qtty
        '
        Me.qtty.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtty.ForeColor = System.Drawing.Color.Black
        Me.qtty.Location = New System.Drawing.Point(185, 226)
        Me.qtty.Multiline = True
        Me.qtty.Name = "qtty"
        Me.qtty.Size = New System.Drawing.Size(263, 43)
        Me.qtty.TabIndex = 38
        '
        'totalprice
        '
        Me.totalprice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalprice.ForeColor = System.Drawing.Color.Black
        Me.totalprice.Location = New System.Drawing.Point(185, 332)
        Me.totalprice.Multiline = True
        Me.totalprice.Name = "totalprice"
        Me.totalprice.ReadOnly = True
        Me.totalprice.Size = New System.Drawing.Size(263, 43)
        Me.totalprice.TabIndex = 37
        '
        'unitprice
        '
        Me.unitprice.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitprice.ForeColor = System.Drawing.Color.Black
        Me.unitprice.Location = New System.Drawing.Point(185, 279)
        Me.unitprice.Multiline = True
        Me.unitprice.Name = "unitprice"
        Me.unitprice.Size = New System.Drawing.Size(263, 43)
        Me.unitprice.TabIndex = 36
        '
        'dated
        '
        Me.dated.AutoSize = True
        Me.dated.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dated.ForeColor = System.Drawing.Color.Black
        Me.dated.Location = New System.Drawing.Point(64, 144)
        Me.dated.Name = "dated"
        Me.dated.Size = New System.Drawing.Size(38, 18)
        Me.dated.TabIndex = 35
        Me.dated.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(64, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Unit Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(64, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 18)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(64, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Reciept No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(160, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 31)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "PLACE ORDER"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(64, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 18)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Item Name"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(320, 388)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(131, 63)
        Me.Button5.TabIndex = 29
        Me.Button5.Text = "Delete"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(185, 388)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 63)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Place"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Place_Order_TableBindingSource
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.deletTextBox)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dated)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.unitprice)
        Me.GroupBox2.Controls.Add(Me.id)
        Me.GroupBox2.Controls.Add(Me.totalprice)
        Me.GroupBox2.Controls.Add(Me.itemname)
        Me.GroupBox2.Controls.Add(Me.qtty)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(347, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 480)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(64, 332)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(97, 43)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Total Price"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'deletTextBox
        '
        Me.deletTextBox.Location = New System.Drawing.Point(185, 90)
        Me.deletTextBox.Multiline = True
        Me.deletTextBox.Name = "deletTextBox"
        Me.deletTextBox.Size = New System.Drawing.Size(55, 43)
        Me.deletTextBox.TabIndex = 50
        Me.deletTextBox.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(185, 143)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(263, 20)
        Me.DateTimePicker1.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'qty
        '
        Me.qty.DataPropertyName = "qty"
        Me.qty.HeaderText = "qty"
        Me.qty.Name = "qty"
        '
        'unit_price
        '
        Me.unit_price.DataPropertyName = "unit_price"
        Me.unit_price.HeaderText = "unit_price"
        Me.unit_price.Name = "unit_price"
        '
        'total_price
        '
        Me.total_price.DataPropertyName = "total_price"
        Me.total_price.HeaderText = "total_price"
        Me.total_price.Name = "total_price"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Id"
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'item_name
        '
        Me.item_name.DataPropertyName = "item_name"
        Me.item_name.HeaderText = "item_name"
        Me.item_name.Name = "item_name"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn8.HeaderText = "unit_price"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn9.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'SuperStoreManagementSystemDataSet3
        '
        Me.SuperStoreManagementSystemDataSet3.DataSetName = "SuperStoreManagementSystemDataSet3"
        Me.SuperStoreManagementSystemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Place_Order_TableBindingSource1
        '
        Me.Place_Order_TableBindingSource1.DataMember = "Place_Order_Table"
        Me.Place_Order_TableBindingSource1.DataSource = Me.SuperStoreManagementSystemDataSet3
        '
        'Place_Order_TableTableAdapter
        '
        Me.Place_Order_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddItems_TableTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Customer_TableTableAdapter = Nothing
        Me.TableAdapterManager.Employee_TableTableAdapter = Nothing
        Me.TableAdapterManager.Place_Order_TableTableAdapter = Me.Place_Order_TableTableAdapter
        Me.TableAdapterManager.UpdateOrder = SuperStoreManagementSystem.SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Place_Order_TableDataGridView1
        '
        Me.Place_Order_TableDataGridView1.AutoGenerateColumns = False
        Me.Place_Order_TableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Place_Order_TableDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Place_Order_TableDataGridView1.DataSource = Me.Place_Order_TableBindingSource1
        Me.Place_Order_TableDataGridView1.Location = New System.Drawing.Point(275, 496)
        Me.Place_Order_TableDataGridView1.Name = "Place_Order_TableDataGridView1"
        Me.Place_Order_TableDataGridView1.Size = New System.Drawing.Size(643, 220)
        Me.Place_Order_TableDataGridView1.TabIndex = 52
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "item_name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "item_name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "qty"
        Me.DataGridViewTextBoxColumn12.HeaderText = "qty"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "unit_price"
        Me.DataGridViewTextBoxColumn13.HeaderText = "unit_price"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "total_price"
        Me.DataGridViewTextBoxColumn14.HeaderText = "total_price"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn15.HeaderText = "date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.PictureBox1)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 771)
        Me.GroupBox3.TabIndex = 53
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(-3, 636)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(203, 80)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "LOG OUT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PlaceOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.SuperStoreManagementSystem.My.Resources.Resources._65471975_pattaya_thailand_february_22_2016_inside_of_the_tesco_lotus_hypermarket_in_pattaya_tesco_lotus_is_a_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 717)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Place_Order_TableDataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "PlaceOrder"
        Me.Text = "Super Store Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Place_Order_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SuperStoreManagementSystemDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Place_Order_TableBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Place_Order_TableDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Home As LinkLabel
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents id As Label
    Friend WithEvents itemname As TextBox
    Friend WithEvents qtty As TextBox
    Friend WithEvents totalprice As TextBox
    Friend WithEvents unitprice As TextBox
    Friend WithEvents dated As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Place_Order_TableBindingSource As BindingSource
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents unit_price As DataGridViewTextBoxColumn
    Friend WithEvents total_price As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents item_name As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents deletTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SuperStoreManagementSystemDataSet3 As SuperStoreManagementSystemDataSet3
    Friend WithEvents Place_Order_TableBindingSource1 As BindingSource
    Friend WithEvents Place_Order_TableTableAdapter As SuperStoreManagementSystemDataSet3TableAdapters.Place_Order_TableTableAdapter
    Friend WithEvents TableAdapterManager As SuperStoreManagementSystemDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents Place_Order_TableDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
End Class
