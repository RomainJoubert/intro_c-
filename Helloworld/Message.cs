using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{

    public class Message
    {
        private int morning = 9;
        private int noon = 13;
        private int evening = 18;
        private IDateTime _date;

        //public Message(int matin, int midi, int soir)
        //{
        //    this.morning = matin;
        //    this.noon = midi;
        //    this.evening = soir;
        //}

        public Message()
            :this(new RealDateTime())
        {

        }

        public Message(IDateTime date)
        {
            _date = date;
        }


        public String getHelloMessage()
        {
            String message = String.Empty; //équivaut à écrire String message = "";
            String userName = System.Environment.UserName; //permet d'afficher le nom de l'utilisateur
            //DayOfWeek currentDay = localTime.DayOfWeek;
            DayOfWeek currentDay = _date.Date.DayOfWeek;
            DateTime localTime = _date.Date;

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
