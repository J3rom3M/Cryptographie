/*
 * Liens interessants pour la cryptographie :
 * 
 * http://www.uqtr.ca/~delisle/Crypto/
 * 
 * Rijndael se prononce "Rain Doll".
 * 
 * */
using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Cryptographie
{
    /// <summary>
    /// Description résumée de Main.
    /// </summary>
    public class Main : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_parcourir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.Container components = null;
        public static bool bAction = false;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_algo;
        private System.Windows.Forms.RadioButton radioButton_algonormal;
        private System.Windows.Forms.RadioButton radioButton_algoperso;
        private string mdp = "";
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusBar statusBar1;
        private string name_of_file = "";

        public Main(bool bCrypt)
        {
            //
            // Requis pour la prise en charge du Concepteur Windows Forms
            //
            InitializeComponent();

            //
            // TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
            //
            if (bCrypt)
            {
                this.Text = "Cryptage de fichiers";
                button1.Text = "Crypter !";
                openFileDialog1.Title = "Choisir un fichier à crypter...";
                openFileDialog1.Filter = "Tous les fichiers|*.*";

                statusBar1.Text = "Sélectionner un fichier à crypter";

                bAction = true;
            }
            else
            {
                this.Text = "Décryptage de fichiers";
                button1.Text = "Decrypter !";
                openFileDialog1.Title = "Choisir un fichier à décrypter...";
                openFileDialog1.Filter = "Fichiers MPS|*.mps";

                statusBar1.Text = "Sélectionner un fichier à décrypter";

                bAction = false;
            }
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_parcourir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_algo = new System.Windows.Forms.ListBox();
            this.radioButton_algonormal = new System.Windows.Forms.RadioButton();
            this.radioButton_algoperso = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";
            // 
            // button_parcourir
            // 
            this.button_parcourir.Location = new System.Drawing.Point(416, 24);
            this.button_parcourir.Name = "button_parcourir";
            this.button_parcourir.Size = new System.Drawing.Size(72, 32);
            this.button_parcourir.TabIndex = 2;
            this.button_parcourir.Text = "Parcourir";
            this.button_parcourir.Click += new System.EventHandler(this.button_parcourir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.InitialDirectory = "C:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 32);
            this.button1.TabIndex = 3;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "Retour";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Quitter";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(336, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 192);
            this.label2.TabIndex = 6;
            this.label2.Text = "Algorithme";
            // 
            // listBox_algo
            // 
            this.listBox_algo.Enabled = false;
            this.listBox_algo.Location = new System.Drawing.Point(344, 184);
            this.listBox_algo.Name = "listBox_algo";
            this.listBox_algo.Size = new System.Drawing.Size(160, 82);
            this.listBox_algo.TabIndex = 8;
            // 
            // radioButton_algonormal
            // 
            this.radioButton_algonormal.Checked = true;
            this.radioButton_algonormal.Location = new System.Drawing.Point(352, 112);
            this.radioButton_algonormal.Name = "radioButton_algonormal";
            this.radioButton_algonormal.Size = new System.Drawing.Size(128, 24);
            this.radioButton_algonormal.TabIndex = 9;
            this.radioButton_algonormal.TabStop = true;
            this.radioButton_algonormal.Text = "Algorithme Rijndael";
            this.radioButton_algonormal.CheckedChanged += new System.EventHandler(this.Allow_Algo_Normal);
            // 
            // radioButton_algoperso
            // 
            this.radioButton_algoperso.Location = new System.Drawing.Point(352, 144);
            this.radioButton_algoperso.Name = "radioButton_algoperso";
            this.radioButton_algoperso.Size = new System.Drawing.Size(136, 24);
            this.radioButton_algoperso.TabIndex = 10;
            this.radioButton_algoperso.Text = "Algorithme Personnel";
            this.radioButton_algoperso.CheckedChanged += new System.EventHandler(this.Allow_AlgoPerso);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(280, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 295);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(544, 22);
            this.statusBar1.SizingGrip = false;
            this.statusBar1.TabIndex = 12;
            this.statusBar1.Text = "statusBar1";
            // 
            // Main
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(544, 317);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButton_algoperso);
            this.Controls.Add(this.radioButton_algonormal);
            this.Controls.Add(this.listBox_algo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_parcourir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private void button_parcourir_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            else
            {
                textBox1.Text = (string)openFileDialog1.FileName;
                progressBar1.Value = 0;

                if (bAction)
                {
                    statusBar1.Text = "Appuyer sur le bouton Crypter!";
                }
                else
                {
                    statusBar1.Text = "Appuyer sur le bouton Décrypter!";
                }
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
            Form1 New_Form = new Form1();
            New_Form.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Erreur, vous devez sélectionner un fichier", "Erreur de sélection de fichier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            else
            {
                Cle Form_Cle = new Cle();
                if (Form_Cle.ShowDialog() == DialogResult.OK)
                {
                    // Récupérer le mot de passe
                    mdp = Form_Cle.Password;

                    // Si on choisit l'algo simple
                    if (radioButton_algonormal.Checked == true)
                    {
                        if (bAction)
                        {
                            // On encrypte le fichier
                            Encrypt_File();
                        }
                        else
                        {
                            // Sinon, on décrypte le fichier
                            Decrypt_File();
                        }
                    }
                    // Sinon, on choisit un algo personnalisé
                    else if (radioButton_algoperso.Checked == true)
                    {
                        // Charegement de l'assembly (DLL) sélectionné dans la listbox
                        Assembly DLL_a_charger = Assembly.LoadFrom(Application.StartupPath + @"\plugins\" + listBox_algo.SelectedItem.ToString());

                        // Récupération de l'ensemble des classes contenues dans l'assembly
                        Type[] classes = DLL_a_charger.GetTypes();

                        // Arguments à passer à la fonction
                        string[] arg = new string[3];

                        // Fichier source
                        arg[0] = @textBox1.Text;

                        // Fichier crypté/decrypté
                        if (bAction)
                        {
                            // On encrypte
                            // Nom du futur fichier crypté = nom_extention.mps
                            arg[1] = Path.ChangeExtension(Path.GetFileName(@textBox1.Text.Replace('.', '_')), ".mps");
                        }
                        else
                        {
                            // On décrypte
                            // Nom du fichier décrypté = nom.extension
                            arg[1] = Path.ChangeExtension(Path.GetFileName(@textBox1.Text.Replace('_', '.')), "");
                        }

                        // Clé
                        arg[2] = mdp;

                        /*
						 * Appel de la fonction de cryptage
						 * Cette fonction doit porter le même nom 
						 * que le fichier.
						 * Ex : Pour la fonction XOR
						 *  fichier Fonction_Xor.dll => fonction Fonction_Xor
						 **/
                        string methode_name = listBox_algo.SelectedItem.ToString().Substring(0, listBox_algo.SelectedItem.ToString().Length - 4);

                        if (File.Exists(arg[1]))
                        {
                            File.Delete(arg[1]);
                        }

                        /*
						 * Paramètre 1 : nom de la méthode à appeler
						 * Paramètre 2 : Flags sur les filtres de recherche de la méthode :
						 * ici, nous recherchons une méthode publqie et statique
						 * Paramètre 5 : paramètre(s) à passer à la méthode
						 * */
                        classes[0].InvokeMember(methode_name, BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static, null, null, arg);

                        if (bAction)
                        {
                            MessageBox.Show("Le fichier a été crypté avec succès avec la fonction " + methode_name, "Crytage du fichier terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Le fichier a été décrypté avec succès avec la fonction " + methode_name, "Décryptage du fichier terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        // Méthode pour crypter les fichiers en utilisant la clé utilisateur
        private void Encrypt_File()
        {
            try
            {
                UnicodeEncoding Unicode_Encode = new UnicodeEncoding();

                // On convertit le mot de passe en tableau de byte
                byte[] key = Unicode_Encode.GetBytes(mdp);

                // Nom du futur fichier crypté = nom_extention.mps
                string File_To_Create = Path.ChangeExtension(Path.GetFileName(@textBox1.Text.Replace('.', '_')), ".mps");

                // Flux qui va créé le fichier crypté. Si le fichier existe
                // déjà, il est remplacé
                FileStream File_Crypted = new FileStream(File_To_Create, FileMode.Create);

                // On indique l'algorithme que l'on va utilisé pour le cryptage
                RijndaelManaged RM_Algo = new RijndaelManaged();

                // On indique que les données seront écrites dans File_Crypted
                // et que l'on utilisera aussi la clé saisi par l'utilisateur pour crypter
                CryptoStream Crypto_Stream = new CryptoStream(File_Crypted, RM_Algo.CreateEncryptor(key, key), CryptoStreamMode.Write);

                // On indique depuis quelle source on va lire les données
                FileStream File_To_Read = new FileStream(textBox1.Text, FileMode.Open);

                int donnees = 0;

                // On récupèr la taille du fichier et on l'affecte à
                // la valeur maximale de la progresse barre
                FileInfo Taille_Fichier = new FileInfo(@textBox1.Text);
                progressBar1.Maximum = (int)Taille_Fichier.Length;

                // Tant que l'on peut lire des bytes dans le fichier
                while ((donnees = File_To_Read.ReadByte()) != -1)
                {
                    // On écrit les bytes dans le fichier
                    Crypto_Stream.WriteByte((byte)donnees);

                    // On met un curseur en forme de sablier
                    this.Cursor = Cursors.WaitCursor;

                    // On fait avancer la progresse barre
                    progressBar1.PerformStep();
                }

                // On ferme les flux de données
                File_To_Read.Close();
                Crypto_Stream.Close();
                File_Crypted.Close();

                // On repasse le curseur en mode normal
                this.Cursor = Cursors.Arrow;

                statusBar1.Text = "Fichier crypté avec succès !";

                MessageBox.Show("Le fichier a été crypté avec succès !", "Crytage du fichier terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("Erreur lors du cryptage du fichier !", "Erreur de cryptage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode pour décrypter les fichiers  en utilisant la clé utilisateur
        private void Decrypt_File()
        {
            // Nom du fichier décrypté = nom.extension
            string File_To_Create = Path.ChangeExtension(Path.GetFileName(@textBox1.Text.Replace('_', '.')), "");

            try
            {
                UnicodeEncoding Unicode_Encode = new UnicodeEncoding();

                // On convertit le mot de passe en tableau de byte
                byte[] key = Unicode_Encode.GetBytes(mdp);

                // On indique depuis quelle source on va lire les données
                FileStream File_To_Read = new FileStream(textBox1.Text, FileMode.Open);

                // On indique l'algorithme que l'on va utilisé pour le cryptage
                RijndaelManaged RM_Algo = new RijndaelManaged();

                // On indique que les données seront écrites dans File_Crypted
                // et que l'on utilisera aussi la clé saisi par l'utilisateur pour décrypter
                CryptoStream Crypto_Stream = new CryptoStream(File_To_Read, RM_Algo.CreateDecryptor(key, key), CryptoStreamMode.Read);

                // Si le fichier destisnation existe
                if (File.Exists(File_To_Create))
                {
                    // On l'efface
                    File.Delete(File_To_Create);
                }
                // On instancie une stream qui va créée le fichier
                // décrypté.
                FileStream Stream_File = new FileStream(File_To_Create, FileMode.Create);

                int donnees = 0;

                // On récupère la taille du fichier et on l'affecte à
                // la valeur maximale de la progresse barre
                FileInfo Taille_Fichier = new FileInfo(@textBox1.Text);
                progressBar1.Maximum = (int)Taille_Fichier.Length;

                // Tant que l'on peut lire des bytes dans le fichier
                while ((donnees = Crypto_Stream.ReadByte()) != -1)
                {
                    // On écrit les bytes dans le fichier
                    Stream_File.WriteByte((byte)donnees);

                    // On met un curseur en forme de sablier
                    this.Cursor = Cursors.WaitCursor;

                    // On fait avancer la progresse barre
                    progressBar1.PerformStep();
                }

                // On ferme le flux de données
                Stream_File.Close();

                // On repasse le curseur en mode normal
                this.Cursor = Cursors.Arrow;
                /*
				else
				{
					// On déclenche une exception qui permettra d'indiquer
					// que le fichier existe déjà
					throw (new FileNotFoundException());
				}*/

                // Fermeture des autres flux ouverts
                Crypto_Stream.Close();
                File_To_Read.Close();

                statusBar1.Text = "Fichier décrypté avec succès !";

                MessageBox.Show("Le fichier a été décrypté avec succès !", "Décrytage du fichier terminé", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Erreur : Le fichier existe déjà !", "Erreur de décryptage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("Erreur lors du décryptage du fichier ! Est-ce la bonne clé / le bon algorithme ?", "Erreur de décryptage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Allow_AlgoPerso(object sender, System.EventArgs e)
        {
            if (radioButton_algoperso.Checked == true)
            {
                listBox_algo.Enabled = true;
                listBox_algo.SelectedIndex = 0;
            }
        }

        private void Allow_Algo_Normal(object sender, System.EventArgs e)
        {
            if (radioButton_algonormal.Checked == true)
            {
                listBox_algo.Enabled = false;
                listBox_algo.SelectedIndex = -1;
            }
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            try
            {
                string[] fichiers = Directory.GetFiles(Application.StartupPath + "\\plugins");

                for (int i = 0; i < fichiers.Length; i++)
                {
                    // Si le fichier est un .dll
                    if (Path.GetExtension(fichiers[i]) == ".dll")
                    {
                        int iPosBackSlash = fichiers[i].LastIndexOf(@"\") + 1;

                        name_of_file = fichiers[i].Substring(iPosBackSlash, fichiers[i].Length - iPosBackSlash);

                        // Si le fichier commence par Fonction_
                        if (name_of_file.StartsWith("Fonction_") == true)
                        {
                            // On ajoute le nom du fichie à la listBox
                            listBox_algo.Items.Add(name_of_file);
                        }
                    }
                }

                if (listBox_algo.Items.Count == 0)
                {
                    listBox_algo.Items.Add("Aucun algorithme personnel");
                    radioButton_algoperso.Enabled = false;
                    listBox_algo.Enabled = false;

                    radioButton_algonormal.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("Erreur, le répertoire plugins n'existe pas", "Erreur de chargement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
