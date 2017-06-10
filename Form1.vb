'Cosas que faltan por hacer:
'   Al seleccionar el cliente o mesa debe cargar el cosumo de ese cliente o mesa en la grilla de consumo
'   Al apretar el boton de cancelar de cliente o mesa deberia regresar todo al estado inicial
'   Con el boton Agregar, agregar los productos ya selecionados a base de datos y recargar la grilla de consumo del cliente o mesa
'   En la grilla de consumo calcular el precio total = precio unitario * cantidad
'   Poder eliminar productos ingresados por equivocacion de la base de datos y recargar la grilla pero con clave de autorizacion
'   


Imports System.Windows.Forms.DataGridView


Public Class Form1
    Inherits System.Windows.Forms.Form
    Friend WithEvents gbPagar As System.Windows.Forms.GroupBox
    Friend WithEvents btPagar As System.Windows.Forms.Button
    Friend WithEvents cbServicio As System.Windows.Forms.CheckBox
    Friend WithEvents cbIVA As System.Windows.Forms.CheckBox
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbServicio As System.Windows.Forms.TextBox
    Friend WithEvents tbIVA As System.Windows.Forms.TextBox
    Friend WithEvents tbSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAnular As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbSelProds As System.Windows.Forms.GroupBox
    Friend WithEvents btAgregar As System.Windows.Forms.Button
    Friend WithEvents lbCantidad As System.Windows.Forms.ListBox
    Friend WithEvents dgvSubTipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvClase As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents gbConsumo As System.Windows.Forms.GroupBox
    Friend WithEvents dgvConsumo As System.Windows.Forms.DataGridView
    Friend WithEvents CodtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CodsubtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescsubtipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents btCancelarRestaurant As System.Windows.Forms.Button
    Friend WithEvents btCancelarBar As System.Windows.Forms.Button
    Friend WithEvents btNuevoBar As System.Windows.Forms.Button
    Friend WithEvents gbFormaPago As System.Windows.Forms.GroupBox
    Friend WithEvents tbSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvDetallePago As System.Windows.Forms.DataGridView
    Friend WithEvents CodformapagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents tbAbono As System.Windows.Forms.TextBox
    Friend WithEvents btTicket As System.Windows.Forms.Button
    Friend WithEvents CostoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btCerrarCuenta As System.Windows.Forms.Button
    Friend WithEvents dgvDetallePago2 As System.Windows.Forms.DataGridView
    Friend WithEvents CodmesaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarConsumoMesa As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cod_tarjeta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EliminarPago As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn





