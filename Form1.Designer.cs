
namespace SCUD
{
    partial class Create
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCardNumber = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Otch = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Otch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Post = new System.Windows.Forms.TextBox();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_ReadCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCardNumber
            // 
            this.tbCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCardNumber.Location = new System.Drawing.Point(167, 292);
            this.tbCardNumber.Multiline = true;
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(223, 33);
            this.tbCardNumber.TabIndex = 5;
            this.tbCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCardNumber.Validated += new System.EventHandler(this.DisplayText);
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_LastName.Location = new System.Drawing.Point(30, 94);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(72, 18);
            this.lbl_LastName.TabIndex = 4;
            this.lbl_LastName.Text = "Фамилия";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Name.Location = new System.Drawing.Point(30, 145);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(40, 18);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Имя";
            // 
            // lbl_Otch
            // 
            this.lbl_Otch.AutoSize = true;
            this.lbl_Otch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Otch.Location = new System.Drawing.Point(30, 195);
            this.lbl_Otch.Name = "lbl_Otch";
            this.lbl_Otch.Size = new System.Drawing.Size(77, 18);
            this.lbl_Otch.TabIndex = 4;
            this.lbl_Otch.Text = "Отчество";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_LastName.Location = new System.Drawing.Point(167, 87);
            this.txt_LastName.Multiline = true;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(226, 34);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Name.Location = new System.Drawing.Point(167, 136);
            this.txt_Name.Multiline = true;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(226, 34);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Otch
            // 
            this.txt_Otch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Otch.Location = new System.Drawing.Point(167, 187);
            this.txt_Otch.Multiline = true;
            this.txt_Otch.Name = "txt_Otch";
            this.txt_Otch.Size = new System.Drawing.Size(226, 34);
            this.txt_Otch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Регистрация нового пользователя:";
            // 
            // txt_Post
            // 
            this.txt_Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Post.Location = new System.Drawing.Point(167, 239);
            this.txt_Post.Multiline = true;
            this.txt_Post.Name = "txt_Post";
            this.txt_Post.Size = new System.Drawing.Size(226, 34);
            this.txt_Post.TabIndex = 4;
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Post.Location = new System.Drawing.Point(30, 248);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(87, 18);
            this.lbl_Post.TabIndex = 4;
            this.lbl_Post.Text = "Должность";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.Location = new System.Drawing.Point(139, 353);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(146, 49);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "Записать в БД";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // btn_ReadCard
            // 
            this.btn_ReadCard.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ReadCard.Location = new System.Drawing.Point(12, 292);
            this.btn_ReadCard.Name = "btn_ReadCard";
            this.btn_ReadCard.Size = new System.Drawing.Size(134, 33);
            this.btn_ReadCard.TabIndex = 6;
            this.btn_ReadCard.Text = "Считать карту";
            this.btn_ReadCard.UseVisualStyleBackColor = true;
            this.btn_ReadCard.Click += new System.EventHandler(this.btn_ReadCard_Click);
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 425);
            this.Controls.Add(this.btn_ReadCard);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Post);
            this.Controls.Add(this.txt_Otch);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lbl_Post);
            this.Controls.Add(this.lbl_Otch);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.tbCardNumber);
            this.Name = "Create";
            this.Text = "Регистрация нового пользователя";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCardNumber;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Otch;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Otch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Post;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_ReadCard;
    }
}

