namespace ConsoleAppIMC
{
    public class  Profil 
    {
        protected string nom;
        protected string prenom;
        protected int poids;
        protected int taille;


        public Profil(string unNom, string unPrenom, int unPoids, int uneTaille)
        {
            nom = unNom;
            prenom = unPrenom;
            poids = unPoids;
            taille = uneTaille;
        }

        public float calculIMC()
        {
            float tailleCm = (float)taille / 100;
            return (poids / (tailleCm * tailleCm));
        }





    }
}
