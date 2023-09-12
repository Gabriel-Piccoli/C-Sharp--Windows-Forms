namespace CadastroDeClientes
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 73);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(269, 141);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "CPF:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 205);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 268);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(269, 333);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Endereço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(195, 408);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 5;
            label6.Text = "Data de Nascimento:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(375, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 27);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(375, 268);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 27);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(375, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 27);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(630, 492);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(279, 492);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 13;
            button2.Text = "SAIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(375, 408);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 710);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro de Cliente";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
    }
}