using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR5
{
    public partial class Form1 : Form
    {
        public static int alternativeCnt; //Кол-во альтернатив
        public static int critCnt; //Кол-во критериев

        public Form1()
        {
            InitializeComponent();
            onCreateTable(null, null);
        }


        // Сохранение в файл
        private void Save_Click(object sender, EventArgs e)
        {
            // Получение пути сохранения
            saveFileDialog1.Filter = "Файл Excel | *.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                excelPackage.Workbook.Properties.Title = "Документ";

                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Лист 1");

                int curRow = 1; // Индекс текущей строки

                // Запись альтернатив и критериев
                worksheet.Cells[curRow, 1].Value = "Кол-во альтернатив:";
                worksheet.Cells[curRow++, 2].Value = Convert.ToInt32(alternativeCnt);
                worksheet.Cells[curRow, 1].Value = "Кол-во критериев:";
                worksheet.Cells[curRow, 2].Value = Convert.ToInt32(critCnt);
                curRow += 2;

                // Запись таблицы критериев
                worksheet.Cells[curRow++, 1].Value = "Таблица критериев:";
                for (int row = 0; row < dgwСrit.Rows.Count; row++)
                {
                    for (int col = 0; col < dgwСrit.Columns.Count; col++)
                        worksheet.Cells[curRow, col + 1].Value = Convert.ToInt32(dgwСrit.Rows[row].Cells[col].Value);
                    curRow++;
                }
                curRow++;

                // Запись таблицы функций
                worksheet.Cells[curRow++, 1].Value = "Таблица функций: ";
                for (int row = 0; row < dgwFunc.Rows.Count; row++)
                {
                    for (int col = 0; col < dgwFunc.Columns.Count; col++)
                        worksheet.Cells[curRow, col + 1].Value = dgwFunc.Rows[row].Cells[col].Value;
                    curRow++;
                }

                // Попытка записи файла
                try
                {
                    FileInfo fi = new FileInfo(saveFileDialog1.FileName);
                    excelPackage.SaveAs(fi);
                }
                catch
                {
                    MessageBox.Show(
                        "Открыт Excel файл",
                        "Ошибка сохранения файла!"
                    );
                    return;
                }
            }
        }


        // Загрузка из файла
        private void Load_Click(object sender, EventArgs e)
        {
            // Получение пути файла
            openFileDialog1.FileName = null;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            FileInfo File = new FileInfo(openFileDialog1.FileName);

            using (ExcelPackage excelPackage = new ExcelPackage(File))
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[0];

                dgwСrit.Columns.Clear();
                dgwСrit.Rows.Clear();

                dgwFunc.Rows.Clear();

                int curRow = 1; // Индекс текущей строки

                // Загрузка количества альтернатив и критериев
                alternativeCnt = Convert.ToInt32(worksheet.Cells[curRow++, 2].Value);
                critCnt = Convert.ToInt32(worksheet.Cells[curRow, 2].Value);

                nudAlternative.Value = alternativeCnt;
                nudCrit.Value = critCnt;

                curRow += 3;

                // Загрузка таблицы критериев
                for (int i = 0; i < critCnt; i++)
                {
                    var column = createDataGridViewColumn(Convert.ToString(i + 1) + " критерий");
                    dgwСrit.Columns.Add(column);
                }

                for (int i = 0; i < alternativeCnt; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "a" + Convert.ToString(i + 1);
                    dgwСrit.Rows.Add(row);

                    for (int j = 0; j < critCnt; j++)
                    {
                        var value = Convert.ToInt32(worksheet.Cells[curRow, j + 1].Value);
                        dgwСrit.Rows[i].Cells[j].Value = value;
                    }

                    curRow++;
                }
                curRow += 2;

                // Загрузка таблицы функций
                for (int i = 0; i < critCnt; i++)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = Convert.ToString(i + 1) + " критерий";
                    dgwFunc.Rows.Add(row);

                    for (int j = 0; j < 4; j++)
                    {
                        var value = worksheet.Cells[curRow, j + 1].Value;
                        dgwFunc.Rows[i].Cells[j].Value = value;
                    }

                    curRow++;
                }

                excelPackage.Save();
            }
        }


        // Заполнение списка выбора критериев
        private void CreateCriterias()
        {
            cbCriteria.Items.Clear();
            var list = new List<string>();
            for (int i = 0; i < critCnt; i++)
            {
                list.Add(Convert.ToString(i + 1) + " критерий");
            }
            cbCriteria.Items.AddRange(list.ToArray());
        }


        // Определение параметров критерия
        private void btnSetCrit_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgwFunc;
            int critIndex = cbCriteria.SelectedIndex;

            dgv[0, critIndex].Value = cbFunction.SelectedItem;
            dgv[1, critIndex].Value = (nudQ.Visible ? nudQ.Value : 0);
            dgv[2, critIndex].Value = (nudS.Visible ? nudS.Value : 0);
            dgv[3, critIndex].Value = nudWeight.Value;
        }


        // Открытие формы расчета шагов
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sumCrit = 0;
            for (int row = 0; row < dgwFunc.Rows.Count; row++)
                for (int col = 0; col < dgwFunc.Columns.Count; col++)
                {
                    if (dgwFunc.Rows[row].Cells[col].Value == null)
                    {
                        MessageBox.Show("Не все критерии настроены", "Ошибка");
                        return;
                    }

                    if (col == 3)
                    {
                        sumCrit += Convert.ToDouble(dgwFunc.Rows[row].Cells[col].Value);
                    }
                }

            if (sumCrit != 1)
            {
                MessageBox.Show("Сумма весов критериев отлична от 1!", "Ошибка");
                return;
            }

            Form2 f2 = new Form2(dgwСrit, dgwFunc);
            f2.ShowDialog();
        }


        // Формирование таблицы
        private void onCreateTable(object sender, EventArgs e)
        {
            // Очистка строк и колонок таблицы
            dgwСrit.Columns.Clear();
            dgwСrit.Rows.Clear();

            // Задание количества альтернатив и критериев
            alternativeCnt = (int)nudAlternative.Value;
            critCnt = (int)nudCrit.Value;

            // Создание колонок таблицы
            for (int i = 1; i <= critCnt; i++)
            {
                var column = createDataGridViewColumn(Convert.ToString(i) + " критерий");
                dgwСrit.Columns.Add(column); // Добавление колонки
            }

            // Создание строк таблицы
            for (int i = 0; i < alternativeCnt; i++)
            {
                DataGridViewRow row = new DataGridViewRow();  // Создание новой строки
                row.HeaderCell.Value = "a" + Convert.ToString(i + 1); // Заголовок строки

                dgwСrit.Rows.Add(row); // Добавление строки
            }

            // Заполнение таблицы нулями
            for (int row = 0; row < alternativeCnt; row++)
                for (int col = 0; col < critCnt; col++)
                    dgwСrit.Rows[row].Cells[col].Value = 0;

            CreateCriterias();

            cbCriteria.SelectedIndex = 0;
            cbFunction.SelectedIndex = 0;
            //cbType.SelectedIndex = 0;

            // Таблица критериев
            CreateFuncTable();
        }


        // Заполнение таблицы функций
        void CreateFuncTable()
        {
            dgwFunc.Rows.Clear(); // Очистка строк таблицы

            // Создание строк таблицы
            for (int i = 0; i < critCnt; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToString(i + 1) + " критерий";
                dgwFunc.Rows.Add(row);
            }
        }


        // Измение видимости параметров Q и S
        private void cbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            var q = false;
            var s = false;

            switch (cbFunction.SelectedIndex)
            {
                case 1: // U-образная функция
                    q = true;
                    break;
                case 2: // V-образная функция
                    s = true;
                    break;
                case 3:  // Уровневая функция
                    q = true;
                    s = true;
                    break;
                case 4: // V-образная функция с порогами безразличия
                    q = true;
                    s = true;
                    break;
            }

            // Измение видимости параметров Q и S
            lblQ.Visible = q;
            nudQ.Visible = q;

            lblS.Visible = s;
            nudS.Visible = s;
        }

        // Создание колонки таблицы
        private DataGridViewColumn createDataGridViewColumn(string headerText = "")
        {
            var column = new DataGridViewColumn();

            column.HeaderText = headerText;
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.CellTemplate = new DataGridViewTextBoxCell();

            return column;
        }
    }
}
