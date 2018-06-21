using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication7
{
    /// <summary>
    /// Interaction logic for ToDoItem.xaml
    /// </summary>
    public partial class ToDoItem : UserControl
    {
        public string ItemName
        {
            get
            {
                return ItemNameTb.Text;
            }
            set
            {
                ItemNameTb.Text = value;
            }
        }
        public string DateName
        {
            get
            {
                return Date.Text;
            }
            set
            {
                Date.Text = value;
            }
        }
        public string MoneyName
        {
            get
            {
                return Money.Text;
            }
            set
            {
                Money.Text = value;
            }
        }

        public ToDoItem()
            {
                InitializeComponent();
            }
    }
    }