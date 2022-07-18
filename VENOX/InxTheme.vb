Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.Threading
Enum MouseState As Byte
    None = 0 : Hover = 1 : Down = 2 : Block = 3
End Enum
Class MovePanel
    Inherits Panel
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New()
        BackColor = Color.Transparent
        Size = New Point(50, 50)
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        drag = True
        mousex = Cursor.Position.X - FindForm.Left
        mousey = Cursor.Position.Y - FindForm.Top
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If drag Then
            FindForm.Top = Cursor.Position.Y - mousey
            FindForm.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        drag = False
    End Sub
End Class
Class Movelabel
    Inherits Label
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Sub New()
        BackColor = Color.Transparent
        Size = New Point(50, 50)
    End Sub
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        drag = True
        mousex = Cursor.Position.X - FindForm.Left
        mousey = Cursor.Position.Y - FindForm.Top
    End Sub
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If drag Then
            FindForm.Top = Cursor.Position.Y - mousey
            FindForm.Left = Cursor.Position.X - mousex
        End If
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        drag = False
    End Sub
    Private _textRenderingHint As TextRenderingHint = TextRenderingHint.SystemDefault
    Public Property TextRenderingHint As TextRenderingHint
        Get
            Return _textRenderingHint
        End Get
        Set(ByVal value As TextRenderingHint)
            _textRenderingHint = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.TextRenderingHint = _textRenderingHint
        MyBase.OnPaint(e)
    End Sub
End Class
<DefaultEvent("CheckedChanged")>
Class InxCheckBox
    Inherits Control
#Region "Declarations"
    Private _Checked As Boolean
    Private State As MouseState = MouseState.None
    Private _CheckedColour As Color = Color.FromArgb(0, 120, 220)
    Private _BorderColour As Color = Color.FromArgb(85, 85, 85)
    Private _BackColour As Color = Color.FromArgb(20, 20, 20)
    Private _TextColour As Color = Color.FromArgb(255, 255, 255)
#End Region
#Region "Colour & Other Properties"
    <Category("Colours")>
    Public Property BaseColour As Color
        Get
            Return _BackColour
        End Get
        Set(value As Color)
            _BackColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property BorderColour As Color
        Get
            Return _BorderColour
        End Get
        Set(value As Color)
            _BorderColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property CheckedColour As Color
        Get
            Return _CheckedColour
        End Get
        Set(value As Color)
            _CheckedColour = value
        End Set
    End Property
    <Category("Colours")>
    Public Property FontColour As Color
        Get
            Return _TextColour
        End Get
        Set(value As Color)
            _TextColour = value
        End Set
    End Property
    Protected Overrides Sub OnTextChanged(ByVal e As EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Property Checked() As Boolean
        Get
            Return _Checked
        End Get
        Set(ByVal value As Boolean)
            _Checked = value
            Invalidate()
        End Set
    End Property
    Event CheckedChanged(ByVal sender As Object)
    Protected Overrides Sub OnClick(ByVal e As EventArgs)
        _Checked = Not _Checked
        RaiseEvent CheckedChanged(Me)
        MyBase.OnClick(e)
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        Height = 22
    End Sub
#End Region
#Region "Mouse States"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Hover : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseEnter(e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Hover : Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None : Invalidate()
    End Sub
#End Region
#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                   ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        Cursor = Cursors.Default
        Size = New Size(100, 22)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, 20, 20)
        With G
            .TextRenderingHint = TextRenderingHint.SystemDefault
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            .Clear(BackColor)
            .FillRectangle(New SolidBrush(_BackColour), Base)
            .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            .DrawString(Text, Font, New SolidBrush(_TextColour), New Rectangle(24, 1, Width, Height - 2), New StringFormat With {.Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Center})
            Select Case State
                Case MouseState.Hover
                    .FillRectangle(New SolidBrush(Color.FromArgb(50, 49, 51)), Base)
                    .DrawRectangle(New Pen(_BorderColour), New Rectangle(1, 1, 18, 18))
            End Select
            If Checked Then
                Dim P() As Point = {New Point(3.5, 11), New Point(6, 8), New Point(9, 12), New Point(15, 5), New Point(17, 6), New Point(9, 16)}
                .FillPolygon(New SolidBrush(_CheckedColour), P)
            End If
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region
End Class
Class InxLabel
    Inherits Label
    Sub New()
        Font = New Font("Corbel", 10, FontStyle.Regular)
        BackColor = Color.Transparent
        ForeColor = Color.FromArgb(150, 150, 150)
    End Sub
    Private _textRenderingHint As TextRenderingHint = TextRenderingHint.SystemDefault
    Public Property TextRenderingHint As TextRenderingHint
        Get
            Return _textRenderingHint
        End Get
        Set(ByVal value As TextRenderingHint)
            _textRenderingHint = value
        End Set
    End Property
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.TextRenderingHint = _textRenderingHint
        MyBase.OnPaint(e)
    End Sub
