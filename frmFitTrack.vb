Imports System.IO
Imports System.Security.Cryptography

Public Class Form1

    Private _decIntensityOne As Decimal = 1.5D
    Private _decIntensityTwo As Decimal = 2D
    Private _decIntensityThree As Decimal = 2.5D

    Private Sub frmFitTrack_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        radWalk.Checked = True
        txtHR.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalc.Click
        'This event calculates the average heart rate and estimated calories burned and displays them in labels in the
        'right panel of the window

        Dim intTotalHR As Integer
        Dim intAvgHR As Integer
        Dim intCount As Integer
        Dim decCalorie As Decimal
        Dim decIntensity As Decimal = 1D

        For Each item As Integer In lstHR.Items
            intTotalHR += item
            intCount += 1
        Next

        intAvgHR = intTotalHR / intCount
        lblHR.Text = intAvgHR & "BPM"
        lblHR.Visible = True

        If radWalk.Checked = True Then
            decIntensity = _decIntensityOne
        ElseIf radJog.Checked = True Then
            decIntensity = _decIntensityTwo
        ElseIf radRun.Checked = True Then
            decIntensity = _decIntensityThree
        End If

        decCalorie = Convert.ToDecimal(intAvgHR) * decIntensity
        lblCalories.Text = decCalorie
        lblCalories.Visible = True
        btnPrint.Enabled = True

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'adds items from the txtHR element to the list box from which average heart rate and
        'estimated calories are calculated from

        Dim intConvHR As Integer

        If Integer.TryParse(txtHR.Text, intConvHR) Then
            lstHR.Items.Add(intConvHR)
            txtHR.Clear()
            btnCalc.Enabled = True
            txtHR.Focus()
        Else
            MsgBox("Please enter an integer value for the heart rate")
            txtHR.Clear()
            txtHR.Focus()
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'btnPrint event takes the currently displayed calories and average heart rate and appends them
        'to an external text document (receipt.txt) for storage

        Dim objWriter As IO.StreamWriter

        Try
            objWriter = IO.File.AppendText("C:\Users\xgarc\source\repos\Final Project - Fitness Tracker\receipt.txt")
            objWriter.WriteLine("On " & DateAndTime.Now & " your average heart rate was: " & lblHR.Text & " and you burned: " & lblCalories.Text & " calories")
        Catch ex As IOException
        End Try

        objWriter.Close()
        btnPrint.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstHR.Items.Clear()
        lblCalories.Text = ""
        lblHR.Text = ""
        lblCalories.Visible = False
        lblHR.Visible = False
        lblHR.Focus()
        radWalk.Checked = True
        radJog.Checked = False
        radRun.Checked = False
        btnCalc.Enabled = False
        btnPrint.Enabled = False
    End Sub

End Class
