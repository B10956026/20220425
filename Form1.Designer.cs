
namespace _20220425
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); 
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_player = new System.Windows.Forms.Label();
            this.lbl_IP = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_Port = new System.Windows.Forms.TextBox();
            this.btn_Login_Server = new System.Windows.Forms.Button();
            this.tb_player = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_player
            // 
            this.lbl_player.AutoSize = true;
            this.lbl_player.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_player.Location = new System.Drawing.Point(16, 126);
            this.lbl_player.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(110, 31);
            this.lbl_player.TabIndex = 0;
            this.lbl_player.Text = "玩家名稱";
            // 
            // lbl_IP
            // 
            this.lbl_IP.AutoSize = true;
            this.lbl_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_IP.Location = new System.Drawing.Point(18, 30);
            this.lbl_IP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IP.Name = "lbl_IP";
            this.lbl_IP.Size = new System.Drawing.Size(108, 31);
            this.lbl_IP.TabIndex = 2;
            this.lbl_IP.Text = "伺服器IP";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_Port.Location = new System.Drawing.Point(465, 22);
            this.lbl_Port.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(134, 31);
            this.lbl_Port.TabIndex = 3;
            this.lbl_Port.Text = "伺服器Port";
            // 
            // tb_IP
            // 
            this.tb_IP.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_IP.Location = new System.Drawing.Point(142, 27);
            this.tb_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(238, 39);
            this.tb_IP.TabIndex = 4;
            // 
            // tb_Port
            // 
            this.tb_Port.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Port.Location = new System.Drawing.Point(615, 18);
            this.tb_Port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Port.Name = "tb_Port";
            this.tb_Port.Size = new System.Drawing.Size(238, 39);
            this.tb_Port.TabIndex = 5;
            // 
            // btn_Login_Server
            // 
            this.btn_Login_Server.AutoSize = true;
            this.btn_Login_Server.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Login_Server.Location = new System.Drawing.Point(615, 118);
            this.btn_Login_Server.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login_Server.Name = "btn_Login_Server";
            this.btn_Login_Server.Size = new System.Drawing.Size(240, 46);
            this.btn_Login_Server.TabIndex = 6;
            this.btn_Login_Server.Text = "登入伺服器";
            this.btn_Login_Server.UseVisualStyleBackColor = true;
            this.btn_Login_Server.Click += new System.EventHandler(this.btn_Login_Server_Click);
            // 
            // tb_player
            // 
            this.tb_player.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_player.Location = new System.Drawing.Point(142, 122);
            this.tb_player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_player.Name = "tb_player";
            this.tb_player.Size = new System.Drawing.Size(238, 39);
            this.tb_player.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 186);
            this.Controls.Add(this.tb_player);
            this.Controls.Add(this.btn_Login_Server);
            this.Controls.Add(this.tb_Port);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_IP);
            this.Controls.Add(this.lbl_player);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TCP 客戶端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Label lbl_IP;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_Port;
        private System.Windows.Forms.Button btn_Login_Server;
        private System.Windows.Forms.TextBox tb_player;
    }
}

