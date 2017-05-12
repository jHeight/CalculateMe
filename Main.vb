
    Dim fileReader As System.IO.StreamReader
    fileReader = My.Computer.FileSystem.OpenTextFileReader(path & "\settings.xml")
    Dim stringReader As String
    stringReader = fileReader.ReadLine()
    
