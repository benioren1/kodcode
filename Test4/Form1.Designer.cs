namespace Test4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cmbday = new ComboBox();
            cmbmunth2 = new ComboBox();
            cmbmunth = new ComboBox();
            cmbyear = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbday
            // 
            cmbday.FormattingEnabled = true;
            cmbday.Items.AddRange(new object[] { "ראשון", "שני", "שלישי", "רביעי", "חמישי", "שישי" });
            cmbday.Location = new Point(599, 197);
            cmbday.Name = "cmbday";
            cmbday.Size = new Size(128, 28);
            cmbday.TabIndex = 0;
            // 
            // cmbmunth2
            // 
            cmbmunth2.FormattingEnabled = true;
            cmbmunth2.Items.AddRange(new object[] { "אלול", "תשרי", "חשוון", "כסליו", "טבת", "שבט", "אדר", "ניסן", "סיוון", "אייר", "תמוז", "אב " });
            cmbmunth2.Location = new Point(240, 197);
            cmbmunth2.Name = "cmbmunth2";
            cmbmunth2.Size = new Size(128, 28);
            cmbmunth2.TabIndex = 1;
            // 
            // cmbmunth
            // 
            cmbmunth.FormattingEnabled = true;
            cmbmunth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cmbmunth.Location = new Point(424, 197);
            cmbmunth.Name = "cmbmunth";
            cmbmunth.Size = new Size(128, 28);
            cmbmunth.TabIndex = 2;
            // 
            // cmbyear
            // 
            cmbyear.FormattingEnabled = true;
            cmbyear.Items.AddRange(new object[] { "תשפד", "תשפה", "תשפז", "תשפח", "תשפט" });
            cmbyear.Location = new Point(43, 197);
            cmbyear.Name = "cmbyear";
            cmbyear.Size = new Size(128, 28);
            cmbyear.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(328, 62);
            label1.Name = "label1";
            label1.Size = new Size(150, 31);
            label1.TabIndex = 4;
            label1.Text = "כתיבת תאריך";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.Location = new Point(87, 143);
            label2.Name = "label2";
            label2.Size = new Size(49, 29);
            label2.TabIndex = 5;
            label2.Text = "שנה";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(280, 143);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 6;
            label3.Text = "חודש";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.Location = new Point(431, 143);
            label4.Name = "label4";
            label4.Size = new Size(120, 29);
            label4.TabIndex = 7;
            label4.Text = "היום בחודש";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.Location = new Point(603, 143);
            label5.Name = "label5";
            label5.Size = new Size(121, 29);
            label5.TabIndex = 8;
            label5.Text = "היום בשבוע";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F);
            button1.Location = new Point(307, 352);
            button1.Name = "button1";
            button1.Size = new Size(149, 63);
            button1.TabIndex = 9;
            button1.Text = "החזרת תאריך עיברי";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbyear);
            Controls.Add(cmbmunth);
            Controls.Add(cmbmunth2);
            Controls.Add(cmbday);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbday;
        private ComboBox cmbmunth2;
        private ComboBox cmbmunth;
        private ComboBox cmbyear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}
