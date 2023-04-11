using System;
using System.Windows.Forms;

namespace Cryptographie
{
    /// <summary>
    /// Description résumée de Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button_crypter;
        private System.Windows.Forms.Button button_decrypter;
        private System.Windows.Forms.Button button1;
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            //
            // TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
            //
        }

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_crypter = new System.Windows.Forms.Button();
            this.button_decrypter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_crypter
            // 
            this.button_crypter.Location = new System.Drawing.Point(40, 56);
            this.button_crypter.Name = "button_crypter";
            this.button_crypter.Size = new System.Drawing.Size(80, 32);
            this.button_crypter.TabIndex = 0;
            this.button_crypter.Text = "Crypter";
            this.button_crypter.Click += new System.EventHandler(this.button_crypter_Click);
            // 
            // button_decrypter
            // 
            this.button_decrypter.Location = new System.Drawing.Point(168, 56);
            this.button_decrypter.Name = "button_decrypter";
            this.button_decrypter.Size = new System.Drawing.Size(80, 32);
            this.button_decrypter.TabIndex = 1;
            this.button_decrypter.Text = "Decrypter";
            this.button_decrypter.Click += new System.EventHandler(this.button_decrypter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quitter";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_decrypter);
            this.Controls.Add(this.button_crypter);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cryptage - Decryptage de fichiers";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void button_crypter_Click(object sender, System.EventArgs e)
        {
            Main form = new Main(true);
            form.Show();
            this.Hide();
        }

        private void button_decrypter_Click(object sender, System.EventArgs e)
        {
            Main form = new Main(false);
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
