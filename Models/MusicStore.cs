namespace TP_03_ZIA.Models;
static class MusicStore
{
    static public Dictionary<int, Disco> Discos{get; private set;}
static public void InicializarDiscografica()
{
Discos = new Dictionary<int, Disco>();

Disco disco1 = new Disco("AM", "Arctic Monkeys", "James Ford", "Indie Rock", "/AM.jpg",1 );
disco1.Temas.Add("Do I Wanna Know?");
disco1.Temas.Add("R U Mine?");
disco1.Temas.Add("One for the Road");
disco1.Temas.Add("Arabella");
disco1.Temas.Add("I Want It All");
disco1.Temas.Add("No. 1 Party Anthem");
disco1.Temas.Add("Mad Sounds");
disco1.Temas.Add("Fireside");
disco1.Temas.Add("Why'd You Only Call Me When You're High?");
disco1.Temas.Add("Snap Out of It");
disco1.Temas.Add("Knee Socks");
disco1.Temas.Add("I Wanna Be Yours");
Discos.Add(1, disco1);

Disco disco2 = new Disco("Midnights", "Taylor Swift", "Jack Antonoff", "Pop", "/midnights.jpg",2 );
disco2.Temas.Add("Lavender Haze");
disco2.Temas.Add("Maroon");
disco2.Temas.Add("Anti-Hero");
disco2.Temas.Add("Snow on the Beach");
disco2.Temas.Add("You're on Your Own, Kid");
disco2.Temas.Add("Midnight Rain");
disco2.Temas.Add("Question...?");
disco2.Temas.Add("Vigilante Shit");
disco2.Temas.Add("Bejeweled");
disco2.Temas.Add("Labyrinth");
disco2.Temas.Add("Karma");
disco2.Temas.Add("Sweet Nothing");
disco2.Temas.Add("Mastermind");
Discos.Add(2, disco2);

Disco disco3 = new Disco("A Rush of Blood to the Head", "Coldplay", "Ken Nelson", "Alternative Rock", "/rush.jpg",3 );
disco3.Temas.Add("Politik");
disco3.Temas.Add("In My Place");
disco3.Temas.Add("God Put a Smile upon Your Face");
disco3.Temas.Add("The Scientist");
disco3.Temas.Add("Clocks");
disco3.Temas.Add("Daylight");
disco3.Temas.Add("Green Eyes");
disco3.Temas.Add("Warning Sign");
disco3.Temas.Add("A Whisper");
disco3.Temas.Add("A Rush of Blood to the Head");
disco3.Temas.Add("Amsterdam");
Discos.Add(3, disco3);

Disco disco4 = new Disco("Lemonade", "Beyoncé", "Various", "R&B", "/lemomonade.jpg", 4);
disco4.Temas.Add("Pray You Catch Me");
disco4.Temas.Add("Hold Up");
disco4.Temas.Add("Don't Hurt Yourself");
disco4.Temas.Add("Sorry");
disco4.Temas.Add("6 Inch");
disco4.Temas.Add("Daddy Lessons");
disco4.Temas.Add("Love Drought");
disco4.Temas.Add("Sandcastles");
disco4.Temas.Add("Forward");
disco4.Temas.Add("Freedom");
disco4.Temas.Add("All Night");
disco4.Temas.Add("Formation");
Discos.Add(4, disco4);

Disco disco5 = new Disco("Abbey Road", "The Beatles", "George Martin", "Rock", "/abbey.jpg", 5);
disco5.Temas.Add("Come Together");
disco5.Temas.Add("Something");
disco5.Temas.Add("Maxwell's Silver Hammer");
disco5.Temas.Add("Oh! Darling");
disco5.Temas.Add("Octopus's Garden");
disco5.Temas.Add("I Want You (She's So Heavy)");
disco5.Temas.Add("Here Comes the Sun");
disco5.Temas.Add("Because");
disco5.Temas.Add("You Never Give Me Your Money");
disco5.Temas.Add("Sun King");
disco5.Temas.Add("Mean Mr Mustard");
disco5.Temas.Add("Polythene Pam");
disco5.Temas.Add("She Came In Through the Bathroom Window");
disco5.Temas.Add("Golden Slumbers");
disco5.Temas.Add("Carry That Weight");
disco5.Temas.Add("The End");
disco5.Temas.Add("Her Majesty");
Discos.Add(5, disco5);

Disco disco6 = new Disco("DAMN.", "Kendrick Lamar", "Various", "Hip-Hop", "/DAMN.jpg",6 );
disco6.Temas.Add("BLOOD.");
disco6.Temas.Add("DNA.");
disco6.Temas.Add("YAH.");
disco6.Temas.Add("ELEMENT.");
disco6.Temas.Add("FEEL.");
disco6.Temas.Add("LOYALTY.");
disco6.Temas.Add("PRIDE.");
disco6.Temas.Add("HUMBLE.");
disco6.Temas.Add("LUST.");
disco6.Temas.Add("LOVE.");
disco6.Temas.Add("XXX.");
disco6.Temas.Add("FEAR.");
disco6.Temas.Add("GOD.");
disco6.Temas.Add("DUCKWORTH.");
Discos.Add(6, disco6);

Disco disco7 = new Disco("The Fame Monster", "Lady Gaga", "RedOne", "Pop", "/monster.jpg",7 );
disco7.Temas.Add("Bad Romance");
disco7.Temas.Add("Alejandro");
disco7.Temas.Add("Monster");
disco7.Temas.Add("Speechless");
disco7.Temas.Add("Dance in the Dark");
disco7.Temas.Add("Telephone");
disco7.Temas.Add("So Happy I Could Die");
disco7.Temas.Add("Teeth");
Discos.Add(7, disco7);

Disco disco8 = new Disco("Random Access Memories", "Daft Punk", "Daft Punk", "Electronic", "/random.jpg", 8);
disco8.Temas.Add("Give Life Back to Music");
disco8.Temas.Add("The Game of Love");
disco8.Temas.Add("Giorgio by Moroder");
disco8.Temas.Add("Within");
disco8.Temas.Add("Instant Crush");
disco8.Temas.Add("Lose Yourself to Dance");
disco8.Temas.Add("Touch");
disco8.Temas.Add("Get Lucky");
disco8.Temas.Add("Beyond");
disco8.Temas.Add("Motherboard");
disco8.Temas.Add("Fragments of Time");
disco8.Temas.Add("Doin' It Right");
disco8.Temas.Add("Contact");
Discos.Add(8, disco8);

Disco disco9 = new Disco("21", "Adele", "Paul Epworth", "Soul", "/21.jpg", 9);
disco9.Temas.Add("Rolling in the Deep");
disco9.Temas.Add("Rumour Has It");
disco9.Temas.Add("Turning Tables");
disco9.Temas.Add("Don't You Remember");
disco9.Temas.Add("Set Fire to the Rain");
disco9.Temas.Add("He Won't Go");
disco9.Temas.Add("Take It All");
disco9.Temas.Add("I'll Be Waiting");
disco9.Temas.Add("One and Only");
disco9.Temas.Add("Lovesong");
disco9.Temas.Add("Someone Like You");
Discos.Add(9, disco9);

Disco disco10 = new Disco("Metallica (Black Album)", "Metallica", "Bob Rock", "Metal", "/Metallica.jpg", 10);
disco10.Temas.Add("Enter Sandman");
disco10.Temas.Add("Sad but True");
disco10.Temas.Add("Holier Than Thou");
disco10.Temas.Add("The Unforgiven");
disco10.Temas.Add("Wherever I May Roam");
disco10.Temas.Add("Don't Tread on Me");
disco10.Temas.Add("Through the Never");
disco10.Temas.Add("Nothing Else Matters");
disco10.Temas.Add("Of Wolf and Man");
disco10.Temas.Add("The God That Failed");
disco10.Temas.Add("My Friend of Misery");
disco10.Temas.Add("The Struggle Within");
Discos.Add(10, disco10);

}
}