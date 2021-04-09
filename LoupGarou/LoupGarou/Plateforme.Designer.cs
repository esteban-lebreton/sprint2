namespace LoupGarou
{
    partial class Plateforme
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
            this.gb_Vote = new System.Windows.Forms.GroupBox();
            this.cb_Vote = new System.Windows.Forms.ComboBox();
            this.bt_2 = new System.Windows.Forms.Button();
            this.tc_Client = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_4 = new System.Windows.Forms.Button();
            this.bt_3 = new System.Windows.Forms.Button();
            this.gb_ForumL = new System.Windows.Forms.GroupBox();
            this.tb_leMessageFL = new System.Windows.Forms.TextBox();
            this.lb_lesMessagesFL = new System.Windows.Forms.ListBox();
            this.gb_ForumV = new System.Windows.Forms.GroupBox();
            this.tb_leMessageFV = new System.Windows.Forms.TextBox();
            this.lb_lesMessagesV = new System.Windows.Forms.ListBox();
            this.gb_Narration = new System.Windows.Forms.GroupBox();
            this.l_Narration = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rb_OSalle = new System.Windows.Forms.RadioButton();
            this.rb_RSalle = new System.Windows.Forms.RadioButton();
            this.p_OSalle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Capacite = new System.Windows.Forms.TextBox();
            this.tb_PortPOS = new System.Windows.Forms.TextBox();
            this.tb_AdresseSOS = new System.Windows.Forms.TextBox();
            this.p_RSalle = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_AdresseCRS = new System.Windows.Forms.TextBox();
            this.tb_PortCRs = new System.Windows.Forms.TextBox();
            this.tb_AdresseSRS = new System.Windows.Forms.TextBox();
            this.bt_1 = new System.Windows.Forms.Button();
            this.bt_5 = new System.Windows.Forms.Button();
            this.gb_Reseau = new System.Windows.Forms.GroupBox();
            this.tb_leMessageR = new System.Windows.Forms.TextBox();
            this.lb_lesMessagesR = new System.Windows.Forms.ListBox();
            this.laPlateforme = new System.Windows.Forms.GroupBox();
            this.gb_Vote.SuspendLayout();
            this.tc_Client.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_ForumL.SuspendLayout();
            this.gb_ForumV.SuspendLayout();
            this.gb_Narration.SuspendLayout();
            this.p_OSalle.SuspendLayout();
            this.p_RSalle.SuspendLayout();
            this.gb_Reseau.SuspendLayout();
            this.laPlateforme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Vote
            // 
            this.gb_Vote.Controls.Add(this.cb_Vote);
            this.gb_Vote.Controls.Add(this.bt_2);
            this.gb_Vote.Location = new System.Drawing.Point(24, 182);
            this.gb_Vote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Vote.Name = "gb_Vote";
            this.gb_Vote.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Vote.Size = new System.Drawing.Size(307, 138);
            this.gb_Vote.TabIndex = 0;
            this.gb_Vote.TabStop = false;
            this.gb_Vote.Text = "Vote";
            // 
            // cb_Vote
            // 
            this.cb_Vote.FormattingEnabled = true;
            this.cb_Vote.Location = new System.Drawing.Point(36, 42);
            this.cb_Vote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Vote.Name = "cb_Vote";
            this.cb_Vote.Size = new System.Drawing.Size(227, 24);
            this.cb_Vote.TabIndex = 9;
            // 
            // bt_2
            // 
            this.bt_2.Location = new System.Drawing.Point(36, 86);
            this.bt_2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_2.Name = "bt_2";
            this.bt_2.Size = new System.Drawing.Size(228, 30);
            this.bt_2.TabIndex = 6;
            this.bt_2.Text = "VALIDER";
            this.bt_2.UseVisualStyleBackColor = true;
            // 
            // tc_Client
            // 
            this.tc_Client.Controls.Add(this.tabPage1);
            this.tc_Client.Controls.Add(this.tabPage2);
            this.tc_Client.Controls.Add(this.tabPage3);
            this.tc_Client.Location = new System.Drawing.Point(20, 347);
            this.tc_Client.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tc_Client.Name = "tc_Client";
            this.tc_Client.SelectedIndex = 0;
            this.tc_Client.Size = new System.Drawing.Size(748, 359);
            this.tc_Client.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_4);
            this.tabPage1.Controls.Add(this.bt_3);
            this.tabPage1.Controls.Add(this.gb_ForumL);
            this.tabPage1.Controls.Add(this.gb_ForumV);
            this.tabPage1.Controls.Add(this.gb_Narration);
            this.tabPage1.Controls.Add(this.gb_Vote);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(740, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Accueil";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_4
            // 
            this.bt_4.Location = new System.Drawing.Point(552, 268);
            this.bt_4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_4.Name = "bt_4";
            this.bt_4.Size = new System.Drawing.Size(173, 30);
            this.bt_4.TabIndex = 8;
            this.bt_4.Text = "VALIDER";
            this.bt_4.UseVisualStyleBackColor = true;
            // 
            // bt_3
            // 
            this.bt_3.Location = new System.Drawing.Point(363, 268);
            this.bt_3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_3.Name = "bt_3";
            this.bt_3.Size = new System.Drawing.Size(168, 30);
            this.bt_3.TabIndex = 7;
            this.bt_3.Text = "VALIDER";
            this.bt_3.UseVisualStyleBackColor = true;
            // 
            // gb_ForumL
            // 
            this.gb_ForumL.Controls.Add(this.tb_leMessageFL);
            this.gb_ForumL.Controls.Add(this.lb_lesMessagesFL);
            this.gb_ForumL.Location = new System.Drawing.Point(552, 17);
            this.gb_ForumL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_ForumL.Name = "gb_ForumL";
            this.gb_ForumL.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_ForumL.Size = new System.Drawing.Size(173, 233);
            this.gb_ForumL.TabIndex = 1;
            this.gb_ForumL.TabStop = false;
            this.gb_ForumL.Text = "Forum des loups";
            // 
            // tb_leMessageFL
            // 
            this.tb_leMessageFL.Location = new System.Drawing.Point(20, 190);
            this.tb_leMessageFL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_leMessageFL.Name = "tb_leMessageFL";
            this.tb_leMessageFL.Size = new System.Drawing.Size(131, 22);
            this.tb_leMessageFL.TabIndex = 2;
            // 
            // lb_lesMessagesFL
            // 
            this.lb_lesMessagesFL.FormattingEnabled = true;
            this.lb_lesMessagesFL.ItemHeight = 16;
            this.lb_lesMessagesFL.Location = new System.Drawing.Point(20, 28);
            this.lb_lesMessagesFL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_lesMessagesFL.Name = "lb_lesMessagesFL";
            this.lb_lesMessagesFL.Size = new System.Drawing.Size(131, 148);
            this.lb_lesMessagesFL.TabIndex = 1;
            // 
            // gb_ForumV
            // 
            this.gb_ForumV.Controls.Add(this.tb_leMessageFV);
            this.gb_ForumV.Controls.Add(this.lb_lesMessagesV);
            this.gb_ForumV.Location = new System.Drawing.Point(363, 17);
            this.gb_ForumV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_ForumV.Name = "gb_ForumV";
            this.gb_ForumV.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_ForumV.Size = new System.Drawing.Size(168, 233);
            this.gb_ForumV.TabIndex = 1;
            this.gb_ForumV.TabStop = false;
            this.gb_ForumV.Text = "Forum des villageois";
            // 
            // tb_leMessageFV
            // 
            this.tb_leMessageFV.Location = new System.Drawing.Point(13, 190);
            this.tb_leMessageFV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_leMessageFV.Name = "tb_leMessageFV";
            this.tb_leMessageFV.Size = new System.Drawing.Size(131, 22);
            this.tb_leMessageFV.TabIndex = 1;
            // 
            // lb_lesMessagesV
            // 
            this.lb_lesMessagesV.FormattingEnabled = true;
            this.lb_lesMessagesV.ItemHeight = 16;
            this.lb_lesMessagesV.Location = new System.Drawing.Point(13, 28);
            this.lb_lesMessagesV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_lesMessagesV.Name = "lb_lesMessagesV";
            this.lb_lesMessagesV.Size = new System.Drawing.Size(131, 148);
            this.lb_lesMessagesV.TabIndex = 0;
            // 
            // gb_Narration
            // 
            this.gb_Narration.Controls.Add(this.l_Narration);
            this.gb_Narration.Location = new System.Drawing.Point(24, 17);
            this.gb_Narration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Narration.Name = "gb_Narration";
            this.gb_Narration.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Narration.Size = new System.Drawing.Size(307, 145);
            this.gb_Narration.TabIndex = 1;
            this.gb_Narration.TabStop = false;
            this.gb_Narration.Text = "Histoire";
            // 
            // l_Narration
            // 
            this.l_Narration.AutoSize = true;
            this.l_Narration.Location = new System.Drawing.Point(41, 71);
            this.l_Narration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Narration.Name = "l_Narration";
            this.l_Narration.Size = new System.Drawing.Size(224, 17);
            this.l_Narration.TabIndex = 11;
            this.l_Narration.Text = "Les loups mangent les villageois...";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(740, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Compte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(740, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Deconnexion";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rb_OSalle
            // 
            this.rb_OSalle.AutoSize = true;
            this.rb_OSalle.Location = new System.Drawing.Point(17, 17);
            this.rb_OSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_OSalle.Name = "rb_OSalle";
            this.rb_OSalle.Size = new System.Drawing.Size(165, 21);
            this.rb_OSalle.TabIndex = 2;
            this.rb_OSalle.TabStop = true;
            this.rb_OSalle.Text = "Ouverture d\'une salle";
            this.rb_OSalle.UseVisualStyleBackColor = true;
            this.rb_OSalle.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rb_RSalle
            // 
            this.rb_RSalle.AutoSize = true;
            this.rb_RSalle.Location = new System.Drawing.Point(17, 18);
            this.rb_RSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_RSalle.Name = "rb_RSalle";
            this.rb_RSalle.Size = new System.Drawing.Size(151, 21);
            this.rb_RSalle.TabIndex = 2;
            this.rb_RSalle.TabStop = true;
            this.rb_RSalle.Text = "Rejoindre une salle";
            this.rb_RSalle.UseVisualStyleBackColor = true;
            this.rb_RSalle.CheckedChanged += new System.EventHandler(this.rb_RSalle_CheckedChanged);
            // 
            // p_OSalle
            // 
            this.p_OSalle.Controls.Add(this.label3);
            this.p_OSalle.Controls.Add(this.label2);
            this.p_OSalle.Controls.Add(this.label1);
            this.p_OSalle.Controls.Add(this.tb_Capacite);
            this.p_OSalle.Controls.Add(this.tb_PortPOS);
            this.p_OSalle.Controls.Add(this.tb_AdresseSOS);
            this.p_OSalle.Controls.Add(this.rb_OSalle);
            this.p_OSalle.Location = new System.Drawing.Point(21, 23);
            this.p_OSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_OSalle.Name = "p_OSalle";
            this.p_OSalle.Size = new System.Drawing.Size(541, 95);
            this.p_OSalle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Capacité";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adresse serveur";
            // 
            // tb_Capacite
            // 
            this.tb_Capacite.Location = new System.Drawing.Point(439, 50);
            this.tb_Capacite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Capacite.Name = "tb_Capacite";
            this.tb_Capacite.Size = new System.Drawing.Size(75, 22);
            this.tb_Capacite.TabIndex = 5;
            // 
            // tb_PortPOS
            // 
            this.tb_PortPOS.Location = new System.Drawing.Point(280, 50);
            this.tb_PortPOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PortPOS.Name = "tb_PortPOS";
            this.tb_PortPOS.Size = new System.Drawing.Size(64, 22);
            this.tb_PortPOS.TabIndex = 4;
            // 
            // tb_AdresseSOS
            // 
            this.tb_AdresseSOS.Location = new System.Drawing.Point(127, 50);
            this.tb_AdresseSOS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AdresseSOS.Name = "tb_AdresseSOS";
            this.tb_AdresseSOS.Size = new System.Drawing.Size(101, 22);
            this.tb_AdresseSOS.TabIndex = 3;
            // 
            // p_RSalle
            // 
            this.p_RSalle.Controls.Add(this.label7);
            this.p_RSalle.Controls.Add(this.label6);
            this.p_RSalle.Controls.Add(this.label5);
            this.p_RSalle.Controls.Add(this.label4);
            this.p_RSalle.Controls.Add(this.tb_Login);
            this.p_RSalle.Controls.Add(this.tb_AdresseCRS);
            this.p_RSalle.Controls.Add(this.tb_PortCRs);
            this.p_RSalle.Controls.Add(this.tb_AdresseSRS);
            this.p_RSalle.Controls.Add(this.rb_RSalle);
            this.p_RSalle.Location = new System.Drawing.Point(21, 139);
            this.p_RSalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_RSalle.Name = "p_RSalle";
            this.p_RSalle.Size = new System.Drawing.Size(721, 110);
            this.p_RSalle.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Capacité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adresse client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adresse serveur";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(643, 62);
            this.tb_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(65, 22);
            this.tb_Login.TabIndex = 7;
            // 
            // tb_AdresseCRS
            // 
            this.tb_AdresseCRS.Location = new System.Drawing.Point(459, 62);
            this.tb_AdresseCRS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AdresseCRS.Name = "tb_AdresseCRS";
            this.tb_AdresseCRS.Size = new System.Drawing.Size(99, 22);
            this.tb_AdresseCRS.TabIndex = 6;
            // 
            // tb_PortCRs
            // 
            this.tb_PortCRs.Location = new System.Drawing.Point(280, 62);
            this.tb_PortCRs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PortCRs.Name = "tb_PortCRs";
            this.tb_PortCRs.Size = new System.Drawing.Size(64, 22);
            this.tb_PortCRs.TabIndex = 5;
            // 
            // tb_AdresseSRS
            // 
            this.tb_AdresseSRS.Location = new System.Drawing.Point(127, 62);
            this.tb_AdresseSRS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AdresseSRS.Name = "tb_AdresseSRS";
            this.tb_AdresseSRS.Size = new System.Drawing.Size(101, 22);
            this.tb_AdresseSRS.TabIndex = 4;
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(279, 271);
            this.bt_1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(193, 37);
            this.bt_1.TabIndex = 5;
            this.bt_1.Text = "VALIDER";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bt_5
            // 
            this.bt_5.Location = new System.Drawing.Point(28, 623);
            this.bt_5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_5.Name = "bt_5";
            this.bt_5.Size = new System.Drawing.Size(224, 30);
            this.bt_5.TabIndex = 9;
            this.bt_5.Text = "VALIDER";
            this.bt_5.UseVisualStyleBackColor = true;
            // 
            // gb_Reseau
            // 
            this.gb_Reseau.Controls.Add(this.tb_leMessageR);
            this.gb_Reseau.Controls.Add(this.lb_lesMessagesR);
            this.gb_Reseau.Controls.Add(this.bt_5);
            this.gb_Reseau.Location = new System.Drawing.Point(799, 20);
            this.gb_Reseau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Reseau.Name = "gb_Reseau";
            this.gb_Reseau.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Reseau.Size = new System.Drawing.Size(273, 687);
            this.gb_Reseau.TabIndex = 10;
            this.gb_Reseau.TabStop = false;
            this.gb_Reseau.Text = "Test réseau";
            // 
            // tb_leMessageR
            // 
            this.tb_leMessageR.Location = new System.Drawing.Point(28, 580);
            this.tb_leMessageR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_leMessageR.Name = "tb_leMessageR";
            this.tb_leMessageR.Size = new System.Drawing.Size(223, 22);
            this.tb_leMessageR.TabIndex = 11;
            // 
            // lb_lesMessagesR
            // 
            this.lb_lesMessagesR.FormattingEnabled = true;
            this.lb_lesMessagesR.ItemHeight = 16;
            this.lb_lesMessagesR.Location = new System.Drawing.Point(28, 36);
            this.lb_lesMessagesR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_lesMessagesR.Name = "lb_lesMessagesR";
            this.lb_lesMessagesR.Size = new System.Drawing.Size(223, 516);
            this.lb_lesMessagesR.TabIndex = 10;
            // 
            // laPlateforme
            // 
            this.laPlateforme.Controls.Add(this.p_RSalle);
            this.laPlateforme.Controls.Add(this.p_OSalle);
            this.laPlateforme.Controls.Add(this.bt_1);
            this.laPlateforme.Location = new System.Drawing.Point(20, 9);
            this.laPlateforme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laPlateforme.Name = "laPlateforme";
            this.laPlateforme.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.laPlateforme.Size = new System.Drawing.Size(748, 331);
            this.laPlateforme.TabIndex = 11;
            this.laPlateforme.TabStop = false;
            this.laPlateforme.Text = "Loup Garou";
            // 
            // Plateforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 731);
            this.Controls.Add(this.laPlateforme);
            this.Controls.Add(this.gb_Reseau);
            this.Controls.Add(this.tc_Client);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Plateforme";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Plateforme_Load);
            this.gb_Vote.ResumeLayout(false);
            this.tc_Client.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_ForumL.ResumeLayout(false);
            this.gb_ForumL.PerformLayout();
            this.gb_ForumV.ResumeLayout(false);
            this.gb_ForumV.PerformLayout();
            this.gb_Narration.ResumeLayout(false);
            this.gb_Narration.PerformLayout();
            this.p_OSalle.ResumeLayout(false);
            this.p_OSalle.PerformLayout();
            this.p_RSalle.ResumeLayout(false);
            this.p_RSalle.PerformLayout();
            this.gb_Reseau.ResumeLayout(false);
            this.gb_Reseau.PerformLayout();
            this.laPlateforme.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Vote;
        private System.Windows.Forms.TabControl tc_Client;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gb_ForumL;
        private System.Windows.Forms.GroupBox gb_ForumV;
        private System.Windows.Forms.GroupBox gb_Narration;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rb_OSalle;
        private System.Windows.Forms.RadioButton rb_RSalle;
        private System.Windows.Forms.Panel p_OSalle;
        private System.Windows.Forms.Panel p_RSalle;
        private System.Windows.Forms.TextBox tb_Capacite;
        private System.Windows.Forms.TextBox tb_PortPOS;
        private System.Windows.Forms.TextBox tb_AdresseSOS;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_AdresseCRS;
        private System.Windows.Forms.TextBox tb_PortCRs;
        private System.Windows.Forms.TextBox tb_AdresseSRS;
        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.ComboBox cb_Vote;
        private System.Windows.Forms.Button bt_2;
        private System.Windows.Forms.Button bt_4;
        private System.Windows.Forms.Button bt_3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_5;
        private System.Windows.Forms.GroupBox gb_Reseau;
        private System.Windows.Forms.TextBox tb_leMessageR;
        private System.Windows.Forms.ListBox lb_lesMessagesR;
        private System.Windows.Forms.TextBox tb_leMessageFL;
        private System.Windows.Forms.ListBox lb_lesMessagesFL;
        private System.Windows.Forms.TextBox tb_leMessageFV;
        private System.Windows.Forms.ListBox lb_lesMessagesV;
        private System.Windows.Forms.Label l_Narration;
        private System.Windows.Forms.GroupBox laPlateforme;
    }
}

