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
    public partial class Results : Form
    {
        Hormones usersHormones = new Hormones("Final",0, 0, 0, 0, 0, 0, 0);
        public Results()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //creating a datatable
            DataTable dt = new DataTable();

            //adding collumns to the database we just add
            dt.Columns.Add("Title");
            dt.Columns.Add("DHEA");
            dt.Columns.Add("Androstenedione");
            dt.Columns.Add("Progesterone");
            dt.Columns.Add("Estrogen");
            dt.Columns.Add("Testostorone");
            dt.Columns.Add("Phytoestrogens");
            dt.Columns.Add("TSH");

            //making the object that gathers users total hormones in take
            

            //doing a foreach so that we can add all the objects in the datagridview
            foreach (Hormones eatenObj in Form1.testList) 
            {
                dt.Rows.Add(eatenObj.Title,eatenObj.Dhea, eatenObj.Androstenedione, eatenObj.Progesterone, eatenObj.Estrogens, eatenObj.Testostorone, eatenObj.Phytoestrogens, eatenObj.Tsh);

                usersHormones.Title = usersHormones.Title;
                usersHormones.Dhea += eatenObj.Dhea;
                usersHormones.Androstenedione += eatenObj.Androstenedione;
                usersHormones.Progesterone += eatenObj.Progesterone;
                usersHormones.Estrogens += eatenObj.Estrogens;
                usersHormones.Testostorone += eatenObj.Testostorone;
                usersHormones.Phytoestrogens += eatenObj.Phytoestrogens;
                usersHormones.Tsh += eatenObj.Tsh;
            }

           dt.Rows.Add (usersHormones.Title,usersHormones.Dhea,usersHormones.Androstenedione,usersHormones.Progesterone,usersHormones.Estrogens,usersHormones.Testostorone,usersHormones.Phytoestrogens,usersHormones.Tsh);


            dataGridView1.DataSource = dt;
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mood = comboBoxMood.SelectedItem.ToString().ToLower();
            switch (mood)
            {
                case "happy":
                    {
                        if (usersHormones.Estrogens <= 0.01)
                        {
                            ReccomendationLabel.Text = "Estrogen is a bit too low, consume more dairy products such as milk or yogurt";
                        }
                        else
                        {
                            ReccomendationLabel.Text = "Keep eating more dairy and sugary foods to inprove happiness!";
                        }
                        break;
                    }
                case "sad":
                    {

                        if (usersHormones.Estrogens <= 0.01)
                        {
                            ReccomendationLabel.Text = "Estrogen is a bit too low, consume more dairy products such as milk or yogurt";
                        }
                        else if (usersHormones.Estrogens >= 0.06)
                        {
                            ReccomendationLabel.Text = "Estrogen is too high, avoid dairy products and consume more veggies to have a lower estrogen level";
                        }
                        else
                        {
                            ReccomendationLabel.Text = "Consider eating more dairy products to improve mood";
                        }
                        break;
                    }
                case "stressed":
                    {

                        if (usersHormones.Dhea >= 1)
                        { 
                            ReccomendationLabel.Text = "dhea is high, avoid turkey and prioritize beef and potato for dinner, and soybeans for lunch";
                            break;
                        }

                        else if (usersHormones.Testostorone >= 2)
                        {
                            ReccomendationLabel.Text = "testerone is high, avoid turkey and prioritize beef and potato for dinner, and soybeans for lunch";
                        }
                        else if (usersHormones.Androstenedione >= 4)
                        {
                            ReccomendationLabel.Text = "Androstenedione is high, avoid turkey and prioritize beef and potato for dinner, and soybeans for lunch";
                        }
                        else
                        {
                            ReccomendationLabel.Text = "Phytoestrogens tends to act as a calming agent among its other uses, for lunch prioritize nuts & seeds or soybeans, for dinner prioritize adding potatos instead of the other options";

                        }

                        break;
                    }
                case "tired":
                    {
                        if (usersHormones.Dhea <= 0.5)
                        {
                            ReccomendationLabel.Text = "DHEA is a bit low, consider adding supplements or eating foods rich in DHEA such as yams or wild yam extract.";
                        }
                        else
                        {
                            ReccomendationLabel.Text = "Consider adding energizing foods to your diet such as whole grains, fruits, and vegetables";
                        }

                        break;
                    }
                default:
                    ReccomendationLabel.Text = "Sorry, we don't have a recommendation for that mood.";
                    break;
            }

        }
    }
}
