using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{

    public class Message
    {
        private int morning;
        private int noon;
        private int evening;

        public Message(int matin, int midi, int soir)
        {
            this.morning = matin;
            this.noon = midi;
            this.evening = soir;
        }

        public String getHelloMessage(DateTime localTime)
        {
            String message = String.Empty; //équivaut à écrire String message = "";
            String userName = System.Environment.UserName; //permet d'afficher le nom de l'utilisateur
            //DateTime localTime = DateTime.Now; //permet de récupérer la date et l'heure
            DayOfWeek currentDay = DateTime.Today.DayOfWeek;

            if (currentDay == DayOfWeek.Saturday | currentDay == DayOfWeek.Sunday | (currentDay == DayOfWeek.Friday &localTime.Hour >= evening) | (currentDay == DayOfWeek.Monday & localTime.Hour <= morning))
            {
                message = "Bon weekend " + userName + "\nNous sommes le : " + localTime.ToString("F") +
                    " vas-y mollo sur l'apéro !";
            }

            else if (localTime.Hour > evening)
            {
                message = "Bonsoir " + userName + "\nNous sommes le : " + localTime.ToString("F");
            }
            else if (localTime.Hour < noon)
            {
                message = "Bonjour " + userName + "\nNous sommes le : "  + localTime.ToString("F");
            }
            else
            {
                message = "Bon après-midi " + userName + "\nNous sommes le : " + localTime.ToString("F") + " et vas-y doucement sur la sieste !";
            }
            return message;
        }
    }
}
