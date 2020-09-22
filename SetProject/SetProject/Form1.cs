using SetProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetProject
{
    public partial class Form1 : Form
    {
        private Control[] universalSetInitControls;
        private Control[] addSetInitControls;
        private SetField field;
        public Form1()
        {
            InitializeComponent();
            InitUniversalSetInitControls();
            InitAddSetControls();

            for (int i = 0; i < this.addSetInitControls.Length; i++)
                addSetInitControls[i].Enabled = false;

            binaryOperationComboBox.SelectedIndex = 0;
            unaryOperationComboBox.SelectedIndex = 0;
        }

        private void InitUniversalSetInitControls()
        {
            this.universalSetInitControls = new Control[2]
            {
                uniSetTextBox, initUniSetButton
            };
        }

        private void InitAddSetControls()
        {
            this.addSetInitControls = new Control[11]
            {
                currentSetTextBox, addSetButton, setsListBox,
                binaryOperationComboBox, firstBinarySetComboBox, secondBinaryComboBox,
                unaryOperationComboBox, unarySetComboBox,
                doBinatyButton, doUnaryButton, updateButton
            };
        }

        private void UpdateComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            for (int i = 0; i < setsListBox.Items.Count; i++)
                comboBox.Items.Add($"{i}");
            comboBox.SelectedIndex = 0;
        }

        private void AddSetToListBox(Set set)
        {
            this.UpdateListBox(set.ToString());
            this.UpdateComboBox(firstBinarySetComboBox);
            this.UpdateComboBox(secondBinaryComboBox);
            this.UpdateComboBox(unarySetComboBox);
        }

        private void ChangeControlsState()
        {
            foreach (Control control in this.addSetInitControls)
                control.Enabled = !control.Enabled;

            foreach (Control control in this.universalSetInitControls)
                control.Enabled = !control.Enabled;
        }

        private void InitUniversalSet()
        {
            Set universal;
            try { universal = new Set(uniSetTextBox.Text); }
            catch { return; }
            field = new SetField(universal);
            uniSetTextBox.Text = field.UniversalSet.ToString();

            ChangeControlsState();
        }

        private void AddSet()
        {
            Set set;
            try { set = new Set(currentSetTextBox.Text); }
            catch
            {
                MessageBox.Show("Введенная строка некорректна");
                return;
            }

            try { field.AddSet(set); }
            catch
            {
                MessageBox.Show("Множество не является подмножеством универсального");
                currentSetTextBox.Clear();
                return;
            }
            currentSetTextBox.Clear();
            this.AddSetToListBox(set);
        }

        private void AddSetDialog(Set resultSet, string operationName)
        {
            DialogResult result = MessageBox.Show($"Результатом {operationName} " +
                $"является множество {resultSet.ToString()}\n" +
                $"Желаете ли вы добавить это множество в список?", "Результат", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {
                try { field.AddSet(resultSet); }
                catch
                {
                    MessageBox.Show($"Множество {resultSet.ToString()} \n" +
                        $"не является подмножеством универсального");
                    return;
                }
                this.AddSetToListBox(resultSet);
            }
            
        }

        private void UpdateListBox(string setString) =>
            setsListBox.Items.Add(setString + " " + 
                field.GetCharacteristicVectorString(this.field.Sets - 1));

        private void BinaryOperation()
        {
            Set resultSet = new Set("");
            string operationName = binaryOperationComboBox.Text.Substring(0, 
                binaryOperationComboBox.Text.Length - 1) + "я";

            switch (binaryOperationComboBox.SelectedIndex)
            {
                case 0:
                    resultSet = field.Disjunction(firstBinarySetComboBox.SelectedIndex,
                        secondBinaryComboBox.SelectedIndex);
                    break;
                case 1:
                    resultSet = field.Conjuction(firstBinarySetComboBox.SelectedIndex,
                        secondBinaryComboBox.SelectedIndex);
                    break;
            }

            AddSetDialog(resultSet, operationName);
        }

        private void UnaryOperation()
        {
            Set resultSet = new Set("");
            string operationName = unaryOperationComboBox.Text.Substring(0, 
                unaryOperationComboBox.Text.Length - 1) + "я";
            switch (unaryOperationComboBox.SelectedIndex)
            {
                case 0:
                    resultSet = field.ReverseSet(unarySetComboBox.SelectedIndex);
                    break;
            }

            AddSetDialog(resultSet, operationName);
        }

        private void UpdateAll()
        {
            firstBinarySetComboBox.Items.Clear();
            secondBinaryComboBox.Items.Clear();
            unarySetComboBox.Items.Clear();
            uniSetTextBox.Clear();
            setsListBox.Items.Clear();

            this.ChangeControlsState();
        }

        private void initUniSetButton_Click(object sender, EventArgs e) => InitUniversalSet();

        private void addSetButton_Click(object sender, EventArgs e) => AddSet();

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void doBinatyButton_Click(object sender, EventArgs e) => BinaryOperation();

        private void doUnaryButton_Click(object sender, EventArgs e) => UnaryOperation();

        private void updateButton_Click(object sender, EventArgs e) => UpdateAll();
    }
}
