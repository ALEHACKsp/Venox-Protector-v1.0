Option Infer On
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices
Imports Mono.Cecil
Imports Mono.Cecil.Cil
Imports Mono.Collections.Generic
Public Class Main
#Region "Controls"
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Environment.Exit(0)
    End Sub
    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        Me.Size = New Point(320, 160)
        Threading.Thread.Sleep(100)
        TabControl1.SelectTab(SettingsPage)
        Me.Size = New Point(320, 300)
    End Sub
    Private Sub btncredits_Click(sender As Object, e As EventArgs) Handles btncredits.Click
        Me.Size = New Point(320, 160)
        Threading.Thread.Sleep(100)
        TabControl1.SelectTab(CreditsPage)
        Me.Size = New Point(320, 300)
    End Sub
#End Region
#Region "Funcs"
    Public Function ShouldRename(m As MethodDefinition) As Boolean
        Dim flag As Boolean = Operators.CompareString(m.Name, "InitializeComponent", False) = 0
        Dim result As Boolean
        If flag Then
            result = False
        Else
            Dim left As String = m.Name.ToLower()
            flag = (Operators.CompareString(left, "<Module>", False) <> 0 AndAlso Operators.CompareString(left, ".ctor", False) <> 0 AndAlso Operators.CompareString(left, ".cctor", False) <> 0 AndAlso Operators.CompareString(left, "new", False) <> 0 AndAlso Operators.CompareString(left, "dispose", False) <> 0 AndAlso Operators.CompareString(left, "finalize", False) <> 0 AndAlso Not m.IsConstructor AndAlso Not m.IsRuntime AndAlso Not m.IsRuntimeSpecialName AndAlso Not m.IsSpecialName AndAlso Not m.IsVirtual AndAlso Not m.IsAbstract AndAlso m.[Overrides].Count <= 0 AndAlso Not m.Name.StartsWith("<") AndAlso Not m.IsPInvokeImpl)
            result = flag
        End If
        Return result
    End Function
    Public Sub SetN(asm As AssemblyDefinition)
        Try
            Try
                Dim enumerator As Collection(Of TypeDefinition).Enumerator = asm.MainModule.Types.GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As TypeDefinition = enumerator.Current
                    Dim mtname As Boolean = Not current.Name.StartsWith("sad")
                    If mtname Then
                        list.Add(current)
                    End If
                End While
            Finally
                Dim enumerator As Collection(Of TypeDefinition).Enumerator
                CType(enumerator, IDisposable).Dispose()
            End Try
            Try
                Dim enumerator2 As List(Of TypeDefinition).Enumerator = list.GetEnumerator()
                While enumerator2.MoveNext()
                    Dim current2 As TypeDefinition = enumerator2.Current
                    Try
                        Dim enumerator3 As Collection(Of MethodDefinition).Enumerator = current2.Methods.GetEnumerator()
                        While enumerator3.MoveNext()
                            Dim current3 As MethodDefinition = enumerator3.Current
                            Dim flag As Boolean = Not current3.Name.StartsWith("sad")
                            If flag Then
                                list2.Add(current3)
                            End If
                        End While
                    Finally
                        Dim enumerator3 As Collection(Of MethodDefinition).Enumerator
                        CType(enumerator3, IDisposable).Dispose()
                    End Try
                End While
            Finally
                Dim enumerator2 As List(Of TypeDefinition).Enumerator
                CType(enumerator2, IDisposable).Dispose()
            End Try
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & ex.Message.ToString
        End Try
    End Sub
    Public Function ShouldRename(c As TypeDefinition) As Boolean
        Return Operators.CompareString(c.Name, "<Module>", False) <> 0 AndAlso Not c.IsRuntimeSpecialName AndAlso Not c.IsSpecialName AndAlso Not c.Name.Contains("Resources") AndAlso Not c.Name.StartsWith("<") AndAlso Not c.Name.Contains("__") AndAlso Not c.IsEnum
    End Function
    Public Function GetRndCrap() As OpCode
        Dim result As OpCode
        Select Case r.[Next](1, 5)
            Case 1
                result = OpCodes.Add
            Case 2
                result = OpCodes.Div
            Case 3
                result = OpCodes.[Xor]
            Case 4
                result = OpCodes.Mul
        End Select
        Return result
    End Function
    Public Function GetRandomType() As Type
        Dim typeFromHandle As Type
        Select Case r.[Next](0, 10)
            Case 0
                typeFromHandle = GetType(Type)
            Case 1
                typeFromHandle = GetType(Void)
            Case 2
                typeFromHandle = GetType(Form)
            Case 3
                typeFromHandle = GetType(Reflection.Assembly)
            Case 4
                typeFromHandle = GetType(Byte())
            Case 5
                typeFromHandle = GetType(Char)
            Case 6
                typeFromHandle = GetType(AssemblyDefinition)
            Case 7
                typeFromHandle = GetType(Button)
            Case 8
                typeFromHandle = GetType(Boolean)
            Case 9
                typeFromHandle = GetType(Encoding)
            Case 10
                typeFromHandle = GetType(Clipboard)
            Case Else
                typeFromHandle = GetType(Form)
        End Select
        Return typeFromHandle
    End Function
    Public Function IsBase64(b As String) As Boolean
        Dim regex As Regex = New Regex("^([A-Za-z0-9+/]{4})*([A-Za-z0-9+/]{4}|[A-Za-z0-9+/]{3}=|[A-Za-z0-9+/]{2}==)$")
        Return regex.IsMatch(b)
    End Function
    Public Function SuppressIlDasm(a As AssemblyDefinition) As AssemblyDefinition
        Try
            Dim constructor As MethodReference = a.MainModule.Import(GetType(SuppressIldasmAttribute).GetConstructor(New Type(-1) {}))
            a.CustomAttributes.Add(New Mono.Cecil.CustomAttribute(constructor))
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & ex.Message.ToString
        End Try
        Return a
    End Function
    Public Function FixRes(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Try
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As ModuleDefinition = enumerator.Current
                    Try
                        Dim enumerator2 As Collection(Of Mono.Cecil.Resource).Enumerator = current.Resources.GetEnumerator()
                        While enumerator2.MoveNext()
                            Dim current2 As Mono.Cecil.Resource = enumerator2.Current
                            Dim flag As Boolean = current2.Name.Contains("My.Resources")
                            If flag Then
                                current2.Name = current2.Name.Replace("My.Resources.", "")
                            End If
                        End While
                    Finally
                        Dim enumerator2 As Collection(Of Mono.Cecil.Resource).Enumerator
                        CType(enumerator2, IDisposable).Dispose()
                    End Try
                End While
            Finally
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator
                CType(enumerator, IDisposable).Dispose()
            End Try
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & ex.Message.ToString
        End Try
        Return reversed
    End Function
    Public Function AddInxSignature(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Try
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules().GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As ModuleDefinition = enumerator.Current()
                    current.Types().Add(New TypeDefinition("VenoX", "Discord:Inx#0308", 0))
                End While
            Finally
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator
                enumerator.Dispose()
            End Try
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & "Protected & Obfuscated!"
        End Try
        Return reversed
    End Function
    Public Function AddJunk(reversed As AssemblyDefinition) As AssemblyDefinition
        Try
            Try
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules().GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As ModuleDefinition = enumerator.Current()
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                    current.Types().Add(New TypeDefinition(RandomString(r), RandomString(r), 0))
                End While
            Finally
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator
                enumerator.Dispose()
            End Try
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & ex.Message.ToString
        End Try
        Return reversed
    End Function
    Public Function randomname(lengh As Integer) As String
        VBMath.Randomize()
        Dim text As String = ""
        text = renamearray(r.[Next](0, renamearray.Length)).Trim().Replace("'", "")
        Return text
    End Function
    Public Function Rename(reversed As AssemblyDefinition) As AssemblyDefinition
        VBMath.Randomize()
        Try
            Try
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator = reversed.Modules.GetEnumerator()
                While enumerator.MoveNext()
                    Dim current As ModuleDefinition = enumerator.Current
                    Try
                        Dim enumerator2 As Collection(Of TypeDefinition).Enumerator = current.Types.GetEnumerator()
                        While enumerator2.MoveNext()
                            Dim current2 As TypeDefinition = enumerator2.Current
                            Dim flag As Boolean = ShouldRename(current2)
                            If flag Then
                                Dim name As String = current2.Name
                                current2.Name = randomname(r.[Next](30, 50))
                                Try
                                    Dim enumerator3 As Collection(Of Mono.Cecil.Resource).Enumerator = current.Resources.GetEnumerator()
                                    While enumerator3.MoveNext()
                                        Dim current3 As Mono.Cecil.Resource = enumerator3.Current
                                        flag = (current3.Name.Contains(name) AndAlso Operators.CompareString(current3.Name.Substring(current3.Name.LastIndexOf(name) - 1, 1), ".", False) = 0)
                                        If flag Then
                                            current3.Name = current2.FullName + ".resources"
                                        End If
                                    End While
                                Finally
                                    Dim enumerator3 As Collection(Of Mono.Cecil.Resource).Enumerator
                                    CType(enumerator3, IDisposable).Dispose()
                                End Try
                            End If
                            Try
                                Dim enumerator4 As Collection(Of MethodDefinition).Enumerator = current2.Methods.GetEnumerator()
                                While enumerator4.MoveNext()
                                    Dim current4 As MethodDefinition = enumerator4.Current
                                    flag = ShouldRename(current4)
                                    If flag Then
                                        current4.Name = randomname(r.[Next](30, 50))
                                    End If
                                    Try
                                        Dim enumerator5 As Collection(Of ParameterDefinition).Enumerator = current4.Parameters.GetEnumerator()
                                        While enumerator5.MoveNext()
                                            Dim current5 As ParameterDefinition = enumerator5.Current
                                            current5.Name = randomname(r.[Next](30, 50))
                                        End While
                                    Finally
                                        Dim enumerator5 As Collection(Of ParameterDefinition).Enumerator
                                        CType(enumerator5, IDisposable).Dispose()
                                    End Try
                                End While
                            Finally
                                Dim enumerator4 As Collection(Of MethodDefinition).Enumerator
                                CType(enumerator4, IDisposable).Dispose()
                            End Try
                        End While
                    Finally
                        Dim enumerator2 As Collection(Of TypeDefinition).Enumerator
                        CType(enumerator2, IDisposable).Dispose()
                    End Try
                End While
            Finally
                Dim enumerator As Collection(Of ModuleDefinition).Enumerator
                CType(enumerator, IDisposable).Dispose()
            End Try
        Catch ex As Exception
            RichTextBox1.Text += vbNewLine & ex.Message.ToString
        End Try
        Return reversed
    End Function
    Private Sub renamemodules(assemblyDef As AssemblyDefinition)
        For Each moduledef As ModuleDefinition In assemblyDef.Modules
            If moduledef.IsMain Then
                moduledef.Name = "Discord : Inx#0308"
                moduledef.Assembly.Name.Name = "Discord : Inx#0308"
            End If
        Next
    End Sub
    Function RandomString(r As Random)
        Dim s As String = "kYp3s6v9y$B&E)H+MbQeThWmZq4t7w!z%C*F-JaNcRfUjXn2r5u8x/A?D(G+KbPeSgVkYp3s6v9y$B&E)H@McQfTjWmZq4t7w!z%C*F-JaNdRgUkXp2r5u8x/A?D(G+KbPeShVmYq3t6v9y$B&E)H@McQfTjWnZr4u7x!z%C*F-JaNdRgUkXp2s5v8y/B?D(G+KbPeShVmYq3t6w9z$C&F)H@McQfTjWnZr4u7x!A%D*G-KaNdRgUkXp2s5v8y/B?E(H+MbQeShVmYq3t6w9z$C&F)J@NcRfUjWnZr4u7x!A%D*G-KaPdSgVkYp3s5v8y/B?E(H+MbQeThWmZq4t7w9z$C&F)J@NcRfUjXn2r5u8x/A%D*G-KaPdSgVkYp3s6v9y$B&E(H+MbQeThWmZq4t7w!z%C*F-J@NcRfUjXn2r5u8x/A?D(G+KbPdSgVkYp3s6v9y$B&E)H@McQfThWmZq4t7w!z%C*F-JaNdRgUkXn2r5u8x/A?D(G+KbPeSh"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(1, 25)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function
    Private Sub renamenamespaces(assemblyDef As AssemblyDefinition)
        For Each moduledef As ModuleDefinition In assemblyDef.Modules
            For Each typedef As TypeDefinition In moduledef.Types
                Dim r As New Random
                typedef.Namespace = RandomString(r)
            Next
        Next
    End Sub
    Private Sub renametypes(assemblyDef As AssemblyDefinition)
        For Each moduledef As ModuleDefinition In assemblyDef.Modules
            For Each types As TypeDefinition In moduledef.Types
                Dim r As New Random
                types.Name = "VenoX"
            Next
        Next
    End Sub
    Private Sub renamemethods(assemblyDef As AssemblyDefinition)
        For Each moduledef As ModuleDefinition In assemblyDef.Modules
            For Each mdef As TypeDefinition In moduledef.Types
                For Each methoddef As MethodDefinition In mdef.Methods
                    methoddef.Name = "VenoX"
                Next
            Next
        Next
    End Sub
    Private Sub lastrename(assemblyDef As AssemblyDefinition)
        For Each moduledef As ModuleDefinition In assemblyDef.Modules
            For Each mdef As TypeDefinition In moduledef.Types
                For Each methoddef As MethodDefinition In mdef.Methods
                    For Each Paramdef As ParameterDefinition In methoddef.Parameters
                        Paramdef.Name = "VenoX"
                    Next
                Next
            Next
        Next
    End Sub
    Public Shared Function encodeBytes(ByVal bytes() As Byte, ByVal pass As String) As Byte()
        Dim XorBytes() As Byte = Encoding.Unicode.GetBytes(pass)
        For i As Integer = 0 To bytes.Length - 1
            bytes(i) = bytes(i) Xor XorBytes(i Mod 16)
        Next i
        Return bytes
    End Function
    Public Shared Function decryptBytes(ByVal bytes() As Byte, ByVal pass As String) As Byte()
        Dim XorBytes() As Byte = Encoding.Unicode.GetBytes(pass)
        For i As Integer = 0 To bytes.Length - 1
            bytes(i) = bytes(i) Xor XorBytes(i Mod 16)
        Next i
        Return bytes
    End Function
    Public Shared Function RandomString(ByVal length As Integer) As String
        Const chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Return New String(Enumerable.Repeat(chars, length).Select(Function(s) s(random.Next(s.Length))).ToArray())
    End Function
    Public Shared Function Encode(ByVal str As String) As String
        Return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(str))
    End Function
    Private Shared Function InjectDecrypter(ByVal AssemblyDef As AssemblyDefinition) As MethodDefinition
        For Each ModuleDef As ModuleDefinition In AssemblyDef.Modules
            For Each TypeDef As TypeDefinition In ModuleDef.GetTypes()
                If TypeDef.Name = "<Module>" Then
                    Dim MethodDef As MethodDefinition = CreateDecrypter(AssemblyDef)
                    TypeDef.Methods.Add(MethodDef)
                    Return MethodDef
                End If
            Next TypeDef
        Next ModuleDef
        Throw New Exception("Decrypter not injected.")
    End Function
    Private Shared Function CreateDecrypter(ByVal AssemblyDef As AssemblyDefinition) As MethodDefinition
        Dim Decrypt As New MethodDefinition("Decrypt", MethodAttributes.Public Or MethodAttributes.Static, AssemblyDef.MainModule.Import(GetType(String)))
        Decrypt.Parameters.Add(New ParameterDefinition(AssemblyDef.MainModule.Import(GetType(String))))
        Dim Body As New List(Of Instruction)()
        Body.Add(Instruction.Create(OpCodes.Call, AssemblyDef.MainModule.Import(GetType(System.Text.Encoding).GetMethod("get_UTF8"))))
        Body.Add(Instruction.Create(OpCodes.Ldarg_0))
        Body.Add(Instruction.Create(OpCodes.Call, AssemblyDef.MainModule.Import(GetType(System.Convert).GetMethod("FromBase64String", New Type() {GetType(String)}))))
        Body.Add(Instruction.Create(OpCodes.Callvirt, AssemblyDef.MainModule.Import(GetType(System.Text.Encoding).GetMethod("GetString", New Type() {GetType(Byte())}))))
        Body.Add(Instruction.Create(OpCodes.Ret))
        For Each Instr As Instruction In Body
            Decrypt.Body.Instructions.Add(Instr)
        Next Instr
        Return Decrypt
    End Function
    Public Function strenc(reversed As AssemblyDefinition) As AssemblyDefinition
        Dim MD As MethodDefinition = InjectDecrypter(reversed)
        For Each ModuleDef As ModuleDefinition In reversed.Modules
            For Each TypeDef As TypeDefinition In ModuleDef.GetTypes()
                For Each MethodDef As MethodDefinition In TypeDef.Methods
                    If MethodDef.HasBody Then
                        Dim ilp As ILProcessor = MethodDef.Body.GetILProcessor()
                        For i As Integer = 0 To MethodDef.Body.Instructions.Count - 1
                            Dim InstructionDef As Instruction = MethodDef.Body.Instructions(i)
                            If InstructionDef.OpCode = OpCodes.Ldstr Then
                                InstructionDef.Operand = Encode(InstructionDef.Operand.ToString())
                                ilp.InsertAfter(InstructionDef, Instruction.Create(OpCodes.Call, MD))
                            End If
                        Next i
                    End If
                Next MethodDef
            Next TypeDef
        Next ModuleDef
        Return reversed
    End Function
#End Region
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        r = New Random()
        list = New List(Of TypeDefinition)()
        list2 = New List(Of MethodDefinition)()
        Me.AllowTransparency = True
        Me.TransparencyKey = Color.DimGray
        AssemblyPath.AllowDrop = True
    End Sub
    Private Sub AssemblyPath_DragDrop(sender As Object, e As DragEventArgs) Handles AssemblyPath.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim assembly As String = Nothing
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())
            For Each Path In files
                If Not Path.EndsWith(".exe") Then
                Else
                    AssemblyPath.Text = Nothing
                    AssemblyPath.Text = Path
                End If
            Next
        End If
    End Sub
    Private Sub AssemblyPath_DragEnter(sender As Object, e As DragEventArgs) Handles AssemblyPath.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub
    Private Sub actall_CheckedChanged(sender As Object) Handles actall.CheckedChanged
        If actall.Checked Then
            actall.Text = "Revert ( Uncheck all )"
            renamer.Checked = True
            fixresources.Checked = True
            junk.Checked = True
            Hidenamespaces.Checked = True
            antiildasm.Checked = True
            strencryption.Checked = True
        Else
            actall.Text = "Best settings ( Active all recommended )"
            renamer.Checked = False
            fixresources.Checked = False
            junk.Checked = False
            Hidenamespaces.Checked = False
            antiildasm.Checked = False
            strencryption.Checked = False
        End If
    End Sub
    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        Me.Size = New Point(320, 160)
        Dim ofd As New OpenFileDialog : With ofd
            .Tag = "Browse for assembly"
            .Title = "Browse for assembly"
            .Filter = ".NET Assembly |*.exe"
            .Multiselect = False
        End With
        Dim okres As Boolean = ofd.ShowDialog = DialogResult.OK
        If okres = True Then
            AssemblyPath.Text = ofd.FileName
        End If
    End Sub
    Private Sub btnprotect_Click(sender As Object, e As EventArgs) Handles btnprotect.Click
        Me.Size = New Point(320, 160)
        Threading.Thread.Sleep(100)
        TabControl1.SelectTab(logpage)
        Me.Size = New Point(320, 300)
        Dim assembly As Boolean = (Operators.CompareString(AssemblyPath.Text, "", False) = 0)
        If assembly Or AssemblyPath.Text = "Drag & Drop Supported" Then
            RichTextBox1.Text += vbNewLine & "Assembly not found!"
        ElseIf Not renamer.Checked AndAlso Not fixresources.Checked AndAlso _
        Not junk.Checked AndAlso Not Hidenamespaces.Checked AndAlso _
        Not antiildasm.Checked AndAlso Not strencryption.Checked Then
            RichTextBox1.Text += vbNewLine & "Please select at least 1 protection!"
        Else
            renamearray = My.Resources.ren.Split(New Char() {vbCr})
            Dim filePath As String = AssemblyPath.Text
            Dim directoryPath As String = Path.GetDirectoryName(filePath)
            Dim assemblyDefinition1 As AssemblyDefinition = AssemblyDefinition.ReadAssembly(AssemblyPath.Text)
            SetN(assemblyDefinition1)
            assemblyDefinition1 = AddInxSignature(assemblyDefinition1)
            If fixresources.Checked Then
                assemblyDefinition1 = FixRes(assemblyDefinition1)
            End If
            If strencryption.Checked Then
                assemblyDefinition1 = strenc(assemblyDefinition1)
            End If
            If antiildasm.Checked Then
                assemblyDefinition1 = SuppressIlDasm(assemblyDefinition1)
            End If
            If junk.Checked Then
                assemblyDefinition1 = AddJunk(assemblyDefinition1)
            End If
            If Hidenamespaces.Checked Then
                renamenamespaces(assemblyDefinition1)
            End If
            If renamer.Checked Then
                renamemodules(assemblyDefinition1)
                renametypes(assemblyDefinition1)
                lastrename(assemblyDefinition1)
                assemblyDefinition1 = Rename(assemblyDefinition1)
            End If
            assemblyDefinition1.Write(directoryPath + "\Protected.exe")
            If File.Exists(directoryPath + "\Protected.exe") Then
                RichTextBox1.Text += vbNewLine & "Protected & Obfuscated!"
            End If
        End If
    End Sub
    Private Sub Discord_Click(sender As Object, e As EventArgs) Handles Discord.Click
        Process.Start("https://pastebin.com/raw/QkCNxKmc")
    End Sub
End Class
