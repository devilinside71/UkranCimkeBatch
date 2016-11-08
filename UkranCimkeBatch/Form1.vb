
Imports System.Xml

Public Class Form1
    Public cimkenames As List(Of String) = New List(Of String)
    Public cimkemegnev As List(Of String) = New List(Of String)
    Public cimkemeret As List(Of String) = New List(Of String)
    Public cimkeosztaly As List(Of String) = New List(Of String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ZebraPrint.LoadPrinters()
        ComboBoxPrinter.Items.Clear()
        For Each pr In ZebraPrint.PrinterNames
            ComboBoxPrinter.Items.Add(pr)
        Next
        ComboBoxPrinter.SelectedIndex = 0
        Call ZebraPrint.LoadLabels()
        Call LoadCimkes()
    End Sub
    Sub ZPLPrint(Optional mode As Boolean = True)
        Dim strPrinter As String
        Dim strPrintText As String
        Dim res As String
        Dim FILE_NAME As String = My.Settings.CimkeFilename
        Dim TextLine As String
        Dim strCat As String
        Dim strQty As String



        strPrinter = ComboBoxPrinter.Text
        Try
            strPrinter = ZebraPrint.PrinterWinNames(ComboBoxPrinter.SelectedIndex)
        Catch ex As Exception

        End Try





        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                strCat = TextLine.Split(",")(0)
                If mode = True Then
                    strQty = TextLine.Split(",")(1)
                Else
                    strQty = "1"
                End If
                Debug.Print(strCat & ":" & strQty)
                strPrintText = ZebraPrint.LabelCodes(0)

                Dim strMegnev As String
                strMegnev = GetMegnev(strCat)
                Debug.Print(strMegnev)

                If strMegnev <> vbNullString Then
                    Dim strMeret As String
                    strMeret = GetMeret(strCat)
                    Dim strOszt As String
                    strOszt = GetOsztaly(strCat)

                    strPrintText = ZebraPrint.LabelCodes(0)
                    strPrintText = strPrintText.Replace("LABELREF", strCat)
                    strPrintText = strPrintText.Replace("LABELMEGNEV", ZebraPrint.GetZPLutf8Code(strMegnev))
                    strPrintText = strPrintText.Replace("MERET", ZebraPrint.GetZPLutf8Code(strMeret))

                    Dim oszt As String
                    oszt = Trim(strOszt)

                    If oszt = "" Then
                        oszt = "UA.TR.116"
                    Else
                        oszt = ""
                    End If

                    strPrintText = strPrintText.Replace("OSZTALY", oszt)
                    strPrintText = strPrintText.Replace("LABELQTY", strQty)


                    ' Open the printer dialog box, and then allow the user to select a printer.
                    res = ZebraPrint.SendStringToPrinter(strPrinter, strPrintText)
                Else



                    strPrintText = ZebraPrint.LabelCodes(0)
                    strPrintText = strPrintText.Replace("LABELREF", strCat)
                    strPrintText = strPrintText.Replace("MERET", "")
                    strPrintText = strPrintText.Replace("LABELMEGNEV", "ISMERETLEN")



                    strPrintText = strPrintText.Replace("OSZTALY", "")
                    strPrintText = strPrintText.Replace("LABELQTY", "1")


                    ' Open the printer dialog box, and then allow the user to select a printer.
                    res = ZebraPrint.SendStringToPrinter(strPrinter, strPrintText)
                End If


                'Console.WriteLine(strPrintText)

                ' Open the printer dialog box, and then allow the user to select a printer.

            Loop
        Else

            MessageBox.Show("CimkekBatch.txt nem található")
        End If


        MessageBox.Show("KÉSZ!")
    End Sub



    Private Sub ButtonPrint_Click_1(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Call ZPLPrint()
    End Sub
    Public Function GetMegnev(kod As String) As String
        GetMegnev = vbNullString
        For i = 0 To cimkenames.Count - 1
            If cimkenames(i) = kod Then
                GetMegnev = cimkemegnev(i)
            End If
        Next
    End Function
    Public Function GetMeret(kod As String) As String
        GetMeret = vbNullString
        For i = 0 To cimkenames.Count - 1
            If cimkenames(i) = kod Then
                GetMeret = cimkemeret(i)
            End If
        Next
    End Function
    Public Function GetOsztaly(kod As String) As String
        GetOsztaly = vbNullString
        For i = 0 To cimkenames.Count - 1
            If cimkenames(i) = kod Then
                GetOsztaly = cimkeosztaly(i)
            End If
        Next
    End Function
    Public Sub LoadCimkes()
        Dim m_xmlr As XmlTextReader
        'Create the XML Reader
        m_xmlr = New XmlTextReader("UACimke.xml")
        'Disable whitespace so that you don't have to read over whitespaces
        m_xmlr.WhitespaceHandling = WhitespaceHandling.None
        'read the xml declaration and advance to family tag
        m_xmlr.Read()
        'read the family tag
        m_xmlr.Read()
        'Load the Loop
        While Not m_xmlr.EOF
            'Go to the name tag
            m_xmlr.Read()
            'if not start element exit while loop
            If Not m_xmlr.IsStartElement() Then
                Exit While
            End If
            'Get the Gender Attribute Value
            cimkenames.Add(m_xmlr.GetAttribute("name"))
            'Read elements firstname and lastname
            m_xmlr.Read()
            'Get the firstName Element Value
            cimkemegnev.Add(m_xmlr.ReadElementString("megnev"))
            cimkemeret.Add(m_xmlr.ReadElementString("meret"))
            cimkeosztaly.Add(m_xmlr.ReadElementString("osztaly"))
        End While
        'close the reader
        m_xmlr.Close()
    End Sub

    Private Sub ButtonSzim_Click(sender As Object, e As EventArgs) Handles ButtonSzim.Click
        Call Szimulacio()
    End Sub
    Sub Szimulacio()
        Dim strPrintText As String
        Dim FILE_NAME As String = "CimkekBatch.txt"
        Dim TextLine As String
        Dim strCat As String
        Dim strQty As String





        strPrintText = vbNullString


        If System.IO.File.Exists(FILE_NAME) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                strCat = TextLine.Split(",")(0)
                strQty = TextLine.Split(",")(1)
                Debug.Print(strCat & ":" & strQty)


                Dim strMegnev As String
                strMegnev = GetMegnev(strCat)
                Debug.Print(strMegnev)

                If strMegnev = vbNullString Then
                    strPrintText = strPrintText & strCat & vbCrLf
                End If


                'Console.WriteLine(strPrintText)

                ' Open the printer dialog box, and then allow the user to select a printer.

            Loop
            TextBoxSzim.Text = strPrintText
        Else

            MessageBox.Show("CimkekBatch.txt nem található")
        End If


        MessageBox.Show("SZIMULÁCIÓ KÉSZ!")
    End Sub


    Private Sub TextBoxSzim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxSzim.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub ButtonTestPrint_Click(sender As Object, e As EventArgs) Handles ButtonTestPrint.Click
        Call ZPLPrint(False)
    End Sub
End Class
