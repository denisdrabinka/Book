using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Xps.Packaging;

namespace MyFirstProject2
{
    class ViewModel : INotifyPropertyChanged
    {
        Image img1 = new Image();
        Image img2 = new Image();
        MainWindow main = (MainWindow)Application.Current.MainWindow;
        Video video;


        Book book = new Book();

        private RelayCommand showTreeViewBook;
        public RelayCommand ShowTreeViewBook
        {
            get
            {
                return showTreeViewBook ??
                  (showTreeViewBook = new RelayCommand(obj =>
                  {
                      using (BooksContext db = new BooksContext())
                      {
                          main.ControlLibraryDocViewer.Visibility = Visibility.Collapsed;
                          main.ControlLibrary_StackPanelForImage.Visibility = Visibility.Collapsed;

                          string name = obj as string;
                          book = new Book();
                          var findbook = db.Books.Where(b => b.NameSource == name);
                          foreach (Book item in findbook)
                          {
                              book = item;
                          }
                          //TreeBook.Header = book.NameSource;
                          ShowBookTreeViewItems();
                          ShowImageMethod();
                      }
                  }));
            }
        }

        public void ShowBookTreeViewItems()
        {
            main.InfoVis.Visibility = Visibility.Collapsed;
            main.ImageVis.Visibility = Visibility.Collapsed;
            main.MainWindow_xamlVis.Visibility = Visibility.Collapsed;
            main.MainWindow_csVis.Visibility = Visibility.Collapsed;
            main.App_xamlVis.Visibility = Visibility.Collapsed;
            main.App_csVis.Visibility = Visibility.Collapsed;
            main.App_configVis.Visibility = Visibility.Collapsed;
            main.Class_1Vis.Visibility = Visibility.Collapsed;
            main.Class_2Vis.Visibility = Visibility.Collapsed;
            main.Class_3Vis.Visibility = Visibility.Collapsed;
            main.Class_4Vis.Visibility = Visibility.Collapsed;
            main.Class_5Vis.Visibility = Visibility.Collapsed;
            main.Class_6Vis.Visibility = Visibility.Collapsed;
            main.Class_7Vis.Visibility = Visibility.Collapsed;
            main.Class_8Vis.Visibility = Visibility.Collapsed;
            main.Class_9Vis.Visibility = Visibility.Collapsed;
            main.Class_10Vis.Visibility = Visibility.Collapsed;

            if (book.InfoSource != "")
            {
                main.InfoVis.Visibility = Visibility.Visible;
            }
            if (book.MyImageSource1 != "")
            {
                main.ImageVis.Visibility = Visibility.Visible;
            }
            if (book.MainWindow_xamlSource != "")
            {
                main.MainWindow_xamlVis.Visibility = Visibility.Visible;
            }
            if (book.MainWindow_csSource != "")
            {
                main.MainWindow_csVis.Visibility = Visibility.Visible;
            }
            if (book.App_xamlSource != "")
            {
                main.App_xamlVis.Visibility = Visibility.Visible;
            }
            if (book.App_xaml_csSource != "")
            {
                main.App_csVis.Visibility = Visibility.Visible;
            }
            if (book.App_configSource != "")
            {
                main.App_configVis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source1 != "")
            {
                main.Class_1Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source2 != "")
            {
                main.Class_2Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source3 != "")
            {
                main.Class_3Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source4 != "")
            {
                main.Class_4Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source5 != "")
            {
                main.Class_5Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source6 != "")
            {
                main.Class_6Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source7 != "")
            {
                main.Class_7Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source8 != "")
            {
                main.Class_8Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source9 != "")
            {
                main.Class_9Vis.Visibility = Visibility.Visible;
            }
            if (book.Class_Source10 != "")
            {
                main.Class_10Vis.Visibility = Visibility.Visible;
            }
        }

        public void ShowDocMethod(XpsDocument doc)
        {
            main.ControlLibraryDocViewer.Document = null;
            main.ControlLibrary_StackPanelForImage.Visibility = Visibility.Collapsed;
            main.ControlLibraryDocViewer.Visibility = Visibility.Visible;
            main.ControlLibraryDocViewer.Document = doc.GetFixedDocumentSequence();
            doc.Close();

        }

        public void ShowImageMethod()
        {
            if (string.IsNullOrEmpty(book.MyImageSource1))
            {
                return;
            }
            else
            {
                img1.Source = new BitmapImage(new Uri(book.MyImageSource1));
                main.ControlLibrary_StackPanelForImage.Children.Clear();
                main.ControlLibrary_StackPanelForImage.Children.Add(img1);
                if (string.IsNullOrEmpty(book.MyImageSource2))
                {
                    goto Metka;
                }
                else
                {
                    img2.Source = new BitmapImage(new Uri(book.MyImageSource2));
                    main.ControlLibrary_StackPanelForImage.Children.Add(img2);
                }
            }
            Metka:
            main.ControlLibraryDocViewer.Visibility = Visibility.Collapsed;
            main.ControlLibrary_StackPanelForImage.Visibility = Visibility.Visible;
        }


        RelayCommand showVideo;
        public RelayCommand ShowVideo
        {
            get
            {
                showVideo = new RelayCommand(VideoExecute, VideoCanExecute);
                return showVideo;
            }
        }

        public void VideoExecute(object obj)
        {
            string videoSource = book.VideoSource;
            double timeSource = Convert.ToDouble(book.VideoTime);
            video = new Video();
            video.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            video.media1.Source = new Uri(videoSource);
            video.Position = TimeSpan.FromMinutes(timeSource);
            video.Show();
        }

        public bool VideoCanExecute(object obj)
        {
            if (book.VideoSource == null)
                return false;
            return true;

        }


        private RelayCommand showImage;
        public RelayCommand ShowImage
        {
            get
            {
                return showImage ??
                  (showImage = new RelayCommand(obj =>
                  {
                      ShowImageMethod();
                  }));
            }
        }

        private RelayCommand showBook;
        public RelayCommand ShowBook
        {
            get
            {
                return showBook ??
                  (showBook = new RelayCommand(obj =>
                  {
                      string name = (string)obj;

                      switch (name)
                      {
                         
                          case "InfoVis":
                              {
                                  XpsDocument doc = new XpsDocument(book.InfoSource, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }break;
                          case "MainWindow_xamlVis":
                              {
                                  XpsDocument doc = new XpsDocument(book.MainWindow_xamlSource, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }break;
                          case "MainWindow_csVis":
                              {
                                  XpsDocument doc = new XpsDocument(book.MainWindow_csSource, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }break;
                          case "App_xamlVis":
                              {
                                  XpsDocument doc = new XpsDocument(book.App_xamlSource, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "App_csVis":
                              {
                                  XpsDocument doc = new XpsDocument(book.App_xaml_csSource, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_1Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source1, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;

                          case "Class_2Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source2, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }break;
                          case "Class_3Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source3, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_4Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source4, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_5Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source5, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_6Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source6, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_7Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source7, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_8Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source8, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_9Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source9, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                          case "Class_10Vis":
                              {
                                  XpsDocument doc = new XpsDocument(book.Class_Source10, FileAccess.Read);
                                  ShowDocMethod(doc);
                              }
                              break;
                      }

                  }));
            }
        }


        private RelayCommand updateDataBaseShow;
        public RelayCommand UpdateDataBaseShow
        {
            get
            {
                return updateDataBaseShow ??
                  (updateDataBaseShow = new RelayCommand(obj =>
                  {
                      AddBooks addBooks = new AddBooks();
                      addBooks.Show();
                  }));
            }
        }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

    }
}