End Class
Class InxFlatProgressBar2
    Inherits ProgressBar
    Private G As Graphics
    Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        G = e.Graphics
        MyBase.OnPaint(e)
        G.Clear(BackColor)
        Using Border As New Pen(Color.FromArgb(50, 50, 50))
            G.DrawRectangle(Border, New Rectangle(0, 0, Width - 1, Height - 1))
        End Using
        Using Background As New SolidBrush(Color.FromArgb(40, 202, 66))
            G.FillRectangle(Background, New Rectangle(0, 0, Value / Maximum * Width - 1, Height - 1))
        End Using
    End Sub
End Class
#Region "TextBox"
<DefaultEvent("TextChanged")> _
Public Class DarkUITextBox : Inherits Control
#Region "Declarations"
    Private _T As New TextBox()
    Private Property T() As TextBox
        Get
            Return _T
        End Get
        Set(value As TextBox)
            If _T IsNot Nothing Then
                RemoveHandler _T.TextChanged, AddressOf T_TextChanged
                RemoveHandler _T.KeyDown, AddressOf T_KeyDown
            End If
            _T = value
            If _T IsNot Nothing Then
                AddHandler _T.TextChanged, AddressOf T_TextChanged
                AddHandler _T.KeyDown, AddressOf T_KeyDown
            End If
        End Set
    End Property
    Private _TextAlign As HorizontalAlignment = HorizontalAlignment.Left
    Private _MaxLength As Integer = 32767
    Private _ReadOnly As Boolean = False
    Private _UseSystemPasswordChar As Boolean = False
    Private _WatermarkText As String = String.Empty
    Private _Image As Image
    Private _AutoCompleteSource As AutoCompleteSource = AutoCompleteSource.None
    Private _AutoCompleteMode As AutoCompleteMode = AutoCompleteMode.None
    Private _AutoCompleteCustomSource As AutoCompleteStringCollection
    Private _Multiline As Boolean = False
    Private _Lines As String() = Nothing
#End Region
#Region "Native Methods"
    Private Declare Auto Function SendMessage Lib "user32.dll" (hWnd As IntPtr, msg As Integer, wParam As Integer, <System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)> lParam As String) As Int32
