namespace TP_03_ZIA.Models;
static class Grupo
{
    static public Dictionary<int, Disco> Discos{get; private set;}
static public void InicializarDiscografica()
{
    Disco = new Dictionary<int, Integrante>();
    DatoPersonal Person = new DatoPersonal("Agustin", "Aiello", new DateTime(2008,07,17) , "/Agus.jpeg");
    List<DatoFamiliar> Familieros= new List<DatoFamiliar> ();
    Familieros.Add (new DatoFamiliar("Ciruja", "Campano", "Padre", "Padre muy atento y responsable"));
    Familieros.Add (new DatoFamiliar ("Ailu", "Severino", "Tia", "Sovietica de corazon"));
    DatosInteres Interes = new DatosInteres("Fulbinho", "Flash", "Lobo Solitario", "Matematica y Fisica");
    Integrantes.Add(48612009,new Integrante(48612009, Person, Familieros, Interes));

}