using OOProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProject
{
    public partial class Form1 : Form
    {
        public static List<Hormones> testList = new List<Hormones>();
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Serafino Pampena, 2023","About");
        }

        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLunch form = new FormLunch();
            form.Show();
        }

        private void dinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiner form = new FormDiner();
            form.Show();
        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results form = new Results();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string userFood = comboBoxBreakfast.Text.ToLower();
            double quantity = Convert.ToDouble(comboBoxBreakfastQuantity.SelectedItem.ToString());


            switch (userFood) 
            {
                case "cereal(1 bowl)":
                {
                 
                 Hormones Cereal = new Hormones("Cereal " + quantity,0 * quantity, 0 * quantity, 0 * quantity,0 * quantity, 0 * quantity, 1113 * quantity, 0 * quantity);
                 testList.Add(Cereal); 
                 break;

                }

                case "bread(1 slice)":
                {


                   Hormones Bread = new Hormones("Bread " + quantity, 0 * quantity, 0 * quantity, 0 * quantity, 0 * quantity, 0 * quantity, 1113 * quantity, 0 * quantity);
                   testList.Add(Bread);
                   break;

                }

                case "egg(1 egg)":
                {
                   Hormones Egg = new Hormones("Egg " + quantity, 0.176 * quantity, 0.927 * quantity, 4.36 * quantity,0.14 * quantity, 0.19 * quantity, 0 * quantity, 5.79 * quantity);
                   testList.Add(Egg);
                   break;
                }

                case "apple(1 full apple)":
                {


                   Hormones Apple = new Hormones("Apple " + quantity, 0 * quantity, 0 * quantity, 0 * quantity,0 * quantity, 0 * quantity, 73 * quantity, 0 * quantity);
                   testList.Add(Apple);
                   break;

                }

                case "milk(1 glass)": 
                {
                   Hormones Milk = new Hormones("Milk " + quantity, 0.013 * quantity, 0.021 * quantity, 1.2 * quantity,0.015 * quantity, 0.009 * quantity, 1.2 * quantity, 1.26 * quantity);
                   testList.Add(Milk);
                   break;
                }

                default:
                {
                   Console.WriteLine();
                   break;
                }

            }

        }

        private void comboBoxBreakfast_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBreakfastQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
