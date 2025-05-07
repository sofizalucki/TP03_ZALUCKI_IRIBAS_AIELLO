namespace TP_03_ZIA.Models;
class Disco
{
    
    public string nombre { get; private set; }
    public string artista { get; private set; }
    public string productor{ get; private set; }
    public string genero{ get; private set; }
    public List <string>Temas = new List<string>();

    public int ID { get; private set; }
    public string foto{ get; private set; }

    public Disco(string nombre, string artista, string productor, string genero, string foto, int ID )
    {
    this.nombre = nombre;
    this.artista = artista;
    this.productor = productor;
    this.genero = genero;
    this.Temas = new List<string>();
    this.foto = foto;
    this.ID = ID;
    }

}