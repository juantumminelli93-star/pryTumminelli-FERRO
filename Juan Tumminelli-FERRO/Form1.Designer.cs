namespace Juan_Tumminelli_FERRO
{
    partial class AirLux
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cboDeProvincias;
        private System.Windows.Forms.ComboBox cboFromAero;
        private System.Windows.Forms.Label lblvoy;
        private System.Windows.Forms.ComboBox cboDeProvincias2;
        private System.Windows.Forms.ComboBox cbofromAero2;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblsalida;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.NumericUpDown nudPersons;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblmoneda;
        private System.Windows.Forms.ComboBox cbomoneda;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox grpDescuent;
        private System.Windows.Forms.Label lblPromocionText;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPay;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirLux));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cboDeProvincias = new System.Windows.Forms.ComboBox();
            this.cboFromAero = new System.Windows.Forms.ComboBox();
            this.lblvoy = new System.Windows.Forms.Label();
            this.cboDeProvincias2 = new System.Windows.Forms.ComboBox();
            this.cbofromAero2 = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblsalida = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.nudPersons = new System.Windows.Forms.NumericUpDown();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblmoneda = new System.Windows.Forms.Label();
            this.cbomoneda = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpDescuent = new System.Windows.Forms.GroupBox();
            this.lblPromocionText = new System.Windows.Forms.Label();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).BeginInit();
            this.grpDescuent.SuspendLayout();
            this.grpPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(12, 9);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(58, 20);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Viajes";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(6, 40);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(153, 13);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = " (distancia de kilómetros):";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(15, 56);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(144, 20);
            this.txtDistancia.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(190, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(61, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "Salgo de:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // cboDeProvincias
            // 
            this.cboDeProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeProvincias.Items.AddRange(new object[] {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego"});
            this.cboDeProvincias.Location = new System.Drawing.Point(182, 56);
            this.cboDeProvincias.Name = "cboDeProvincias";
            this.cboDeProvincias.Size = new System.Drawing.Size(128, 21);
            this.cboDeProvincias.TabIndex = 5;
            this.cboDeProvincias.SelectedIndexChanged += new System.EventHandler(this.CboFromProvince_SelectedIndexChanged);
            // 
            // cboFromAero
            // 
            this.cboFromAero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromAero.Location = new System.Drawing.Point(330, 56);
            this.cboFromAero.Name = "cboFromAero";
            this.cboFromAero.Size = new System.Drawing.Size(170, 21);
            this.cboFromAero.TabIndex = 6;
            // 
            // lblvoy
            // 
            this.lblvoy.AutoSize = true;
            this.lblvoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoy.Location = new System.Drawing.Point(13, 140);
            this.lblvoy.Name = "lblvoy";
            this.lblvoy.Size = new System.Drawing.Size(43, 13);
            this.lblvoy.TabIndex = 14;
            this.lblvoy.Text = "Voy a:";
            // 
            // cboDeProvincias2
            // 
            this.cboDeProvincias2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeProvincias2.Items.AddRange(new object[] {
            "Buenos Aires",
            "Catamarca",
            "Chaco",
            "Chubut",
            "Córdoba",
            "Corrientes",
            "Entre Ríos",
            "Formosa",
            "Jujuy",
            "La Pampa",
            "La Rioja",
            "Mendoza",
            "Misiones",
            "Neuquén",
            "Río Negro",
            "Salta",
            "San Juan",
            "San Luis",
            "Santa Cruz",
            "Santa Fe",
            "Santiago del Estero",
            "Tierra del Fuego"});
            this.cboDeProvincias2.Location = new System.Drawing.Point(16, 156);
            this.cboDeProvincias2.Name = "cboDeProvincias2";
            this.cboDeProvincias2.Size = new System.Drawing.Size(143, 21);
            this.cboDeProvincias2.TabIndex = 15;
            this.cboDeProvincias2.SelectedIndexChanged += new System.EventHandler(this.CboToProvince_SelectedIndexChanged);
            // 
            // cbofromAero2
            // 
            this.cbofromAero2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbofromAero2.Location = new System.Drawing.Point(182, 156);
            this.cbofromAero2.Name = "cbofromAero2";
            this.cbofromAero2.Size = new System.Drawing.Size(128, 21);
            this.cbofromAero2.TabIndex = 16;
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(0, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(100, 23);
            this.lblDays.TabIndex = 0;
            // 
            // lblsalida
            // 
            this.lblsalida.AutoSize = true;
            this.lblsalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalida.Location = new System.Drawing.Point(13, 87);
            this.lblsalida.Name = "lblsalida";
            this.lblsalida.Size = new System.Drawing.Size(48, 15);
            this.lblsalida.TabIndex = 8;
            this.lblsalida.Text = "Salida";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalida.Location = new System.Drawing.Point(16, 103);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(143, 20);
            this.dtpSalida.TabIndex = 9;
            this.dtpSalida.Value = new System.DateTime(2026, 5, 5, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.Location = new System.Drawing.Point(187, 86);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(54, 13);
            this.lblReturn.TabIndex = 10;
            this.lblReturn.Text = "Regreso";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(182, 102);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(128, 20);
            this.dtpReturn.TabIndex = 11;
            this.dtpReturn.Value = new System.DateTime(2026, 5, 6, 0, 0, 0, 0);
            this.dtpReturn.ValueChanged += new System.EventHandler(this.dtpReturn_ValueChanged);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(324, 86);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(63, 13);
            this.lblPersonas.TabIndex = 12;
            this.lblPersonas.Text = "Personas:";
            // 
            // nudPersons
            // 
            this.nudPersons.Location = new System.Drawing.Point(330, 102);
            this.nudPersons.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPersons.Name = "nudPersons";
            this.nudPersons.Size = new System.Drawing.Size(50, 20);
            this.nudPersons.TabIndex = 13;
            this.nudPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(393, 86);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(42, 13);
            this.lblClass.TabIndex = 14;
            this.lblClass.Text = "Clase:";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.Items.AddRange(new object[] {
            "Todas",
            "Económica",
            "Ejecutiva",
            "Primera"});
            this.cboClass.Location = new System.Drawing.Point(395, 102);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(105, 21);
            this.cboClass.TabIndex = 15;
            // 
            // lblmoneda
            // 
            this.lblmoneda.AutoSize = true;
            this.lblmoneda.Location = new System.Drawing.Point(186, 30);
            this.lblmoneda.Name = "lblmoneda";
            this.lblmoneda.Size = new System.Drawing.Size(56, 13);
            this.lblmoneda.TabIndex = 16;
            this.lblmoneda.Text = "Moneda:";
            // 
            // cbomoneda
            // 
            this.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbomoneda.Items.AddRange(new object[] {
            "$ Pesos",
            "US$ Dólares"});
            this.cbomoneda.Location = new System.Drawing.Point(241, 27);
            this.cbomoneda.Name = "cbomoneda";
            this.cbomoneda.Size = new System.Drawing.Size(120, 21);
            this.cbomoneda.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(400, 150);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 30);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Buscar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(29, 290);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Visible = false;
            // 
            // grpDescuent
            // 
            this.grpDescuent.Controls.Add(this.lblPromocionText);
            this.grpDescuent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescuent.Location = new System.Drawing.Point(15, 183);
            this.grpDescuent.Name = "grpDescuent";
            this.grpDescuent.Size = new System.Drawing.Size(486, 56);
            this.grpDescuent.TabIndex = 19;
            this.grpDescuent.TabStop = false;
            this.grpDescuent.Text = "Promociones y Descuentos ";
            this.grpDescuent.Enter += new System.EventHandler(this.grpPromotions_Enter);
            // 
            // lblPromocionText
            // 
            this.lblPromocionText.Location = new System.Drawing.Point(6, 16);
            this.lblPromocionText.Name = "lblPromocionText";
            this.lblPromocionText.Size = new System.Drawing.Size(460, 37);
            this.lblPromocionText.TabIndex = 0;
            this.lblPromocionText.Text = "Precio por kilómetro: 5 pesos.\r\nDescuento 50% si la distancia >= 100 km y la esta" +
    "ncia >= 7 días.";
            // 
            // grpPay
            // 
            this.grpPay.Controls.Add(this.lblTotal);
            this.grpPay.Controls.Add(this.txtTotal);
            this.grpPay.Controls.Add(this.btnPay);
            this.grpPay.Controls.Add(this.cbomoneda);
            this.grpPay.Controls.Add(this.lblmoneda);
            this.grpPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPay.Location = new System.Drawing.Point(16, 254);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(485, 70);
            this.grpPay.TabIndex = 21;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(60, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(380, 21);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(85, 30);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pagar";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // AirLux
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(520, 335);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.cboDeProvincias2);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cboDeProvincias);
            this.Controls.Add(this.cboFromAero);
            this.Controls.Add(this.lblvoy);
            this.Controls.Add(this.cbofromAero2);
            this.Controls.Add(this.lblsalida);
            this.Controls.Add(this.dtpSalida);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.nudPersons);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpDescuent);
            this.Controls.Add(this.grpPay);
            this.Controls.Add(this.lblInfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AirLux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirLux";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).EndInit();
            this.grpDescuent.ResumeLayout(false);
            this.grpPay.ResumeLayout(false);
            this.grpPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

