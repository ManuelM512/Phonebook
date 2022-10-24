using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact yo = new Contact("Manu");
            // Crear la lista de contactos
            Phonebook agenda = new Phonebook(yo);
            // Agregar contactos a la lista
            agenda.Add("AlterEgo", "091690850", "aaaa", "Manuel45720107");
            string[] nombres = new string[1] {"AlterEgo"};
            // Enviar un msj de Twitter
            Twitter twitterChannel = new Twitter();
            agenda.Send(nombres, twitterChannel, "Buenasss");
            // Enviar un WhatsApp a algunos contactos
            Whatsapp whatsappChannel = new Whatsapp();
            agenda.Send(nombres, whatsappChannel, "Buenas, te lo mando desde el vsCode, saludos");
        }
    }
}
