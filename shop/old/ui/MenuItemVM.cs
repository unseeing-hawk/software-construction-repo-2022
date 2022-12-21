using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DB_scientificLibrary.ui
{
    class MenuItemVM : VM
    {
        public ObservableCollection<MenuItemVM> ChildItems { get; } =
            new ObservableCollection<MenuItemVM>();

        Geometry icon;
        public Geometry Icon
        {
            get => icon;
            set => Set(ref icon, value);
        }

        string text;
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }

        string groupName;
        public string GroupName
        {
            get => groupName;
            set => Set(ref groupName, value);
        }

        int? itemCount;
        public int? ItemCount
        {
            get => itemCount;
            set => Set(ref itemCount, value);
        }

        Color itemColor;
        public Color ItemColor
        {
            get => itemColor;
            set => Set(ref itemColor, value);
        }
    }
}
