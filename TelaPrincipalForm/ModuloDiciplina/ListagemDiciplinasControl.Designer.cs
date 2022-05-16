namespace TestesDaDonaMariana.WinApp.ModuloDiciplina
{
    partial class ListagemDiciplinasControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listDiciplinas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listDiciplinas
            // 
            this.listDiciplinas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDiciplinas.FormattingEnabled = true;
            this.listDiciplinas.ItemHeight = 15;
            this.listDiciplinas.Location = new System.Drawing.Point(0, 0);
            this.listDiciplinas.Name = "listDiciplinas";
            this.listDiciplinas.Size = new System.Drawing.Size(534, 425);
            this.listDiciplinas.TabIndex = 1;
            this.listDiciplinas.SelectedIndexChanged += new System.EventHandler(this.listTarefas_SelectedIndexChanged);
            // 
            // ListagemDiciplinasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listDiciplinas);
            this.Name = "ListagemDiciplinasControl";
            this.Size = new System.Drawing.Size(534, 425);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDiciplinas;
    }
}
