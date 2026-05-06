namespace Juan_Tumminelli_FERRO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cboFromProvince;
        private System.Windows.Forms.ComboBox cboFromAirport;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cboToProvince;
        private System.Windows.Forms.ComboBox cboToAirport;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label lblPersons;
        private System.Windows.Forms.NumericUpDown nudPersons;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpPromotions;
        private System.Windows.Forms.Label lblPromotionsText;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpPayment;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblFlights = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cboFromProvince = new System.Windows.Forms.ComboBox();
            this.cboFromAirport = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cboToProvince = new System.Windows.Forms.ComboBox();
            this.cboToAirport = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.lblReturn = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.lblPersons = new System.Windows.Forms.Label();
            this.nudPersons = new System.Windows.Forms.NumericUpDown();
            this.lblClass = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.grpPromotions = new System.Windows.Forms.GroupBox();
            this.lblPromotionsText = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).BeginInit();
            this.grpPromotions.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlights
            // 
            this.lblFlights.AutoSize = true;
            this.lblFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlights.Location = new System.Drawing.Point(12, 9);
            this.lblFlights.Name = "lblFlights";
            this.lblFlights.Size = new System.Drawing.Size(64, 20);
            this.lblFlights.TabIndex = 0;
            this.lblFlights.Text = "Vuelos";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 40);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(178, 13);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Distancia al destino (kilómetros, ida):";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(15, 56);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(150, 20);
            this.txtDistance.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(190, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(52, 13);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "Salgo de:";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // cboFromProvince
            // 
            this.cboFromProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromProvince.Items.AddRange(new object[] {
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
            this.cboFromProvince.Location = new System.Drawing.Point(190, 56);
            this.cboFromProvince.Name = "cboFromProvince";
            this.cboFromProvince.Size = new System.Drawing.Size(120, 21);
            this.cboFromProvince.TabIndex = 5;
            this.cboFromProvince.SelectedIndexChanged += new System.EventHandler(this.CboFromProvince_SelectedIndexChanged);
            // 
            // cboFromAirport
            // 
            this.cboFromAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFromAirport.Location = new System.Drawing.Point(315, 56);
            this.cboFromAirport.Name = "cboFromAirport";
            this.cboFromAirport.Size = new System.Drawing.Size(185, 21);
            this.cboFromAirport.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(21, 140);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(37, 13);
            this.lblTo.TabIndex = 14;
            this.lblTo.Text = "Voy a:";
            // 
            // cboToProvince
            // 
            this.cboToProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToProvince.Items.AddRange(new object[] {
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
            this.cboToProvince.Location = new System.Drawing.Point(16, 156);
            this.cboToProvince.Name = "cboToProvince";
            this.cboToProvince.Size = new System.Drawing.Size(120, 21);
            this.cboToProvince.TabIndex = 15;
            this.cboToProvince.SelectedIndexChanged += new System.EventHandler(this.CboToProvince_SelectedIndexChanged);
            // 
            // cboToAirport
            // 
            this.cboToAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToAirport.Location = new System.Drawing.Point(140, 156);
            this.cboToAirport.Name = "cboToAirport";
            this.cboToAirport.Size = new System.Drawing.Size(200, 21);
            this.cboToAirport.TabIndex = 16;
            // 
            // lblDays
            // 
            this.lblDays.Location = new System.Drawing.Point(0, 0);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(100, 23);
            this.lblDays.TabIndex = 0;
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Location = new System.Drawing.Point(12, 86);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(36, 13);
            this.lblDeparture.TabIndex = 8;
            this.lblDeparture.Text = "Salida";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDeparture.Location = new System.Drawing.Point(15, 102);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(120, 20);
            this.dtpDeparture.TabIndex = 9;
            this.dtpDeparture.Value = new System.DateTime(2026, 5, 5, 0, 0, 0, 0);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(190, 86);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(47, 13);
            this.lblReturn.TabIndex = 10;
            this.lblReturn.Text = "Regreso";
            // 
            // dtpReturn
            // 
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(190, 102);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(120, 20);
            this.dtpReturn.TabIndex = 11;
            this.dtpReturn.Value = new System.DateTime(2026, 5, 6, 0, 0, 0, 0);
            this.dtpReturn.ValueChanged += new System.EventHandler(this.dtpReturn_ValueChanged);
            // 
            // lblPersons
            // 
            this.lblPersons.AutoSize = true;
            this.lblPersons.Location = new System.Drawing.Point(330, 86);
            this.lblPersons.Name = "lblPersons";
            this.lblPersons.Size = new System.Drawing.Size(54, 13);
            this.lblPersons.TabIndex = 12;
            this.lblPersons.Text = "Personas:";
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
            this.lblClass.Location = new System.Drawing.Point(395, 86);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(36, 13);
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
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(186, 30);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 16;
            this.lblCurrency.Text = "Moneda:";
            // 
            // cboCurrency
            // 
            this.cboCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrency.Items.AddRange(new object[] {
            "$ Pesos",
            "US$ Dólares"});
            this.cboCurrency.Location = new System.Drawing.Point(241, 27);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(120, 21);
            this.cboCurrency.TabIndex = 17;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(400, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 18;
            this.btnCalculate.Text = "Buscar";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            // grpPromotions
            // 
            this.grpPromotions.Controls.Add(this.lblPromotionsText);
            this.grpPromotions.Location = new System.Drawing.Point(15, 183);
            this.grpPromotions.Name = "grpPromotions";
            this.grpPromotions.Size = new System.Drawing.Size(486, 56);
            this.grpPromotions.TabIndex = 19;
            this.grpPromotions.TabStop = false;
            this.grpPromotions.Text = "Promociones y Descuentos";
            this.grpPromotions.Enter += new System.EventHandler(this.grpPromotions_Enter);
            // 
            // lblPromotionsText
            // 
            this.lblPromotionsText.Location = new System.Drawing.Point(6, 16);
            this.lblPromotionsText.Name = "lblPromotionsText";
            this.lblPromotionsText.Size = new System.Drawing.Size(460, 37);
            this.lblPromotionsText.TabIndex = 0;
            this.lblPromotionsText.Text = "Precio por kilómetro: 5 pesos.\r\nDescuento 50% si la distancia >= 100 km y la esta" +
    "ncia >= 7 días.";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblTotal);
            this.grpPayment.Controls.Add(this.txtTotal);
            this.grpPayment.Controls.Add(this.btnPay);
            this.grpPayment.Controls.Add(this.cboCurrency);
            this.grpPayment.Controls.Add(this.lblCurrency);
            this.grpPayment.Location = new System.Drawing.Point(16, 254);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(485, 70);
            this.grpPayment.TabIndex = 21;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Pago";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
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
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(520, 330);
            this.Controls.Add(this.lblFlights);
            this.Controls.Add(this.cboToProvince);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cboFromProvince);
            this.Controls.Add(this.cboFromAirport);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cboToAirport);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.dtpDeparture);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.lblPersons);
            this.Controls.Add(this.nudPersons);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpPromotions);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.lblInfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AirLux";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPersons)).EndInit();
            this.grpPromotions.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

