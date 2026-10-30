using _2KursProgramming.Model;
using _2KursProgramming.Services;
using _2KursProgramming.View;
using _2KursProgramming.View.Tabs;

namespace _2KursProgramming
{
    public partial class MainForm : Form
    {
        public Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.ItemsUpdater = _store.Items;
            customersTab1.CustomersUpdater = _store.Cutomers;
        }
    }
}
