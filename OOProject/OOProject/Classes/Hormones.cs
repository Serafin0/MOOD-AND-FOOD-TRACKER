using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProject.Classes
{
    public class Hormones
    {
        private string title;
        private double dhea;
        private double androstenedione;
        private double progesterone;
        private double estrogens;
        private double testostorone;
        private double phytoestrogens;
        private double tsh;

        public Hormones() { }

        public Hormones(string title,double dhea, double androstenedione, double progesterone, double estrogens, double testostorone, double phytoestrogens, double tsh)
        {
            this.title = title;
            this.Dhea = dhea;
            this.Androstenedione = androstenedione;
            this.Progesterone = progesterone;
            this.Estrogens = estrogens;
            this.Testostorone = testostorone;
            this.Phytoestrogens = phytoestrogens;
            this.Tsh = tsh;
        }

        public string Title { get => title; set => title = value; }
        public double Dhea { get => dhea; set => dhea = value; }
        public double Androstenedione { get => androstenedione; set => androstenedione = value; }
        public double Progesterone { get => progesterone; set => progesterone = value; }
        public double Estrogens { get => estrogens; set => estrogens = value; }
        public double Testostorone { get => testostorone; set => testostorone = value; }
        public double Phytoestrogens { get => phytoestrogens; set => phytoestrogens = value; }
        public double Tsh { get => tsh; set => tsh = value; }
    }
}
