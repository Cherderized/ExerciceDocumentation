using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clTest
{
    public class Class1
    {
        private int id { get; }
        private string nom { get; }
        private string info { get; }
        private double cost { get; set; }
        /// <summary>
        /// Cette fonction est pour construire l'objet.
        /// </summary>
        /// <param name="id">premier paramètre, doit être différent</param>
        /// <param name="nom">deuxième paramètre</param>
        /// <param name="info">troisième paramètre</param>
        /// <param name="cost">quatrième paramètre</param>
        public Class1(int id, string nom, string info, double cost)
        {
            this.id = id;
            this.nom = nom;
            this.info = info;
            this.cost = cost;
        }
        /// <summary>
        /// Cette fonction est pour recevoir le nom et les info de l'objet en override la fonction de base .ToString().
        /// </summary>
        /// <returns>Retourne un string comprenant le nom et l'info séparé par un espace.</returns>
        public override string ToString()
        {
            return nom + " " + info;
        }
        /// <summary>
        /// Cette fonction est pour moddifier le cout de l'objet selon son id.
        /// </summary>
        /// <param name="id">premier paramètre, permet de choisir quel objet sera moddifier.</param>
        /// <param name="cost">deuxième paramètre, permet de moddifier le cout.</param>
        public void ChangeCostById(int id, double cost)
        {
            if (this.id == id)
            {
                this.cost = cost;
            }
        }
    }
}
