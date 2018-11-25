namespace CastleWindsorDI_Example.Views
{
    partial class MainView
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnArrest = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnRobBank = new System.Windows.Forms.Button();
            this.btnWhoWeAre = new System.Windows.Forms.Button();
            this.btnCriminalShootGun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(48, 72);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(127, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Typed Factory: Message:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(181, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(16, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "...";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(316, 124);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 2;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnArrest
            // 
            this.btnArrest.Location = new System.Drawing.Point(208, 124);
            this.btnArrest.Name = "btnArrest";
            this.btnArrest.Size = new System.Drawing.Size(102, 23);
            this.btnArrest.TabIndex = 3;
            this.btnArrest.Text = "Arrest Criminal";
            this.btnArrest.UseVisualStyleBackColor = true;
            this.btnArrest.Click += new System.EventHandler(this.btnArrest_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(107, 124);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(95, 23);
            this.btnShoot.TabIndex = 4;
            this.btnShoot.Text = "Shoot Criminal";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnRobBank
            // 
            this.btnRobBank.Location = new System.Drawing.Point(26, 124);
            this.btnRobBank.Name = "btnRobBank";
            this.btnRobBank.Size = new System.Drawing.Size(75, 23);
            this.btnRobBank.TabIndex = 5;
            this.btnRobBank.Text = "Rob Bank";
            this.btnRobBank.UseVisualStyleBackColor = true;
            this.btnRobBank.Click += new System.EventHandler(this.btnRobBank_Click);
            // 
            // btnWhoWeAre
            // 
            this.btnWhoWeAre.Location = new System.Drawing.Point(397, 124);
            this.btnWhoWeAre.Name = "btnWhoWeAre";
            this.btnWhoWeAre.Size = new System.Drawing.Size(106, 23);
            this.btnWhoWeAre.TabIndex = 6;
            this.btnWhoWeAre.Text = "Who We Are";
            this.btnWhoWeAre.UseVisualStyleBackColor = true;
            this.btnWhoWeAre.Click += new System.EventHandler(this.btnWhoWeAre_Click);
            // 
            // btnCriminalShootGun
            // 
            this.btnCriminalShootGun.AutoEllipsis = true;
            this.btnCriminalShootGun.Location = new System.Drawing.Point(107, 165);
            this.btnCriminalShootGun.Name = "btnCriminalShootGun";
            this.btnCriminalShootGun.Size = new System.Drawing.Size(159, 23);
            this.btnCriminalShootGun.TabIndex = 7;
            this.btnCriminalShootGun.Text = "Criminal Shoot Gun";
            this.btnCriminalShootGun.UseVisualStyleBackColor = true;
            this.btnCriminalShootGun.Click += new System.EventHandler(this.btnCriminalShootGun_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 200);
            this.Controls.Add(this.btnCriminalShootGun);
            this.Controls.Add(this.btnWhoWeAre);
            this.Controls.Add(this.btnRobBank);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnArrest);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lbl1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnArrest;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnRobBank;
        private System.Windows.Forms.Button btnWhoWeAre;
        private System.Windows.Forms.Button btnCriminalShootGun;
    }
}

