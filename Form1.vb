Public Class Form1
    Dim Aa, B, C, D, E As Boolean

    Private time As Byte

    Private binary As Byte

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles A2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        binary = time

        Aa = CBool(binary >= 8)
        If Aa Then
            binary -= 8
        End If

        B = CBool(binary >= 4)
        If B Then
            binary -= 4
        End If

        C = CBool(binary >= 2)
        If C Then
            binary -= 2
        End If

        D = CBool(binary >= 1)
        If D Then
            binary -= 1
        End If

        IsOn(CBool((C And (Not B Or D)) Or (B And Not C)), A1)

        IsOn(CBool(C Or Aa Or Not (B Xor D)), A2)

        IsOn(CBool(Not B Or D Or C), A3)

        IsOn(CBool(C Or Aa Or Not (B Xor D)), A4)

        IsOn(B, A5)

        IsOn(CBool(Aa Or (Not C And Not D) Or (B And (Not C Or Not D))), A6)

        IsOn(CBool(Not Aa And Not B And Not C And D), A7)

        IsOn(CBool(Not Aa And Not B And Not C And D), A8)

        IsOn(CBool(Not Aa And Not B And Not C And Not D), A9)

        IsOn(CBool(Aa Or (Not B And Not D) Or Not (C Xor D)), A10)

        IsOn(CBool((Not Aa And Not B And Not C And Not D) Or (B And (C Xor D))), A11)

        IsOn(CBool(Aa Or (C And Not D) Or (B And Not C)), A12)

        IsOn(CBool(Not B Or Not C Or Not D), A13)

        IsOn(CBool(Aa Or B Or C), A14)

        IsOn(CBool((Not Aa And Not C And Not D) Or (Aa And D)), A15)

        IsOn(CBool(Not D And (Not B Or C)), A16)

        IsOn(CBool(Not Aa And Not B And Not C And Not D), A17)

        IsOn(CBool(Not Aa And Not B And Not C And D), A18)

        IsOn(CBool(D And B And C), A19)

        IsOn(CBool(Aa Or (Not C And Not D) Or (Not B And C And D) Or (B And (Not C Or Not D))), A20)

        IsOn(CBool((Not B And C) Or (B And Not C And D)), A21)

        IsOn(CBool((Not D And (Not B Or C)) Or (Not Aa And (Not B Or (Not C And D)))), A22)

        IsOn(CBool(Not B Or (C Xor D)), A23)

        IsOn(CBool(Not B Or C Or D), A24)

        IsOn(CBool(Not D And (B Xor C)), A25)


        If time = 9 Then
            time = 0
        Else
            time += 1
        End If
    End Sub

    Private Sub IsOn(x As Boolean, A As Label)
        Console.WriteLine(x)
        Console.WriteLine(A)

        If x Then
            A.BackColor = Color.Red
        Else
            A.BackColor = Color.DimGray
        End If
    End Sub
End Class
