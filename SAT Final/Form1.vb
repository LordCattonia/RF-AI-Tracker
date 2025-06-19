Imports System.Xml

Public Class Form1
    Private Sub encodeXML_Click(sender As Object, e As EventArgs) Handles encodeXML.Click
        ' Create the XML document with root and child elements
        Dim doc As XDocument = New XDocument(
            New XElement("RFI",
                New XElement("Info", "This is a test RFI file.")
            )
        )

        ' Save the file as test.RFI
        doc.Save("test.rfi")


        MsgBox("Created successfully")
    End Sub

    Private Sub decodeXML_Click(sender As Object, e As EventArgs) Handles decodeXML.Click
        Dim doc As XDocument = XDocument.Load("test.RFI")
        MsgBox(doc.Root.Element("info").Value)
    End Sub
End Class
