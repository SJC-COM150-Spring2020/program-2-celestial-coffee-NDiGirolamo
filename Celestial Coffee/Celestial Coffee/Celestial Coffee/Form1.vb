Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Declare Regular and Decaf as a Double
        Dim Regular As Double
        Dim Decaf As Double

        'Cast values from textboxes as Doubles
        Regular = CDbl(txtRegular.Text * 3.99)
        Decaf = CDbl(txtDecaf.Text * 2.49)

        'Declare Tax as a constant and the Total as a Double
        Const TAX As Double = 0.08875
        Dim Total As Double

        'Cast values to Doubles with Total Price formula
        Total = CDbl((Regular + Decaf) * TAX + (Regular + Decaf))
        'When user clicks the Calculate button, the Total will appear in the textbox
        txtTotal.Text = FormatCurrency(Total, 2)

    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        'Declare Name, Address, City, State, and Zip Code as variables
        Dim Name As String = txtName.Text
        Dim Address As String = txtAddress.Text
        Dim City As String = txtCity.Text
        Dim State As String = txtState.Text
        Dim Zip As String = txtZip.Text

        'When the user clicks the Confirm Order button after entering their personal information, the Confirmation Message will appear in the text box
        lstMessage.Items.Add("Thank you " & txtName.Text & " for ")
        lstMessage.Items.Add("ordering our coffee today!")
        lstMessage.Items.Add("Your order will be shipped to;")
        lstMessage.Items.Add(txtAddress.Text & ", " & txtCity.Text & ", ")
        lstMessage.Items.Add(txtState.Text & ", " & txtZip.Text & ".")

    End Sub
End Class