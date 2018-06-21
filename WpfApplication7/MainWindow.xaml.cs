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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            // 建立元件
            ToDoItem item = new ToDoItem();

            // 放入到 StackPanel
            ToDoList.Children.Add(item);
        }

        // 關閉視窗的事件
        private void Window_Closed(object sender, EventArgs e)
        {
            string data = "";

            // 取得每一個項目的文字
            foreach (ToDoItem item in ToDoList.Children)
            {
                if (item.ItemName != "")
                {
                    // 文字
                    data +=item.DateName+ "|" + item.ItemName + "|"+item.MoneyName+ "|" + "\r\n";
                }
            }

            // 存檔
            System.IO.File.WriteAllText(@"C:\temp\data.txt", data);
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 讀檔
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\data.txt");

            // 逐行產生元件
            foreach (string line in lines)
            {
                // 用符號分隔
                string[] parts = line.Split('|');

                // 建立元件
                ToDoItem item = new ToDoItem();
                item.DateName = parts[0];
                item.ItemName = parts[1];
                item.MoneyName = parts[2];

                // 放入到 StackPanel
                ToDoList.Children.Add(item);
            }
        }
    }
}