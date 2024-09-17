namespace ClassLibrary1{
    public class Archivo: Gestor
    {
        public void Guardar_Archivo()
        {
            using (FileStream archivo = new FileStream("Restaurante.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(archivo, Restaurante);
            }

        }

        public Restaurante Cargar_Archivo()
        {
            using (FileStream fs = new FileStream("Restaurante.dat", FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                restaurante = (Restaurante)formatter.Deserialize(fs);
                return restaurante;
            }
        }
    }
}