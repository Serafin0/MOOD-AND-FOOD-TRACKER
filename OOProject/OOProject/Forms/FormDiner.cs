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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOProject
{
    public partial class FormDiner : Form
    {
        public FormDiner()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string userFood = comboBoxDinner.Text.ToLower();
            double quantity = Convert.ToDouble(comboBoxDinnerQuantity.SelectedItem.ToString());

            switch (userFood)
            {
                case "butter(1 stick)":
                    {


                        Hormones Butter = new Hormones("Butter " + quantity,0.115 * quantity, 0.598 * quantity, 14.1 * quantity,0.029 * quantity, 0.005 * quantity, 0 * quantity, 14.8 * quantity); ;
                         Form1.testList.Add(Butter);
                        break;

                    }

                case "fish(1 fish)":
                    {


                        Hormones Fish = new Hormones("Fish " + quantity, 0.06 * quantity, 0.029 * quantity, 0.051 * quantity,0.005 * quantity, 0.007 * quantity, 0 * quantity, 0.147 * quantity);
                         Form1.testList.Add(Fish);
                        break;

                    }

                case "beef(1 pound)":
                    {
                        Hormones Beef = new Hormones("Beef " + quantity, 0.09 * quantity, 0.08 * quantity, 2.15 * quantity,0.005 * quantity, 0.4 * quantity, 0 * quantity, 2.72 * quantity);
                         Form1.testList.Add(Beef);
                        break;
                    }

                case "potato(1 potato)":
                    {


                        Hormones Potato = new Hormones("Potato" + quantity, 0.0309 * quantity, 0.005 * quantity, 0.507 * quantity,0.005 * quantity, 0.002 * quantity, 1.4 * quantity, 0.550 * quantity);
                         Form1.testList.Add(Potato);
                        break;

                    }

                case "olive oil(1 teaspoon)":
                    {
                        Hormones OliveOil = new Hormones("Olive Oil " + quantity, 0.004 * quantity, 0.002 * quantity, 0.008 * quantity,0.005 * quantity, 0.002 * quantity, 180.7 * quantity, 0.021 * quantity);
                        Form1.testList.Add(OliveOil);
                        break;
                    }

                default:
                    {
                        Console.WriteLine();
                        break;
                    }
            }
        }


      

        public void comboBoxMoodDiner_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
