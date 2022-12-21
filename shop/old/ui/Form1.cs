using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DB_scientificLibrary.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IEnumerable<MenuItemVM> BuildMenu()
        {
            return new[]
            {
        new MenuItemVM()
        {
            Icon = Geometry.Parse("M0,0 L1,0 L1,1 L0,1 L0,0 L1,1 M1,0 L0,1"),
            Text = "Dashboards",
            GroupName = "Apps",
            ChildItems =
            {
                new MenuItemVM() { Text = "Dashboard1" },
                new MenuItemVM() { Text = "Dashboard2" }
            }
        },
        new MenuItemVM()
        {
            Icon = Geometry.Parse("M0,0 L1,0 L1,1 L0,1 L0,0 L1,1 M1,0 L0,1"),
            Text = "Calendar",
            GroupName = "Apps"
        },
        new MenuItemVM()
        {
            Icon = Geometry.Parse("M0,0 L1,0 L1,1 L0,1 L0,0 L1,1 M1,0 L0,1"),
            Text = "Mail",
            GroupName = "Apps",
            ItemCount = 25,
            ItemColor = Colors.Red
        },
        new MenuItemVM()
        {
            Icon = Geometry.Parse("M0,0 L1,0 L1,1 L0,1 L0,0 L1,1 M1,0 L0,1"),
            Text = "Coming Soon",
            GroupName = "Pages"
        }
    };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
