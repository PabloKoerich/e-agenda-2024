namespace eAgenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromissoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            lblTerminoPeriodo = new Label();
            lblInicioPeriodo = new Label();
            txtTerminoPeriodo = new DateTimePicker();
            txtInicioPeriodo = new DateTimePicker();
            rdbCompromissosPeriodo = new RadioButton();
            rdbCompromissosFuturos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbTodosCompromissos = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Segoe UI", 11.25F);
            btnGravar.Location = new Point(315, 279);
            btnGravar.Margin = new Padding(3, 4, 3, 4);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(114, 49);
            btnGravar.TabIndex = 10;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(437, 279);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 49);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTerminoPeriodo);
            groupBox1.Controls.Add(lblInicioPeriodo);
            groupBox1.Controls.Add(txtTerminoPeriodo);
            groupBox1.Controls.Add(txtInicioPeriodo);
            groupBox1.Controls.Add(rdbCompromissosPeriodo);
            groupBox1.Controls.Add(rdbCompromissosFuturos);
            groupBox1.Controls.Add(rdbCompromissosPassados);
            groupBox1.Controls.Add(rdbTodosCompromissos);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(537, 255);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selecione um Filtro:";
            // 
            // lblTerminoPeriodo
            // 
            lblTerminoPeriodo.AutoSize = true;
            lblTerminoPeriodo.Enabled = false;
            lblTerminoPeriodo.Location = new Point(310, 215);
            lblTerminoPeriodo.Name = "lblTerminoPeriodo";
            lblTerminoPeriodo.Size = new Size(84, 25);
            lblTerminoPeriodo.TabIndex = 2;
            lblTerminoPeriodo.Text = "Término:";
            lblTerminoPeriodo.Visible = false;
            // 
            // lblInicioPeriodo
            // 
            lblInicioPeriodo.AutoSize = true;
            lblInicioPeriodo.Enabled = false;
            lblInicioPeriodo.Location = new Point(112, 215);
            lblInicioPeriodo.Name = "lblInicioPeriodo";
            lblInicioPeriodo.Size = new Size(62, 25);
            lblInicioPeriodo.TabIndex = 2;
            lblInicioPeriodo.Text = "Início:";
            lblInicioPeriodo.Visible = false;
            // 
            // txtTerminoPeriodo
            // 
            txtTerminoPeriodo.Enabled = false;
            txtTerminoPeriodo.Format = DateTimePickerFormat.Short;
            txtTerminoPeriodo.Location = new Point(395, 211);
            txtTerminoPeriodo.Margin = new Padding(3, 4, 3, 4);
            txtTerminoPeriodo.Name = "txtTerminoPeriodo";
            txtTerminoPeriodo.Size = new Size(134, 32);
            txtTerminoPeriodo.TabIndex = 1;
            txtTerminoPeriodo.Visible = false;
            // 
            // txtInicioPeriodo
            // 
            txtInicioPeriodo.Enabled = false;
            txtInicioPeriodo.Format = DateTimePickerFormat.Short;
            txtInicioPeriodo.Location = new Point(174, 211);
            txtInicioPeriodo.Margin = new Padding(3, 4, 3, 4);
            txtInicioPeriodo.Name = "txtInicioPeriodo";
            txtInicioPeriodo.Size = new Size(134, 32);
            txtInicioPeriodo.TabIndex = 1;
            txtInicioPeriodo.Visible = false;
            // 
            // rdbCompromissosPeriodo
            // 
            rdbCompromissosPeriodo.AutoSize = true;
            rdbCompromissosPeriodo.Location = new Point(27, 168);
            rdbCompromissosPeriodo.Margin = new Padding(3, 4, 3, 4);
            rdbCompromissosPeriodo.Name = "rdbCompromissosPeriodo";
            rdbCompromissosPeriodo.Size = new Size(291, 29);
            rdbCompromissosPeriodo.TabIndex = 0;
            rdbCompromissosPeriodo.TabStop = true;
            rdbCompromissosPeriodo.Text = "Compromissos em um período";
            rdbCompromissosPeriodo.UseVisualStyleBackColor = true;
            rdbCompromissosPeriodo.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Location = new Point(27, 128);
            rdbCompromissosFuturos.Margin = new Padding(3, 4, 3, 4);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(225, 29);
            rdbCompromissosFuturos.TabIndex = 0;
            rdbCompromissosFuturos.TabStop = true;
            rdbCompromissosFuturos.Text = "Compromissos Futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Location = new Point(27, 88);
            rdbCompromissosPassados.Margin = new Padding(3, 4, 3, 4);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(238, 29);
            rdbCompromissosPassados.TabIndex = 0;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // rdbTodosCompromissos
            // 
            rdbTodosCompromissos.AutoSize = true;
            rdbTodosCompromissos.Location = new Point(27, 48);
            rdbTodosCompromissos.Margin = new Padding(3, 4, 3, 4);
            rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            rdbTodosCompromissos.Size = new Size(235, 29);
            rdbTodosCompromissos.TabIndex = 0;
            rdbTodosCompromissos.TabStop = true;
            rdbTodosCompromissos.Text = "Todos os Compromissos";
            rdbTodosCompromissos.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 344);
            Controls.Add(groupBox1);
            Controls.Add(btnGravar);
            Controls.Add(btnCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Filtro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private RadioButton rdbTodosCompromissos;
        private RadioButton rdbCompromissosFuturos;
        private RadioButton rdbCompromissosPassados;
        private DateTimePicker txtInicioPeriodo;
        private RadioButton rdbCompromissosPeriodo;
        private Label lblTerminoPeriodo;
        private Label lblInicioPeriodo;
        private DateTimePicker txtTerminoPeriodo;
    }
}