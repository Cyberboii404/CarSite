namespace Hotel_Room_Selector
{
    partial class Selector
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
            lblHeading = new Label();
            pcStandardRoom = new PictureBox();
            picDeluxeRoom = new PictureBox();
            btnStandardRoom = new Button();
            btnSelectRoom = new Button();
            btnDeluxeRoom = new Button();
            lblInstructions = new Label();
            lblConfirmationMessage = new Label();
            btnExitWindow = new Button();
            ((System.ComponentModel.ISupportInitialize)pcStandardRoom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDeluxeRoom).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeading.Location = new Point(99, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(236, 25);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Hotel Room Selection";
            // 
            // pcStandardRoom
            // 
            pcStandardRoom.Location = new Point(12, 51);
            pcStandardRoom.Name = "pcStandardRoom";
            pcStandardRoom.Size = new Size(185, 150);
            pcStandardRoom.TabIndex = 1;
            pcStandardRoom.TabStop = false;
            // 
            // picDeluxeRoom
            // 
            picDeluxeRoom.Location = new Point(237, 51);
            picDeluxeRoom.Name = "picDeluxeRoom";
            picDeluxeRoom.Size = new Size(185, 150);
            picDeluxeRoom.TabIndex = 2;
            picDeluxeRoom.TabStop = false;
            // 
            // btnStandardRoom
            // 
            btnStandardRoom.Location = new Point(53, 216);
            btnStandardRoom.Name = "btnStandardRoom";
            btnStandardRoom.Size = new Size(102, 27);
            btnStandardRoom.TabIndex = 3;
            btnStandardRoom.Text = "Standard Room";
            btnStandardRoom.UseVisualStyleBackColor = true;
            // 
            // btnSelectRoom
            // 
            btnSelectRoom.Location = new Point(166, 216);
            btnSelectRoom.Name = "btnSelectRoom";
            btnSelectRoom.Size = new Size(102, 27);
            btnSelectRoom.TabIndex = 4;
            btnSelectRoom.Text = "Select Room";
            btnSelectRoom.UseVisualStyleBackColor = true;
            // 
            // btnDeluxeRoom
            // 
            btnDeluxeRoom.Location = new Point(278, 216);
            btnDeluxeRoom.Name = "btnDeluxeRoom";
            btnDeluxeRoom.Size = new Size(102, 27);
            btnDeluxeRoom.TabIndex = 5;
            btnDeluxeRoom.Text = "Deluxe Room";
            btnDeluxeRoom.UseVisualStyleBackColor = true;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInstructions.Location = new Point(46, 260);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(342, 16);
            lblInstructions.TabIndex = 6;
            lblInstructions.Text = "Choose a room type and then click the Select Room button";
            // 
            // lblConfirmationMessage
            // 
            lblConfirmationMessage.AutoSize = true;
            lblConfirmationMessage.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmationMessage.Location = new Point(130, 293);
            lblConfirmationMessage.Name = "lblConfirmationMessage";
            lblConfirmationMessage.Size = new Size(174, 16);
            lblConfirmationMessage.TabIndex = 7;
            lblConfirmationMessage.Text = "Your room has been selected";
            // 
            // btnExitWindow
            // 
            btnExitWindow.Location = new Point(166, 326);
            btnExitWindow.Name = "btnExitWindow";
            btnExitWindow.Size = new Size(102, 27);
            btnExitWindow.TabIndex = 8;
            btnExitWindow.Text = "Exit Window";
            btnExitWindow.UseVisualStyleBackColor = true;
            btnExitWindow.Click += button4_Click;
            // 
            // Selector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(btnExitWindow);
            Controls.Add(lblConfirmationMessage);
            Controls.Add(lblInstructions);
            Controls.Add(btnDeluxeRoom);
            Controls.Add(btnSelectRoom);
            Controls.Add(btnStandardRoom);
            Controls.Add(picDeluxeRoom);
            Controls.Add(pcStandardRoom);
            Controls.Add(lblHeading);
            Name = "Selector";
            Text = "Hotel Room Selection";
            ((System.ComponentModel.ISupportInitialize)pcStandardRoom).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDeluxeRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private PictureBox pcStandardRoom;
        private PictureBox picDeluxeRoom;
        private Button btnStandardRoom;
        private Button btnSelectRoom;
        private Button btnDeluxeRoom;
        private Label lblInstructions;
        private Label lblConfirmationMessage;
        private Button btnExitWindow;
    }
}