using System;
using System.Drawing;
using System.Windows.Forms;


namespace Cafeteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        { //Botão Resetar
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtMocha.Text = "0";
            txtValeCoffee.Text = "0";
            txtCappu.Text = "0";
            txtAfricanCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtChineseTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCream.Text = "0";
            txtLagosChoco.Text = "0";
            txtKillburnChoco.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "1.10";
            lblTax.Text = "0";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappucino.Checked = false;
            chkAfricanCoffe.Checked = false;
            chkMilkTea.Checked = false;
            chkChineseTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            checkBox13.Checked = false;
            chkKilburnChoco.Checked = false;
            chkCheese.Checked = false;
            chkRainbowCake.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Array
            string[] itemNames = { "Café com Leite", "Expresso", "Moca", "Vale Café", "Capuucino", "Café Frio", "Chá com Leite", "Chá chinês", "Bolo de Café", "Bolo de Veludo Vermelho", "Bolo Floresta Negra", "Bolo de Creme de Boston", "Bolo de Chocolate Lagos", "Bolo de Chocolate Kilburn", "Bolo de Queijo", "Bolo Arco-Íris" };
            // Controles de textos
            TextBox[] textControls = { txtLatte, txtEspresso, txtMocha, txtValeCoffee, txtCappu, txtAfricanCoffee, txtMilkTea, txtChineseTea, txtCoffeCake, txtRedValvetCake, txtBlackForestCake, txtBostonCream, txtLagosChoco, txtKillburnChoco, txtCheeseCake, txtRainbowCake };
            rtfReceipt.Clear();
            // Loop para adicionar os itens
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("\t\t" + "Cafe do Samuel" + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            for (int i = 0; i < itemNames.Length; i++)
            {
                int quantity = int.Parse(textControls[i].Text);
                if (quantity > 0)
                {
                    rtfReceipt.AppendText(itemNames[i] + "\t\t\t" + quantity + Environment.NewLine);
                }
            }
            // RECIBO 
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Taxa de serviço \t\t" + lblSvcCharge.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Taxa \t\t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Custo Total \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-------------------------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText(lblTimer.Text + "\t" + lblDate.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        { // Botã Total
            double lat, mocha, espr, vale, cappu, afri, mTea, cTea;
            double cCake, rValvet, bFor, bCream, lChoco, kChoco, cheese, rain;
            double tax;
            tax = 0.45;

            lat = 1.20; mocha = 1.29; espr = 1.29; vale = 1.45; cappu = 1.70; afri = 1.50; mTea = 1.45; cTea = 1.10; //Preço Café
            cCake = 1.30; rValvet = 1.20; bFor = 1.30; bCream = 1.90; lChoco = 1.50; kChoco = 1.40; cheese = 1.30; rain = 1.10; // Preço Bolo

            // Café
            double latteeCof = Convert.ToDouble(txtLatte.Text);
            double mochaCof = Convert.ToDouble(txtMocha.Text);
            double espressoCof = Convert.ToDouble(txtEspresso.Text);
            double valeCoffee = Convert.ToDouble(txtValeCoffee.Text);
            double cappCof = Convert.ToDouble(txtCappu.Text);
            double afriCof = Convert.ToDouble(txtAfricanCoffee.Text);
            double miTea = Convert.ToDouble(txtMilkTea.Text);
            double cineseTea = Convert.ToDouble(txtChineseTea.Text);
            // Bolos
            double cofCake = Convert.ToDouble(txtCoffeCake.Text);
            double redValvet = Convert.ToDouble(txtRedValvetCake.Text);
            double bForest = Convert.ToDouble(txtBlackForestCake.Text);
            double bostonCream = Convert.ToDouble(txtBostonCream.Text);
            double lagosChoco = Convert.ToDouble(txtLagosChoco.Text);
            double kilbChoco = Convert.ToDouble(txtKillburnChoco.Text);
            double cheeseCak = Convert.ToDouble(txtCheeseCake.Text);
            double rainbow = Convert.ToDouble(txtRainbowCake.Text);

            Cafe eat_in_cafe = new Cafe(latteeCof, mochaCof, espressoCof, valeCoffee, cappCof, afriCof, miTea, cineseTea,
            cofCake, redValvet, bForest, bostonCream, lagosChoco, kilbChoco, cheeseCak, rainbow);

            double drinkCosts = (latteeCof * lat) + (mochaCof * mocha) + (espressoCof * espr) + (valeCoffee * vale) + (cappCof * cappu) + (afriCof * afri) + (miTea * mTea) + (cineseTea * cTea);
            lblDrinkCost.Text = Convert.ToString(drinkCosts);
            double cakeCosts = (cofCake * cCake) + (redValvet * rValvet) + (bForest * bFor) + (bostonCream * bCream) + (lagosChoco * lChoco) + (kilbChoco * kChoco) + (cheeseCak * cheese) + (rainbow * rain);
            lblCakeCost.Text = Convert.ToString(cakeCosts);

            double svcCharge = Convert.ToDouble(lblSvcCharge.Text);

            lblSubTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge);
            lblTax.Text = Convert.ToString(((cakeCosts + drinkCosts + svcCharge) * tax) / 100);
            double totalAftTax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cakeCosts + drinkCosts + svcCharge + totalAftTax);

            lblDrinkCost.Text = String.Format("{0:C}", drinkCosts);
            lblCakeCost.Text = String.Format("{0:C}", cakeCosts);
            lblSvcCharge.Text = String.Format("{0:C}", svcCharge);
            lblSubTotal.Text = String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge));
            lblTax.Text = String.Format("{0:C}", totalAftTax);
            lblTotal.Text = String.Format("{0:C}", (cakeCosts + drinkCosts + svcCharge + totalAftTax));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            double latteeCof = Convert.ToDouble(txtLatte.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            timer1.Start();

            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtMocha.Text = "0";
            txtValeCoffee.Text = "0";
            txtCappu.Text = "0";
            txtAfricanCoffee.Text = "0";
            txtMilkTea.Text = "0";
            txtChineseTea.Text = "0";
            txtCoffeCake.Text = "0";
            txtRedValvetCake.Text = "0";
            txtBlackForestCake.Text = "0";
            txtBostonCream.Text = "0";
            txtLagosChoco.Text = "0";
            txtKillburnChoco.Text = "0";
            txtCheeseCake.Text = "0";
            txtRainbowCake.Text = "0";
            lblCakeCost.Text = "0";
            lblDrinkCost.Text = "0";
            lblSvcCharge.Text = "0.65";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";

            txtLatte.Enabled = false;
            txtEspresso.Enabled = false; ;
            txtMocha.Enabled = false;
            txtValeCoffee.Enabled = false;
            txtCappu.Enabled = false;
            txtAfricanCoffee.Enabled = false;
            txtMilkTea.Enabled = false;
            txtChineseTea.Enabled = false;
            txtCoffeCake.Enabled = false;
            txtRedValvetCake.Enabled = false;
            txtBlackForestCake.Enabled = false;
            txtBostonCream.Enabled = false;
            txtLagosChoco.Enabled = false;
            txtKillburnChoco.Enabled = false;
            txtCheeseCake.Enabled = false;
            txtRainbowCake.Enabled = false;

            chkLatte.Checked = false;
            chkEspresso.Checked = false;
            chkMocha.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappucino.Checked = false;
            chkAfricanCoffe.Checked = false;
            chkMilkTea.Checked = false;
            chkChineseTea.Checked = false;
            chkRedValvet.Checked = false;
            chkCoffe.Checked = false;
            chkBlackForest.Checked = false;
            chkBostonCream.Checked = false;
            checkBox13.Checked = false;
            chkKilburnChoco.Checked = false;
            chkCheese.Checked = false;
            chkRainbowCake.Checked = false;

            rtfReceipt.Clear();
        }

        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked == true)
            {
                txtLatte.Enabled = true;
            }
            else
            {
                txtLatte.Enabled=false;
                txtLatte.Text = "0";
            }
        }
        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }
        private void txtLatte_TextChanged(object sender, EventArgs e)
        {
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            else
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text= "0";
            }
        }
        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void chkMocha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMocha.Checked == true)
            {
                txtMocha.Enabled = true;
            }
            else
            {
                txtMocha.Enabled= false;
                txtMocha.Text= "0";
            }
        }
        private void txtMocha_Click(object sender, EventArgs e)
        {
            txtMocha.Text = "";
            txtMocha.Focus();
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtValeCoffee.Enabled = true;
            }
            else
            {
                txtValeCoffee.Enabled= false;
                txtValeCoffee.Text= "0";
            }
        }
        private void txtValeCoffee_Click(object sender, EventArgs e)
        {
            txtValeCoffee.Text = "";
            txtValeCoffee.Focus();
        }

        private void chkCappucino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappucino.Checked == true)
            {

            } 
            else
            {
                txtCappu.Enabled = true;
                txtCappu.Text= "0";
            }
        }
        private void txtCappu_Click(object sender, EventArgs e)
        {
            txtCappu.Text = "";
            txtCappu.Focus();
        }

        private void chkAfricanCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffe.Checked == true)
            {
                txtAfricanCoffee.Enabled = true;
            }
            else
            {
                txtAfricanCoffee.Enabled = false;
                txtAfricanCoffee.Text = "0";
            }
        }
        private void txtAfricanCoffee_Click(object sender, EventArgs e)
        {
            txtAfricanCoffee.Text = "";
            txtAfricanCoffee.Focus();
        }

        private void chkMilkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMilkTea.Checked == true)
            {
                txtMilkTea.Enabled = true;
            }
            else
            {
               txtMilkTea.Enabled= false;
                txtMilkTea.Text = "0";
            }
        }
        private void txtMilkTea_Click(object sender, EventArgs e)
        {
            txtMilkTea.Text = "";
            txtMilkTea.Focus();
        }

        private void chkChineseTea_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChineseTea.Checked == true)
            {
                txtChineseTea.Enabled = true;
            }
            else
            {
                txtChineseTea.Enabled = false;
                txtChineseTea.Text= "0";
            }
        }
        private void txtChineseTea_Click(object sender, EventArgs e)
        {
            txtChineseTea.Text = "";
            txtChineseTea.Focus();
        }

        private void chkCoffe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffe.Checked == true)
            {
                txtCoffeCake.Enabled = true;
            }
            else
            {
                txtCoffeCake.Enabled = false;
                txtCoffeCake.Text= "0";
            }
        }
        private void txtCoffeCake_Click(object sender, EventArgs e)
        {
            txtCoffeCake.Text = "";
            txtCoffeCake.Focus();
        }

        private void chkRedValvet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedValvet.Checked == true)
            {
                txtRainbowCake.Enabled = true;
            }
            else
            {
                txtRedValvetCake.Enabled = false;
                txtRedValvetCake.Text= "0";
            }
        }
        private void txtRedValvetCake_Click(object sender, EventArgs e)
        {
            txtRedValvetCake.Text = "";
            txtRedValvetCake.Focus();
        }

        private void chkBlackForest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForest.Checked == true)
            {
                txtBlackForestCake.Enabled = true;
            }
            else
            {
                txtBlackForestCake.Enabled = false;
                txtBlackForestCake.Text= "0";
            }
        }
        private void txtBlackForestCake_Click(object sender, EventArgs e)
        {
            txtBlackForestCake.Text = "";
            txtBlackForestCake.Focus();
        }

        private void chkBostonCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCream.Checked == true)
            {
                txtBostonCream.Enabled = true;
            }
            else
            {
                txtBostonCream.Enabled = false;
                txtBostonCream.Text = "0";
            }
        }
        private void txtBostonCream_Click(object sender, EventArgs e)
        {
            txtBostonCream.Text = "";
            txtBostonCream.Focus();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                txtLagosChoco.Enabled = true;
            }
            else
            {
                txtLagosChoco.Enabled = false;
                txtLagosChoco.Text = "0";
            }
        }
        private void txtLagosChoco_Click(object sender, EventArgs e)
        {
            txtLagosChoco.Text = "";
            txtLagosChoco.Focus();
        }

        private void chkKilburnChoco_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburnChoco.Checked == true)
            {
                txtKillburnChoco.Enabled = true;
            }
            else
            {
                txtKillburnChoco.Enabled = false;
                txtKillburnChoco.Text ="0";
            }
        }
        private void txtKillburnChoco_Click(object sender, EventArgs e)
        {
            txtKillburnChoco.Text = "";
            txtKillburnChoco.Focus();
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCheese.Checked == true)
            {
                txtCheeseCake.Enabled = true;
            }
            else
            {
                txtCheeseCake.Enabled = false;
                txtCheeseCake.Text = "0";
            }
        }
        private void txtCheeseCake_Click(object sender, EventArgs e)
        {
            txtCheeseCake.Text = "";
            txtCheeseCake.Focus();
        }

        private void chkRainbowCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRainbowCake.Checked == true)
            {
                txtRainbowCake.Enabled = true;
            }
            else
            {
                txtRainbowCake.Enabled = false;
                txtRainbowCake.Text = "0";
            }
        }
        private void txtRainbowCake_Click(object sender, EventArgs e)
        {
            txtRainbowCake.Text = "";
            txtRainbowCake.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // Salvando arquivos 
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtfReceipt.Text);
            }
        }
    }
}
