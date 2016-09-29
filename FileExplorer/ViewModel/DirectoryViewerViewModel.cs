using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using FileExplorer.Model;

namespace FileExplorer.ViewModel
{
    /// <summary>
    /// View model for the right side pane
    /// </summary>
    public class DirectoryViewerViewModel : ViewModelBase
    {
        #region // Private variables
        private ExplorerWindowViewModel _evm;
        private DirInfo _currentItem; 
        #endregion

        #region // .ctor
        public DirectoryViewerViewModel(ExplorerWindowViewModel evm)
        {
            _evm = evm;
        } 
        #endregion

        #region // Public members
        /// <summary>
        /// Indicates the current directory in the Directory view pane
        /// </summary>
        public DirInfo CurrentItem
        {
            get { return _currentItem; }
            set { _currentItem = value; }
        } 
        #endregion

        #region // Public Methods
        /// <summary>
        /// processes the current object. If this is a file then open it or if it is a directory then return its subdirectories
        /// </summary>
        public void OpenCurrentObject()
        {
            int objType = CurrentItem.DirType; //Dir/File type

            if ((ObjectType)CurrentItem.DirType == ObjectType.File)
            {
                System.Diagnostics.Process.Start(CurrentItem.Path);
            }
            else
            {
                _evm.CurrentDirectory = CurrentItem;
                _evm.FileTreeVM.ExpandToCurrentNode(_evm.CurrentDirectory);
            }
        } 
        #endregion
    }
}
