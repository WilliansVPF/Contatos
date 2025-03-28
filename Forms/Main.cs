using Microsoft.Extensions.DependencyInjection;

namespace Forms
{
    public partial class Main : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            var login = _serviceProvider.GetRequiredService<Login>();
            login.ShowDialog();
        }
    }
}
