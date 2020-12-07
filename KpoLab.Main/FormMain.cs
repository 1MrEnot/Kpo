namespace KpoLab.Main
{
    using Lib;
    using Lib.Commands.Factory;
    using Lib.Common;
    using Lib.Utils;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 2 лаба - абстрактная фабрика
    /// Сделать абстрактную фабрику <see cref="IAbstractCommandFactory"/>, фабрику команд заглушек <see cref="TestCommandFactory"/> и настоящих команд <see cref="FileCommandFactory"/> <br></br>
    /// Сделать получение и использование фабрики <see cref="IAbstractCommandFactory"/> из настроек <see cref="GlobalAppSettings"/> <br></br>
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
                var commandFactory = GlobalAppSettings.CommandFactory;
                var command = commandFactory.CreateLoader();
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
