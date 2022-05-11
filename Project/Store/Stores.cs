using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Stores : Form
    {
        public event Action<string, string, string> EditStoreEvent;
        public event Action<Store> AddStoreEvent;
        private IReadOnlyList<Store> stores;
        public Stores(IReadOnlyList<Store> _stores)
        {
            InitializeComponent();
            stores = _stores;
            if (_stores.Count > 0)
            {
                storeGridView2.DataSource = null;
                storeGridView2.DataSource = _stores;
            }
        }
        private void Add_Stor_Btn_Click_1(object sender, EventArgs e)
        {
            Store store = new Store();
            store.Name = storeName.Text.ToString();
            store.Address = storeAddress.Text.ToString();
            bool StoreIsExist = false;
            bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(store.Name, "^[a-zA-Z]+$");
            bool AddressIsValid = int.TryParse(store.Address, out _);
            foreach (Store Itemstore in stores)
            {
                if (Itemstore.Name == store.Name)
                {
                    StoreIsExist = true;
                }
            }
            if (storeName.Text.Length > 0 && storeAddress.Text.Length > 0 && NameIsValid && !AddressIsValid)
            {
                if (AddStoreEvent != null && !StoreIsExist)
                {
                    AddStoreEvent(store);
                    storeGridView2.DataSource = null;
                    storeGridView2.DataSource = stores;
                }
                if (StoreIsExist)
                {
                    MessageBox.Show("Store Is Exist......");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Data ......");
            }
        }
        private void storeGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (storeGridView2.SelectedRows.Count > 0)
            {

                int InedxSelected = storeGridView2.SelectedRows[0].Index;
                storeName.Text = stores[InedxSelected].Name;
                storeAddress.Text = stores[InedxSelected].Address;
            }
        }
        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if (storeGridView2.SelectedRows.Count > 0)
            {
                bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(storeName.Text, "^[a-zA-Z]+$");
                bool AddressIsValid = int.TryParse(storeAddress.Text, out _);
                int InedxSelected = storeGridView2.SelectedRows[0].Index;
                string OldStoreName = stores[InedxSelected].Name;
                string OldStoreAddress = stores[InedxSelected].Address;
                string NewStoreName = storeName.Text;
                string NewStoreAddress = storeAddress.Text;
                bool StoreIsExists = false;
                int counter = 0;
                foreach (Store item in stores)
                {
                    if (counter != InedxSelected)
                    {
                        if (item.Name == NewStoreName)
                        {
                            StoreIsExists = true;
                        }
                    }
                    counter++;
                }
                if (StoreIsExists)
                {
                    MessageBox.Show("Store is exists");
                }
                else
                {
                    if (EditStoreEvent != null && NameIsValid && !AddressIsValid)
                    {
                        EditStoreEvent(OldStoreName, NewStoreName, NewStoreAddress);
                        storeGridView2.DataSource = null;
                        storeGridView2.DataSource = stores;
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Data......");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Store to Edit it....");
            }
        }
    }
}