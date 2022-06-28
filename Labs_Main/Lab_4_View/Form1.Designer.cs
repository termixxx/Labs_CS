
namespace Lab_4_View
{
    partial class Form1
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
            this.objectFieldsListBox = new System.Windows.Forms.ListBox();
            this.methodsFieldsListBox = new System.Windows.Forms.ListBox();
            this.ObjComboBox = new System.Windows.Forms.ComboBox();
            this.MethodsComboBox = new System.Windows.Forms.ComboBox();
            this.CreateObjButton = new System.Windows.Forms.Button();
            this.InputFieldsButton = new System.Windows.Forms.Button();
            this.RunMethodButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // objectFieldsListBox
            // 
            this.objectFieldsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.objectFieldsListBox.FormattingEnabled = true;
            this.objectFieldsListBox.ItemHeight = 20;
            this.objectFieldsListBox.Location = new System.Drawing.Point(30, 39);
            this.objectFieldsListBox.Name = "objectFieldsListBox";
            this.objectFieldsListBox.Size = new System.Drawing.Size(223, 124);
            this.objectFieldsListBox.TabIndex = 12;
            this.objectFieldsListBox.SelectedIndexChanged += new System.EventHandler(this.objectFieldsListBox_SelectedIndexChanged);
            // 
            // methodsFieldsListBox
            // 
            this.methodsFieldsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.methodsFieldsListBox.FormattingEnabled = true;
            this.methodsFieldsListBox.ItemHeight = 20;
            this.methodsFieldsListBox.Location = new System.Drawing.Point(300, 39);
            this.methodsFieldsListBox.Name = "methodsFieldsListBox";
            this.methodsFieldsListBox.Size = new System.Drawing.Size(223, 124);
            this.methodsFieldsListBox.TabIndex = 13;
            this.methodsFieldsListBox.SelectedIndexChanged += new System.EventHandler(this.methodsFieldsListBox_SelectedIndexChanged);
            // 
            // ObjComboBox
            // 
            this.ObjComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ObjComboBox.FormattingEnabled = true;
            this.ObjComboBox.Location = new System.Drawing.Point(163, 180);
            this.ObjComboBox.Name = "ObjComboBox";
            this.ObjComboBox.Size = new System.Drawing.Size(121, 28);
            this.ObjComboBox.TabIndex = 16;
            this.ObjComboBox.SelectedIndexChanged += new System.EventHandler(this.ObjComboBox_SelectedIndexChanged_1);
            // 
            // MethodsComboBox
            // 
            this.MethodsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.MethodsComboBox.FormattingEnabled = true;
            this.MethodsComboBox.Location = new System.Drawing.Point(163, 226);
            this.MethodsComboBox.Name = "MethodsComboBox";
            this.MethodsComboBox.Size = new System.Drawing.Size(121, 28);
            this.MethodsComboBox.TabIndex = 18;
            this.MethodsComboBox.SelectedIndexChanged += new System.EventHandler(this.MethodsComboBox_SelectedIndexChanged_1);
            // 
            // CreateObjButton
            // 
            this.CreateObjButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CreateObjButton.Location = new System.Drawing.Point(296, 180);
            this.CreateObjButton.Name = "CreateObjButton";
            this.CreateObjButton.Size = new System.Drawing.Size(126, 32);
            this.CreateObjButton.TabIndex = 19;
            this.CreateObjButton.Text = "создать";
            this.CreateObjButton.UseVisualStyleBackColor = true;
            this.CreateObjButton.Click += new System.EventHandler(this.CreateObjButton_Click_1);
            // 
            // InputFieldsButton
            // 
            this.InputFieldsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.InputFieldsButton.Location = new System.Drawing.Point(428, 203);
            this.InputFieldsButton.Name = "InputFieldsButton";
            this.InputFieldsButton.Size = new System.Drawing.Size(100, 33);
            this.InputFieldsButton.TabIndex = 20;
            this.InputFieldsButton.Text = "ввод данных";
            this.InputFieldsButton.UseVisualStyleBackColor = true;
            this.InputFieldsButton.Click += new System.EventHandler(this.InputFieldsButton_Click_1);
            // 
            // RunMethodButton
            // 
            this.RunMethodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RunMethodButton.Location = new System.Drawing.Point(296, 223);
            this.RunMethodButton.Name = "RunMethodButton";
            this.RunMethodButton.Size = new System.Drawing.Size(126, 31);
            this.RunMethodButton.TabIndex = 21;
            this.RunMethodButton.Text = "выполнить";
            this.RunMethodButton.UseVisualStyleBackColor = true;
            this.RunMethodButton.Click += new System.EventHandler(this.RunMethodButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Вид телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Метод:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(273, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Параметры:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Информация:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RunMethodButton);
            this.Controls.Add(this.InputFieldsButton);
            this.Controls.Add(this.CreateObjButton);
            this.Controls.Add(this.MethodsComboBox);
            this.Controls.Add(this.ObjComboBox);
            this.Controls.Add(this.methodsFieldsListBox);
            this.Controls.Add(this.objectFieldsListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.ListBox objectFieldsListBox;
        private System.Windows.Forms.ListBox methodsFieldsListBox;
        private System.Windows.Forms.ComboBox ObjComboBox;
        private System.Windows.Forms.ComboBox MethodsComboBox;
        private System.Windows.Forms.Button CreateObjButton;
        private System.Windows.Forms.Button InputFieldsButton;
        private System.Windows.Forms.Button RunMethodButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

