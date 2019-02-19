using NHibernate;
using NHibernate.Cfg;
using NHibernateTest.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHibernateTest
{
    public partial class Form1 : Form
    {

        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myConfiguration = new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            using(mySession.BeginTransaction())
            {
                Contato loContato = new Contato { Nome="Marcio Silva",Telefone="997061756"};
                mySession.Save(loContato);

                mySession.Transaction.Commit();
            }
        }
    }
}
