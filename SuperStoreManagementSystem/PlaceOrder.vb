Imports System.Data.SqlClient

Public Class PlaceOrder
    'Dim con As SqlConnection = New SqlConnection()
    Dim con As SqlConnection = New SqlConnection()

    Dim commd As SqlCommand = New SqlCommand()
    'Dim commd As SqlCommand = New SqlCommand()
    Dim sql As String
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim placrOrd As Object

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        HomePage.Show()

        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        CustomerDetail.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        EmployeeDetail.Show()
        Me.Hide()
    End Sub


    Private Sub Place_Order_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Place_Order_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperStoreManagementSystemDataSet3)
    End Sub

    Private Sub PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuperStoreManagementSystemDataSet3.Place_Order_Table' table. You can move, or remove it, as needed.
        Me.Place_Order_TableTableAdapter.Fill(Me.SuperStoreManagementSystemDataSet3.Place_Order_Table)


        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Place_Oreder_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            Place_Order_TableDataGridView1.DataSource = New BindingSource(dt, placrOrd)

        End Using


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True"

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Place_Oreder_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            id.Text = dr.GetValue(0).ToString
            If id.Text = "" Then
                id.Text = 1
            End If
        End If

        con.Close()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If itemname.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf unitprice.Text = "" Then
            MsgBox("Please provide UnitPrice!")
        ElseIf qtty.Text = "" Then
            MsgBox("Please provide Quantity!")

        Else
            If totalprice.Text = "" Then
                Dim total As Integer
                total = unitprice.Text * qtty.Text
                totalprice.Text = total
            End If
            con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True"

            con.Open()
            sql = "insert into Place_Oreder_Table values (" & id.Text & ", '" & itemname.Text & "', '" & qtty.Text & "', '" & unitprice.Text & "', '" & totalprice.Text & "','" & DateTimePicker1.Value & "')"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Order Information Added Successfully!")

            itemname.Text = ""
            qtty.Text = ""
            unitprice.Text = ""
            totalprice.Text = ""


            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Place_Oreder_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                Place_Order_TableDataGridView1.DataSource = New BindingSource(dt, placrOrd)

            End Using
            con.Close()
        End If
        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Place_Oreder_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            id.Text = dr.GetValue(0).ToString
            If id.Text = "" Then
                id.Text = 1
            End If
        End If
        con.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Place_Oreder_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            Place_Order_TableDataGridView1.DataSource = New BindingSource(dt, placrOrd)

        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Place_Oreder_Table where item_name = '" & itemname.Text & "'"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            Place_Order_TableDataGridView1.DataSource = New BindingSource(dt, placrOrd)

        End Using

    End Sub



    Private Sub Place_Order_TableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Place_Order_TableBindingSource.CurrentChanged

    End Sub

    Private Sub Place_Order_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If deletTextBox.Visible = False Then
            MessageBox.Show("Please Enter Order Id To Delete Record..!")
            deletTextBox.Visible = True
        Else
            con.Open()
            sql = "delete from Place_Oreder_Table where id = '" & deletTextBox.Text & "'"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Order detail deleted successfully...!")

        End If
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Place_Oreder_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            Place_Order_TableDataGridView1.DataSource = New BindingSource(dt, placrOrd)

        End Using

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Place_Oreder_Table"
        commd = New SqlCommand(sql, con)
        dr = commd.ExecuteReader

        If dr.Read Then
            id.Text = dr.GetValue(0).ToString
            If id.Text = "" Then
                id.Text = 1
            End If
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        total = unitprice.Text * qtty.Text
        totalprice.Text = total
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmployeeDetail.Show()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Show()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CustomerDetail.Show()
        Me.Hide()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HomePage.Show()
        Me.Hide()

    End Sub
End Class