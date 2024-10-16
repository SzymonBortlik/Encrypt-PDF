'
' This software has been written by szymon.bortlik@gmail.com
'
' Encrypt PDF files using AES 256 bit Encryption Standard
' It's only GUI for free qpdf command line software - Apache License 2.0
'
' This software ONLY encrypt pdf files - nothing more so far
' Acrobat Reader needed

Imports System.IO
Imports System.Text

Public Class Form1

    Dim input, output, pass, arguments
    'Dim pdfs() As String
    Dim temp = "c:\TEMP\"
    Dim tempinput = "C:\TEMP\original.pdf"
    Dim tempoutput = "C:\TEMP\encrypted.pdf"
    Dim passfile As StreamWriter


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AllowDrop = True
        TextBoxPass.Text = ""

        If FileIO.FileSystem.DirectoryExists(temp) = False Then

            FileIO.FileSystem.CreateDirectory(temp)

        Else

            If FileIO.FileSystem.FileExists(tempinput) = True Then

                FileIO.FileSystem.DeleteFile(tempinput)

            End If

            If FileIO.FileSystem.FileExists(tempoutput) = True Then

                FileIO.FileSystem.DeleteFile(tempoutput)

            End If

            If FileIO.FileSystem.FileExists("c:\temp\password") = True Then

                FileIO.FileSystem.DeleteFile("c:\temp\password")

            End If

            'for testing - del all pdf
            'pdfs = Directory.GetFiles(temp, "*.pdf", SearchOption.TopDirectoryOnly)
            'pdfs = Directory.GetFiles(temp, "*.pdf", SearchOption.AllDirectories)

            'For Each pdf In pdfs

            '    FileIO.FileSystem.DeleteFile(pdf)

            'Next

        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ForgetMP.Click

        Process.Start("notepad.exe", "c:\temp\password")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OpenPdf.Click

        OpenFileDialog1.Filter = "Pdf Files|*.pdf"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            input = OpenFileDialog1.FileName

            'for testing
            'infilename = Path.GetFileName(input)

            'Acrobat Reader
            AxAcroPDF1.LoadFile(input)
            AxAcroPDF1.Visible = True

        End If

        GC.Collect()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SavePdf.Click

        SaveFileDialog1.Filter = "Pdf Files|*.pdf"

        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            output = SaveFileDialog1.FileName
            pass = TextBoxPass.Text

            If input = "" Then

                MsgBox("please choose Pdf file to encrypt")

            Else

                If pass = "" Then

                    MsgBox("Please enter the password !!!")

                Else

                    FileIO.FileSystem.CopyFile(input, tempinput)

                    arguments = "--encrypt" + " " + pass + " " + pass + " 256 -- " + tempinput + " " + tempoutput

                    Process.Start(Application.StartupPath + "/Resources/qpdf.exe", arguments).WaitForExit()

                    'System.Threading.Thread.Sleep(2000)

                    If FileIO.FileSystem.FileExists(tempoutput) = True Then

                        passfile = Computer.FileSystem.OpenTextFileWriter("c:\temp\password", True)
                        passfile.WriteLine(DateTime.Now.ToString() + " - " + input + " - " + output + " - " + pass)
                        passfile.Close()

                        If FileIO.FileSystem.FileExists(output) = True Then

                            FileIO.FileSystem.DeleteFile(output)
                            FileIO.FileSystem.CopyFile(tempoutput, output)
                            FileIO.FileSystem.DeleteFile(tempinput)
                            FileIO.FileSystem.DeleteFile(tempoutput)

                            AxAcroPDF1.Visible = False

                        Else

                            FileIO.FileSystem.CopyFile(tempoutput, output)
                            FileIO.FileSystem.DeleteFile(tempinput)
                            FileIO.FileSystem.DeleteFile(tempoutput)

                            AxAcroPDF1.Visible = False

                        End If

                        TextBoxPass.Text = ""

                    Else

                        FileIO.FileSystem.DeleteFile(tempinput)
                        MsgBox("File is already ENCRYPTED, Corrupted or doesn't exist !!!")
                        TextBoxPass.Text = ""
                        AxAcroPDF1.Visible = False

                    End If

                End If

            End If

        End If

        GC.Collect()

    End Sub


    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

        Dim Dropfiles() As String = e.Data.GetData(DataFormats.FileDrop)

        For Each Droppath In Dropfiles

            AxAcroPDF1.LoadFile(Droppath)
            AxAcroPDF1.Visible = True
            input = Droppath.ToString
            TextBoxPass.Text = ""

        Next

    End Sub


    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then

            e.Effect = DragDropEffects.Copy
            AxAcroPDF1.Visible = False

        End If

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged

        If TextBoxPass.Text.Contains(" ") Then

            MsgBox("Password can't have any spaces, Sorry")
            TextBoxPass.Text = ""

        End If

    End Sub


End Class