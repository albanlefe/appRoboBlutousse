using applicationRoboV1;
using SERIAL_RX_TX;
using System;
using System.Drawing;

namespace appRoboBlutousse
{
    partial class FenetrePrincipale
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenetrePrincipale));
            this.tacMain = new System.Windows.Forms.TabControl();
            this.tapMainStr = new System.Windows.Forms.TabPage();
            this.spcStrHorisontal = new System.Windows.Forms.SplitContainer();
            this.spcStrMapTreeView = new System.Windows.Forms.SplitContainer();
            this.picStrTable = new System.Windows.Forms.PictureBox();
            this.tctStrVueStrategie = new System.Windows.Forms.TabControl();
            this.pjStrVueArbre = new System.Windows.Forms.TabPage();
            this.trvStrAbr = new System.Windows.Forms.TreeView();
            this.pjStrVueChekBox = new System.Windows.Forms.TabPage();
            this.chbStrChe = new System.Windows.Forms.CheckedListBox();
            this.pjStrVueTxt = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.spcEditeBp = new System.Windows.Forms.SplitContainer();
            this.tbcStrConfigurateur = new System.Windows.Forms.TabControl();
            this.pjStrConfiguration = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.numericUpDown43 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown44 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown45 = new System.Windows.Forms.NumericUpDown();
            this.label68 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.numericUpDown40 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown41 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown42 = new System.Windows.Forms.NumericUpDown();
            this.label39 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.numericUpDown14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown13 = new System.Windows.Forms.NumericUpDown();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pjStrConDeplacement = new System.Windows.Forms.TabPage();
            this.numericUpDown26 = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.numericUpDown27 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown25 = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown24 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown23 = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDown21 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown22 = new System.Windows.Forms.NumericUpDown();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.numericUpDown20 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown19 = new System.Windows.Forms.NumericUpDown();
            this.chbStrDepArcdecercle = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.numericUpDown18 = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label34 = new System.Windows.Forms.Label();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.numericUpDown17 = new System.Windows.Forms.NumericUpDown();
            this.label33 = new System.Windows.Forms.Label();
            this.numericUpDown16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown15 = new System.Windows.Forms.NumericUpDown();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.chbStrDepCourbedebesier = new System.Windows.Forms.CheckBox();
            this.chbStrDepRecalage = new System.Windows.Forms.CheckBox();
            this.chbStrDepDeplacement = new System.Windows.Forms.CheckBox();
            this.chbStrDepDeplacementXY = new System.Windows.Forms.CheckBox();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.spcStrDepPrepaVisu = new System.Windows.Forms.SplitContainer();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tacStrActRoPlateau = new System.Windows.Forms.TabPage();
            this.numericUpDown38 = new System.Windows.Forms.NumericUpDown();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.numericUpDown37 = new System.Windows.Forms.NumericUpDown();
            this.label56 = new System.Windows.Forms.Label();
            this.numericUpDown36 = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.numericUpDown35 = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.numericUpDown34 = new System.Windows.Forms.NumericUpDown();
            this.label53 = new System.Windows.Forms.Label();
            this.numericUpDown33 = new System.Windows.Forms.NumericUpDown();
            this.label52 = new System.Windows.Forms.Label();
            this.numericUpDown32 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown31 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown30 = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.numericUpDown29 = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.numericUpDown28 = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.spcStrActRoboPlaConsImage = new System.Windows.Forms.SplitContainer();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.numericUpDown39 = new System.Windows.Forms.NumericUpDown();
            this.cbStrActRpDeclencheur = new System.Windows.Forms.ComboBox();
            this.spcStrActRoboPlaVisuImage = new System.Windows.Forms.SplitContainer();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tacStrActionRoCata = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tapMainActionneur = new System.Windows.Forms.TabPage();
            this.tacAct = new System.Windows.Forms.TabControl();
            this.tacActCatapulte = new System.Windows.Forms.TabPage();
            this.spcActCat = new System.Windows.Forms.SplitContainer();
            this.bPActCat1Foie = new System.Windows.Forms.Button();
            this.nupActCatTireNbPas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nupActCatnBPasCalc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bpActCatVitOptiAR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bpActCatVitOptiAV = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nupActCatTemps = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.bpActCataFairenbPasArrier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bpActCataFairenbPasAvan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bpActCatDemarer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nupActCatVitesseArrier = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nupActCatVittesseAvan = new System.Windows.Forms.NumericUpDown();
            this.nupActCatNbFoie = new System.Windows.Forms.NumericUpDown();
            this.nupActCatAccelerationArrier = new System.Windows.Forms.NumericUpDown();
            this.nupActCatnBPas = new System.Windows.Forms.NumericUpDown();
            this.nupActCatAccelerationAvant = new System.Windows.Forms.NumericUpDown();
            this.nupActCatAttenteRepo = new System.Windows.Forms.NumericUpDown();
            this.nupActCatAttenteChargemnt = new System.Windows.Forms.NumericUpDown();
            this.rtbActCatDebug = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tacMainCommunication = new System.Windows.Forms.TabPage();
            this.tacCom = new System.Windows.Forms.TabControl();
            this.tacComBlutoose = new System.Windows.Forms.TabPage();
            this.spcComBluComandeVisue = new System.Windows.Forms.SplitContainer();
            this.txbComBluMessageEnvoie = new System.Windows.Forms.TextBox();
            this.bpComBluEnvoieTrame = new System.Windows.Forms.Button();
            this.nupComBluBaud = new System.Windows.Forms.NumericUpDown();
            this.bpComBluRessetAfichage = new System.Windows.Forms.Button();
            this.bpComBluDemareComme = new System.Windows.Forms.Button();
            this.txbComBluPortCom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbComBluDebug = new System.Windows.Forms.RichTextBox();
            this.tacComCan = new System.Windows.Forms.TabPage();
            this.tapSimulation = new System.Windows.Forms.TabPage();
            this.bpActCatArree = new System.Windows.Forms.Button();
            this.tacMain.SuspendLayout();
            this.tapMainStr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcStrHorisontal)).BeginInit();
            this.spcStrHorisontal.Panel1.SuspendLayout();
            this.spcStrHorisontal.Panel2.SuspendLayout();
            this.spcStrHorisontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcStrMapTreeView)).BeginInit();
            this.spcStrMapTreeView.Panel1.SuspendLayout();
            this.spcStrMapTreeView.Panel2.SuspendLayout();
            this.spcStrMapTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStrTable)).BeginInit();
            this.tctStrVueStrategie.SuspendLayout();
            this.pjStrVueArbre.SuspendLayout();
            this.pjStrVueChekBox.SuspendLayout();
            this.pjStrVueTxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcEditeBp)).BeginInit();
            this.spcEditeBp.Panel1.SuspendLayout();
            this.spcEditeBp.Panel2.SuspendLayout();
            this.spcEditeBp.SuspendLayout();
            this.tbcStrConfigurateur.SuspendLayout();
            this.pjStrConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.pjStrConDeplacement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcStrDepPrepaVisu)).BeginInit();
            this.spcStrDepPrepaVisu.Panel2.SuspendLayout();
            this.spcStrDepPrepaVisu.SuspendLayout();
            this.tacStrActRoPlateau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcStrActRoboPlaConsImage)).BeginInit();
            this.spcStrActRoboPlaConsImage.Panel1.SuspendLayout();
            this.spcStrActRoboPlaConsImage.Panel2.SuspendLayout();
            this.spcStrActRoboPlaConsImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcStrActRoboPlaVisuImage)).BeginInit();
            this.spcStrActRoboPlaVisuImage.Panel1.SuspendLayout();
            this.spcStrActRoboPlaVisuImage.Panel2.SuspendLayout();
            this.spcStrActRoboPlaVisuImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tapMainActionneur.SuspendLayout();
            this.tacAct.SuspendLayout();
            this.tacActCatapulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcActCat)).BeginInit();
            this.spcActCat.Panel1.SuspendLayout();
            this.spcActCat.Panel2.SuspendLayout();
            this.spcActCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatTireNbPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatnBPasCalc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatTemps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatVitesseArrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatVittesseAvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatNbFoie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAccelerationArrier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatnBPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAccelerationAvant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAttenteRepo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAttenteChargemnt)).BeginInit();
            this.tacMainCommunication.SuspendLayout();
            this.tacCom.SuspendLayout();
            this.tacComBlutoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcComBluComandeVisue)).BeginInit();
            this.spcComBluComandeVisue.Panel1.SuspendLayout();
            this.spcComBluComandeVisue.Panel2.SuspendLayout();
            this.spcComBluComandeVisue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupComBluBaud)).BeginInit();
            this.SuspendLayout();
            // 
            // tacMain
            // 
            this.tacMain.Controls.Add(this.tapMainStr);
            this.tacMain.Controls.Add(this.tapMainActionneur);
            this.tacMain.Controls.Add(this.tacMainCommunication);
            this.tacMain.Controls.Add(this.tapSimulation);
            this.tacMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tacMain.Location = new System.Drawing.Point(0, 0);
            this.tacMain.Margin = new System.Windows.Forms.Padding(2);
            this.tacMain.Name = "tacMain";
            this.tacMain.SelectedIndex = 0;
            this.tacMain.Size = new System.Drawing.Size(1367, 748);
            this.tacMain.TabIndex = 0;
            // 
            // tapMainStr
            // 
            this.tapMainStr.BackColor = System.Drawing.Color.Transparent;
            this.tapMainStr.Controls.Add(this.spcStrHorisontal);
            this.tapMainStr.Location = new System.Drawing.Point(4, 22);
            this.tapMainStr.Margin = new System.Windows.Forms.Padding(2);
            this.tapMainStr.Name = "tapMainStr";
            this.tapMainStr.Padding = new System.Windows.Forms.Padding(2);
            this.tapMainStr.Size = new System.Drawing.Size(1359, 722);
            this.tapMainStr.TabIndex = 0;
            this.tapMainStr.Text = "Strategiet";
            // 
            // spcStrHorisontal
            // 
            this.spcStrHorisontal.BackColor = System.Drawing.Color.Transparent;
            this.spcStrHorisontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStrHorisontal.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcStrHorisontal.IsSplitterFixed = true;
            this.spcStrHorisontal.Location = new System.Drawing.Point(2, 2);
            this.spcStrHorisontal.Name = "spcStrHorisontal";
            this.spcStrHorisontal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcStrHorisontal.Panel1
            // 
            this.spcStrHorisontal.Panel1.Controls.Add(this.spcStrMapTreeView);
            // 
            // spcStrHorisontal.Panel2
            // 
            this.spcStrHorisontal.Panel2.Controls.Add(this.spcEditeBp);
            this.spcStrHorisontal.Size = new System.Drawing.Size(1355, 718);
            this.spcStrHorisontal.SplitterDistance = 586;
            this.spcStrHorisontal.TabIndex = 0;
            // 
            // spcStrMapTreeView
            // 
            this.spcStrMapTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStrMapTreeView.IsSplitterFixed = true;
            this.spcStrMapTreeView.Location = new System.Drawing.Point(0, 0);
            this.spcStrMapTreeView.Name = "spcStrMapTreeView";
            // 
            // spcStrMapTreeView.Panel1
            // 
            this.spcStrMapTreeView.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.spcStrMapTreeView.Panel1.Controls.Add(this.picStrTable);
            // 
            // spcStrMapTreeView.Panel2
            // 
            this.spcStrMapTreeView.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcStrMapTreeView.Panel2.Controls.Add(this.tctStrVueStrategie);
            this.spcStrMapTreeView.Size = new System.Drawing.Size(1355, 586);
            this.spcStrMapTreeView.SplitterDistance = 888;
            this.spcStrMapTreeView.TabIndex = 0;
            // 
            // picStrTable
            // 
            this.picStrTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStrTable.Image = global::appRoboBlutousse.Properties.Resources.Sans_titre;
            this.picStrTable.Location = new System.Drawing.Point(0, 0);
            this.picStrTable.Name = "picStrTable";
            this.picStrTable.Size = new System.Drawing.Size(888, 586);
            this.picStrTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStrTable.TabIndex = 0;
            this.picStrTable.TabStop = false;
            // 
            // tctStrVueStrategie
            // 
            this.tctStrVueStrategie.Controls.Add(this.pjStrVueArbre);
            this.tctStrVueStrategie.Controls.Add(this.pjStrVueChekBox);
            this.tctStrVueStrategie.Controls.Add(this.pjStrVueTxt);
            this.tctStrVueStrategie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctStrVueStrategie.Location = new System.Drawing.Point(0, 0);
            this.tctStrVueStrategie.Name = "tctStrVueStrategie";
            this.tctStrVueStrategie.SelectedIndex = 0;
            this.tctStrVueStrategie.Size = new System.Drawing.Size(463, 586);
            this.tctStrVueStrategie.TabIndex = 0;
            // 
            // pjStrVueArbre
            // 
            this.pjStrVueArbre.Controls.Add(this.trvStrAbr);
            this.pjStrVueArbre.Location = new System.Drawing.Point(4, 22);
            this.pjStrVueArbre.Name = "pjStrVueArbre";
            this.pjStrVueArbre.Padding = new System.Windows.Forms.Padding(3);
            this.pjStrVueArbre.Size = new System.Drawing.Size(455, 560);
            this.pjStrVueArbre.TabIndex = 0;
            this.pjStrVueArbre.Text = "Arbre";
            this.pjStrVueArbre.UseVisualStyleBackColor = true;
            // 
            // trvStrAbr
            // 
            this.trvStrAbr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvStrAbr.Location = new System.Drawing.Point(3, 3);
            this.trvStrAbr.Name = "trvStrAbr";
            this.trvStrAbr.Size = new System.Drawing.Size(449, 554);
            this.trvStrAbr.TabIndex = 0;
            // 
            // pjStrVueChekBox
            // 
            this.pjStrVueChekBox.Controls.Add(this.chbStrChe);
            this.pjStrVueChekBox.Location = new System.Drawing.Point(4, 22);
            this.pjStrVueChekBox.Name = "pjStrVueChekBox";
            this.pjStrVueChekBox.Padding = new System.Windows.Forms.Padding(3);
            this.pjStrVueChekBox.Size = new System.Drawing.Size(455, 560);
            this.pjStrVueChekBox.TabIndex = 1;
            this.pjStrVueChekBox.Text = "Check box";
            this.pjStrVueChekBox.UseVisualStyleBackColor = true;
            // 
            // chbStrChe
            // 
            this.chbStrChe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chbStrChe.FormattingEnabled = true;
            this.chbStrChe.Location = new System.Drawing.Point(3, 3);
            this.chbStrChe.Name = "chbStrChe";
            this.chbStrChe.Size = new System.Drawing.Size(449, 554);
            this.chbStrChe.TabIndex = 0;
            // 
            // pjStrVueTxt
            // 
            this.pjStrVueTxt.Controls.Add(this.richTextBox1);
            this.pjStrVueTxt.Location = new System.Drawing.Point(4, 22);
            this.pjStrVueTxt.Name = "pjStrVueTxt";
            this.pjStrVueTxt.Padding = new System.Windows.Forms.Padding(3);
            this.pjStrVueTxt.Size = new System.Drawing.Size(455, 560);
            this.pjStrVueTxt.TabIndex = 2;
            this.pjStrVueTxt.Text = "Txt";
            this.pjStrVueTxt.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(449, 554);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // spcEditeBp
            // 
            this.spcEditeBp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcEditeBp.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcEditeBp.IsSplitterFixed = true;
            this.spcEditeBp.Location = new System.Drawing.Point(0, 0);
            this.spcEditeBp.Name = "spcEditeBp";
            // 
            // spcEditeBp.Panel1
            // 
            this.spcEditeBp.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.spcEditeBp.Panel1.Controls.Add(this.tbcStrConfigurateur);
            // 
            // spcEditeBp.Panel2
            // 
            this.spcEditeBp.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.spcEditeBp.Panel2.Controls.Add(this.button6);
            this.spcEditeBp.Panel2.Controls.Add(this.button5);
            this.spcEditeBp.Panel2.Controls.Add(this.numericUpDown2);
            this.spcEditeBp.Panel2.Controls.Add(this.numericUpDown1);
            this.spcEditeBp.Panel2.Controls.Add(this.button4);
            this.spcEditeBp.Panel2.Controls.Add(this.button3);
            this.spcEditeBp.Panel2.Controls.Add(this.button2);
            this.spcEditeBp.Panel2.Controls.Add(this.button1);
            this.spcEditeBp.Size = new System.Drawing.Size(1355, 128);
            this.spcEditeBp.SplitterDistance = 1174;
            this.spcEditeBp.TabIndex = 0;
            // 
            // tbcStrConfigurateur
            // 
            this.tbcStrConfigurateur.Controls.Add(this.pjStrConfiguration);
            this.tbcStrConfigurateur.Controls.Add(this.pjStrConDeplacement);
            this.tbcStrConfigurateur.Controls.Add(this.tacStrActRoPlateau);
            this.tbcStrConfigurateur.Controls.Add(this.tacStrActionRoCata);
            this.tbcStrConfigurateur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcStrConfigurateur.Location = new System.Drawing.Point(0, 0);
            this.tbcStrConfigurateur.Margin = new System.Windows.Forms.Padding(0);
            this.tbcStrConfigurateur.Name = "tbcStrConfigurateur";
            this.tbcStrConfigurateur.SelectedIndex = 0;
            this.tbcStrConfigurateur.Size = new System.Drawing.Size(1174, 128);
            this.tbcStrConfigurateur.TabIndex = 0;
            // 
            // pjStrConfiguration
            // 
            this.pjStrConfiguration.Controls.Add(this.textBox1);
            this.pjStrConfiguration.Controls.Add(this.label63);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown43);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown44);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown45);
            this.pjStrConfiguration.Controls.Add(this.label68);
            this.pjStrConfiguration.Controls.Add(this.label64);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown40);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown41);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown42);
            this.pjStrConfiguration.Controls.Add(this.label39);
            this.pjStrConfiguration.Controls.Add(this.comboBox1);
            this.pjStrConfiguration.Controls.Add(this.label38);
            this.pjStrConfiguration.Controls.Add(this.checkBox20);
            this.pjStrConfiguration.Controls.Add(this.checkBox19);
            this.pjStrConfiguration.Controls.Add(this.checkBox18);
            this.pjStrConfiguration.Controls.Add(this.label37);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown14);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown13);
            this.pjStrConfiguration.Controls.Add(this.checkBox10);
            this.pjStrConfiguration.Controls.Add(this.checkBox9);
            this.pjStrConfiguration.Controls.Add(this.label32);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown9);
            this.pjStrConfiguration.Controls.Add(this.label24);
            this.pjStrConfiguration.Controls.Add(this.label23);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown6);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown7);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown8);
            this.pjStrConfiguration.Controls.Add(this.label22);
            this.pjStrConfiguration.Controls.Add(this.label21);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown5);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown4);
            this.pjStrConfiguration.Controls.Add(this.numericUpDown3);
            this.pjStrConfiguration.Controls.Add(this.label20);
            this.pjStrConfiguration.Controls.Add(this.label19);
            this.pjStrConfiguration.Location = new System.Drawing.Point(4, 22);
            this.pjStrConfiguration.Name = "pjStrConfiguration";
            this.pjStrConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.pjStrConfiguration.Size = new System.Drawing.Size(1166, 102);
            this.pjStrConfiguration.TabIndex = 0;
            this.pjStrConfiguration.Text = "Configuration";
            this.pjStrConfiguration.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(888, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(889, 53);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(29, 13);
            this.label63.TabIndex = 37;
            this.label63.Text = "Nom";
            // 
            // numericUpDown43
            // 
            this.numericUpDown43.Location = new System.Drawing.Point(317, 60);
            this.numericUpDown43.Name = "numericUpDown43";
            this.numericUpDown43.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown43.TabIndex = 36;
            // 
            // numericUpDown44
            // 
            this.numericUpDown44.Location = new System.Drawing.Point(317, 43);
            this.numericUpDown44.Name = "numericUpDown44";
            this.numericUpDown44.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown44.TabIndex = 35;
            // 
            // numericUpDown45
            // 
            this.numericUpDown45.Location = new System.Drawing.Point(317, 24);
            this.numericUpDown45.Name = "numericUpDown45";
            this.numericUpDown45.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown45.TabIndex = 34;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(314, 8);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(63, 13);
            this.label68.TabIndex = 33;
            this.label68.Text = "Arret en mm";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(231, 8);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(81, 13);
            this.label64.TabIndex = 32;
            this.label64.Text = "Distance en cm";
            // 
            // numericUpDown40
            // 
            this.numericUpDown40.Location = new System.Drawing.Point(234, 60);
            this.numericUpDown40.Name = "numericUpDown40";
            this.numericUpDown40.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown40.TabIndex = 30;
            // 
            // numericUpDown41
            // 
            this.numericUpDown41.Location = new System.Drawing.Point(234, 43);
            this.numericUpDown41.Name = "numericUpDown41";
            this.numericUpDown41.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown41.TabIndex = 29;
            // 
            // numericUpDown42
            // 
            this.numericUpDown42.Location = new System.Drawing.Point(234, 24);
            this.numericUpDown42.Name = "numericUpDown42";
            this.numericUpDown42.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown42.TabIndex = 28;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(889, 8);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 24;
            this.label39.Text = "Robo";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Robot rond",
            "Robot catapulte"});
            this.comboBox1.Location = new System.Drawing.Point(889, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(775, 40);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(77, 13);
            this.label38.TabIndex = 22;
            this.label38.Text = "Cotée du code";
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(730, 46);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(47, 17);
            this.checkBox20.TabIndex = 21;
            this.checkBox20.Text = "Bleu";
            this.checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(730, 29);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(45, 17);
            this.checkBox19.TabIndex = 20;
            this.checkBox19.Text = "Vert";
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(730, 63);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(118, 17);
            this.checkBox18.TabIndex = 19;
            this.checkBox18.Text = "Revecible (couleur)";
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(727, 8);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 13);
            this.label37.TabIndex = 18;
            this.label37.Text = "Coulleur";
            // 
            // numericUpDown14
            // 
            this.numericUpDown14.Location = new System.Drawing.Point(631, 46);
            this.numericUpDown14.Name = "numericUpDown14";
            this.numericUpDown14.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown14.TabIndex = 17;
            // 
            // numericUpDown13
            // 
            this.numericUpDown13.Location = new System.Drawing.Point(631, 26);
            this.numericUpDown13.Name = "numericUpDown13";
            this.numericUpDown13.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown13.TabIndex = 16;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(569, 49);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(56, 17);
            this.checkBox10.TabIndex = 15;
            this.checkBox10.Text = "Arriere";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(569, 27);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(54, 17);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Avant";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(566, 8);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 13);
            this.label32.TabIndex = 13;
            this.label32.Text = "Recalage";
            // 
            // numericUpDown9
            // 
            this.numericUpDown9.Location = new System.Drawing.Point(478, 24);
            this.numericUpDown9.Name = "numericUpDown9";
            this.numericUpDown9.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown9.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(465, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "Temp matche (Ms)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(161, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "Acceleration";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(161, 60);
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown6.TabIndex = 9;
            // 
            // numericUpDown7
            // 
            this.numericUpDown7.Location = new System.Drawing.Point(161, 43);
            this.numericUpDown7.Name = "numericUpDown7";
            this.numericUpDown7.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown7.TabIndex = 8;
            // 
            // numericUpDown8
            // 
            this.numericUpDown8.Location = new System.Drawing.Point(161, 24);
            this.numericUpDown8.Name = "numericUpDown8";
            this.numericUpDown8.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown8.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Vitesse";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Grand vittesse";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(88, 60);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown5.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(88, 43);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown4.TabIndex = 3;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(88, 24);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Moyen vittesse";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Petit vittesse";
            // 
            // pjStrConDeplacement
            // 
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown26);
            this.pjStrConDeplacement.Controls.Add(this.label45);
            this.pjStrConDeplacement.Controls.Add(this.label46);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown27);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown25);
            this.pjStrConDeplacement.Controls.Add(this.label44);
            this.pjStrConDeplacement.Controls.Add(this.comboBox2);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown24);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown23);
            this.pjStrConDeplacement.Controls.Add(this.label43);
            this.pjStrConDeplacement.Controls.Add(this.label42);
            this.pjStrConDeplacement.Controls.Add(this.label40);
            this.pjStrConDeplacement.Controls.Add(this.label41);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown21);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown22);
            this.pjStrConDeplacement.Controls.Add(this.checkBox23);
            this.pjStrConDeplacement.Controls.Add(this.checkBox22);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown20);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown19);
            this.pjStrConDeplacement.Controls.Add(this.chbStrDepArcdecercle);
            this.pjStrConDeplacement.Controls.Add(this.label36);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown18);
            this.pjStrConDeplacement.Controls.Add(this.label35);
            this.pjStrConDeplacement.Controls.Add(this.checkBox17);
            this.pjStrConDeplacement.Controls.Add(this.checkBox16);
            this.pjStrConDeplacement.Controls.Add(this.label34);
            this.pjStrConDeplacement.Controls.Add(this.checkBox15);
            this.pjStrConDeplacement.Controls.Add(this.checkBox14);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown17);
            this.pjStrConDeplacement.Controls.Add(this.label33);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown16);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown15);
            this.pjStrConDeplacement.Controls.Add(this.checkBox13);
            this.pjStrConDeplacement.Controls.Add(this.checkBox12);
            this.pjStrConDeplacement.Controls.Add(this.checkBox11);
            this.pjStrConDeplacement.Controls.Add(this.checkBox8);
            this.pjStrConDeplacement.Controls.Add(this.checkBox7);
            this.pjStrConDeplacement.Controls.Add(this.checkBox6);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown12);
            this.pjStrConDeplacement.Controls.Add(this.checkBox5);
            this.pjStrConDeplacement.Controls.Add(this.label31);
            this.pjStrConDeplacement.Controls.Add(this.label30);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown11);
            this.pjStrConDeplacement.Controls.Add(this.chbStrDepCourbedebesier);
            this.pjStrConDeplacement.Controls.Add(this.chbStrDepRecalage);
            this.pjStrConDeplacement.Controls.Add(this.chbStrDepDeplacement);
            this.pjStrConDeplacement.Controls.Add(this.chbStrDepDeplacementXY);
            this.pjStrConDeplacement.Controls.Add(this.numericUpDown10);
            this.pjStrConDeplacement.Controls.Add(this.spcStrDepPrepaVisu);
            this.pjStrConDeplacement.Controls.Add(this.label25);
            this.pjStrConDeplacement.Location = new System.Drawing.Point(4, 22);
            this.pjStrConDeplacement.Margin = new System.Windows.Forms.Padding(0);
            this.pjStrConDeplacement.Name = "pjStrConDeplacement";
            this.pjStrConDeplacement.Padding = new System.Windows.Forms.Padding(3);
            this.pjStrConDeplacement.Size = new System.Drawing.Size(1166, 102);
            this.pjStrConDeplacement.TabIndex = 1;
            this.pjStrConDeplacement.Text = "Deplacement";
            this.pjStrConDeplacement.UseVisualStyleBackColor = true;
            // 
            // numericUpDown26
            // 
            this.numericUpDown26.Location = new System.Drawing.Point(670, 76);
            this.numericUpDown26.Name = "numericUpDown26";
            this.numericUpDown26.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown26.TabIndex = 50;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(645, 80);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(26, 13);
            this.label45.TabIndex = 52;
            this.label45.Text = "Y = ";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(563, 78);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(26, 13);
            this.label46.TabIndex = 51;
            this.label46.Text = "X = ";
            // 
            // numericUpDown27
            // 
            this.numericUpDown27.Location = new System.Drawing.Point(589, 75);
            this.numericUpDown27.Name = "numericUpDown27";
            this.numericUpDown27.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown27.TabIndex = 49;
            // 
            // numericUpDown25
            // 
            this.numericUpDown25.Location = new System.Drawing.Point(652, 20);
            this.numericUpDown25.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown25.Name = "numericUpDown25";
            this.numericUpDown25.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown25.TabIndex = 47;
            this.numericUpDown25.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(558, 24);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(95, 13);
            this.label44.TabIndex = 48;
            this.label44.Text = "nombre de point = ";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(561, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // numericUpDown24
            // 
            this.numericUpDown24.Location = new System.Drawing.Point(484, 82);
            this.numericUpDown24.Name = "numericUpDown24";
            this.numericUpDown24.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown24.TabIndex = 45;
            // 
            // numericUpDown23
            // 
            this.numericUpDown23.Location = new System.Drawing.Point(484, 62);
            this.numericUpDown23.Name = "numericUpDown23";
            this.numericUpDown23.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown23.TabIndex = 44;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(428, 66);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(50, 13);
            this.label43.TabIndex = 43;
            this.label43.Text = "Rayon = ";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(432, 86);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(46, 13);
            this.label42.TabIndex = 42;
            this.label42.Text = "Angle = ";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(452, 46);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(26, 13);
            this.label40.TabIndex = 41;
            this.label40.Text = "Y = ";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(452, 26);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(26, 13);
            this.label41.TabIndex = 40;
            this.label41.Text = "X = ";
            // 
            // numericUpDown21
            // 
            this.numericUpDown21.Location = new System.Drawing.Point(484, 42);
            this.numericUpDown21.Name = "numericUpDown21";
            this.numericUpDown21.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown21.TabIndex = 39;
            // 
            // numericUpDown22
            // 
            this.numericUpDown22.Location = new System.Drawing.Point(484, 22);
            this.numericUpDown22.Name = "numericUpDown22";
            this.numericUpDown22.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown22.TabIndex = 38;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(13, 54);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(53, 17);
            this.checkBox23.TabIndex = 37;
            this.checkBox23.Text = "Angle";
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(13, 29);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(48, 17);
            this.checkBox22.TabIndex = 36;
            this.checkBox22.Text = "ligne";
            this.checkBox22.UseVisualStyleBackColor = true;
            // 
            // numericUpDown20
            // 
            this.numericUpDown20.Location = new System.Drawing.Point(66, 53);
            this.numericUpDown20.Name = "numericUpDown20";
            this.numericUpDown20.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown20.TabIndex = 35;
            // 
            // numericUpDown19
            // 
            this.numericUpDown19.Location = new System.Drawing.Point(66, 27);
            this.numericUpDown19.Name = "numericUpDown19";
            this.numericUpDown19.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown19.TabIndex = 33;
            // 
            // chbStrDepArcdecercle
            // 
            this.chbStrDepArcdecercle.AutoSize = true;
            this.chbStrDepArcdecercle.Location = new System.Drawing.Point(431, 4);
            this.chbStrDepArcdecercle.Name = "chbStrDepArcdecercle";
            this.chbStrDepArcdecercle.Size = new System.Drawing.Size(89, 17);
            this.chbStrDepArcdecercle.TabIndex = 31;
            this.chbStrDepArcdecercle.Text = "Arc de cercle";
            this.chbStrDepArcdecercle.UseVisualStyleBackColor = true;
            this.chbStrDepArcdecercle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbStrDepArcdecercle_MouseClick);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(260, 76);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(31, 13);
            this.label36.TabIndex = 30;
            this.label36.Text = "Type";
            // 
            // numericUpDown18
            // 
            this.numericUpDown18.Location = new System.Drawing.Point(355, 36);
            this.numericUpDown18.Name = "numericUpDown18";
            this.numericUpDown18.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown18.TabIndex = 29;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(255, 38);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 13);
            this.label35.TabIndex = 28;
            this.label35.Text = "Nouvelle position = ";
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(346, 56);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(33, 17);
            this.checkBox17.TabIndex = 27;
            this.checkBox17.Text = "Y";
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(296, 56);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(33, 17);
            this.checkBox16.TabIndex = 26;
            this.checkBox16.Text = "X";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(266, 58);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(25, 13);
            this.label34.TabIndex = 25;
            this.label34.Text = "Axe";
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(296, 74);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(50, 17);
            this.checkBox15.TabIndex = 24;
            this.checkBox15.Text = "Arrier";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(346, 74);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(54, 17);
            this.checkBox14.TabIndex = 23;
            this.checkBox14.Text = "Avant";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // numericUpDown17
            // 
            this.numericUpDown17.Location = new System.Drawing.Point(355, 20);
            this.numericUpDown17.Name = "numericUpDown17";
            this.numericUpDown17.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown17.TabIndex = 21;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(274, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 13);
            this.label33.TabIndex = 20;
            this.label33.Text = "Distance mur = ";
            // 
            // numericUpDown16
            // 
            this.numericUpDown16.Location = new System.Drawing.Point(744, 78);
            this.numericUpDown16.Name = "numericUpDown16";
            this.numericUpDown16.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown16.TabIndex = 19;
            // 
            // numericUpDown15
            // 
            this.numericUpDown15.Location = new System.Drawing.Point(744, 58);
            this.numericUpDown15.Name = "numericUpDown15";
            this.numericUpDown15.Size = new System.Drawing.Size(91, 20);
            this.numericUpDown15.TabIndex = 18;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(744, 6);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(87, 17);
            this.checkBox13.TabIndex = 17;
            this.checkBox13.Text = "Petit Vittesse";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(744, 40);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(91, 17);
            this.checkBox12.TabIndex = 16;
            this.checkBox12.Text = "Grnad vitesse";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(744, 23);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(97, 17);
            this.checkBox11.TabIndex = 15;
            this.checkBox11.Text = "Moyen vittesse";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(845, 47);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(110, 17);
            this.checkBox8.TabIndex = 14;
            this.checkBox8.Text = "Corection position";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(845, 27);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(130, 17);
            this.checkBox7.TabIndex = 13;
            this.checkBox7.Text = "Corection angle debut";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(845, 6);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(117, 17);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Corection angle Fin";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Location = new System.Drawing.Point(181, 75);
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown12.TabIndex = 11;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(135, 77);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(45, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "A = ";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(154, 53);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(26, 13);
            this.label31.TabIndex = 9;
            this.label31.Text = "Y = ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(154, 27);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 13);
            this.label30.TabIndex = 8;
            this.label30.Text = "X = ";
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(181, 49);
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown11.TabIndex = 7;
            // 
            // chbStrDepCourbedebesier
            // 
            this.chbStrDepCourbedebesier.AutoSize = true;
            this.chbStrDepCourbedebesier.Location = new System.Drawing.Point(561, 3);
            this.chbStrDepCourbedebesier.Name = "chbStrDepCourbedebesier";
            this.chbStrDepCourbedebesier.Size = new System.Drawing.Size(106, 17);
            this.chbStrDepCourbedebesier.TabIndex = 6;
            this.chbStrDepCourbedebesier.Text = "Courbe de besier";
            this.chbStrDepCourbedebesier.UseVisualStyleBackColor = true;
            // 
            // chbStrDepRecalage
            // 
            this.chbStrDepRecalage.AutoSize = true;
            this.chbStrDepRecalage.Location = new System.Drawing.Point(259, 6);
            this.chbStrDepRecalage.Name = "chbStrDepRecalage";
            this.chbStrDepRecalage.Size = new System.Drawing.Size(72, 17);
            this.chbStrDepRecalage.TabIndex = 5;
            this.chbStrDepRecalage.Text = "Recalage";
            this.chbStrDepRecalage.UseVisualStyleBackColor = true;
            this.chbStrDepRecalage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbStrDepRecalage_MouseClick);
            // 
            // chbStrDepDeplacement
            // 
            this.chbStrDepDeplacement.AutoSize = true;
            this.chbStrDepDeplacement.Location = new System.Drawing.Point(13, 6);
            this.chbStrDepDeplacement.Name = "chbStrDepDeplacement";
            this.chbStrDepDeplacement.Size = new System.Drawing.Size(95, 17);
            this.chbStrDepDeplacement.TabIndex = 3;
            this.chbStrDepDeplacement.Text = "Ddeplacement";
            this.chbStrDepDeplacement.UseVisualStyleBackColor = true;
            this.chbStrDepDeplacement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbStrDepDeplacement_MouseClick);
            // 
            // chbStrDepDeplacementXY
            // 
            this.chbStrDepDeplacementXY.AutoSize = true;
            this.chbStrDepDeplacementXY.Location = new System.Drawing.Point(135, 6);
            this.chbStrDepDeplacementXY.Name = "chbStrDepDeplacementXY";
            this.chbStrDepDeplacementXY.Size = new System.Drawing.Size(106, 17);
            this.chbStrDepDeplacementXY.TabIndex = 2;
            this.chbStrDepDeplacementXY.Text = "Deplacement XY";
            this.chbStrDepDeplacementXY.UseVisualStyleBackColor = true;
            this.chbStrDepDeplacementXY.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chbStrDepDeplacementXY_MouseClick);
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(181, 23);
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown10.TabIndex = 0;
            // 
            // spcStrDepPrepaVisu
            // 
            this.spcStrDepPrepaVisu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStrDepPrepaVisu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcStrDepPrepaVisu.Location = new System.Drawing.Point(3, 3);
            this.spcStrDepPrepaVisu.Name = "spcStrDepPrepaVisu";
            // 
            // spcStrDepPrepaVisu.Panel2
            // 
            this.spcStrDepPrepaVisu.Panel2.Controls.Add(this.richTextBox2);
            this.spcStrDepPrepaVisu.Size = new System.Drawing.Size(1160, 96);
            this.spcStrDepPrepaVisu.SplitterDistance = 971;
            this.spcStrDepPrepaVisu.TabIndex = 53;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(0, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(185, 96);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(7, 7);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(0, 13);
            this.label25.TabIndex = 1;
            // 
            // tacStrActRoPlateau
            // 
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown38);
            this.tacStrActRoPlateau.Controls.Add(this.label60);
            this.tacStrActRoPlateau.Controls.Add(this.label59);
            this.tacStrActRoPlateau.Controls.Add(this.label58);
            this.tacStrActRoPlateau.Controls.Add(this.label57);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown37);
            this.tacStrActRoPlateau.Controls.Add(this.label56);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown36);
            this.tacStrActRoPlateau.Controls.Add(this.label55);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown35);
            this.tacStrActRoPlateau.Controls.Add(this.label54);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown34);
            this.tacStrActRoPlateau.Controls.Add(this.label53);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown33);
            this.tacStrActRoPlateau.Controls.Add(this.label52);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown32);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown31);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown30);
            this.tacStrActRoPlateau.Controls.Add(this.label49);
            this.tacStrActRoPlateau.Controls.Add(this.label48);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown29);
            this.tacStrActRoPlateau.Controls.Add(this.label47);
            this.tacStrActRoPlateau.Controls.Add(this.numericUpDown28);
            this.tacStrActRoPlateau.Controls.Add(this.label29);
            this.tacStrActRoPlateau.Controls.Add(this.label28);
            this.tacStrActRoPlateau.Controls.Add(this.label27);
            this.tacStrActRoPlateau.Controls.Add(this.label26);
            this.tacStrActRoPlateau.Controls.Add(this.label50);
            this.tacStrActRoPlateau.Controls.Add(this.label51);
            this.tacStrActRoPlateau.Controls.Add(this.spcStrActRoboPlaConsImage);
            this.tacStrActRoPlateau.Location = new System.Drawing.Point(4, 22);
            this.tacStrActRoPlateau.Name = "tacStrActRoPlateau";
            this.tacStrActRoPlateau.Padding = new System.Windows.Forms.Padding(3);
            this.tacStrActRoPlateau.Size = new System.Drawing.Size(1166, 102);
            this.tacStrActRoPlateau.TabIndex = 3;
            this.tacStrActRoPlateau.Text = "Action robot plateau";
            this.tacStrActRoPlateau.UseVisualStyleBackColor = true;
            // 
            // numericUpDown38
            // 
            this.numericUpDown38.Location = new System.Drawing.Point(618, 27);
            this.numericUpDown38.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown38.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown38.Name = "numericUpDown38";
            this.numericUpDown38.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown38.TabIndex = 31;
            this.numericUpDown38.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(555, 39);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(57, 13);
            this.label60.TabIndex = 30;
            this.label60.Text = "donnatrice";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(523, 24);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(90, 13);
            this.label59.TabIndex = 29;
            this.label59.Text = "Emplacement pile";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(375, 73);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(59, 13);
            this.label58.TabIndex = 28;
            this.label58.Text = "Receptrice";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(377, 40);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(57, 13);
            this.label57.TabIndex = 27;
            this.label57.Text = "donnatrice";
            // 
            // numericUpDown37
            // 
            this.numericUpDown37.Location = new System.Drawing.Point(437, 64);
            this.numericUpDown37.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown37.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown37.Name = "numericUpDown37";
            this.numericUpDown37.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown37.TabIndex = 26;
            this.numericUpDown37.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(344, 60);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(90, 13);
            this.label56.TabIndex = 25;
            this.label56.Text = "Emplacement pile";
            // 
            // numericUpDown36
            // 
            this.numericUpDown36.Location = new System.Drawing.Point(437, 32);
            this.numericUpDown36.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown36.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown36.Name = "numericUpDown36";
            this.numericUpDown36.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown36.TabIndex = 24;
            this.numericUpDown36.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(344, 27);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(90, 13);
            this.label55.TabIndex = 23;
            this.label55.Text = "Emplacement pile";
            // 
            // numericUpDown35
            // 
            this.numericUpDown35.Location = new System.Drawing.Point(278, 71);
            this.numericUpDown35.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown35.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown35.Name = "numericUpDown35";
            this.numericUpDown35.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown35.TabIndex = 22;
            this.numericUpDown35.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(191, 73);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(81, 13);
            this.label54.TabIndex = 21;
            this.label54.Text = "Hateur du depo";
            // 
            // numericUpDown34
            // 
            this.numericUpDown34.Location = new System.Drawing.Point(278, 45);
            this.numericUpDown34.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown34.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown34.Name = "numericUpDown34";
            this.numericUpDown34.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown34.TabIndex = 20;
            this.numericUpDown34.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(203, 48);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(69, 13);
            this.label53.TabIndex = 19;
            this.label53.Text = "nb a deposer";
            // 
            // numericUpDown33
            // 
            this.numericUpDown33.Location = new System.Drawing.Point(278, 19);
            this.numericUpDown33.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown33.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown33.Name = "numericUpDown33";
            this.numericUpDown33.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown33.TabIndex = 18;
            this.numericUpDown33.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(182, 24);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(90, 13);
            this.label52.TabIndex = 17;
            this.label52.Text = "Emplacement pile";
            // 
            // numericUpDown32
            // 
            this.numericUpDown32.Location = new System.Drawing.Point(103, 78);
            this.numericUpDown32.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown32.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown32.Name = "numericUpDown32";
            this.numericUpDown32.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown32.TabIndex = 14;
            this.numericUpDown32.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown31
            // 
            this.numericUpDown31.Location = new System.Drawing.Point(56, 78);
            this.numericUpDown31.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown31.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown31.Name = "numericUpDown31";
            this.numericUpDown31.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown31.TabIndex = 13;
            this.numericUpDown31.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown30
            // 
            this.numericUpDown30.Location = new System.Drawing.Point(9, 78);
            this.numericUpDown30.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown30.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown30.Name = "numericUpDown30";
            this.numericUpDown30.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown30.TabIndex = 12;
            this.numericUpDown30.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(14, 62);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(93, 13);
            this.label49.TabIndex = 11;
            this.label49.Text = "Emplacement final";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(14, 43);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 13);
            this.label48.TabIndex = 10;
            this.label48.Text = "nb a reucpere";
            // 
            // numericUpDown29
            // 
            this.numericUpDown29.Location = new System.Drawing.Point(93, 39);
            this.numericUpDown29.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown29.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown29.Name = "numericUpDown29";
            this.numericUpDown29.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown29.TabIndex = 9;
            this.numericUpDown29.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 21);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(81, 13);
            this.label47.TabIndex = 8;
            this.label47.Text = "Hauteur de pille";
            // 
            // numericUpDown28
            // 
            this.numericUpDown28.Location = new System.Drawing.Point(93, 19);
            this.numericUpDown28.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown28.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown28.Name = "numericUpDown28";
            this.numericUpDown28.Size = new System.Drawing.Size(31, 20);
            this.numericUpDown28.TabIndex = 7;
            this.numericUpDown28.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(523, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(74, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Depose serise";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(340, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(142, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Echange deux emplacement";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(182, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(92, 13);
            this.label27.TabIndex = 3;
            this.label27.Text = "Deposer un etage";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 3);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(123, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Recuperai etage au sole";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(40, 80);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(16, 13);
            this.label50.TabIndex = 15;
            this.label50.Text = "->";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(87, 80);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(16, 13);
            this.label51.TabIndex = 16;
            this.label51.Text = "->";
            // 
            // spcStrActRoboPlaConsImage
            // 
            this.spcStrActRoboPlaConsImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStrActRoboPlaConsImage.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcStrActRoboPlaConsImage.Location = new System.Drawing.Point(3, 3);
            this.spcStrActRoboPlaConsImage.Name = "spcStrActRoboPlaConsImage";
            // 
            // spcStrActRoboPlaConsImage.Panel1
            // 
            this.spcStrActRoboPlaConsImage.Panel1.Controls.Add(this.label62);
            this.spcStrActRoboPlaConsImage.Panel1.Controls.Add(this.label61);
            this.spcStrActRoboPlaConsImage.Panel1.Controls.Add(this.numericUpDown39);
            this.spcStrActRoboPlaConsImage.Panel1.Controls.Add(this.cbStrActRpDeclencheur);
            // 
            // spcStrActRoboPlaConsImage.Panel2
            // 
            this.spcStrActRoboPlaConsImage.Panel2.Controls.Add(this.spcStrActRoboPlaVisuImage);
            this.spcStrActRoboPlaConsImage.Size = new System.Drawing.Size(1160, 96);
            this.spcStrActRoboPlaConsImage.SplitterDistance = 851;
            this.spcStrActRoboPlaConsImage.TabIndex = 32;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(678, 3);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(68, 13);
            this.label62.TabIndex = 33;
            this.label62.Text = "Declancheur";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(678, 60);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(61, 13);
            this.label61.TabIndex = 33;
            this.label61.Text = "Temps (ms)";
            // 
            // numericUpDown39
            // 
            this.numericUpDown39.Location = new System.Drawing.Point(745, 56);
            this.numericUpDown39.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown39.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown39.Name = "numericUpDown39";
            this.numericUpDown39.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown39.TabIndex = 33;
            this.numericUpDown39.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbStrActRpDeclencheur
            // 
            this.cbStrActRpDeclencheur.FormattingEnabled = true;
            this.cbStrActRpDeclencheur.Items.AddRange(new object[] {
            "A la lecture",
            "Apre un sertin temp"});
            this.cbStrActRpDeclencheur.Location = new System.Drawing.Point(678, 28);
            this.cbStrActRpDeclencheur.Name = "cbStrActRpDeclencheur";
            this.cbStrActRpDeclencheur.Size = new System.Drawing.Size(121, 21);
            this.cbStrActRpDeclencheur.TabIndex = 1;
            // 
            // spcStrActRoboPlaVisuImage
            // 
            this.spcStrActRoboPlaVisuImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcStrActRoboPlaVisuImage.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spcStrActRoboPlaVisuImage.Location = new System.Drawing.Point(0, 0);
            this.spcStrActRoboPlaVisuImage.Name = "spcStrActRoboPlaVisuImage";
            // 
            // spcStrActRoboPlaVisuImage.Panel1
            // 
            this.spcStrActRoboPlaVisuImage.Panel1.Controls.Add(this.richTextBox3);
            // 
            // spcStrActRoboPlaVisuImage.Panel2
            // 
            this.spcStrActRoboPlaVisuImage.Panel2.Controls.Add(this.pictureBox1);
            this.spcStrActRoboPlaVisuImage.Size = new System.Drawing.Size(305, 96);
            this.spcStrActRoboPlaVisuImage.SplitterDistance = 240;
            this.spcStrActRoboPlaVisuImage.TabIndex = 0;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(240, 96);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 96);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // tacStrActionRoCata
            // 
            this.tacStrActionRoCata.Location = new System.Drawing.Point(4, 22);
            this.tacStrActionRoCata.Name = "tacStrActionRoCata";
            this.tacStrActionRoCata.Padding = new System.Windows.Forms.Padding(3);
            this.tacStrActionRoCata.Size = new System.Drawing.Size(1166, 102);
            this.tacStrActionRoCata.TabIndex = 4;
            this.tacStrActionRoCata.Text = " Action robo catapulte";
            this.tacStrActionRoCata.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 94);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Charger";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Envoie vers";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 65);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(89, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Suppression";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ajout apre";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajout fin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sauvegarde";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tapMainActionneur
            // 
            this.tapMainActionneur.Controls.Add(this.tacAct);
            this.tapMainActionneur.Location = new System.Drawing.Point(4, 22);
            this.tapMainActionneur.Margin = new System.Windows.Forms.Padding(2);
            this.tapMainActionneur.Name = "tapMainActionneur";
            this.tapMainActionneur.Padding = new System.Windows.Forms.Padding(2);
            this.tapMainActionneur.Size = new System.Drawing.Size(1359, 722);
            this.tapMainActionneur.TabIndex = 1;
            this.tapMainActionneur.Text = "Actionneur";
            this.tapMainActionneur.UseVisualStyleBackColor = true;
            // 
            // tacAct
            // 
            this.tacAct.Controls.Add(this.tacActCatapulte);
            this.tacAct.Controls.Add(this.tabPage5);
            this.tacAct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tacAct.Location = new System.Drawing.Point(2, 2);
            this.tacAct.Margin = new System.Windows.Forms.Padding(2);
            this.tacAct.Name = "tacAct";
            this.tacAct.SelectedIndex = 0;
            this.tacAct.Size = new System.Drawing.Size(1355, 718);
            this.tacAct.TabIndex = 0;
            // 
            // tacActCatapulte
            // 
            this.tacActCatapulte.Controls.Add(this.spcActCat);
            this.tacActCatapulte.Location = new System.Drawing.Point(4, 22);
            this.tacActCatapulte.Margin = new System.Windows.Forms.Padding(2);
            this.tacActCatapulte.Name = "tacActCatapulte";
            this.tacActCatapulte.Padding = new System.Windows.Forms.Padding(2);
            this.tacActCatapulte.Size = new System.Drawing.Size(1347, 692);
            this.tacActCatapulte.TabIndex = 0;
            this.tacActCatapulte.Text = "Catapulte";
            this.tacActCatapulte.UseVisualStyleBackColor = true;
            // 
            // spcActCat
            // 
            this.spcActCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcActCat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcActCat.IsSplitterFixed = true;
            this.spcActCat.Location = new System.Drawing.Point(2, 2);
            this.spcActCat.Name = "spcActCat";
            // 
            // spcActCat.Panel1
            // 
            this.spcActCat.Panel1.AutoScroll = true;
            this.spcActCat.Panel1.AutoScrollMinSize = new System.Drawing.Size(337, 572);
            this.spcActCat.Panel1.Controls.Add(this.bPActCat1Foie);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatTireNbPas);
            this.spcActCat.Panel1.Controls.Add(this.label1);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatnBPasCalc);
            this.spcActCat.Panel1.Controls.Add(this.label2);
            this.spcActCat.Panel1.Controls.Add(this.label18);
            this.spcActCat.Panel1.Controls.Add(this.label3);
            this.spcActCat.Panel1.Controls.Add(this.label17);
            this.spcActCat.Panel1.Controls.Add(this.label4);
            this.spcActCat.Panel1.Controls.Add(this.bpActCatVitOptiAR);
            this.spcActCat.Panel1.Controls.Add(this.label5);
            this.spcActCat.Panel1.Controls.Add(this.bpActCatVitOptiAV);
            this.spcActCat.Panel1.Controls.Add(this.label13);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatTemps);
            this.spcActCat.Panel1.Controls.Add(this.label14);
            this.spcActCat.Panel1.Controls.Add(this.label16);
            this.spcActCat.Panel1.Controls.Add(this.label15);
            this.spcActCat.Panel1.Controls.Add(this.bpActCataFairenbPasArrier);
            this.spcActCat.Panel1.Controls.Add(this.label6);
            this.spcActCat.Panel1.Controls.Add(this.bpActCataFairenbPasAvan);
            this.spcActCat.Panel1.Controls.Add(this.label7);
            this.spcActCat.Panel1.Controls.Add(this.bpActCatDemarer);
            this.spcActCat.Panel1.Controls.Add(this.label8);
            this.spcActCat.Panel1.Controls.Add(this.label9);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatVitesseArrier);
            this.spcActCat.Panel1.Controls.Add(this.label12);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatVittesseAvan);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatNbFoie);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatAccelerationArrier);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatnBPas);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatAccelerationAvant);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatAttenteRepo);
            this.spcActCat.Panel1.Controls.Add(this.nupActCatAttenteChargemnt);
            this.spcActCat.Panel1MinSize = 337;
            // 
            // spcActCat.Panel2
            // 
            this.spcActCat.Panel2.Controls.Add(this.rtbActCatDebug);
            this.spcActCat.Panel2MinSize = 800;
            this.spcActCat.Size = new System.Drawing.Size(1343, 688);
            this.spcActCat.SplitterDistance = 350;
            this.spcActCat.TabIndex = 17;
            // 
            // bPActCat1Foie
            // 
            this.bPActCat1Foie.Location = new System.Drawing.Point(213, 277);
            this.bPActCat1Foie.Margin = new System.Windows.Forms.Padding(2);
            this.bPActCat1Foie.Name = "bPActCat1Foie";
            this.bPActCat1Foie.Size = new System.Drawing.Size(97, 23);
            this.bPActCat1Foie.TabIndex = 6;
            this.bPActCat1Foie.Text = "1 foie";
            this.bPActCat1Foie.UseVisualStyleBackColor = true;
            this.bPActCat1Foie.Click += new System.EventHandler(this.bPActCat1Foie_Click);
            // 
            // nupActCatTireNbPas
            // 
            this.nupActCatTireNbPas.Location = new System.Drawing.Point(104, 197);
            this.nupActCatTireNbPas.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatTireNbPas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatTireNbPas.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nupActCatTireNbPas.Name = "nupActCatTireNbPas";
            this.nupActCatTireNbPas.Size = new System.Drawing.Size(90, 20);
            this.nupActCatTireNbPas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avant";
            // 
            // nupActCatnBPasCalc
            // 
            this.nupActCatnBPasCalc.Location = new System.Drawing.Point(104, 478);
            this.nupActCatnBPasCalc.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatnBPasCalc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatnBPasCalc.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nupActCatnBPasCalc.Name = "nupActCatnBPasCalc";
            this.nupActCatnBPasCalc.Size = new System.Drawing.Size(90, 20);
            this.nupActCatnBPasCalc.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrier";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 479);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "nbPas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vittesse";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(143, 445);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Set vitesse optimisée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Acceleration";
            // 
            // bpActCatVitOptiAR
            // 
            this.bpActCatVitOptiAR.Location = new System.Drawing.Point(213, 503);
            this.bpActCatVitOptiAR.Name = "bpActCatVitOptiAR";
            this.bpActCatVitOptiAR.Size = new System.Drawing.Size(97, 23);
            this.bpActCatVitOptiAR.TabIndex = 12;
            this.bpActCatVitOptiAR.Text = "Set Arrier";
            this.bpActCatVitOptiAR.UseVisualStyleBackColor = true;
            this.bpActCatVitOptiAR.Click += new System.EventHandler(this.bpActCatVitOptiAR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Attente chr (sec)";
            // 
            // bpActCatVitOptiAV
            // 
            this.bpActCatVitOptiAV.Location = new System.Drawing.Point(213, 478);
            this.bpActCatVitOptiAV.Margin = new System.Windows.Forms.Padding(2);
            this.bpActCatVitOptiAV.Name = "bpActCatVitOptiAV";
            this.bpActCatVitOptiAV.Size = new System.Drawing.Size(97, 23);
            this.bpActCatVitOptiAV.TabIndex = 11;
            this.bpActCatVitOptiAV.Text = "Set Avant";
            this.bpActCatVitOptiAV.UseVisualStyleBackColor = true;
            this.bpActCatVitOptiAV.Click += new System.EventHandler(this.bpActCatVitOptiAV_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Parametrage";
            // 
            // nupActCatTemps
            // 
            this.nupActCatTemps.Location = new System.Drawing.Point(104, 502);
            this.nupActCatTemps.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatTemps.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nupActCatTemps.Name = "nupActCatTemps";
            this.nupActCatTemps.Size = new System.Drawing.Size(90, 20);
            this.nupActCatTemps.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(165, 144);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Catapultage";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 508);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Temps (ms)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(165, 346);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Action simple";
            // 
            // bpActCataFairenbPasArrier
            // 
            this.bpActCataFairenbPasArrier.Location = new System.Drawing.Point(213, 397);
            this.bpActCataFairenbPasArrier.Name = "bpActCataFairenbPasArrier";
            this.bpActCataFairenbPasArrier.Size = new System.Drawing.Size(97, 23);
            this.bpActCataFairenbPasArrier.TabIndex = 8;
            this.bpActCataFairenbPasArrier.Text = "Arriere";
            this.bpActCataFairenbPasArrier.UseVisualStyleBackColor = true;
            this.bpActCataFairenbPasArrier.Click += new System.EventHandler(this.bpActCataFairenbPasArrier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "nb pas AV";
            // 
            // bpActCataFairenbPasAvan
            // 
            this.bpActCataFairenbPasAvan.Location = new System.Drawing.Point(213, 372);
            this.bpActCataFairenbPasAvan.Margin = new System.Windows.Forms.Padding(2);
            this.bpActCataFairenbPasAvan.Name = "bpActCataFairenbPasAvan";
            this.bpActCataFairenbPasAvan.Size = new System.Drawing.Size(97, 23);
            this.bpActCataFairenbPasAvan.TabIndex = 6;
            this.bpActCataFairenbPasAvan.Text = "Avan";
            this.bpActCataFairenbPasAvan.UseVisualStyleBackColor = true;
            this.bpActCataFairenbPasAvan.Click += new System.EventHandler(this.bpActCataFairenbPasAvan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Attente rep (sec)";
            // 
            // bpActCatDemarer
            // 
            this.bpActCatDemarer.Location = new System.Drawing.Point(213, 301);
            this.bpActCatDemarer.Margin = new System.Windows.Forms.Padding(2);
            this.bpActCatDemarer.Name = "bpActCatDemarer";
            this.bpActCatDemarer.Size = new System.Drawing.Size(97, 23);
            this.bpActCatDemarer.TabIndex = 6;
            this.bpActCatDemarer.Text = "Demaree";
            this.bpActCatDemarer.UseVisualStyleBackColor = true;
            this.bpActCatDemarer.Click += new System.EventHandler(this.bpActCatDemarer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "nb pas Ar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 304);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre de foie";
            // 
            // nupActCatVitesseArrier
            // 
            this.nupActCatVitesseArrier.Location = new System.Drawing.Point(220, 69);
            this.nupActCatVitesseArrier.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatVitesseArrier.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupActCatVitesseArrier.Name = "nupActCatVitesseArrier";
            this.nupActCatVitesseArrier.Size = new System.Drawing.Size(90, 20);
            this.nupActCatVitesseArrier.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 386);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "nbPas";
            // 
            // nupActCatVittesseAvan
            // 
            this.nupActCatVittesseAvan.Location = new System.Drawing.Point(104, 68);
            this.nupActCatVittesseAvan.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatVittesseAvan.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupActCatVittesseAvan.Name = "nupActCatVittesseAvan";
            this.nupActCatVittesseAvan.Size = new System.Drawing.Size(90, 20);
            this.nupActCatVittesseAvan.TabIndex = 5;
            // 
            // nupActCatNbFoie
            // 
            this.nupActCatNbFoie.Location = new System.Drawing.Point(104, 304);
            this.nupActCatNbFoie.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatNbFoie.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatNbFoie.Name = "nupActCatNbFoie";
            this.nupActCatNbFoie.Size = new System.Drawing.Size(90, 20);
            this.nupActCatNbFoie.TabIndex = 5;
            // 
            // nupActCatAccelerationArrier
            // 
            this.nupActCatAccelerationArrier.Location = new System.Drawing.Point(220, 91);
            this.nupActCatAccelerationArrier.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatAccelerationArrier.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupActCatAccelerationArrier.Name = "nupActCatAccelerationArrier";
            this.nupActCatAccelerationArrier.Size = new System.Drawing.Size(90, 20);
            this.nupActCatAccelerationArrier.TabIndex = 5;
            // 
            // nupActCatnBPas
            // 
            this.nupActCatnBPas.Location = new System.Drawing.Point(104, 385);
            this.nupActCatnBPas.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatnBPas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatnBPas.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nupActCatnBPas.Name = "nupActCatnBPas";
            this.nupActCatnBPas.Size = new System.Drawing.Size(90, 20);
            this.nupActCatnBPas.TabIndex = 5;
            // 
            // nupActCatAccelerationAvant
            // 
            this.nupActCatAccelerationAvant.Location = new System.Drawing.Point(104, 91);
            this.nupActCatAccelerationAvant.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatAccelerationAvant.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nupActCatAccelerationAvant.Name = "nupActCatAccelerationAvant";
            this.nupActCatAccelerationAvant.Size = new System.Drawing.Size(90, 20);
            this.nupActCatAccelerationAvant.TabIndex = 5;
            // 
            // nupActCatAttenteRepo
            // 
            this.nupActCatAttenteRepo.Location = new System.Drawing.Point(104, 218);
            this.nupActCatAttenteRepo.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatAttenteRepo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatAttenteRepo.Name = "nupActCatAttenteRepo";
            this.nupActCatAttenteRepo.Size = new System.Drawing.Size(90, 20);
            this.nupActCatAttenteRepo.TabIndex = 5;
            // 
            // nupActCatAttenteChargemnt
            // 
            this.nupActCatAttenteChargemnt.Location = new System.Drawing.Point(104, 173);
            this.nupActCatAttenteChargemnt.Margin = new System.Windows.Forms.Padding(2);
            this.nupActCatAttenteChargemnt.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupActCatAttenteChargemnt.Name = "nupActCatAttenteChargemnt";
            this.nupActCatAttenteChargemnt.Size = new System.Drawing.Size(90, 20);
            this.nupActCatAttenteChargemnt.TabIndex = 5;
            // 
            // rtbActCatDebug
            // 
            this.rtbActCatDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbActCatDebug.Location = new System.Drawing.Point(0, 0);
            this.rtbActCatDebug.Margin = new System.Windows.Forms.Padding(2);
            this.rtbActCatDebug.Name = "rtbActCatDebug";
            this.rtbActCatDebug.Size = new System.Drawing.Size(989, 688);
            this.rtbActCatDebug.TabIndex = 7;
            this.rtbActCatDebug.Text = "";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(1347, 692);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tacMainCommunication
            // 
            this.tacMainCommunication.Controls.Add(this.tacCom);
            this.tacMainCommunication.Location = new System.Drawing.Point(4, 22);
            this.tacMainCommunication.Margin = new System.Windows.Forms.Padding(2);
            this.tacMainCommunication.Name = "tacMainCommunication";
            this.tacMainCommunication.Padding = new System.Windows.Forms.Padding(2);
            this.tacMainCommunication.Size = new System.Drawing.Size(1359, 722);
            this.tacMainCommunication.TabIndex = 2;
            this.tacMainCommunication.Text = "Communication";
            this.tacMainCommunication.UseVisualStyleBackColor = true;
            // 
            // tacCom
            // 
            this.tacCom.Controls.Add(this.tacComBlutoose);
            this.tacCom.Controls.Add(this.tacComCan);
            this.tacCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tacCom.Location = new System.Drawing.Point(2, 2);
            this.tacCom.Margin = new System.Windows.Forms.Padding(2);
            this.tacCom.Name = "tacCom";
            this.tacCom.SelectedIndex = 0;
            this.tacCom.Size = new System.Drawing.Size(1355, 718);
            this.tacCom.TabIndex = 0;
            // 
            // tacComBlutoose
            // 
            this.tacComBlutoose.Controls.Add(this.spcComBluComandeVisue);
            this.tacComBlutoose.Location = new System.Drawing.Point(4, 22);
            this.tacComBlutoose.Margin = new System.Windows.Forms.Padding(2);
            this.tacComBlutoose.Name = "tacComBlutoose";
            this.tacComBlutoose.Padding = new System.Windows.Forms.Padding(2);
            this.tacComBlutoose.Size = new System.Drawing.Size(1347, 692);
            this.tacComBlutoose.TabIndex = 0;
            this.tacComBlutoose.Text = "Blutouse";
            this.tacComBlutoose.UseVisualStyleBackColor = true;
            // 
            // spcComBluComandeVisue
            // 
            this.spcComBluComandeVisue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcComBluComandeVisue.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcComBluComandeVisue.IsSplitterFixed = true;
            this.spcComBluComandeVisue.Location = new System.Drawing.Point(2, 2);
            this.spcComBluComandeVisue.Name = "spcComBluComandeVisue";
            this.spcComBluComandeVisue.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcComBluComandeVisue.Panel1
            // 
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.txbComBluMessageEnvoie);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.bpComBluEnvoieTrame);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.nupComBluBaud);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.bpComBluRessetAfichage);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.bpComBluDemareComme);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.txbComBluPortCom);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.label10);
            this.spcComBluComandeVisue.Panel1.Controls.Add(this.label11);
            // 
            // spcComBluComandeVisue.Panel2
            // 
            this.spcComBluComandeVisue.Panel2.Controls.Add(this.rtbComBluDebug);
            this.spcComBluComandeVisue.Size = new System.Drawing.Size(1343, 688);
            this.spcComBluComandeVisue.SplitterDistance = 46;
            this.spcComBluComandeVisue.TabIndex = 5;
            // 
            // txbComBluMessageEnvoie
            // 
            this.txbComBluMessageEnvoie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbComBluMessageEnvoie.Location = new System.Drawing.Point(0, 26);
            this.txbComBluMessageEnvoie.Margin = new System.Windows.Forms.Padding(2);
            this.txbComBluMessageEnvoie.Name = "txbComBluMessageEnvoie";
            this.txbComBluMessageEnvoie.Size = new System.Drawing.Size(1343, 20);
            this.txbComBluMessageEnvoie.TabIndex = 3;
            // 
            // bpComBluEnvoieTrame
            // 
            this.bpComBluEnvoieTrame.Location = new System.Drawing.Point(466, 2);
            this.bpComBluEnvoieTrame.Margin = new System.Windows.Forms.Padding(2);
            this.bpComBluEnvoieTrame.Name = "bpComBluEnvoieTrame";
            this.bpComBluEnvoieTrame.Size = new System.Drawing.Size(56, 19);
            this.bpComBluEnvoieTrame.TabIndex = 2;
            this.bpComBluEnvoieTrame.Text = "Envoie de la trame";
            this.bpComBluEnvoieTrame.UseVisualStyleBackColor = true;
            this.bpComBluEnvoieTrame.Click += new System.EventHandler(this.bpComBluEnvoieTrame_Click);
            // 
            // nupComBluBaud
            // 
            this.nupComBluBaud.Location = new System.Drawing.Point(193, 1);
            this.nupComBluBaud.Margin = new System.Windows.Forms.Padding(2);
            this.nupComBluBaud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nupComBluBaud.Name = "nupComBluBaud";
            this.nupComBluBaud.Size = new System.Drawing.Size(90, 20);
            this.nupComBluBaud.TabIndex = 4;
            this.nupComBluBaud.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // bpComBluRessetAfichage
            // 
            this.bpComBluRessetAfichage.Location = new System.Drawing.Point(373, 2);
            this.bpComBluRessetAfichage.Margin = new System.Windows.Forms.Padding(2);
            this.bpComBluRessetAfichage.Name = "bpComBluRessetAfichage";
            this.bpComBluRessetAfichage.Size = new System.Drawing.Size(89, 19);
            this.bpComBluRessetAfichage.TabIndex = 2;
            this.bpComBluRessetAfichage.Text = "Reset affichage";
            this.bpComBluRessetAfichage.UseVisualStyleBackColor = true;
            this.bpComBluRessetAfichage.Click += new System.EventHandler(this.bpComBluRessetAfichage_Click);
            // 
            // bpComBluDemareComme
            // 
            this.bpComBluDemareComme.Location = new System.Drawing.Point(287, 2);
            this.bpComBluDemareComme.Margin = new System.Windows.Forms.Padding(2);
            this.bpComBluDemareComme.Name = "bpComBluDemareComme";
            this.bpComBluDemareComme.Size = new System.Drawing.Size(82, 19);
            this.bpComBluDemareComme.TabIndex = 2;
            this.bpComBluDemareComme.Text = "Demare COM";
            this.bpComBluDemareComme.UseVisualStyleBackColor = true;
            this.bpComBluDemareComme.Click += new System.EventHandler(this.bpComBluDemareComme_Click);
            // 
            // txbComBluPortCom
            // 
            this.txbComBluPortCom.Location = new System.Drawing.Point(62, 1);
            this.txbComBluPortCom.Margin = new System.Windows.Forms.Padding(2);
            this.txbComBluPortCom.Name = "txbComBluPortCom";
            this.txbComBluPortCom.Size = new System.Drawing.Size(91, 20);
            this.txbComBluPortCom.TabIndex = 3;
            this.txbComBluPortCom.Text = "COM16";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port COM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(157, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Baud";
            // 
            // rtbComBluDebug
            // 
            this.rtbComBluDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbComBluDebug.Location = new System.Drawing.Point(0, 0);
            this.rtbComBluDebug.Margin = new System.Windows.Forms.Padding(2);
            this.rtbComBluDebug.Name = "rtbComBluDebug";
            this.rtbComBluDebug.Size = new System.Drawing.Size(1343, 638);
            this.rtbComBluDebug.TabIndex = 0;
            this.rtbComBluDebug.Text = "";
            // 
            // tacComCan
            // 
            this.tacComCan.Location = new System.Drawing.Point(4, 22);
            this.tacComCan.Margin = new System.Windows.Forms.Padding(2);
            this.tacComCan.Name = "tacComCan";
            this.tacComCan.Padding = new System.Windows.Forms.Padding(2);
            this.tacComCan.Size = new System.Drawing.Size(1347, 692);
            this.tacComCan.TabIndex = 1;
            this.tacComCan.Text = "Can";
            this.tacComCan.UseVisualStyleBackColor = true;
            // 
            // tapSimulation
            // 
            this.tapSimulation.Location = new System.Drawing.Point(4, 22);
            this.tapSimulation.Name = "tapSimulation";
            this.tapSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.tapSimulation.Size = new System.Drawing.Size(1359, 722);
            this.tapSimulation.TabIndex = 3;
            this.tapSimulation.Text = "Simulation";
            this.tapSimulation.UseVisualStyleBackColor = true;
            // 
            // bpActCatArree
            // 
            this.bpActCatArree.Location = new System.Drawing.Point(41, 66);
            this.bpActCatArree.Name = "bpActCatArree";
            this.bpActCatArree.Size = new System.Drawing.Size(120, 23);
            this.bpActCatArree.TabIndex = 6;
            this.bpActCatArree.Text = "Arret";
            this.bpActCatArree.UseVisualStyleBackColor = true;
            this.bpActCatArree.Click += new System.EventHandler(this.bpActCatArree_Click);
            // 
            // FenetrePrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 748);
            this.Controls.Add(this.tacMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FenetrePrincipale";
            this.Text = "Getionere de robot";
            this.tacMain.ResumeLayout(false);
            this.tapMainStr.ResumeLayout(false);
            this.spcStrHorisontal.Panel1.ResumeLayout(false);
            this.spcStrHorisontal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStrHorisontal)).EndInit();
            this.spcStrHorisontal.ResumeLayout(false);
            this.spcStrMapTreeView.Panel1.ResumeLayout(false);
            this.spcStrMapTreeView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStrMapTreeView)).EndInit();
            this.spcStrMapTreeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStrTable)).EndInit();
            this.tctStrVueStrategie.ResumeLayout(false);
            this.pjStrVueArbre.ResumeLayout(false);
            this.pjStrVueChekBox.ResumeLayout(false);
            this.pjStrVueTxt.ResumeLayout(false);
            this.spcEditeBp.Panel1.ResumeLayout(false);
            this.spcEditeBp.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcEditeBp)).EndInit();
            this.spcEditeBp.ResumeLayout(false);
            this.tbcStrConfigurateur.ResumeLayout(false);
            this.pjStrConfiguration.ResumeLayout(false);
            this.pjStrConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.pjStrConDeplacement.ResumeLayout(false);
            this.pjStrConDeplacement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.spcStrDepPrepaVisu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStrDepPrepaVisu)).EndInit();
            this.spcStrDepPrepaVisu.ResumeLayout(false);
            this.tacStrActRoPlateau.ResumeLayout(false);
            this.tacStrActRoPlateau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown28)).EndInit();
            this.spcStrActRoboPlaConsImage.Panel1.ResumeLayout(false);
            this.spcStrActRoboPlaConsImage.Panel1.PerformLayout();
            this.spcStrActRoboPlaConsImage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStrActRoboPlaConsImage)).EndInit();
            this.spcStrActRoboPlaConsImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown39)).EndInit();
            this.spcStrActRoboPlaVisuImage.Panel1.ResumeLayout(false);
            this.spcStrActRoboPlaVisuImage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcStrActRoboPlaVisuImage)).EndInit();
            this.spcStrActRoboPlaVisuImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tapMainActionneur.ResumeLayout(false);
            this.tacAct.ResumeLayout(false);
            this.tacActCatapulte.ResumeLayout(false);
            this.spcActCat.Panel1.ResumeLayout(false);
            this.spcActCat.Panel1.PerformLayout();
            this.spcActCat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcActCat)).EndInit();
            this.spcActCat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatTireNbPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatnBPasCalc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatTemps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatVitesseArrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatVittesseAvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatNbFoie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAccelerationArrier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatnBPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAccelerationAvant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAttenteRepo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupActCatAttenteChargemnt)).EndInit();
            this.tacMainCommunication.ResumeLayout(false);
            this.tacCom.ResumeLayout(false);
            this.tacComBlutoose.ResumeLayout(false);
            this.spcComBluComandeVisue.Panel1.ResumeLayout(false);
            this.spcComBluComandeVisue.Panel1.PerformLayout();
            this.spcComBluComandeVisue.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcComBluComandeVisue)).EndInit();
            this.spcComBluComandeVisue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupComBluBaud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tacMain;
        private System.Windows.Forms.TabPage tapMainStr;
        private System.Windows.Forms.TabPage tapMainActionneur;
        private System.Windows.Forms.TabPage tacMainCommunication;
        private System.Windows.Forms.TabControl tacAct;
        private System.Windows.Forms.TabPage tacActCatapulte;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox rtbActCatDebug;
        private System.Windows.Forms.Button bpActCatDemarer;
        private System.Windows.Forms.Button bpActCatArree;
        private System.Windows.Forms.Button bPActCat1Foie;
        private System.Windows.Forms.NumericUpDown nupActCatVitesseArrier;
        private System.Windows.Forms.NumericUpDown nupActCatVittesseAvan;
        private System.Windows.Forms.NumericUpDown nupActCatAccelerationArrier;
        private System.Windows.Forms.NumericUpDown nupActCatAccelerationAvant;
        private System.Windows.Forms.NumericUpDown nupActCatAttenteChargemnt;
        private System.Windows.Forms.NumericUpDown nupActCatAttenteRepo;
        private System.Windows.Forms.NumericUpDown nupActCatNbFoie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tacCom;
        private System.Windows.Forms.TabPage tacComBlutoose;
        private System.Windows.Forms.TabPage tacComCan;
        private System.Windows.Forms.NumericUpDown nupComBluBaud;
        private System.Windows.Forms.TextBox txbComBluPortCom;
        private System.Windows.Forms.TextBox txbComBluMessageEnvoie;
        private System.Windows.Forms.Button bpComBluEnvoieTrame;
        private System.Windows.Forms.Button bpComBluRessetAfichage;
        private System.Windows.Forms.Button bpComBluDemareComme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbComBluDebug;
        private System.Windows.Forms.Button bpActCataFairenbPasAvan;
        private System.Windows.Forms.NumericUpDown nupActCatnBPas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bpActCataFairenbPasArrier;
        private System.Windows.Forms.Button bpActCatVitOptiAR;
        private System.Windows.Forms.Button bpActCatVitOptiAV;
        private System.Windows.Forms.NumericUpDown nupActCatTemps;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nupActCatTireNbPas;
        private System.Windows.Forms.NumericUpDown nupActCatnBPasCalc;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.SplitContainer spcStrHorisontal;
        private System.Windows.Forms.SplitContainer spcStrMapTreeView;
        private System.Windows.Forms.SplitContainer spcEditeBp;
        private System.Windows.Forms.SplitContainer spcActCat;
        private System.Windows.Forms.TabControl tctStrVueStrategie;
        private System.Windows.Forms.TabPage pjStrVueArbre;
        private System.Windows.Forms.TabPage pjStrVueChekBox;
        private System.Windows.Forms.TabControl tbcStrConfigurateur;
        private System.Windows.Forms.TabPage pjStrConfiguration;
        private System.Windows.Forms.TabPage pjStrConDeplacement;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer spcComBluComandeVisue;
        private System.Windows.Forms.PictureBox picStrTable;
        private System.Windows.Forms.TabPage pjStrVueTxt;
        private System.Windows.Forms.TreeView trvStrAbr;
        private System.Windows.Forms.CheckedListBox chbStrChe;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown9;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.NumericUpDown numericUpDown7;
        private System.Windows.Forms.NumericUpDown numericUpDown8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox chbStrDepCourbedebesier;
        private System.Windows.Forms.CheckBox chbStrDepRecalage;
        private System.Windows.Forms.CheckBox chbStrDepDeplacement;
        private System.Windows.Forms.CheckBox chbStrDepDeplacementXY;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.TabPage tacStrActRoPlateau;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numericUpDown14;
        private System.Windows.Forms.NumericUpDown numericUpDown13;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.NumericUpDown numericUpDown16;
        private System.Windows.Forms.NumericUpDown numericUpDown15;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.NumericUpDown numericUpDown12;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown numericUpDown18;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.NumericUpDown numericUpDown17;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chbStrDepArcdecercle;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.NumericUpDown numericUpDown20;
        private System.Windows.Forms.NumericUpDown numericUpDown19;
        private System.Windows.Forms.NumericUpDown numericUpDown24;
        private System.Windows.Forms.NumericUpDown numericUpDown23;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown numericUpDown21;
        private System.Windows.Forms.NumericUpDown numericUpDown22;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.NumericUpDown numericUpDown26;
        private System.Windows.Forms.NumericUpDown numericUpDown27;
        private System.Windows.Forms.NumericUpDown numericUpDown25;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.SplitContainer spcStrDepPrepaVisu;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown38;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.NumericUpDown numericUpDown37;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown numericUpDown36;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numericUpDown35;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.NumericUpDown numericUpDown34;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.NumericUpDown numericUpDown33;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.NumericUpDown numericUpDown32;
        private System.Windows.Forms.NumericUpDown numericUpDown31;
        private System.Windows.Forms.NumericUpDown numericUpDown30;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.NumericUpDown numericUpDown29;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.NumericUpDown numericUpDown28;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.SplitContainer spcStrActRoboPlaConsImage;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.NumericUpDown numericUpDown39;
        private System.Windows.Forms.ComboBox cbStrActRpDeclencheur;
        private System.Windows.Forms.SplitContainer spcStrActRoboPlaVisuImage;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown43;
        private System.Windows.Forms.NumericUpDown numericUpDown44;
        private System.Windows.Forms.NumericUpDown numericUpDown45;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.NumericUpDown numericUpDown40;
        private System.Windows.Forms.NumericUpDown numericUpDown41;
        private System.Windows.Forms.NumericUpDown numericUpDown42;
        private System.Windows.Forms.TabPage tacStrActionRoCata;
        private System.Windows.Forms.TabPage tapSimulation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label63;
    }
}

