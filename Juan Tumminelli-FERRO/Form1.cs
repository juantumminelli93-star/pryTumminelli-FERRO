using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juan_Tumminelli_FERRO
{
    public partial class AirLux : Form
    {
        public AirLux()
        {
            InitializeComponent();
         
            if (this.cboDeProvincias.Items.Count > 0) this.cboDeProvincias.SelectedIndex = 0;
            if (this.cboDeProvincias2.Items.Count > 0) this.cboDeProvincias2.SelectedIndex = 0;
        }

        private void CboFromProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAirportsForProvince(this.cboDeProvincias.SelectedItem as string, this.cboFromAero);
        }

        private void CboToProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateAirportsForProvince(this.cboDeProvincias2.SelectedItem as string, this.cbofromAero2);
        }

        private void PopulateAirportsForProvince(string province, ComboBox target)
        {
            target.Items.Clear();
            if (string.IsNullOrEmpty(province)) return;

          
            switch (province)
            {
                case "Buenos Aires":
                    target.Items.AddRange(new object[] { "Ezeiza (EZE)", "Aeroparque (AEP)", "Mar del Plata (MDQ)" });
                    break;
                case "Córdoba":
                    target.Items.AddRange(new object[] { "Pajas Blancas (COR)" });
                    break;
                case "Mendoza":
                    target.Items.AddRange(new object[] { "El Plumerillo (MDZ)" });
                    break;
                case "Neuquén":
                    target.Items.AddRange(new object[] { "Presidente Perón (NQN)" });
                    break;
                case "Tierra del Fuego":
                    target.Items.AddRange(new object[] { "Ushuaia (USH)" });
                    break;
                default:
                    target.Items.AddRange(new object[] { "Aeropuerto local" });
                    break;
            }

            if (target.Items.Count > 0) target.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal pricePerKm = 5m;
            const decimal discountFactor = 0.5m;

      
            if (!decimal.TryParse(txtDistancia.Text.Trim(), out decimal distanceOneWay))
            {
                MessageBox.Show("Ingrese una distancia válida en kilómetros.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

            if (distanceOneWay <= 0)
            {
                MessageBox.Show("La distancia debe ser mayor que 0.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistancia.Focus();
                return;
            }

           
            DateTime departureDate = this.dtpSalida.Value.Date;
            DateTime returnDate = this.dtpReturn.Value.Date;

            if (returnDate <= departureDate)
            {
                MessageBox.Show("La fecha de regreso debe ser posterior a la de salida.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtpReturn.Focus();
                return;
            }

            int days = (int)(returnDate - departureDate).TotalDays;

     
            decimal totalDistance = distanceOneWay * 2m;
            decimal price = totalDistance * pricePerKm;

          
            bool promotionApplied = (distanceOneWay >= 100m && days >= 7);
            if (promotionApplied)
            {
                price = price * discountFactor;
            }

           
            string fromProvince = this.cboDeProvincias.SelectedItem != null ? this.cboDeProvincias.SelectedItem.ToString() : "";
            string fromAirport = this.cboFromAero.SelectedItem != null ? this.cboFromAero.SelectedItem.ToString() : "";
            string toProvince = this.cboDeProvincias2.SelectedItem != null ? this.cboDeProvincias2.SelectedItem.ToString() : "";
            string toAirport = this.cbofromAero2.SelectedItem != null ? this.cbofromAero2.SelectedItem.ToString() : "";
            int persons = (int)this.nudPersons.Value;
            string travelClass = this.cboClass.SelectedItem != null ? this.cboClass.SelectedItem.ToString() : this.cboClass.Text;
            string currency = this.cbomoneda.SelectedItem != null ? this.cbomoneda.SelectedItem.ToString() : this.cbomoneda.Text;

            string summary =
                "Resumen de búsqueda:\r\n" +
                $"Origen: {fromProvince} - {fromAirport}\r\n" +
                $"Destino: {toProvince} - {toAirport}\r\n" +
                $"Salida: {departureDate:d}   Regreso: {returnDate:d}\r\n" +
                $"Días de estancia: {days}\r\n" +
                $"Personas: {persons}   Clase: {travelClass}\r\n" +
                $"Distancia ida (km): {distanceOneWay}   Distancia total (ida y vuelta): {totalDistance}\r\n" +
                $"Precio por km: {pricePerKm:C2}\r\n" +
                $"Promoción aplicada: {(promotionApplied ? "SÍ (50% off)" : "NO")}\r\n" +
                $"Precio final (ida y vuelta): {price:C2}";

            MessageBox.Show(summary, "Resultado de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

         
            this.txtTotal.Text = price.ToString("F2");
           
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.txtTotal.Text))
            {
                MessageBox.Show("No hay un total calculado. Busque primero para calcular el precio.", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Procesando pago de {this.txtTotal.Text} {this.cbomoneda.SelectedItem}", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void grpPromotions_Enter(object sender, EventArgs e)
        {

        }

        private void dtpReturn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFrom_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
