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
    public partial class FormLunch : Form
    {
        public FormLunch()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string userFood = comboBoxLunch.Text.ToLower();
            double quantity = Convert.ToDouble(comboBoxLunchQuantity.SelectedItem.ToString());

            switch (userFood)
            {
                case "ham(1 slice)":
                    {


                        Hormones ham = new Hormones("Ham " + quantity, 0.005 * quantity, 0.039 *quantity, 0.151 *quantity,0.005 *quantity, 0.005 *quantity, 2.3 *quantity, 0.259 *quantity);
                        Form1.testList.Add(ham);
                        break;

                    }

                case "carrots(1 carrot)":
                    {


                        Hormones Carrot = new Hormones("Carrot " + quantity, 0 *quantity, 0 *quantity, 0 *quantity,0 *quantity, 0 *quantity, 504 *quantity, 0 *quantity);
                        Form1.testList.Add(Carrot);
                        break;

                    }

                case "soy beans(1 spoonfull)":
                    {
                        Hormones SoyBean = new Hormones("Soy Bean " + quantity, 0.031 *quantity, 0.005 *quantity, 0.03 *quantity,0.012 *quantity, 19837 *quantity, 0.083 *quantity, 5.79 *quantity);
                        Form1.testList.Add(SoyBean);
                        break;
                    }

                case "yogurt(1 cup)":
                    {


                        Hormones Yogurt = new Hormones("Yogurt " + quantity, 0.011 *quantity, 0.056 *quantity, 1.33 *quantity,0.018 *quantity, 0.001 *quantity, 0 *quantity, 1.42 *quantity);
                        Form1.testList.Add(Yogurt);
                        break;

                    }

                case "turkey(1 slice)":
                    {
                        Hormones Turkey = new Hormones("Turkey " + quantity, 0.005 *quantity, 0.006 *quantity, 0.818 *quantity,0.003 *quantity, 0.0023 *quantity, 0 *quantity, 0.083 *quantity);
                        Form1.testList.Add(Turkey);
                        break;
                    }

                default:
                    {
                        Console.WriteLine();
                        break;
                    }

            }
        }
    }
}
