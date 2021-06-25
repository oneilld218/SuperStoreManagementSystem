Imports System.Data.SqlClient

Public Class CustomerDetail

    Dim con As SqlConnection = New SqlConnection()
    Dim commd As SqlCommand = New SqlCommand()
    Dim sql As String
    Dim dr As SqlDataReader
    Dim da As New SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim cust As Object

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        EmployeeDetail.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customer_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Customer_TableBindingSource2.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.SuperStoreManagementSystemDataSet3)

    End Sub

    Private Sub CustomerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuperStoreManagementSystemDataSet3.Customer_Table' table. You can move, or remove it, as needed.
        Me.Customer_TableTableAdapter1.Fill(Me.SuperStoreManagementSystemDataSet3.Customer_Table)

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True"

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from Customer_Table"
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf contact.Text = "" Then
            MsgBox("Please provide Contcat!")
        ElseIf email.Text = "" Then
            MsgBox("Please provide Email!")
        ElseIf city.Text = "" Then
            MsgBox("Please provide City!")
        ElseIf address.Text = "" Then
            MsgBox("Please provide Address!")
        Else

            con.Open()
            sql = "insert into Customer_Table values (" & id.Text & ", '" & custName.Text & "', '" & address.Text & "', '" & city.Text & "', '" & contact.Text & "', '" & email.Text & "')"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Customer Information Inserted Successfully!")


            custName.Text = ""
            address.Text = ""
            city.Text = ""
            contact.Text = ""
            email.Text = ""


            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from Customer_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                Customer_TableDataGridView1.DataSource = New BindingSource(dt, cust)

            End Using



            con.Open()
            sql = "select nextID=MAX(ID) + 1 from Customer_Table"
            commd = New SqlCommand(sql, con)
            dr = commd.ExecuteReader

            If dr.Read Then
                id.Text = dr.GetValue(0).ToString
                If id.Text = "" Then
                    id.Text = 1
                End If
            End If
            con.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf contact.Text = "" Then
            MsgBox("Please provide Contcat!")
        ElseIf email.Text = "" Then
            MsgBox("Please provide Email!")
        ElseIf city.Text = "" Then
            MsgBox("Please provide City!")
        ElseIf address.Text = "" Then
            MsgBox("Please provide Address!")
        Else

            con.Open()

            sql = "Update Customer_Table set address = '" & address.Text & "' , city = '" & city.Text & "', contcat = '" & contact.Text & "' , email = '" & email.Text & "'
            where name = '" & custName.Text & "'"
            MsgBox(sql)
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Customer detail updated successfully!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "select * from Customer_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                Customer_TableDataGridView1.DataSource = New BindingSource(dt, cust)

            End Using
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        Else
            con.Open()
            sql = "delete from Customer_Table where name = '" & custName.Text & "'"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Customer detail deleted successfully!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "select * from Customer_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                Customer_TableDataGridView1.DataSource = New BindingSource(dt, cust)

            End Using
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If custName.Text = "" Then
            MessageBox.Show("Please Provide Name To Delete Record....!")
        Else

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "select * from Customer_Table where name = '" & custName.Text & "'"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                Customer_TableDataGridView1.DataSource = New BindingSource(dt, cust)

            End Using
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Customer_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from Customer_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            Customer_TableDataGridView1.DataSource = New BindingSource(dt, cust)

        End Using
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        HomePage.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PlaceOrder.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmployeeDetail.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()

    End Sub
End Class