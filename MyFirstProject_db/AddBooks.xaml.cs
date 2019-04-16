using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Data.Entity;


namespace MyFirstProject2
{
    /// <summary>
    /// Interaction logic for AddBooks.xaml
    /// </summary>
    public partial class AddBooks : Window
    {
        ObservableCollection<Book> collection;

        public AddBooks()
        {
            InitializeComponent();
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            using (BooksContext db = new BooksContext())
            {
                collection = new ObservableCollection<Book>();
                db.Books.Load();
                collection = db.Books.Local;
                booksGrid.ItemsSource = collection;
            }
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            using (BooksContext db = new BooksContext())
            {
                WindowCRUD crud = new WindowCRUD();
                crud.ShowDialog();


                if (crud.DialogResult == false)
                    return;

                Book book = new Book();
                book.NameSource = crud.NameForm.Text;
                book.InfoSource = crud.InfoForm.Text;
                book.MyImageSource1 = crud.MyImage1Form.Text;
                book.MyImageSource2 = crud.MyImage2Form.Text;
                book.MainWindow_xamlSource = crud.MainWindow_xamlForm.Text;
                book.MainWindow_csSource = crud.MainWindow_csForm.Text;
                book.VideoSource = crud.VideoSourceForm.Text;
                if (crud.VideoTimeForm.Text != "")
                {
                    var time2 = Convert.ToDouble(crud.VideoTimeForm.Text.Replace('.', ','));
                    book.VideoTime = time2;
                }
                else
                {
                    book.VideoTime = 0;
                }
                book.Class_Source1 = crud.Class_1Form.Text;
                book.Class_Source2 = crud.Class_2Form.Text;
                book.Class_Source3 = crud.Class_3Form.Text;
                book.Class_Source4 = crud.Class_4Form.Text;
                book.Class_Source5 = crud.Class_5Form.Text;
                book.Class_Source6 = crud.Class_6Form.Text;
                book.Class_Source7 = crud.Class_7Form.Text;
                book.Class_Source8 = crud.Class_8Form.Text;
                book.Class_Source9 = crud.Class_9Form.Text;
                book.Class_Source10 = crud.Class_10Form.Text;
                book.App_configSource = crud.App_configForm.Text;
                book.App_xamlSource = crud.App_xamlForm.Text;
                book.App_xaml_csSource = crud.App_xaml_csForm.Text;

                db.Books.Add(book);
                db.SaveChanges();
                MessageBox.Show("Объект добавлен");

            }
        }

        private void UpDate_Click(object sender, RoutedEventArgs e)
        {
            using (BooksContext db = new BooksContext())
            {
                if (booksGrid.SelectedItem == null)
                    return;
                Book book = new Book();
                book = booksGrid.SelectedItem as Book;
                int id = book.Id;
                book = db.Books.Find(id);

                WindowCRUD crud = new WindowCRUD();

                crud.NameForm.Text = book.NameSource;
                crud.InfoForm.Text = book.InfoSource;
                crud.MyImage1Form.Text = book.MyImageSource1;
                crud.MyImage2Form.Text = book.MyImageSource2;
                crud.MainWindow_xamlForm.Text = book.MainWindow_xamlSource;
                crud.MainWindow_csForm.Text = book.MainWindow_csSource;
                crud.VideoSourceForm.Text = book.VideoSource;

                crud.VideoTimeForm.Text = Convert.ToString(book.VideoTime);

                crud.Class_1Form.Text = book.Class_Source1;
                crud.Class_2Form.Text = book.Class_Source2;
                crud.Class_3Form.Text = book.Class_Source3;
                crud.Class_4Form.Text = book.Class_Source4;
                crud.Class_5Form.Text = book.Class_Source5;
                crud.Class_6Form.Text = book.Class_Source6;
                crud.Class_7Form.Text = book.Class_Source7;
                crud.Class_8Form.Text = book.Class_Source8;
                crud.Class_9Form.Text = book.Class_Source9;
                crud.Class_10Form.Text = book.Class_Source10;
                crud.App_configForm.Text = book.App_configSource;
                crud.App_xamlForm.Text = book.App_xamlSource;
                crud.App_xaml_csForm.Text = book.App_xaml_csSource;

                crud.ShowDialog();
                if (crud.DialogResult == false)
                    return;

                book.NameSource = crud.NameForm.Text;
                book.InfoSource = crud.InfoForm.Text;
                book.MyImageSource1 = crud.MyImage1Form.Text;
                book.MyImageSource2 = crud.MyImage2Form.Text;
                book.MainWindow_xamlSource = crud.MainWindow_xamlForm.Text;
                book.MainWindow_csSource = crud.MainWindow_csForm.Text;
                book.VideoSource = crud.VideoSourceForm.Text;
                if (crud.VideoTimeForm.Text != "")
                {
                    var time2 = Convert.ToDouble(crud.VideoTimeForm.Text.Replace('.', ','));
                    book.VideoTime = time2;
                }
                else
                {
                    book.VideoTime = 0;
                }
                book.Class_Source1 = crud.Class_1Form.Text;
                book.Class_Source2 = crud.Class_2Form.Text;
                book.Class_Source3 = crud.Class_3Form.Text;
                book.Class_Source4 = crud.Class_4Form.Text;
                book.Class_Source5 = crud.Class_5Form.Text;
                book.Class_Source6 = crud.Class_6Form.Text;
                book.Class_Source7 = crud.Class_7Form.Text;
                book.Class_Source8 = crud.Class_8Form.Text;
                book.Class_Source9 = crud.Class_9Form.Text;
                book.Class_Source10 = crud.Class_10Form.Text;
                book.App_configSource = crud.App_configForm.Text;
                book.App_xamlSource = crud.App_xamlForm.Text;
                book.App_xaml_csSource = crud.App_xaml_csForm.Text;

                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Объект обновлен");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            using (BooksContext db = new BooksContext())
            {
                if (booksGrid.SelectedItem == null)
                    return;
                Book book = new Book();
                book = booksGrid.SelectedItem as Book;
                int id = book.Id;
                book = db.Books.Find(id);

                db.Books.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Объект удален");
            }

        }

    }
}