#End Region
#Region "Properties"
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property BorderStyle() As BorderStyle
        Get
            Return BorderStyle.None
        End Get
    End Property
    <Category("Custom"), Description("Gets or sets how text is aligned in TextBox control.")> _
    Public Property TextAlign() As HorizontalAlignment
        Get
            Return _TextAlign
        End Get
        Set(value As HorizontalAlignment)
            _TextAlign = value
            If T IsNot Nothing Then
                T.TextAlign = value
            End If
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets how text is aligned in TextBox control.")> _
    Public Property MaxLength() As Integer
        Get
            Return _MaxLength
        End Get
        Set(value As Integer)
            _MaxLength = value
            If T IsNot Nothing Then
                T.MaxLength = value
            End If
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets a value indicating whether text in the text box is read-only.")> _
    Public Property [ReadOnly]() As Boolean
        Get
            Return _ReadOnly
        End Get
        Set(value As Boolean)
            _ReadOnly = value
            If T IsNot Nothing Then
                T.[ReadOnly] = value
            End If
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets a value indicating whether the text in  TextBox control should appear as the default password character.")> _
    Public Property UseSystemPasswordChar() As Boolean
        Get
            Return _UseSystemPasswordChar
        End Get
        Set(value As Boolean)
            _UseSystemPasswordChar = value
            If T IsNot Nothing Then
                T.UseSystemPasswordChar = value
            End If
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets a value indicating whether this is a multiline System.Windows.Forms.TextBox control.")> _
    Public Property Multiline() As Boolean
        Get
            Return _Multiline
        End Get
        Set(value As Boolean)
            _Multiline = value
            If T Is Nothing Then
                Return
            End If
            T.Multiline = value
            If value Then
                T.Height = Height - 10
            Else
                Height = T.Height + 10
            End If
        End Set
    End Property
    <Browsable(False), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property BackgroundImage() As Image
        Get
            Return Nothing
        End Get
    End Property
    <Category("Custom"), Description("Gets or sets the current text in  TextBox.")> _
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
            If T IsNot Nothing Then
                T.Text = value
            End If
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets the text in the System.Windows.Forms.TextBox while being empty.")> _
    Public Property WatermarkText() As String
        Get
            Return _WatermarkText
        End Get
        Set(value As String)
            _WatermarkText = value
            SendMessage(T.Handle, 5377, 0, value)
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets the image of the control.")> _
    Public Property Image() As Image
        Get
            Return _Image
        End Get
        Set(value As Image)
            _Image = value
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")> _
    Public Property AutoCompleteSource() As AutoCompleteSource
        Get
            Return _AutoCompleteSource
        End Get
        Set(value As AutoCompleteSource)
            _AutoCompleteSource = value
            If T IsNot Nothing Then
                T.AutoCompleteSource = value
            End If
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets a value specifying the source of complete strings used for automatic completion.")> _
    Public Property AutoCompleteCustomSource() As AutoCompleteStringCollection
        Get
            Return _AutoCompleteCustomSource
        End Get
        Set(value As AutoCompleteStringCollection)
            _AutoCompleteCustomSource = value
            If T IsNot Nothing Then
                T.AutoCompleteCustomSource = value
            End If
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets an option that controls how automatic completion works for the TextBox.")> _
    Public Property AutoCompleteMode() As AutoCompleteMode
        Get
            Return _AutoCompleteMode
        End Get
        Set(value As AutoCompleteMode)
            _AutoCompleteMode = value
            If T IsNot Nothing Then
                T.AutoCompleteMode = value
            End If
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets the font of the text displayed by the control.")> _
    Public Shadows Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
            If T Is Nothing Then
                Return
            End If
            T.Font = value
            T.Location = New Point(5, 5)
            T.Width = Width - 8
            If Not Multiline Then
                Height = T.Height + 11
            End If
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets the lines of text in the control.")> _
    Public Property Lines() As String()
        Get
            Return _Lines
        End Get
        Set(value As String())
            _Lines = value
            If T Is Nothing Then
                Return
            End If
            T.Lines = value
            Invalidate()
        End Set
    End Property
    <Category("Custom"), Description("Gets or sets the ContextMenuStrip associated with this control.")> _
    Public Overrides Property ContextMenuStrip() As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            MyBase.ContextMenuStrip = value
            If T Is Nothing Then
                Return
            End If
            T.ContextMenuStrip = value
            Invalidate()
        End Set
    End Property