#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OrdenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbPagar = New System.Windows.Forms.GroupBox
        Me.btCerrarCuenta = New System.Windows.Forms.Button
        Me.btTicket = New System.Windows.Forms.Button
        Me.btAnular = New System.Windows.Forms.Button
        Me.btPagar = New System.Windows.Forms.Button
        Me.cbServicio = New System.Windows.Forms.CheckBox
        Me.cbIVA = New System.Windows.Forms.CheckBox
        Me.tbTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbServicio = New System.Windows.Forms.TextBox
        Me.tbIVA = New System.Windows.Forms.TextBox
        Me.tbSubTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btCancelarRestaurant = New System.Windows.Forms.Button
        Me.btCancelarBar = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.gbSelProds = New System.Windows.Forms.GroupBox
        Me.btAgregar = New System.Windows.Forms.Button
        Me.lbCantidad = New System.Windows.Forms.ListBox
        Me.dgvSubTipo = New System.Windows.Forms.DataGridView
        Me.dgvTipo = New System.Windows.Forms.DataGridView
        Me.dgvClase = New System.Windows.Forms.DataGridView
        Me.dgvProductos = New System.Windows.Forms.DataGridView
        Me.gbConsumo = New System.Windows.Forms.GroupBox
        Me.dgvConsumo = New System.Windows.Forms.DataGridView
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubTipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripcionDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescsubtipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btSalir = New System.Windows.Forms.Button
        Me.btNuevoBar = New System.Windows.Forms.Button
        Me.gbFormaPago = New System.Windows.Forms.GroupBox
        Me.dgvDetallePago2 = New System.Windows.Forms.DataGridView
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EliminarConsumoMesa = New System.Windows.Forms.DataGridViewButtonColumn
        Me.tbAbono = New System.Windows.Forms.TextBox
        Me.cbFormaPago = New System.Windows.Forms.ComboBox
        Me.tbSaldo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvDetallePago = New System.Windows.Forms.DataGridView
        Me.cod_tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EliminarPago = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.gbPagar.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbSelProds.SuspendLayout()
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbConsumo.SuspendLayout()
        CType(Me.dgvConsumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFormaPago.SuspendLayout()
        CType(Me.dgvDetallePago2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbPagar
        '
        Me.gbPagar.Controls.Add(Me.btCerrarCuenta)
        Me.gbPagar.Controls.Add(Me.btTicket)
        Me.gbPagar.Controls.Add(Me.btAnular)
        Me.gbPagar.Controls.Add(Me.btPagar)
        Me.gbPagar.Controls.Add(Me.cbServicio)
        Me.gbPagar.Controls.Add(Me.cbIVA)
        Me.gbPagar.Controls.Add(Me.tbTotal)
        Me.gbPagar.Controls.Add(Me.Label4)
        Me.gbPagar.Controls.Add(Me.tbServicio)
        Me.gbPagar.Controls.Add(Me.tbIVA)
        Me.gbPagar.Controls.Add(Me.tbSubTotal)
        Me.gbPagar.Controls.Add(Me.Label1)
        Me.gbPagar.Enabled = False
        Me.gbPagar.Location = New System.Drawing.Point(600, 329)
        Me.gbPagar.Name = "gbPagar"
        Me.gbPagar.Size = New System.Drawing.Size(396, 179)
        Me.gbPagar.TabIndex = 8
        Me.gbPagar.TabStop = False
        Me.gbPagar.Text = "Total a Pagar"
        '
        'btCerrarCuenta
        '
        Me.btCerrarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarCuenta.Location = New System.Drawing.Point(271, 32)
        Me.btCerrarCuenta.Name = "btCerrarCuenta"
        Me.btCerrarCuenta.Size = New System.Drawing.Size(109, 81)
        Me.btCerrarCuenta.TabIndex = 23
        Me.btCerrarCuenta.Text = "CERRAR CUENTA"
        Me.btCerrarCuenta.UseVisualStyleBackColor = True
        Me.btCerrarCuenta.Visible = False
        '
        'btTicket
        '
        Me.btTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btTicket.Location = New System.Drawing.Point(10, 137)
        Me.btTicket.Name = "btTicket"
        Me.btTicket.Size = New System.Drawing.Size(82, 26)
        Me.btTicket.TabIndex = 22
        Me.btTicket.Text = "TICKET"
        Me.btTicket.UseVisualStyleBackColor = True
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.Location = New System.Drawing.Point(195, 138)
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(60, 26)
        Me.btAnular.TabIndex = 21
        Me.btAnular.Text = "ANULAR"
        Me.btAnular.UseVisualStyleBackColor = True
        '
        'btPagar
        '
        Me.btPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.Location = New System.Drawing.Point(99, 127)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(87, 46)
        Me.btPagar.TabIndex = 20
        Me.btPagar.Text = "PAGAR"
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'cbServicio
        '
        Me.cbServicio.AutoSize = True
        Me.cbServicio.Checked = True
        Me.cbServicio.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServicio.Location = New System.Drawing.Point(9, 74)
        Me.cbServicio.Name = "cbServicio"
        Me.cbServicio.Size = New System.Drawing.Size(136, 28)
        Me.cbServicio.TabIndex = 19
        Me.cbServicio.Text = "Servicio 10%"
        Me.cbServicio.UseVisualStyleBackColor = True
        '
        'cbIVA
        '
        Me.cbIVA.AutoSize = True
        Me.cbIVA.Checked = True
        Me.cbIVA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIVA.Location = New System.Drawing.Point(9, 49)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(99, 28)
        Me.cbIVA.TabIndex = 18
        Me.cbIVA.Text = "IVA 12%"
        Me.cbIVA.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.BackColor = System.Drawing.Color.Black
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.ForeColor = System.Drawing.Color.White
        Me.tbTotal.Location = New System.Drawing.Point(153, 97)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTotal.Size = New System.Drawing.Size(102, 29)
        Me.tbTotal.TabIndex = 17
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total"
        '
        'tbServicio
        '
        Me.tbServicio.BackColor = System.Drawing.Color.Black
        Me.tbServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServicio.ForeColor = System.Drawing.Color.White
        Me.tbServicio.Location = New System.Drawing.Point(153, 71)
        Me.tbServicio.Name = "tbServicio"
        Me.tbServicio.ReadOnly = True
        Me.tbServicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbServicio.Size = New System.Drawing.Size(102, 29)
        Me.tbServicio.TabIndex = 15
        Me.tbServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbIVA
        '
        Me.tbIVA.BackColor = System.Drawing.Color.Black
        Me.tbIVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIVA.ForeColor = System.Drawing.Color.White
        Me.tbIVA.Location = New System.Drawing.Point(153, 45)
        Me.tbIVA.Name = "tbIVA"
        Me.tbIVA.ReadOnly = True
        Me.tbIVA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbIVA.Size = New System.Drawing.Size(102, 29)
        Me.tbIVA.TabIndex = 13
        Me.tbIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbSubTotal
        '
        Me.tbSubTotal.BackColor = System.Drawing.Color.Black
        Me.tbSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSubTotal.ForeColor = System.Drawing.Color.White
        Me.tbSubTotal.Location = New System.Drawing.Point(153, 19)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.ReadOnly = True
        Me.tbSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSubTotal.Size = New System.Drawing.Size(102, 29)
        Me.tbSubTotal.TabIndex = 11
        Me.tbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "SubTotal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btCancelarRestaurant)
        Me.GroupBox2.Controls.Add(Me.btCancelarBar)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(452, 60)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'btCancelarRestaurant
        '
        Me.btCancelarRestaurant.Enabled = False
        Me.btCancelarRestaurant.Location = New System.Drawing.Point(371, 34)
        Me.btCancelarRestaurant.Name = "btCancelarRestaurant"
        Me.btCancelarRestaurant.Size = New System.Drawing.Size(75, 20)
        Me.btCancelarRestaurant.TabIndex = 17
        Me.btCancelarRestaurant.Text = "Cancelar"
        Me.btCancelarRestaurant.UseVisualStyleBackColor = True
        '
        'btCancelarBar
        '
        Me.btCancelarBar.Enabled = False
        Me.btCancelarBar.Location = New System.Drawing.Point(371, 14)
        Me.btCancelarBar.Name = "btCancelarBar"
        Me.btCancelarBar.Size = New System.Drawing.Size(75, 20)
        Me.btCancelarBar.TabIndex = 16
        Me.btCancelarBar.Text = "Cancelar"
        Me.btCancelarBar.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Black
        Me.TextBox5.Enabled = False
        Me.TextBox5.ForeColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(191, 15)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(174, 20)
        Me.TextBox5.TabIndex = 15
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.Black
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.ForeColor = System.Drawing.Color.White
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(244, 35)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 14
        Me.ComboBox3.ValueMember = "codigo"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.Black
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.ForeColor = System.Drawing.Color.White
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(117, 35)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 13
        Me.ComboBox2.ValueMember = "codigo"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(117, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(68, 21)
        Me.ComboBox1.TabIndex = 12
        Me.ComboBox1.ValueMember = "nombre"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 36)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(99, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RESTAURANT"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 16)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "BAR"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'gbSelProds
        '
        Me.gbSelProds.Controls.Add(Me.btAgregar)
        Me.gbSelProds.Controls.Add(Me.lbCantidad)
        Me.gbSelProds.Controls.Add(Me.dgvSubTipo)
        Me.gbSelProds.Controls.Add(Me.dgvTipo)
        Me.gbSelProds.Controls.Add(Me.dgvClase)
        Me.gbSelProds.Controls.Add(Me.dgvProductos)
        Me.gbSelProds.Enabled = False
        Me.gbSelProds.Location = New System.Drawing.Point(12, 64)
        Me.gbSelProds.Name = "gbSelProds"
        Me.gbSelProds.Size = New System.Drawing.Size(984, 265)
        Me.gbSelProds.TabIndex = 11
        Me.gbSelProds.TabStop = False
        Me.gbSelProds.Text = "Seleccion de Producto"
        '
        'btAgregar
        '
        Me.btAgregar.Enabled = False
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(946, 15)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(33, 244)
        Me.btAgregar.TabIndex = 12
        Me.btAgregar.Text = "AGREGAR"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lbCantidad
        '
        Me.lbCantidad.BackColor = System.Drawing.Color.Black
        Me.lbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCantidad.ForeColor = System.Drawing.Color.White
        Me.lbCantidad.FormattingEnabled = True
        Me.lbCantidad.ItemHeight = 24
        Me.lbCantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.lbCantidad.Location = New System.Drawing.Point(910, 15)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(30, 244)
        Me.lbCantidad.TabIndex = 11
        '
        'dgvSubTipo
        '
        Me.dgvSubTipo.AllowUserToAddRows = False
        Me.dgvSubTipo.AllowUserToDeleteRows = False
        Me.dgvSubTipo.AllowUserToResizeColumns = False
        Me.dgvSubTipo.AllowUserToResizeRows = False
        Me.dgvSubTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubTipo.Location = New System.Drawing.Point(734, 15)
        Me.dgvSubTipo.Name = "dgvSubTipo"
        Me.dgvSubTipo.ReadOnly = True
        Me.dgvSubTipo.RowHeadersVisible = False
        Me.dgvSubTipo.Size = New System.Drawing.Size(170, 244)
        Me.dgvSubTipo.TabIndex = 10
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.AllowUserToResizeColumns = False
        Me.dgvTipo.AllowUserToResizeRows = False
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipo.Location = New System.Drawing.Point(458, 15)
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.RowHeadersVisible = False
        Me.dgvTipo.Size = New System.Drawing.Size(270, 244)
        Me.dgvTipo.TabIndex = 9
        '
        'dgvClase
        '
        Me.dgvClase.AllowUserToAddRows = False
        Me.dgvClase.AllowUserToDeleteRows = False
        Me.dgvClase.AllowUserToResizeColumns = False
        Me.dgvClase.AllowUserToResizeRows = False
        Me.dgvClase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClase.Location = New System.Drawing.Point(182, 15)
        Me.dgvClase.Name = "dgvClase"
        Me.dgvClase.ReadOnly = True
        Me.dgvClase.RowHeadersVisible = False
        Me.dgvClase.Size = New System.Drawing.Size(270, 244)
        Me.dgvClase.TabIndex = 8
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeColumns = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(6, 15)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        Me.dgvProductos.Size = New System.Drawing.Size(170, 244)
        Me.dgvProductos.TabIndex = 7
        '
        'gbConsumo
        '
        Me.gbConsumo.Controls.Add(Me.dgvConsumo)
        Me.gbConsumo.Enabled = False
        Me.gbConsumo.Location = New System.Drawing.Point(12, 329)
        Me.gbConsumo.Name = "gbConsumo"
        Me.gbConsumo.Size = New System.Drawing.Size(582, 391)
        Me.gbConsumo.TabIndex = 12
        Me.gbConsumo.TabStop = False
        Me.gbConsumo.Text = "Consumo"
        '
        'dgvConsumo
        '
        Me.dgvConsumo.AllowUserToAddRows = False
        Me.dgvConsumo.AllowUserToDeleteRows = False
        Me.dgvConsumo.AllowUserToResizeColumns = False
        Me.dgvConsumo.AllowUserToResizeRows = False
        Me.dgvConsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.SubTipo, Me.Tipo, Me.PrecioUnitario, Me.Total, Me.Eliminar})
        Me.dgvConsumo.Location = New System.Drawing.Point(6, 15)
        Me.dgvConsumo.Name = "dgvConsumo"
        Me.dgvConsumo.ReadOnly = True
        Me.dgvConsumo.RowHeadersVisible = False
        Me.dgvConsumo.Size = New System.Drawing.Size(569, 370)
        Me.dgvConsumo.TabIndex = 8
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cantidad.Width = 50
        '
        'SubTipo
        '
        Me.SubTipo.DataPropertyName = "descsubtipo"
        Me.SubTipo.HeaderText = "Descripcion"
        Me.SubTipo.Name = "SubTipo"
        Me.SubTipo.ReadOnly = True
        Me.SubTipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "descripcion"
        Me.Tipo.HeaderText = "Producto"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        Me.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Tipo.Width = 250
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "pvp"
        Me.PrecioUnitario.HeaderText = "Precio Unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        Me.PrecioUnitario.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PrecioUnitario.Width = 50
        '
        'Total
        '
        Me.Total.DataPropertyName = "total"
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Total.Width = 50
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Eliminar.Text = "ELIMINAR"
        Me.Eliminar.Width = 50
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'DescripcionDataGridViewTextBoxColumn4
        '
        Me.DescripcionDataGridViewTextBoxColumn4.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn4.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn4.Name = "DescripcionDataGridViewTextBoxColumn4"
        '
        'DescsubtipoDataGridViewTextBoxColumn
        '
        Me.DescsubtipoDataGridViewTextBoxColumn.DataPropertyName = "descsubtipo"
        Me.DescsubtipoDataGridViewTextBoxColumn.HeaderText = "descsubtipo"
        Me.DescsubtipoDataGridViewTextBoxColumn.Name = "DescsubtipoDataGridViewTextBoxColumn"
        '
        'CostoDataGridViewTextBoxColumn
        '
        Me.CostoDataGridViewTextBoxColumn.DataPropertyName = "costo"
        Me.CostoDataGridViewTextBoxColumn.HeaderText = "costo"
        Me.CostoDataGridViewTextBoxColumn.Name = "CostoDataGridViewTextBoxColumn"
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(871, 7)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(125, 51)
        Me.btSalir.TabIndex = 23
        Me.btSalir.Text = "SALIR"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btNuevoBar
        '
        Me.btNuevoBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevoBar.Location = New System.Drawing.Point(479, 15)
        Me.btNuevoBar.Name = "btNuevoBar"
        Me.btNuevoBar.Size = New System.Drawing.Size(141, 23)
        Me.btNuevoBar.TabIndex = 24
        Me.btNuevoBar.Text = "Nueva Tarjeta"
        Me.btNuevoBar.UseVisualStyleBackColor = True
        '
        'gbFormaPago
        '
        Me.gbFormaPago.Controls.Add(Me.dgvDetallePago2)
        Me.gbFormaPago.Controls.Add(Me.tbAbono)
        Me.gbFormaPago.Controls.Add(Me.cbFormaPago)
        Me.gbFormaPago.Controls.Add(Me.tbSaldo)
        Me.gbFormaPago.Controls.Add(Me.Label2)
        Me.gbFormaPago.Controls.Add(Me.dgvDetallePago)
        Me.gbFormaPago.Enabled = False
        Me.gbFormaPago.Location = New System.Drawing.Point(600, 508)
        Me.gbFormaPago.Name = "gbFormaPago"
        Me.gbFormaPago.Size = New System.Drawing.Size(396, 212)
        Me.gbFormaPago.TabIndex = 25
        Me.gbFormaPago.TabStop = False
        Me.gbFormaPago.Text = "Forma de Pago"
        Me.gbFormaPago.Visible = False
        '
        'dgvDetallePago2
        '
        Me.dgvDetallePago2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePago2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.descripcion, Me.EliminarConsumoMesa})
        Me.dgvDetallePago2.Location = New System.Drawing.Point(6, 47)
        Me.dgvDetallePago2.Name = "dgvDetallePago2"
        Me.dgvDetallePago2.RowHeadersVisible = False
        Me.dgvDetallePago2.Size = New System.Drawing.Size(385, 159)
        Me.dgvDetallePago2.TabIndex = 22
        Me.dgvDetallePago2.Visible = False
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Tipo de Pago"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Width = 200
        '
        'EliminarConsumoMesa
        '
        Me.EliminarConsumoMesa.HeaderText = "Eliminar"
        Me.EliminarConsumoMesa.Name = "EliminarConsumoMesa"
        Me.EliminarConsumoMesa.Width = 80
        '
        'tbAbono
        '
        Me.tbAbono.BackColor = System.Drawing.Color.Black
        Me.tbAbono.Enabled = False
        Me.tbAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAbono.ForeColor = System.Drawing.Color.White
        Me.tbAbono.Location = New System.Drawing.Point(146, 14)
        Me.tbAbono.Name = "tbAbono"
        Me.tbAbono.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbAbono.Size = New System.Drawing.Size(76, 29)
        Me.tbAbono.TabIndex = 21
        Me.tbAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbFormaPago
        '
        Me.cbFormaPago.BackColor = System.Drawing.Color.Black
        Me.cbFormaPago.Enabled = False
        Me.cbFormaPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.ForeColor = System.Drawing.Color.White
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(9, 14)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(136, 28)
        Me.cbFormaPago.TabIndex = 20
        Me.cbFormaPago.ValueMember = "codigo"
        '
        'tbSaldo
        '
        Me.tbSaldo.BackColor = System.Drawing.Color.Black
        Me.tbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldo.ForeColor = System.Drawing.Color.White
        Me.tbSaldo.Location = New System.Drawing.Point(289, 14)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.ReadOnly = True
        Me.tbSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbSaldo.Size = New System.Drawing.Size(102, 29)
        Me.tbSaldo.TabIndex = 19
        Me.tbSaldo.Text = "0"
        Me.tbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Saldo:"
        '
        'dgvDetallePago
        '
        Me.dgvDetallePago.AllowUserToAddRows = False
        Me.dgvDetallePago.AllowUserToDeleteRows = False
        Me.dgvDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallePago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_tarjeta, Me.TipoPago, Me.Valor, Me.EliminarPago})
        Me.dgvDetallePago.Location = New System.Drawing.Point(6, 47)
        Me.dgvDetallePago.Name = "dgvDetallePago"
        Me.dgvDetallePago.ReadOnly = True
        Me.dgvDetallePago.RowHeadersVisible = False
        Me.dgvDetallePago.Size = New System.Drawing.Size(384, 159)
        Me.dgvDetallePago.TabIndex = 0
        Me.dgvDetallePago.Visible = False
        '
        'cod_tarjeta
        '
        Me.cod_tarjeta.DataPropertyName = "cod_tarjeta"
        Me.cod_tarjeta.HeaderText = "Tarjeta"
        Me.cod_tarjeta.Name = "cod_tarjeta"
        Me.cod_tarjeta.ReadOnly = True
        Me.cod_tarjeta.Visible = False
        '
        'TipoPago
        '
        Me.TipoPago.DataPropertyName = "descripcion"
        Me.TipoPago.HeaderText = "Tipo de Pago"
        Me.TipoPago.Name = "TipoPago"
        Me.TipoPago.ReadOnly = True
        Me.TipoPago.Width = 200
        '
        'Valor
        '
        Me.Valor.DataPropertyName = "valor"
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Width = 80
        '
        'EliminarPago
        '
        Me.EliminarPago.HeaderText = "Eliminar"
        Me.EliminarPago.Name = "EliminarPago"
        Me.EliminarPago.ReadOnly = True
        Me.EliminarPago.Width = 80
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(659, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 55)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "RECARGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1018, 732)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbFormaPago)
        Me.Controls.Add(Me.btNuevoBar)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.gbConsumo)
        Me.Controls.Add(Me.gbSelProds)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 738)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GoTech - BarDisco"
        Me.gbPagar.ResumeLayout(False)
        Me.gbPagar.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbSelProds.ResumeLayout(False)
        CType(Me.dgvSubTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbConsumo.ResumeLayout(False)
        CType(Me.dgvConsumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFormaPago.ResumeLayout(False)
        Me.gbFormaPago.PerformLayout()
        CType(Me.dgvDetallePago2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If Me.RadioButton1.Checked = True Then
            Me.ComboBox1.Enabled = True
            Me.TextBox5.Enabled = True
            Me.ComboBox2.Enabled = False
            Me.ComboBox3.Enabled = False
            Me.TARJETATableAdapter.Fill(Me.BarDisco2DataSet5.TARJETA)
            Me.RadioButton1.Enabled = False
            Me.RadioButton2.Enabled = False
            Me.btCancelarBar.Enabled = True
            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox1.Focus()
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If Me.RadioButton2.Checked = True Then
            Me.ComboBox2.Enabled = True
            Me.ComboBox3.Enabled = True
            Me.ComboBox1.Enabled = False
            Me.TextBox5.Enabled = False
            Me.MESEROTableAdapter.Fill(Me.BarDisco2DataSet4.MESERO)
            Me.MESATableAdapter.Fill(Me.BarDisco2DataSet3.MESA)
            Me.RadioButton1.Enabled = False
            Me.RadioButton2.Enabled = False
            Me.btCancelarRestaurant.Enabled = True
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.SelectedValue <> Nothing Then
            Me.TextBox5.Text = Me.ComboBox1.SelectedValue.ToString
            codCliente = CType(Me.ComboBox1.Text.ToString, Integer)
            Me.gbConsumo.Enabled = True
            Me.gbPagar.Enabled = True
            Me.gbSelProds.Enabled = True
            Me.CONSUMOTableAdapter.Fill(Me.BarDisco2DataSet6.CONSUMO)
            Me.GRUPOSTableAdapter.Fill(Me.DsGrupos.GRUPOS)
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If Me.ComboBox2.SelectedValue <> Nothing Then
            codMesa = Me.ComboBox2.SelectedValue
            codMesero = Me.ComboBox3.SelectedValue
            Me.CONSUMOTableAdapter.Fill(Me.BarDisco2DataSet6.CONSUMO)
            Me.ComboBox3.Focus()
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If Me.ComboBox3.SelectedValue <> Nothing Then
            codMesero = Me.ComboBox3.SelectedValue
            Me.gbConsumo.Enabled = True
            Me.gbPagar.Enabled = True
            Me.gbSelProds.Enabled = True
            Me.GRUPOSTableAdapter.Fill(Me.DsGrupos.GRUPOS)
        End If
    End Sub

    Private Sub dgvProductos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProductos.CellClick
        codGrupo = dgvProductos.Rows(e.RowIndex).Cells(0).Value
        ' Me.BarDisco2DataSet.CLASE.Clear()
        Me.CLASETableAdapter.Fill(Me.BarDisco2DataSet.CLASE)
        Me.dgvClase.Focus()
    End Sub

    Private Sub dgvClase_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvClase.CellClick
        codClase = dgvClase.Rows(e.RowIndex).Cells(0).Value
        Me.TIPOTableAdapter.Fill(Me.BarDisco2DataSet1.TIPO)
        Me.dgvTipo.Focus()
    End Sub

    Private Sub dgvTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvTipo.CellClick
        codTipo = dgvTipo.Rows(e.RowIndex).Cells(0).Value
        Me.SUB_TIPOTableAdapter.Fill(Me.BarDisco2DataSet2._SUB_TIPO)
        Me.dgvSubTipo.Focus()
    End Sub

    Private Sub dgvSubTipo_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSubTipo.CellClick
        codSubTipo = dgvSubTipo.Rows(e.RowIndex).Cells(0).Value
        Me.lbCantidad.Focus()
    End Sub

    Private Sub lbCantidad_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCantidad.SelectedIndexChanged
        cantidadProd = CType(Me.lbCantidad.SelectedItem, Integer)
        Me.btAgregar.Enabled = True
    End Sub

    Private Sub btSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btCancelarBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarBar.Click
        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.ComboBox1.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox5.Clear()
        Me.ComboBox1.Text = ""
        Me.btCancelarBar.Enabled = False
        Me.BarDisco2DataSet6.CONSUMO.Clear()

        codCliente = Nothing
    End Sub

    Private Sub btCancelarRestaurant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarRestaurant.Click
        Me.RadioButton1.Enabled = True
        Me.RadioButton2.Enabled = True
        Me.ComboBox2.Enabled = False
        Me.ComboBox3.Enabled = False
        Me.ComboBox2.Text = ""
        Me.ComboBox3.Text = ""
        Me.btCancelarRestaurant.Enabled = False
        Me.BarDisco2DataSet6.CONSUMO.Clear()

        codMesa = Nothing
        codMesero = Nothing
    End Sub

    Private Sub tbSubTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbSubTotal.TextChanged
        If Me.tbSubTotal.Text <> "$ 0,00" Then
            If Me.cbIVA.Checked = True Then
                Me.tbIVA.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.12, "$ #,##0.00")
            Else
                Me.tbIVA.Text = 0
            End If
            If Me.cbServicio.Checked = True Then
                Me.tbServicio.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.1, "$ #,##0.00")
            Else
                Me.tbServicio.Text = 0
            End If
            Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double), "$ #,##0.00")
            CalculaSaldo()
        Else
            Me.tbIVA.Text = ""
            Me.tbServicio.Text = ""
            Me.tbTotal.Text = ""
        End If
    End Sub

    Private Sub cbIVA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIVA.CheckedChanged
        If Me.tbSubTotal.Text <> "" Then
            If Me.cbIVA.Checked = True Then
                Me.tbIVA.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.12, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            Else
                Me.tbIVA.Text = Format(0, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            End If
        End If
    End Sub

    Private Sub cbServicio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbServicio.CheckedChanged
        If Me.tbSubTotal.Text <> "" Then
            If Me.cbServicio.Checked = True Then
                Me.tbServicio.Text = Format(CType(Me.tbSubTotal.Text, Double) * 0.1, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            Else
                Me.tbServicio.Text = Format(0, "$ #,##0.00")
                Me.tbTotal.Text = Format(CType(Me.tbSubTotal.Text, Double) + CType(Me.tbIVA.Text, Double) + CType(Me.tbServicio.Text, Double), "$ #,##0.00")
                CalculaSaldo()
            End If
        End If
    End Sub

    Private Sub btNuevoBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btNuevoBar.Click
        NuevoCliente.Show()
        Me.Close()
    End Sub

    Private Sub btPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPagar.Click
        Me.gbFormaPago.Enabled = True
        Me.gbFormaPago.Visible = True
        Me.FORMA_PAGOTableAdapter.Fill(Me.DsFormaPago._FORMA_PAGO)
        If codCliente <> Nothing Then
            Me.DETALLE_PAGOTableAdapter.Fill(Me.DsDetallePago._DETALLE_PAGO)
            Me.dgvDetallePago.Visible = True
        ElseIf codMesa <> Nothing Then
            Me.DETALLE_PAGO2TableAdapter.Fill(Me.DsDetallePago2._DETALLE_PAGO2)
            Me.dgvDetallePago2.Visible = True
        End If

        CalculaSaldo()
        Me.cbFormaPago.Focus()
    End Sub

    Private Sub CalculaSaldo()
        abonado = Nothing
        If codCliente <> Nothing Then
            For Each row As DataGridViewRow In Me.dgvDetallePago.Rows
                abonado += Val(row.Cells(2).Value)
            Next
        ElseIf codMesa <> Nothing Then
            For Each row As DataGridViewRow In Me.dgvDetallePago2.Rows
                abonado += Val(row.Cells(1).Value)
            Next
        End If
        saldo = CType(Me.tbTotal.Text, Double) - abonado
        Me.tbSaldo.Text = Format(saldo, "$ #,##0.00")
        If CType(Me.tbSaldo.Text, Double) > 0 Then
            Me.cbFormaPago.Enabled = True
            Me.tbAbono.Enabled = True
        ElseIf CType(Me.tbSaldo.Text, Double) < 0 Then
            Me.cbFormaPago.Enabled = False
            Me.tbAbono.Enabled = False
            Dim zz As New C_baradmin
            MessageBox.Show("El vuelto es: " & Me.tbSaldo.Text)
            codFormaPago = 8
            abono = CType(Me.tbSaldo.Text, Double)
            zz.add_abono()
            Me.tbSaldo.Text = "$ 0.00"
            If codCliente <> Nothing Then
                Me.DETALLE_PAGOTableAdapter.Fill(Me.DsDetallePago._DETALLE_PAGO)
            ElseIf codMesa <> Nothing Then
            End If

        Else
            Me.cbFormaPago.Enabled = False
            Me.tbAbono.Enabled = False
            MessageBox.Show("Cuenta al dia")
            Me.btCerrarCuenta.Visible = True
        End If
        If CType(Me.tbSaldo.Text, Double) = 0 Then
            Me.cbFormaPago.Enabled = False
            Me.tbAbono.Enabled = False
            MessageBox.Show("Cuenta al dia")
            Me.btCerrarCuenta.Visible = True
        End If
    End Sub

    Private Sub dgvConsumo_DataBindingComplete(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles dgvConsumo.DataBindingComplete
        Dim Total As Double
        For Each row As DataGridViewRow In Me.dgvConsumo.Rows
            Total += Val(row.Cells(4).Value)
        Next
        Me.tbSubTotal.Text = Format(Total, "$ #,##0.00")
    End Sub

    Private Sub btTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTicket.Click
        Reportes.Show()
    End Sub

    Private Sub btAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregar.Click
        Dim cc As New C_baradmin
        If Me.RadioButton1.Checked = True Then
            cc.add_consumo()
        ElseIf Me.RadioButton2.Checked = True Then
            cc.add_mesa()
        End If
        Me.CONSUMOTableAdapter.Fill(Me.BarDisco2DataSet6.CONSUMO)
    End Sub

    Private Sub tbAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAbono.KeyPress
        Dim xx As New C_baradmin
        abono = Nothing
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
            If e.KeyChar = Convert.ToChar(Keys.Return) And Me.cbFormaPago.SelectedValue <> Nothing Then
                abono = CType(Me.tbAbono.Text, Double)
                codFormaPago = Me.cbFormaPago.SelectedValue
                xx.add_abono()
                If codCliente <> Nothing Then
                    Me.DETALLE_PAGOTableAdapter.Fill(Me.DsDetallePago._DETALLE_PAGO)
                ElseIf codMesa <> Nothing Then
                    Me.DETALLE_PAGO2TableAdapter.Fill(Me.DsDetallePago2._DETALLE_PAGO2)
                End If
                CalculaSaldo()
                Me.tbAbono.Text = ""
                Me.cbFormaPago.Focus()
            End If
        End If

    End Sub

    Private Sub tbTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTotal.TextChanged
        'CalculaSaldo()
    End Sub


    Private Sub btCerrarCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCerrarCuenta.Click
        Dim cc As New C_baradmin
        cc.cerrar_cuenta()

        Recarga.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Recarga.Show()
        Me.Close()
    End Sub
End Class

