using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lab_4_View
{
    public partial class Form1 : Form
    {
        Assembly models;
        IEnumerable<Type> types;

        Type type;
        object Object;

        MethodInfo method;
        object[] methodParameters;


        public Form1()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            models = Assembly.Load("Lab_4_Model");
            types = models.GetTypes().Where(type => type.GetInterface("IMobile") != null && !type.IsAbstract);
            ObjComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }
        private void objectFieldsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void FillMethodsComboBox()
        {
            MethodsComboBox.Items.Clear();
            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            MethodsComboBox.Items.AddRange(type.GetMethods().Where(method => !objectMethods.Contains(method.Name) && method.Name.Substring(0, 4) != "get_" && method.Name.Substring(0, 4) != "set_").Select(method => method.Name).ToArray());
        }
        object InputIntNumber(string message)
        {
            read nf = new read(message);
            nf.ShowDialog();
            this.Enabled = true;

            return Int32.Parse(nf.number);
        }

        object InputObject(Type type)
        {
            MessageBox.Show($"input {type.Name} object");

            object newObject = Activator.CreateInstance(type);

            foreach (var item in type.GetProperties())
            {
                item.SetValue(newObject, InputIntNumber("input " + item.Name));
            }

            return newObject;
        }
        private void methodsFieldsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        void ShowObjectFields()
        {
            objectFieldsListBox.Items.Clear();

            foreach (var item in type.GetProperties())
            {
                objectFieldsListBox.Items.Add(item.Name + ": " + item.GetValue(Object));
            }
        }




        private void ObjComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            type = types.First(type => type.Name == ObjComboBox.SelectedItem.ToString());
            Object = null;
            FillMethodsComboBox();
            CreateObjButton.Enabled = true;
            ObjComboBox.Enabled = true;
            InputFieldsButton.Enabled = false;
            RunMethodButton.Enabled = false;
            objectFieldsListBox.Items.Clear();
        }

        private void MethodsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            method = type.GetMethods().First(Method => Method.Name == MethodsComboBox.SelectedItem.ToString());
            RunMethodButton.Enabled = false;
            if (method.GetParameters().Length == 0)
            {
                InputFieldsButton.Enabled = false;
                RunMethodButton.Enabled = Object != null;
            }
            else
                InputFieldsButton.Enabled = true;
            methodParameters = null;
            methodsFieldsListBox.Items.Clear();
            foreach (var item in method.GetParameters())
            {
                methodsFieldsListBox.Items.Add(item.Name);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CreateObjButton_Click_1(object sender, EventArgs e)
        {
            Object = InputObject(type);
            if (method?.GetParameters().Length == 0)
                RunMethodButton.Enabled = true;
            ShowObjectFields();
        }

        private void InputFieldsButton_Click_1(object sender, EventArgs e)
        {
            if (method.GetParameters()[0].ParameterType.Name == "IMobile")
                methodParameters = new object[1] { InputObject(type) };
            else if (method.GetParameters().Length != 0)
                methodParameters = method.GetParameters().Select(param => InputIntNumber("input" + param.Name)).ToArray();
            if (Object != null)
                RunMethodButton.Enabled = true;
        }

        private void RunMethodButton_Click_1(object sender, EventArgs e)
        {
            if (method.ReturnType == typeof(void))
            {
                method.Invoke(Object, methodParameters);
            }
            else
                MessageBox.Show(method.Invoke(Object, methodParameters).ToString());
            ShowObjectFields();
        }
    }
}