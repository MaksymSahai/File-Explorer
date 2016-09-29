using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FileExplorer.ViewModel;

namespace FileExplorer.View
{
    /// <summary>
    /// Interaction logic for FileTree.xaml
    /// </summary>
    public partial class FileTree : UserControl
    {
        private ExplorerWindowViewModel _myViewModel;
        
        public FileTree()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(ViewLoaded);
        }

        private void ViewLoaded(object sender, RoutedEventArgs r)
        {
            _myViewModel = this.DataContext as ExplorerWindowViewModel;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            _myViewModel.FileTreeVM.CurrentTreeItem = (sender as TreeView).SelectedItem as DirInfo;
        }

        private void TreeView_Expanded(object sender, RoutedEventArgs e)
        {

            //_myViewModel.FileTreeVM.CurNode = (sender as TreeViewItem).Header as DirInfo;
            test.DataContext = _myViewModel;
            
        }
    }
}
