
namespace CarFixMgr0611
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.custFixView = new Sunny.UI.UISymbolButton();
            this.custFixAdmin = new Sunny.UI.UISymbolButton();
            this.custFixRand = new Sunny.UI.UISymbolButton();
            this.custFixInfo = new Sunny.UI.UISymbolButton();
            this.mainMin = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("cxFlatPictureBox1.Image")));
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(6, 68);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(477, 537);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 0;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(495, 83);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.RectColor = System.Drawing.Color.Transparent;
            this.custFixAdd.Size = new System.Drawing.Size(306, 63);
            this.custFixAdd.Style = Sunny.UI.UIStyle.Custom;
            this.custFixAdd.Symbol = 62141;
            this.custFixAdd.TabIndex = 6;
            this.custFixAdd.Text = "고객 정보 접수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.Transparent;
            this.mainExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.mainExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(766, 24);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.White;
            this.mainExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.mainExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainExit.Size = new System.Drawing.Size(44, 37);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 36;
            this.mainExit.TabIndex = 7;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(0, 24);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(195, 38);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // custFixView
            // 
            this.custFixView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.custFixView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixView.Location = new System.Drawing.Point(495, 192);
            this.custFixView.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixView.Name = "custFixView";
            this.custFixView.RectColor = System.Drawing.Color.Transparent;
            this.custFixView.Size = new System.Drawing.Size(306, 63);
            this.custFixView.Style = Sunny.UI.UIStyle.Custom;
            this.custFixView.Symbol = 61613;
            this.custFixView.TabIndex = 9;
            this.custFixView.Text = "수리내역";
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdmin.FillColor = System.Drawing.Color.Red;
            this.custFixAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdmin.Location = new System.Drawing.Point(495, 301);
            this.custFixAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.RectColor = System.Drawing.Color.Transparent;
            this.custFixAdmin.Size = new System.Drawing.Size(306, 63);
            this.custFixAdmin.Style = Sunny.UI.UIStyle.Custom;
            this.custFixAdmin.Symbol = 61475;
            this.custFixAdmin.TabIndex = 10;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custFixRand
            // 
            this.custFixRand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixRand.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.custFixRand.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixRand.Location = new System.Drawing.Point(495, 410);
            this.custFixRand.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixRand.Name = "custFixRand";
            this.custFixRand.RectColor = System.Drawing.Color.Transparent;
            this.custFixRand.Size = new System.Drawing.Size(306, 63);
            this.custFixRand.Style = Sunny.UI.UIStyle.Custom;
            this.custFixRand.Symbol = 61736;
            this.custFixRand.TabIndex = 11;
            this.custFixRand.Text = "랜덤 데이터 추가";
            this.custFixRand.Click += new System.EventHandler(this.custFixRand_Click);
            // 
            // custFixInfo
            // 
            this.custFixInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixInfo.FillColor = System.Drawing.Color.Silver;
            this.custFixInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixInfo.Location = new System.Drawing.Point(696, 544);
            this.custFixInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixInfo.Name = "custFixInfo";
            this.custFixInfo.RectColor = System.Drawing.Color.Transparent;
            this.custFixInfo.Size = new System.Drawing.Size(105, 53);
            this.custFixInfo.Style = Sunny.UI.UIStyle.Custom;
            this.custFixInfo.Symbol = 61442;
            this.custFixInfo.TabIndex = 12;
            this.custFixInfo.Text = "앱 정보";
            this.custFixInfo.Click += new System.EventHandler(this.custFixInfo_Click);
            // 
            // mainMin
            // 
            this.mainMin.BackColor = System.Drawing.Color.Transparent;
            this.mainMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainMin.FillColor = System.Drawing.Color.Transparent;
            this.mainMin.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.mainMin.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainMin.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainMin.Location = new System.Drawing.Point(716, 24);
            this.mainMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainMin.Name = "mainMin";
            this.mainMin.RectColor = System.Drawing.Color.White;
            this.mainMin.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.mainMin.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainMin.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.mainMin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainMin.Size = new System.Drawing.Size(44, 37);
            this.mainMin.Style = Sunny.UI.UIStyle.Custom;
            this.mainMin.Symbol = 61544;
            this.mainMin.SymbolSize = 36;
            this.mainMin.TabIndex = 13;
            this.mainMin.Click += new System.EventHandler(this.mainMin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 609);
            this.ControlBox = false;
            this.Controls.Add(this.mainMin);
            this.Controls.Add(this.custFixInfo);
            this.Controls.Add(this.custFixRand);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton custFixView;
        private Sunny.UI.UISymbolButton custFixAdmin;
        private Sunny.UI.UISymbolButton custFixRand;
        private Sunny.UI.UISymbolButton custFixInfo;
        private Sunny.UI.UISymbolButton mainMin;
    }
}

