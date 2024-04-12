namespace TLV
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
            dataText = new TextBox();
            start = new Button();
            treeView1 = new TreeView();
            clearBtn = new Button();
            calculateBtn = new Button();
            lengthBtn = new Button();
            asciiBtn = new Button();
            aidBtn = new Button();
            exportBtn = new Button();
            btnRemove = new Button();
            negativeBtn = new Button();
            positiveBtn = new Button();
            SuspendLayout();
            // 
            // dataText
            // 
            dataText.BackColor = SystemColors.Control;
            dataText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dataText.Location = new Point(1287, 12);
            dataText.Multiline = true;
            dataText.Name = "dataText";
            dataText.ScrollBars = ScrollBars.Vertical;
            dataText.Size = new Size(494, 431);
            dataText.TabIndex = 0;
            // 
            // start
            // 
            start.Location = new Point(1287, 449);
            start.Name = "start";
            start.Size = new Size(94, 57);
            start.TabIndex = 1;
            start.Text = "PARSER";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // treeView1
            // 
            treeView1.AllowDrop = true;
            treeView1.BackColor = SystemColors.Control;
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Font = new Font("Cascadia Mono", 18F, FontStyle.Regular, GraphicsUnit.Point);
            treeView1.LabelEdit = true;
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.ShowNodeToolTips = true;
            treeView1.Size = new Size(1269, 550);
            treeView1.TabIndex = 2;
            treeView1.DoubleClick += treeView1_DoubleClick;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(1387, 449);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(94, 57);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(1487, 449);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(94, 57);
            calculateBtn.TabIndex = 4;
            calculateBtn.Text = "CALCULATE";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // lengthBtn
            // 
            lengthBtn.Location = new Point(1287, 505);
            lengthBtn.Name = "lengthBtn";
            lengthBtn.Size = new Size(94, 57);
            lengthBtn.TabIndex = 5;
            lengthBtn.Text = "LENGTH";
            lengthBtn.UseVisualStyleBackColor = true;
            lengthBtn.Click += lengthBtn_Click;
            // 
            // asciiBtn
            // 
            asciiBtn.Location = new Point(1387, 505);
            asciiBtn.Name = "asciiBtn";
            asciiBtn.Size = new Size(94, 57);
            asciiBtn.TabIndex = 6;
            asciiBtn.Text = "ASCII";
            asciiBtn.UseVisualStyleBackColor = true;
            asciiBtn.Click += asciiBtn_Click;
            // 
            // aidBtn
            // 
            aidBtn.Location = new Point(1487, 505);
            aidBtn.Name = "aidBtn";
            aidBtn.Size = new Size(94, 57);
            aidBtn.TabIndex = 7;
            aidBtn.Text = "AID";
            aidBtn.UseVisualStyleBackColor = true;
            aidBtn.Click += aidBtn_Click;
            // 
            // exportBtn
            // 
            exportBtn.Location = new Point(1587, 449);
            exportBtn.Name = "exportBtn";
            exportBtn.Size = new Size(94, 57);
            exportBtn.TabIndex = 8;
            exportBtn.Text = "EXPORT";
            exportBtn.UseVisualStyleBackColor = true;
            exportBtn.Click += exportBtn_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(1587, 505);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 57);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // negativeBtn
            // 
            negativeBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            negativeBtn.Location = new Point(1687, 505);
            negativeBtn.Name = "negativeBtn";
            negativeBtn.Size = new Size(94, 57);
            negativeBtn.TabIndex = 11;
            negativeBtn.Text = "-";
            negativeBtn.UseVisualStyleBackColor = true;
            negativeBtn.Click += negativeBtn_Click;
            // 
            // positiveBtn
            // 
            positiveBtn.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            positiveBtn.Location = new Point(1687, 449);
            positiveBtn.Name = "positiveBtn";
            positiveBtn.Size = new Size(94, 57);
            positiveBtn.TabIndex = 10;
            positiveBtn.Text = "+";
            positiveBtn.UseVisualStyleBackColor = true;
            positiveBtn.Click += positiveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1793, 698);
            Controls.Add(negativeBtn);
            Controls.Add(positiveBtn);
            Controls.Add(btnRemove);
            Controls.Add(exportBtn);
            Controls.Add(aidBtn);
            Controls.Add(asciiBtn);
            Controls.Add(lengthBtn);
            Controls.Add(calculateBtn);
            Controls.Add(clearBtn);
            Controls.Add(treeView1);
            Controls.Add(start);
            Controls.Add(dataText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dataText;
        private Button start;
        private TreeView treeView1;
        private Button clearBtn;
        private Button calculateBtn;
        private Button lengthBtn;
        private Button asciiBtn;
        private Button exportBtn;
        private Button aidBtn;
        private Button btnRemove;
        private Button negativeBtn;
        private Button positiveBtn;
    }
}
