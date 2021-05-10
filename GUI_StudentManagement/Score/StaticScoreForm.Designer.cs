
namespace GUI_StudentManagement.Score
{
    partial class StaticScoreForm
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
            this.LabelStatic = new System.Windows.Forms.Label();
            this.labelXuatsac = new System.Windows.Forms.Label();
            this.labelGioi = new System.Windows.Forms.Label();
            this.labelKha = new System.Windows.Forms.Label();
            this.labelTrungBinh = new System.Windows.Forms.Label();
            this.labelYeu = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelAVG = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // LabelStatic
            // 
            this.LabelStatic.AutoSize = true;
            this.LabelStatic.Location = new System.Drawing.Point(223, 23);
            this.LabelStatic.Name = "LabelStatic";
            this.LabelStatic.Size = new System.Drawing.Size(70, 13);
            this.LabelStatic.TabIndex = 1;
            this.LabelStatic.Text = "static student";
            // 
            // labelXuatsac
            // 
            this.labelXuatsac.AutoSize = true;
            this.labelXuatsac.Location = new System.Drawing.Point(485, 80);
            this.labelXuatsac.Name = "labelXuatsac";
            this.labelXuatsac.Size = new System.Drawing.Size(70, 13);
            this.labelXuatsac.TabIndex = 2;
            this.labelXuatsac.Text = "static student";
            // 
            // labelGioi
            // 
            this.labelGioi.AutoSize = true;
            this.labelGioi.Location = new System.Drawing.Point(485, 135);
            this.labelGioi.Name = "labelGioi";
            this.labelGioi.Size = new System.Drawing.Size(70, 13);
            this.labelGioi.TabIndex = 3;
            this.labelGioi.Text = "static student";
            // 
            // labelKha
            // 
            this.labelKha.AutoSize = true;
            this.labelKha.Location = new System.Drawing.Point(485, 198);
            this.labelKha.Name = "labelKha";
            this.labelKha.Size = new System.Drawing.Size(70, 13);
            this.labelKha.TabIndex = 4;
            this.labelKha.Text = "static student";
            // 
            // labelTrungBinh
            // 
            this.labelTrungBinh.AutoSize = true;
            this.labelTrungBinh.Location = new System.Drawing.Point(485, 269);
            this.labelTrungBinh.Name = "labelTrungBinh";
            this.labelTrungBinh.Size = new System.Drawing.Size(70, 13);
            this.labelTrungBinh.TabIndex = 5;
            this.labelTrungBinh.Text = "static student";
            // 
            // labelYeu
            // 
            this.labelYeu.AutoSize = true;
            this.labelYeu.Location = new System.Drawing.Point(485, 329);
            this.labelYeu.Name = "labelYeu";
            this.labelYeu.Size = new System.Drawing.Size(70, 13);
            this.labelYeu.TabIndex = 6;
            this.labelYeu.Text = "static student";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(608, 37);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(77, 13);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "Student Result";
            // 
            // panelAVG
            // 
            this.panelAVG.Location = new System.Drawing.Point(51, 80);
            this.panelAVG.Name = "panelAVG";
            this.panelAVG.Size = new System.Drawing.Size(352, 331);
            this.panelAVG.TabIndex = 8;
            // 
            // StaticScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAVG);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelYeu);
            this.Controls.Add(this.labelTrungBinh);
            this.Controls.Add(this.labelKha);
            this.Controls.Add(this.labelGioi);
            this.Controls.Add(this.labelXuatsac);
            this.Controls.Add(this.LabelStatic);
            this.Name = "StaticScoreForm";
            this.Text = "StaticScoreForm";
            this.Load += new System.EventHandler(this.StaticScoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelStatic;
        private System.Windows.Forms.Label labelXuatsac;
        private System.Windows.Forms.Label labelGioi;
        private System.Windows.Forms.Label labelKha;
        private System.Windows.Forms.Label labelTrungBinh;
        private System.Windows.Forms.Label labelYeu;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.FlowLayoutPanel panelAVG;
    }
}