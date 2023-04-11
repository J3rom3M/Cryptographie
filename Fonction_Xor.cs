using System;
using System.IO;
using System.Windows.Forms;

namespace Cryptographie
{
	/// <summary>
	/// Description résumée de Fonction_Xor.
	/// </summary>
	public class FonctionXor
	{
		public static void Fonction_Xor(string sourcefile, string resultfile, string key)
		{
			//
			// TODO : ajoutez ici la logique du constructeur
			//

			// Tableau de bytes
			byte[] buffer = new byte[2048];

			XORMelangeur Scrambler = new XORMelangeur(key);

			try
			{
				// Flux qui vont lire le fichier source et créer le fichier de destination
				FileStream iStream = new FileStream(sourcefile, FileMode.Open);
				FileStream oStream = new FileStream(resultfile, FileMode.CreateNew);

				int read;
				while( (read = iStream.Read(buffer, 0, 2048)) > 0 )
				{
					oStream.Write(Scrambler.scramble(buffer), 0, read);
				}
				iStream.Close();
				oStream.Flush();
				oStream.Close();

				buffer = null;
			}
			catch(Exception Ex)
			{
				MessageBox.Show("Erreur lors du cryptage du fichier avec la fonction XOR!\nErreur : " + Ex.Message, "Erreur de cryptage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public class XORMelangeur
		{
			byte[] key;

			// On prend la clé passée en paramètre
			public XORMelangeur(string keystring)
			{
				System.Text.ASCIIEncoding encodedData = new System.Text.ASCIIEncoding();
				// Et on la stocke dans un table de bytes
				key = encodedData.GetBytes(keystring);
			}
			
			// Pour "mélanger" les bytes des fichiers
			public byte[] scramble(byte[] b)
			{
				byte[] r = new byte[b.Length];
				for (int i = 0; i < b.Length;i++)
				{
					r[i] = (byte)(b[i] ^ key[i%key.Length]);
				}
				return r;
			}
		}
	}
}
