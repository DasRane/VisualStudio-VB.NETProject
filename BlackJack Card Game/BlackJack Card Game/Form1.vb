
Public Class Form1
    Dim Rand1 As New Random
    Dim Rand2 As New Random
    Dim Rand3 As New Random
    Dim Rand4 As New Random
    Dim Rand5 As New Random
    Dim Rand6 As New Random
    Dim Rand7 As New Random
    Dim rand8 As New Random

    Dim win As Integer


    'DEALER
    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btdealdealer.Click

        'TAHAP PERTAMA : MENCOBA MEMBUAT PROGRAM UNTUK MENGACAK KARTU TERLEBIH DAHULU 

        'menampilkan angka acak dari 0 sampai 51

        ' Rnd()
        Dim i As Integer
        'variabel image sebagai array yang menampung resources gambar kartu 
        ' dalam permainan blackjack kartu berjumlah 52 , tidak termasuk joker 
        Dim IMG1() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Randomize()
        i = Int(Rnd() * 51)
        Dim card1 As Integer = i
        Lbdealer1.Text = card1
        If IMG1(card1) Is My.Resources._1 And Lbdealer1.Text = 1 Then
            Lbdealer1.Text = 11
        End If
        Lbdealer1.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1
        If Lbdealer1.Text > 10 And Lbdealer1.Text <= 13 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 14 Then
            Lbdealer1.Text = 11 ' AS
        End If
        If Lbdealer1.Text > 14 And Lbdealer1.Text <= 23 Then
            Lbdealer1.Text = Lbdealer1.Text - 13
        End If
        If Lbdealer1.Text > 23 And Lbdealer1.Text <= 26 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 27 Then
            Lbdealer1.Text = 11 'As
        End If
        If Lbdealer1.Text > 27 And Lbdealer1.Text <= 36 Then
            Lbdealer1.Text = Lbdealer1.Text - 26
        End If
        If Lbdealer1.Text > 36 And Lbdealer1.Text <= 39 Then
            Lbdealer1.Text = 10
        End If
        If Lbdealer1.Text = 40 Then
            Lbdealer1.Text = 11 'AS
        End If
        If Lbdealer1.Text > 40 And Lbdealer1.Text <= 49 Then
            Lbdealer1.Text = Lbdealer1.Text - 39
        End If
        If Lbdealer1.Text > 49 And Lbdealer1.Text <= 52 Then
            Lbdealer1.Text = 10

        End If

        'kartu yang akan  tampil di Meja
        Me.pic1.Image = IMG1(card1)
        btdealdealer.Hide()

    End Sub

    Private Sub betdealer_Click(sender As Object, e As EventArgs) Handles HitDealer.Click

        Dim IMG2() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Dim i As Integer

        Randomize()
        i = Int(Rnd() * 52)
        Dim card2 As Integer = i
        lbdealer2.Text = card2

        'Tes kondisi untuk menentukan nilai kartu Black Jack

        If IMG2(card2) Is My.Resources._1 And lbdealer2.Text = 1 Then
            lbdealer2.Text = 11
        End If
        lbdealer2.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1

        If Val(lbdealer2.Text) > 10 And Val(lbdealer2.Text) <= 13 Then
            lbdealer2.Text = 10
        End If
        If lbdealer2.Text = 14 Then
            lbdealer2.Text = 11 ' AS
        End If
        If Val(lbdealer2.Text) > 14 And Val(lbdealer2.Text) <= 23 Then
            lbdealer2.Text = lbdealer2.Text - 13
        End If
        If Val(lbdealer2.Text) > 23 And Val(lbdealer2.Text) <= 26 Then
            lbdealer2.Text = 10
        End If
        If Val(lbdealer2.Text) = 27 Then
            lbdealer2.Text = 11 'As
        End If
        If Val(lbdealer2.Text) > 27 And Val(lbdealer2.Text) <= 36 Then
            lbdealer2.Text = lbdealer2.Text - 26
        End If
        If Val(lbdealer2.Text) > 36 And Val(lbdealer2.Text) <= 39 Then
            lbdealer2.Text = 10
        End If
        If Val(lbdealer2.Text) = 40 Then
            lbdealer2.Text = 11 'AS
        End If
        If Val(lbdealer2.Text) > 40 And Val(lbdealer2.Text) <= 49 Then
            lbdealer2.Text = lbdealer2.Text - 39
        End If
        If Val(lbdealer2.Text) > 49 And Val(lbdealer2.Text) <= 52 Then
            lbdealer2.Text = 10

        End If
        'kartu yang akan  tampil di Meja
        Me.pic2.Image = IMG2(card2)
        HitDealer.Hide()

    End Sub

    'PLAYER 1
    Private Sub btdealP1_Click(sender As Object, e As EventArgs) Handles btdealP1.Click

        Dim IMG3() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card3 As Integer = i
        lbP1one.Text = card3
        If IMG3(card3) Is My.Resources._1 And lbP1one.Text = 1 Then
            lbP1one.Text = 11
        End If
        lbP1one.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1

        If Val(lbP1one.Text) > 10 And Val(lbP1one.Text) <= 13 Then
            lbP1one.Text = 10
        End If
        If lbP1one.Text = 14 Then
            lbP1one.Text = 11 ' AS
        End If
        If Val(lbP1one.Text) > 14 And Val(lbP1one.Text) <= 23 Then
            lbP1one.Text = lbP1one.Text - 13
        End If
        If Val(lbP1one.Text) > 23 And Val(lbP1one.Text) <= 26 Then
            lbP1one.Text = 10
        End If
        If Val(lbP1one.Text) = 27 Then
            lbP1one.Text = 11 'As
        End If
        If Val(lbP1one.Text) > 27 And Val(lbP1one.Text) <= 36 Then
            lbP1one.Text = lbP1one.Text - 26
        End If
        If Val(lbP1one.Text) > 36 And Val(lbP1one.Text) <= 39 Then
            lbP1one.Text = 10
        End If
        If Val(lbP1one.Text) = 40 Then
            lbP1one.Text = 11 'AS
        End If
        If Val(lbP1one.Text) > 40 And Val(lbP1one.Text) <= 49 Then
            lbP1one.Text = lbP1one.Text - 39
        End If
        If Val(lbP1one.Text) > 49 And Val(lbP1one.Text) <= 52 Then
            lbP1one.Text = 10

        End If

        'kartu yang akan  tampil di Meja
        Me.pic3.Image = IMG3(card3)
        btdealP1.Hide()
    End Sub

    Private Sub bet1_Click(sender As Object, e As EventArgs) Handles Hit1.Click

        Dim IMG4() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}
        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card4 As Integer = i
        lbP1two.Text = card4
        If IMG4(card4) Is My.Resources._1 And lbP1two.Text = 1 Then
            lbP1two.Text = 11
        End If
        lbP1two.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1

        If Val(lbP1two.Text) > 10 And Val(lbP1two.Text) <= 13 Then
            lbP1two.Text = 10
        End If
        If lbP1two.Text = 14 Then
            lbP1two.Text = 11 ' AS
        End If
        If Val(lbP1two.Text) > 14 And Val(lbP1two.Text) <= 23 Then
            lbP1two.Text = lbP1two.Text - 13
        End If
        If Val(lbP1two.Text) > 23 And Val(lbP1two.Text) <= 26 Then
            lbP1two.Text = 10
        End If
        If Val(lbP1two.Text) = 27 Then
            lbP1two.Text = 11 'As
        End If
        If Val(lbP1two.Text) > 27 And Val(lbP1two.Text) <= 36 Then
            lbP1two.Text = lbP1two.Text - 26
        End If
        If Val(lbP1two.Text) > 36 And Val(lbP1two.Text) <= 39 Then
            lbP1two.Text = 10
        End If
        If Val(lbP1two.Text) = 40 Then
            lbP1two.Text = 11 'AS
        End If
        If Val(lbP1two.Text) > 40 And Val(lbP1two.Text) <= 49 Then
            lbP1two.Text = lbP1two.Text - 39
        End If
        If Val(lbP1two.Text) > 49 And Val(lbP1two.Text) <= 52 Then
            lbP1two.Text = 10

        End If

        'kartu yang akan  tampil di Meja
        Me.pic4.Image = IMG4(card4)
        Hit1.Hide()
    End Sub

    Private Sub BtdealP2_Click(sender As Object, e As EventArgs) Handles BtdealP2.Click

        Dim IMG5() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card5 As Integer = i
        lbP2one.Text = card5
        If IMG5(card5) Is My.Resources._1 And lbP2one.Text = 1 Then
            lbP2one.Text = 11
        End If
        lbP2one.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1
        If Val(lbP2one.Text) > 10 And Val(lbP2one.Text) <= 13 Then
            lbP2one.Text = 10
        End If
        If lbP2one.Text = 14 Then
            lbP2one.Text = 11 ' AS
        End If
        If Val(lbP2one.Text) > 14 And Val(lbP2one.Text) <= 23 Then
            lbP2one.Text = lbP2one.Text - 13
        End If
        If Val(lbP2one.Text) > 23 And Val(lbP2one.Text) <= 26 Then
            lbP2one.Text = 10
        End If
        If Val(lbP2one.Text) = 27 Then
            lbP2one.Text = 11 'As
        End If
        If Val(lbP2one.Text) > 27 And Val(lbP2one.Text) <= 36 Then
            lbP2one.Text = lbP2one.Text - 26
        End If
        If Val(lbP2one.Text) > 36 And Val(lbP2one.Text) <= 39 Then
            lbP2one.Text = 10
        End If
        If Val(lbP2one.Text) = 40 Then
            lbP2one.Text = 11 'AS
        End If
        If Val(lbP2one.Text) > 40 And Val(lbP2one.Text) <= 49 Then
            lbP2one.Text = lbP2one.Text - 39
        End If
        If Val(lbP2one.Text) > 49 And Val(lbP2one.Text) <= 52 Then
            lbP2one.Text = 10

        End If

        'kartu yang akan  tampil di Meja
        Me.pic5.Image = IMG5(card5)
        BtdealP2.Hide()
    End Sub

    'PLAYER 2 
    Private Sub Hit2_Click(sender As Object, e As EventArgs) Handles Hit2.Click

        Dim IMG6() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
            My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
            My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
            My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
            My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
            My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
            My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
            My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}
        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card6 As Integer = i
        lbP2two.Text = card6
        If IMG6(card6) Is My.Resources._1 And lbP2two.Text = 1 Then
            lbP2two.Text = 11
        End If
        lbP2two.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1
        If Val(lbP2two.Text) > 10 And Val(lbP2two.Text) <= 13 Then
            lbP2two.Text = 10
        End If
        If lbP2two.Text = 14 Then
            lbP2two.Text = 11 ' AS
        End If
        If Val(lbP2two.Text) > 14 And Val(lbP2two.Text) <= 23 Then
            lbP2two.Text = lbP2two.Text - 13
        End If
        If Val(lbP2two.Text) > 23 And Val(lbP2two.Text) <= 26 Then
            lbP2two.Text = 10
        End If
        If Val(lbP2two.Text) = 27 Then
            lbP2two.Text = 11 'As
        End If
        If Val(lbP2two.Text) > 27 And Val(lbP2two.Text) <= 36 Then
            lbP2two.Text = lbP2two.Text - 26
        End If
        If Val(lbP2two.Text) > 36 And Val(lbP2two.Text) <= 39 Then
            lbP2two.Text = 10
        End If
        If Val(lbP2two.Text) = 40 Then
            lbP2two.Text = 11 'AS
        End If
        If Val(lbP2two.Text) > 40 And Val(lbP2two.Text) <= 49 Then
            lbP2two.Text = lbP2two.Text - 39
        End If
        If Val(lbP2two.Text) > 49 And Val(lbP2two.Text) <= 52 Then
            lbP2two.Text = 10

        End If


        'kartu yang akan  tampil di Meja
        Me.pic6.Image = IMG6(card6)
        Hit2.Hide()
    End Sub
    'PLAYER 3
    Private Sub btdealP3_Click(sender As Object, e As EventArgs) Handles btdealP3.Click
        Dim IMG7() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
           My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
           My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
           My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
           My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
           My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
           My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
           My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card7 As Integer = i
        lbP3one.Text = card7
        If IMG7(card7) Is My.Resources._1 And lbP3one.Text = 1 Then
            lbP3one.Text = 11
        End If
        lbP3one.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1

        If Val(lbP3one.Text) > 10 And Val(lbP3one.Text) <= 13 Then
            lbP3one.Text = 10
        End If
        If lbP3one.Text = 14 Then
            lbP3one.Text = 11 ' AS
        End If
        If Val(lbP3one.Text) > 14 And Val(lbP3one.Text) <= 23 Then
            lbP3one.Text = lbP3one.Text - 13
        End If
        If Val(lbP3one.Text) > 23 And Val(lbP3one.Text) <= 26 Then
            lbP3one.Text = 10
        End If
        If Val(lbP3one.Text) = 27 Then
            lbP3one.Text = 11 'As
        End If
        If Val(lbP3one.Text) > 27 And Val(lbP3one.Text) <= 36 Then
            lbP3one.Text = lbP3one.Text - 26
        End If
        If Val(lbP3one.Text) > 36 And Val(lbP3one.Text) <= 39 Then
            lbP3one.Text = 10
        End If
        If Val(lbP3one.Text) = 40 Then
            lbP3one.Text = 11 'AS
        End If
        If Val(lbP3one.Text) > 40 And Val(lbP3one.Text) <= 49 Then
            lbP3one.Text = lbP3one.Text - 39
        End If
        If Val(lbP3one.Text) > 49 And Val(lbP3one.Text) <= 52 Then
            lbP3one.Text = 10

        End If
        Me.pic7.Image = IMG7(card7)
        btdealP3.Hide()
    End Sub

    Private Sub HitP3_Click(sender As Object, e As EventArgs) Handles Hit3.Click
        Dim IMG8() As Image = {My.Resources._1, My.Resources._2, My.Resources._3, My.Resources._4, My.Resources._5, My.Resources._6,
           My.Resources._7, My.Resources._8, My.Resources._9, My.Resources._10, My.Resources._11,
           My.Resources._12, My.Resources._13, My.Resources._14, My.Resources._15, My.Resources._16, My.Resources._17, My.Resources._18,
           My.Resources._19, My.Resources._20, My.Resources._21, My.Resources._22, My.Resources._23, My.Resources._24, My.Resources._25,
           My.Resources._26, My.Resources._27, My.Resources._28, My.Resources._29, My.Resources._30, My.Resources._31, My.Resources._32,
           My.Resources._33, My.Resources._34, My.Resources._35, My.Resources._36, My.Resources._37,
           My.Resources._38, My.Resources._39, My.Resources._40, My.Resources._41, My.Resources._42, My.Resources._43, My.Resources._44, My.Resources._45,
           My.Resources._46, My.Resources._47, My.Resources._48, My.Resources._49, My.Resources._50, My.Resources._51, My.Resources._52}

        Dim i As Integer
        Randomize()
        i = Int(Rnd() * 52)
        Dim card8 As Integer = i
        lbP3two.Text = card8
        If IMG8(card8) Is My.Resources._1 And lbP3two.Text = 1 Then
            lbP3two.Text = 11
        End If
        lbP3two.Text += 1 'karena array dimulai dari 0, maka agar bisa dilakukan tes kondisi nantinya value kita tambah 1
        If Val(lbP3two.Text) > 10 And Val(lbP3two.Text) <= 13 Then
            lbP3two.Text = 10
        End If
        If lbP3two.Text = 14 Then
            lbP3two.Text = 11 ' AS
        End If
        If Val(lbP3two.Text) > 14 And Val(lbP3two.Text) <= 23 Then
            lbP3two.Text = lbP3two.Text - 13
        End If
        If Val(lbP3two.Text) > 23 And Val(lbP3two.Text) <= 26 Then
            lbP3two.Text = 10
        End If
        If Val(lbP3two.Text) = 27 Then
            lbP3two.Text = 11 'As
        End If
        If Val(lbP3two.Text) > 27 And Val(lbP3two.Text) <= 36 Then
            lbP3two.Text = lbP3two.Text - 26
        End If
        If Val(lbP3two.Text) > 36 And Val(lbP3two.Text) <= 39 Then
            lbP3two.Text = 10
        End If
        If Val(lbP3two.Text) = 40 Then
            lbP3two.Text = 11 'AS
        End If
        If Val(lbP3two.Text) > 40 And Val(lbP3two.Text) <= 49 Then
            lbP3two.Text = lbP3two.Text - 39
        End If
        If Val(lbP3two.Text) > 49 And Val(lbP3two.Text) <= 52 Then
            lbP3two.Text = 10

        End If

        'kartu yang akan  tampil di Meja
        Me.pic8.Image = IMG8(card8)
        Hit3.Hide()
    End Sub

    'ulang kartu
    Private Sub btresetcard_Click(sender As Object, e As EventArgs) Handles btresetcard.Click
        Lbdealer1.Text = "X"
        lbdealer2.Text = "X"
        lbP1one.Text = "X"
        lbP1two.Text = "X"
        lbP2one.Text = "X"
        lbP2two.Text = "X"
        lbP3one.Text = "X"
        lbP3two.Text = "X"
        pic1.Hide()
        pic2.Hide()
        pic3.Hide()
        pic4.Hide()
        pic5.Hide()
        pic6.Hide()
        pic7.Hide()
        pic8.Hide()
        btdividecards.Show()
        Call cleanbtndealhit()
        WinLose.Hide()
        chip5dealer.Location = New Point(217, 79)
        chip10dealer.Location = New Point(256, 79)
        chip25dealer.Location = New Point(295, 79)
        chip50dealer.Location = New Point(334, 79)

        chip5P1.Location = New Point(367, 470)
        chip10P1.Location = New Point(417, 470)
        chip25P1.Location = New Point(467, 470)
        chip50P1.Location = New Point(514, 470)

        chip5P2.Location = New Point(14, 362)
        chip10P2.Location = New Point(44, 386)
        chip25P2.Location = New Point(76, 408)
        chip50P2.Location = New Point(115, 442)


        chip5P3.Location = New Point(729, 408)
        chip10P3.Location = New Point(765, 389)
        chip25P3.Location = New Point(804, 372)
        chip50P3.Location = New Point(837, 353)

        win = 0
    End Sub
    Sub dispbet() 'menampilkan menu bet
        bet5dealer.Show()
        bet10dealer.Show()
        bet25dealer.Show()
        bet50dealer.Show()
        bet5p1.Show()
        bet5p1.Show()
        bet10p1.Show()
        bet25p1.Show()
        bet50p1.Show()
        bet5p2.Show()
        bet10p2.Show()
        bet25p2.Show()
        bet50p2.Show()
        bet5p3.Show()
        bet5p3.Show()
        bet10p3.Show()
        bet25p3.Show()
        bet50p3.Show()
        Surrenderdealer.Show()
        surrenderP2.Show()
        SurrenderP1.Show()
        surrenderP3.Show()
    End Sub
    Private Sub btdividecards_Click(sender As Object, e As EventArgs) Handles btdividecards.Click
        Call dispbet()

        'kartu ditampilkan kembali
        pic1.Show()
        pic2.Show()
        pic3.Show()
        pic4.Show()
        pic5.Show()
        pic6.Show()
        pic7.Show()
        pic8.Show()

        'kartu dalam keadaan tertutup
        Me.pic1.Image = My.Resources.CloseCard
        Me.pic2.Image = My.Resources.CloseCard
        Me.pic3.Image = My.Resources.CloseCard
        Me.pic4.Image = My.Resources.CloseCard
        Me.pic5.Image = My.Resources.CloseCard
        Me.pic6.Image = My.Resources.CloseCard
        Me.pic7.Image = My.Resources.CloseCard
        Me.pic8.Image = My.Resources.CloseCard

        btdividecards.Hide()
        btresetcard.Show()
    End Sub
    Sub cleanbtndealhit()
        bet10dealer.Hide()
        bet25dealer.Hide()
        bet50dealer.Hide()
        bet10p1.Hide()
        bet25p1.Hide()
        bet50p1.Hide()
        bet10p2.Hide()
        bet25p2.Hide()
        bet50p2.Hide()
        bet10p3.Hide()
        bet25p3.Hide()
        bet50p3.Hide()
        btdealdealer.Hide()
        btdealP1.Hide()
        BtdealP2.Hide()
        btdealP3.Hide()
        HitDealer.Hide()
        Hit1.Hide()
        Hit2.Hide()
        Hit3.Hide()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call cleanbtndealhit()

        If Lbdealer1.Text = 1 Or lbdealer2.Text = 1 Or lbP1one.Text = 1 Or lbP1two.Text = 1 Or lbP2one.Text = 1 Or lbP2two.Text = 1 Or lbP3one.Text = 1 Or lbP3two.Text = 1 Then
            Lbdealer1.Text = 11
            lbdealer2.Text = 11
            lbP1one.Text = 11
            lbP1two.Text = 11
            lbP2one.Text = 11
            lbP2two.Text = 11
            lbP3one.Text = 11
            lbP3two.Text = 11
        End If

        If saldodealer.Text = 0 Then
            chip5dealer.Hide()
            chip25dealer.Hide()
            chip10dealer.Hide()
            chip50dealer.Hide()
            pic1.Hide()
            pic2.Hide()
            btdealdealer.Hide()
            HitDealer.Hide()
            Surrenderdealer.Hide()
            Label1.Text = "Losed"
        End If

        If saldop1.Text = 0 Then
            chip5P1.Hide()
            chip25P1.Hide()
            chip10P1.Hide()
            chip50P1.Hide()
            pic3.Hide()
            pic4.Hide()
            btdealP1.Hide()
            Hit1.Hide()
            SurrenderP1.Hide()
            Label4.Text = "Losed"
        End If
        If saldop2.Text = 0 Then
            chip5P2.Hide()
            chip25P2.Hide()
            chip10P2.Hide()
            chip50P2.Hide()
            pic4.Hide()
            pic5.Hide()
            BtdealP2.Hide()
            Hit2.Hide()
            surrenderP2.Hide()
            Label7.Text = "Losed"
        End If
        If saldop3.Text = 0 Then
            chip5P3.Hide()
            chip25P3.Hide()
            chip10P3.Hide()
            chip50P3.Hide()
            pic6.Hide()
            pic7.Hide()
            btdealP3.Hide()
            Hit3.Hide()
            surrenderP3.Hide()
            Label9.Text = "Losed"
        End If
    End Sub
    'DEALER BET
    Private Sub bet5dealer_Click(sender As Object, e As EventArgs) Handles bet5dealer.Click
        chip5dealer.Location = New Point(428, 186)
        saldodealer.Text -= 5
        bet5dealer.Hide()
        bet10dealer.Show()
        btdealdealer.Show()
        win += 5
    End Sub

    Private Sub bet10dealer_Click(sender As Object, e As EventArgs) Handles bet10dealer.Click
        chip10dealer.Location = New Point(426, 219)
        saldodealer.Text -= 10
        bet10dealer.Hide()
        bet25dealer.Show()
        HitDealer.Show()
        win += 10
    End Sub

    Private Sub bet25dealer_Click(sender As Object, e As EventArgs) Handles bet25dealer.Click
        chip25dealer.Location = New Point(428, 186)
        saldodealer.Text -= 25
        bet25dealer.Hide()
        bet50dealer.Show()
        btdealdealer.Show()
        win += 25
    End Sub

    Private Sub bet50dealer_Click(sender As Object, e As EventArgs) Handles bet50dealer.Click
        chip50dealer.Location = New Point(426, 219)
        saldodealer.Text -= 50
        bet50dealer.Hide()
        HitDealer.Show()
        win += 50
    End Sub

    'PLAYER 1
    Private Sub bet5p1_Click(sender As Object, e As EventArgs) Handles bet5p1.Click
        chip5P1.Location = New Point(467, 186)
        saldop1.Text -= 5
        bet5p1.Hide()
        bet10p1.Show()
        btdealP1.Show()
        win += 5
    End Sub

    Private Sub bet10p1_Click(sender As Object, e As EventArgs) Handles bet10p1.Click
        chip10P1.Location = New Point(467, 219)
        saldop1.Text -= 10
        bet10p1.Hide()
        bet25p1.Show()
        Hit1.Show()
        win += 10

    End Sub

    Private Sub bet25p1_Click(sender As Object, e As EventArgs) Handles bet25p1.Click
        chip25P1.Location = New Point(428, 186)
        saldop1.Text -= 25
        bet25p1.Hide()
        bet50p1.Show()
        btdealP1.Show()
        win += 25
    End Sub

    Private Sub bet50p1_Click(sender As Object, e As EventArgs) Handles bet50p1.Click
        chip50P1.Location = New Point(426, 219)
        saldop1.Text -= 50
        bet50p1.Hide()
        Hit1.Show()
        win += 50
    End Sub

    'PLAYER 2
    Private Sub bet5P2_Click(sender As Object, e As EventArgs) Handles bet5p2.Click
        chip5P2.Location = New Point(390, 186)
        saldop2.Text -= 5
        bet5p2.Hide()
        bet10p2.Show()
        BtdealP2.Show()
        win += 5
    End Sub

    Private Sub bet10P2_Click(sender As Object, e As EventArgs) Handles bet10p2.Click
        chip10P2.Location = New Point(390, 219)
        saldop2.Text -= 10
        bet10p2.Hide()
        bet25p2.Show()
        Hit2.Show()
        win += 10
    End Sub

    Private Sub bet25P2_Click(sender As Object, e As EventArgs) Handles bet25p2.Click
        chip25P2.Location = New Point(428, 186)
        saldop2.Text -= 25
        bet25p2.Hide()
        bet50p2.Show()
        BtdealP2.Show()
        win += 25
    End Sub

    Private Sub bet50P2_Click(sender As Object, e As EventArgs) Handles bet50p2.Click
        chip50P2.Location = New Point(426, 219)
        saldop2.Text -= 50
        bet50p2.Hide()
        Hit2.Show()
        win += 50
    End Sub

    'PLAYER 3

    Private Sub bet5P3_Click(sender As Object, e As EventArgs) Handles bet5p3.Click
        chip5P3.Location = New Point(506, 186)
        saldop3.Text -= 5
        bet5p3.Hide()
        bet10p3.Show()
        btdealP3.Show()
        win += 5
    End Sub

    Private Sub bet10P3_Click(sender As Object, e As EventArgs) Handles bet10p3.Click
        chip10P3.Location = New Point(506, 219)
        saldop3.Text -= 10
        bet10p3.Hide()
        bet25p3.Show()
        Hit3.Show()
        win += 10
    End Sub

    Private Sub bet25P3_Click(sender As Object, e As EventArgs) Handles bet25p3.Click
        chip25P3.Location = New Point(428, 186)
        saldop3.Text -= 25
        bet25p3.Hide()
        bet50p3.Show()
        btdealP3.Show()
    End Sub

    Private Sub bet50P3_Click(sender As Object, e As EventArgs) Handles bet50p3.Click
        chip50P3.Location = New Point(426, 219)
        saldop3.Text -= 50
        bet50p3.Hide()
        Hit3.Show()
    End Sub

    'Tombol menyerah 
    Private Sub Surrenderdealer_Click(sender As Object, e As EventArgs) Handles Surrenderdealer.Click
        bet5dealer.Hide()
        bet10dealer.Hide()
        bet25dealer.Hide()
        bet50dealer.Hide()
        btdealdealer.Hide()
        HitDealer.Hide()
        pic1.Hide()
        pic2.Hide()
        Surrenderdealer.Hide()
    End Sub

    Private Sub SurrenderP1_Click(sender As Object, e As EventArgs) Handles SurrenderP1.Click
        bet5p1.Hide()
        bet10p1.Hide()
        bet25p1.Hide()
        bet50dealer.Hide()
        btdealP1.Hide()
        Hit1.Hide()
        pic3.Hide()
        pic4.Hide()
        SurrenderP1.Hide()
    End Sub

    Private Sub SurrenderP2_Click(sender As Object, e As EventArgs) Handles surrenderP2.Click
        bet5p2.Hide()
        bet10p2.Hide()
        bet25p2.Hide()
        bet50dealer.Hide()
        BtdealP2.Hide()
        Hit2.Hide()
        pic5.Hide()
        pic6.Hide()
        surrenderP2.Hide()
    End Sub
    Private Sub SurrenderP3_Click(sender As Object, e As EventArgs) Handles surrenderP3.Click
        bet5p3.Hide()
        bet10p3.Hide()
        bet25p3.Hide()
        bet50dealer.Hide()
        btdealP3.Hide()
        Hit1.Hide()
        pic7.Hide()
        pic8.Hide()
        surrenderP3.Hide()
    End Sub

    Private Sub Guna2GradientButton1_Click_1(sender As Object, e As EventArgs) Handles announcement.Click


        Dim opencarddealer As Integer
        Dim opencardP1 As Integer
        Dim opencardP2 As Integer
        Dim opencardP3 As Integer


        opencarddealer = Val(Lbdealer1.Text) + Val(lbdealer2.Text)
        opencardP1 = Val(lbP1one.Text) + Val(lbP1two.Text)
        opencardP2 = Val(lbP2one.Text) + Val(lbP2two.Text)
        opencardP3 = Val(lbP3one.Text) + Val(lbP3two.Text)

        'tes kondisi untuk menentukan pemenang 

        'Dealer =====================================

        '1.kemungkinan jika player dealer hasil kartunya lebih besar dari semua pemain maka gunakan logika AND
        If opencarddealer > opencardP1 And opencarddealer > opencardP2 And opencarddealer > opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DEALER is THE WINNER " & "who gets $ " & win
            saldodealer.Text += win
        End If

        '2.kemungkinan jika player dealer hasil kartunya sama dari semua pemain maka gunakan logika AND
        If opencarddealer = opencardP1 And opencarddealer = opencardP2 And opencarddealer > opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DRAW"
            Dim div As Double
            win = win / 4
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        '3. Kemungkinan jika player dealer hasil kartunya draw dengan P1 dan lebih besar dari P2 dan P3
        If opencarddealer = opencardP1 And opencarddealer > opencardP2 And opencarddealer > opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DEALER vs  ANDREAS is DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldodealer.Text += div
            saldop1.Text += div
        End If

        '4. Kemungkinan jika player dealer hasil kartunya draw dengan P2 dan lebih besar dari P1 dan P3
        If opencarddealer > opencardP1 And opencarddealer = opencardP2 And opencarddealer > opencardP3 Then
            WinLose.Text = "DEALER vs  PLAYER 2 is DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldodealer.Text += div
            saldop2.Text += div

        End If

        '5. Kemungkinan jika player dealer hasil kartunya draw dengan P3 dan lebih besar dari P1 dan P2
        If opencarddealer > opencardP1 And opencarddealer > opencardP2 And opencarddealer = opencardP3 Then
            WinLose.Text = "DEALER vs  PLAYER 3  is DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldodealer.Text += div
            saldop3.Text += div

        End If
        '6. Kemungkinan jika player dealer hasil kartunya draw dengan P1 dan P2 dan lebih besar  P3
        If opencarddealer = opencardP1 And opencarddealer > opencardP2 And opencarddealer > opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DEALER vs  ANDREAS vs PLAYER 2 is DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
        End If

        '7. Kemungkinan jika player dealer hasil kartunya draw dengan P1 dan P3 dan lebih besar  P2
        If opencarddealer = opencardP1 And opencarddealer > opencardP2 And opencarddealer = opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DEALER vs  ANDREAS  vs PLAYER 3 is DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop3.Text += div
        End If

        '8. Kemungkinan jika player dealer hasil kartunya draw dengan P2 dan P3 dan lebih besar  P1
        If opencarddealer > opencardP1 And opencarddealer = opencardP2 And opencarddealer = opencardP3 And opencarddealer <= 21 Then
            WinLose.Text = "DEALER vs  ANDREAS  vs PLAYER 3 is DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldodealer.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        'player 1 (andreas)=======================

        '1.kemungkinan jika player1 hasil kartunya lebih besar dari semua pemain maka gunakan logika AND
        If opencardP1 > opencarddealer And opencardP1 > opencardP2 And opencardP1 > opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 is THE WINNER " & "who gets $" & win
            saldop1.Text += win
        End If

        '2.kemungkinan jika player1 hasil kartunya sama dari semua pemain maka gunakan logika AND
        If opencardP1 = opencarddealer And opencardP1 = opencardP2 And opencardP1 = opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "DRAW"
            Dim div As Double
            win = win / 4
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        '3. Kemungkinan jika player1 hasil kartunya draw dengan dealer dan lebih besar dari P2 dan P3
        If opencardP1 = opencarddealer And opencardP1 > opencardP2 And opencardP1 > opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 vs DEALER is DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldop1.Text += div
            saldodealer.Text += div

        End If

        '4. Kemungkinan jika player1 hasil kartunya draw dengan P2 dan lebih besar dari dealer dan P3
        If opencardP1 > opencarddealer And opencardP1 = opencardP2 And opencardP1 > opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 vs  PLAYER 2  is DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldop1.Text += div
            saldop2.Text += div


        End If

        '5. Kemungkinan jika player1 hasil kartunya draw dengan P3 dan lebih besar dari dealer dan P2
        If opencardP1 > opencarddealer And opencardP1 > opencardP2 And opencardP1 = opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 vs  PLAYER 3 is  DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldop1.Text += div
            saldop3.Text += div
        End If
        '6. Kemungkinan jika player 1 hasil kartunya draw dengan dealer dan P2 dan lebih besar  P3
        If opencardP1 = opencarddealer And opencardP1 > opencardP2 And opencardP1 > opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 vs  DEALER vs PLAYER 2  is DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
        End If

        '7. Kemungkinan jika player 1 hasil kartunya draw dengan dealer dan P3 dan lebih besar  P2
        If opencardP1 = opencarddealer And opencardP1 > opencardP2 And opencardP1 = opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas vs  DEALER  vs PLAYER 3 is DRAW CARD"

            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop3.Text += div
        End If

        '8. Kemungkinan jika player 1 hasil kartunya draw dengan P2 dan P3 dan lebih besar  dealer
        If opencardP1 > opencarddealer And opencardP1 = opencardP2 And opencardP1 = opencardP3 And opencardP1 <= 21 Then
            WinLose.Text = "Andreas108 vs  DEALER  vs PLAYER 3 is  DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldop3.Text += div
            saldop1.Text += div
            saldop2.Text += div
        End If

        'Player2 ===================================

        If opencardP2 > opencarddealer And opencardP2 > opencardP1 And opencardP2 > opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "PLAYER 2 is THE WINNER " & "who gets $" & win
            saldop2.Text += win
        End If
        '2.kemungkinan jika player2 hasil kartunya sama dari semua pemain maka gunakan logika AND
        If opencardP2 = opencarddealer And opencardP2 = opencardP1 And opencardP2 = opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "DRAW"
            Dim div As Double
            win = win / 4
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        '3. Kemungkinan jika player2 hasil kartunya draw dengan dealer dan lebih besar dari P1 dan P3
        If opencardP2 = opencarddealer And opencardP2 > opencardP1 And opencardP2 > opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas108 vs DEALER  DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldop2.Text += div
            saldodealer.Text += div

        End If

        '4. Kemungkinan jika player2 hasil kartunya draw dengan P1 dan lebih besar dari dealer dan P3
        If opencardP2 > opencarddealer And opencardP2 = opencardP1 And opencardP2 > opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas108 vs  PLAYER 2  is DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldop1.Text += div
            saldop2.Text += div


        End If

        '5. Kemungkinan jika player2 hasil kartunya draw dengan P3 dan lebih besar dari dealer dan P2
        If opencardP2 > opencarddealer And opencardP2 > opencardP1 And opencardP2 = opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas108 vs  PLAYER 3 is  DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldop2.Text += div
            saldop3.Text += div
        End If
        '6. Kemungkinan jika player 2 hasil kartunya draw dengan dealer dan P2 dan lebih besar  P3
        If opencardP2 = opencarddealer And opencardP2 > opencardP1 And opencardP2 > opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas108 vs  DEALER vs PLAYER 2  is DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop3.Text += div
            saldop2.Text += div
        End If

        '7. Kemungkinan jika player 2 hasil kartunya draw dengan dealer dan P3 dan lebih besar  P2
        If opencardP2 = opencarddealer And opencardP2 > opencardP1 And opencardP2 = opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas vs  DEALER  vs PLAYER 3 is DRAW CARD"

            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        '8. Kemungkinan jika player 2 hasil kartunya draw dengan P1 dan P3 dan lebih besar  dealer
        If opencardP2 > opencarddealer And opencardP2 = opencardP1 And opencardP2 = opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = "Andreas108 vs  DEALER  vs PLAYER 3 is  DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldop3.Text += div
            saldop1.Text += div
            saldop2.Text += div
        End If

        'Player3

        If opencardP3 > opencarddealer And opencardP3 > opencardP1 And opencardP3 > opencardP2 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 is THE WINNER " & "who gets $" & win
            saldop3.Text += win
        End If

        '2.kemungkinan jika player3 hasil kartunya sama dari semua pemain maka gunakan logika AND
        If opencardP3 = opencarddealer And opencardP3 = opencardP1 And opencardP3 = opencardP2 And opencardP2 <= 21 Then
            WinLose.Text = "DRAW"
            Dim div As Double
            win = win / 4
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop2.Text += div
            saldop3.Text += div
        End If

        '3. Kemungkinan jika player3 hasil kartunya draw dengan dealer dan lebih besar dari P1 dan P2
        If opencardP3 = opencarddealer And opencardP3 > opencardP1 And opencardP3 > opencardP2 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 vs DEALER is  DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldop3.Text += div
            saldodealer.Text += div

        End If

        '4. Kemungkinan jika player3 hasil kartunya draw dengan P1 dan lebih besar dari dealer dan P2
        If opencardP3 > opencarddealer And opencardP3 = opencardP1 And opencardP3 > opencardP2 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 vs  Andreas108  is DRAW CARD"

            Dim div As Double
            win = win / 2
            div = win
            saldop1.Text += div
            saldop3.Text += div


        End If

        '5. Kemungkinan jika player3 hasil kartunya draw dengan P2 dan lebih besar dari dealer dan P1
        If opencardP3 > opencarddealer And opencardP3 > opencardP1 And opencardP3 = opencardP2 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 vs PLAYER 2 is  DRAW CARD"
            Dim div As Double
            win = win / 2
            div = win
            saldop2.Text += div
            saldop3.Text += div
        End If
        '6. Kemungkinan jika player 3 hasil kartunya draw dengan dealer dan P2 dan lebih besar  P1
        If opencardP3 = opencarddealer And opencardP3 > opencardP1 And opencardP3 > opencardP1 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 vs  DEALER vs PLAYER 2  is DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop3.Text += div
            saldop2.Text += div
        End If

        '7. Kemungkinan jika player 3 hasil kartunya draw dengan dealer dan P1 dan lebih besar  P2
        If opencardP3 = opencarddealer And opencardP3 = opencardP1 And opencardP3 > opencardP3 And opencardP3 <= 21 Then
            WinLose.Text = "PLAYER 3 vs DEALER vs Andreas108 is DRAW CARD"

            Dim div As Double
            win = win / 3
            div = win
            saldodealer.Text += div
            saldop1.Text += div
            saldop3.Text += div
        End If

        '8. Kemungkinan jika player 3 hasil kartunya draw dengan P1 dan P2 dan lebih besar  dealer
        If opencardP2 > opencarddealer And opencardP2 = opencardP1 And opencardP2 = opencardP3 And opencardP2 <= 21 Then
            WinLose.Text = " PLAYER 3 vs Andreas108 vs PLAYER 2 is  DRAW CARD"
            Dim div As Double
            win = win / 3
            div = win
            saldop3.Text += div
            saldop1.Text += div
            saldop2.Text += div
        End If

        WinLose.Show()
        WinLose.Visible = True
    End Sub
End Class
