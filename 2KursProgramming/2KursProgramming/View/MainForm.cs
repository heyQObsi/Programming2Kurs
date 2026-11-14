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
            cartsTab1.CartCustomersUpdater = _store.Cutomers;
            cartsTab1.CartItemUpdater = _store.Items;
        }

        private void MainIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainIcon.SelectedIndex >= 0)
            {
                cartsTab1.RefreshData();
            }
        }
    }
}
