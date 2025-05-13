using Data;
using Data.Models;

namespace MusicalConcertApp
{
    public partial class Form1 : Form
    {
        User currentUser;
        bool isLoggedIn;
        public Form1()
        {
            InitializeComponent();
            homePagePanel.Visible = true;
            LoginSlashRegisterPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = false;
            homePagePanel.Visible = true;

            loginErrorSpan.Text = string.Empty;
            registerErrorSpan.Text = string.Empty;

            loginNameTextBox.Text = string.Empty;
            loginPasswordTextBox.Text = string.Empty;

            registerNameTextBox.Text = string.Empty;
            registerPasswordTextBox.Text = string.Empty;
        }

        private void LatestConcertButton_Click(object sender, EventArgs e)
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = true;
            homePagePanel.Visible = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var foundUser = dbc.Users.FirstOrDefault(x => x.Name == registerNameTextBox.Text);
                if(foundUser == null)
                {
                    User newUser = new User()
                    {
                        Name = registerNameTextBox.Text,
                        Password = registerPasswordTextBox.Text,
                    };
                    dbc.Users.Add(newUser);
                    dbc.SaveChanges();
                    currentUser = newUser;
                    isLoggedIn = true;
                    LoginSlashRegisterPanel.Visible = false;
                    homePagePanel.Visible = true;
                    userName.Visible = true;
                    userName.Text = currentUser.Name;
                }
                else
                {
                    registerErrorSpan.Visible = true;
                    registerErrorSpan.Text += "Има акаунт със същото име. Измислете ново име.";
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var foundUser = dbc.Users.FirstOrDefault(x => x.Name == loginNameTextBox.Text);
                if(foundUser != null)
                {
                    if(loginPasswordTextBox.Text == foundUser.Password)
                    {
                        currentUser = foundUser;
                        isLoggedIn = true;
                        userName.Visible = true;
                        userName.Text = currentUser.Name;
                        LoginSlashRegisterPanel.Visible = false;
                        homePagePanel.Visible = true;
                    }
                    else
                    {
                        loginErrorSpan.Visible = true;
                        loginErrorSpan.Text += "Грешна парола!";
                    }
                }
                else
                {
                    loginErrorSpan.Visible = true;
                    loginErrorSpan.Text += "Не е намерен акаунт с това име.";
                }
            }
        }
    }
}
