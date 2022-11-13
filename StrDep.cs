using applicationRoboV1;
using SERIAL_RX_TX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace appRoboBlutousse
{
    internal class Deplacement
    {
        private Byte depLigneAngle = 0;
        private int changeDepValeur = 0;
        public string changeDep(Byte lingneAngle,int valeur,int vittesse, int acceleration,int distanceDetec,int distArret  )
        {
            if(lingneAngle != 3)
            {
                changeDepValeur = valeur;
            }

            if (lingneAngle != 3)
            {
                depLigneAngle = lingneAngle;
            }
            string str = "Dep/";
            switch (depLigneAngle)
            {
                case 0:
                    str += "NAN/";
                break;
                case 1:
                    str += "ligne/";
                break ;
                case 2:
                    str += "angle/";
                break;
            }

            str += changeDepValeur.ToString() + '/';
            str += vittesse.ToString() + '/';
            str += acceleration.ToString() + '/';
            str += distanceDetec.ToString() + '/';
            str += distArret.ToString();
            str += "!";
            return str;
        }
    }
}
