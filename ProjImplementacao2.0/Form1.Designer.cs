namespace ProjImplementacao2._0
{
    partial class Form1
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
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventTitulo = new System.Windows.Forms.TextBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.dtpEventData = new System.Windows.Forms.DateTimePicker();
            this.rbConference = new System.Windows.Forms.RadioButton();
            this.rbWorkshop = new System.Windows.Forms.RadioButton();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnRemoveEvent = new System.Windows.Forms.Button();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblParticipantName = new System.Windows.Forms.Label();
            this.txtParticipaNome = new System.Windows.Forms.TextBox();
            this.btnRegisterParticipant = new System.Windows.Forms.Button();
            this.btnUnregisterParticipant = new System.Windows.Forms.Button();
            this.lstParticipa = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Location = new System.Drawing.Point(17, 16);
            this.lblEventTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(107, 16);
            this.lblEventTitle.TabIndex = 0;
            this.lblEventTitle.Text = "Título do Evento:";
            // 
            // txtEventTitulo
            // 
            this.txtEventTitulo.Location = new System.Drawing.Point(160, 12);
            this.txtEventTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEventTitulo.Name = "txtEventTitulo";
            this.txtEventTitulo.Size = new System.Drawing.Size(265, 22);
            this.txtEventTitulo.TabIndex = 1;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(17, 62);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(103, 16);
            this.lblEventDate.TabIndex = 2;
            this.lblEventDate.Text = "Data do Evento:";
            // 
            // dtpEventData
            // 
            this.dtpEventData.Location = new System.Drawing.Point(160, 62);
            this.dtpEventData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEventData.Name = "dtpEventData";
            this.dtpEventData.Size = new System.Drawing.Size(265, 22);
            this.dtpEventData.TabIndex = 3;
            // 
            // rbConference
            // 
            this.rbConference.AutoSize = true;
            this.rbConference.Location = new System.Drawing.Point(21, 111);
            this.rbConference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbConference.Name = "rbConference";
            this.rbConference.Size = new System.Drawing.Size(100, 20);
            this.rbConference.TabIndex = 4;
            this.rbConference.TabStop = true;
            this.rbConference.Text = "Conferência";
            this.rbConference.UseVisualStyleBackColor = true;
            // 
            // rbWorkshop
            // 
            this.rbWorkshop.AutoSize = true;
            this.rbWorkshop.Location = new System.Drawing.Point(160, 111);
            this.rbWorkshop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbWorkshop.Name = "rbWorkshop";
            this.rbWorkshop.Size = new System.Drawing.Size(90, 20);
            this.rbWorkshop.TabIndex = 5;
            this.rbWorkshop.TabStop = true;
            this.rbWorkshop.Text = "Workshop";
            this.rbWorkshop.UseVisualStyleBackColor = true;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(21, 160);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(133, 28);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Adicionar Evento";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnRemoveEvent
            // 
            this.btnRemoveEvent.Location = new System.Drawing.Point(200, 160);
            this.btnRemoveEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveEvent.Name = "btnRemoveEvent";
            this.btnRemoveEvent.Size = new System.Drawing.Size(133, 28);
            this.btnRemoveEvent.TabIndex = 7;
            this.btnRemoveEvent.Text = "Remover Evento";
            this.btnRemoveEvent.UseVisualStyleBackColor = true;
            this.btnRemoveEvent.Click += new System.EventHandler(this.btnRemoveEvent_Click);
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(21, 209);
            this.lstEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(412, 116);
            this.lstEvents.TabIndex = 8;
            // 
            // lblParticipantName
            // 
            this.lblParticipantName.AutoSize = true;
            this.lblParticipantName.Location = new System.Drawing.Point(17, 345);
            this.lblParticipantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParticipantName.Name = "lblParticipantName";
            this.lblParticipantName.Size = new System.Drawing.Size(140, 16);
            this.lblParticipantName.TabIndex = 9;
            this.lblParticipantName.Text = "Nome do Participante:";
            // 
            // txtParticipaNome
            // 
            this.txtParticipaNome.Location = new System.Drawing.Point(160, 345);
            this.txtParticipaNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParticipaNome.Name = "txtParticipaNome";
            this.txtParticipaNome.Size = new System.Drawing.Size(265, 22);
            this.txtParticipaNome.TabIndex = 10;
            // 
            // btnRegisterParticipant
            // 
            this.btnRegisterParticipant.Location = new System.Drawing.Point(21, 394);
            this.btnRegisterParticipant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterParticipant.Name = "btnRegisterParticipant";
            this.btnRegisterParticipant.Size = new System.Drawing.Size(160, 28);
            this.btnRegisterParticipant.TabIndex = 11;
            this.btnRegisterParticipant.Text = "Registrar Participante";
            this.btnRegisterParticipant.UseVisualStyleBackColor = true;
            this.btnRegisterParticipant.Click += new System.EventHandler(this.btnRegisterParticipant_Click);
            // 
            // btnUnregisterParticipant
            // 
            this.btnUnregisterParticipant.Location = new System.Drawing.Point(200, 394);
            this.btnUnregisterParticipant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnregisterParticipant.Name = "btnUnregisterParticipant";
            this.btnUnregisterParticipant.Size = new System.Drawing.Size(160, 28);
            this.btnUnregisterParticipant.TabIndex = 12;
            this.btnUnregisterParticipant.Text = "Desregistrar Participante";
            this.btnUnregisterParticipant.UseVisualStyleBackColor = true;
            this.btnUnregisterParticipant.Click += new System.EventHandler(this.btnUnregisterParticipant_Click);
            // 
            // lstParticipa
            // 
            this.lstParticipa.FormattingEnabled = true;
            this.lstParticipa.ItemHeight = 16;
            this.lstParticipa.Location = new System.Drawing.Point(21, 443);
            this.lstParticipa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstParticipa.Name = "lstParticipa";
            this.lstParticipa.Size = new System.Drawing.Size(412, 116);
            this.lstParticipa.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 588);
            this.Controls.Add(this.lstParticipa);
            this.Controls.Add(this.btnUnregisterParticipant);
            this.Controls.Add(this.btnRegisterParticipant);
            this.Controls.Add(this.txtParticipaNome);
            this.Controls.Add(this.lblParticipantName);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnRemoveEvent);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.rbWorkshop);
            this.Controls.Add(this.rbConference);
            this.Controls.Add(this.dtpEventData);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.txtEventTitulo);
            this.Controls.Add(this.lblEventTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gerenciador de Eventos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.TextBox txtEventTitulo;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.DateTimePicker dtpEventData;
        private System.Windows.Forms.RadioButton rbConference;
        private System.Windows.Forms.RadioButton rbWorkshop;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnRemoveEvent;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblParticipantName;
        private System.Windows.Forms.TextBox txtParticipaNome;
        private System.Windows.Forms.Button btnRegisterParticipant;
        private System.Windows.Forms.Button btnUnregisterParticipant;
        private System.Windows.Forms.ListBox lstParticipa;
    }
}

