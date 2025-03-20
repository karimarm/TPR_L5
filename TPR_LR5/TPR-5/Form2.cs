using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static OfficeOpenXml.ExcelErrorValue;

namespace LR5
{
    public partial class Form2 : Form
    {
        DataGridView dgwFunc;
        DataGridView dgwСrit;

        DataGridView[] dgwStep1_arr;
        DataGridView[] dgwStep2_arr;
        DataGridView dgwStep3;

        int critCnt;
        int alternativeCnt;

        public Form2(DataGridView dgwСrit, DataGridView dgwFunc)
        {
            this.dgwСrit = dgwСrit;
            this.dgwFunc = dgwFunc;

            alternativeCnt = dgwСrit.Rows.Count;
            critCnt = dgwСrit.Columns.Count;

            dgwStep1_arr = new DataGridView[critCnt];
            dgwStep2_arr = new DataGridView[critCnt];

            InitializeComponent();

            Step1();
            Step2();
            Step3();
            Step4();
        }

        // Шаг #1
        private void Step1()
        {
            tabControl1.TabPages.Clear();

            for (int i = 0; i < critCnt; i++)
            {
                // Создание новой страницы
                TabPage tabP = new TabPage();
                tabP.Text = Convert.ToString(i + 1) + " критерий";
                tabControl1.Controls.Add(tabP);

                // Создание новой таблицы
                DataGridView dgwStep1 = createDataGridView();
                tabP.Controls.Add(dgwStep1);
                dgwStep1_arr[i] = dgwStep1;

                tabControl1.Refresh();

                // Создание строк и колонок таблицы
                for (int j = 0; j < alternativeCnt; j++)
                {
                    var column = createDataGridViewColumn("a " + Convert.ToString(j + 1));
                    dgwStep1.Columns.Add(column);

                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "a" + Convert.ToString(j + 1);
                    dgwStep1.Rows.Add(row);
                }

                // Расчет элементов таблицы
                for (int row = 0; row < dgwStep1.Rows.Count; row++)
                    for (int col = 0; col < dgwStep1.Columns.Count; col++)
                        dgwStep1.Rows[row].Cells[col].Value = Convert.ToInt32(dgwСrit.Rows[row].Cells[i].Value) - Convert.ToInt32(dgwСrit.Rows[col].Cells[i].Value);
            }
        }

        // Шаг #2
        private void Step2()
        {
            tabControl2.TabPages.Clear();

            for (int i = 0; i < critCnt; i++)
            {
                // Создание новой страницы
                TabPage tabP = new TabPage();
                tabP.Text = "P" + Convert.ToString(i + 1);
                tabControl2.Controls.Add(tabP);

                // Создание новой таблицы
                DataGridView dgwStep2 = createDataGridView();
                tabP.Controls.Add(dgwStep2);
                dgwStep2_arr[i] = dgwStep2;

                tabControl2.Refresh();

                // Создание строк и колонок таблицы
                for (int j = 0; j < alternativeCnt; j++)
                {
                    var column = createDataGridViewColumn("a " + Convert.ToString(i + 1));
                    dgwStep2.Columns.Add(column);

                    DataGridViewRow row = new DataGridViewRow();
                    row.HeaderCell.Value = "a" + Convert.ToString(j + 1);
                    dgwStep2.Rows.Add(row);
                }

                // Расчет элементов таблицы
                for (int row = 0; row < dgwStep2.Rows.Count; row++)
                    for (int col = 0; col < dgwStep2.Columns.Count; col++)
                        dgwStep2.Rows[row].Cells[col].Value = Func(i, Convert.ToInt32(dgwStep1_arr[i].Rows[row].Cells[col].Value));
            }
        }

