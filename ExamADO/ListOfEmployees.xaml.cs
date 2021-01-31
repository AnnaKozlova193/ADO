using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamADO
{
    /// <summary>
    /// Interaction logic for ListOfEmployess.xaml
    /// </summary>
    public partial class ListOfEmployess : Window
    {
        string name;


        public ListOfEmployess()
        {
            InitializeComponent();

           // AddDBtabl();

            // подкючение к базе
            string connectionString = @"Data Source=localhost\ANNAK;Initial Catalog=MyEmployees;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();
            string query = "SELECT * FROM Сотрудники;";
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            datagr.AutoGenerateColumns = true;
            datagr.ItemsSource = dt.DefaultView;
        }
       
        static void AddDBtabl() // заполнение
        {
            //вносим данные сотрудника в базу данных
            Сотрудники newEmpl = new Сотрудники();
            newEmpl.Id = 1;
            newEmpl.Фамилия = "Иванов";
            newEmpl.Имя = "Алексей";
            newEmpl.Отчество = "Петрович";
            newEmpl.Дата_рождения = DateTime.Parse("1965-10-24");
            newEmpl.Должность = "Завхоз";
            // сразу заносим данные в связанные таблицы
            newEmpl.Втемя_роботы_сотрудника = new List<Втемя_роботы_сотрудника>
            {
                new Втемя_роботы_сотрудника
                {
                    Id = 1,
                    id_Сотрудника = 1,
                    Начало_работы = DateTime.Now,
                    Окончание_работы = DateTime.Now

                }
            };
            newEmpl.Принятие_на_работу = new List<Принятие_на_работу>
            {
                new Принятие_на_работу
                {
                    Id =1,
                    Дата_принятия_на_работу =  DateTime.Parse("1997-03-15"),
                    id_Сотрудника = 1
                }
            };
            newEmpl.Увольнение = new List<Увольнение>
            {
                new Увольнение
                {
                    Id = 1,
                    Дата_увольнения = DateTime.Now,
                    id_Сотрудника = 1
                }
            };

            FileInfo fileInfo = new FileInfo("dog1.jpg");

            byte[] imageBytes = null;
            using (FileStream stream = fileInfo.Open(FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    imageBytes = reader.ReadBytes((int)fileInfo.Length);
                }
            }

            newEmpl.Фотогафии_Сотрудников = new List<Фотогафии_Сотрудников>
            {
                new Фотогафии_Сотрудников
                {
                    Id = 1,
                    id_Сотрудника = 1,
                    Фото = imageBytes

                }

            };

            // DbContext - позволяет извлекать и сохранять данные в моих классах
            // создаем DbContext объект
            //MyEmployeesEntities наследует DbContext
            using (var db_context = new MyEmployeesEntities())
            {
                //добавляем объект "сотрудник" в базу MyEmployees DBset
                db_context.Сотрудники.Add(newEmpl);
                //вызываем метод для сохранения сотрудника в базе данных
                db_context.SaveChanges();
            }
            //===================     2     =======================
            Сотрудники newEmpl2 = new Сотрудники();
            newEmpl2.Id = 2;
            newEmpl2.Фамилия = "Сидорова";
            newEmpl2.Имя = "Ирина";
            newEmpl2.Отчество = "Ивановна";
            newEmpl2.Дата_рождения = DateTime.Parse("1968-03-14");
            newEmpl2.Должность = "Бухгалтер";
            // сразу заносим данные в связанные таблицы
            newEmpl2.Втемя_роботы_сотрудника = new List<Втемя_роботы_сотрудника>
            {
                new Втемя_роботы_сотрудника
                {
                    Id = 2,
                    id_Сотрудника = 2,
                    Начало_работы = DateTime.Now,
                    Окончание_работы = DateTime.Now

                }
            };
            newEmpl2.Принятие_на_работу = new List<Принятие_на_работу>
            {
                new Принятие_на_работу
                {
                    Id =2,
                    Дата_принятия_на_работу = DateTime.Parse("2003-06-15"),
                    id_Сотрудника = 2
                }
            };
            newEmpl2.Увольнение = new List<Увольнение>
            {
                new Увольнение
                {
                    Id = 2,
                    Дата_увольнения = DateTime.Now,
                    id_Сотрудника = 2
                }
            };

            FileInfo fileInfo2 = new FileInfo("dog2.jpg");

            byte[] imageBytes2 = null;
            using (FileStream stream = fileInfo2.Open(FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    imageBytes2 = reader.ReadBytes((int)fileInfo2.Length);
                }
            }

            newEmpl2.Фотогафии_Сотрудников = new List<Фотогафии_Сотрудников>
            {
            new Фотогафии_Сотрудников
                {
                    Id = 2,
                    id_Сотрудника = 2,
                    Фото = imageBytes2

                }

            };

            using (var db_context2 = new MyEmployeesEntities())
            {
                db_context2.Сотрудники.Add(newEmpl2);

                db_context2.SaveChanges();
            }
            //===================     3     =======================
            Сотрудники newEmpl3 = new Сотрудники();
            newEmpl3.Id = 3;
            newEmpl3.Фамилия = "Кузнецов";
            newEmpl3.Имя = "Роман";
            newEmpl3.Отчество = "Анатольевич";
            newEmpl3.Дата_рождения = DateTime.Parse("1966-06-03");
            newEmpl3.Должность = "Сторож";

            // сразу заносим данные в связанные таблицы
            newEmpl3.Втемя_роботы_сотрудника = new List<Втемя_роботы_сотрудника>
            {
                new Втемя_роботы_сотрудника
                {
                    Id = 3,
                    id_Сотрудника = 3,
                    Начало_работы = DateTime.Now,
                    Окончание_работы = DateTime.Now

                }
            };
            newEmpl2.Принятие_на_работу = new List<Принятие_на_работу>
            {
                new Принятие_на_работу
                {
                    Id =3,
                    Дата_принятия_на_работу =  DateTime.Parse("1999-10-15"),
                    id_Сотрудника = 3
                }
            };
            newEmpl2.Увольнение = new List<Увольнение>
            {
                new Увольнение
                {
                    Id = 3,
                    Дата_увольнения =  DateTime.Parse("2010-10-24"),
                    id_Сотрудника = 3
                }
            };

            FileInfo fileInfo3 = new FileInfo("dog3.jpg");

            byte[] imageBytes3 = null;
            using (FileStream stream = fileInfo3.Open(FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    imageBytes3 = reader.ReadBytes((int)fileInfo3.Length);
                }
            }

            newEmpl2.Фотогафии_Сотрудников = new List<Фотогафии_Сотрудников>
            {
            new Фотогафии_Сотрудников
                {
                    Id = 3,
                    id_Сотрудника = 3,
                    Фото = imageBytes3

                }

            };
            using (var db_context3 = new MyEmployeesEntities())
            {
                db_context3.Сотрудники.Add(newEmpl3);

                db_context3.SaveChanges();
            }

        }
        // ввод номера сотрудника
        private void Id_empl_TextChanged(object sender, TextChangedEventArgs e)
        {
            //проверка на ввод только чисел

            if ((Char.IsDigit(id_empl.Text, 0)))
            {
                 name = id_empl.Text;// присвоить введенное значение 
               
            }
            else
            {
                MessageBox.Show("Введите число");
                
            }
            
        }

        // кнопка перехода на форму отображения данных о сотруднике
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow(name).ShowDialog();// вызываем окно ,передавая данные
           
        }
    }
}
