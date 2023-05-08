class OrtWorld{
public static List<string> ListaDestinos {get; private set;}=new List<string>{"Buenos Aires", "Bariloche", "Mar del plata", "Viedma", "San Rafael", "Rawson","Puerto Madrin", "Neuquén","San Martín de Tucuman","Macabbi san Miguel"};
public static List<string> ListaHoteles {get; private set;}
public static List<string> ListaAereos {get; private set;}
public static List<string> ListaExcursiones {get; private set;}
public static Dictionary<string, Paquete> Paquetes {get; private set;}
public static bool IngresarPaquete(string destino, Paquete paquete)
{
    bool existe = true;
    if(Paquetes.Keys.Contains(destino)){

    }




}
}