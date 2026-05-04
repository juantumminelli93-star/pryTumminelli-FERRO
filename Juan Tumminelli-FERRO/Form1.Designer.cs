namespace Juan_Tumminelli_FERRO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.NumericUpDown nudDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInfo;

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 170);
            this.Text = "Calculadora de Precios - Ferrocarril";

            // distance label
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(12, 18);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(210, 13);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Distancia al destino (kilómetros, ida):";
            this.Controls.Add(this.lblDistance);

            // distance textbox
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtDistance.Location = new System.Drawing.Point(15, 35);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(150, 20);
            this.txtDistance.TabIndex = 1;
            this.Controls.Add(this.txtDistance);

            // days label
            this.lblDays = new System.Windows.Forms.Label();
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(12, 70);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(127, 13);
            this.lblDays.TabIndex = 2;
            this.lblDays.Text = "Días de estancia (1 a 30):";
            this.Controls.Add(this.lblDays);

            // days numeric updown
            this.nudDays = new System.Windows.Forms.NumericUpDown();
            this.nudDays.Location = new System.Drawing.Point(15, 86);
            this.nudDays.Name = "nudDays";
            this.nudDays.Minimum = 1;
            this.nudDays.Maximum = 30;
            this.nudDays.Value = 1;
            this.nudDays.Size = new System.Drawing.Size(60, 20);
            this.nudDays.TabIndex = 3;
            this.Controls.Add(this.nudDays);

            // calculate button
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCalculate.Location = new System.Drawing.Point(200, 30);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular precio";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.Controls.Add(this.btnCalculate);

            // info label
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 120);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(290, 26);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Precio por kilómetro: 5 pesos. Descuento 50% si la distancia >= 100 km y\r\nla estancia >= 7 días.";
            this.Controls.Add(this.lblInfo);

            // Set AcceptButton
            this.AcceptButton = this.btnCalculate;
        }

        #endregion
    }
}

