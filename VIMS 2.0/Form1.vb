Public Class Form1
    Private vehicles As New List(Of Vehicle)()

    Public Sub New()
        InitializeComponent()

        ' Add 10 random data entries
        vehicles.Add(New Vehicle("1ABCD1234EF567890", "Ford", "Focus", 2012))
        vehicles.Add(New Vehicle("2ABCD1234EF567891", "Toyota", "Camry", 2015))
        vehicles.Add(New Vehicle("3ABCD1234EF567892", "Honda", "Civic", 2013))
        ' ... Add more entries here
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim vin As String = txtVIN.Text
        Dim vehicleData As Vehicle = vehicles.FirstOrDefault(Function(v) v.VIN = vin)

        If vehicleData IsNot Nothing Then
            searchTab.SelectedTab = vDataTab
            txtVINData.Text = vehicleData.VIN
            txtMake.Text = vehicleData.Make
            txtModel.Text = vehicleData.Model
            txtYear.Text = vehicleData.Year.ToString()
        Else
            MessageBox.Show("No vehicle found for the specified VIN.", "Vehicle Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtVIN.Clear()
    End Sub

    Public Class Vehicle
        Public Property VIN As String
        Public Property Make As String
        Public Property Model As String
        Public Property Year As Integer

        Public Sub New(VIN As String, Make As String, Model As String, Year As Integer)
            Me.VIN = VIN
            Me.Make = Make
            Me.Model = Model
            Me.Year = Year
        End Sub
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
