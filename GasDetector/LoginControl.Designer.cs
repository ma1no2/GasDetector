namespace GasDetector
{
    partial class LoginControl
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
            btnClickThis = new Button();
            lblHelloWorld = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(394, 299);
            btnClickThis.Margin = new Padding(4, 4, 4, 4);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(206, 36);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "Login";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(326, 224);
            lblHelloWorld.Margin = new Padding(4, 0, 4, 0);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(65, 25);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 264);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 224);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(394, 261);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 31);
            textBox2.TabIndex = 4;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(428, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(137, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register instead";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 562);
            Controls.Add(linkLabel1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickThis);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblHelloWorld;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private LinkLabel linkLabel1;
    }
}
