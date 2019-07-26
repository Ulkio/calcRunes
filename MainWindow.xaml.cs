using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Text.RegularExpressions;


namespace calcRunes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> lstHisto = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Rend les textbox numériques uniquement (regex)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grid_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Reset les textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewItem_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox textbox in grid.Children.OfType<TextBox>())
            {
                textbox.Text = "0";
            }
            historique.Items.Clear();
        }

        /// <summary>
        /// Génère une boîte de dialogue de confirmation, ajoute dans l'historique
        /// </summary>
        /// <returns></returns>
        private bool Message(string btnName)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Succès ?", "Forgemagie effectuée", System.Windows.Forms.MessageBoxButtons.YesNoCancel);
            if (result == System.Windows.Forms.DialogResult.No)
            {
                historique.Items.Add(btnName);
                return false;
            }
            else if (result == System.Windows.Forms.DialogResult.Yes)
            {
                historique.Items.Add(btnName);
                return true;
            }
            else
                return false;
        }

  

        /// <summary>
        /// Ajoute les bonus dans la textbox associée
        /// </summary>
        /// <param name="text"></param>
        /// <param name="bonus"></param>
        /// <returns></returns>
        private string AddRune(string text, int bonus)
        {
            int val = Convert.ToInt32(text);
            val += bonus;
            return text = val.ToString();
        }
        private string RemoveRune(string text, int bonus)
        {
            int val = Convert.ToInt32(text);
            if (val > 0)
                val -= bonus;
            return text = val.ToString(); ;
        }


        private void AddPuits(double valeur)
        {
            double valPuits = Convert.ToDouble(Puits.Text);
            if (valPuits != 0)
                valPuits += valeur;
            Puits.Text = valPuits.ToString();
        }

        private void RemovePuits(double valeur)
        {
            double valPuits = Convert.ToDouble(Puits.Text);
            valPuits -= valeur;

            Puits.Text = valPuits.ToString();
        }









        private void Vi_Click(object sender, RoutedEventArgs e)
        {
            if (Message((sender as Button).Name))
            {
                vitalite.Text = AddRune(vitalite.Text, 5);
                RemovePuits(1);
            }
               
        }


        private void PaVi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                vitalite.Text = AddRune(vitalite.Text, 15);
                RemovePuits(3);
            }
        }

        private void RaVi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                vitalite.Text = AddRune(vitalite.Text, 50);
                RemovePuits(10);
            }
        }

        private void Fo_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                force.Text = AddRune(force.Text, 1);
                RemovePuits(1);
            }

        }

        private void PaFo_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                force.Text = AddRune(force.Text, 3);
                RemovePuits(3);
            }
        }

        private void RaFo_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                force.Text = AddRune(force.Text, 10);
                RemovePuits(10);
            }
        }

        private void Ine_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                intel.Text = AddRune(intel.Text, 1);
                RemovePuits(1);
            }
        }

        private void PaIne_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                intel.Text = AddRune(intel.Text, 3);
                RemovePuits(3);
            }
        }

        private void RaIne_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                intel.Text = AddRune(intel.Text, 10);
                RemovePuits(10);
            }
        }

        private void Cha_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                chance.Text = AddRune(chance.Text, 1);
                RemovePuits(1);
            }
        }

        private void PaCha_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                chance.Text = AddRune(chance.Text, 3);
                RemovePuits(3);
            }
        }

        private void RaCha_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                chance.Text = AddRune(chance.Text, 10);
                RemovePuits(10);
            }
        }

        private void Age_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                agilite.Text = AddRune(agilite.Text, 1);
                RemovePuits(1);
            }
        }

        private void PaAge_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                agilite.Text = AddRune(agilite.Text, 3);
                RemovePuits(3);
            }
        }

        private void RaAge_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                agilite.Text = AddRune(agilite.Text, 10);
                RemovePuits(10);
            }
        }

        private void Ini_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                ini.Text = AddRune(ini.Text, 10);
                RemovePuits(1);
            }
        }

        private void PaIni_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                ini.Text = AddRune(ini.Text, 30);
                RemovePuits(3);
            }
        }

        private void RaIni_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                ini.Text = AddRune(ini.Text, 100);
                RemovePuits(10);
            }
        }
        private void Sa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                sagesse.Text = AddRune(sagesse.Text, 1);
                RemovePuits(3);
            }
        }

        private void PaSa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                sagesse.Text = AddRune(sagesse.Text, 3);
                RemovePuits(9);
            }
        }

        private void RaSa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                sagesse.Text = AddRune(sagesse.Text, 10);
                RemovePuits(30);
            }
        }

        private void Prospe_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                prospe.Text = AddRune(prospe.Text, 1);
                RemovePuits(3);
            }
        }

        private void PaProspe_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                prospe.Text = AddRune(prospe.Text, 3);
                RemovePuits(9);
            }
        }

        private void Pui_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                puissance.Text = AddRune(puissance.Text, 1);
                RemovePuits(2);
            }
        }

        private void PaPui_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                puissance.Text = AddRune(puissance.Text, 3);
                RemovePuits(6);
            }
        }

        private void RaPui_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                puissance.Text = AddRune(puissance.Text, 10);
                RemovePuits(20);
            }
        }

        private void RéNeutre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reneutre.Text = AddRune(reneutre.Text, 1);
                RemovePuits(2);
            }
        }

        private void RéTerre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reneutre.Text = AddRune(reneutre.Text, 3);
                RemovePuits(2);
            }
        }

        private void RéEau_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reeau.Text = AddRune(reeau.Text, 1);
                RemovePuits(2);
            }
        }

        private void RéAir_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reair.Text = AddRune(reair.Text, 1);
                RemovePuits(2);
            }
        }

        private void RéFeu_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                refeu.Text = AddRune(refeu.Text, 1);
                RemovePuits(2);
            }
        }

        private void RéPerNeutre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reperneutre.Text = AddRune(reperneutre.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPerTerre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reperterre.Text = AddRune(reperterre.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPerEau_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                repereau.Text = AddRune(repereau.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPerAir_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reperair.Text = AddRune(reperair.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPerFeu_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reperfeu.Text = AddRune(reperfeu.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPou_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                repou.Text = AddRune(repou.Text, 1);
                RemovePuits(2);
            }
        }

        private void PaRéPou_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                repou.Text = AddRune(repou.Text, 3);
                RemovePuits(6);
            }
        }

        private void RéCri_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                recri.Text = AddRune(recri.Text, 1);
                RemovePuits(2);
            }
        }

        private void PaRéCri_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                recri.Text = AddRune(recri.Text, 1);
                RemovePuits(6);
            }
        }

        private void RéPa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reretpa.Text = AddRune(reretpa.Text, 1);
                RemovePuits(7);
            }
        }

        private void PaRéPa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reretpa.Text = AddRune(reretpa.Text, 3);
                RemovePuits(21);
            }
        }

        private void RéPm_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reretpm.Text = AddRune(reretpm.Text, 1);
                RemovePuits(7);
            }
        }

        private void PaRéPm_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reretpm.Text = AddRune(reretpm.Text, 3);
                RemovePuits(21);
            }
        }

        private void RetPa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                retpa.Text = AddRune(retpa.Text, 1);
                RemovePuits(7);
            }
        }

        private void PaRetPa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                retpa.Text = AddRune(retpa.Text, 3);
                RemovePuits(21);
            }
        }

        private void RetPm_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                retpm.Text = AddRune(retpm.Text, 1);
                RemovePuits(7);
            }
        }

        private void PaRetPm_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                retpm.Text = AddRune(retpm.Text, 3);
                RemovePuits(21);
            }
        }

        private void Pod_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                pod.Text = AddRune(pod.Text, 10);
                RemovePuits(2.5);
            }
        }

        private void PaPod_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                pod.Text = AddRune(pod.Text, 30);
                RemovePuits(7.5);
            }
        }

        private void RaPod_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                pod.Text = AddRune(pod.Text, 100);
                RemovePuits(25);
            }
        }

        private void Tac_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                tacle.Text = AddRune(tacle.Text, 1);
                RemovePuits(4);
            }
        }

        private void PaTac_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                tacle.Text = AddRune(tacle.Text, 3);
                RemovePuits(12);
            }
        }

        private void Fui_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                fuite.Text = AddRune(fuite.Text, 1);
                RemovePuits(4);
            }
        }

        private void PaFui_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                fuite.Text = AddRune(fuite.Text, 3);
                RemovePuits(12);
            }
        }

        private void Do_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dom.Text = AddRune(dom.Text, 1);
                RemovePuits(20);
            }
        }

        private void DoNeutre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doneutre.Text = AddRune(doneutre.Text, 1);
                RemovePuits(5);
            }
        }

        private void DoTerre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doterre.Text = AddRune(doterre.Text, 1);
                RemovePuits(5);
            }
        }

        private void DoEau_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doeau.Text = AddRune(doeau.Text, 1);
                RemovePuits(5);
            }
        }

        private void DoAir_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doair.Text = AddRune(doair.Text, 1);
                RemovePuits(5);
            }
        }

        private void DoFeu_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dofeu.Text = AddRune(dofeu.Text, 1);
                RemovePuits(5);
            }
        }

        private void DoPi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dopi.Text = AddRune(dopi.Text, 1);
                RemovePuits(5);
            }
        }

        private void PaDoNeutre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doneutre.Text = AddRune(doneutre.Text, 3);
                RemovePuits(15);
            }
        }

        private void PaDoTerre_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doterre.Text = AddRune(doterre.Text, 3);
                RemovePuits(15);
            }
        }

        private void PaDoEau_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doeau.Text = AddRune(doeau.Text, 3);
                RemovePuits(15);
            }
        }

        private void PaDoAir_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doair.Text = AddRune(doair.Text, 3);
                RemovePuits(15);
            }
        }

        private void PaDoFeu_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dofeu.Text = AddRune(dofeu.Text, 3);
                RemovePuits(15);
            }
        }

        private void PaDoPi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dopi.Text = AddRune(dopi.Text, 3);
                RemovePuits(15);
            }
        }

        private void DoPerDi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dodist.Text = AddRune(dodist.Text, 1);
                RemovePuits(15);
            }
        }

        private void DoPerAr_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doarme.Text = AddRune(doarme.Text, 1);
                RemovePuits(15);
            }
        }

        private void DoPerSo_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                dosort.Text = AddRune(dosort.Text, 1);
                RemovePuits(15);
            }
        }

        private void DoPerMé_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                domelee.Text = AddRune(domelee.Text, 1);
                RemovePuits(15);
            }
        }

        private void RéPerDi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                reperdist.Text = AddRune(reperdist.Text, 1);
                RemovePuits(15);
            }
        }

        private void RéPerMe_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                repermelee.Text = AddRune(repermelee.Text, 1);
                RemovePuits(15);
            }
        }

        private void DoPerPi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doperpi.Text = AddRune(doperpi.Text, 1);
                RemovePuits(2);
            }
        }

        private void PaDoPerPi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doperpi.Text = AddRune(doperpi.Text, 3);
                RemovePuits(6);
            }
        }

        private void RaDoPerPi_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                doperpi.Text = AddRune(doperpi.Text, 10);
                RemovePuits(20);
            }
        }

        private void So_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                soin.Text = AddRune(soin.Text, 1);
                RemovePuits(10);
            }
        }

        private void Cri_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                crit.Text = AddRune(crit.Text, 1);
                RemovePuits(10);
            }
        }

        private void DoRen_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                renvoi.Text = AddRune(renvoi.Text, 1);
                RemovePuits(10);
            }
        }

        private void Invo_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                invo.Text = AddRune(invo.Text, 1);
                RemovePuits(30);
            }
        }

        private void Po_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                po.Text = AddRune(po.Text, 1);
                RemovePuits(51);
            }
        }

        private void Pm_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                pm.Text = AddRune(pm.Text, 1);
                RemovePuits(90);
            }
        }

        private void Pa_Click(object sender, RoutedEventArgs e)
        {
            if ((Message((sender as Button).Name)))
            {
                pa.Text = AddRune(pa.Text, 1);
                RemovePuits(100);
            }
        }

        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////
        ////////////////////////////////////////




        private void Onevitalite_Click(object sender, RoutedEventArgs e)
        {
            vitalite.Text = RemoveRune(vitalite.Text, 1);
            AddPuits(0.2);
        }

        private void Tenvitalite_Click(object sender, RoutedEventArgs e)
        {
            vitalite.Text = RemoveRune(vitalite.Text, 10);
            AddPuits(2);
        }

        private void Hundvitalite_Click(object sender, RoutedEventArgs e)
        {
            vitalite.Text = RemoveRune(vitalite.Text, 100);
            AddPuits(20);
        }

        private void Oneforce_Click(object sender, RoutedEventArgs e)
        {
            force.Text = RemoveRune(force.Text, 1);
            AddPuits(1);
        }

        private void Tenforce_Click(object sender, RoutedEventArgs e)
        {
            force.Text = RemoveRune(force.Text, 10);
            AddPuits(10);
        }

        private void Oneintel_Click(object sender, RoutedEventArgs e)
        {
            intel.Text = RemoveRune(intel.Text, 1);
            AddPuits(1);
        }

        private void Tenintel_Click(object sender, RoutedEventArgs e)
        {
            intel.Text = RemoveRune(intel.Text, 10);
            AddPuits(10);
        }

        private void Onechance_Click(object sender, RoutedEventArgs e)
        {
            chance.Text = RemoveRune(chance.Text, 1);
            AddPuits(1);
        }

        private void Tenchance_Click(object sender, RoutedEventArgs e)
        {
            chance.Text = RemoveRune(chance.Text, 10);
            AddPuits(10);
        }

        private void Oneagilite_Click(object sender, RoutedEventArgs e)
        {
            agilite.Text = RemoveRune(agilite.Text, 1);
            AddPuits(1);
        }

        private void Tenagilite_Click(object sender, RoutedEventArgs e)
        {
            agilite.Text = RemoveRune(agilite.Text, 10);
            AddPuits(2);
        }

        private void Oneinitiative_Click(object sender, RoutedEventArgs e)
        {
            ini.Text = RemoveRune(ini.Text, 1);


            AddPuits(0.1);
        }

        private void Teninitiative_Click(object sender, RoutedEventArgs e)
        {
            ini.Text = RemoveRune(ini.Text, 10);
            AddPuits(1);
        }

        private void Hundinitiative_Click(object sender, RoutedEventArgs e)
        {
            ini.Text = RemoveRune(ini.Text, 100);
            AddPuits(100);
        }

        private void Onesagesse_Click(object sender, RoutedEventArgs e)
        {
            sagesse.Text = RemoveRune(sagesse.Text, 1);
            AddPuits(3);
        }

        private void Tensagesse_Click(object sender, RoutedEventArgs e)
        {
            sagesse.Text = RemoveRune(sagesse.Text, 10);
            AddPuits(30);
        }

        private void Oneprospection_Click(object sender, RoutedEventArgs e)
        {
            prospe.Text = RemoveRune(prospe.Text, 1);
            AddPuits(3);
        }

        private void Tenprospection_Click(object sender, RoutedEventArgs e)
        {
            prospe.Text = RemoveRune(prospe.Text, 10);
            AddPuits(30);
        }

        private void Onepuissance_Click(object sender, RoutedEventArgs e)
        {
            puissance.Text = RemoveRune(puissance.Text, 1);
            AddPuits(2);
        }

        private void Tenpuissance_Click(object sender, RoutedEventArgs e)
        {
            puissance.Text = RemoveRune(puissance.Text, 10);
            AddPuits(20);
        }

        private void Onereneutre_Click(object sender, RoutedEventArgs e)
        {
            reneutre.Text = RemoveRune(reneutre.Text, 1);
            AddPuits(2);

        }

        private void Tenreneutre_Click(object sender, RoutedEventArgs e)
        {
            reneutre.Text = RemoveRune(reneutre.Text, 10);
            AddPuits(20);
        }

        private void Onereterre_Click(object sender, RoutedEventArgs e)
        {
            reter.Text = RemoveRune(reter.Text, 1);
            AddPuits(2);
        }

        private void Tenreterre_Click(object sender, RoutedEventArgs e)
        {
            reter.Text = RemoveRune(reter.Text, 10);
            AddPuits(20);
        }

        private void Onereeau_Click(object sender, RoutedEventArgs e)
        {
            reeau.Text = RemoveRune(reeau.Text, 1);
            AddPuits(2);
        }

        private void Tenreeau_Click(object sender, RoutedEventArgs e)
        {
            reeau.Text = RemoveRune(reeau.Text, 10);
            AddPuits(20);
        }

        private void Onereair_Click(object sender, RoutedEventArgs e)
        {
            reair.Text = RemoveRune(reair.Text, 1);
            AddPuits(2);
        }

        private void Tenreair_Click(object sender, RoutedEventArgs e)
        {
            reair.Text = RemoveRune(reair.Text, 10);
            AddPuits(20);
        }

        private void Onerefeu_Click(object sender, RoutedEventArgs e)
        {
            refeu.Text = RemoveRune(refeu.Text, 1);
            AddPuits(2);
        }

        private void Tenrefeu_Click(object sender, RoutedEventArgs e)
        {
            refeu.Text = RemoveRune(refeu.Text, 10);
            AddPuits(20);
        }

        private void Onereperneutre_Click(object sender, RoutedEventArgs e)
        {
            reperneutre.Text = RemoveRune(reperneutre.Text, 1);
            AddPuits(6);
        }



        private void Onereperterre_Click(object sender, RoutedEventArgs e)
        {
            reperterre.Text = RemoveRune(reperterre.Text, 1);
            AddPuits(6);
        }



        private void Onerepereau_Click(object sender, RoutedEventArgs e)
        {
            repereau.Text = RemoveRune(repereau.Text, 1);
            AddPuits(6);
        }



        private void Onereperair_Click(object sender, RoutedEventArgs e)
        {
            reperair.Text = RemoveRune(reperair.Text, 1);
            AddPuits(6);
        }


        private void Onereperfeu_Click(object sender, RoutedEventArgs e)
        {
            reperfeu.Text = RemoveRune(reperfeu.Text, 1);
            AddPuits(6);
        }


        private void Onerepou_Click(object sender, RoutedEventArgs e)
        {
            repou.Text = RemoveRune(repou.Text, 1);
            AddPuits(6);
        }



        private void Onerecri_Click(object sender, RoutedEventArgs e)
        {
            recri.Text = RemoveRune(recri.Text, 1);
            AddPuits(2);
        }



        private void Onereretpa_Click(object sender, RoutedEventArgs e)
        {
            reretpa.Text = RemoveRune(reretpa.Text, 1);
            AddPuits(7);
        }



        private void Onereretpm_Click(object sender, RoutedEventArgs e)
        {
            reretpm.Text = RemoveRune(reretpm.Text, 1);
            AddPuits(7);
        }


        private void Oneretpa_Click(object sender, RoutedEventArgs e)
        {
            retpa.Text = RemoveRune(retpa.Text, 1);
            AddPuits(7);
        }



        private void Oneretpm_Click(object sender, RoutedEventArgs e)
        {
            retpm.Text = RemoveRune(retpm.Text, 1);
            AddPuits(7);
        }



        private void Onepods_Click(object sender, RoutedEventArgs e)
        {
            pod.Text = RemoveRune(pod.Text, 1);
            AddPuits(0.25);
        }
        private void Tenpods_Click(object sender, RoutedEventArgs e)
        {
            pod.Text = RemoveRune(pod.Text, 10);
            AddPuits(2.5);
        }
        private void Hundpods_Click(object sender, RoutedEventArgs e)
        {
            pod.Text = RemoveRune(pod.Text, 100);
            AddPuits(25);
        }



        private void Onetacle_Click(object sender, RoutedEventArgs e)
        {
            tacle.Text = RemoveRune(tacle.Text, 1);
            AddPuits(4);
        }
        private void Tentacle_Click(object sender, RoutedEventArgs e)
        {
            tacle.Text = RemoveRune(tacle.Text, 10);
            AddPuits(40);
        }

        private void Onefuite_Click(object sender, RoutedEventArgs e)
        {
            fuite.Text = RemoveRune(fuite.Text, 1);
            AddPuits(4);
        }

        private void Tenfuite_Click(object sender, RoutedEventArgs e)
        {
            fuite.Text = RemoveRune(fuite.Text, 10);
            AddPuits(40);
        }


        private void Onedo_Click(object sender, RoutedEventArgs e)
        {
            dom.Text = RemoveRune(dom.Text, 1);
            AddPuits(20);
        }



        private void Onedoneutre_Click(object sender, RoutedEventArgs e)
        {
            doneutre.Text = RemoveRune(doneutre.Text, 1);
            AddPuits(5);
        }



        private void Onedoterre_Click(object sender, RoutedEventArgs e)
        {
            doterre.Text = RemoveRune(doterre.Text, 1);
            AddPuits(5);
        }




        private void Onedoeau_Click(object sender, RoutedEventArgs e)
        {
            doeau.Text = RemoveRune(doeau.Text, 1);
            AddPuits(5);
        }


        private void Onedoair_Click(object sender, RoutedEventArgs e)
        {
            doair.Text = RemoveRune(doair.Text, 1);
            AddPuits(5);
        }

        private void Onedofeu_Click(object sender, RoutedEventArgs e)
        {
            dofeu.Text = RemoveRune(dofeu.Text, 1);
            AddPuits(5);
        }


        private void Onedopi_Click(object sender, RoutedEventArgs e)
        {
            dopi.Text = RemoveRune(dopi.Text, 1);
            AddPuits(5);
        }



        private void Onedoperdi_Click(object sender, RoutedEventArgs e)
        {
            dodist.Text = RemoveRune(dodist.Text, 1);
            AddPuits(15);
        }



        private void Onedoperme_Click(object sender, RoutedEventArgs e)
        {
            domelee.Text = RemoveRune(domelee.Text, 1);
            AddPuits(15);
        }


        private void Onedoperar_Click(object sender, RoutedEventArgs e)
        {
            doarme.Text = RemoveRune(doarme.Text, 1);
            AddPuits(15);
        }


        private void Onedoperso_Click(object sender, RoutedEventArgs e)
        {
            dosort.Text = RemoveRune(dosort.Text, 1);
            AddPuits(15);
        }


        private void Onereperdi_Click(object sender, RoutedEventArgs e)
        {
            reperdist.Text = RemoveRune(reperdist.Text, 1);
            AddPuits(15);
        }



        private void Onereperme_Click(object sender, RoutedEventArgs e)
        {
            repermelee.Text = RemoveRune(repermelee.Text, 1);
            AddPuits(15);
        }


        private void Onedoperpi_Click(object sender, RoutedEventArgs e)
        {
            doperpi.Text = RemoveRune(doperpi.Text, 1);
            AddPuits(2);
        }



        private void Oneso_Click(object sender, RoutedEventArgs e)
        {
            soin.Text = RemoveRune(soin.Text, 1);
            AddPuits(10);
        }

        private void Onecri_Click(object sender, RoutedEventArgs e)
        {
            crit.Text = RemoveRune(crit.Text, 1);
            AddPuits(10);
        }

        private void Onerenvoi_Click(object sender, RoutedEventArgs e)
        {
            renvoi.Text = RemoveRune(renvoi.Text, 1);
            AddPuits(10);
        }

        private void Oneinvo_Click(object sender, RoutedEventArgs e)
        {
            invo.Text = RemoveRune(invo.Text, 1);
            AddPuits(30);
        }

        private void Onepo_Click(object sender, RoutedEventArgs e)
        {
            po.Text = RemoveRune(po.Text, 1);
            AddPuits(51);
        }

        private void Onepm_Click(object sender, RoutedEventArgs e)
        {
            pm.Text = RemoveRune(pm.Text, 1);
            AddPuits(90);
        }

        private void Onepa_Click(object sender, RoutedEventArgs e)
        {
            pa.Text = RemoveRune(pa.Text, 1);
            AddPuits(100);
        }

       
    }
}
