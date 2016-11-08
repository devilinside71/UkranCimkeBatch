<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ComboBoxPrinter = New System.Windows.Forms.ComboBox()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonSzim = New System.Windows.Forms.Button()
        Me.TextBoxSzim = New System.Windows.Forms.TextBox()
        Me.ButtonTestPrint = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 325.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ComboBoxPrinter, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonPrint, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSzim, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxSzim, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonTestPrint, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.8169!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.1831!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(629, 284)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ComboBoxPrinter
        '
        Me.ComboBoxPrinter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxPrinter.FormattingEnabled = True
        Me.ComboBoxPrinter.Location = New System.Drawing.Point(328, 3)
        Me.ComboBoxPrinter.Name = "ComboBoxPrinter"
        Me.ComboBoxPrinter.Size = New System.Drawing.Size(298, 41)
        Me.ComboBoxPrinter.TabIndex = 0
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPrint.Location = New System.Drawing.Point(328, 188)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(298, 47)
        Me.ButtonPrint.TabIndex = 2
        Me.ButtonPrint.Text = "Nyomtat"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonSzim
        '
        Me.ButtonSzim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonSzim.Location = New System.Drawing.Point(3, 188)
        Me.ButtonSzim.Name = "ButtonSzim"
        Me.ButtonSzim.Size = New System.Drawing.Size(319, 47)
        Me.ButtonSzim.TabIndex = 3
        Me.ButtonSzim.Text = "Szimuláció"
        Me.ButtonSzim.UseVisualStyleBackColor = True
        '
        'TextBoxSzim
        '
        Me.TextBoxSzim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxSzim.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBoxSzim.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxSzim.Multiline = True
        Me.TextBoxSzim.Name = "TextBoxSzim"
        Me.TextBoxSzim.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxSzim.Size = New System.Drawing.Size(319, 179)
        Me.TextBoxSzim.TabIndex = 4
        '
        'ButtonTestPrint
        '
        Me.ButtonTestPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTestPrint.Location = New System.Drawing.Point(3, 241)
        Me.ButtonTestPrint.Name = "ButtonTestPrint"
        Me.ButtonTestPrint.Size = New System.Drawing.Size(319, 40)
        Me.ButtonTestPrint.TabIndex = 5
        Me.ButtonTestPrint.Text = "Test print"
        Me.ButtonTestPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 284)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ukrán címke tömeges nyomtatás"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ComboBoxPrinter As ComboBox
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonSzim As Button
    Friend WithEvents TextBoxSzim As TextBox
    Friend WithEvents ButtonTestPrint As Button
End Class
