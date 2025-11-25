using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpulenciaLinearBinary
{
    public partial class LinearBinarySearch : Form
    {
        int[] arr;
        Label[] linearLabels;
        Label[] binaryLabels;

        int target;

        // For Binary Search
        int left, right, mid, stepBinary;
        // For Linear Search
        int indexLinear, stepLinear;

        public LinearBinarySearch()
        {
            InitializeComponent();
        }

        private void LinearBinarySearch_Load(object sender, EventArgs e)
        {

        }
        
        
        void CreateArrayVisualsLinear()
        {
            panelLinear.Controls.Clear();
            linearLabels = new Label[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                linearLabels[i] = new Label();
                linearLabels[i].Text = arr[i].ToString();
                linearLabels[i].Width = 45;
                linearLabels[i].Height = 45;
                linearLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                linearLabels[i].BorderStyle = BorderStyle.FixedSingle;
                linearLabels[i].BackColor = Color.DodgerBlue;
                linearLabels[i].Font = new Font("Arial", 10, FontStyle.Bold);
                panelLinear.Controls.Add(linearLabels[i]);
            }
        }

        private void panelLinear_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBinary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerLinear_Tick(object sender, EventArgs e)
        {
            if (indexLinear < arr.Length)
            {
                foreach (var label in linearLabels)
                    label.BackColor = Color.LightBlue;

                linearLabels[indexLinear].BackColor = Color.RoyalBlue;
                lblLinearStatus.Text = $"Step {stepLinear}: Checking index {indexLinear} (Value={arr[indexLinear]})";

                if (arr[indexLinear] == target)
                {
                    linearLabels[indexLinear].BackColor = Color.LightGreen;
                    lblLinearStatus.Text = $"✅ Found {target} at index {indexLinear}";
                    timerLinear.Stop();
                    return;
                }

                indexLinear++;
                stepLinear++;
            }
            else
            {
                lblLinearStatus.Text = "❌ Target not found.";
                timerLinear.Stop();
            }
        }


        private void timerBinary_Tick(object sender, EventArgs e)
        {
            if (left <= right)
            {
                mid = (left + right) / 2;

                foreach (var label in binaryLabels)
                    label.BackColor = Color.LightBlue;

                binaryLabels[mid].BackColor = Color.RoyalBlue;
                lblBinaryStatus.Text = $"Step {stepBinary}: Left={left}, Right={right}, Mid={mid} (Value={arr[mid]})";

                if (arr[mid] == target)
                {
                    binaryLabels[mid].BackColor = Color.LightGreen;
                    lblBinaryStatus.Text = $"✅ Found {target} at index {mid}";
                    timerBinary.Stop();
                    return;
                }
                else if (arr[mid] < target)
                {
                    for (int i = left; i <= mid; i++)
                        binaryLabels[i].BackColor = Color.MidnightBlue;
                    left = mid + 1;
                }
                else
                {
                    for (int i = mid; i <= right; i++)
                        binaryLabels[i].BackColor = Color.MidnightBlue;
                    right = mid - 1;
                }

                stepBinary++;
            }
            else
            {
                lblBinaryStatus.Text = "❌ Target not found.";
                timerBinary.Stop();
            }
        }

        private void btnLinearStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                arr = txtArray.Text
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim()))
                    .ToArray();

                if (!int.TryParse(txtTarget.Text, out target))
                {
                    MessageBox.Show("Invalid target input!");
                    return;
                }

                CreateArrayVisualsLinear();
                indexLinear = 0;
                stepLinear = 1;

                lblLinearStatus.Text = "Starting Linear Search...";
                timerLinear.Interval = 1000;
                timerLinear.Start();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers separated by spaces.");
            }
        }

        private void btnBinaryStart_Click(object sender, EventArgs e)
        {
            try
            {
                arr = txtArray.Text
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x.Trim()))
                    .OrderBy(x => x)
                    .ToArray();

                if (!int.TryParse(txtTarget.Text, out target))
                {
                    MessageBox.Show("Invalid target input!");
                    return;
                }

                CreateArrayVisualsBinary();

                left = 0;
                right = arr.Length - 1;
                stepBinary = 1;

                lblBinaryStatus.Text = "Starting Binary Search...";
                timerBinary.Interval = 1000;
                timerBinary.Start();
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers separated by spaces.");
            }
        }

        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmMenu frmMenu = new frmMenu();
            //frmMenu.ShowDialog();
        }
        
        void CreateArrayVisualsBinary()
        {
            panelBinary.Controls.Clear();
            binaryLabels = new Label[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                binaryLabels[i] = new Label();
                binaryLabels[i].Text = arr[i].ToString();
                binaryLabels[i].Width = 45;
                binaryLabels[i].Height = 45;
                binaryLabels[i].TextAlign = ContentAlignment.MiddleCenter;
                binaryLabels[i].BorderStyle = BorderStyle.FixedSingle;
                binaryLabels[i].BackColor = Color.DodgerBlue;
                binaryLabels[i].Font = new Font("Arial", 10, FontStyle.Bold);
                panelBinary.Controls.Add(binaryLabels[i]);
            }
        }
    }
}
