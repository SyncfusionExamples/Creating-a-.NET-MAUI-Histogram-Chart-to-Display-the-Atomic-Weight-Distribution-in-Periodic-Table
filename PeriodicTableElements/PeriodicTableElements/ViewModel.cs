using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace PeriodicTableElements
{
    public class ViewModel: INotifyPropertyChanged
    {
        List<Model> elementsData;

        public event PropertyChangedEventHandler? PropertyChanged;
        public List<Model> ElementsData
        {
            get { return elementsData; }
            set
            {
                elementsData = value;
                NotifyPropertyChanged();
            }
        }

        public ViewModel()
        {
            ElementsData = ReadCSV();
        }

        private List<Model> ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("PeriodicTableElements.Resources.Raw.Table.csv");

            string? line;
            List<string> lines = new();

            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            List<Model> elementDetails = new();

            foreach (string line1 in lines)
            {
                string[] data = line1.Split(',');
                elementDetails.Add(new Model(
                     int.Parse(data[0]),
                     double.Parse(data[3])));
            }

            return (elementDetails);
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
