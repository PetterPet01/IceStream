Imports System
Imports System.Xml.Serialization
Imports System.Collections.Generic

<XmlRoot(ElementName:="paste")>
    Public Class Paste
        <XmlElement(ElementName:="paste_key")>
        Public Property Paste_key As String
        <XmlElement(ElementName:="paste_date")>
        Public Property Paste_date As String
        <XmlElement(ElementName:="paste_title")>
        Public Property Paste_title As String
        <XmlElement(ElementName:="paste_size")>
        Public Property Paste_size As String
        <XmlElement(ElementName:="paste_expire_date")>
        Public Property Paste_expire_date As String
        <XmlElement(ElementName:="paste_private")>
        Public Property Paste_private As String
        <XmlElement(ElementName:="paste_format_long")>
        Public Property Paste_format_long As String
        <XmlElement(ElementName:="paste_format_short")>
        Public Property Paste_format_short As String
        <XmlElement(ElementName:="paste_url")>
        Public Property Paste_url As String
        <XmlElement(ElementName:="paste_hits")>
        Public Property Paste_hits As String
    End Class

    <XmlRoot(ElementName:="Pastes")>
    Public Class Pastes
        <XmlElement(ElementName:="paste")>
        Public Property Paste As List(Of Paste)
End Class