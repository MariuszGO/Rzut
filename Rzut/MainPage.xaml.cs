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

            Image zd1= new Image { Source = "z1.png" };
            Image zd2 = new Image { Source = "z2.png" };
            Image zd3 = new Image { Source = "z3.png" };
            Image zd4 = new Image { Source = "z4.png" };
            Image zd5 = new Image { Source = "z5.png" };
            Image zd6 = new Image { Source = "z6.png" };



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

            int[]wyniki = new int[ilosc+5];
            for (int i = 0; i < ilosc+5; i++)
            {
                wyniki[i] = 0;
            }



                for (int i = 1; i <= ilosc; i++)
            {
                x = los.Next(1, 7);
                wyniki[i] = x;
                tab[x - 1]++;

                zdj1.Source = ImageSource.FromFile($"z{wyniki[1]}.png");
                zdj2.Source = ImageSource.FromFile($"z{wyniki[2]}.png");
                zdj3.Source = ImageSource.FromFile($"z{wyniki[3]}.png");
                zdj4.Source = ImageSource.FromFile($"z{wyniki[4]}.png");
                zdj5.Source = ImageSource.FromFile($"z{wyniki[5]}.png");


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
