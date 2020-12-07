namespace KpoLab.Main
{
    using Lib;
    using Lib.Commands;
    using Lib.Utils;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 4 лаба - тесты <br></br>
    /// Создать парсер <see cref="Parser"/> для превращения строк в объекты  <br></br>
    /// Написать для него тесты <see cref="ParserTest"/><br></br>
    /// </summary>
    public partial class FormMain : Form
    {
        private readonly BindingSource bindingSource;

        public FormMain()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                var command = Ioc.Container.Resolve<ILoader>();
                command.Execute();
                var systems = command.Systems;
                
                bindingSource.DataSource = systems;
                dataGridMain.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void menuItemCreateAthlete_Click(object sender, EventArgs e)
        {
            var formSystem = new FormSystem();
            var currentSystem = (InformationSystem)bindingSource.Current;

            if (currentSystem == null)
            {
                currentSystem = new InformationSystem();
            }
            formSystem.InformationSystem = currentSystem;

            formSystem.ShowDialog();
        }
    }
}
