'Brandon Jones
'10/2/21
'Hotel Occupancy

Public Class Form1
    Const intROOMS As Integer = 30                              'number of rooms
    Const intFLOORS As Integer = 8                              'number of floors
    Const intTOTAL_ROOMS As Integer = intROOMS * intFLOORS      'Total rooms
    Dim intTotalRoomsOccupied As Integer = 0                    'Hold total number of rooms
    Dim dblOverallOccupancyRate As Double = 0.0                 'Hold overall occupancy rate


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Get Out
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear the listbox items
        DataListBox.Items.Clear()

        'set boxes to empty
        TotOccupiedLbl.Text = String.Empty
        OverallRateLbl.Text = String.Empty
        FloorsComboBox.SelectedIndex = 0
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim intRoomsOccupied As Integer
        Dim dblOccupancyRate As Double

        If Integer.TryParse(NumRoomsTextbox.Text, intRoomsOccupied) Then
            intTotalRoomsOccupied += intRoomsOccupied
            dblOccupancyRate = intRoomsOccupied / intROOMS

            DataListBox.Items.Add("Floor: " & FloorsComboBox.Text &
                                  " Rooms Occupied: " & intRoomsOccupied.ToString &
                                  " Occupancy Rate: " & dblOccupancyRate.ToString("p"))

            'Calculate the overall occupancy rate for all of the floors
            dblOverallOccupancyRate = intTotalRoomsOccupied / intTOTAL_ROOMS

            'Display the results
            TotOccupiedLbl.Text = intTotalRoomsOccupied.ToString()
            OverallRateLbl.Text = dblOverallOccupancyRate.ToString("p")
            If FloorsComboBox.SelectedIndex < intFLOORS - 1 Then
                FloorsComboBox.SelectedIndex += 1
            End If
            NumRoomsTextbox.Clear()
        Else
            MessageBox.Show("Please enter an integer value")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FloorsComboBox.SelectedIndex = 0
    End Sub
End Class
