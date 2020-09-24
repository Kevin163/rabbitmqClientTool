using System;
using System.Windows.Forms;
using RabbitMQ.Client;

namespace RabbitMQClientTool
{
    public partial class Form1 : Form
    {
        private IConnection _conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_conn == null)
                {
                    var connectionFactory = new ConnectionFactory
                    {
                        HostName = host.Text,
                        Port = Convert.ToInt32(port.Text),
                        UserName = user.Text,
                        Password = password.Text,
                        VirtualHost = vhost.Text
                    };
                    _conn = connectionFactory.CreateConnection();
                    connect.Text = "disconnect";
                    MessageBox.Show($"connect successed");
                } else
                {
                    _conn.Close();
                    connect.Text = "connect";
                    MessageBox.Show($"disconnect successed");
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"connect failed because of {ex.Message}");
            }
        }
    }
}
