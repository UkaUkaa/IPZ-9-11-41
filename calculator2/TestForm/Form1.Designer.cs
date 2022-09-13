namespace TestForm
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
            this.components = new System.ComponentModel.Container();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.operation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(12, 83);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(125, 27);
            this.number1.TabIndex = 0;
            this.number1.Text = "1";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(223, 83);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(125, 27);
            this.number2.TabIndex = 1;
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.operation.Location = new System.Drawing.Point(98, 161);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(151, 28);
            this.operation.TabIndex = 3;
            this.operation.SelectedIndexChanged += new System.EventHandler(this.operation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Число 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число 2";
            // 
            // resultButton
            // 
            this.resultButton.Location = new System.Drawing.Point(139, 224);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(94, 29);
            this.resultButton.TabIndex = 6;
            this.resultButton.Text = "Результат";
            this.resultButton.UseVisualStyleBackColor = true;
            this.resultButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(98, 351);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(125, 27);
            this.result.TabIndex = 8;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox number1;
        private TextBox number2;
        private ComboBox operation;
        private Label label1;
        private Label label2;
        private Button resultButton;
        private Label label3;
        private TextBox result;
        private System.Windows.Forms.Timer timer1;
    }
}