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
    public partial class CategoryForm : Form
    {
        public event Action<string, string> EditCategoryEvent;
        public event Action<Category> AddCategoryEvent;
        private IReadOnlyList<Category> categories;
        public CategoryForm(IReadOnlyList<Category> _categories)
        {
            InitializeComponent();
            categories = _categories;
            if (_categories.Count > 0)
            {
                categoryGridView.DataSource = null;
                categoryGridView.DataSource = categories;
            }
        }
        private void categoryBtnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Name = nameTextBoxCategory.Text;
            bool categoryIsExist = false;
            bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(category.Name, "^[a-zA-Z]+$");
            foreach (Category Itemcategory in categories)
            {
                if (Itemcategory.Name == category.Name)
                {
                    categoryIsExist = true;
                }
            }
            if (nameTextBoxCategory.Text.Length > 0 && NameIsValid)
            {
                if (AddCategoryEvent != null && !categoryIsExist)
                {
                    AddCategoryEvent(category);
                }
                else
                {
                    if (NameIsValid)
                    {
                        MessageBox.Show("category IS Exist......");
                    } 
                }
                categoryGridView.DataSource = null;
                categoryGridView.DataSource = categories;
            }
            else
            {
                MessageBox.Show("Plz Valid Name Of Category......");
            }
        }
        private void categoryGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (categoryGridView.SelectedRows.Count > 0)
            {
                int InedxSelected = categoryGridView.SelectedRows[0].Index;
                nameTextBoxCategory.Text = categories[InedxSelected].Name;
            }
        }
        private void gunaAdvenceTileButton1_Click(object sender, EventArgs e)
        {
   
            if (categoryGridView.SelectedRows.Count > 0)
            {
                bool NameIsValid = System.Text.RegularExpressions.Regex.IsMatch(nameTextBoxCategory.Text, "^[a-zA-Z]+$");
                int InedxSelected = categoryGridView.SelectedRows[0].Index;
                string OldCategoryName = categories[InedxSelected].Name;
                string NewCategoryName = nameTextBoxCategory.Text;
                bool CatIsExist = false;
                foreach (Category item in categories)
                {
                    if (item.Name == NewCategoryName)
                    {
                        CatIsExist = true;
                    }
                }
                if (CatIsExist)
                {
                    MessageBox.Show("Category is Existing");
                }
                else
                {
                    if (EditCategoryEvent != null && NameIsValid)
                    {
                        EditCategoryEvent(OldCategoryName, NewCategoryName);
                        categoryGridView.DataSource = null;
                        categoryGridView.DataSource = categories;
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Data.......");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Category to edit");
            }
        }
    }
}