#End Region
#Region "Constructors"
    Public Sub New()
        SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        UpdateStyles()
        BackColor = Color.Transparent
        ForeColor = Color.White
        Font = New Font("Segoe ui", 10)
        T.Multiline = False
        T.Cursor = Cursors.IBeam
        T.BackColor = Color.FromArgb(31, 31, 31)
        T.ForeColor = ForeColor
        T.BorderStyle = BorderStyle.None
        T.Location = New Point(7, 4)
        T.Font = Font
        T.UseSystemPasswordChar = UseSystemPasswordChar
        Size = New Size(135, 30)
        If Multiline Then
            T.Height = Height - 11
        Else
            Height = T.Height + 11
        End If
    End Sub

#End Region

#Region "Events"

    Public Shadows Event TextChanged As TextChangedEventHandler
    Public Delegate Sub TextChangedEventHandler(sender As Object)

    Protected Overrides Sub OnCreateControl()
        MyBase.OnCreateControl()
        If Not Controls.Contains(T) Then
            Controls.Add(T)
        End If
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        T.Size = New Size(Width - 10, Height - 10)
    End Sub

#Region "TextBox MouseEvents"

    Private Sub T_TextChanged(sender As Object, e As EventArgs)
        Text = T.Text
        If TextChangedEvent IsNot Nothing Then
            RaiseEvent TextChanged(Me)
        End If
        Invalidate()
    End Sub

    Private Sub T_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.A Then
            e.SuppressKeyPress = True
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            T.Copy()
            e.SuppressKeyPress = True
        End If
        Invalidate()
    End Sub

#End Region

#End Region

#Region "Draw Control"

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim G As Graphics = e.Graphics
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        Dim Rect As New Rectangle(0, 0, Width - 1, Height - 1)

        Using B As New SolidBrush(Color.FromArgb(31, 31, 31))
            FillRoundedPath(G, B, Rect, 2)
            DrawRoundedPath(G, Color.FromArgb(22, 22, 22), 1, Rect, 2)
        End Using

        If Image IsNot Nothing Then
            T.Location = New Point(31, 4)
            T.Width = Width - 60
            G.InterpolationMode = InterpolationMode.HighQualityBicubic
            G.DrawImage(Image, New Rectangle(8, 6, 16, 16))
        Else
            T.Location = New Point(7, 4)

            T.Width = Width - 10
        End If

    End Sub

#End Region

End Class

#End Region
Class InxSeperator
    Inherits Control
#Region "Declarations"
    Private _SeperatorColour As Color = Color.FromArgb(1, 119, 215)
    Private _Alignment As Style = Style.Horizontal
    Private _Thickness As Single = 1
#End Region
#Region "Properties"
    Enum Style
        Horizontal
        Verticle
    End Enum
    <Category("Control")>
    Public Property Thickness As Single
        Get
            Return _Thickness
        End Get
        Set(value As Single)
            _Thickness = value
        End Set
    End Property

    <Category("Control")>
    Public Property Alignment As Style
        Get
            Return _Alignment
        End Get
        Set(value As Style)
            _Alignment = value
        End Set
    End Property
    <Category("Colours")>
    Public Property SeperatorColour As Color
        Get
            Return _SeperatorColour
        End Get
        Set(value As Color)
            _SeperatorColour = value
        End Set
    End Property
#End Region
#Region "Draw Control"
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or _
                 ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or _
                 ControlStyles.SupportsTransparentBackColor, True)
        DoubleBuffered = True
        BackColor = Color.Transparent
        Size = New Size(20, 20)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim G = Graphics.FromImage(B)
        Dim Base As New Rectangle(0, 0, Width - 1, Height - 1)
        With G
            .SmoothingMode = SmoothingMode.HighQuality
            .PixelOffsetMode = PixelOffsetMode.HighQuality
            Select Case _Alignment
                Case Style.Horizontal
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(0, Height / 2), New Point(Width, Height / 2))
                Case Style.Verticle
                    .DrawLine(New Pen(_SeperatorColour, _Thickness), New Point(Width / 2, 0), New Point(Width / 2, Height))
            End Select
        End With
        MyBase.OnPaint(e)
        G.Dispose()
        e.Graphics.InterpolationMode = 7
        e.Graphics.DrawImageUnscaled(B, 0, 0)
        B.Dispose()
    End Sub
