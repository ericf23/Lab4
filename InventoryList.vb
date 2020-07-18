Option Strict On
Imports System.Threading

' Author:       Eric Fisher
' Date:         2020-07-16
' Description:  The purpose of this program is to track the inventory for car lot
Public Class inventoryForm
#Region "Variables and Constants"
    'new list of object car
    Dim cars As New List(Of Car)
    Dim editMode As Boolean = False
    Dim updatingData As Boolean = False
    Dim currentlySelectedIndex As Integer = -1
#End Region

#Region "Event Handlers"
    ''' <summary>
    ''' Handle exit button click event
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitClick(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit application
        Application.Exit()
    End Sub

    ''' <summary>
    ''' Handles reset button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ResetClick(sender As Object, e As EventArgs) Handles btnReset.Click
        'call reset form function
        ResetForm()
    End Sub

    ''' <summary>
    ''' Handle enter button click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EnterClick(sender As Object, e As EventArgs) Handles btnEnter.Click
        'intialize new variables to form input fields
        Dim inputMake As String = cbMake.Text
        Dim inputModel As String = tbModel.Text
        Dim inputYear As Integer = CInt(cbYear.Text)
        Dim inputPrice As Decimal = CDec(tbPrice.Text)
        Dim inputNewStatus = chkNewStatus.Checked
        'initialize errors to the Errormessage returned from ValidateInputs
        Dim errors As String = ValidateInputs(inputMake, inputModel, inputYear, inputPrice)
        'intialize vairable to object car
        Dim car As Car

        'Check to see if there are errors
        If (String.IsNullOrEmpty(errors)) Then
            'Validation success

            If (editMode = True) Then
                'update an existing car

                cars(currentlySelectedIndex).Make = inputMake
                cars(currentlySelectedIndex).Model = inputModel
                cars(currentlySelectedIndex).Year = inputYear
                cars(currentlySelectedIndex).Price = inputPrice
                cars(currentlySelectedIndex).NewStatus = inputNewStatus

                'call UpdateCarList function
                UpdateCarList()
                'call ResetForm function
                ResetForm()

                lbOutput.Text = "Updated car"
            Else
                'creating new car
                car = New Car(inputMake, inputModel, inputYear, inputPrice, inputNewStatus)
                'add new created car to list cars
                cars.Add(car)
                'reset form
                ResetForm()

                lbOutput.Text = "Car data updated"
                'update list of cars in listview
                UpdateCarList()
            End If
        Else
            'validation unsuccessful - display errors
            lbOutput.Text = errors
        End If

    End Sub

    ''' <summary>
    ''' Handles selection of car from list
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListSelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwInventoryList.SelectedIndexChanged
        Dim car As Car
        If (Not lvwInventoryList.FocusedItem Is Nothing) Then
            currentlySelectedIndex = lvwInventoryList.FocusedItem.Index
            car = cars(currentlySelectedIndex)

            editMode = True

            'Assign user inputs to class properties
            cbMake.Text = car.Make
            tbModel.Text = car.Model
            cbYear.Text = car.Year.ToString
            tbPrice.Text = car.Price.ToString
            chkNewStatus.Checked = car.NewStatus

            lbOutput.Text = "Loaded car data to update"
        End If
    End Sub

    ''' <summary>
    ''' Prevent the user from using checkboxes in listview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwInventoryList.ItemCheck
        'If field not updated with new data, leave it the way it was
        If (Not updatingData) Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

#End Region

#Region "Subroutines and Functions"
    ''' <summary>
    ''' Validate inputs
    ''' </summary>
    ''' <returns>Status of error message, empty if no errors</returns>
    Function ValidateInputs(make As String, model As String, year As Integer, price As Decimal) As String
        Dim errorMessage As String = String.Empty


        'Validation for make
        If (String.IsNullOrWhiteSpace(make)) Then
            errorMessage += "Please select a valid make" & Environment.NewLine
        End If

        'Validation for model
        If (String.IsNullOrWhiteSpace(model)) Then
            errorMessage += "Please enter a valid model" & Environment.NewLine
        End If

        'Validation for year
        If (year = Nothing) Then
            errorMessage += "Please select a valid year" & Environment.NewLine
        End If

        'Validation for price (checks price is greater than zero)
        If (price = Nothing Or price < 0) Then
            errorMessage += "Please enter a valid price" & Environment.NewLine
        End If

        Return errorMessage
    End Function

    ''' <summary>
    ''' Resets the form to to its inital values
    ''' </summary>
    Private Sub ResetForm()
        lvwInventoryList.SelectedIndices.Clear()

        'clear make combo box
        cbMake.SelectedIndex = -1
        'empty model textbox
        tbModel.Text = String.Empty
        'clear year combo box
        cbYear.SelectedIndex = -1
        'empty price textbox
        tbPrice.Text = String.Empty
        'uncheck newStatus checkbox
        chkNewStatus.Checked = False
        'set editMode back to false
        editMode = False

        lbOutput.Text = "Reset form"
    End Sub

    ''' <summary>
    ''' Reloads current list of cars into listview
    ''' </summary>

    Private Sub UpdateCarList()
        Dim carListItem As ListViewItem

        updatingData = True
        'clear input fields
        lvwInventoryList.Items.Clear()

        For Each car As Car In cars
            carListItem = New ListViewItem()

            carListItem.Checked = car.NewStatus
            carListItem.SubItems.Add(car.InternalId.ToString)
            carListItem.SubItems.Add(car.Make)
            carListItem.SubItems.Add(car.Model)
            carListItem.SubItems.Add(car.Year.ToString)
            carListItem.SubItems.Add(car.Price.ToString)

            lvwInventoryList.Items.Add(carListItem)
        Next
        updatingData = False
    End Sub
#End Region
End Class
