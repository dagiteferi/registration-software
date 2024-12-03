Public Class Form1
    Private idGenerated As Boolean = False ' Flag to indicate if an ID has been generated

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbdep.SelectedIndexChanged
        ' Disable the Register button if the department is changed
        If idGenerated Then
            cmdregistred.Enabled = False
            idGenerated = False
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regular.CheckedChanged
        ' Disable the Register button if the division is changed
        If idGenerated Then
            cmdregistred.Enabled = False
            idGenerated = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles extension.CheckedChanged
        ' Disable the Register button if the division is changed
        If idGenerated Then
            cmdregistred.Enabled = False
            idGenerated = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weekend.CheckedChanged
        ' Disable the Register button if the division is changed
        If idGenerated Then
            cmdregistred.Enabled = False
            idGenerated = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmdregistred_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdregistred.Click
        ' Ensure the ID has been generated
        If Not idGenerated Then
            MessageBox.Show("Please generate an ID before registering.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Increment the global student count
        globalStudentCount += 1

        ' Proceed with the registration
        MessageBox.Show("Registration successful!", "Registration Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Reset the flag for the next user
        idGenerated = False

        ' Reset the form fields to default values
        cmbdep.SelectedIndex = 0 ' Assuming index 0 is "Accounting"
        regular.Checked = True

        ' Set the button text to "Generate ID" after registration
        cmdid.Text = "Generate ID"

        ' Disable the Register button until a new ID is generated
        cmdregistred.Enabled = False
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        ' Close when the exit button is clicked
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set default selections when the form loads
        cmbdep.SelectedIndex = 0 ' Assuming index 0 is "Accounting"
        regular.Checked = True

        ' Disable the Register button initially
        cmdregistred.Enabled = False

        ' Generate and display a default ID
        GenerateDefaultID()
    End Sub

    Private Sub GenerateDefaultID()
        ' Set the default ID to "ACR0000/24"
        Dim departmentCode As String = "AC"
        Dim divisionCode As String = "R"
        Dim studentNumber As String = "0000"
        Dim registrationYear As String = "24"

        Dim defaultID As String = String.Format("{0}{1}/{2}/{3}", departmentCode, divisionCode, studentNumber, registrationYear)
        cmdid.Text = defaultID
    End Sub

    Private Sub GenerateID()
        ' Generate the ID based on the selected criteria 
        Dim departmentCode As String = ""
        Dim divisionCode As String = ""
        Dim studentNumber As Integer = globalStudentCount + 1 ' Use global student count + 1
        Dim registrationYear As String = "24" ' Fixed registration year for this example

        Select Case cmbdep.SelectedItem.ToString()
            Case "Accounting"
                departmentCode = "AC"
            Case "Computer Science"
                departmentCode = "CS"
            Case "Management"
                departmentCode = "MG"
            Case "Business Administration"
                departmentCode = "BA"
            Case "Marketing"
                departmentCode = "MR"
        End Select

        If regular.Checked Then
            divisionCode = "R"
        ElseIf extension.Checked Then
            divisionCode = "E"
        ElseIf weekend.Checked Then
            divisionCode = "W"
        End If

        Dim studentNumberFormatted As String = studentNumber.ToString("D4")
        Dim generatedID As String = String.Format("{0}{1}/{2}/{3}", departmentCode, divisionCode, studentNumberFormatted, registrationYear)

        ' Display the generated ID on the cmdid button
        cmdid.Text = generatedID

        ' Set the flag to indicate that an ID has been generated
        idGenerated = True

        ' Enable the Register button
        cmdregistred.Enabled = True
    End Sub

    Private Sub cmdid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdid.Click
        GenerateID()
    End Sub
End Class
