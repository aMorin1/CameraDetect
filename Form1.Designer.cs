using System;

namespace CameraDetect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.imgBox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.TxtBoxNom = new System.Windows.Forms.TextBox();
            this.TxtBoxPrenom = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.LblBDD = new System.Windows.Forms.Label();
            this.imgBoxSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxSave)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgBox.Location = new System.Drawing.Point(13, 13);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(500, 439);
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "BADGEUSE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom :";
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.BtnStart.Location = new System.Drawing.Point(351, 458);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(162, 45);
            this.BtnStart.TabIndex = 6;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click_1);
            // 
            // BtnAjout
            // 
            this.BtnAjout.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjout.Location = new System.Drawing.Point(632, 458);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(126, 45);
            this.BtnAjout.TabIndex = 7;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // TxtBoxNom
            // 
            this.TxtBoxNom.Location = new System.Drawing.Point(586, 355);
            this.TxtBoxNom.Name = "TxtBoxNom";
            this.TxtBoxNom.Size = new System.Drawing.Size(172, 20);
            this.TxtBoxNom.TabIndex = 8;
            // 
            // TxtBoxPrenom
            // 
            this.TxtBoxPrenom.Location = new System.Drawing.Point(586, 387);
            this.TxtBoxPrenom.Name = "TxtBoxPrenom";
            this.TxtBoxPrenom.Size = new System.Drawing.Size(172, 20);
            this.TxtBoxPrenom.TabIndex = 9;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(519, 297);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(239, 34);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Sauvegarder";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQuitter.Location = new System.Drawing.Point(13, 458);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(147, 45);
            this.BtnQuitter.TabIndex = 11;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // LblBDD
            // 
            this.LblBDD.AutoSize = true;
            this.LblBDD.BackColor = System.Drawing.Color.Silver;
            this.LblBDD.Location = new System.Drawing.Point(519, 13);
            this.LblBDD.Name = "LblBDD";
            this.LblBDD.Size = new System.Drawing.Size(30, 13);
            this.LblBDD.TabIndex = 12;
            this.LblBDD.Text = "BDD";
            // 
            // imgBoxSave
            // 
            this.imgBoxSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBoxSave.Location = new System.Drawing.Point(519, 45);
            this.imgBoxSave.Name = "imgBoxSave";
            this.imgBoxSave.Size = new System.Drawing.Size(239, 246);
            this.imgBoxSave.TabIndex = 13;
            this.imgBoxSave.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(770, 506);
            this.Controls.Add(this.imgBoxSave);
            this.Controls.Add(this.LblBDD);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtBoxPrenom);
            this.Controls.Add(this.TxtBoxNom);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBox);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Emgu.CV.UI.ImageBox imgBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.TextBox TxtBoxNom;
        private System.Windows.Forms.TextBox TxtBoxPrenom;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label LblBDD;
        private System.Windows.Forms.PictureBox imgBoxSave;
    }
    #endregion
}