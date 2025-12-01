namespace TrabajoLun
{
    partial class Form1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnJumpSearch = new System.Windows.Forms.Button();
            this.btnInterpolation = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Generar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.ItemHeight = 16;
            this.lstNumeros.Location = new System.Drawing.Point(13, 54);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(120, 292);
            this.lstNumeros.TabIndex = 1;
            this.lstNumeros.SelectedIndexChanged += new System.EventHandler(this.lstNumeros_SelectedIndexChanged);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(151, 123);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(180, 45);
            this.btnSelectionSort.TabIndex = 2;
            this.btnSelectionSort.Text = "Selection Sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Location = new System.Drawing.Point(151, 185);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(180, 41);
            this.btnMergeSort.TabIndex = 3;
            this.btnMergeSort.Text = "Merge Sort";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
            // 
            // btnJumpSearch
            // 
            this.btnJumpSearch.Location = new System.Drawing.Point(151, 246);
            this.btnJumpSearch.Name = "btnJumpSearch";
            this.btnJumpSearch.Size = new System.Drawing.Size(180, 44);
            this.btnJumpSearch.TabIndex = 4;
            this.btnJumpSearch.Text = "Búsqueda por Saltos";
            this.btnJumpSearch.UseVisualStyleBackColor = true;
            this.btnJumpSearch.Click += new System.EventHandler(this.btnJumpSearch_Click);
            // 
            // btnInterpolation
            // 
            this.btnInterpolation.Location = new System.Drawing.Point(151, 308);
            this.btnInterpolation.Name = "btnInterpolation";
            this.btnInterpolation.Size = new System.Drawing.Size(180, 51);
            this.btnInterpolation.TabIndex = 5;
            this.btnInterpolation.Text = "Búsqueda Interpolada";
            this.btnInterpolation.UseVisualStyleBackColor = true;
            this.btnInterpolation.Click += new System.EventHandler(this.btnInterpolation_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(151, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(180, 22);
            this.txtBuscar.TabIndex = 6;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(9, 360);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(97, 16);
            this.lblTiempo.TabIndex = 7;
            this.lblTiempo.Text = "Tiempo: 0 ticks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 400);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnInterpolation);
            this.Controls.Add(this.btnJumpSearch);
            this.Controls.Add(this.btnMergeSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstNumeros;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Button btnJumpSearch;
        private System.Windows.Forms.Button btnInterpolation;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTiempo;
    }
}

