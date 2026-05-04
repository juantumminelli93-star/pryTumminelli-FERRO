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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const decimal pricePerKm = 5m;
            const decimal discountFactor = 0.5m;

            // Validate distance input
            if (!decimal.TryParse(txtDistance.Text.Trim(), out decimal distanceOneWay))
            {
                MessageBox.Show("Ingrese una distancia válida en kilómetros.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistance.Focus();
                return;
            }

            if (distanceOneWay <= 0)
            {
                MessageBox.Show("La distancia debe ser mayor que 0.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDistance.Focus();
                return;
            }

            int days = (int)nudDays.Value;

            // distance total for round trip
            decimal totalDistance = distanceOneWay * 2m;
            decimal price = totalDistance * pricePerKm;

            // apply discount if conditions met
            if (distanceOneWay >= 100m && days >= 7)
            {
                price = price * discountFactor;
            }

            MessageBox.Show($"El precio del boleto (ida y vuelta) es: {price:C2}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
