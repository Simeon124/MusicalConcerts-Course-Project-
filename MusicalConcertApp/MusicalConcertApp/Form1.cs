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
        Concert currentConcert;
        bool isLoggedIn;
        public Form1()
        {
            InitializeComponent();
            homePagePanel.Visible = true;
            LoginSlashRegisterPanel.Visible = false;
            concertsPanel.Visible = false;
            concertPanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = false;
            concertsPanel.Visible = false;
            homePagePanel.Visible = true;
            concertPanel.Visible = false;

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
            concertPanel.Visible = false;
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
            concertPanel.Visible = false;

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
                    Name = concert.Name,
                };
                button.Click += new EventHandler(concertInfoButton);

                card.Controls.Add(title);
                card.Controls.Add(location);
                card.Controls.Add(button);

                concertsPanel.Controls.Add(card);
            }
        }

        private void concertInfoButton(object sender, EventArgs e)
        {
            LoginSlashRegisterPanel.Visible = false;
            homePagePanel.Visible = false;
            concertsPanel.Visible = false;
            concertPanel.Visible = true;
            concertsPanel.Controls.Clear();

            var clickedButton = sender as Button;

            if (clickedButton != null)
            {
                using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
                {
                    var choosenConcert = dbc.Concerts.FirstOrDefault(x => x.Name == clickedButton.Name);
                    if (choosenConcert != null)
                    {
                        if(dbc.UserConcerts != null)
                        {
                            //var currentUserConcert = dbc.UserConcerts.FirstOrDefault(x => x.User == currentUser).Concerts.FirstOrDefault(c => c == choosenConcert);
                            if (currentUser != null)
                            {
                                signButton.Enabled = true;
                            }
                            else
                            {
                                signButton.Enabled = false;
                            }
                        }
                        else if (dbc.UserConcerts == null && currentUser != null)
                        {
                            signButton.Enabled = true;
                        }
                        

                        currentConcert = choosenConcert;
                        concertTitle.Text = choosenConcert.Name;
                        concertDescription.Text = "";
                        concertDescription.Text += $"Концертът ще се изпълни от {choosenConcert.Performers} в град/село {choosenConcert.Location} на " +
                            $"{choosenConcert.ConcertStartDate.Day}-{choosenConcert.ConcertStartDate.Month}-{choosenConcert.ConcertStartDate.Year} г. ";
                        concertGenreLabel.Text = choosenConcert.Genre.ToString();
                    }
                }
            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as Button;

            if(clickedButton != null)
            {
                clickedButton.Enabled = false;

                using (MusicalConcertAppDbContext dbc = new MusicalConcertAppDbContext())
                {
                    ConcertUsers concertUsers = new ConcertUsers
                    {
                        Concert = currentConcert,
                    };
                    concertUsers.Users.Add(currentUser);

                    dbc.ConcertUsers.Add(concertUsers);
                    dbc.SaveChanges();

                    UserConcerts userConcerts = new UserConcerts
                    {
                        User = currentUser,
                    };
                    userConcerts.Concerts.Add(currentConcert);

                    dbc.UserConcerts.Add(userConcerts);
                    dbc.SaveChanges();
                }
            }
        }
    }
}
