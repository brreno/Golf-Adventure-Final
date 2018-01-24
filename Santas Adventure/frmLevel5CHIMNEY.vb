﻿Public Class frmLevel5CHIMNEY
    Dim Index As Integer = 82
    Dim n(999) As clsPictureBox1
    Dim Tiles As Integer = 111
    Public width As Integer = 40
    Public height As Integer = 40

    Dim GoalLoc As Integer
    Private Sub frmLevel5CHIMNEY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Multiply As Integer = Val(txtCol.Text) * Val(txtRow.Text)
        Dim rows As Integer = Val(txtRow.Text)
        Dim columns As Integer = Val(txtCol.Text)

        Me.Location = New Point(0, 0)
        frmLevel4.Hide()
        Form1.Hide()
        GoalLoc = 97
        pctNotFloor.Tag = 1


        txtCol.Enabled = False
        txtRow.Enabled = False

        Button2.Enabled = False

        'Ben Reno
        frmMainMenu.Hide()
        frmLevel2.Hide()
        frmLevelSelect.Hide()


        For c = 0 To rows * columns - 1
            n(c) = New clsPictureBox1
            Controls.Add(n(c).PictureBox1)
            n(c).PictureBox1.Tag = 5
            n(c).PictureBox1.Image = pctFloor.Image
        Next

        n(82).PictureBox1.Image = pctSanta.Image

        'Change the lines below based on lvls
        'to change score based on Tag is the Tag Lines- changes based on the location of pct box
        ''present location
        n(22).PictureBox1.Image = pctWall.Image
        n(22).PictureBox1.Tag = 1
        n(37).PictureBox1.Image = pctWall.Image
        n(37).PictureBox1.Tag = 1
        n(52).PictureBox1.Image = pctWall.Image
        n(52).PictureBox1.Tag = 1
        n(49).PictureBox1.Image = pctWall.Image
        n(49).PictureBox1.Tag = 1
        n(48).PictureBox1.Image = pctWall.Image
        n(48).PictureBox1.Tag = 1


        n(55).PictureBox1.Image = pctWall.Image
        n(55).PictureBox1.Tag = 1
        'n(40).PictureBox1.Image = pctWall.Image
        'n(40).PictureBox1.Tag = 1
        n(56).PictureBox1.Image = pctWall.Image
        n(56).PictureBox1.Tag = 1
        n(70).PictureBox1.Image = pctWall.Image
        n(70).PictureBox1.Tag = 1
        n(71).PictureBox1.Image = pctWall.Image
        n(71).PictureBox1.Tag = 1
        n(41).PictureBox1.Image = pctPresent.Image
        n(41).PictureBox1.Tag = 2
        For c = 90 To 94
            n(c).PictureBox1.Tag = 1
            n(c).PictureBox1.Image = pctWall.Image
        Next
        For c = 100 To 104
            n(c).PictureBox1.Tag = 1
            n(c).PictureBox1.Image = pctWall.Image
        Next
        For c = 138 To 145
            n(c).PictureBox1.Tag = 1
            n(c).PictureBox1.Image = pctWall.Image
        Next
        n(127).PictureBox1.Image = pctWall.Image
        n(127).PictureBox1.Tag = 1
        n(126).PictureBox1.Image = pctWall.Image
        n(126).PictureBox1.Tag = 1
        n(157).PictureBox1.Image = pctPresent.Image
        n(157).PictureBox1.Tag = 2




        'sets the goals lockation as locked and a different tag
        n(GoalLoc).PictureBox1.Image = pctLocked.Image
        n(GoalLoc).PictureBox1.Tag = 4
        Dim l As Point
        l.X = 40 : l.Y = 80
        For c = 0 To rows * columns - 1
            If c Mod columns = 0 And c <> 0 Then
                l.X = n(0).PictureBox1.Location.X
                l.Y = n(c - 1).PictureBox1.Location.Y + Height
                n(c).PictureBox1.Location = l
            Else
                l.X = l.X + Width
                n(c).PictureBox1.Location = l
            End If
        Next


        'Left
        For c = 0 To (Val(txtCol.Text + 1) * Val(txtRow.Text - 1)) Step Val(txtCol.Text)
            n(c).PictureBox1.Image = pctWall.Image
            n(c).PictureBox1.Tag = 1

        Next

        'Top
        For c = 0 To Val(txtCol.Text - 1)
            n(c).PictureBox1.Image = pctWall.Image
            n(c).PictureBox1.Tag = 1

        Next

        'Bot

        For c = Multiply - Val(txtCol.Text) To Multiply - 1
            n(c).PictureBox1.Image = pctWall.Image
            n(c).PictureBox1.Tag = 1

        Next

        'right

        For c = Val(txtCol.Text - 1) To (Val(txtCol.Text + 1) * Val(txtRow.Text - 1)) Step Val(txtCol.Text)
            n(c).PictureBox1.Image = pctWall.Image
            n(c).PictureBox1.Tag = 1

        Next




        '
    End Sub
    Private Sub frmLevel2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown



        If e.KeyCode = Keys.D Or e.KeyCode = Keys.Right Then
            'block off walls code
            If n(Index + 1).PictureBox1.Tag = 1 Then
                Exit Sub
            End If

            'Presents Pickup code
            If n(Index + 1).PictureBox1.Tag = 2 Then
                lblPresent.Text = lblPresent.Text + 1



            End If

            'to keep a active checker put it in the key press code
            If lblPresent.Text = 2 And lblTiles.Text = Tiles Then
                n(GoalLoc).PictureBox1.Image = pctGoal.Image
                n(GoalLoc).PictureBox1.Tag = 3
            End If

            'Win Code
            If n(Index + 1).PictureBox1.Tag = 3 Then

                lblWIN.Visible = True
                Button2.Enabled = True


            End If



            'if locked cant delete it
            If n(Index + 1).PictureBox1.Tag = 4 Then
                Exit Sub

            End If


            'Count Tiles Taken
            If n(Index + 1).PictureBox1.Tag = 5 Then
                lblTiles.Text = lblTiles.Text + 1

            End If


            'hole code
            'Count Tiles Taken
            If n(Index + 1).PictureBox1.Tag = 6 Then


            End If

            n(Index).PictureBox1.Image = pctNotFloor.Image
            n(Index).PictureBox1.Tag = 1
            Index = Index + 1
            n(Index).PictureBox1.Image = pctSanta.Image
        End If

        If e.KeyCode = Keys.W Or e.KeyCode = Keys.Up Then
            'block off walls code
            If n(Index - Val(txtCol.Text)).PictureBox1.Tag = 1 Then
                Exit Sub
            End If
            'Presents Pickup code
            If n(Index - Val(txtCol.Text)).PictureBox1.Tag = 2 Then
                lblPresent.Text = lblPresent.Text + 1

            End If

            'to keep a active checker put it in the key press code
            If lblPresent.Text = 2 And lblTiles.Text = Tiles Then
                n(GoalLoc).PictureBox1.Image = pctGoal.Image
                n(GoalLoc).PictureBox1.Tag = 3
            End If


            'win code
            If n(Index - Val(txtCol.Text)).PictureBox1.Tag = 3 Then
                lblWIN.Visible = True
                Button2.Enabled = True

            End If

            'if locked cant delete it
            If n(Index - Val(txtCol.Text)).PictureBox1.Tag = 4 Then
                Exit Sub

            End If

            'Count Tiles Taken
            If n(Index - Val(txtCol.Text)).PictureBox1.Tag = 5 Then
                lblTiles.Text = lblTiles.Text + 1

            End If
            n(Index).PictureBox1.Image = pctNotFloor.Image
            n(Index).PictureBox1.Tag = 1
            Index = Index - Val(txtCol.Text)
            n(Index).PictureBox1.Image = pctSanta.Image
        End If

        If e.KeyCode = Keys.S Or e.KeyCode = Keys.Down Then
            'block off walls code
            If n(Index + Val(txtCol.Text)).PictureBox1.Tag = 1 Then
                Exit Sub
            End If
            'Presents Pickup code
            If n(Index + Val(txtCol.Text)).PictureBox1.Tag = 2 Then
                lblPresent.Text = lblPresent.Text + 1

            End If

            'to keep a active checker put it in the key press code
            If lblPresent.Text = 2 And lblTiles.Text = Tiles Then
                n(GoalLoc).PictureBox1.Image = pctGoal.Image
                n(GoalLoc).PictureBox1.Tag = 3
            End If

            'win 
            If n(Index + Val(txtCol.Text)).PictureBox1.Tag = 3 Then
                lblWIN.Visible = True
                Button2.Enabled = True

            End If

            'if locked cant delete it
            If n(Index + Val(txtCol.Text)).PictureBox1.Tag = 4 Then
                Exit Sub

            End If

            'Count Tiles Taken
            If n(Index + Val(txtCol.Text)).PictureBox1.Tag = 5 Then
                lblTiles.Text = lblTiles.Text + 1

            End If
            n(Index).PictureBox1.Image = pctNotFloor.Image
            n(Index).PictureBox1.Tag = 1
            Index = Index + Val(txtCol.Text)
            n(Index).PictureBox1.Image = pctSanta.Image
        End If

        If e.KeyCode = Keys.A Or e.KeyCode = Keys.Left Then
            'block off walls code
            If n(Index - 1).PictureBox1.Tag = 1 Then
                Exit Sub
            End If
            'Presents Pickup code
            If n(Index - 1).PictureBox1.Tag = 2 Then
                lblPresent.Text = lblPresent.Text + 1

            End If


            'to keep a active checker put it in the key press code
            If lblPresent.Text = 2 And lblTiles.Text = Tiles Then
                n(GoalLoc).PictureBox1.Image = pctGoal.Image
                n(GoalLoc).PictureBox1.Tag = 3
            End If


            'win code 
            If n(Index - 1).PictureBox1.Tag = 3 Then
                lblWIN.Visible = True

                Button2.Enabled = True
            End If
            'if locked cant delete it
            If n(Index - 1).PictureBox1.Tag = 4 Then
                Exit Sub

            End If


            'Count Tiles Taken
            If n(Index - 1).PictureBox1.Tag = 5 Then
                lblTiles.Text = lblTiles.Text + 1

            End If
            n(Index).PictureBox1.Image = pctNotFloor.Image
            n(Index).PictureBox1.Tag = 1
            Index = Index - 1
            n(Index).PictureBox1.Image = pctSanta.Image


        End If


        'arrow keys 
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '
        '





    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        '  If lblResets.Text > 0 Then
        Me.Controls.Clear()

            InitializeComponent()

            frmLevel5CHIMNEY_Load(e, e)

            Index = 82

        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Me.Close()
        Form1.Close()
        frmLevel3.Close()
        frmLevel2.Close()
        frmMainMenu.Show()
    End Sub
End Class