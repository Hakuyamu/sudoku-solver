using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuSolver
{
    public partial class FSudokuSolver : Form
    {
        private IDictionary<Field, int> valueMap = new Dictionary<Field, int>();
        private IDictionary<TextBox, Field> allocatedFieldMap = new Dictionary<TextBox, Field>();

        public FSudokuSolver()
        {
            InitializeComponent();
            for (int i = 1; i <= 9; i++) // i = group
            {
                int rowStart = (((i - 1) / 3) * 3 + 1);
                int rowEnd = rowStart + 2;
                for (int j = rowStart; j <= rowEnd; j++) // j = row
                {
                    int columnStart = (((i - 1) % 3) * 3 + 1);
                    int columnEnd = columnStart + 2;
                    for (int k = columnStart; k <= columnEnd; k++) // k = column
                    {
                        Field field = new Field(i, j, k);
                        valueMap.Add(field, 0);
                        int x = ((i - 1) % 3) * 140 + (k % 3) * 40;
                        int y = ((i - 1) / 3) * 140 + (j % 3) * 40;
                        //Console.Out.WriteLine("Group: " + i + ", Row: " + j + ", Column: " + k + ", X: " + x + ", Y: " + y);
                        TextBox tb = new TextBox
                        {
                            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0),
                            Location = new Point(x, y),
                            Name = "tb" + i + j + k,
                            Size = new Size(31, 31),
                            TabIndex = 82,
                            TextAlign = HorizontalAlignment.Center
                        };
                        this.Controls.Add(tb);
                        allocatedFieldMap[tb] = field;
                    }
                }
            }
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.TextChanged += Tb_TextChanged;
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            EvalField(sender as TextBox, allocatedFieldMap[sender as TextBox]);
        }

        private void EvalField(TextBox tb, Field field)
        {
            if (tb.Text.Length > 1)
            {
                tb.Text = tb.Text.Substring(0, 1);
            }
            int value;
            if (tb.Text.Length < 1)
            {
                value = 0;
            }
            else
            {
                value = int.Parse(tb.Text);
            }
            valueMap[field] = value;
        }

        private bool Solve()
        {
            int count = 0;
            IDictionary<Field, int> oldMap = new Dictionary<Field, int>();
            foreach(var field in valueMap)
            {
                oldMap.Add(field.Key, field.Value);
            }

            foreach (var field in oldMap)
            {
                // skip this field if already solved
                if (field.Value != 0)
                {
                    continue;
                }

                List<int> possible = new List<int>();
                for (int i = 1; i <= 9; i++)
                {
                    possible.Add(i);
                }
                foreach (var compare in valueMap)
                {
                    if (compare.Value == 0)
                    {
                        continue;
                    }
                    // elimination
                    if (
                        compare.Key.GetGroup() == field.Key.GetGroup() ||
                        compare.Key.GetRow() == field.Key.GetRow() ||
                        compare.Key.GetColumn() == field.Key.GetColumn()
                        )
                    {
                        possible.Remove(compare.Value);
                    }
                }

                if (possible.Count != 1)
                {
                    continue;
                }

                valueMap[field.Key] = possible.First();
                count++;
            }

            if (count == 0)
            {
                return false;
            }
            return true;
        }

        private void bSolve_Click(object sender, EventArgs e)
        {
            if (Solve() == false)
            {
                MessageBox.Show("The given Sudoku pattern is unsolveable!");
            }
            foreach(var allocation in allocatedFieldMap)
            {
                int value = valueMap[allocation.Value];
                if (value != 0)
                {
                    allocation.Key.Text = value.ToString();
                }
            }
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string[] imported = tbImport.Text.Split();
            if (imported.Length != 81)
            {
                return;
            }

        }

        private void bReset_Click(object sender, EventArgs e)
        {
            foreach(var tb in this.Controls.OfType<TextBox>())
            {
                if (allocatedFieldMap.ContainsKey(tb))
                {
                    tb.Text = "";
                    EvalField(tb, allocatedFieldMap[tb]);
                }
            }
        }
    }
}
