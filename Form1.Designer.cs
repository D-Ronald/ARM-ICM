namespace Braço
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.AllowAnimations = true;
            this.button2.AllowMouseEffects = true;
            this.button2.AllowToggling = false;
            this.button2.AnimationSpeed = 200;
            this.button2.AutoGenerateColors = false;
            this.button2.AutoRoundBorders = false;
            this.button2.AutoSizeLeftIcon = true;
            this.button2.AutoSizeRightIcon = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button2.ButtonText = "Conectar";
            this.button2.ButtonTextMarginLeft = 0;
            this.button2.ColorContrastOnClick = 45;
            this.button2.ColorContrastOnHover = 45;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button2.CustomizableEdges = borderEdges2;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button2.DisabledFillColor = System.Drawing.Color.Empty;
            this.button2.DisabledForecolor = System.Drawing.Color.Empty;
            this.button2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.IconLeft = null;
            this.button2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button2.IconMarginLeft = 11;
            this.button2.IconPadding = 10;
            this.button2.IconRight = null;
            this.button2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button2.IconSize = 25;
            this.button2.IdleBorderColor = System.Drawing.Color.Empty;
            this.button2.IdleBorderRadius = 0;
            this.button2.IdleBorderThickness = 0;
            this.button2.IdleFillColor = System.Drawing.Color.Empty;
            this.button2.IdleIconLeftImage = null;
            this.button2.IdleIconRightImage = null;
            this.button2.IndicateFocus = false;
            this.button2.Location = new System.Drawing.Point(396, 63);
            this.button2.Name = "button2";
            this.button2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button2.OnDisabledState.BorderRadius = 1;
            this.button2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button2.OnDisabledState.BorderThickness = 1;
            this.button2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button2.OnDisabledState.IconLeftImage = null;
            this.button2.OnDisabledState.IconRightImage = null;
            this.button2.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button2.onHoverState.BorderRadius = 1;
            this.button2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button2.onHoverState.BorderThickness = 1;
            this.button2.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.button2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button2.onHoverState.IconLeftImage = null;
            this.button2.onHoverState.IconRightImage = null;
            this.button2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.button2.OnIdleState.BorderRadius = 1;
            this.button2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button2.OnIdleState.BorderThickness = 1;
            this.button2.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.button2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button2.OnIdleState.IconLeftImage = null;
            this.button2.OnIdleState.IconRightImage = null;
            this.button2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button2.OnPressedState.BorderRadius = 1;
            this.button2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button2.OnPressedState.BorderThickness = 1;
            this.button2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button2.OnPressedState.IconLeftImage = null;
            this.button2.OnPressedState.IconRightImage = null;
            this.button2.Size = new System.Drawing.Size(122, 24);
            this.button2.TabIndex = 4;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button2.TextMarginLeft = 0;
            this.button2.TextPadding = new System.Windows.Forms.Padding(0);
            this.button2.UseDefaultRadiusAndThickness = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.button2_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Escolher porta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Braço Robótico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

