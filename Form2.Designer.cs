namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.board1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ppointer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dlainnychlab = new System.Windows.Forms.Label();
            this.dlainnychbar = new CircularProgressBar.CircularProgressBar();
            this.inwestycjelab = new System.Windows.Forms.Label();
            this.inwestycjebar = new CircularProgressBar.CircularProgressBar();
            this.wiekszezaklab = new System.Windows.Forms.Label();
            this.wiekszezakbar = new CircularProgressBar.CircularProgressBar();
            this.edulab = new System.Windows.Forms.Label();
            this.edubar = new CircularProgressBar.CircularProgressBar();
            this.przyjlab = new System.Windows.Forms.Label();
            this.przyjbar = new CircularProgressBar.CircularProgressBar();
            this.opstalelab = new System.Windows.Forms.Label();
            this.opstalebar = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.OszczLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelActionDodaj = new System.Windows.Forms.Panel();
            this.Wyplatawys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wyplatadata = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DodajWyplate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.board1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelActionDodaj.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // board1
            // 
            this.board1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.board1.Controls.Add(this.button4);
            this.board1.Controls.Add(this.button3);
            this.board1.Controls.Add(this.button2);
            this.board1.Controls.Add(this.panel2);
            this.board1.Location = new System.Drawing.Point(0, 0);
            this.board1.Name = "board1";
            this.board1.Size = new System.Drawing.Size(200, 400);
            this.board1.TabIndex = 2;
            this.board1.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(0, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 80);
            this.button4.TabIndex = 2;
            this.button4.Text = "   Dodaj wypłatę";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 80);
            this.button3.TabIndex = 1;
            this.button3.Text = "   Moje finanse";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 80);
            this.button2.TabIndex = 0;
            this.button2.Text = "Jak oszczędzać? ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ppointer);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 0;
            // 
            // ppointer
            // 
            this.ppointer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.ppointer.Location = new System.Drawing.Point(185, 0);
            this.ppointer.Name = "ppointer";
            this.ppointer.Size = new System.Drawing.Size(15, 80);
            this.ppointer.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dlainnychlab);
            this.panel3.Controls.Add(this.dlainnychbar);
            this.panel3.Controls.Add(this.inwestycjelab);
            this.panel3.Controls.Add(this.inwestycjebar);
            this.panel3.Controls.Add(this.wiekszezaklab);
            this.panel3.Controls.Add(this.wiekszezakbar);
            this.panel3.Controls.Add(this.edulab);
            this.panel3.Controls.Add(this.edubar);
            this.panel3.Controls.Add(this.przyjlab);
            this.panel3.Controls.Add(this.przyjbar);
            this.panel3.Controls.Add(this.opstalelab);
            this.panel3.Controls.Add(this.opstalebar);
            this.panel3.Location = new System.Drawing.Point(47, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 322);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // dlainnychlab
            // 
            this.dlainnychlab.AutoSize = true;
            this.dlainnychlab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dlainnychlab.Location = new System.Drawing.Point(249, 246);
            this.dlainnychlab.Name = "dlainnychlab";
            this.dlainnychlab.Size = new System.Drawing.Size(83, 19);
            this.dlainnychlab.TabIndex = 21;
            this.dlainnychlab.Text = "Dla innych";
            // 
            // dlainnychbar
            // 
            this.dlainnychbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.dlainnychbar.AnimationSpeed = 500;
            this.dlainnychbar.BackColor = System.Drawing.Color.Transparent;
            this.dlainnychbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dlainnychbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dlainnychbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dlainnychbar.InnerMargin = 2;
            this.dlainnychbar.InnerWidth = -1;
            this.dlainnychbar.Location = new System.Drawing.Point(252, 161);
            this.dlainnychbar.MarqueeAnimationSpeed = 2000;
            this.dlainnychbar.Name = "dlainnychbar";
            this.dlainnychbar.OuterColor = System.Drawing.Color.Gray;
            this.dlainnychbar.OuterMargin = -25;
            this.dlainnychbar.OuterWidth = 26;
            this.dlainnychbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.dlainnychbar.ProgressWidth = 7;
            this.dlainnychbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dlainnychbar.Size = new System.Drawing.Size(80, 80);
            this.dlainnychbar.StartAngle = 270;
            this.dlainnychbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dlainnychbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.dlainnychbar.SubscriptText = "";
            this.dlainnychbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.dlainnychbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.dlainnychbar.SuperscriptText = "";
            this.dlainnychbar.TabIndex = 20;
            this.dlainnychbar.Text = "5%";
            this.dlainnychbar.TextMargin = new System.Windows.Forms.Padding(7);
            this.dlainnychbar.Value = 5;
            // 
            // inwestycjelab
            // 
            this.inwestycjelab.AutoSize = true;
            this.inwestycjelab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inwestycjelab.Location = new System.Drawing.Point(148, 246);
            this.inwestycjelab.Name = "inwestycjelab";
            this.inwestycjelab.Size = new System.Drawing.Size(81, 19);
            this.inwestycjelab.TabIndex = 19;
            this.inwestycjelab.Text = "Inwestycje";
            // 
            // inwestycjebar
            // 
            this.inwestycjebar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.inwestycjebar.AnimationSpeed = 500;
            this.inwestycjebar.BackColor = System.Drawing.Color.Transparent;
            this.inwestycjebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.inwestycjebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inwestycjebar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.inwestycjebar.InnerMargin = 2;
            this.inwestycjebar.InnerWidth = -1;
            this.inwestycjebar.Location = new System.Drawing.Point(148, 161);
            this.inwestycjebar.MarqueeAnimationSpeed = 2000;
            this.inwestycjebar.Name = "inwestycjebar";
            this.inwestycjebar.OuterColor = System.Drawing.Color.Gray;
            this.inwestycjebar.OuterMargin = -25;
            this.inwestycjebar.OuterWidth = 26;
            this.inwestycjebar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.inwestycjebar.ProgressWidth = 7;
            this.inwestycjebar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inwestycjebar.Size = new System.Drawing.Size(80, 80);
            this.inwestycjebar.StartAngle = 270;
            this.inwestycjebar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.inwestycjebar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.inwestycjebar.SubscriptText = "";
            this.inwestycjebar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.inwestycjebar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.inwestycjebar.SuperscriptText = "";
            this.inwestycjebar.TabIndex = 18;
            this.inwestycjebar.Text = "10%";
            this.inwestycjebar.TextMargin = new System.Windows.Forms.Padding(7);
            this.inwestycjebar.Value = 10;
            // 
            // wiekszezaklab
            // 
            this.wiekszezaklab.AutoSize = true;
            this.wiekszezaklab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wiekszezaklab.Location = new System.Drawing.Point(22, 244);
            this.wiekszezaklab.Name = "wiekszezaklab";
            this.wiekszezaklab.Size = new System.Drawing.Size(117, 19);
            this.wiekszezaklab.TabIndex = 17;
            this.wiekszezaklab.Text = "Większe zakupy";
            // 
            // wiekszezakbar
            // 
            this.wiekszezakbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.wiekszezakbar.AnimationSpeed = 500;
            this.wiekszezakbar.BackColor = System.Drawing.Color.Transparent;
            this.wiekszezakbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.wiekszezakbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wiekszezakbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wiekszezakbar.InnerMargin = 2;
            this.wiekszezakbar.InnerWidth = -1;
            this.wiekszezakbar.Location = new System.Drawing.Point(39, 161);
            this.wiekszezakbar.MarqueeAnimationSpeed = 2000;
            this.wiekszezakbar.Name = "wiekszezakbar";
            this.wiekszezakbar.OuterColor = System.Drawing.Color.Gray;
            this.wiekszezakbar.OuterMargin = -25;
            this.wiekszezakbar.OuterWidth = 26;
            this.wiekszezakbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.wiekszezakbar.ProgressWidth = 7;
            this.wiekszezakbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wiekszezakbar.Size = new System.Drawing.Size(80, 80);
            this.wiekszezakbar.StartAngle = 270;
            this.wiekszezakbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wiekszezakbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.wiekszezakbar.SubscriptText = "";
            this.wiekszezakbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.wiekszezakbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.wiekszezakbar.SuperscriptText = "";
            this.wiekszezakbar.TabIndex = 16;
            this.wiekszezakbar.Text = "10%";
            this.wiekszezakbar.TextMargin = new System.Windows.Forms.Padding(7);
            this.wiekszezakbar.Value = 10;
            // 
            // edulab
            // 
            this.edulab.AutoSize = true;
            this.edulab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edulab.Location = new System.Drawing.Point(257, 134);
            this.edulab.Name = "edulab";
            this.edulab.Size = new System.Drawing.Size(75, 19);
            this.edulab.TabIndex = 15;
            this.edulab.Text = "Edukacja";
            // 
            // edubar
            // 
            this.edubar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.edubar.AnimationSpeed = 500;
            this.edubar.BackColor = System.Drawing.Color.Transparent;
            this.edubar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.edubar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edubar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.edubar.InnerMargin = 2;
            this.edubar.InnerWidth = -1;
            this.edubar.Location = new System.Drawing.Point(252, 51);
            this.edubar.MarqueeAnimationSpeed = 2000;
            this.edubar.Name = "edubar";
            this.edubar.OuterColor = System.Drawing.Color.Gray;
            this.edubar.OuterMargin = -25;
            this.edubar.OuterWidth = 26;
            this.edubar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.edubar.ProgressWidth = 7;
            this.edubar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edubar.Size = new System.Drawing.Size(80, 80);
            this.edubar.StartAngle = 270;
            this.edubar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.edubar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.edubar.SubscriptText = "";
            this.edubar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.edubar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.edubar.SuperscriptText = "";
            this.edubar.TabIndex = 14;
            this.edubar.Text = "10%";
            this.edubar.TextMargin = new System.Windows.Forms.Padding(7);
            this.edubar.Value = 10;
            // 
            // przyjlab
            // 
            this.przyjlab.AutoSize = true;
            this.przyjlab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyjlab.Location = new System.Drawing.Point(138, 134);
            this.przyjlab.Name = "przyjlab";
            this.przyjlab.Size = new System.Drawing.Size(95, 19);
            this.przyjlab.TabIndex = 13;
            this.przyjlab.Text = "Przyjemności";
            // 
            // przyjbar
            // 
            this.przyjbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.przyjbar.AnimationSpeed = 500;
            this.przyjbar.BackColor = System.Drawing.Color.Transparent;
            this.przyjbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.przyjbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.przyjbar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.przyjbar.InnerMargin = 2;
            this.przyjbar.InnerWidth = -1;
            this.przyjbar.Location = new System.Drawing.Point(148, 51);
            this.przyjbar.MarqueeAnimationSpeed = 2000;
            this.przyjbar.Name = "przyjbar";
            this.przyjbar.OuterColor = System.Drawing.Color.Gray;
            this.przyjbar.OuterMargin = -25;
            this.przyjbar.OuterWidth = 26;
            this.przyjbar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.przyjbar.ProgressWidth = 7;
            this.przyjbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.przyjbar.Size = new System.Drawing.Size(80, 80);
            this.przyjbar.StartAngle = 270;
            this.przyjbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.przyjbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.przyjbar.SubscriptText = "";
            this.przyjbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.przyjbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.przyjbar.SuperscriptText = "";
            this.przyjbar.TabIndex = 12;
            this.przyjbar.Text = "10%";
            this.przyjbar.TextMargin = new System.Windows.Forms.Padding(7);
            this.przyjbar.Value = 10;
            // 
            // opstalelab
            // 
            this.opstalelab.AutoSize = true;
            this.opstalelab.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opstalelab.Location = new System.Drawing.Point(32, 134);
            this.opstalelab.Name = "opstalelab";
            this.opstalelab.Size = new System.Drawing.Size(95, 19);
            this.opstalelab.TabIndex = 11;
            this.opstalelab.Text = "Opłaty stałe";
            // 
            // opstalebar
            // 
            this.opstalebar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.opstalebar.AnimationSpeed = 500;
            this.opstalebar.BackColor = System.Drawing.Color.Transparent;
            this.opstalebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.opstalebar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opstalebar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.opstalebar.InnerMargin = 2;
            this.opstalebar.InnerWidth = -1;
            this.opstalebar.Location = new System.Drawing.Point(39, 51);
            this.opstalebar.MarqueeAnimationSpeed = 2000;
            this.opstalebar.Name = "opstalebar";
            this.opstalebar.OuterColor = System.Drawing.Color.Gray;
            this.opstalebar.OuterMargin = -25;
            this.opstalebar.OuterWidth = 26;
            this.opstalebar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.opstalebar.ProgressWidth = 7;
            this.opstalebar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.opstalebar.Size = new System.Drawing.Size(80, 80);
            this.opstalebar.StartAngle = 270;
            this.opstalebar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.opstalebar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.opstalebar.SubscriptText = "";
            this.opstalebar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.opstalebar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.opstalebar.SuperscriptText = "";
            this.opstalebar.TabIndex = 10;
            this.opstalebar.Text = "55%";
            this.opstalebar.TextMargin = new System.Windows.Forms.Padding(7);
            this.opstalebar.Value = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.OszczLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 80);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(381, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(16, 16);
            this.button6.TabIndex = 3;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // OszczLabel
            // 
            this.OszczLabel.AutoSize = true;
            this.OszczLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OszczLabel.Location = new System.Drawing.Point(115, 27);
            this.OszczLabel.Name = "OszczLabel";
            this.OszczLabel.Size = new System.Drawing.Size(171, 22);
            this.OszczLabel.TabIndex = 0;
            this.OszczLabel.Text = "Metoda 6 słoików";
            this.OszczLabel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(115, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Metoda 6 słoików";
            this.label3.Visible = false;
            // 
            // PanelActionDodaj
            // 
            this.PanelActionDodaj.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelActionDodaj.Controls.Add(this.panel3);
            this.PanelActionDodaj.Controls.Add(this.Wyplatawys);
            this.PanelActionDodaj.Controls.Add(this.label1);
            this.PanelActionDodaj.Controls.Add(this.wyplatadata);
            this.PanelActionDodaj.Controls.Add(this.label2);
            this.PanelActionDodaj.Controls.Add(this.DodajWyplate);
            this.PanelActionDodaj.Location = new System.Drawing.Point(0, 0);
            this.PanelActionDodaj.Name = "PanelActionDodaj";
            this.PanelActionDodaj.Size = new System.Drawing.Size(400, 322);
            this.PanelActionDodaj.TabIndex = 0;
            this.PanelActionDodaj.Visible = false;
            // 
            // Wyplatawys
            // 
            this.Wyplatawys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyplatawys.Location = new System.Drawing.Point(28, 100);
            this.Wyplatawys.Name = "Wyplatawys";
            this.Wyplatawys.Size = new System.Drawing.Size(203, 26);
            this.Wyplatawys.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wysokość wypłaty:";
            // 
            // wyplatadata
            // 
            this.wyplatadata.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyplatadata.Location = new System.Drawing.Point(28, 200);
            this.wyplatadata.Name = "wyplatadata";
            this.wyplatadata.Size = new System.Drawing.Size(203, 27);
            this.wyplatadata.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Okres pracy:";
            // 
            // DodajWyplate
            // 
            this.DodajWyplate.FlatAppearance.BorderSize = 0;
            this.DodajWyplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DodajWyplate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DodajWyplate.Image = ((System.Drawing.Image)(resources.GetObject("DodajWyplate.Image")));
            this.DodajWyplate.Location = new System.Drawing.Point(105, 249);
            this.DodajWyplate.Name = "DodajWyplate";
            this.DodajWyplate.Size = new System.Drawing.Size(100, 50);
            this.DodajWyplate.TabIndex = 3;
            this.DodajWyplate.Text = "   Dodaj";
            this.DodajWyplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DodajWyplate.UseVisualStyleBackColor = true;
            this.DodajWyplate.Click += new System.EventHandler(this.DodajWyplate_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(200, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 322);
            this.panel4.TabIndex = 11;
            this.panel4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(81, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 161);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Miesiąc";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Zarobek:";
            this.Column2.Name = "Column2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.PanelActionDodaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.board1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.board1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelActionDodaj.ResumeLayout(false);
            this.PanelActionDodaj.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ppointer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelActionDodaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OszczLabel;
        private System.Windows.Forms.DateTimePicker wyplatadata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Wyplatawys;
        private System.Windows.Forms.Button DodajWyplate;
        public System.Windows.Forms.Panel board1;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar opstalebar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label dlainnychlab;
        private CircularProgressBar.CircularProgressBar dlainnychbar;
        private System.Windows.Forms.Label inwestycjelab;
        private CircularProgressBar.CircularProgressBar inwestycjebar;
        private System.Windows.Forms.Label wiekszezaklab;
        private CircularProgressBar.CircularProgressBar wiekszezakbar;
        private System.Windows.Forms.Label edulab;
        private CircularProgressBar.CircularProgressBar edubar;
        private System.Windows.Forms.Label przyjlab;
        private CircularProgressBar.CircularProgressBar przyjbar;
        private System.Windows.Forms.Label opstalelab;
        private System.Windows.Forms.Label label3;
    }
}