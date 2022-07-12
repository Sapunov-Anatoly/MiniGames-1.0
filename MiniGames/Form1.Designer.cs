
namespace MiniGames
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.CrackerGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrackerGameButton
            // 
            this.CrackerGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrackerGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrackerGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrackerGameButton.Location = new System.Drawing.Point(12, 12);
            this.CrackerGameButton.Name = "CrackerGameButton";
            this.CrackerGameButton.Size = new System.Drawing.Size(248, 97);
            this.CrackerGameButton.TabIndex = 0;
            this.CrackerGameButton.Text = "Взломщик";
            this.CrackerGameButton.UseVisualStyleBackColor = true;
            this.CrackerGameButton.Click += new System.EventHandler(this.CrackerGameButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CrackerGameButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мини игры";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrackerGameButton;
    }
}

