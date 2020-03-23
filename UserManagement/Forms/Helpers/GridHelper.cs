using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement.Forms.Helpers
{
    class GridHelper
    {
        /// <summary>
        /// Initialize grid with empty model, hide the Primary key column and adds Edit and Delete button
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataGridView1"></param>
        public static void InitializeGrid<T>(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = new List<T>();
            dataGridView1.Columns["PrimaryKey"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Text = Messages.EditView,
                UseColumnTextForButtonValue = true
            };

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Text = Messages.Delete,
                UseColumnTextForButtonValue = true
            };

            dataGridView1.Columns.Add(btnEdit);
            dataGridView1.Columns.Add(btnDelete);
        }
    }
}
