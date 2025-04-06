namespace RaceX
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbClima = new System.Windows.Forms.ComboBox();
            this.lblClima = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dataGridResultados = new System.Windows.Forms.DataGridView();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del Auto: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 92);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(74, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Auto: ";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Deportivo",
            "Todo Terreno",
            "Hibrido"});
            this.cmbTipo.Location = new System.Drawing.Point(158, 84);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(109, 21);
            this.cmbTipo.TabIndex = 3;
            // 
            // cmbClima
            // 
            this.cmbClima.FormattingEnabled = true;
            this.cmbClima.Items.AddRange(new object[] {
            "Soleado",
            "Lluvioso",
            "Ventoso"});
            this.cmbClima.Location = new System.Drawing.Point(158, 130);
            this.cmbClima.Name = "cmbClima";
            this.cmbClima.Size = new System.Drawing.Size(109, 21);
            this.cmbClima.TabIndex = 5;
            // 
            // lblClima
            // 
            this.lblClima.AutoSize = true;
            this.lblClima.Location = new System.Drawing.Point(12, 138);
            this.lblClima.Name = "lblClima";
            this.lblClima.Size = new System.Drawing.Size(38, 13);
            this.lblClima.TabIndex = 6;
            this.lblClima.Text = "Clima: ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 187);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(107, 45);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Auto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(128, 187);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(107, 45);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar Carrera";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnTurno
            // 
            this.btnTurno.Location = new System.Drawing.Point(241, 187);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(107, 45);
            this.btnTurno.TabIndex = 9;
            this.btnTurno.Text = "Siguiente turno";
            this.btnTurno.UseVisualStyleBackColor = true;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(89, 247);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(202, 39);
            this.btnReiniciar.TabIndex = 10;
            this.btnReiniciar.Text = "Reiniciar Carrera";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // dataGridResultados
            // 
            this.dataGridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colTipo,
            this.colDistancia});
            this.dataGridResultados.Location = new System.Drawing.Point(431, 73);
            this.dataGridResultados.Name = "dataGridResultados";
            this.dataGridResultados.Size = new System.Drawing.Size(308, 187);
            this.dataGridResultados.TabIndex = 11;
            this.dataGridResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResultados_CellContentClick);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(89, 338);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(150, 27);
            this.txtLog.TabIndex = 12;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            // 
            // colDistancia
            // 
            this.colDistancia.HeaderText = "Distancia Recorrida";
            this.colDistancia.Name = "colDistancia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.dataGridResultados);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnTurno);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblClima);
            this.Controls.Add(this.cmbClima);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbClima;
        private System.Windows.Forms.Label lblClima;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dataGridResultados;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistancia;
    }
}

