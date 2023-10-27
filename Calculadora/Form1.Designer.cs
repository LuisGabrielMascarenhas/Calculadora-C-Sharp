
namespace Calculadora
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
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.txtBoxN1 = new System.Windows.Forms.TextBox();
            this.txtBoxN2 = new System.Windows.Forms.TextBox();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(219, 66);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(84, 13);
            this.n1.TabIndex = 0;
            this.n1.Text = "Primeiro Número";
            this.n1.UseWaitCursor = true;
            this.n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(467, 66);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(90, 13);
            this.n2.TabIndex = 1;
            this.n2.Text = "Segundo Número";
            // 
            // txtBoxN1
            // 
            this.txtBoxN1.Location = new System.Drawing.Point(222, 93);
            this.txtBoxN1.Name = "txtBoxN1";
            this.txtBoxN1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxN1.TabIndex = 2;
            // 
            // txtBoxN2
            // 
            this.txtBoxN2.Location = new System.Drawing.Point(470, 93);
            this.txtBoxN2.Name = "txtBoxN2";
            this.txtBoxN2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxN2.TabIndex = 3;
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(315, 131);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(79, 70);
            this.btnSubtrair.TabIndex = 5;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(410, 131);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(80, 70);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "X";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(496, 131);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(74, 70);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            this.label1.UseWaitCursor = true;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(364, 230);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(36, 39);
            this.labelResultado.TabIndex = 10;
            this.labelResultado.Text = "0";
            this.labelResultado.UseWaitCursor = true;
            // 
            // btnSomar
            // 
            this.btnSomar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.Location = new System.Drawing.Point(222, 131);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(79, 70);
            this.btnSomar.TabIndex = 11;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.txtBoxN2);
            this.Controls.Add(this.txtBoxN1);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.TextBox txtBoxN1;
        private System.Windows.Forms.TextBox txtBoxN2;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button btnSomar;
    }
}

