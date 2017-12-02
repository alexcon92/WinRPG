namespace WinRPG
{
    partial class frmCharacterCreation
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
            this.btnCCStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCCStartGame
            // 
            this.btnCCStartGame.Location = new System.Drawing.Point(592, 352);
            this.btnCCStartGame.Name = "btnCCStartGame";
            this.btnCCStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnCCStartGame.TabIndex = 0;
            this.btnCCStartGame.Text = "Start Game";
            this.btnCCStartGame.UseVisualStyleBackColor = true;
            this.btnCCStartGame.Click += new System.EventHandler(this.btnCCStartGame_Click);
            // 
            // frmCharacterCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 387);
            this.Controls.Add(this.btnCCStartGame);
            this.Name = "frmCharacterCreation";
            this.Text = "frmCharacterCreation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCCStartGame;
    }
}