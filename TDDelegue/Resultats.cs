using System;
using System.Collections.Generic;
using System.Text;

namespace TDDelegue
{
    class Resultats : IResultats
    {
        public List<int> Data { get; set; } = new List<int> { 4, 3, 5 };

        private EventHandler _ajouterUnResultat;

        public event EventHandler AjouterUnResultat
        {
            add
            {
                Console.WriteLine("Quelqu'un s'est abonné à l'évènement");
                _ajouterUnResultat += value;
            }
            remove
            {
                Console.WriteLine("Impossible de se désabonner de l'évènement");
            }
        }

        public void RaiseTheEvent(int intToAdd)
        {
            _ajouterUnResultat?.Invoke(this, EventArgs.Empty);
            Data.Add(intToAdd);
            Console.WriteLine("Longueur de Resultats.Data (longueur initiale = 3) : " + Data.Count);
        }
    }
}
