using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Media3D;
using System.Windows;
using System.Windows.Documents;
using System.Security.Cryptography;

namespace Laba_21
{
    public static class DBManager
    {
        public static Student[][] GetStudents()
        {
            const string con = @"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=laba_21;User ID=wsr-3;Password=#774566cC2260$;Persist Security Info=True";

            List<Student> list = new List<Student>();

            Student[][] result = null;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string commandStudents = "SELECT * FROM dbo.Студенты";
                SqlDataAdapter StudentsAdapter = new SqlDataAdapter(commandStudents, con);
                DataTable StudentsTable = new DataTable();

                StudentsAdapter.Fill(StudentsTable);;

                try
                {
                    foreach (DataRow row in StudentsTable.Rows)
                    {
                        int id = Convert.ToInt32(row["Код"].ToString());
                        string fullname = row["ФИО"].ToString();
                        string address = row["Адрес"].ToString();
                        string phone = row["Телефон"].ToString();
                        int groupID = Convert.ToInt32(row["ID_GR"].ToString());

                        list.Add(new Student(id, fullname, address, phone, groupID));

                    }

                    int pages = (int)Math.Ceiling((double)list.Count / 3);

                    List<Student> temp = new List<Student>();
                    Student[][] arr = new Student[pages][]; // указывается длина двумерного массива, в зависимости от количества страниц (подмассивов)

                    int lastIndex = 0;


                    for (int i = 0; i < pages; i++)
                    {
                        for (int j = lastIndex; j < lastIndex + 3 && j < list.Count; j++) // если j меньше суммы последнего индекса и лимита и меньше длины списка-параметра
                        {
                            temp.Add(list[j]); // во временный список добавляется ограниченное число элементов
                        }
                        arr[i] = temp.ToArray(); // список конвертируется в массив, который добавляется в многомерный массив
                        temp.Clear(); //
                        lastIndex += 3; // индекс увеличивается на один лимит
                    }


                    result = arr;
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            return result;
        }

        public static Group[][] GetGroups()
        {
            const string con = @"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=laba_21;User ID=wsr-3;Password=#774566cC2260$;Persist Security Info=True";

            List<Group> list = new List<Group>();

            Group[][] result = null;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                string commandGroup = "SELECT * FROM dbo.Группа";
                SqlDataAdapter GroupAdapter = new SqlDataAdapter(commandGroup, con);
                DataTable GroupTable = new DataTable();

                GroupAdapter.Fill(GroupTable);
                try
                {
                    foreach (DataRow row in GroupTable.Rows)
                    {
                        int id = Convert.ToInt32(row["Код"].ToString());
                        string groupName = row["Название группы"].ToString();
                        string headman = row["Фамилия старосты"].ToString();
                        int quantity = Convert.ToInt32(row["Количество"].ToString());
                        int facultyID = Convert.ToInt32(row["ФакультетID"].ToString());

                        list.Add(new Group(id, groupName, headman, quantity, facultyID));

                    }


                    int pages = (int)Math.Ceiling((double)list.Count / 3);

                    List<Group> temp = new List<Group>();
                    Group[][] arr = new Group[pages][]; // указывается длина двумерного массива, в зависимости от количества страниц (подмассивов)

                    int lastIndex = 0;


                    for (int i = 0; i < pages; i++)
                    {
                        for (int j = lastIndex; j < lastIndex + 3 && j < list.Count; j++) // если j меньше суммы последнего индекса и лимита и меньше длины списка-параметра
                        {
                            temp.Add(list[j]); // во временный список добавляется ограниченное число элементов
                        }
                        arr[i] = temp.ToArray(); // список конвертируется в массив, который добавляется в многомерный массив
                        temp.Clear(); //
                        lastIndex += 3; // индекс увеличивается на один лимит
                    }


                    result = arr;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            return result;

        }

        public static Faculty[][] GetFaculties()
        {
            const string con = @"Data Source=192.168.10.151\SQLEXPRESS;Initial Catalog=laba_21;User ID=wsr-3;Password=#774566cC2260$;Persist Security Info=True";

            List<Faculty> list = new List<Faculty>();

            Faculty[][] result = null;

            using (SqlConnection connection = new SqlConnection(con))
            {
                string commandFaculty = "SELECT * FROM dbo.Факультет";
                SqlDataAdapter FacultyAdapter = new SqlDataAdapter(commandFaculty, con);
                DataTable FacultyTable = new DataTable();

                FacultyAdapter.Fill(FacultyTable);

                try
                {
                    foreach (DataRow row in FacultyTable.Rows)
                    {
                        int id = Convert.ToInt32(row["Код"].ToString());
                        string facultyName = row["Факультет"].ToString();
                        int course = Convert.ToInt32(row["Курс"].ToString());
                        int quantity = Convert.ToInt32(row["Количество групп"].ToString());

                        list.Add(new Faculty(id, facultyName, course, quantity));

                    }

                    int pages = (int)Math.Ceiling((double)list.Count / 3);

                    List<Faculty> temp = new List<Faculty>();
                    Faculty[][] arr = new Faculty[pages][]; // указывается длина двумерного массива, в зависимости от количества страниц (подмассивов)

                    int lastIndex = 0;


                    for (int i = 0; i < pages; i++)
                    {
                        for (int j = lastIndex; j < lastIndex + 3 && j < list.Count; j++) // если j меньше суммы последнего индекса и лимита и меньше длины списка-параметра
                        {
                            temp.Add(list[j]); // во временный список добавляется ограниченное число элементов
                        }
                        arr[i] = temp.ToArray(); // список конвертируется в массив, который добавляется в многомерный массив
                        temp.Clear(); //
                        lastIndex += 3; // индекс увеличивается на один лимит
                    }


                    result = arr;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            return result;
        }


    }
}
