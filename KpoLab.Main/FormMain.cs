namespace KpoLab.Main
{
    using Lib;
    using Lib.Commands;
    using Lib.Common;
    using Lib.Utils;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 1 лаба - Настройка проекта
    /// Сделать объект <see cref="InformationSystem"/> <br></br>
    /// Сделать статический объект для настроек <see cref="GlobalAppSettings"/> <br></br>
    /// Сделать интерфейс для команды <see cref="ILoader"/>,
    /// команду-заглушку <see cref="TestLoader"/> и настоящую команду <see cref="SplitFileLoader"/>
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
                var command = new TestLoader();
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

        private void menuItemCreate_Click(object sender, EventArgs e)
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
