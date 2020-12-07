using KpoLab.Lib;
using System.Windows.Forms;

namespace KpoLab.Main
{
    public partial class FormSystem : Form
    {
        private InformationSystem _informationSystem;

        public InformationSystem InformationSystem
        {
            get => _informationSystem;
            set
            {
                _informationSystem = value;
                textBoxOs.Text = _informationSystem.OperationSystem;
                textBoxDatabase.Text = _informationSystem.Database;
                textBoxMemory.Text = _informationSystem.MemoryAmount.ToString();
                textBoxPlace.Text = _informationSystem.RamAmount.ToString();
            }
        }

        public FormSystem()
        {
            InitializeComponent();
        }
    }
}
