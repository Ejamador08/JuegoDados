
namespace JUEGO_DADOS
{
    partial class frm_juego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_tirar = new System.Windows.Forms.Button();
            this.dv_jugadores = new System.Windows.Forms.DataGridView();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.banner = new System.Windows.Forms.PictureBox();
            this.dado2 = new System.Windows.Forms.PictureBox();
            this.dado1 = new System.Windows.Forms.PictureBox();
            this.tiempoAnimacion = new System.Windows.Forms.Timer(this.components);
            this.pararAnimacion = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dv_jugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(22, 242);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(393, 44);
            this.lbl_resultado.TabIndex = 3;
            this.lbl_resultado.Text = "Has sacado 1 y 1 = 2";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_tirar
            // 
            this.btn_tirar.BackColor = System.Drawing.Color.Maroon;
            this.btn_tirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tirar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tirar.Location = new System.Drawing.Point(12, 280);
            this.btn_tirar.Name = "btn_tirar";
            this.btn_tirar.Size = new System.Drawing.Size(417, 55);
            this.btn_tirar.TabIndex = 4;
            this.btn_tirar.Text = "Turno de tirar de";
            this.btn_tirar.UseVisualStyleBackColor = false;
            this.btn_tirar.Click += new System.EventHandler(this.btn_tirar_Click);
            // 
            // dv_jugadores
            // 
            this.dv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_jugadores.Location = new System.Drawing.Point(12, 350);
            this.dv_jugadores.Name = "dv_jugadores";
            this.dv_jugadores.Size = new System.Drawing.Size(285, 159);
            this.dv_jugadores.TabIndex = 5;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(303, 350);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(126, 82);
            this.btn_iniciar.TabIndex = 6;
            this.btn_iniciar.Text = "INICIAR";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.BackColor = System.Drawing.Color.Olive;
            this.btn_Reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Reiniciar.Location = new System.Drawing.Point(303, 438);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(126, 71);
            this.btn_Reiniciar.TabIndex = 7;
            this.btn_Reiniciar.Text = "REINICAR";
            this.btn_Reiniciar.UseVisualStyleBackColor = false;
            // 
            // banner
            // 
            this.banner.Image = global::JUEGO_DADOS.Properties.Resources.banner;
            this.banner.Location = new System.Drawing.Point(1, 0);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(442, 62);
            this.banner.TabIndex = 0;
            this.banner.TabStop = false;
            // 
            // dado2
            // 
            this.dado2.Image = global::JUEGO_DADOS.Properties.Resources.cara01;
            this.dado2.Location = new System.Drawing.Point(236, 78);
            this.dado2.Name = "dado2";
            this.dado2.Size = new System.Drawing.Size(193, 161);
            this.dado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dado2.TabIndex = 2;
            this.dado2.TabStop = false;
            // 
            // dado1
            // 
            this.dado1.Image = global::JUEGO_DADOS.Properties.Resources.cara01;
            this.dado1.Location = new System.Drawing.Point(12, 78);
            this.dado1.Name = "dado1";
            this.dado1.Size = new System.Drawing.Size(193, 161);
            this.dado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dado1.TabIndex = 1;
            this.dado1.TabStop = false;
            // 
            // tiempoAnimacion
            // 
            this.tiempoAnimacion.Tick += new System.EventHandler(this.tiempoAnimacion_Tick);
            // 
            // pararAnimacion
            // 
            this.pararAnimacion.Interval = 1500;
            this.pararAnimacion.Tick += new System.EventHandler(this.pararAnimacion_Tick);
            // 
            // frm_juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 521);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.dado2);
            this.Controls.Add(this.dado1);
            this.Controls.Add(this.btn_tirar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.dv_jugadores);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.btn_Reiniciar);
            this.Name = "frm_juego";
            this.Text = "Casino ElPochoAlegre";
            this.Load += new System.EventHandler(this.frm_juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_jugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dado1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox banner;
        private System.Windows.Forms.PictureBox dado1;
        private System.Windows.Forms.PictureBox dado2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_tirar;
        private System.Windows.Forms.DataGridView dv_jugadores;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer tiempoAnimacion;
        private System.Windows.Forms.Timer pararAnimacion;
    }
}

