Class MainWindow 
    Dim isWiden As Boolean
    Dim isHeight As Boolean
    Dim About As New About

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles button2.Click
        Me.Close()
        About.Close()
    End Sub


    'Private Sub Rec1_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Rec1.MouseLeftButtonDown
    '    isWiden = True
    '    Rec1.CaptureMouse()
    'End Sub
    'Private Sub Rec1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Rec1.MouseMove
    '    Dim newWidth As Double

    '    If (isWiden = True) Then
    '        Rec1.CaptureMouse()
    '        newWidth = e.GetPosition(Me).X + 5
    '        If (newWidth > 0) Then
    '            Me.Width = newWidth
    '        End If
    '    End If

    'End Sub
    'Private Sub Rec1_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Rec1.MouseLeftButtonUp

    '    isWiden = False
    '    Rec1.ReleaseMouseCapture()

    'End Sub
    'Private Sub Rec2_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Rec2.MouseLeftButtonDown
    '    isHeight = True
    '    Rec2.CaptureMouse()
    'End Sub

    'Private Sub Rec2_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Rec2.MouseLeftButtonUp

    '    isHeight = False
    '    Rec2.ReleaseMouseCapture()

    'End Sub

    'Private Sub Rec2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles Rec2.MouseMove
    '    Dim newHeight As Double

    '    If (isHeight = True) Then
    '        Rec2.CaptureMouse()
    '        newHeight = e.GetPosition(Me).Y + 5
    '        If (newHeight > 0) Then
    '            Me.Height = newHeight
    '        End If
    '    End If
    'End Sub

    'Private Sub ResGrip_MouseLeftButtonDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ResGrip.MouseLeftButtonDown
    '    isHeight = True
    '    isWiden = True
    '    ResGrip.CaptureMouse()
    'End Sub

    'Private Sub ResGrip_MouseLeftButtonUp(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles ResGrip.MouseLeftButtonUp

    '    isHeight = False
    '    isWiden = False
    '    ResGrip.ReleaseMouseCapture()

    'End Sub

    'Private Sub ResGrip_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Input.MouseEventArgs) Handles ResGrip.MouseMove
    '    Dim newHeight As Double
    '    Dim newWidth As Double

    '    If (isHeight = True) Then
    '        ResGrip.CaptureMouse()
    '        newHeight = e.GetPosition(Me).Y + 5
    '        If (newHeight > 0) Then
    '            Me.Height = newHeight
    '        End If
    '    End If

    '    If (isWiden = True) Then
    '        ResGrip.CaptureMouse()
    '        newWidth = e.GetPosition(Me).X + 5
    '        If (newWidth > 0) Then
    '            Me.Width = newWidth
    '        End If
    '    End If

    'End Sub


    Private Sub grid0_MouseLeftButtonDown1(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles grid0.MouseLeftButtonDown
        Me.DragMove()
    End Sub

    Private Sub MainWindow_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        Me.Height = 420
        Me.Width = 580
        RadioButton1.IsChecked = True
        Radio3.IsChecked = True
        Radio1.IsChecked = True
        RadioButtonF1.IsChecked = True
        RadioF1.IsChecked = True
        RadioF3.IsChecked = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click
        Me.Close()
        About.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim P1 As Object, P2 As Object, T1 As Object, M As Object
        Dim a As Object, b As Object, k As Object, ksi As Object, mu As Object
        Dim Qm As Object, d As Object, f As Object, md As Object, ro As Object
        Dim An As Object, Bn As Object, Cn As Object, Dn As Object, p As Object
        Dim Q As Object, alfa As Object, beta As Object, delt As Object
        Dim y As Object, x As Object, betak As Object
        Const R As Double = 8.314
        Dim sep As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator(0)
        Dim tb1 As String = Replace(TextBox1.Text, ".", sep), tb2 As String = Replace(TextBox2.Text, ".", sep), tb3 As String = Replace(TextBox3.Text, ".", sep)
        Dim tb4 As String = Replace(TextBox4.Text, ".", sep), tb5 As String = Replace(TextBox5.Text, ".", sep), tb6 As String = Replace(TextBox6.Text, ".", sep)
        Dim tb7 As String = Replace(TextBox7.Text, ".", sep), tb8 As String = Replace(TextBox8.Text, ".", sep)

        Status.Content = "Расчет..."

        On Error GoTo ErrorHandler

        TextBox1.Text = tb1
        TextBox2.Text = tb2
        TextBox3.Text = tb3
        TextBox4.Text = tb4
        TextBox5.Text = tb5
        TextBox6.Text = tb6
        TextBox7.Text = tb7
        TextBox8.Text = tb8

       

        If TextBox4.Text = "" Then
            MsgBox("Введите значение давления на входе", vbExclamation)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        If TextBox5.Text = "" Then
            MsgBox("Введите значение давления на выходе", vbExclamation)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        If TextBox6.Text = "" Then
            MsgBox("Введите значение температуры на входе", vbExclamation)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        If Val(TextBox5.Text) > Val(TextBox4.Text) Then
            MsgBox("Неверное значение давления на выходе", vbCritical)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        P1 = TextBox4.Text
        P2 = TextBox5.Text
        T1 = TextBox6.Text + 273.15
        M = TextBox9.Text
        k = TextBox3.Text
        ksi = TextBox7.Text
        Qm = TextBox1.Text
        d = TextBox2.Text
        mu = TextBox8.Text


        If TextBox6.Text > 100 Or TextBox6.Text < -220 Then
            MsgBox("Неверное значение температуры на входе", vbCritical)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        If P1 < 0 Then
            MsgBox("Неверное значение давления на входе", vbCritical)
            Status.Content = "Ошибка"
            Exit Sub
        End If

        If RadioButton1.IsChecked = True Then
            M = 0.028
            k = 1.4
            a = 0.135
            b = 0.00003862
            TextBox3.Text = k
            TextBox9.Text = M
        End If

        If RadioButton2.IsChecked = True Then
            M = 0.004
            k = 1.67
            a = 0.00338
            b = 0.000023606
            TextBox3.Text = k
            TextBox9.Text = M
        End If

        If Radio1.IsChecked = True Then
            If TextBox7.Text = "" Then
                MsgBox("Введите коэффициент гидравлических потерь", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If

            If ksi < 0 Then
                MsgBox("Неверный коэффициент гидравлических потерь", vbCritical)
                Status.Content = "Ошибка"
                Exit Sub
            Else
                mu = 1 / ((1 + ksi) ^ (1 / 2))
                TextBox8.Text = Math.Round(mu, 3)
            End If
        End If

        If Radio2.IsChecked = True Then
            If TextBox8.Text = "" Then
                MsgBox("Введите коэффициент гидравлического сопротивления", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If

            If mu < 0 Or mu > 1 Then
                MsgBox("Неверный коэффициент гидравлического сопротивления", vbCritical)
                Status.Content = "Ошибка"
                Exit Sub
            Else
                mu = TextBox8.Text
                TextBox7.Text = Math.Round((((1 / mu) ^ 2) - 1), 3)
            End If
        End If

        md = 9.80665 * ((k * M / R) * ((2 / (k + 1)) ^ ((k + 1) / (k - 1)))) ^ (1 / 2)
        betak = (2 / (k + 1)) ^ (k / (k - 1))

        If CheckBox1.IsChecked = True Then
            If TextBox2.Text = "" Then
                MsgBox("Введите диаметр", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If

            If TextBox2.Text < 0 Then
                MsgBox("Неверный диаметр", vbCritical)
                Status.Content = "Ошибка"
                Exit Sub
            End If

            If Radio3.IsChecked = True Then
                'расчет плотности по уравнению состояния Ван-дер-Ваальса, с помощью метода Кардано
                An = P1 * 98066.5
                Bn = -P1 * 98066.5 * b - R * T1
                Cn = a
                Dn = -a * b

                p = ((-(Bn ^ 2)) / (3 * (An ^ 2))) + Cn / An
                Q = ((2 * (Bn ^ 3)) / (27 * (An ^ 3))) - ((Bn * Cn) / (3 * (An ^ 2))) + Dn / An

                delt = -27 * (Q ^ 2) - 4 * (p ^ 3)

                alfa = (-Q / 2 + (-delt / 108) ^ (1 / 2)) ^ (1 / 3)
                beta = (-Q / 2 - (-delt / 108) ^ (1 / 2)) ^ (1 / 3)

                y = alfa + beta

                x = y - ((Bn) / (3 * An))

                ro = M / x
                TextBox10.Text = Math.Round(ro, 4)

                'расчет массового расхода с применением плотности по Ван-дре-Ваальсу
                f = 3.141592654 * ((d / 1000) ^ 2) / 4
                Qm = mu * f * ((2 * k / (k + 1)) * P1 * 98066.5 * ro * (2 / (k + 1)) ^ (2 / (k - 1))) ^ (1 / 2)
                TextBox1.Text = Math.Round(Qm, 4)
            Else
                'расчет плотности по уравнению состояния идельаонго газа
                ro = (M * P1 * 98066.5) / (R * T1)
                TextBox10.Text = Math.Round(ro, 4)

                'расчет массового расхода с применением плотности по идеальному газу
                f = 3.141592654 * ((d / 10) ^ 2) / 4
                Qm = (mu * f * md * P1) / (T1 ^ (1 / 2))
                TextBox1.Text = Math.Round(Qm, 4)
            End If

        Else
            If TextBox1.Text = "" Then
                MsgBox("Введите значение массового расхода", vbExclamation)
                Status.Content = "Error"
                Exit Sub
            End If

            If Qm < 0 Then
                MsgBox("Неверное значение массового расхода", vbCritical)
                Status.Content = "Error"
                Exit Sub
            End If

            If Radio3.IsChecked = True Then
                'расчет плотности по уравнению состояния Ван-дер-Ваальса, с помощью метода Кардано
                An = P1 * 98066.5
                Bn = -P1 * 98066.5 * b - R * T1
                Cn = a
                Dn = -a * b

                p = ((-(Bn ^ 2)) / (3 * (An ^ 2))) + Cn / An
                Q = ((2 * (Bn ^ 3)) / (27 * (An ^ 3))) - ((Bn * Cn) / (3 * (An ^ 2))) + Dn / An

                delt = -27 * (Q ^ 2) - 4 * (p ^ 3)

                alfa = (-Q / 2 + (-delt / 108) ^ (1 / 2)) ^ (1 / 3)
                beta = (-Q / 2 - (-delt / 108) ^ (1 / 2)) ^ (1 / 3)

                y = alfa + beta

                x = y - ((Bn) / (3 * An))

                ro = M / x
                TextBox10.Text = Math.Round(ro, 4)

                'расчет массового расхода с применением плотности по Ван-дре-Ваальсу
                f = Qm / (mu * ((2 * k / (k + 1)) * P1 * 98066.5 * ro * (2 / (k + 1)) ^ (2 / (k - 1))) ^ (1 / 2))
                d = 2 * ((f / 3.141592654) ^ (1 / 2)) * 1000
                TextBox2.Text = Math.Round(d, 2)

            Else
                'расчет плотности по уравнению состояния идельаонго газа
                ro = (M * P1 * 98066.5) / (R * T1)
                TextBox10.Text = Math.Round(ro, 4)

                'расчет массового расхода с применением плотности по идеальному газу
                f = (Qm * (T1 ^ (1 / 2))) / (mu * md * P1)
                d = 2 * ((f / 3.141592654) ^ (1 / 2)) * 10
                TextBox2.Text = Math.Round(d, 2)
            End If
        End If

        Status.Content = "Готово"
        Exit Sub
ErrorHandler: MsgBox("Ошибка! " & "Проверьте правильность ввода данных", vbCritical)
        Status.Content = "Ошибка"

    End Sub

    'Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button4.Click
    '    Dim w As New About
    '    w.Show()
    'End Sub

    Private Sub ButtonF1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ButtonF1.Click

        Dim Pmax As Object, Psr As Object, Tg As Object, Hm As Object, Rh As Object, Szsm As Object
        Dim gamma As Object, dzsm As Object, ksi As Object, Q As Object, M As Object, mu As Object
        Dim sep As String = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator(0)
        Dim tb1 As String = Replace(TextBoxF1.Text, ".", sep), tb2 As String = Replace(TextBoxF2.Text, ".", sep), tb3 As String = Replace(TextBoxF3.Text, ".", sep)
        Dim tb4 As String = Replace(TextBoxF4.Text, ".", sep), tb5 As String = Replace(TextBoxF5.Text, ".", sep), tb6 As String = Replace(TextBoxF6.Text, ".", sep)
        Dim tb7 As String = Replace(TextBoxF7.Text, ".", sep), tb8 As String = Replace(TextBoxF8.Text, ".", sep), tb9 As String = Replace(TextBoxF9.Text, ".", sep)
        Dim tb10 As String = Replace(TextBoxF10.Text, ".", sep)

        Status.Content = "Расчет..."

        TextBoxF1.Text = tb1
        TextBoxF2.Text = tb2
        TextBoxF3.Text = tb3
        TextBoxF4.Text = tb4
        TextBoxF5.Text = tb5
        TextBoxF6.Text = tb6
        TextBoxF7.Text = tb7
        TextBoxF8.Text = tb8
        TextBoxF9.Text = tb9
        TextBoxF10.Text = tb10


        On Error GoTo ErrorHandler

        Pmax = TextBoxF4.Text
        Psr = TextBoxF5.Text
        Tg = TextBoxF6.Text + 273.15
        Hm = TextBoxF1.Text
        gamma = TextBoxF2.Text
        dzsm = TextBoxF9.Text
        ksi = TextBoxF7.Text
        Q = TextBoxF10.Text
        M = TextBoxF11.Text

        If CheckBox2.IsChecked = False Then

            If TextBoxF4.Text = "" Then
                MsgBox("Введите значение максимального давления газа при наддуве", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF5.Text = "" Then
                MsgBox("Введите значение среднего давления газа при наддуве", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF6.Text = "" Then
                MsgBox("Введите температуру газа в баке", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF1.Text = "" Then
                MsgBox("Введите значение максимального уровня компонента топлива", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF2.Text = "" Then
                MsgBox("Введите удельный вес компонента топлива", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If

            If RadioButtonF1.IsChecked = True Then
                Rh = (8.314 / 0.028) / 9.80665
            Else
                Rh = (8.314 / 0.004) / 9.80665
            End If

            If RadioF1.IsChecked = True Then
                If TextBoxF7.Text = "" Then
                    MsgBox("Введите коэффициент гидравлического сопротивления", vbExclamation)
                    Status.Content = "Ошибка"
                    Exit Sub
                End If
                mu = 1 / ((1 + ksi) ^ (1 / 2))
                TextBoxF8.Text = Math.Round(mu, 4)
            Else
                If TextBoxF8.Text = "" Then
                    MsgBox("Введите коэффицент гидравлических потерь", vbExclamation)
                    Status.Content = "Ошибка"
                    Exit Sub
                End If
                mu = TextBoxF8.Text
                TextBoxF7.Text = Math.Round((((1 / mu) ^ 2) - 1), 4)
            End If

            If RadioF3.IsChecked = True Then
                If TextBoxF3.Text = "" Then
                    MsgBox("Введите значение площади ЗСМ", vbExclamation)
                    Status.Content = "Ошибка"
                    Exit Sub
                End If
                Szsm = TextBoxF3.Text
                TextBoxF9.Text = Math.Round((Szsm * 4 / 3.14159254) ^ (1 / 2), 4)
            Else
                If TextBoxF9.Text = "" Then
                    MsgBox("Введите диаметр ЗСМ", vbExclamation)
                    Status.Content = "Ошибка"
                    Exit Sub
                End If
                Szsm = (3.14159254 * ((dzsm ^ 2) / 4))
                TextBoxF3.Text = Math.Round(Szsm, 4)
            End If

            Q = mu * Szsm * ((2 * 9.80665 * (Hm + ((Pmax * (10 ^ 4)) / gamma))) ^ (1 / 2))
            M = (Psr * (10 ^ 4) * Q) / (Rh * Tg)

            TextBoxF10.Text = Math.Round(Q * 60000, 3)
            TextBoxF11.Text = Math.Round(M, 3)

            Status.Content = "Ready"
        Else

            If TextBoxF5.Text = "" Then
                MsgBox("Введите среднее значение давления газа при наддуве", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF6.Text = "" Then
                MsgBox("Введите значение температуры газа в баке", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If
            If TextBoxF10.Text = "" Then
                MsgBox("Введите значение объемного расхода", vbExclamation)
                Status.Content = "Ошибка"
                Exit Sub
            End If


            Psr = TextBoxF5.Text
            Tg = TextBoxF6.Text + 273.15
            Q = TextBoxF10.Text


            If RadioButtonF1.IsChecked = True Then
                Rh = (8.314 / 0.028) / 9.80665
            Else
                Rh = (8.314 / 0.004) / 9.80665
            End If

            M = (Psr * (10 ^ 4) * (Q / 60000)) / (Rh * Tg)
            TextBoxF11.Text = Math.Round(M, 3)

            Status.Content = "Готово"
        End If
            Exit Sub
ErrorHandler: MsgBox("Ошибка! " & "Проверьте правильность ввода данных", vbCritical)
            Status.Content = "Ошибка"
    End Sub

    'Кнопка для расчета по объемному расходу без применения CheckBox
    '    Private Sub ButtonF3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ButtonF3.Click
    '        Dim M As Object, Psr As Object, Q As Object, Rh As Object, Tg As Object

    '        On Error GoTo ErrorHandler

    '        Status.Content = "Расчет..."

    '        If TextBoxF5.Text = "" Then
    '            MsgBox("Введите среднее значение давления газа при наддуве", vbExclamation)
    '            Status.Content = "Ошибка"
    '            Exit Sub
    '        End If
    '        If TextBoxF6.Text = "" Then
    '            MsgBox("Введите значение температуры газа в баке", vbExclamation)
    '            Status.Content = "Ошибка"
    '            Exit Sub
    '        End If
    '        If TextBoxF10.Text = "" Then
    '            MsgBox("Введите значение объемного расхода", vbExclamation)
    '            Status.Content = "Ошибка"
    '            Exit Sub
    '        End If


    '        Psr = TextBoxF5.Text
    '        Tg = TextBoxF6.Text + 273.15
    '        Q = TextBoxF10.Text


    '        If RadioButtonF1.IsChecked = True Then
    '            Rh = (8.314 / 0.028) / 9.80665
    '        Else
    '            Rh = (8.314 / 0.004) / 9.80665
    '        End If

    '        M = (Psr * (10 ^ 4) * (Q / 60000)) / (Rh * Tg)
    '        TextBoxF11.Text = Math.Round(M, 3)

    '        Status.Content = "Готово"

    '        Exit Sub
    'ErrorHandler: MsgBox("Ошибка! " & "Проверьте правильность ввода данных", vbCritical)
    '        Status.Content = "Ошибка"
    '    End Sub

    Private Sub Radio1_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Radio1.Checked
        TextBox7.IsEnabled = True
        TextBox8.IsEnabled = False
    End Sub


    Private Sub Radio2_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Radio2.Checked
        TextBox7.IsEnabled = False
        TextBox8.IsEnabled = True
    End Sub

    Private Sub RadioF1_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioF1.Checked
        If CheckBox2.IsChecked = False Then
            TextBoxF7.IsEnabled = True
            TextBoxF8.IsEnabled = False
        End If
    End Sub

    Private Sub RadioF2_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioF2.Checked
        If CheckBox2.IsChecked = False Then
            TextBoxF7.IsEnabled = False
            TextBoxF8.IsEnabled = True
        End If
    End Sub

    Private Sub RadioF3_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioF3.Checked
        If CheckBox2.IsChecked = False Then
            TextBoxF3.IsEnabled = True
            TextBoxF9.IsEnabled = False
        End If
    End Sub


    Private Sub RadioF4_Checked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles RadioF4.Checked
        If CheckBox2.IsChecked = False Then
            TextBoxF3.IsEnabled = False
            TextBoxF9.IsEnabled = True
        End If
    End Sub

    Private Sub CheckBox2_Checked(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles CheckBox2.Checked
        TextBoxF1.IsEnabled = False
        TextBoxF2.IsEnabled = False
        TextBoxF3.IsEnabled = False
        TextBoxF4.IsEnabled = False
        TextBoxF7.IsEnabled = False
        TextBoxF8.IsEnabled = False
        TextBoxF9.IsEnabled = False
    End Sub

    Private Sub CheckBox2_Unchecked(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles CheckBox2.Unchecked
        TextBoxF1.IsEnabled = True
        TextBoxF2.IsEnabled = True
        TextBoxF4.IsEnabled = True
        If RadioF1.IsChecked = True Then
            TextBoxF7.IsEnabled = True
            TextBoxF8.IsEnabled = False
        Else
            TextBoxF7.IsEnabled = False
            TextBoxF8.IsEnabled = True
        End If

        If RadioF3.IsChecked = True Then
            TextBoxF3.IsEnabled = True
            TextBoxF9.IsEnabled = False
        Else
            TextBoxF3.IsEnabled = False
            TextBoxF9.IsEnabled = True
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button4.Click
        About.Show()
    End Sub
End Class
