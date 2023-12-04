using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Budgetplaner
{
    public partial class Form1 : Form
    {
        private string[] auswahlArray;
        private Chart chart;

        public Form1()
        {
            InitializeComponent();

            // Annahme: Die ComboBox ist bereits mit Elementen gefüllt
            auswahlArray = new string[comboBox1.Items.Count];

            // Erstelle das Chart-Objekt und fügen Sie es zum Formular hinzu
            chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Füge dem Diagramm eine Diagrammfläche hinzu
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Erstelle eine neue Datenreihe
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;

            // Füge die Daten aus der Datei zur Datenreihe hinzu
            UpdateChart();

            // Füge die Datenreihe zum Diagramm hinzu
            chart.Series.Add(series);

            // Fügen Sie das Diagrammsteuerelement zum Formular hinzu
            Controls.Add(chart);

            // sicher stellen, dass das Diagramm sichtbar ist
            chart.Visible = true;

        }
        private const string FileName = "ausgaben.txt";
        private void UpdateChartAutomatically()
        {
            // Aktualisiert das Diagramm automatisch, wenn Daten hinzugefügt werden
            UpdateChart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
        private void AddDataToSeries(Series series, string data)
        {
            if (data != null)
            {
                string[] parts = data.Split(' ');
                if (parts.Length == 2)
                {
                    string auswahl = parts[0];
                    decimal betrag;
                    if (decimal.TryParse(parts[1], out betrag))
                    {
                        series.Points.AddXY(auswahl, betrag);
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Überprüfen  ob eine Auswahl getroffen wurde
            if (comboBox1.SelectedIndex != -1)
            {
                // Überprüfen  ob ein Betrag eingegeben wurde
                if (decimal.TryParse(textBox1.Text, out decimal betrag))
                {
                    // Speichern der Auswahl und den Betrag in der Datei
                    string auswahl = comboBox1.SelectedItem.ToString();
                    int selectedIndex = comboBox1.SelectedIndex;

                    if (selectedIndex >= 0 && selectedIndex < auswahlArray.Length)
                    {
                        auswahlArray[selectedIndex] = $"{auswahl} {betrag:C}";

                        // Speichern des Array in der Datei
                        SaveArrayToFile();

                        MessageBox.Show($"Auswahl und Betrag in Datei gespeichert: {auswahl}, {betrag:C}");
                    }
                    else
                    {
                        MessageBox.Show("Ungültiger Index für die Auswahl.");
                    }
                }
                else
                {
                    MessageBox.Show("Bitte einen gültigen Betrag eingeben.");
                }
            }
            else
            {
                MessageBox.Show("Bitte eine Auswahl treffen.");
            }
        }

        private void SaveArrayToFile()
        {
            string dateipfad = "ausgaben.txt";

            try
            {
                File.WriteAllLines(dateipfad, auswahlArray);
                MessageBox.Show("Array erfolgreich in Datei gespeichert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Speichern des Arrays: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Speichern des  Array in der Datei, bevor das Formular geschlossen wird
            SaveArrayToFile();
        }

        private void chart2_Click(object sender, EventArgs e)
        {
            // Aktualisieren das Diagramm, wenn der Button geklickt wird
            UpdateChart();
        }

        private void UpdateChart()
        {
            if (chart.Series.Count > 0)
            {
                // Löschen der vorhandene Daten aus der Datenreihe
                chart.Series[0].Points.Clear();

                // F Daten aus dem Array zur Datenreihe hinzu
                foreach (string data in auswahlArray)
                {
                    AddDataToSeries(chart.Series[0], data);
                }
            }
            chart.Visible = true;
        }
        
    }
}

