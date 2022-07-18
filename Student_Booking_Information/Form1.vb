Public Class Form1
    Dim ph_number(3) As String
    Dim counter As Integer = 0
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then 'empty validation on Student Name
            MsgBox("Please ener the name, it can't be empty")
        ElseIf (TextBox2.Text = "") Then
            MsgBox("Please enter the phone number, you can't leave it empty")
        ElseIf IsNumeric(TextBox2.Text) = False Then  'Number validation
            MsgBox("You can only type digits for mobile number")

        ElseIf (TextBox3.Text = "") Then 'Empty validation on Email
            MsgBox("Please enter the email, it can't be empty")
        ElseIf (RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False) Then
            MsgBox("Please select the course option")  'Validation on RadioButton
        ElseIf (CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False) Then
            MsgBox("Please select the communication preferences") 'Validation on CheckBox
        Else
            ListBox1.Items.Clear() 'Clear the ListBox
            ListBox1.Items.Add("----------------Student Detail Summary----------------------")
            ListBox1.Items.Add("Student's Name: " + TextBox1.Text)
            ListBox1.Items.Add("D.O.B: " + DateTimePicker1.Value.Date)

            If (counter < 3) Then
                ph_number(counter) = TextBox2.Text
                counter = counter + 1
            End If
            For i = 1 To counter
                ListBox1.Items.Add("Phone Number " + i.ToString() + " - " + ph_number(i - 1))
            Next

            ListBox1.Items.Add("Email: " + TextBox3.Text)
                If (RadioButton1.Checked) Then
                    ListBox1.Items.Add("Course: " + RadioButton1.Text)
                End If
                If (RadioButton1.Checked) Then
                    ListBox1.Items.Add("Course: " + RadioButton2.Text)
                End If
                If (RadioButton3.Checked) Then
                    ListBox1.Items.Add("Course: " + RadioButton3.Text)
                End If
                If (CheckBox1.Checked) Then
                    ListBox1.Items.Add("Communication: " + CheckBox1.Text)
                End If
                If (CheckBox2.Checked) Then
                    ListBox1.Items.Add("Communication: " + CheckBox2.Text)
                End If
                If (CheckBox3.Checked) Then
                    ListBox1.Items.Add("Communication: " + CheckBox3.Text)
                End If
                ListBox1.Items.Add("-------------------Information Added-----------------------")
            counter = 0
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (counter < 2) Then
            If (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If (TextBox2.Text = "") Then
                    MsgBox("Please enter the phone number, you can't leave it empty")
                ElseIf IsNumeric(TextBox2.Text) = False Then  'Number validation
                    MsgBox("You can only type digits for mobile number")
                Else
                    ph_number(counter) = TextBox2.Text
                    counter = counter + 1
                    TextBox2.Text = ""
                End If
            End If
        Else
            MessageBox.Show("You can only add three phone numbers")
        End If

    End Sub
End Class
