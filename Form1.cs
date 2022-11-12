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
    public partial class FenetrePrincipale : Form
    {
        private SerialComPort serialPort;
        private Timer receivedDataTimer;
        private catapulte catapulte1 = new catapulte();
        private string receivedData;
        private int comType=0;//0 pas de comme set 1 comme serie sett
        private bool dataReady = false;
        private Boolean envoieDunMsgEnCour = false;
        public FenetrePrincipale()
        {
            InitializeComponent();
            serialPort = new SerialComPort();
            serialPort.RegisterReceiveCallback(ReceiveDataHandler);
            receivedDataTimer = new Timer();
            receivedDataTimer.Interval = 25;   // 25 ms
            receivedDataTimer.Tick += new EventHandler(ReceivedDataTimerTick);
            receivedDataTimer.Start();

        }
        private void ReceiveDataHandler(string data)
        {
            if (dataReady)
            {
                rtbComBluDebug.Text += "->";
                rtbComBluDebug.Text += "Received data was thrown away because line buffer not emptied";
                rtbComBluDebug.Text += "\n";
                rtbActCatDebug.ScrollToCaret();
            }
            else
            {
                dataReady = true;
                receivedData = data;
            }
        }

        private void ReceivedDataTimerTick(object sender, EventArgs e)
        {
            if (dataReady)
            {
                dataReady = false;
                rtbComBluDebug.Text += "<-";
                rtbComBluDebug.Text += receivedData;
                rtbActCatDebug.ScrollToCaret();
            }
        }

        private void bPActCat1Foie_Click(object sender, EventArgs e)
        {
            switch (catapulte1.state())
            {
                case 0:
                    string message = "ACT//Cata//catapultage//" +
                    nupActCatVittesseAvan.Text + "/" +
                    nupActCatVitesseArrier.Text + "/" +
                    nupActCatAccelerationAvant.Text + "/" +
                    nupActCatAccelerationArrier.Text + "/" +
                    nupActCatAttenteChargemnt.Text + "/" +
                    nupActCatTireNbPas.Text + "/" +
                    nupActCatAttenteRepo.Text + "/" +
                    "1\n";

                    rtbActCatDebug.Text += SendMessage(message); ;
                    

                    break;
                case 1:
                    rtbActCatDebug.Text += "Deja demarée\n";
                    break;
                default:
                    rtbActCatDebug.Text += "Non deffinie\n";
                    break;
            }
            rtbActCatDebug.ScrollToCaret();
        }

        private void bpActCatDemarer_Click(object sender, EventArgs e)
        {
            if (nupActCatNbFoie.Value != 0)
            {
                switch (catapulte1.state())
                {
                    case 0:
                        string message = "ACT//Cata//catapultage//" +
                        nupActCatVittesseAvan.Text + "/" +
                        nupActCatVitesseArrier.Text + "/" +
                        nupActCatAccelerationAvant.Text + "/" +
                        nupActCatAccelerationArrier.Text + "/" +
                        nupActCatAttenteChargemnt.Text + "/" +
                        nupActCatTireNbPas.Text + "/" +
                        nupActCatAttenteRepo.Text + "/" +
                        nupActCatNbFoie.Text + 
                        "\n";

                        rtbActCatDebug.Text += SendMessage(message); ;
                        
                        break;
                    case 1:
                        rtbActCatDebug.Text += "Deja demarée\n";
                        break;
                    default:
                        rtbActCatDebug.Text += "Non deffinie\n";
                        break;
                }
            }
            else
            {
                rtbActCatDebug.Text += "Tu a mis zero dans le nombre de foie\n";
            }
            rtbActCatDebug.ScrollToCaret();
        }
        private void bpActCataFairenbPasAvan_Click(object sender, EventArgs e)
        {
            switch (catapulte1.state())
            {
                
                case 0:
                    string message = "ACT//Cata//nbPas//";// a chek
                    if (nupActCatnBPas.Value > 0)
                    {

                        message+= nupActCatVittesseAvan.Text + "/" +
                        nupActCatAccelerationAvant.Text + "/" +
                        nupActCatnBPas.Text + "\n";
                    }
                    else
                    {

                        message += nupActCatVitesseArrier.Text + "/" +
                        nupActCatAccelerationArrier.Text + "/" +
                        nupActCatnBPas.Text + "\n";
                    }
                    rtbActCatDebug.Text += SendMessage(message); ;

                    break;
                case 1:
                    rtbActCatDebug.Text += "Deja demarée\n";
                    break;
                default:
                    rtbActCatDebug.Text += "Non deffinie\n";
                    break;
            }
            rtbActCatDebug.ScrollToCaret();
        }
        private void bpActCataFairenbPasArrier_Click(object sender, EventArgs e)
        {
            switch (catapulte1.state())
            {

                case 0:
                    string message = "ACT//Cata//nbPas//";
                    int value = (int)-nupActCatnBPas.Value;
                    if (nupActCatnBPas.Value < 0)
                    {

                        message += nupActCatVittesseAvan.Text + "/" +
                        nupActCatAccelerationAvant.Text + "/" +
                        value.ToString() + "\n";
                    }
                    else
                    {

                        message += nupActCatVitesseArrier.Text + "/" +
                        nupActCatAccelerationArrier.Text + "/" +
                        value.ToString() + "\n";
                    }
                    rtbActCatDebug.Text += SendMessage(message); ;

                    break;
                case 1:
                    rtbActCatDebug.Text += "Deja demarée\n";
                    break;
                default:
                    rtbActCatDebug.Text += "Non deffinie\n";
                    break;
            }
            rtbActCatDebug.ScrollToCaret();
        }

        private void bpActCatArree_Click(object sender, EventArgs e)
        {
            rtbActCatDebug.Text += "Arree\n";
            rtbActCatDebug.ScrollToCaret();
        }

        private void bpComBluDemareComme_Click(object sender, EventArgs e)
        {
            // Handles the Open/Close button, which toggles its label, depending on previous state.
            string status;
            if (bpComBluDemareComme.Text == "Demare COM")
            {
                status = serialPort.Open(txbComBluPortCom.Text, nupComBluBaud.Text, "8", "None", "One");
                if (status.Contains("Opened"))
                {
                    comType = 1;
                    bpComBluDemareComme.Text = "Stop COM";
                }
            }
            else
            {
                comType = 0;
                status = serialPort.Close();
                bpComBluDemareComme.Text = "Demare COM";
            }
            rtbComBluDebug.Text += "->";
            rtbComBluDebug.Text += status;
            rtbComBluDebug.Text += "\n";
        }

        private void bpComBluRessetAfichage_Click(object sender, EventArgs e)
        {
            rtbComBluDebug.Clear();
        }

        private void bpComBluEnvoieTrame_Click(object sender, EventArgs e)
        {
            SendMessage(txbComBluMessageEnvoie.Text+"\r\n");
        }

        private string SendMessage(String message)
        {

                
                if (comType != 0)
                {
                    if (!envoieDunMsgEnCour)
                    {
                        envoieDunMsgEnCour = true;
                        rtbComBluDebug.Text += "->";
                        rtbComBluDebug.Text += message;
                        rtbComBluDebug.Text += "\n";
                        serialPort.SendLine(message);
                        envoieDunMsgEnCour = false;
                        return message;

                    }
                    else
                    {
                        rtbComBluDebug.Text += "->";
                        rtbComBluDebug.Text += "Un message et dejat en court d'envoie";
                        rtbComBluDebug.Text += "\n";
                        return "Un message et dejat en court d'envoie\n";
                    }
                }
                else
                {
                    rtbComBluDebug.Text += "->";
                    rtbComBluDebug.Text += "Pas de com ouverte";
                    rtbComBluDebug.Text += "\n";
                    return "Pas de com ouverte\n";
                }
                
            return "Un message est deja en cour d'envoie\n";
        }

        private void bpActCatVitOptiAV_Click(object sender, EventArgs e)
        {
            nupActCatVittesseAvan.Value= (int)(nupActCatnBPasCalc.Value * 2 * 1000 / nupActCatTemps.Value);
            nupActCatAccelerationAvant.Value = (int)((long)nupActCatnBPasCalc.Value * (long)1000 * (long)1000 / ((long)nupActCatTemps.Value * (long)nupActCatTemps.Value) );
        }

        private void bpActCatVitOptiAR_Click(object sender, EventArgs e)
        {
            nupActCatVitesseArrier.Value = 2*(int)(nupActCatnBPasCalc.Value * 2 * 1000 / nupActCatTemps.Value);
            nupActCatAccelerationArrier.Value = 2*(int)((long)nupActCatnBPasCalc.Value * (long)1000 * (long)1000 / ((long)nupActCatTemps.Value * (long)nupActCatTemps.Value));
        }   

        private void chbStrDepDeplacement_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepArcdecercle.Checked = false;
            chbStrDepCourbedebesier.Checked = false;
        }

        private void chbStrDepDeplacementXY_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepArcdecercle.Checked = false;
            chbStrDepCourbedebesier.Checked = false;
        }

        private void chbStrDepRecalage_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepArcdecercle.Checked = false;
            chbStrDepCourbedebesier.Checked = false;
        }

        private void chbStrDepArcdecercle_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepCourbedebesier.Checked = false;
        }

        private void chbStrDepCourbedebesier_CheckedChanged(object sender, EventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepArcdecercle.Checked = false;
        }
    }
}
