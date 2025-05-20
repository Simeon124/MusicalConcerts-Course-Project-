using Business;
using Data;
using Data.Models;
using System.Drawing.Printing;
using System.Windows.Forms.VisualStyles;

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
            concertsPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = false;
            concertsPanel.Visible = false;
            homePagePanel.Visible = true;

            concertsPanel.Controls.Clear();

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
            concertsPanel.Visible = false;
            concertsPanel.Controls.Clear();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
            {
                var foundUser = dbc.Users.FirstOrDefault(x => x.Name == registerNameTextBox.Text);
                if (foundUser == null)
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
                if (foundUser != null)
                {
                    if (loginPasswordTextBox.Text == foundUser.Password)
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

        private void concertsButton_Click(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = false;
            homePagePanel.Visible = false;
            concertsPanel.Visible = true;

            var concerts = Business.Business.GetConcerts();
            foreach (var concert in concerts)
            {
                Panel card = new Panel
                {
                    Height = 240,
                    Width = 120,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label title = new Label
                {
                    Text = concert.Name,
                    Location = new Point(10, 10),
                    ForeColor = Color.Black,
                    AutoSize = true,
                };
                Label location = new Label
                {
                    Text = $"Място: {concert.Location}",
                    Location = new Point(10, 30),
                    ForeColor = Color.Black,
                    AutoSize = true,
                };

                Button button = new Button()
                {
                    Location = new Point(10, 50),
                    Text = "Още...",
                };

                card.Controls.Add(title);
                card.Controls.Add(location);
                card.Controls.Add(button);

                concertsPanel.Controls.Add(card);
            }
        }
    }
}
