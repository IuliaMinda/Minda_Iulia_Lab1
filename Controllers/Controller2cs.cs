using Microsoft.AspNetCore.Mvc;

namespace Minda_Iulia_Lab1.Controllers
{
    public class Controller2cs : Controller
    {
        public string Index()
        {
            return "Welcome!";
        }

        public string Salut()
        { return "Hello!"; }

        public string Mesaj()
        { return "Primul laborator"; }

        public string Concatenare(string text, int numar)
        {
            string mesaj = text;
            mesaj += " ";
            mesaj += numar.ToString();
            return mesaj;
        }
    }
}
