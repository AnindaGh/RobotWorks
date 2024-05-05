using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovement.Interfaces
{
    public interface IPosition
    {
        public List<int>  getPosition();

        public void setPosition(int x,int y);

        public string getFacing();

        public void setFacing(string facing);
    }
}