        // Шаг #3
        private void Step3()
        {
            tabControl3.TabPages.Clear();

            // Создание новой страницы
            TabPage tabP = new TabPage();
            tabP.Text = "Индексы предпочтения для каждой альтернативы";
            tabControl3.Controls.Add(tabP);

            // Создание новой таблицы
            dgwStep3 = createDataGridView();
            tabP.Controls.Add(dgwStep3);

            tabControl3.Refresh();

            // Создание таблицы для шага #3
            for (int i = 0; i < alternativeCnt + 1; i++)
            {
                string columnHeaderText = "";
                if (i == alternativeCnt)
                    columnHeaderText = "Ф +";
                else
                    columnHeaderText = "a" + Convert.ToString(i + 1);

                var column = createDataGridViewColumn(columnHeaderText);
                dgwStep3.Columns.Add(column);

                DataGridViewRow row = new DataGridViewRow();
                if (i == alternativeCnt)
                    row.HeaderCell.Value = "Ф -";
                else
                    row.HeaderCell.Value = "a" + Convert.ToString(i + 1);
                dgwStep3.Rows.Add(row);
            }

            // Вычисление индексов предпочтения 
            for (int row = 0; row < alternativeCnt; row++)
                for (int col = 0; col < alternativeCnt; col++)
                {
                    double Value = 0;
                    for (int critIndex = 0; critIndex < critCnt; critIndex++)
                        Value += Convert.ToDouble(dgwStep2_arr[critIndex].Rows[row].Cells[col].Value) * Convert.ToDouble(dgwFunc.Rows[critIndex].Cells[3].Value);

                    dgwStep3.Rows[row].Cells[col].Value = Math.Round(Value, 3);
                }

            // Вычисление положительных оценок
            for (int row = 0; row < alternativeCnt; row++)
            {
                double Value = 0;
                for (int col = 0; col < alternativeCnt; col++)
                    Value += Convert.ToDouble(dgwStep3.Rows[row].Cells[col].Value);

                dgwStep3.Rows[row].Cells[alternativeCnt].Value = Math.Round(Value, 3);
            }

            // Вычисление отрицательных оценок
            for (int col = 0; col < alternativeCnt; col++)
            {
                double Value = 0;
                for (int row = 0; row < alternativeCnt; row++)
                    Value += Convert.ToDouble(dgwStep3.Rows[row].Cells[col].Value);

                dgwStep3.Rows[alternativeCnt].Cells[col].Value = Math.Round(Value, 3);
            }
        }

        // Шаг #4
        private void Step4()
        {
            double[] marksArr = new double[alternativeCnt];
            string[] alternArr = new string[alternativeCnt];

            // Вычисление чистых оценок
            for (int i = 0; i < alternativeCnt; i++)
            {
                double value = Convert.ToDouble(dgwStep3.Rows[i].Cells[alternativeCnt].Value) - Convert.ToDouble(dgwStep3.Rows[alternativeCnt].Cells[i].Value);

                marksArr[i] = value;
                alternArr[i] = "a" + Convert.ToString(i + 1);
            }

            // Выводи чистых оценок
            lbFour.Items.Clear();
            for (int i = 0; i < alternativeCnt; i++)
            {
                lbFour.Items.Add("Φ(a" + Convert.ToString(i + 1) + ") = Φ+(a" + Convert.ToString(i + 1) + ") - Φ-(a" + Convert.ToString(i + 1) + ") = " + Math.Round(marksArr[i], 3));
            }

            // Сортировка альтернатив
            for (int i = 0; i < alternativeCnt - 1; i++)
            {
                for (int j = i; j < alternativeCnt; j++)
                {
                    if (marksArr[i] < marksArr[j])
                    {
                        (marksArr[i], marksArr[j]) = (marksArr[j], marksArr[i]);
                        (alternArr[i], alternArr[j]) = (alternArr[j], alternArr[i]);
                    }
                }
            }

            lbResult.Items.Clear();
            for (int i = 0; i < alternativeCnt; i++)
            {
                lbResult.Items.Add(alternArr[i]);
            }
        }

        // Получение значения функции
        private double Func(int critIndex, double d)
        {
            string func = dgwFunc.Rows[critIndex].Cells[0].Value.ToString();
            double q = Convert.ToDouble(dgwFunc.Rows[critIndex].Cells[1].Value);
            double s = Convert.ToDouble(dgwFunc.Rows[critIndex].Cells[2].Value);

            if (func == "Обычная функция") // без q и s
            {
                if (d <= 0)
                    return 0;
                else
                    return 1;
            }
            if (func == "U-образная функция") //без s
            {
                if (d <= q)
                    return 0;
                else
                    return 1;
            }
            if (func == "V-образная функция") // без q
            {
                if (d <= 0)
                    return 0;

                if (d > 0 && d <= s)
                    return d / s;

                if (d > s)
                    return 1;
            }
            if (func == "Уровневая функция")
            {
                if (d <= q)
                    return 0;

                if (d > q && d <= s)
                    return 0.5;

                if (d > s)
                    return 1;
            }
            if (func == "V-образная функция с порогами безразличия")
            {
                if (d <= q)
                    return 0;

                if (d > q && d <= s)
                    return (d - q) / (s - q);

                if (d > s)
                    return 1;
            }
            return 0;
        }


        // Создание таблицы
        private DataGridView createDataGridView()
        {
            DataGridView dgwStep1 = new DataGridView();

            dgwStep1.Dock = DockStyle.Fill;
            dgwStep1.AllowUserToAddRows = false;
            dgwStep1.AllowUserToDeleteRows = false;
            dgwStep1.AllowUserToResizeColumns = false;
            dgwStep1.AllowUserToResizeRows = false;
            dgwStep1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwStep1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwStep1.BackgroundColor = System.Drawing.Color.White;

            return dgwStep1;
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
