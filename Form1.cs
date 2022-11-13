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
        private Deplacement deplacement = new Deplacement();
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
                
            //return "Un message est deja en cour d'envoie\n";
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

            chbStrDepLigne.Checked = false;
            chbStrDepAngle.Checked = false;
            chbStrDepDeplacementA.Checked = false;
            chbStrDepRecAxeX.Checked = false;
            chbStrDepRecAxeY.Checked = false;
            chbStrDepRecTypeArrier.Checked = false;
            chbStrDepRecTypeAvan.Checked = false;
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepCorAngleFin.Checked = false;
            chbStrDepCorAngleDebut.Checked = false;
            chbStrDepCorectionPosition.Checked = false;
            if (chbStrDepDeplacement.Checked)
            {
                chbStrDepLigne.Enabled = true;
                chbStrDepAngle.Enabled = true;

                labStrDepDepX.Enabled = false;
                labStrDepDepY.Enabled = false;
                chbStrDepDeplacementA.Enabled = false;
                nupStrDepDepX.Enabled = false;
                nupStrDepDepY.Enabled = false;
                nupStrDepDepA.Enabled = false;

                labStrDepRecDistMur.Enabled = false;
                labStrDepReqNouvellePosition.Enabled = false;
                nupStrDepRecDistanceMur.Enabled = false;
                nupStrDepRecNouvellePosition.Enabled = false;
                labStrDepRecAxe.Enabled = false;
                chbStrDepRecAxeX.Enabled = false;
                chbStrDepRecAxeY.Enabled = false;
                labStrDepRecType.Enabled = false;
                chbStrDepRecTypeArrier.Enabled = false;
                chbStrDepRecTypeAvan.Enabled = false;

                labStrDepRecArcX.Enabled = false;
                labStrDepRecArcY.Enabled = false;
                labStrDepRecArcRayon.Enabled = false;
                labStrDepRecArcAngle.Enabled = false;
                nupStrDepRecArcX.Enabled = false;
                nupStrDepRecArcY.Enabled = false;
                nupStrDepRecArcRayon.Enabled = false;
                nupStrDepRecArcAngle.Enabled = false;

                labStrDepCobNBPoint.Enabled = false;
                trvStrAbr.Enabled = false;
                cbStrDepCobChoixDuPoint.Enabled = false;
                labStrDepCobX.Enabled = false;
                nupStrDepCobX.Enabled = false;
                labStrDepCobY.Enabled = false;
                nupStrDepCobY.Enabled = false;
            }
            else
            {
                chbStrDepLigne.Enabled = false;
                chbStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
                nupStrDepAngle.Enabled = false;
            }

            rtbStrDepDebug.Text = deplacement.changeDep(0,
                0,
                0,
                0,
                0,
                0);

        }

        private void chbStrDepDeplacementXY_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepArcdecercle.Checked = false;
            chbStrDepCourbedebesier.Checked = false;

            chbStrDepLigne.Checked = false;
            chbStrDepAngle.Checked = false;
            chbStrDepDeplacementA.Checked = false;
            chbStrDepRecAxeX.Checked = false;
            chbStrDepRecAxeY.Checked = false;
            chbStrDepRecTypeArrier.Checked = false;
            chbStrDepRecTypeAvan.Checked = false;
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepCorAngleFin.Checked = false;
            chbStrDepCorAngleDebut.Checked = false;
            chbStrDepCorectionPosition.Checked = false;
            if (chbStrDepDeplacementXY.Checked)
            {
                chbStrDepLigne.Enabled = false;
                chbStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
                nupStrDepAngle.Enabled = false;

                labStrDepDepX.Enabled = true;
                labStrDepDepY.Enabled = true;
                chbStrDepDeplacementA.Enabled = true;
                nupStrDepDepX.Enabled=true;
                nupStrDepDepY.Enabled=true;
                nupStrDepDepA.Enabled=true;

                labStrDepRecDistMur.Enabled = false;
                labStrDepReqNouvellePosition.Enabled = false;
                nupStrDepRecDistanceMur.Enabled = false;
                nupStrDepRecNouvellePosition.Enabled = false;
                labStrDepRecAxe.Enabled = false;
                chbStrDepRecAxeX.Enabled = false;
                chbStrDepRecAxeY.Enabled = false;
                labStrDepRecType.Enabled = false;
                chbStrDepRecTypeArrier.Enabled = false;
                chbStrDepRecTypeAvan.Enabled = false;

                labStrDepRecArcX.Enabled = false;
                labStrDepRecArcY.Enabled = false;
                labStrDepRecArcRayon.Enabled = false;
                labStrDepRecArcAngle.Enabled = false;
                nupStrDepRecArcX.Enabled = false;
                nupStrDepRecArcY.Enabled = false;
                nupStrDepRecArcRayon.Enabled = false;
                nupStrDepRecArcAngle.Enabled = false;

                labStrDepCobNBPoint.Enabled = false;
                trvStrAbr.Enabled = false;
                cbStrDepCobChoixDuPoint.Enabled = false;
                labStrDepCobX.Enabled = false;
                nupStrDepCobX.Enabled = false;
                labStrDepCobY.Enabled = false;
                nupStrDepCobY.Enabled = false;
            }
            else
            {
                labStrDepDepX.Enabled = false;
                labStrDepDepY.Enabled = false;
                chbStrDepDeplacementA.Enabled = false;
                nupStrDepDepX.Enabled = false;
                nupStrDepDepY.Enabled = false;
                nupStrDepDepA.Enabled = false;
            }
        }

        private void chbStrDepRecalage_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepArcdecercle.Checked = false;
            chbStrDepCourbedebesier.Checked = false;

            chbStrDepLigne.Checked = false;
            chbStrDepAngle.Checked = false;
            chbStrDepDeplacementA.Checked = false;
            chbStrDepRecAxeX.Checked = false;
            chbStrDepRecAxeY.Checked = false;
            chbStrDepRecTypeArrier.Checked = false;
            chbStrDepRecTypeAvan.Checked = false;
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepCorAngleFin.Checked = false;
            chbStrDepCorAngleDebut.Checked = false;
            chbStrDepCorectionPosition.Checked = false;
            if (chbStrDepRecalage.Checked)
            {
                chbStrDepLigne.Enabled = false;
                chbStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
                nupStrDepAngle.Enabled = false;

                labStrDepDepX.Enabled = false;
                labStrDepDepY.Enabled = false;
                chbStrDepDeplacementA.Enabled = false;
                nupStrDepDepX.Enabled = false;
                nupStrDepDepY.Enabled = false;
                nupStrDepDepA.Enabled = false;

                labStrDepRecDistMur.Enabled = true;
                labStrDepReqNouvellePosition.Enabled = true;
                nupStrDepRecDistanceMur.Enabled = true;
                nupStrDepRecNouvellePosition.Enabled = true;
                labStrDepRecAxe.Enabled = true;
                chbStrDepRecAxeX.Enabled = true;
                chbStrDepRecAxeY.Enabled = true;
                labStrDepRecType.Enabled = true;
                chbStrDepRecTypeArrier.Enabled = true;
                chbStrDepRecTypeAvan.Enabled = true;

                labStrDepRecArcX.Enabled = false;
                labStrDepRecArcY.Enabled = false;
                labStrDepRecArcRayon.Enabled = false;
                labStrDepRecArcAngle.Enabled = false;
                nupStrDepRecArcX.Enabled = false;
                nupStrDepRecArcY.Enabled = false;
                nupStrDepRecArcRayon.Enabled = false;
                nupStrDepRecArcAngle.Enabled = false;

                labStrDepCobNBPoint.Enabled = false;
                trvStrAbr.Enabled = false;
                cbStrDepCobChoixDuPoint.Enabled = false;
                labStrDepCobX.Enabled = false;
                nupStrDepCobX.Enabled = false;
                labStrDepCobY.Enabled = false;
                nupStrDepCobY.Enabled = false;
            }
            else
            {
                labStrDepRecDistMur.Enabled = false;
                labStrDepReqNouvellePosition.Enabled = false;
                nupStrDepRecDistanceMur.Enabled = false;
                nupStrDepRecNouvellePosition.Enabled = false;
                labStrDepRecAxe.Enabled = false;
                chbStrDepRecAxeX.Enabled = false;
                chbStrDepRecAxeY.Enabled = false;
                labStrDepRecType.Enabled = false;
                chbStrDepRecTypeArrier.Enabled = false;
                chbStrDepRecTypeAvan.Enabled = false;
            }
        }

        private void chbStrDepArcdecercle_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepCourbedebesier.Checked = false;

            chbStrDepLigne.Checked = false;
            chbStrDepAngle.Checked = false;
            chbStrDepDeplacementA.Checked = false;
            chbStrDepRecAxeX.Checked = false;
            chbStrDepRecAxeY.Checked = false;
            chbStrDepRecTypeArrier.Checked = false;
            chbStrDepRecTypeAvan.Checked = false;
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepCorAngleFin.Checked = false;
            chbStrDepCorAngleDebut.Checked = false;
            chbStrDepCorectionPosition.Checked = false;
            if (chbStrDepArcdecercle.Checked)
            {
                chbStrDepLigne.Enabled = false;
                chbStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
                nupStrDepAngle.Enabled = false;

                labStrDepDepX.Enabled = false;
                labStrDepDepY.Enabled = false;
                chbStrDepDeplacementA.Enabled = false;
                nupStrDepDepX.Enabled = false;
                nupStrDepDepY.Enabled = false;
                nupStrDepDepA.Enabled = false;

                labStrDepRecDistMur.Enabled = false;
                labStrDepReqNouvellePosition.Enabled = false;
                nupStrDepRecDistanceMur.Enabled = false;
                nupStrDepRecNouvellePosition.Enabled = false;
                labStrDepRecAxe.Enabled = false;
                chbStrDepRecAxeX.Enabled = false;
                chbStrDepRecAxeY.Enabled = false;
                labStrDepRecType.Enabled = false;
                chbStrDepRecTypeArrier.Enabled = false;
                chbStrDepRecTypeAvan.Enabled = false;

                labStrDepRecArcX.Enabled = true;
                labStrDepRecArcY.Enabled = true;
                labStrDepRecArcRayon.Enabled = true;
                labStrDepRecArcAngle.Enabled = true;
                nupStrDepRecArcX.Enabled = true;
                nupStrDepRecArcY.Enabled = true;
                nupStrDepRecArcRayon.Enabled = true;
                nupStrDepRecArcAngle.Enabled = true;

                labStrDepCobNBPoint.Enabled = false;
                trvStrAbr.Enabled = false;
                cbStrDepCobChoixDuPoint.Enabled = false;
                labStrDepCobX.Enabled = false;
                nupStrDepCobX.Enabled = false;
                labStrDepCobY.Enabled = false;
                nupStrDepCobY.Enabled = false;
            }
            else
            {
                labStrDepRecArcX.Enabled = false;
                labStrDepRecArcY.Enabled = false;
                labStrDepRecArcRayon.Enabled = false;
                labStrDepRecArcAngle.Enabled = false;
                nupStrDepRecArcX.Enabled = false;
                nupStrDepRecArcY.Enabled = false;
                nupStrDepRecArcRayon.Enabled = false;
                nupStrDepRecArcAngle.Enabled = false;
            }
        }

        private void chbStrDepCourbedebesier_MouseClick(object sender, EventArgs e)
        {
            chbStrDepDeplacement.Checked = false;
            chbStrDepDeplacementXY.Checked = false;
            chbStrDepRecalage.Checked = false;
            chbStrDepArcdecercle.Checked = false;

            chbStrDepLigne.Checked = false;
            chbStrDepAngle.Checked = false;
            chbStrDepDeplacementA.Checked = false;
            chbStrDepRecAxeX.Checked = false;
            chbStrDepRecAxeY.Checked = false;
            chbStrDepRecTypeArrier.Checked = false;
            chbStrDepRecTypeAvan.Checked = false;
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepCorAngleFin.Checked = false;
            chbStrDepCorAngleDebut.Checked = false;
            chbStrDepCorectionPosition.Checked = false;

            if (chbStrDepCourbedebesier.Checked)
            {
                chbStrDepLigne.Enabled = false;
                chbStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
                nupStrDepAngle.Enabled = false;

                labStrDepDepX.Enabled = false;
                labStrDepDepY.Enabled = false;
                chbStrDepDeplacementA.Enabled = false;
                nupStrDepDepX.Enabled = false;
                nupStrDepDepY.Enabled = false;
                nupStrDepDepA.Enabled = false;

                labStrDepRecDistMur.Enabled = false;
                labStrDepReqNouvellePosition.Enabled = false;
                nupStrDepRecDistanceMur.Enabled = false;
                nupStrDepRecNouvellePosition.Enabled = false;
                labStrDepRecAxe.Enabled = false;
                chbStrDepRecAxeX.Enabled = false;
                chbStrDepRecAxeY.Enabled = false;
                labStrDepRecType.Enabled = false;
                chbStrDepRecTypeArrier.Enabled = false;
                chbStrDepRecTypeAvan.Enabled = false;

                labStrDepRecArcX.Enabled = false;
                labStrDepRecArcY.Enabled = false;
                labStrDepRecArcRayon.Enabled = false;
                labStrDepRecArcAngle.Enabled = false;
                nupStrDepRecArcX.Enabled = false;
                nupStrDepRecArcY.Enabled = false;
                nupStrDepRecArcRayon.Enabled = false;
                nupStrDepRecArcAngle.Enabled = false;

                labStrDepCobNBPoint.Enabled = true;
                trvStrAbr.Enabled = true;
                cbStrDepCobChoixDuPoint.Enabled = true;
                labStrDepCobX.Enabled = true;
                nupStrDepCobX.Enabled = true;
                labStrDepCobY.Enabled = true;
                nupStrDepCobY.Enabled = true;
            }
            else
            {
                labStrDepCobNBPoint.Enabled = false;
                trvStrAbr.Enabled = false;
                cbStrDepCobChoixDuPoint.Enabled = false;
                labStrDepCobX.Enabled = false;
                nupStrDepCobX.Enabled = false;
                labStrDepCobY.Enabled = false;
                nupStrDepCobY.Enabled = false;
            }
        }

        private void chbStrDepLigne_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepAngle.Checked = false;
            if (chbStrDepLigne.Checked)
            {
                nupStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = true;
            }
            else
            {
                nupStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
            }
            if (chbStrDepLigne.Checked)
            {
                rtbStrDepDebug.Text = deplacement.changeDep(1,
                    (int)nupStrDepLigne.Value,
                    (int)nupStrDepVittesse.Value,
                    (int)nupStrDepAcceleration.Value,
                    (int)nupStrDepDistance.Value,
                    (int)nupStrDepArret.Value);
            }
            else
            {
                rtbStrDepDebug.Text = deplacement.changeDep(0,
                    0,
                    0,
                    0,
                    0,
                    0);
            }
        }

        private void chbStrDepAngle_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepLigne.Checked = false;
            if (chbStrDepAngle.Checked)
            {
                nupStrDepAngle.Enabled = true;
                nupStrDepLigne.Enabled = false;
            }
            else
            {
                nupStrDepAngle.Enabled = false;
                nupStrDepLigne.Enabled = false;
            }
            if (chbStrDepAngle.Checked)
            {
                rtbStrDepDebug.Text = deplacement.changeDep(2,
                    (int)nupStrDepAngle.Value,
                    (int)nupStrDepVittesse.Value,
                    (int)nupStrDepAcceleration.Value,
                    (int)nupStrDepDistance.Value,
                    (int)nupStrDepArret.Value);
            }
            else
            {
                rtbStrDepDebug.Text = deplacement.changeDep(0,
                    0,
                    0,
                    0,
                    0,
                    0);
            }
        }

        private void chbStrDepRecAxeX_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepRecAxeY.Checked = false;
        }

        private void chbStrDepRecAxeY_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepRecAxeX.Checked = false;
        }

        private void chbStrDepRecTypeArrier_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepRecTypeAvan.Checked = false;
        }

        private void chbStrDepRecTypeAvan_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepRecTypeArrier.Checked = false;
        }

        private void nupStrDepLigne_ValueChanged(object sender, EventArgs e)
        {
            rtbStrDepDebug.Text = deplacement.changeDep(1,
                (int)nupStrDepLigne.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepAngle_ValueChanged(object sender, EventArgs e)
        {
            rtbStrDepDebug.Text = deplacement.changeDep(2,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepLigne_MouseCaptureChanged(object sender, EventArgs e)
        {
            rtbStrDepDebug.Text = deplacement.changeDep(1,
                (int)nupStrDepLigne.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepAngle_MouseCaptureChanged(object sender, EventArgs e)
        {
            rtbStrDepDebug.Text = deplacement.changeDep(2,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void chbStrDepPV_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = true;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = false;
            if (chbStrDepPV.Checked)
            {
                nupStrDepAcceleration.Value = nupStrConPetitVittesse.Value;
                nupStrDepVittesse.Value = nupStrConPetiteAcceleration.Value;
                nupStrDepDistance.Value = nupStrConPetiteDistance.Value;
                nupStrDepArret.Value = nupStrConPetiteDistanceArret.Value;
            }
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void chbStrDepMV_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = true;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = false;
            if (chbStrDepMV.Checked)
            {
                nupStrDepAcceleration.Value = nupStrConMoyenAcceleration.Value;
                nupStrDepVittesse.Value = nupStrConMoyenVittesse.Value;
                nupStrDepDistance.Value = nupStrConMoyenDistance.Value;
                nupStrDepArret.Value = nupStrConMoyeneDistanceArret.Value;
            }
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void chbStrDepGV_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = true;
            chbStrDepPerssonaliser.Checked = false;
            if (chbStrDepGV.Checked)
            {
                nupStrDepAcceleration.Value = nupStrConGrandAcceleration.Value;
                nupStrDepVittesse.Value = nupStrConGrandVittesse.Value;
                nupStrDepDistance.Value = nupStrConGrandeDistance.Value;
                nupStrDepArret.Value = nupStrConGrandDistanceArret.Value;
            }
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void chbStrDepPerssonaliser_MouseClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepAcceleration_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepVittesse_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepDistance_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepArret_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepAcceleration_MouseCaptureChanged(object sender, EventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepVittesse_MouseCaptureChanged(object sender, EventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepDistance_MouseCaptureChanged(object sender, EventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }

        private void nupStrDepArret_MouseCaptureChanged(object sender, EventArgs e)
        {
            chbStrDepPV.Checked = false;
            chbStrDepMV.Checked = false;
            chbStrDepGV.Checked = false;
            chbStrDepPerssonaliser.Checked = true;
            rtbStrDepDebug.Text = deplacement.changeDep(3,
                (int)nupStrDepAngle.Value,
                (int)nupStrDepVittesse.Value,
                (int)nupStrDepAcceleration.Value,
                (int)nupStrDepDistance.Value,
                (int)nupStrDepArret.Value);
        }
    }
}
