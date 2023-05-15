class OrtWorld{
public static List<string> ListaDestinos {get; private set;}=new List<string>{"Buenos Aires", "Bariloche", "Mar del plata", "Viedma", "San Rafael", "Rawson","Puerto Madrin", "Neuquén","San Martín de Tucuman","Macabi san Miguel"};
public static List<string> ListaHoteles {get; private set;}=new List<string>{"Hilton.jfif", "HotelLlao.jpg", "Costa Galana.webp", "Casa Crespo Hotel Boutique.jfif", "Patios del Mediterraneo Apart Hotel.jfif", "Libertador.jfif","Rayentray Puerto Madryn.jfif", "La Morada Petit Hotel.jfif","Hotel Bicentenario Suites & Spa.jfif","macabi.jpg"};
public static List<string> ListaAereos {get; private set;}=new List<string>{"aerolineas_argentinas.png", "Alaska Airlines.png", "British Airways.png", "Delta.png", "Ethiopian.png", "Japan Airlines.png","LAN.jfif", "Lufthansa.png","Singapur.png","turkish_airlines.png"};
public static List<string> ListaExcursiones {get; private set;}=new List<string>{"lago.jpg", "playa.jpg", "montaña.jpg", "glaciar.jfif", "obelisko.jfif", "cataratas.jfif","cierro.jpg", "ciudad.jpg","cotur.jfif","turismo.jpg"};
public static Dictionary<string, Paquete> Paquetes {get; private set;}=new Dictionary<string, Paquete>();
public static bool IngresarPaquete(string destino, Paquete paquete)
{
    bool existe = true;
    if(Paquetes.Keys.Contains(destino)){
        existe=false;
    }
    return existe;
}
}