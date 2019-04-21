using CitiesCatalog.Models;
using CitiesCatalog.Services.Abstract;
using System;
using System.Windows.Forms;

namespace CitiesCatalog
{
    public partial class CityCatalog : Form
    {
        private Service _service;

        public CityCatalog()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBoxLastName.Clear();
            textBoxFirstName.Clear();
            textBoxCityCode.Clear();
            textBoxTelephoneNumber.Clear();
            comboBoxCity.Text = "";
        }

        private void SetDefaultComboBoxItems()
        {
            _service = new Service();

            var cities = _service.Select<City>();

            _service.Dispose();
            
            foreach (var city in cities)
            {
                comboBoxCity.Items.Add(city.Name);
            }
            comboBoxCity.Sorted = true;
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            _service = new Service();
            var cities = _service.Select<City>();

            textBoxCityCode.Text = cities[comboBoxCity.SelectedIndex].Code.ToString();

            _service.Dispose();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "" || textBoxCityCode.Text == "" || textBoxFirstName.Text == "" || textBoxTelephoneNumber.Text == "")
            {
                labelResult.Text = " Заполните форму до конца!";
                return;
            }

            _service = new Service();
            var cities = _service.Select<City>();
            var city = cities[comboBoxCity.SelectedIndex];
            
            _service._context.Cities.Attach(city);

            var contact = new Contact
            {
                LastName = textBoxLastName.Text,
                FirstName = textBoxFirstName.Text,
                City = city,
                TelephoneNumber = labelTelephoneCode.Text + textBoxCityCode.Text + textBoxTelephoneNumber.Text
            };

            try
            {
                _service.Insert(contact);

                labelResult.Text = "Пользователь успешно добавлен!";
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException exception)
            {
                if (exception.InnerException.InnerException.Message.ToLower().Contains("unique"))
                {
                    labelResult.Text = "Такой номер телефона уже\nесть в базе данных!";
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException)
            {
                labelResult.Text = " Неверный ввод данных!";
            }
            catch
            {
                labelResult.Text = " Произошла ошибка!";
            }
            finally
            {
                _service.Dispose();
                Clear();
            }
        }

        private void textBoxTelephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void CityCatalog_Load(object sender, EventArgs e)
        {
            SetDefaultComboBoxItems();
        }
    }
}
