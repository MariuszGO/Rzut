namespace Rzut
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int[] tab = new int[6];
            wynik.Text = "Wyniki losowań: ";
            Random los = new Random();
            int x = 0, suma = 0;
            int ilosc;
            int suma_p = 0;
            bool zmienna = true;
            //ilosc = Convert.ToInt32( ile.Text);
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = 0;
            }


            zmienna = Int32.TryParse(ile.Text, out ilosc);
            if (zmienna == false)
            {
                blad.Text = "Podałeś złą ilość";


            }
            else
            {
                blad.Text = "";
            }
            for (int i = 1; i <= ilosc; i++)
            {
                x = los.Next(1, 7);
                tab[x - 1]++;

                wynik.Text = wynik.Text + " , " + x;
                suma = suma + x;  //suma += x;
            }

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > 1)
                {
                    suma_p = suma_p + (i+1) * tab[i];
                }


            }

            //wynik.Text = Convert.ToString(ilosc);
            wynik1.Text = Convert.ToString(suma);
            wynik2.Text = Convert.ToString(suma_p);


        }
    }

}
