Imports System.Data.SqlClient

Public Class HomePage

    Dim con As SqlConnection = New SqlConnection()
    Dim commd As SqlCommand = New SqlCommand()
    Dim sql As String
    Dim dr As SqlDataReader
    Dim typee As String
    Dim da As New SqlDataAdapter
    Dim dt As DataTable
    Dim dv As DataView
    Dim addCoffee As Object






    Private Sub Home_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from AddItems_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Addcoffee_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AddItems_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperStoreManagementSystemDataSet3)

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SuperStoreManagementSystemDataSet3.AddItems_Table' table. You can move, or remove it, as needed.
        Me.AddItems_TableTableAdapter.Fill(Me.SuperStoreManagementSystemDataSet3.AddItems_Table)


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True"

        con.Open()
        sql = "select nextID=MAX(ID) + 1 from AddItems_Table"
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

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf compName.Text = "" Then
            MsgBox("Please select Company Name!")
        ElseIf qty.Text = "" Then
            MsgBox("Please provide Quantity!")
        ElseIf size.Text = "" Then
            MsgBox("Please provide Size")
        ElseIf unitprice.Text = "" Then
            MsgBox("Please provide Unit Price!")
        Else

            con.Open()
            sql = "insert into AddItems_Table values (" & id.Text & ", '" & custName.Text & "', '" & compName.Text & "', '" & size.Text & "','" & qty.Text & "', '" & unitprice.Text & "')"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Information Inserted Successfully!")

            id.Text = ""
            custName.Text = ""
            compName.Text = ""
            size.Text = ""
            unitprice.Text = ""
            qty.Text = ""


            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from AddItems_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using


            con.Open()
            sql = "select nextID=MAX(ID) + 1 from AddItems_Table"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If custName.Text = "" Then
            MessageBox.Show("Please Eneter Item Name To Search Recored..!")

        Else

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from AddItems_Table where name = '" & custName.Text & "' "
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using
        End If
    End Sub

    Private Sub Addcoffee_TableDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If custName.Text = "" Then
            MsgBox("Please provide vlaue for Name!")
        ElseIf compName.Text = "" Then
            MsgBox("Please select Company Name!")
        ElseIf qty.Text = "" Then
            MsgBox("Please provide Quantity!")
        ElseIf size.Text = "" Then
            MsgBox("Please provide Size")
        ElseIf unitprice.Text = "" Then
            MsgBox("Please provide Unit Price!")
        Else
            con.Open()

            sql = "Update AddItems_Table set name = '" & custName.Text & "' , company = '" & compName.Text & "', size = '" & size.Text & "' , qty = '" & qty.Text & "', unit_price = '" & unitprice.Text & "'
            where name = '" & custName.Text & "'"
            MsgBox(sql)
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox(" Detail updated successfully!")

            Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
                sql = "Select * from AddItems_Table"
                commd = New SqlCommand(sql, con)
                da = New SqlDataAdapter(commd)
                dt = New DataTable()
                dv = New DataView()
                da.Fill(dt)
                AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

            End Using
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If idtext.Visible = False Then
            MessageBox.Show("Please Enter Item Record Id To Delete Record..!")
            idtext.Visible = True
        Else
            con.Open()
            sql = "delete from AddItems_Table where id = '" & idtext.Text & "'"
            commd = New SqlCommand(sql, con)
            commd.ExecuteNonQuery()
            con.Close()
            MsgBox("Recored deleted successfully...!")

        End If

        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from AddItems_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using


        con.Open()
        sql = "select nextID=MAX(ID) + 1 from AddItems_Table"
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

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from AddItems_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)

        End Using
    End Sub

    Private Sub AddItems_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AddItems_TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AddItems_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SuperStoreManagementSystemDataSet3)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmployeeDetail.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PlaceOrder.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CustomerDetail.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Using con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Visual Studio Projects\SuperStoreManagementSystem\SuperStoreManagementSystem\SuperStoreManagementSystem.mdf;Integrated Security=True")
            sql = "Select * from AddItems_Table"
            commd = New SqlCommand(sql, con)
            da = New SqlDataAdapter(commd)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            AddItems_TableDataGridView.DataSource = New BindingSource(dt, addCoffee)
            con.Close()
        End Using

    End Sub


End Class