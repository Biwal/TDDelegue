using System;

namespace TDDelegue
{
    public delegate int CalculMethod(int[] data);

    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 3, 5 };
            ComputeOperation(data, CalculAlgos.Additionner);
            ComputeOperation(data, CalculAlgos.Multiplier);
            ComputeOperation(data, delegate (int[] data)
            {
                return (data[0] - data[1]);
            });
            ComputeOperation(data, data => { return (data[0] - data[1]); });

            Resultats resultats = new Resultats();
            resultats.AjouterUnResultat += OnAjouterUnResultat;
            resultats.AjouterUnResultat -= OnAjouterUnResultat;
            resultats.RaiseTheEvent(5);
        }

        private static int ComputeOperation(int[] data , CalculMethod calculMethod)
        {
            int res = calculMethod(data);
            Console.WriteLine(res);
            return res;
        }

        private static void OnAjouterUnResultat(object sender, EventArgs e)
        {
            Console.WriteLine("Le resultat est ajouté");
        }
    }
}
