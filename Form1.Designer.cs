namespace GestionJeux
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnAjouter = new Button();
            txtTitre = new TextBox();
            comboGenre = new ComboBox();
            comboAnnee = new ComboBox();
            txtPrix = new TextBox();
            comboStatut = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnConf = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.WindowFrame;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1084, 200);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Silver;
            btnAjouter.Location = new Point(14, 309);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(100, 30);
            btnAjouter.TabIndex = 1;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // txtTitre
            // 
            txtTitre.BackColor = Color.Silver;
            txtTitre.Location = new Point(206, 260);
            txtTitre.Name = "txtTitre";
            txtTitre.PlaceholderText = "Titre";
            txtTitre.Size = new Size(100, 27);
            txtTitre.TabIndex = 2;
            // 
            // comboGenre
            // 
            comboGenre.BackColor = Color.Silver;
            comboGenre.FormattingEnabled = true;
            comboGenre.Items.AddRange(new object[] { "Action", "Aventure", "RPG", "FPS", "Sport", "Simulation", "Stratégie", "Survie", "Horreur", "Course", "Plateforme", "MMORPG", "Puzzle", "Battle Royale" });
            comboGenre.Location = new Point(327, 260);
            comboGenre.Name = "comboGenre";
            comboGenre.Size = new Size(100, 28);
            comboGenre.TabIndex = 0;
            comboGenre.Text = "Genre";
            // 
            // comboAnnee
            // 
            comboAnnee.BackColor = Color.Silver;
            comboAnnee.FormattingEnabled = true;
            comboAnnee.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026" });
            comboAnnee.Location = new Point(451, 260);
            comboAnnee.Name = "comboAnnee";
            comboAnnee.Size = new Size(100, 28);
            comboAnnee.TabIndex = 1;
            comboAnnee.Text = "année";
            // 
            // txtPrix
            // 
            txtPrix.BackColor = Color.Silver;
            txtPrix.Location = new Point(577, 261);
            txtPrix.Name = "txtPrix";
            txtPrix.PlaceholderText = "Prix";
            txtPrix.Size = new Size(100, 27);
            txtPrix.TabIndex = 5;
            // 
            // comboStatut
            // 
            comboStatut.BackColor = Color.Silver;
            comboStatut.FormattingEnabled = true;
            comboStatut.Items.AddRange(new object[] { "Disponible", "Prêté", "Vendu" });
            comboStatut.Location = new Point(691, 260);
            comboStatut.Name = "comboStatut";
            comboStatut.Size = new Size(121, 28);
            comboStatut.TabIndex = 2;
            comboStatut.Text = "Statut";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(192, 255, 255);
            label7.Location = new Point(14, 9);
            label7.Name = "label7";
            label7.Size = new Size(160, 35);
            label7.TabIndex = 6;
            label7.Text = "Isigames";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripComboBox1, toolStripSeparator1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(182, 42);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(121, 28);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(178, 6);
            // 
            // btnConf
            // 
            btnConf.Location = new Point(833, 260);
            btnConf.Name = "btnConf";
            btnConf.Size = new Size(94, 29);
            btnConf.TabIndex = 7;
            btnConf.Text = "Confirmer";
            btnConf.UseVisualStyleBackColor = true;
            btnConf.Click += button1_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1123, 351);
            Controls.Add(btnConf);
            Controls.Add(label7);
            Controls.Add(comboGenre);
            Controls.Add(comboAnnee);
            Controls.Add(comboStatut);
            Controls.Add(dataGridView1);
            Controls.Add(btnAjouter);
            Controls.Add(txtTitre);
            Controls.Add(txtPrix);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "IsiGames";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.ComboBox comboAnnee;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.ComboBox comboStatut;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private Button btnConf;
    }
}
