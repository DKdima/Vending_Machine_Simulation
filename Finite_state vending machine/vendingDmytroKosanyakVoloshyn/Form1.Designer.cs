namespace vendingDmytroKosanyakVoloshyn
{
    partial class maquina_vending
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            b_cancel = new Button();
            l_monedas = new Label();
            p_l_columna2 = new Panel();
            l_columna2 = new Label();
            p_l_columna3 = new Panel();
            l_columna3 = new Label();
            p_columna1 = new Panel();
            b_tpv = new Button();
            b_en = new Button();
            b_es = new Button();
            p_cancel_retirar = new Panel();
            b_retirarmonedas = new Button();
            p_monedas = new Panel();
            b_2 = new Button();
            b_1 = new Button();
            b_50 = new Button();
            p_columna2 = new Panel();
            b_jack = new Button();
            b_fantanaranja = new Button();
            b_cocacola = new Button();
            b_fantalimon = new Button();
            l_cocacola = new Label();
            l_fantalimon = new Label();
            l_jack = new Label();
            l_fantanaranja = new Label();
            p_columna3 = new Panel();
            b_retirarbebida = new Button();
            l_columna1 = new Label();
            p_l_columna1 = new Panel();
            p_general = new Panel();
            helpProvider1 = new HelpProvider();
            toolTip1 = new ToolTip(components);
            p_l_columna2.SuspendLayout();
            p_l_columna3.SuspendLayout();
            p_columna1.SuspendLayout();
            p_cancel_retirar.SuspendLayout();
            p_monedas.SuspendLayout();
            p_columna2.SuspendLayout();
            p_columna3.SuspendLayout();
            p_l_columna1.SuspendLayout();
            p_general.SuspendLayout();
            SuspendLayout();
            // 
            // b_cancel
            // 
            b_cancel.BackColor = Color.Red;
            b_cancel.FlatAppearance.BorderColor = Color.Black;
            b_cancel.FlatStyle = FlatStyle.Flat;
            b_cancel.ForeColor = SystemColors.ButtonHighlight;
            helpProvider1.SetHelpString(b_cancel, "Click to cancel and remove coins");
            b_cancel.Location = new Point(11, 9);
            b_cancel.Name = "b_cancel";
            helpProvider1.SetShowHelp(b_cancel, true);
            b_cancel.Size = new Size(125, 40);
            b_cancel.TabIndex = 5;
            b_cancel.Text = "CANCEL";
            b_cancel.UseVisualStyleBackColor = false;
            b_cancel.Click += b_cancel_Click;
            // 
            // l_monedas
            // 
            l_monedas.AutoSize = true;
            l_monedas.BackColor = SystemColors.ActiveCaptionText;
            l_monedas.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_monedas.ForeColor = Color.FromArgb(0, 192, 0);
            l_monedas.Location = new Point(91, 138);
            l_monedas.Name = "l_monedas";
            l_monedas.Size = new Size(58, 29);
            l_monedas.TabIndex = 13;
            l_monedas.Text = "0,00";
            // 
            // p_l_columna2
            // 
            p_l_columna2.BackColor = SystemColors.ActiveCaptionText;
            p_l_columna2.BorderStyle = BorderStyle.FixedSingle;
            p_l_columna2.Controls.Add(l_columna2);
            p_l_columna2.Location = new Point(309, 3);
            p_l_columna2.Name = "p_l_columna2";
            p_l_columna2.Size = new Size(300, 35);
            p_l_columna2.TabIndex = 29;
            // 
            // l_columna2
            // 
            l_columna2.AutoSize = true;
            l_columna2.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_columna2.ForeColor = Color.FromArgb(0, 192, 0);
            l_columna2.Location = new Point(-1, 3);
            l_columna2.Name = "l_columna2";
            l_columna2.Size = new Size(271, 29);
            l_columna2.TabIndex = 0;
            l_columna2.Text = "2 CHOOSE BEVERAGE";
            // 
            // p_l_columna3
            // 
            p_l_columna3.BackColor = SystemColors.ActiveCaptionText;
            p_l_columna3.BorderStyle = BorderStyle.FixedSingle;
            p_l_columna3.Controls.Add(l_columna3);
            p_l_columna3.Location = new Point(615, 3);
            p_l_columna3.Name = "p_l_columna3";
            p_l_columna3.Size = new Size(300, 35);
            p_l_columna3.TabIndex = 30;
            // 
            // l_columna3
            // 
            l_columna3.AutoSize = true;
            l_columna3.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_columna3.ForeColor = Color.FromArgb(0, 192, 0);
            l_columna3.Location = new Point(3, 3);
            l_columna3.Name = "l_columna3";
            l_columna3.Size = new Size(230, 29);
            l_columna3.TabIndex = 0;
            l_columna3.Text = "3 TAKE BEVERAGE";
            // 
            // p_columna1
            // 
            p_columna1.BackColor = SystemColors.ActiveBorder;
            p_columna1.BorderStyle = BorderStyle.FixedSingle;
            p_columna1.Controls.Add(b_tpv);
            p_columna1.Controls.Add(b_en);
            p_columna1.Controls.Add(b_es);
            p_columna1.Controls.Add(p_cancel_retirar);
            p_columna1.Controls.Add(p_monedas);
            p_columna1.Location = new Point(3, 45);
            p_columna1.Name = "p_columna1";
            p_columna1.Size = new Size(300, 550);
            p_columna1.TabIndex = 31;
            // 
            // b_tpv
            // 
            b_tpv.BackColor = SystemColors.ButtonHighlight;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.BackgroundImageLayout = ImageLayout.Stretch;
            b_tpv.FlatStyle = FlatStyle.Popup;
            helpProvider1.SetHelpString(b_tpv, "Click to add 4€");
            b_tpv.Location = new Point(191, 112);
            b_tpv.Name = "b_tpv";
            helpProvider1.SetShowHelp(b_tpv, true);
            b_tpv.Size = new Size(80, 88);
            b_tpv.TabIndex = 26;
            toolTip1.SetToolTip(b_tpv, "Master Card\r\nVisa\r\nPayPal");
            b_tpv.UseVisualStyleBackColor = false;
            b_tpv.Click += b_tpv_Click;
            // 
            // b_en
            // 
            b_en.BackColor = SystemColors.ButtonHighlight;
            b_en.BackgroundImage = Properties.Resources.en;
            b_en.BackgroundImageLayout = ImageLayout.Stretch;
            b_en.ForeColor = Color.Black;
            helpProvider1.SetHelpString(b_en, "Click to traslate to English");
            b_en.Location = new Point(211, 60);
            b_en.Name = "b_en";
            helpProvider1.SetShowHelp(b_en, true);
            b_en.Size = new Size(41, 37);
            b_en.TabIndex = 30;
            b_en.Text = "EN";
            toolTip1.SetToolTip(b_en, "Click to traslate to English");
            b_en.UseVisualStyleBackColor = false;
            b_en.Click += b_en_Click;
            // 
            // b_es
            // 
            b_es.BackColor = SystemColors.ButtonHighlight;
            b_es.BackgroundImage = Properties.Resources.es;
            b_es.BackgroundImageLayout = ImageLayout.Stretch;
            helpProvider1.SetHelpString(b_es, "Click to traslate to Spain");
            b_es.Location = new Point(211, 17);
            b_es.Name = "b_es";
            helpProvider1.SetShowHelp(b_es, true);
            b_es.Size = new Size(41, 37);
            b_es.TabIndex = 29;
            b_es.Text = "ES";
            toolTip1.SetToolTip(b_es, "Click to traslate to Spain");
            b_es.UseVisualStyleBackColor = false;
            b_es.Click += b_es_Click;
            // 
            // p_cancel_retirar
            // 
            p_cancel_retirar.BorderStyle = BorderStyle.FixedSingle;
            p_cancel_retirar.Controls.Add(b_retirarmonedas);
            p_cancel_retirar.Controls.Add(b_cancel);
            p_cancel_retirar.Location = new Point(18, 310);
            p_cancel_retirar.Name = "p_cancel_retirar";
            p_cancel_retirar.Size = new Size(167, 180);
            p_cancel_retirar.TabIndex = 28;
            // 
            // b_retirarmonedas
            // 
            b_retirarmonedas.BackColor = SystemColors.ActiveCaptionText;
            b_retirarmonedas.BackgroundImage = Properties.Resources.retirar_Monedas;
            b_retirarmonedas.BackgroundImageLayout = ImageLayout.Stretch;
            b_retirarmonedas.FlatStyle = FlatStyle.Popup;
            helpProvider1.SetHelpString(b_retirarmonedas, "Click when you have coins");
            b_retirarmonedas.Location = new Point(11, 57);
            b_retirarmonedas.Name = "b_retirarmonedas";
            helpProvider1.SetShowHelp(b_retirarmonedas, true);
            b_retirarmonedas.Size = new Size(125, 113);
            b_retirarmonedas.TabIndex = 26;
            b_retirarmonedas.UseVisualStyleBackColor = false;
            b_retirarmonedas.Click += b_retirarmonedas_Click;
            // 
            // p_monedas
            // 
            p_monedas.BorderStyle = BorderStyle.FixedSingle;
            p_monedas.Controls.Add(b_2);
            p_monedas.Controls.Add(b_1);
            p_monedas.Controls.Add(b_50);
            p_monedas.Controls.Add(l_monedas);
            p_monedas.Location = new Point(18, 10);
            p_monedas.Name = "p_monedas";
            p_monedas.Size = new Size(167, 297);
            p_monedas.TabIndex = 27;
            // 
            // b_2
            // 
            b_2.BackColor = SystemColors.ButtonHighlight;
            b_2.BackgroundImage = Properties.Resources.Euro_2;
            b_2.BackgroundImageLayout = ImageLayout.Stretch;
            b_2.FlatStyle = FlatStyle.Popup;
            helpProvider1.SetHelpString(b_2, "Click to add 2€");
            b_2.Location = new Point(5, 195);
            b_2.Name = "b_2";
            helpProvider1.SetShowHelp(b_2, true);
            b_2.Size = new Size(80, 88);
            b_2.TabIndex = 25;
            b_2.UseVisualStyleBackColor = false;
            b_2.Click += b_2_Click;
            // 
            // b_1
            // 
            b_1.BackColor = SystemColors.ButtonHighlight;
            b_1.BackgroundImage = Properties.Resources.Euro_1;
            b_1.BackgroundImageLayout = ImageLayout.Stretch;
            b_1.FlatStyle = FlatStyle.Popup;
            helpProvider1.SetHelpString(b_1, "Click to add 1€");
            b_1.Location = new Point(5, 101);
            b_1.Name = "b_1";
            helpProvider1.SetShowHelp(b_1, true);
            b_1.Size = new Size(80, 88);
            b_1.TabIndex = 24;
            b_1.UseVisualStyleBackColor = false;
            b_1.Click += b_1_Click;
            // 
            // b_50
            // 
            b_50.BackColor = SystemColors.ButtonHighlight;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_50;
            b_50.BackgroundImageLayout = ImageLayout.Stretch;
            b_50.FlatStyle = FlatStyle.Popup;
            helpProvider1.SetHelpString(b_50, "Click to add 0,50€");
            b_50.Location = new Point(5, 7);
            b_50.Name = "b_50";
            helpProvider1.SetShowHelp(b_50, true);
            b_50.Size = new Size(80, 88);
            b_50.TabIndex = 23;
            b_50.UseVisualStyleBackColor = false;
            b_50.Click += b_50_Click;
            // 
            // p_columna2
            // 
            p_columna2.BackColor = SystemColors.ActiveBorder;
            p_columna2.BorderStyle = BorderStyle.FixedSingle;
            p_columna2.Controls.Add(b_jack);
            p_columna2.Controls.Add(b_fantanaranja);
            p_columna2.Controls.Add(b_cocacola);
            p_columna2.Controls.Add(b_fantalimon);
            p_columna2.Controls.Add(l_cocacola);
            p_columna2.Controls.Add(l_fantalimon);
            p_columna2.Controls.Add(l_jack);
            p_columna2.Controls.Add(l_fantanaranja);
            p_columna2.Location = new Point(309, 45);
            p_columna2.Name = "p_columna2";
            p_columna2.Size = new Size(300, 550);
            p_columna2.TabIndex = 32;
            // 
            // b_jack
            // 
            b_jack.BackColor = SystemColors.ActiveBorder;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Coca_Cola;
            b_jack.BackgroundImageLayout = ImageLayout.Stretch;
            b_jack.FlatStyle = FlatStyle.Popup;
            b_jack.Location = new Point(83, 397);
            b_jack.Name = "b_jack";
            b_jack.Size = new Size(74, 123);
            b_jack.TabIndex = 30;
            b_jack.UseVisualStyleBackColor = false;
            b_jack.Click += b_jack_Click;
            // 
            // b_fantanaranja
            // 
            b_fantanaranja.BackColor = SystemColors.ActiveBorder;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange;
            b_fantanaranja.BackgroundImageLayout = ImageLayout.Stretch;
            b_fantanaranja.FlatStyle = FlatStyle.Popup;
            b_fantanaranja.Location = new Point(83, 268);
            b_fantanaranja.Name = "b_fantanaranja";
            b_fantanaranja.Size = new Size(74, 123);
            b_fantanaranja.TabIndex = 29;
            b_fantanaranja.UseVisualStyleBackColor = false;
            b_fantanaranja.Click += b_fantanaranja_Click;
            // 
            // b_cocacola
            // 
            b_cocacola.BackColor = SystemColors.ActiveBorder;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola;
            b_cocacola.BackgroundImageLayout = ImageLayout.Stretch;
            b_cocacola.FlatStyle = FlatStyle.Popup;
            b_cocacola.Location = new Point(83, 10);
            b_cocacola.Name = "b_cocacola";
            b_cocacola.Size = new Size(74, 123);
            b_cocacola.TabIndex = 27;
            b_cocacola.UseVisualStyleBackColor = false;
            b_cocacola.Click += b_cocacola_Click;
            // 
            // b_fantalimon
            // 
            b_fantalimon.BackColor = SystemColors.ActiveBorder;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon;
            b_fantalimon.BackgroundImageLayout = ImageLayout.Stretch;
            b_fantalimon.FlatStyle = FlatStyle.Popup;
            b_fantalimon.Location = new Point(83, 139);
            b_fantalimon.Name = "b_fantalimon";
            b_fantalimon.Size = new Size(74, 123);
            b_fantalimon.TabIndex = 28;
            b_fantalimon.UseVisualStyleBackColor = false;
            b_fantalimon.Click += b_fantalimon_Click;
            // 
            // l_cocacola
            // 
            l_cocacola.AutoSize = true;
            l_cocacola.BackColor = SystemColors.ActiveCaptionText;
            l_cocacola.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_cocacola.ForeColor = Color.FromArgb(0, 192, 0);
            l_cocacola.Location = new Point(163, 63);
            l_cocacola.Name = "l_cocacola";
            l_cocacola.Size = new Size(58, 29);
            l_cocacola.TabIndex = 14;
            l_cocacola.Text = "1,50";
            // 
            // l_fantalimon
            // 
            l_fantalimon.AutoSize = true;
            l_fantalimon.BackColor = SystemColors.ActiveCaptionText;
            l_fantalimon.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_fantalimon.ForeColor = Color.FromArgb(0, 192, 0);
            l_fantalimon.Location = new Point(166, 200);
            l_fantalimon.Name = "l_fantalimon";
            l_fantalimon.Size = new Size(58, 29);
            l_fantalimon.TabIndex = 15;
            l_fantalimon.Text = "1,50";
            // 
            // l_jack
            // 
            l_jack.AutoSize = true;
            l_jack.BackColor = SystemColors.ActiveCaptionText;
            l_jack.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_jack.ForeColor = Color.FromArgb(0, 192, 0);
            l_jack.Location = new Point(166, 455);
            l_jack.Name = "l_jack";
            l_jack.Size = new Size(58, 29);
            l_jack.TabIndex = 17;
            l_jack.Text = "4,00";
            // 
            // l_fantanaranja
            // 
            l_fantanaranja.AutoSize = true;
            l_fantanaranja.BackColor = SystemColors.ActiveCaptionText;
            l_fantanaranja.Font = new Font("Microsoft Sans Serif", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_fantanaranja.ForeColor = Color.FromArgb(0, 192, 0);
            l_fantanaranja.Location = new Point(166, 327);
            l_fantanaranja.Name = "l_fantanaranja";
            l_fantanaranja.Size = new Size(58, 29);
            l_fantanaranja.TabIndex = 16;
            l_fantanaranja.Text = "1,50";
            // 
            // p_columna3
            // 
            p_columna3.BackColor = SystemColors.ActiveBorder;
            p_columna3.BorderStyle = BorderStyle.FixedSingle;
            p_columna3.Controls.Add(b_retirarbebida);
            p_columna3.Location = new Point(615, 45);
            p_columna3.Name = "p_columna3";
            p_columna3.Size = new Size(300, 550);
            p_columna3.TabIndex = 33;
            // 
            // b_retirarbebida
            // 
            b_retirarbebida.BackColor = SystemColors.ActiveCaptionText;
            b_retirarbebida.BackgroundImageLayout = ImageLayout.Stretch;
            b_retirarbebida.FlatStyle = FlatStyle.Popup;
            b_retirarbebida.Location = new Point(29, 10);
            b_retirarbebida.Name = "b_retirarbebida";
            b_retirarbebida.Size = new Size(243, 512);
            b_retirarbebida.TabIndex = 31;
            b_retirarbebida.UseVisualStyleBackColor = false;
            b_retirarbebida.Click += b_retirarbebida_Click;
            // 
            // l_columna1
            // 
            l_columna1.AutoSize = true;
            l_columna1.Font = new Font("Digital-7", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            l_columna1.ForeColor = Color.FromArgb(0, 192, 0);
            l_columna1.Location = new Point(3, 3);
            l_columna1.Name = "l_columna1";
            l_columna1.Size = new Size(124, 25);
            l_columna1.TabIndex = 0;
            l_columna1.Text = "1 INSERT COIN";
            // 
            // p_l_columna1
            // 
            p_l_columna1.BackColor = SystemColors.ActiveCaptionText;
            p_l_columna1.BorderStyle = BorderStyle.FixedSingle;
            p_l_columna1.Controls.Add(l_columna1);
            p_l_columna1.Location = new Point(3, 3);
            p_l_columna1.Name = "p_l_columna1";
            p_l_columna1.Size = new Size(300, 35);
            p_l_columna1.TabIndex = 28;
            // 
            // p_general
            // 
            p_general.BackColor = SystemColors.ActiveBorder;
            p_general.Controls.Add(p_l_columna3);
            p_general.Controls.Add(p_l_columna2);
            p_general.Controls.Add(p_l_columna1);
            p_general.Controls.Add(p_columna3);
            p_general.Controls.Add(p_columna2);
            p_general.Controls.Add(p_columna1);
            p_general.Location = new Point(33, 18);
            p_general.Name = "p_general";
            p_general.Size = new Size(919, 597);
            p_general.TabIndex = 34;
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "";
            // 
            // maquina_vending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 669);
            Controls.Add(p_general);
            HelpButton = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "maquina_vending";
            RightToLeft = RightToLeft.No;
            helpProvider1.SetShowHelp(this, false);
            Text = "Máquina Vending";
            Load += Form1_Load;
            p_l_columna2.ResumeLayout(false);
            p_l_columna2.PerformLayout();
            p_l_columna3.ResumeLayout(false);
            p_l_columna3.PerformLayout();
            p_columna1.ResumeLayout(false);
            p_cancel_retirar.ResumeLayout(false);
            p_monedas.ResumeLayout(false);
            p_monedas.PerformLayout();
            p_columna2.ResumeLayout(false);
            p_columna2.PerformLayout();
            p_columna3.ResumeLayout(false);
            p_l_columna1.ResumeLayout(false);
            p_l_columna1.PerformLayout();
            p_general.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button b_cancel;
        private Label l_monedas;
        private Panel p_l_columna2;
        private Label l_columna2;
        private Panel p_l_columna3;
        private Label l_columna3;
        private Panel p_columna1;
        private Panel p_columna2;
        private Panel p_columna3;
        private Label l_columna1;
        private Panel p_l_columna1;
        private Panel p_general;
        private Button b_50;
        private Button b_1;
        private Button b_retirarmonedas;
        private Button b_2;
        private Button b_retirarbebida;
        private Panel p_cancel_retirar;
        private Panel p_monedas;
        private Button b_jack;
        private Button b_fantanaranja;
        private Button b_cocacola;
        private Button b_fantalimon;
        private Label l_cocacola;
        private Label l_fantalimon;
        private Label l_jack;
        private Label l_fantanaranja;
        private Button b_tpv;
        private Button b_en;
        private Button b_es;
        private HelpProvider helpProvider1;
        private ToolTip toolTip1;
    }
}
