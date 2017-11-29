using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadComboBoxDemo
{
    class AreaViewModel
    {
        private ObservableCollection<Area> areas;

        public ObservableCollection<Area> Areas
        {
            get
            {
                if (areas == null)
                {
                    areas = new ObservableCollection<Area>();
                    areas.Add(new Area { AreaID = "001", AreaName = "白豹作业区" });
                    areas.Add(new Area { AreaID = "002", AreaName = "山城作业区" });
                    areas.Add(new Area { AreaID = "003", AreaName = "环江作业区" });
                    areas.Add(new Area { AreaID = "004", AreaName = "耿湾作业区" });
                    areas.Add(new Area { AreaID = "005", AreaName = "大板梁作业区" });
                    areas.Add(new Area { AreaID = "006", AreaName = "洪德作业区" });
                    areas.Add(new Area { AreaID = "007", AreaName = "洪德作业区2" });
                    areas.Add(new Area { AreaID = "008", AreaName = "洪德作业区3" });
                }
                return areas;
            }
        }
    }
}
