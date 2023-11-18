namespace DZ_c_dies_773
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lotus lot = new Lotus();
            UAZ uazik = new UAZ();
            Marusssia mar = new Marusssia();
            Gonka GON = new Gonka();
            GON.AddVoiture(lot);
            GON.AddVoiture(uazik);
            GON.AddVoiture(mar);
            GON.Igra();

            Karta KARR = new Karta();
           // KARR.Mostra();
            //KARR.Mesh();    // перемешивание карт
           // KARR.Mostra();
            Giocatore gio1 = new Giocatore("111");
            Giocatore gio2 = new Giocatore("222");
            KARR.ADDGIO(gio1);
            KARR.ADDGIO(gio2);
            KARR.RAZDACIA();
            gio1.Mostrr();
            gio2.Mostrr();
            gio1.QUUUU();
            gio2.QUUUU();
            KARR.IGGGGOgo();
            // Интересно поолучилось, но побеждает не то игрок)))

        }
    }
}