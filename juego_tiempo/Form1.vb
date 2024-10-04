Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Public Class Form1
    Private palabras As List(Of String)
    Private palabrasMostradas As List(Of String)
    Private random As Random
    Private currentRound As Integer
    Private totalRounds As Integer
    Private timeLeft As Integer
    Private timer As Timer
    Private easyTime As Integer = 15 ' Tiempo para dificultad fácil
    Private mediumTime As Integer = 10 ' Tiempo para dificultad media
    Private hardTime As Integer = 5 ' Tiempo para dificultad difícil

    Public Sub New()
        InitializeComponent()
        palabras = New List(Of String) From {"amor", "libertad", "felicidad", "paz", "esperanza", "amistad", "familia", "trabajo", "casa", "viaje"}
        palabrasMostradas = New List(Of String)
        random = New Random()
        currentRound = 0
        totalRounds = 5
        timer = New Timer()
        timer.Interval = 1000 ' 1 segundo
        AddHandler timer.Tick, AddressOf Timer_Tick

        cmbDifficulty.Items.AddRange(New String() {"Fácil", "Medio", "Difícil"})
        cmbDifficulty.SelectedIndex = 1 ' Medio por defecto
        AddHandler cmbDifficulty.SelectedIndexChanged, AddressOf cmbDifficulty_SelectedIndexChanged
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        timeLeft -= 1
        lblTimer.Text = $"Tiempo: {timeLeft}s"
        If timeLeft <= 0 Then
            timer.Stop()
            MessageBox.Show("Se acabó el tiempo. Has perdido la ronda.")
            StartNewRound()
        End If
    End Sub

    Private Sub StartNewRound()
        If currentRound >= totalRounds Then
            MessageBox.Show("¡Juego completado!")
            Me.Close()
            Return
        End If

        currentRound += 1
        lblRound.Text = $"Ronda: {currentRound}/{totalRounds}"
        Dim nuevaPalabra As String
        Do
            nuevaPalabra = palabras(random.Next(palabras.Count))
        Loop While palabrasMostradas.Contains(nuevaPalabra)
        palabrasMostradas.Add(nuevaPalabra)
        lblWord.Text = nuevaPalabra
        txtInput.Clear()
        SetTimeLeftBasedOnDifficulty()
        lblTimer.Text = $"Tiempo: {timeLeft}s"
        timer.Start()
    End Sub

    Private Sub SetTimeLeftBasedOnDifficulty()
        Select Case cmbDifficulty.SelectedItem.ToString()
            Case "Fácil"
                timeLeft = easyTime
            Case "Medio"
                timeLeft = mediumTime
            Case "Difícil"
                timeLeft = hardTime
            Case Else
                timeLeft = mediumTime
        End Select
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtInput.Text = lblWord.Text Then
            timer.Stop()
            MessageBox.Show("Palabra correcta. ¡Ronda completada!")
            StartNewRound()
        Else
            MessageBox.Show("Palabra incorrecta. Inténtalo de nuevo.")
            txtInput.Clear()
        End If
    End Sub

    Private Sub cmbDifficulty_SelectedIndexChanged(sender As Object, e As EventArgs)
        SetTimeLeftBasedOnDifficulty()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        cmbDifficulty.Visible = False
        lblTimer.Visible = True
        btnStart.Visible = False
        currentRound = 0
        StartNewRound()
    End Sub
End Class
