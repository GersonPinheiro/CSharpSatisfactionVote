
namespace SatisfactionVote
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
            this.counterNaolbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.counterSimlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quest = new System.Windows.Forms.Label();
            this.btnnao = new System.Windows.Forms.Button();
            this.btnsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterNaolbl
            // 
            this.counterNaolbl.AutoSize = true;
            this.counterNaolbl.BackColor = System.Drawing.Color.Transparent;
            this.counterNaolbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterNaolbl.Location = new System.Drawing.Point(106, 212);
            this.counterNaolbl.Name = "counterNaolbl";
            this.counterNaolbl.Size = new System.Drawing.Size(17, 19);
            this.counterNaolbl.TabIndex = 13;
            this.counterNaolbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Não:";
            // 
            // counterSimlbl
            // 
            this.counterSimlbl.AutoSize = true;
            this.counterSimlbl.BackColor = System.Drawing.Color.Transparent;
            this.counterSimlbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterSimlbl.Location = new System.Drawing.Point(106, 176);
            this.counterSimlbl.Name = "counterSimlbl";
            this.counterSimlbl.Size = new System.Drawing.Size(17, 19);
            this.counterSimlbl.TabIndex = 11;
            this.counterSimlbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sim:";
            // 
            // quest
            // 
            this.quest.AutoSize = true;
            this.quest.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quest.Location = new System.Drawing.Point(55, 42);
            this.quest.Name = "quest";
            this.quest.Size = new System.Drawing.Size(632, 33);
            this.quest.TabIndex = 9;
            this.quest.Text = "Você ficou satisfeito com o atendimento da nossa loja?";
            // 
            // btnnao
            // 
            this.btnnao.BackColor = System.Drawing.Color.Red;
            this.btnnao.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnao.Location = new System.Drawing.Point(580, 104);
            this.btnnao.Name = "btnnao";
            this.btnnao.Size = new System.Drawing.Size(107, 51);
            this.btnnao.TabIndex = 8;
            this.btnnao.Text = "Não";
            this.btnnao.UseVisualStyleBackColor = false;
            this.btnnao.Click += new System.EventHandler(this.btnnao_Click);
            // 
            // btnsim
            // 
            this.btnsim.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsim.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsim.Location = new System.Drawing.Point(467, 104);
            this.btnsim.Name = "btnsim";
            this.btnsim.Size = new System.Drawing.Size(107, 51);
            this.btnsim.TabIndex = 7;
            this.btnsim.Text = "Sim";
            this.btnsim.UseVisualStyleBackColor = false;
            this.btnsim.Click += new System.EventHandler(this.btnsim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 302);
            this.Controls.Add(this.counterNaolbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.counterSimlbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quest);
            this.Controls.Add(this.btnnao);
            this.Controls.Add(this.btnsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label counterNaolbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label counterSimlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quest;
        private System.Windows.Forms.Button btnnao;
        private System.Windows.Forms.Button btnsim;
    }
}

