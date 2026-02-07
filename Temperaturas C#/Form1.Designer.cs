namespace Temperaturas_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnaceptar = new Button();
            btncancelar = new Button();
            lblcelcius = new Label();
            lblfahrenheit = new Label();
            lblkelvin = new Label();
            txtcelcius = new TextBox();
            txtkelvin = new TextBox();
            txtfahrenheit = new TextBox();
            gptemperatura = new GroupBox();
            rbkelvin = new RadioButton();
            rbFahrenheit = new RadioButton();
            rbcelcius = new RadioButton();
            gptemperatura.SuspendLayout();
            SuspendLayout();
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(18, 278);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(110, 55);
            btnaceptar.TabIndex = 0;
            btnaceptar.Text = "aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(172, 278);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(110, 55);
            btncancelar.TabIndex = 1;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // lblcelcius
            // 
            lblcelcius.AutoSize = true;
            lblcelcius.Location = new Point(18, 41);
            lblcelcius.Name = "lblcelcius";
            lblcelcius.Size = new Size(45, 15);
            lblcelcius.TabIndex = 2;
            lblcelcius.Text = "Celcius";
            // 
            // lblfahrenheit
            // 
            lblfahrenheit.AutoSize = true;
            lblfahrenheit.Location = new Point(18, 89);
            lblfahrenheit.Name = "lblfahrenheit";
            lblfahrenheit.Size = new Size(63, 15);
            lblfahrenheit.TabIndex = 3;
            lblfahrenheit.Text = "Fahrenheit";
            // 
            // lblkelvin
            // 
            lblkelvin.AutoSize = true;
            lblkelvin.Location = new Point(18, 131);
            lblkelvin.Name = "lblkelvin";
            lblkelvin.Size = new Size(39, 15);
            lblkelvin.TabIndex = 4;
            lblkelvin.Text = "Kelvin";
            // 
            // txtcelcius
            // 
            txtcelcius.Location = new Point(69, 41);
            txtcelcius.Name = "txtcelcius";
            txtcelcius.Size = new Size(131, 23);
            txtcelcius.TabIndex = 5;
            // 
            // txtkelvin
            // 
            txtkelvin.Location = new Point(84, 127);
            txtkelvin.Name = "txtkelvin";
            txtkelvin.Size = new Size(131, 23);
            txtkelvin.TabIndex = 6;
            // 
            // txtfahrenheit
            // 
            txtfahrenheit.Location = new Point(84, 81);
            txtfahrenheit.Name = "txtfahrenheit";
            txtfahrenheit.Size = new Size(131, 23);
            txtfahrenheit.TabIndex = 7;
            // 
            // gptemperatura
            // 
            gptemperatura.Controls.Add(rbkelvin);
            gptemperatura.Controls.Add(rbFahrenheit);
            gptemperatura.Controls.Add(rbcelcius);
            gptemperatura.Location = new Point(18, 191);
            gptemperatura.Name = "gptemperatura";
            gptemperatura.Size = new Size(236, 59);
            gptemperatura.TabIndex = 8;
            gptemperatura.TabStop = false;
            gptemperatura.Text = "Seleccione su temperatura de entrada";
            // 
            // rbkelvin
            // 
            rbkelvin.AutoSize = true;
            rbkelvin.Location = new Point(156, 31);
            rbkelvin.Name = "rbkelvin";
            rbkelvin.Size = new Size(56, 19);
            rbkelvin.TabIndex = 2;
            rbkelvin.TabStop = true;
            rbkelvin.Text = "kelvin";
            rbkelvin.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit
            // 
            rbFahrenheit.AutoSize = true;
            rbFahrenheit.Location = new Point(69, 31);
            rbFahrenheit.Name = "rbFahrenheit";
            rbFahrenheit.Size = new Size(81, 19);
            rbFahrenheit.TabIndex = 1;
            rbFahrenheit.TabStop = true;
            rbFahrenheit.Text = "Fahrenheit";
            rbFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbcelcius
            // 
            rbcelcius.AutoSize = true;
            rbcelcius.Location = new Point(0, 31);
            rbcelcius.Name = "rbcelcius";
            rbcelcius.Size = new Size(63, 19);
            rbcelcius.TabIndex = 0;
            rbcelcius.TabStop = true;
            rbcelcius.Text = "Celcius";
            rbcelcius.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 345);
            Controls.Add(gptemperatura);
            Controls.Add(txtfahrenheit);
            Controls.Add(txtkelvin);
            Controls.Add(txtcelcius);
            Controls.Add(lblkelvin);
            Controls.Add(lblfahrenheit);
            Controls.Add(lblcelcius);
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gptemperatura.ResumeLayout(false);
            gptemperatura.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaceptar;
        private Button btncancelar;
        private Label lblcelcius;
        private Label lblfahrenheit;
        private Label lblkelvin;
        private TextBox txtcelcius;
        private TextBox txtkelvin;
        private TextBox txtfahrenheit;
        private GroupBox gptemperatura;
        private RadioButton rbkelvin;
        private RadioButton rbFahrenheit;
        private RadioButton rbcelcius;
    }
}
