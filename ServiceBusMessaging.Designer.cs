namespace AzureServiceBusMessaging
{
    partial class ServiceBusMessaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceBusMessaging));
            lblServiceBusNameSpace = new Label();
            txtServiceBusNamespace = new TextBox();
            grpbxServiceBusNameSpace = new GroupBox();
            txtAsbMessage = new TextBox();
            label3 = new Label();
            txtasbTopicName = new TextBox();
            label2 = new Label();
            txtASBConnectionString = new TextBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnBulkUpdate = new Button();
            grpbsSessionDetails = new GroupBox();
            btnSendMessages = new Button();
            txtSessionid2 = new TextBox();
            lblSessionId2 = new Label();
            txtSessionid1 = new TextBox();
            lblSessionId1 = new Label();
            txtasbNamespaceKeyName = new TextBox();
            label1 = new Label();
            grpbxServiceBusNameSpace.SuspendLayout();
            groupBox2.SuspendLayout();
            grpbsSessionDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblServiceBusNameSpace
            // 
            lblServiceBusNameSpace.AutoSize = true;
            lblServiceBusNameSpace.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblServiceBusNameSpace.Location = new Point(20, 190);
            lblServiceBusNameSpace.Margin = new Padding(4, 0, 4, 0);
            lblServiceBusNameSpace.Name = "lblServiceBusNameSpace";
            lblServiceBusNameSpace.Size = new Size(199, 24);
            lblServiceBusNameSpace.TabIndex = 1;
            lblServiceBusNameSpace.Text = "Servicebus Namespace";
            // 
            // txtServiceBusNamespace
            // 
            txtServiceBusNamespace.Enabled = false;
            txtServiceBusNamespace.Location = new Point(306, 190);
            txtServiceBusNamespace.Margin = new Padding(4, 5, 4, 5);
            txtServiceBusNamespace.Name = "txtServiceBusNamespace";
            txtServiceBusNamespace.ReadOnly = true;
            txtServiceBusNamespace.Size = new Size(610, 37);
            txtServiceBusNamespace.TabIndex = 2;
            // 
            // grpbxServiceBusNameSpace
            // 
            grpbxServiceBusNameSpace.Controls.Add(txtAsbMessage);
            grpbxServiceBusNameSpace.Controls.Add(label3);
            grpbxServiceBusNameSpace.Controls.Add(txtasbTopicName);
            grpbxServiceBusNameSpace.Controls.Add(label2);
            grpbxServiceBusNameSpace.Controls.Add(txtASBConnectionString);
            grpbxServiceBusNameSpace.Controls.Add(label4);
            grpbxServiceBusNameSpace.Controls.Add(groupBox2);
            grpbxServiceBusNameSpace.Controls.Add(grpbsSessionDetails);
            grpbxServiceBusNameSpace.Controls.Add(txtasbNamespaceKeyName);
            grpbxServiceBusNameSpace.Controls.Add(label1);
            grpbxServiceBusNameSpace.Controls.Add(txtServiceBusNamespace);
            grpbxServiceBusNameSpace.Controls.Add(lblServiceBusNameSpace);
            grpbxServiceBusNameSpace.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            grpbxServiceBusNameSpace.Location = new Point(13, 2);
            grpbxServiceBusNameSpace.Margin = new Padding(4, 5, 4, 5);
            grpbxServiceBusNameSpace.Name = "grpbxServiceBusNameSpace";
            grpbxServiceBusNameSpace.Padding = new Padding(4, 5, 4, 5);
            grpbxServiceBusNameSpace.Size = new Size(970, 1453);
            grpbxServiceBusNameSpace.TabIndex = 3;
            grpbxServiceBusNameSpace.TabStop = false;
            grpbxServiceBusNameSpace.Text = "Service Bus Details";
            // 
            // txtAsbMessage
            // 
            txtAsbMessage.Location = new Point(306, 398);
            txtAsbMessage.Margin = new Padding(4, 5, 4, 5);
            txtAsbMessage.Multiline = true;
            txtAsbMessage.Name = "txtAsbMessage";
            txtAsbMessage.Size = new Size(610, 407);
            txtAsbMessage.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 398);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 24);
            label3.TabIndex = 12;
            label3.Text = "Servicebus Message";
            // 
            // txtasbTopicName
            // 
            txtasbTopicName.Location = new Point(306, 317);
            txtasbTopicName.Margin = new Padding(4, 5, 4, 5);
            txtasbTopicName.Name = "txtasbTopicName";
            txtasbTopicName.Size = new Size(610, 37);
            txtasbTopicName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 317);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 24);
            label2.TabIndex = 10;
            label2.Text = "Servicebus Topic Name";
            // 
            // txtASBConnectionString
            // 
            txtASBConnectionString.Location = new Point(306, 61);
            txtASBConnectionString.Margin = new Padding(4, 5, 4, 5);
            txtASBConnectionString.Multiline = true;
            txtASBConnectionString.Name = "txtASBConnectionString";
            txtASBConnectionString.Size = new Size(610, 119);
            txtASBConnectionString.TabIndex = 9;
            txtASBConnectionString.Leave += txtASBConnectionString_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 61);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(251, 24);
            label4.TabIndex = 8;
            label4.Text = "Servicebus Connection String";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBulkUpdate);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(20, 1103);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(899, 238);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "BulkUpdate with Session";
            // 
            // btnBulkUpdate
            // 
            btnBulkUpdate.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBulkUpdate.Location = new Point(236, 83);
            btnBulkUpdate.Margin = new Padding(4, 5, 4, 5);
            btnBulkUpdate.Name = "btnBulkUpdate";
            btnBulkUpdate.Size = new Size(459, 55);
            btnBulkUpdate.TabIndex = 4;
            btnBulkUpdate.Text = "Send Bulk Update Message";
            btnBulkUpdate.UseVisualStyleBackColor = true;
            btnBulkUpdate.Click += btnBulkUpdate_Click;
            // 
            // grpbsSessionDetails
            // 
            grpbsSessionDetails.Controls.Add(btnSendMessages);
            grpbsSessionDetails.Controls.Add(txtSessionid2);
            grpbsSessionDetails.Controls.Add(lblSessionId2);
            grpbsSessionDetails.Controls.Add(txtSessionid1);
            grpbsSessionDetails.Controls.Add(lblSessionId1);
            grpbsSessionDetails.Location = new Point(20, 815);
            grpbsSessionDetails.Margin = new Padding(4, 5, 4, 5);
            grpbsSessionDetails.Name = "grpbsSessionDetails";
            grpbsSessionDetails.Padding = new Padding(4, 5, 4, 5);
            grpbsSessionDetails.Size = new Size(899, 238);
            grpbsSessionDetails.TabIndex = 5;
            grpbsSessionDetails.TabStop = false;
            grpbsSessionDetails.Text = "Session Details ";
            // 
            // btnSendMessages
            // 
            btnSendMessages.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSendMessages.Location = new Point(236, 173);
            btnSendMessages.Margin = new Padding(4, 5, 4, 5);
            btnSendMessages.Name = "btnSendMessages";
            btnSendMessages.Size = new Size(459, 55);
            btnSendMessages.TabIndex = 4;
            btnSendMessages.Text = "Send 5 Messages per Session";
            btnSendMessages.UseVisualStyleBackColor = true;
            btnSendMessages.Click += btnSendMessages_Click;
            // 
            // txtSessionid2
            // 
            txtSessionid2.Location = new Point(186, 118);
            txtSessionid2.Margin = new Padding(4, 5, 4, 5);
            txtSessionid2.Name = "txtSessionid2";
            txtSessionid2.Size = new Size(191, 37);
            txtSessionid2.TabIndex = 3;
            // 
            // lblSessionId2
            // 
            lblSessionId2.AutoSize = true;
            lblSessionId2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionId2.Location = new Point(21, 118);
            lblSessionId2.Margin = new Padding(4, 0, 4, 0);
            lblSessionId2.Name = "lblSessionId2";
            lblSessionId2.Size = new Size(108, 24);
            lblSessionId2.TabIndex = 2;
            lblSessionId2.Text = "Session Id 2";
            // 
            // txtSessionid1
            // 
            txtSessionid1.Location = new Point(186, 42);
            txtSessionid1.Margin = new Padding(4, 5, 4, 5);
            txtSessionid1.Name = "txtSessionid1";
            txtSessionid1.Size = new Size(191, 37);
            txtSessionid1.TabIndex = 1;
            // 
            // lblSessionId1
            // 
            lblSessionId1.AutoSize = true;
            lblSessionId1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSessionId1.Location = new Point(21, 42);
            lblSessionId1.Margin = new Padding(4, 0, 4, 0);
            lblSessionId1.Name = "lblSessionId1";
            lblSessionId1.Size = new Size(108, 24);
            lblSessionId1.TabIndex = 0;
            lblSessionId1.Text = "Session Id 1";
            // 
            // txtasbNamespaceKeyName
            // 
            txtasbNamespaceKeyName.Enabled = false;
            txtasbNamespaceKeyName.Location = new Point(306, 250);
            txtasbNamespaceKeyName.Margin = new Padding(4, 5, 4, 5);
            txtasbNamespaceKeyName.Name = "txtasbNamespaceKeyName";
            txtasbNamespaceKeyName.ReadOnly = true;
            txtasbNamespaceKeyName.Size = new Size(610, 37);
            txtasbNamespaceKeyName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 250);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 24);
            label1.TabIndex = 3;
            label1.Text = "Servicebus Namespace Keyname";
            // 
            // ServiceBusMessaging
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1017, 1503);
            Controls.Add(grpbxServiceBusNameSpace);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MinimizeBox = false;
            Name = "ServiceBusMessaging";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicebus Message Testing";
            grpbxServiceBusNameSpace.ResumeLayout(false);
            grpbxServiceBusNameSpace.PerformLayout();
            groupBox2.ResumeLayout(false);
            grpbsSessionDetails.ResumeLayout(false);
            grpbsSessionDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblServiceBusNameSpace;
        private TextBox txtServiceBusNamespace;
        private GroupBox grpbxServiceBusNameSpace;
        private GroupBox grpbsSessionDetails;
        private TextBox txtSessionid2;
        private Label lblSessionId2;
        private TextBox txtSessionid1;
        private Label lblSessionId1;
        private TextBox txtasbNamespaceKeyName;
        private Label label1;
        private Button btnSendMessages;
        private GroupBox groupBox2;
        private Button btnBulkUpdate;
        private TextBox txtASBConnectionString;
        private Label label4;
        private TextBox txtasbTopicName;
        private Label label2;
        private TextBox txtAsbMessage;
        private Label label3;
    }
}