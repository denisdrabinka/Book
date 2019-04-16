using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Xps.Packaging;
using System.Xml;
using System.Xml.Linq;




namespace MyFirstProject2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Image img1 = new Image();

        //Book book;

        public MainWindow()
        {
            InitializeComponent();
        }

        //private void TreeView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    using (BooksContext db = new BooksContext())
        //    {
        //        ControlLibraryDocViewer.Visibility = Visibility.Collapsed;
        //        ControlLibrary_StackPanelForImage.Visibility = Visibility.Collapsed;

        //        string name = (sender as TreeViewItem).Name;

        //        book = new Book();
        //        var findbook = db.Books.Where(b => b.NameSource == name);
        //        foreach (Book item in findbook)
        //        {
        //            book = item;
        //        }

        //        //TreeBook.Header = book.NameSource;

        //        if (book.MyImageSource1 != null)
        //        {
        //            img1.Source = new BitmapImage(new Uri(book.MyImageSource1));
        //            ControlLibrary_StackPanelForImage.Children.Clear();
        //            ControlLibrary_StackPanelForImage.Children.Add(img1);
        //            ControlLibraryDocViewer.Visibility = Visibility.Collapsed;
        //            ControlLibrary_StackPanelForImage.Visibility = Visibility.Visible;
        //        }
        //    }

        //}

        //private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        //{
        //    if (book.MyImageSource1 != null)
        //    {
        //        ImageVis.Visibility = Visibility.Visible;
        //    }
        //    if (book.MainWindow_xamlSource != null)
        //    {
        //        MainWindow_xamlVis.Visibility = Visibility.Visible;
        //    }
        //    //if (book.mainWindow_csSource != null)
        //    //{
        //    //    MainWindow_csVis.Visibility = Visibility.Visible;
        //    //}

        //}

        //private void ImageVis_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    img1.Source = new BitmapImage(new Uri(book.MyImageSource1));
        //    ControlLibrary_StackPanelForImage.Children.Clear();
        //    ControlLibrary_StackPanelForImage.Children.Add(img1);
        //    ControlLibraryDocViewer.Visibility = Visibility.Collapsed;
        //    ControlLibrary_StackPanelForImage.Visibility = Visibility.Visible;

        //}

        //private void MainWindow_xamlVis_MouseUp(object sender, MouseButtonEventArgs e)
        //{
        //    XpsDocument doc = new XpsDocument(book.MainWindow_xamlSource, FileAccess.Read);

        //    ControlLibrary_StackPanelForImage.Visibility = Visibility.Collapsed;
        //    ControlLibraryDocViewer.Visibility = Visibility.Visible;

        //    ControlLibraryDocViewer.Document = doc.GetFixedDocumentSequence();
        //    doc.Close();

        //}

    }
}
