using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.UI;
//DB
using MySql.Data.MySqlClient;


namespace CameraDetect
{
    public partial class Form1 : Form
    {
        private Capture capture;                    //Variable permettant de prendre des images de la caméra
        private bool captureInProgress;             // Vérifie si la capture est en cours d'éxécution
        private CascadeClassifier faceDetect;       //Déclaration de l'objet CascadeClassifier
        private Image<Bgr, Byte> ImageFrame;        //Définition de l'objet Image
        private Bitmap Visage = new Bitmap(350, 400);
        private Rectangle face;
        private Image<Bgr, Byte> SansRect;
        private ConnexionBD con;
        
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Chemin du fichier de détection EmguCV .xml au chargement du programme
            faceDetect = new CascadeClassifier("haarcascade_frontalface_default.xml");
            con = new ConnexionBD();
            
            if (con.OpenConnection() == true)
            {
                LblBDD.BackColor = Color.Green; //Si la connexion est OK : VERT
            }
            else
            {
                LblBDD.BackColor = Color.Red; //Si la connexion est KO : ROUGE
            }
        }
        private void ProcessFrame(object sender, EventArgs arg)
        {
            
            ImageFrame = capture.QueryFrame(); //Création d'un objet EmguCv type image nommé ImageFrame puis enregistrement
            if (ImageFrame != null)
            {
                SansRect = ImageFrame.Copy();
                Image<Gray, byte> GrayFrame = ImageFrame.Convert<Gray, byte>(); //Conversion de l'image en noir et blanc (plus facile pour la détection)

                //Enregistrement des visages détectés
                var faces = faceDetect.DetectMultiScale(
                        GrayFrame,           //image détéctée 
                        1.1,                //scaleFactor
                        3,                 //minNeighbors - Nb minimum de visage à détécter
                        new Size(150, 150),   //minSize
                        Size.Empty);        //

                if(faces.Length != 0)
                {
                    face = faces[0];
                    face.Inflate(0, 55);  //Agrandit ce rectangle de valeur spécifiée
                    ImageFrame.Draw(face, new Bgr(Color.Azure), 6); //Désine un rectangle autour du visage - Couleur + Bordure
                }
                imgBox.Image = ImageFrame;
            }
        }

        private void BtnStart_Click_1(object sender, EventArgs e)
        {
            #region Si capture n'éxiste pas, on le créé
            if (capture == null)
            {
                try
                {
                    capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }
            #endregion

            if (capture != null)
            {
                if (BtnStart.Text == "Pause")
                {
                    BtnStart.Text = "Reprendre";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    BtnStart.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }
                captureInProgress = !captureInProgress;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(capture != null)
            {
                if(captureInProgress)
                {
                    if(!face.IsEmpty)
                    {
                        try
                        {
                            Visage = SansRect.Bitmap.Clone(face, System.Drawing.Imaging.PixelFormat.DontCare);
                        }
                        catch
                        {
                            MessageBox.Show("Votre photo ne comprend pas de visage.");
                        }
                       imgBoxSave.Image = Visage;
                    }
                }
            }
        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            var @nom = TxtBoxNom.Text;
            var @prenom = TxtBoxPrenom.Text;
            ImageConverter imageC = new ImageConverter();
            

            MySqlConnection con = new MySqlConnection("server=127.0.0.1;port=3306;database=camera;uid=adm;");
            MySqlCommand query = new MySqlCommand("INSERT INTO utilisateur (id, nom, prenom, photo) VALUES ('',@nom ,@prenom, @photo)", con);

            query.Parameters.AddWithValue("@nom", TxtBoxNom.Text);
            query.Parameters.AddWithValue("@prenom", TxtBoxPrenom.Text);
            query.Parameters.AddWithValue("@photo", (byte[])imageC.ConvertTo(Visage, typeof(byte[])));
            
            try
            {
                con.Open();
                query.ExecuteNonQuery();
                MessageBox.Show("L'utilisateur a été ajouté!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }

    //Classe pour la Base de données
    class ConnexionBD : Form1
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public ConnexionBD()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            server = "127.0.0.1";
            database = "camera";
            uid = "adm";
            password = "";
            string connectionString;
            connectionString = connectionString =   "SERVER=" + server + ";" +
                                                    "DATABASE=" + database + ";" +
                                                    "UID=" + uid + ";" +
                                                    "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            
        }
        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Impossible de se connecter au serveur.");
                        break;

                    case 1045:
                        MessageBox.Show("Mot de passe ou identifiant invalide, veuillez réessayer!");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(String nom, String prenom, Bitmap photo)
        {
            
        }
    }
}

