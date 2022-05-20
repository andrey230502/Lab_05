namespace Lab_05
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
            this.currentThread = new System.Windows.Forms.GroupBox();
            this.label_ctn_TState = new System.Windows.Forms.Label();
            this.label_ctn_Priority = new System.Windows.Forms.Label();
            this.label_ctn_MTid = new System.Windows.Forms.Label();
            this.label_ctn_IsAlive = new System.Windows.Forms.Label();
            this.label_ctn_Name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Start_newForm_Clik = new System.Windows.Forms.Button();
            this.button_Stop_newForm_Clik = new System.Windows.Forms.Button();
            this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Stop = new System.Windows.Forms.DateTimePicker();
            this.label_value = new System.Windows.Forms.Label();
            this.label_TimeSpan = new System.Windows.Forms.Label();
            this.button_value = new System.Windows.Forms.Button();
            this.currentThread.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentThread
            // 
            this.currentThread.Controls.Add(this.label_ctn_TState);
            this.currentThread.Controls.Add(this.label_ctn_Priority);
            this.currentThread.Controls.Add(this.label_ctn_MTid);
            this.currentThread.Controls.Add(this.label_ctn_IsAlive);
            this.currentThread.Controls.Add(this.label_ctn_Name);
            this.currentThread.Controls.Add(this.label5);
            this.currentThread.Controls.Add(this.label4);
            this.currentThread.Controls.Add(this.label3);
            this.currentThread.Controls.Add(this.label2);
            this.currentThread.Controls.Add(this.label1);
            this.currentThread.Location = new System.Drawing.Point(12, 12);
            this.currentThread.Name = "currentThread";
            this.currentThread.Size = new System.Drawing.Size(260, 126);
            this.currentThread.TabIndex = 0;
            this.currentThread.TabStop = false;
            this.currentThread.Text = "CurrentThread";
            // 
            // label_ctn_TState
            // 
            this.label_ctn_TState.AutoSize = true;
            this.label_ctn_TState.Location = new System.Drawing.Point(150, 105);
            this.label_ctn_TState.Name = "label_ctn_TState";
            this.label_ctn_TState.Size = new System.Drawing.Size(88, 13);
            this.label_ctn_TState.TabIndex = 9;
            this.label_ctn_TState.Text = "label_ctn_TState";
            // 
            // label_ctn_Priority
            // 
            this.label_ctn_Priority.AutoSize = true;
            this.label_ctn_Priority.Location = new System.Drawing.Point(150, 88);
            this.label_ctn_Priority.Name = "label_ctn_Priority";
            this.label_ctn_Priority.Size = new System.Drawing.Size(87, 13);
            this.label_ctn_Priority.TabIndex = 8;
            this.label_ctn_Priority.Text = "label_ctn_Priority";
            // 
            // label_ctn_MTid
            // 
            this.label_ctn_MTid.AutoSize = true;
            this.label_ctn_MTid.Location = new System.Drawing.Point(150, 71);
            this.label_ctn_MTid.Name = "label_ctn_MTid";
            this.label_ctn_MTid.Size = new System.Drawing.Size(80, 13);
            this.label_ctn_MTid.TabIndex = 7;
            this.label_ctn_MTid.Text = "label_ctn_MTid";
            // 
            // label_ctn_IsAlive
            // 
            this.label_ctn_IsAlive.AutoSize = true;
            this.label_ctn_IsAlive.Location = new System.Drawing.Point(150, 55);
            this.label_ctn_IsAlive.Name = "label_ctn_IsAlive";
            this.label_ctn_IsAlive.Size = new System.Drawing.Size(87, 13);
            this.label_ctn_IsAlive.TabIndex = 6;
            this.label_ctn_IsAlive.Text = "label_ctn_IsAlive";
            // 
            // label_ctn_Name
            // 
            this.label_ctn_Name.AutoSize = true;
            this.label_ctn_Name.Location = new System.Drawing.Point(150, 39);
            this.label_ctn_Name.Name = "label_ctn_Name";
            this.label_ctn_Name.Size = new System.Drawing.Size(84, 13);
            this.label_ctn_Name.TabIndex = 5;
            this.label_ctn_Name.Text = "label_ctn_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(40, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ThreadState:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(82, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioriti:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ManagedTreadID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "IsAlive:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // button_Start_newForm_Clik
            // 
            this.button_Start_newForm_Clik.Location = new System.Drawing.Point(278, 27);
            this.button_Start_newForm_Clik.Name = "button_Start_newForm_Clik";
            this.button_Start_newForm_Clik.Size = new System.Drawing.Size(125, 53);
            this.button_Start_newForm_Clik.TabIndex = 1;
            this.button_Start_newForm_Clik.Text = "Start new Form";
            this.button_Start_newForm_Clik.UseVisualStyleBackColor = true;
            this.button_Start_newForm_Clik.Click += new System.EventHandler(this.button_Start_newForm_Clik_Click);
            // 
            // button_Stop_newForm_Clik
            // 
            this.button_Stop_newForm_Clik.Location = new System.Drawing.Point(278, 86);
            this.button_Stop_newForm_Clik.Name = "button_Stop_newForm_Clik";
            this.button_Stop_newForm_Clik.Size = new System.Drawing.Size(125, 52);
            this.button_Stop_newForm_Clik.TabIndex = 2;
            this.button_Stop_newForm_Clik.Text = "Stop new Form";
            this.button_Stop_newForm_Clik.UseVisualStyleBackColor = true;
            this.button_Stop_newForm_Clik.Click += new System.EventHandler(this.button_Stop_newForm_Clik_Click);
            // 
            // dateTimePicker_Start
            // 
            this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Start.Location = new System.Drawing.Point(12, 144);
            this.dateTimePicker_Start.Name = "dateTimePicker_Start";
            this.dateTimePicker_Start.Size = new System.Drawing.Size(77, 20);
            this.dateTimePicker_Start.TabIndex = 10;
            // 
            // dateTimePicker_Stop
            // 
            this.dateTimePicker_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_Stop.Location = new System.Drawing.Point(12, 170);
            this.dateTimePicker_Stop.Name = "dateTimePicker_Stop";
            this.dateTimePicker_Stop.Size = new System.Drawing.Size(77, 20);
            this.dateTimePicker_Stop.TabIndex = 11;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(137, 144);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(33, 13);
            this.label_value.TabIndex = 12;
            this.label_value.Text = "value";
            // 
            // label_TimeSpan
            // 
            this.label_TimeSpan.AutoSize = true;
            this.label_TimeSpan.Location = new System.Drawing.Point(137, 176);
            this.label_TimeSpan.Name = "label_TimeSpan";
            this.label_TimeSpan.Size = new System.Drawing.Size(63, 13);
            this.label_TimeSpan.TabIndex = 13;
            this.label_TimeSpan.Text = "TimeSpawn";
            // 
            // button_value
            // 
            this.button_value.Location = new System.Drawing.Point(278, 144);
            this.button_value.Name = "button_value";
            this.button_value.Size = new System.Drawing.Size(125, 46);
            this.button_value.TabIndex = 14;
            this.button_value.Text = "Value";
            this.button_value.UseVisualStyleBackColor = true;
            this.button_value.Click += new System.EventHandler(this.button_value_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 227);
            this.Controls.Add(this.button_value);
            this.Controls.Add(this.label_TimeSpan);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.dateTimePicker_Stop);
            this.Controls.Add(this.button_Stop_newForm_Clik);
            this.Controls.Add(this.dateTimePicker_Start);
            this.Controls.Add(this.button_Start_newForm_Clik);
            this.Controls.Add(this.currentThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.currentThread.ResumeLayout(false);
            this.currentThread.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox currentThread;
        private System.Windows.Forms.Label label_ctn_TState;
        private System.Windows.Forms.Label label_ctn_Priority;
        private System.Windows.Forms.Label label_ctn_MTid;
        private System.Windows.Forms.Label label_ctn_IsAlive;
        private System.Windows.Forms.Label label_ctn_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Start_newForm_Clik;
        private System.Windows.Forms.Button button_Stop_newForm_Clik;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Stop;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Label label_TimeSpan;
        private System.Windows.Forms.Button button_value;
    }
}

