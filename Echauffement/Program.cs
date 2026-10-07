namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
       
            Console.WriteLine("je m'appelle pelle et j'aime farming simulator");
       
// Etape 2 : demandez à l'utilisateur son prénom et son âge

                string name = Console.WriteLine("quel-est ton nom?");
                int Age = Console.WriteLine("quel-est ton age?");

// Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

                    int Age = Console.ReadLine(if Age < 18 = ((console.WriteLine "majeur") else Age > 18 = (console.WriteLine "mineur"));

// Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

                        float money = Console.WriteLine("combien d'euros as-tu?");
                        float money = Console.ReadLine();

                        float money = Console.WriteLine("combien d'euros as-tu?");
                        float money = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

                            global::System.Object weapon1 = Console.WriteLine("\nfire spell: 18 coins");
                            global::System.Object weapon2 = Console.WriteLine("\nwater spell: 13 coins");
                            global::System.Object weapon3 = Console.WriteLine("\nrock spell: 15 coins");
                            global::System.Object weapon4 = Console.WriteLine("\nwind spell: 11 coins");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        int choix = Console.WriteLine("choisi ton spells: (1 fire spell, 2 water spell, 3 rock spell, 4 wind spell)");
        

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
        * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
        */
    }
}