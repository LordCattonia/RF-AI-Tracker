Public Class Class1
    Dim RFIList As New XDocument()
    ' This is a simple Windows Forms application that creates and decodes an XML file.
    Private Sub encodeXML_Click(sender As Object, e As EventArgs)
        ' Create the XML document with root and child elements
        Dim doc As New XDocument(
            New XElement("RFI",
                New XElement("Info", "This is a test RFI file.")
            )
        )

        ' Save the file as test.RFI
        doc.Save("test.rfi")


        MsgBox("Created successfully")
    End Sub

    Private Sub decodeXML_Click(sender As Object, e As EventArgs)
        Dim doc As XDocument = XDocument.Load("test.RFI")
        Dim RFIRoot As XElement = doc.Root
        MsgBox("Root element: " & RFIRoot.Name.LocalName)
        MsgBox(RFIRoot.Element("Info").Value)

    End Sub

    ''' <summary>
    ''' Opens an RFI file and loads it into the RFIList variable.
    ''' This method is called when the application starts with a command line argument.
    ''' It also checks to make sure the file is a valid .RFI file before loading it.
    ''' </summary>
    ''' <param name="filePath"></param>
    Sub OpenRfiFile(filePath As String)
        Try
            RFIList = XDocument.Load(filePath)
            Dim RFIRoot As XElement = RFIList.Root
            MsgBox("Root element: " & RFIRoot.Name.LocalName)
            MsgBox(RFIRoot.Element("Info").Value)
        Catch ex As Exception
            MsgBox("Please make sure the file is a valid .RFI file.")
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Dim args() As String = Environment.GetCommandLineArgs()
        If args.Length > 1 Then
            Dim rfiFile As String = args(1)
            OpenRfiFile(rfiFile)
        End If
    End Sub
End Class
