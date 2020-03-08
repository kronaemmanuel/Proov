namespace Proov
{
    partial class FormAddQuiz
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
            this.txtbx_quizName = new System.Windows.Forms.TextBox();
            this.lbl_quizName = new System.Windows.Forms.Label();
            this.btn_addQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_quizName
            // 
            this.txtbx_quizName.Location = new System.Drawing.Point(165, 38);
            this.txtbx_quizName.Name = "txtbx_quizName";
            this.txtbx_quizName.Size = new System.Drawing.Size(100, 20);
            this.txtbx_quizName.TabIndex = 0;
            // 
            // lbl_quizName
            // 
            this.lbl_quizName.AutoSize = true;
            this.lbl_quizName.Location = new System.Drawing.Point(98, 41);
            this.lbl_quizName.Name = "lbl_quizName";
            this.lbl_quizName.Size = new System.Drawing.Size(59, 13);
            this.lbl_quizName.TabIndex = 1;
            this.lbl_quizName.Text = "Quiz Name";
            // 
            // btn_addQuiz
            // 
            this.btn_addQuiz.Location = new System.Drawing.Point(190, 74);
            this.btn_addQuiz.Name = "btn_addQuiz";
            this.btn_addQuiz.Size = new System.Drawing.Size(75, 23);
            this.btn_addQuiz.TabIndex = 2;
            this.btn_addQuiz.Text = "Add Quiz";
            this.btn_addQuiz.UseVisualStyleBackColor = true;
            this.btn_addQuiz.Click += new System.EventHandler(this.Btn_AddQuiz_Click);
            // 
            // frm_addQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 127);
            this.Controls.Add(this.btn_addQuiz);
            this.Controls.Add(this.lbl_quizName);
            this.Controls.Add(this.txtbx_quizName);
            this.Name = "FormAddQuiz";
            this.Text = "Add New Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_quizName;
        private System.Windows.Forms.Label lbl_quizName;
        private System.Windows.Forms.Button btn_addQuiz;
    }
}

