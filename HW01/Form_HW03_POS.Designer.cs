
namespace HW01
{
    partial class Form_HW03_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_HW03_POS));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMWine = new System.Windows.Forms.Button();
            this.btnMWisky = new System.Windows.Forms.Button();
            this.btnMTequila = new System.Windows.Forms.Button();
            this.btnMBeer = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.labelPriceShow = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panelPayWay = new System.Windows.Forms.Panel();
            this.btnPayCredit = new System.Windows.Forms.Button();
            this.btnPayCash = new System.Windows.Forms.Button();
            this.labelAD = new System.Windows.Forms.Label();
            this.labelPayWay = new System.Windows.Forms.Label();
            this.panelShopList = new System.Windows.Forms.Panel();
            this.btnCleanList = new System.Windows.Forms.Button();
            this.labelShopListShow = new System.Windows.Forms.Label();
            this.labelShopList = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelPrice.SuspendLayout();
            this.panelPayWay.SuspendLayout();
            this.panelShopList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.btnMWine);
            this.panelMenu.Controls.Add(this.btnMWisky);
            this.panelMenu.Controls.Add(this.btnMTequila);
            this.panelMenu.Controls.Add(this.btnMBeer);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Location = new System.Drawing.Point(10, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 350);
            this.panelMenu.TabIndex = 0;
            // 
            // btnMWine
            // 
            this.btnMWine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMWine.BackgroundImage")));
            this.btnMWine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMWine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMWine.ForeColor = System.Drawing.Color.Black;
            this.btnMWine.Location = new System.Drawing.Point(130, 180);
            this.btnMWine.Name = "btnMWine";
            this.btnMWine.Size = new System.Drawing.Size(87, 115);
            this.btnMWine.TabIndex = 4;
            this.btnMWine.Text = "紅酒\r\nWine\r\nNT$320";
            this.btnMWine.UseVisualStyleBackColor = true;
            this.btnMWine.Click += new System.EventHandler(this.btnMWine_Click);
            // 
            // btnMWisky
            // 
            this.btnMWisky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMWisky.BackgroundImage")));
            this.btnMWisky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMWisky.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMWisky.ForeColor = System.Drawing.Color.White;
            this.btnMWisky.Location = new System.Drawing.Point(30, 180);
            this.btnMWisky.Name = "btnMWisky";
            this.btnMWisky.Size = new System.Drawing.Size(87, 115);
            this.btnMWisky.TabIndex = 3;
            this.btnMWisky.Text = "威士忌\r\nWisky\r\nNT$$350";
            this.btnMWisky.UseVisualStyleBackColor = true;
            this.btnMWisky.Click += new System.EventHandler(this.btnMWisky_Click);
            // 
            // btnMTequila
            // 
            this.btnMTequila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMTequila.BackgroundImage")));
            this.btnMTequila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMTequila.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMTequila.ForeColor = System.Drawing.Color.White;
            this.btnMTequila.Location = new System.Drawing.Point(130, 50);
            this.btnMTequila.Name = "btnMTequila";
            this.btnMTequila.Size = new System.Drawing.Size(87, 115);
            this.btnMTequila.TabIndex = 2;
            this.btnMTequila.Text = "龍舌蘭\r\nTequila\r\nNT$180";
            this.btnMTequila.UseVisualStyleBackColor = true;
            this.btnMTequila.Click += new System.EventHandler(this.btnMTequila_Click);
            // 
            // btnMBeer
            // 
            this.btnMBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMBeer.BackgroundImage")));
            this.btnMBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMBeer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMBeer.ForeColor = System.Drawing.Color.White;
            this.btnMBeer.Location = new System.Drawing.Point(30, 50);
            this.btnMBeer.Name = "btnMBeer";
            this.btnMBeer.Size = new System.Drawing.Size(87, 115);
            this.btnMBeer.TabIndex = 1;
            this.btnMBeer.Text = "啤酒\r\nBeer\r\nNT$120";
            this.btnMBeer.UseVisualStyleBackColor = true;
            this.btnMBeer.Click += new System.EventHandler(this.btnMBeer_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMenu.Location = new System.Drawing.Point(5, 5);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(101, 19);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "菜單 Menu";
            // 
            // panelPrice
            // 
            this.panelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrice.Controls.Add(this.labelPriceShow);
            this.panelPrice.Controls.Add(this.labelPrice);
            this.panelPrice.Location = new System.Drawing.Point(266, 40);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(250, 100);
            this.panelPrice.TabIndex = 1;
            // 
            // labelPriceShow
            // 
            this.labelPriceShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPriceShow.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPriceShow.ForeColor = System.Drawing.Color.White;
            this.labelPriceShow.Location = new System.Drawing.Point(20, 40);
            this.labelPriceShow.Name = "labelPriceShow";
            this.labelPriceShow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPriceShow.Size = new System.Drawing.Size(220, 40);
            this.labelPriceShow.TabIndex = 2;
            this.labelPriceShow.Text = "NT$ 0";
            this.labelPriceShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPrice.Location = new System.Drawing.Point(5, 5);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(166, 19);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "總金額 Total Price";
            // 
            // panelPayWay
            // 
            this.panelPayWay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPayWay.Controls.Add(this.btnPayCredit);
            this.panelPayWay.Controls.Add(this.btnPayCash);
            this.panelPayWay.Controls.Add(this.labelAD);
            this.panelPayWay.Controls.Add(this.labelPayWay);
            this.panelPayWay.Location = new System.Drawing.Point(266, 146);
            this.panelPayWay.Name = "panelPayWay";
            this.panelPayWay.Size = new System.Drawing.Size(250, 130);
            this.panelPayWay.TabIndex = 2;
            // 
            // btnPayCredit
            // 
            this.btnPayCredit.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayCredit.Location = new System.Drawing.Point(135, 50);
            this.btnPayCredit.Name = "btnPayCredit";
            this.btnPayCredit.Size = new System.Drawing.Size(106, 38);
            this.btnPayCredit.TabIndex = 6;
            this.btnPayCredit.Text = "信用卡";
            this.btnPayCredit.UseVisualStyleBackColor = true;
            this.btnPayCredit.Click += new System.EventHandler(this.btnPayCredit_Click);
            // 
            // btnPayCash
            // 
            this.btnPayCash.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPayCash.Location = new System.Drawing.Point(10, 50);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(106, 38);
            this.btnPayCash.TabIndex = 5;
            this.btnPayCash.Text = "現金";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPayCash_Click);
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAD.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAD.Location = new System.Drawing.Point(135, 105);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(111, 18);
            this.labelAD.TabIndex = 4;
            this.labelAD.Text = "信用卡享九折!";
            // 
            // labelPayWay
            // 
            this.labelPayWay.AutoSize = true;
            this.labelPayWay.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelPayWay.Location = new System.Drawing.Point(5, 5);
            this.labelPayWay.Name = "labelPayWay";
            this.labelPayWay.Size = new System.Drawing.Size(89, 19);
            this.labelPayWay.TabIndex = 3;
            this.labelPayWay.Text = "付款方式";
            // 
            // panelShopList
            // 
            this.panelShopList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShopList.Controls.Add(this.btnCleanList);
            this.panelShopList.Controls.Add(this.labelShopListShow);
            this.panelShopList.Controls.Add(this.labelShopList);
            this.panelShopList.Location = new System.Drawing.Point(522, 40);
            this.panelShopList.Name = "panelShopList";
            this.panelShopList.Size = new System.Drawing.Size(300, 350);
            this.panelShopList.TabIndex = 1;
            // 
            // btnCleanList
            // 
            this.btnCleanList.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCleanList.Location = new System.Drawing.Point(169, 290);
            this.btnCleanList.Name = "btnCleanList";
            this.btnCleanList.Size = new System.Drawing.Size(112, 40);
            this.btnCleanList.TabIndex = 4;
            this.btnCleanList.Text = "清除清單";
            this.btnCleanList.UseVisualStyleBackColor = true;
            this.btnCleanList.Click += new System.EventHandler(this.btnCleanList_Click);
            // 
            // labelShopListShow
            // 
            this.labelShopListShow.BackColor = System.Drawing.Color.White;
            this.labelShopListShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShopListShow.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShopListShow.Location = new System.Drawing.Point(14, 40);
            this.labelShopListShow.Name = "labelShopListShow";
            this.labelShopListShow.Size = new System.Drawing.Size(267, 228);
            this.labelShopListShow.TabIndex = 3;
            this.labelShopListShow.Text = "尚未點餐";
            this.labelShopListShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelShopList
            // 
            this.labelShopList.AutoSize = true;
            this.labelShopList.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShopList.Location = new System.Drawing.Point(5, 5);
            this.labelShopList.Name = "labelShopList";
            this.labelShopList.Size = new System.Drawing.Size(127, 19);
            this.labelShopList.TabIndex = 2;
            this.labelShopList.Text = "購物清單 List";
            // 
            // Form_HW03_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.panelShopList);
            this.Controls.Add(this.panelPayWay);
            this.Controls.Add(this.panelPrice);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form_HW03_POS";
            this.Text = "Bar POS";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            this.panelPayWay.ResumeLayout(false);
            this.panelPayWay.PerformLayout();
            this.panelShopList.ResumeLayout(false);
            this.panelShopList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.Panel panelPayWay;
        private System.Windows.Forms.Panel panelShopList;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.Label labelPayWay;
        private System.Windows.Forms.Button btnMBeer;
        private System.Windows.Forms.Label labelShopList;
        private System.Windows.Forms.Button btnMWine;
        private System.Windows.Forms.Button btnMWisky;
        private System.Windows.Forms.Button btnMTequila;
        private System.Windows.Forms.Label labelPriceShow;
        private System.Windows.Forms.Button btnPayCredit;
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.Button btnCleanList;
        private System.Windows.Forms.Label labelShopListShow;
    }
}