#End Region
End Class
Module functions
    Function CenterText(text As String, font As Font, Width As Integer, Height As Integer) As Point
        Dim W As Integer = (Width / 2) - (TextRenderer.MeasureText(text, font).Width / 2)
        Dim H As Integer = (Height / 2) - (TextRenderer.MeasureText(text, font).Height / 2)
        Dim P As New Point(W, H)
        Return P
    End Function
End Module
Module Helpers
    Function RoundRectangle(ByVal R As Rectangle, ByVal Curve As Integer) As System.Drawing.Drawing2D.GraphicsPath
        Dim GP As New System.Drawing.Drawing2D.GraphicsPath(System.Drawing.Drawing2D.FillMode.Winding)
        GP.AddArc(R.X, R.Y, Curve, Curve, 180.0F, 90.0F)
        GP.AddArc(R.Right - Curve, R.Y, Curve, Curve, 270.0F, 90.0F)
        GP.AddArc(R.Right - Curve, R.Bottom - Curve, Curve, Curve, 0.0F, 90.0F)
        GP.AddArc(R.X, R.Bottom - Curve, Curve, Curve, 90.0F, 90.0F)
        GP.CloseFigure()
        Return GP
    End Function
    Public Sub FillRoundedPath(ByVal G As Graphics, ByVal B As Brush, ByVal Rect As Rectangle, ByVal Curve As Integer, _
                                Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                                Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .FillPath(B, RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub
    Public Sub DrawRoundedPath(ByVal G As Graphics, ByVal C As Color, ByVal Size As Single, ByVal Rect As Rectangle, ByVal Curve As Integer, _
                               Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                               Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True)
        With G
            .DrawPath(New Pen(C, Size), RoundRec(Rect, Curve, TopLeft, TopRight, BottomLeft, BottomRight))
        End With
    End Sub
    Public Function RoundRec(ByVal r As Rectangle, ByVal Curve As Integer, _
                                Optional ByVal TopLeft As Boolean = True, Optional ByVal TopRight As Boolean = True, _
                                Optional ByVal BottomLeft As Boolean = True, Optional ByVal BottomRight As Boolean = True) As GraphicsPath
        Dim CreateRoundPath As New GraphicsPath(FillMode.Winding)
        If TopLeft Then
            CreateRoundPath.AddArc(r.X, r.Y, Curve, Curve, 180.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.X, r.Y, r.X, r.Y)
        End If
        If TopRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.Right - r.Width, r.Y, r.Width, r.Y)
        End If
        If BottomRight Then
            CreateRoundPath.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.Right, r.Bottom, r.Right, r.Bottom)
        End If
        If BottomLeft Then
            CreateRoundPath.AddArc(r.X, r.Bottom - Curve, Curve, Curve, 90.0F, 90.0F)
        Else
            CreateRoundPath.AddLine(r.X, r.Bottom, r.X, r.Bottom)
        End If
        CreateRoundPath.CloseFigure()
        Return CreateRoundPath
    End Function
    Private Size As SizeF
    Public Function MiddlePoint(G As Graphics, TargetText As String, TargetFont As Font, Rect As Rectangle) As Point
        Size = G.MeasureString(TargetText, TargetFont)
        Return New Point(Rect.Width / 2 - Size.Width / 2, Rect.Height / 2 - Size.Height / 2)
    End Function
    Public Function PenHTMlColor(ByVal C_WithoutHash As String, ByVal Size As Single) As Pen
        Return New Pen(GetHTMLColor(C_WithoutHash), Size)
    End Function
    Public Function SolidBrushHTMlColor(ByVal C_WithoutHash As String) As SolidBrush
        Return New SolidBrush(GetHTMLColor(C_WithoutHash))
    End Function
    Public Function GetHTMLColor(ByVal C_WithoutHash As String) As Color
        Return ColorTranslator.FromHtml("#" & C_WithoutHash)
    End Function
End Module


