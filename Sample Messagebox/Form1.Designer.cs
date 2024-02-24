namespace Sample_Messagebox
{
    partial class frmmessagebox
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
            btnnext = new Button();
            btnnext2 = new Button();
            btnnext3 = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            SuspendLayout();
            // 
            // btnnext
            // 
            btnnext.Location = new Point(45, 26);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(151, 56);
            btnnext.TabIndex = 0;
            btnnext.Text = "Next 1";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnnext2
            // 
            btnnext2.Location = new Point(240, 26);
            btnnext2.Name = "btnnext2";
            btnnext2.Size = new Size(165, 56);
            btnnext2.TabIndex = 1;
            btnnext2.Text = "Next 2";
            btnnext2.UseVisualStyleBackColor = true;
            btnnext2.Click += btnnext2_Click;
            // 
            // btnnext3
            // 
            btnnext3.Location = new Point(457, 26);
            btnnext3.Name = "btnnext3";
            btnnext3.Size = new Size(158, 56);
            btnnext3.TabIndex = 2;
            btnnext3.Text = "Next 3";
            btnnext3.UseVisualStyleBackColor = true;
            btnnext3.Click += btnnext3_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(112, 165);
            txt1.Name = "txt1";
            txt1.Size = new Size(230, 23);
            txt1.TabIndex = 3;
            // 
            // txt2
            // 
            txt2.Location = new Point(448, 165);
            txt2.Name = "txt2";
            txt2.Size = new Size(230, 23);
            txt2.TabIndex = 4;
            // 
            // frmmessagebox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnnext3);
            Controls.Add(btnnext2);
            Controls.Add(btnnext);
            Name = "frmmessagebox";
            Text = "Messagebox";
            Load += frmmessagebox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnnext;
        private Button btnnext2;
        private Button btnnext3;
        private TextBox txt1;
        private TextBox txt2;
    }
}
