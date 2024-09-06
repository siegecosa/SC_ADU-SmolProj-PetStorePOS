namespace Elarcosa_Prog2_POS
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalamount = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ordersummary = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.pricevar3 = new System.Windows.Forms.Label();
            this.pricevar2 = new System.Windows.Forms.Label();
            this.pricevar1 = new System.Windows.Forms.Label();
            this.variation3 = new System.Windows.Forms.RadioButton();
            this.variation2 = new System.Windows.Forms.RadioButton();
            this.variation1 = new System.Windows.Forms.RadioButton();
            this.chosenproductname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.name5 = new System.Windows.Forms.Label();
            this.name4 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chosenproductimage = new System.Windows.Forms.PictureBox();
            this.product5 = new System.Windows.Forms.PictureBox();
            this.product4 = new System.Windows.Forms.PictureBox();
            this.product3 = new System.Windows.Forms.PictureBox();
            this.product2 = new System.Windows.Forms.PictureBox();
            this.product1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenproductimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalamount);
            this.groupBox4.Controls.Add(this.change);
            this.groupBox4.Controls.Add(this.reset);
            this.groupBox4.Controls.Add(this.finish);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.payment);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox4.Location = new System.Drawing.Point(327, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(285, 179);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PAY HERE";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.Location = new System.Drawing.Point(221, 19);
            this.totalamount.Name = "totalamount";
            this.totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalamount.Size = new System.Drawing.Size(29, 12);
            this.totalamount.TabIndex = 30;
            this.totalamount.Text = "0.00";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(221, 82);
            this.change.Name = "change";
            this.change.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.change.Size = new System.Drawing.Size(35, 15);
            this.change.TabIndex = 29;
            this.change.Text = "0.00";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.LightYellow;
            this.reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(20, 144);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(241, 31);
            this.reset.TabIndex = 28;
            this.reset.Text = "RESET";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.LightYellow;
            this.finish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish.Location = new System.Drawing.Point(20, 107);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(241, 31);
            this.finish.TabIndex = 27;
            this.finish.Text = "PAY";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "CHANGE:";
            // 
            // payment
            // 
            this.payment.BackColor = System.Drawing.Color.LightYellow;
            this.payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(144, 45);
            this.payment.MaxLength = 20;
            this.payment.Name = "payment";
            this.payment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.payment.Size = new System.Drawing.Size(105, 20);
            this.payment.TabIndex = 25;
            this.payment.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "INPUT PAYMENT:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 12);
            this.label12.TabIndex = 23;
            this.label12.Text = "TOTAL AMOUNT:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ordersummary);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.quantity);
            this.groupBox3.Controls.Add(this.pricevar3);
            this.groupBox3.Controls.Add(this.pricevar2);
            this.groupBox3.Controls.Add(this.pricevar1);
            this.groupBox3.Controls.Add(this.variation3);
            this.groupBox3.Controls.Add(this.variation2);
            this.groupBox3.Controls.Add(this.variation1);
            this.groupBox3.Controls.Add(this.chosenproductname);
            this.groupBox3.Controls.Add(this.chosenproductimage);
            this.groupBox3.Font = new System.Drawing.Font("Yard Sale", 11.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Location = new System.Drawing.Point(23, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 340);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PET VARIATIONS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ordersummary
            // 
            this.ordersummary.BackColor = System.Drawing.Color.LightYellow;
            this.ordersummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersummary.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.ordersummary.Location = new System.Drawing.Point(21, 214);
            this.ordersummary.Name = "ordersummary";
            this.ordersummary.ReadOnly = true;
            this.ordersummary.Size = new System.Drawing.Size(567, 120);
            this.ordersummary.TabIndex = 21;
            this.ordersummary.Text = "";
            this.ordersummary.WordWrap = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightYellow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(181, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 20;
            this.button1.Text = "GET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(178, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quantity:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.Color.LightYellow;
            this.quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(245, 122);
            this.quantity.MaxLength = 7;
            this.quantity.Name = "quantity";
            this.quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.quantity.Size = new System.Drawing.Size(72, 20);
            this.quantity.TabIndex = 18;
            // 
            // pricevar3
            // 
            this.pricevar3.AutoSize = true;
            this.pricevar3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricevar3.Location = new System.Drawing.Point(276, 93);
            this.pricevar3.Name = "pricevar3";
            this.pricevar3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pricevar3.Size = new System.Drawing.Size(44, 12);
            this.pricevar3.TabIndex = 17;
            this.pricevar3.Text = "Price 3";
            this.pricevar3.Click += new System.EventHandler(this.label10_Click);
            // 
            // pricevar2
            // 
            this.pricevar2.AutoSize = true;
            this.pricevar2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricevar2.Location = new System.Drawing.Point(276, 62);
            this.pricevar2.Name = "pricevar2";
            this.pricevar2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pricevar2.Size = new System.Drawing.Size(44, 12);
            this.pricevar2.TabIndex = 16;
            this.pricevar2.Text = "Price 2";
            this.pricevar2.Click += new System.EventHandler(this.pricevar2_Click);
            // 
            // pricevar1
            // 
            this.pricevar1.AutoSize = true;
            this.pricevar1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricevar1.Location = new System.Drawing.Point(276, 33);
            this.pricevar1.Name = "pricevar1";
            this.pricevar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pricevar1.Size = new System.Drawing.Size(44, 12);
            this.pricevar1.TabIndex = 15;
            this.pricevar1.Text = "Price 1";
            this.pricevar1.Click += new System.EventHandler(this.pricevar1_Click);
            // 
            // variation3
            // 
            this.variation3.AutoSize = true;
            this.variation3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variation3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variation3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variation3.Location = new System.Drawing.Point(165, 91);
            this.variation3.Name = "variation3";
            this.variation3.Size = new System.Drawing.Size(83, 16);
            this.variation3.TabIndex = 14;
            this.variation3.TabStop = true;
            this.variation3.Text = "Variation 3";
            this.variation3.UseVisualStyleBackColor = true;
            this.variation3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // variation2
            // 
            this.variation2.AutoSize = true;
            this.variation2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variation2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variation2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variation2.Location = new System.Drawing.Point(165, 60);
            this.variation2.Name = "variation2";
            this.variation2.Size = new System.Drawing.Size(83, 16);
            this.variation2.TabIndex = 13;
            this.variation2.TabStop = true;
            this.variation2.Text = "Variation 2";
            this.variation2.UseVisualStyleBackColor = true;
            this.variation2.CheckedChanged += new System.EventHandler(this.variation2_CheckedChanged);
            // 
            // variation1
            // 
            this.variation1.AutoSize = true;
            this.variation1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.variation1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.variation1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variation1.Location = new System.Drawing.Point(165, 31);
            this.variation1.Name = "variation1";
            this.variation1.Size = new System.Drawing.Size(83, 16);
            this.variation1.TabIndex = 12;
            this.variation1.TabStop = true;
            this.variation1.Text = "Variation 1";
            this.variation1.UseVisualStyleBackColor = true;
            this.variation1.CheckedChanged += new System.EventHandler(this.variation1_CheckedChanged);
            // 
            // chosenproductname
            // 
            this.chosenproductname.AutoSize = true;
            this.chosenproductname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenproductname.Location = new System.Drawing.Point(48, 157);
            this.chosenproductname.Name = "chosenproductname";
            this.chosenproductname.Size = new System.Drawing.Size(79, 12);
            this.chosenproductname.TabIndex = 11;
            this.chosenproductname.Text = "ANIMAL TYPE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.name5);
            this.groupBox2.Controls.Add(this.product5);
            this.groupBox2.Controls.Add(this.name4);
            this.groupBox2.Controls.Add(this.product4);
            this.groupBox2.Controls.Add(this.name3);
            this.groupBox2.Controls.Add(this.product3);
            this.groupBox2.Controls.Add(this.name2);
            this.groupBox2.Controls.Add(this.product2);
            this.groupBox2.Controls.Add(this.name1);
            this.groupBox2.Controls.Add(this.product1);
            this.groupBox2.Font = new System.Drawing.Font("Yard Sale", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox2.Location = new System.Drawing.Point(23, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AVAILABLE PETS - CHOOSE ANY!";
            // 
            // name5
            // 
            this.name5.AutoSize = true;
            this.name5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.name5.Location = new System.Drawing.Point(531, 117);
            this.name5.Name = "name5";
            this.name5.Size = new System.Drawing.Size(56, 15);
            this.name5.TabIndex = 9;
            this.name5.Text = "ALIENS";
            // 
            // name4
            // 
            this.name4.AutoSize = true;
            this.name4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.name4.Location = new System.Drawing.Point(408, 117);
            this.name4.Name = "name4";
            this.name4.Size = new System.Drawing.Size(56, 15);
            this.name4.TabIndex = 7;
            this.name4.Text = "FISHES";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.name3.Location = new System.Drawing.Point(285, 117);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(48, 15);
            this.name3.TabIndex = 5;
            this.name3.Text = "BIRDS";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.name2.Location = new System.Drawing.Point(155, 117);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(72, 15);
            this.name2.TabIndex = 3;
            this.name2.Text = "REPTILES";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.name1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.name1.Location = new System.Drawing.Point(47, 117);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(46, 15);
            this.name1.TabIndex = 1;
            this.name1.Text = "DOGS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yard Sale", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO CJ\'S PET STORE!";
            // 
            // chosenproductimage
            // 
            this.chosenproductimage.Location = new System.Drawing.Point(24, 19);
            this.chosenproductimage.Name = "chosenproductimage";
            this.chosenproductimage.Size = new System.Drawing.Size(125, 131);
            this.chosenproductimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.chosenproductimage.TabIndex = 10;
            this.chosenproductimage.TabStop = false;
            // 
            // product5
            // 
            this.product5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product5.Image = global::Elarcosa_Prog2_POS.Properties.Resources.alien;
            this.product5.Location = new System.Drawing.Point(508, 19);
            this.product5.Name = "product5";
            this.product5.Size = new System.Drawing.Size(80, 80);
            this.product5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product5.TabIndex = 8;
            this.product5.TabStop = false;
            this.product5.Click += new System.EventHandler(this.product5_Click);
            // 
            // product4
            // 
            this.product4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product4.Image = global::Elarcosa_Prog2_POS.Properties.Resources.fish;
            this.product4.Location = new System.Drawing.Point(385, 19);
            this.product4.Name = "product4";
            this.product4.Size = new System.Drawing.Size(80, 80);
            this.product4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product4.TabIndex = 6;
            this.product4.TabStop = false;
            this.product4.Click += new System.EventHandler(this.product4_Click);
            // 
            // product3
            // 
            this.product3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product3.Image = global::Elarcosa_Prog2_POS.Properties.Resources.bird;
            this.product3.Location = new System.Drawing.Point(265, 19);
            this.product3.Name = "product3";
            this.product3.Size = new System.Drawing.Size(80, 80);
            this.product3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product3.TabIndex = 4;
            this.product3.TabStop = false;
            this.product3.Click += new System.EventHandler(this.product3_Click);
            // 
            // product2
            // 
            this.product2.BackgroundImage = global::Elarcosa_Prog2_POS.Properties.Resources.reptile;
            this.product2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product2.Location = new System.Drawing.Point(142, 19);
            this.product2.Name = "product2";
            this.product2.Size = new System.Drawing.Size(85, 86);
            this.product2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product2.TabIndex = 2;
            this.product2.TabStop = false;
            this.product2.Click += new System.EventHandler(this.product2_Click);
            // 
            // product1
            // 
            this.product1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product1.Image = global::Elarcosa_Prog2_POS.Properties.Resources.dog;
            this.product1.Location = new System.Drawing.Point(24, 20);
            this.product1.Name = "product1";
            this.product1.Size = new System.Drawing.Size(80, 80);
            this.product1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.product1.TabIndex = 0;
            this.product1.TabStop = false;
            this.product1.Click += new System.EventHandler(this.product1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "VARIANTIONS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "PRICES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yard Sale", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "RECEIPT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Christian Jay B. Elarcosa - CS 101";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(708, 571);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CJ PET STORE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenproductimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label name5;
        private System.Windows.Forms.PictureBox product5;
        private System.Windows.Forms.Label name4;
        private System.Windows.Forms.PictureBox product4;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.PictureBox product3;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.PictureBox product2;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.PictureBox product1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label chosenproductname;
        private System.Windows.Forms.PictureBox chosenproductimage;
        private System.Windows.Forms.RadioButton variation3;
        private System.Windows.Forms.RadioButton variation2;
        private System.Windows.Forms.RadioButton variation1;
        private System.Windows.Forms.Label pricevar3;
        private System.Windows.Forms.Label pricevar2;
        private System.Windows.Forms.Label pricevar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox ordersummary;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

