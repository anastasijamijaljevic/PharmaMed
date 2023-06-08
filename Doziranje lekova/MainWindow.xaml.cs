using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Doziranje_lekova
{

    public partial class MainWindow : Window
    {

        private List<Lekovi> lekovi;
        private Dictionary<string, string> podaciPacijenta = new Dictionary<string, string>()
        {
            {"Anastasija Mijaljevic", "SD123" },
            {"Marko Markovic", "SD223" },
            {"Ana Ivanovic", "SD222" }

        };

    private Dictionary<string, List<string>> medicinskiPodaci = new Dictionary<string, List<string>>()
    {
        {"SD123", new List<string>() {"Omeprazol", "Nolpaza"} },
        {"SD223", new List<string>() {"Emanera"} },
        {"SD222", new List<string>() {"Omeprazol", "Nolpaza", "Emanera"} }
    };
    public MainWindow()
    {
        InitializeComponent();

        lekovi = new List<Lekovi> {
                new Lekovi ("Omeprazol", "Kapusla" , 20),
                 new Lekovi ("Nolpaza", "Tableta" , 40),
                  new Lekovi ("Emanera", "Kapusla" , 20)


            };


        LekoviListBox.ItemsSource = lekovi;
    }

        private void BtnIzdati_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (!string.IsNullOrEmpty(input))
            {
                string IdPacijenta = GetIdPacijenta(input);
                if (IdPacijenta != null)
                {
                    IzdatiLek(IdPacijenta);
                }
                else
                {
                    MessageBox.Show("Pacijent nije pronadjen.Molimo pokusajte ponovo!", "Greska", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private string GetIdPacijenta(string input)
    {
        if(podaciPacijenta.ContainsKey(input))
        {
            return podaciPacijenta[input];
        }

        foreach(var pacijent in podaciPacijenta)
        {
            if(pacijent.Value==input)
            {
                return pacijent.Value;
            }
        }
        return null;
    }

        private void IzdatiLek(string IdPacijenta)
        {
            IzdatiLek(IdPacijenta, podaciPacijenta);
        }

        private void IzdatiLek(string IdPacijenta, Dictionary<string, string> podaciPacijenta)
    {
        if(medicinskiPodaci.ContainsKey(IdPacijenta))
        {
                MessageBoxResult messageBoxResult = MessageBox.Show($"Izdati lek za pacijenta sa brojem: {IdPacijenta}\n\nLekovi:\n\n{string.Join("\n", medicinskiPodaci[IdPacijenta])}", "Dozator Lekova", MessageBoxButton.OK, MessageBoxImage.Information);
        }
            else
            {
                MessageBox.Show("Nisu pronadjeni lekovi za datog pacijenta", "Dozator Lekova", MessageBoxButton.OK, MessageBoxImage.Information);
            }
    }


        private void LekoviListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LekoviListBox.SelectedItem is Lekovi izabraniLekovi)
            {
                MessageBox.Show($"Izabrani lek je:\n\nIme: {izabraniLekovi.Ime}\nTipLeka Tip:{izabraniLekovi.TipLeka}\nJacinaDoze Jacian{izabraniLekovi.JacinaDoze}");
            }


        }
    }
}
