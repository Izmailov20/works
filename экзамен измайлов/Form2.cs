using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace экзамен_измайлов
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadData();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7QJGE9S\SQLEXPRESS;Initial Catalog=shop; Integrated Security=True;");

        private void LoadData() 
        {
            adapter = new SqlDataAdapter("SELECT * FROM Лист1$ ", con);
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet._Лист1_". При необходимости она может быть перемещена или удалена.
            this.лист1_TableAdapter.Fill(this.shopDataSet._Лист1_);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
                    break;

                case 1:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Действующая скидка] <=9";
                    break;

                case 2:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Действующая скидка] >=10 AND [Действующая скидка] <=14";
                    break;

                case 3:
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Действующая скидка] >=15";
                    
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PaintRows()
        {
            var c = System.Drawing.ColorTranslator.FromHtml("#7fff00");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (int.Parse(row.Cells[5].Value.ToString()) > 15)
                        row.DefaultCellStyle.BackColor = c;
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    // здесь можно отреагировать на неправильные данные, а можно ничего не делать
                }
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                    switch (comboBox2.SelectedIndex)
                    {
                        case 0:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\B320R5");
                            break;
                        case 1:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\D329H3.jpg");
                            break;
                        case 2:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\D572U8.jpg");
                            break;
                        case 3:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\F572H7.jpg");
                            break;
                        case 4:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\F635R4.jpg");
                            break;
                        case 5:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\G432E4.jpg");
                            break;
                        case 6:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\G783F5.jpg");
                            break;
                        case 7:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\H782T5.jpg");
                            break;
                        case 8:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\J384T6.jpg");
                            break;
                        case 9:
                            pictureBox1.Image = Image.FromFile(@"C:\Users\ПК-9\Desktop\Вариант 6\Импорт\Товар_import\А112Т4.jpg");
                            break;

                    }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            PaintRows();
        }
    }
    }

