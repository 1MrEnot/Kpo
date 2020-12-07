namespace KpoLab.Main
{
    using Lib;
    using Lib.Commands;
    using Lib.Common;
    using Lib.Utils;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// 3 лаба - внедрение зависимостей <br></br>
    /// Установить <see cref="Castle.Windsor"/> через NuGet <br></br>
    /// Создать статический класс <see cref="Ioc"/> для внедрения зависимостей <br></br>
    /// Регестрировать в нём загрузчик <see cref="ILoader"/>, реализуемый либо <see cref="TestLoader"/> либо <see cref="SplitFileLoader"/>,
    /// в зависимости от настроек в <see cref="GlobalAppSettings"/> <br></br>
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
