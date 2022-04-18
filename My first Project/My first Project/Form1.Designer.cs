
namespace My_first_Project
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblcard = new System.Windows.Forms.Label();
            this.picClubs = new System.Windows.Forms.PictureBox();
            this.picSpades = new System.Windows.Forms.PictureBox();
            this.picJoker = new System.Windows.Forms.PictureBox();
            this.picHearts = new System.Windows.Forms.PictureBox();
            this.picDiamonds = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamonds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(189, 233);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnCalculateTax_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(156, 46);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(173, 15);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Click a Card to See Its Name";
            // 
            // lblcard
            // 
            this.lblcard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblcard.Location = new System.Drawing.Point(18, 206);
            this.lblcard.Name = "lblcard";
            this.lblcard.Size = new System.Drawing.Size(417, 20);
            this.lblcard.TabIndex = 7;
            this.lblcard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcard.Click += new System.EventHandler(this.label1_Click);
            // 
            // picClubs
            // 
            this.picClubs.Image = global::My_first_Project.Properties.Resources._2_Clubs;
            this.picClubs.Location = new System.Drawing.Point(21, 73);
            this.picClubs.Name = "picClubs";
            this.picClubs.Size = new System.Drawing.Size(78, 117);
            this.picClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClubs.TabIndex = 8;
            this.picClubs.TabStop = false;
            this.picClubs.Click += new System.EventHandler(this.picClubs_Click);
            // 
            // picSpades
            // 
            this.picSpades.Image = global::My_first_Project.Properties.Resources.King_Spades;
            this.picSpades.Location = new System.Drawing.Point(357, 73);
            this.picSpades.Name = "picSpades";
            this.picSpades.Size = new System.Drawing.Size(78, 117);
            this.picSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpades.TabIndex = 12;
            this.picSpades.TabStop = false;
            this.picSpades.Click += new System.EventHandler(this.picSpades_Click);
            // 
            // picJoker
            // 
            this.picJoker.Image = global::My_first_Project.Properties.Resources.Joker_Black;
            this.picJoker.Location = new System.Drawing.Point(273, 73);
            this.picJoker.Name = "picJoker";
            this.picJoker.Size = new System.Drawing.Size(78, 117);
            this.picJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJoker.TabIndex = 11;
            this.picJoker.TabStop = false;
            this.picJoker.Click += new System.EventHandler(this.picJoker_Click);
            // 
            // picHearts
            // 
            this.picHearts.Image = global::My_first_Project.Properties.Resources.Ace_Hearts;
            this.picHearts.Location = new System.Drawing.Point(189, 73);
            this.picHearts.Name = "picHearts";
            this.picHearts.Size = new System.Drawing.Size(78, 117);
            this.picHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHearts.TabIndex = 10;
            this.picHearts.TabStop = false;
            this.picHearts.Click += new System.EventHandler(this.picHearts_Click);
            // 
            // picDiamonds
            // 
            this.picDiamonds.Image = global::My_first_Project.Properties.Resources._7_Diamonds;
            this.picDiamonds.Location = new System.Drawing.Point(105, 73);
            this.picDiamonds.Name = "picDiamonds";
            this.picDiamonds.Size = new System.Drawing.Size(78, 117);
            this.picDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiamonds.TabIndex = 9;
            this.picDiamonds.TabStop = false;
            this.picDiamonds.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 263);
            this.Controls.Add(this.picSpades);
            this.Controls.Add(this.picJoker);
            this.Controls.Add(this.picHearts);
            this.Controls.Add(this.picDiamonds);
            this.Controls.Add(this.picClubs);
            this.Controls.Add(this.lblcard);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Pick a Card Any Card!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamonds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblcard;
        private System.Windows.Forms.PictureBox picClubs;
        private System.Windows.Forms.PictureBox picSpades;
        private System.Windows.Forms.PictureBox picJoker;
        private System.Windows.Forms.PictureBox picHearts;
        private System.Windows.Forms.PictureBox picDiamonds;
    }
}

