namespace Ferrari_VeloStreak
{
    partial class createTraining
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
            panel1 = new Panel();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            textBoxDescription = new RichTextBox();
            textBoxType = new TextBox();
            label3 = new Label();
            buttonCreate = new Button();
            panel2 = new Panel();
            listView1 = new ListView();
            labelExercises = new Label();
            textBoxExName = new TextBox();
            label4 = new Label();
            textBoxExDuration = new TextBox();
            label5 = new Label();
            textBoxExZone = new TextBox();
            label6 = new Label();
            textBoxExPower = new TextBox();
            label7 = new Label();
            textBoxExFC = new TextBox();
            label8 = new Label();
            buttonAdd = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(buttonCreate);
            panel1.Controls.Add(textBoxType);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxDescription);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 378);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Session Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(14, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(173, 23);
            textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 2;
            label2.Text = "Session Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(14, 82);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(173, 96);
            textBoxDescription.TabIndex = 4;
            textBoxDescription.Text = "";
            // 
            // textBoxType
            // 
            textBoxType.Location = new Point(14, 208);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(173, 23);
            textBoxType.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 190);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 5;
            label3.Text = "Session Type";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(65, 344);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Create Session";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(textBoxExFC);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxExPower);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxExZone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxExDuration);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxExName);
            panel2.Controls.Add(labelExercises);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(218, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 378);
            panel2.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 29);
            listView1.Name = "listView1";
            listView1.Size = new Size(222, 338);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // labelExercises
            // 
            labelExercises.AutoSize = true;
            labelExercises.Location = new Point(13, 11);
            labelExercises.Name = "labelExercises";
            labelExercises.Size = new Size(54, 15);
            labelExercises.TabIndex = 1;
            labelExercises.Text = "Exercises";
            // 
            // textBoxExName
            // 
            textBoxExName.Location = new Point(258, 47);
            textBoxExName.Name = "textBoxExName";
            textBoxExName.Size = new Size(256, 23);
            textBoxExName.TabIndex = 9;
            textBoxExName.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 29);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 8;
            label4.Text = "Exercise Name";
            label4.Click += this.label4_Click;
            // 
            // textBoxExDuration
            // 
            textBoxExDuration.Location = new Point(258, 100);
            textBoxExDuration.Name = "textBoxExDuration";
            textBoxExDuration.Size = new Size(256, 23);
            textBoxExDuration.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 82);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 10;
            label5.Text = "Exercise Duration";
            // 
            // textBoxExZone
            // 
            textBoxExZone.Location = new Point(258, 158);
            textBoxExZone.Name = "textBoxExZone";
            textBoxExZone.Size = new Size(256, 23);
            textBoxExZone.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 140);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 12;
            label6.Text = "Zone";
            // 
            // textBoxExPower
            // 
            textBoxExPower.Location = new Point(258, 217);
            textBoxExPower.Name = "textBoxExPower";
            textBoxExPower.Size = new Size(256, 23);
            textBoxExPower.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(258, 199);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 14;
            label7.Text = "Expected Power (W)";
            // 
            // textBoxExFC
            // 
            textBoxExFC.Location = new Point(258, 275);
            textBoxExFC.Name = "textBoxExFC";
            textBoxExFC.Size = new Size(256, 23);
            textBoxExFC.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 257);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 16;
            label8.Text = "Exercise FC";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(356, 344);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add Exercise";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // createTraining
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new Size(784, 441);
            MinimumSize = new Size(784, 441);
            Name = "createTraining";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "createTraining";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RichTextBox textBoxDescription;
        private Label label2;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxType;
        private Label label3;
        private Button buttonCreate;
        private Panel panel2;
        private Label labelExercises;
        private ListView listView1;
        private TextBox textBoxExName;
        private Label label4;
        private TextBox textBoxExDuration;
        private Label label5;
        private TextBox textBoxExFC;
        private Label label8;
        private TextBox textBoxExPower;
        private Label label7;
        private TextBox textBoxExZone;
        private Label label6;
        private Button buttonAdd;
    }
}