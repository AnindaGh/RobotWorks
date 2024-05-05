using RobotMovement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotMovement.Models
{
     public class Position : IPosition
    {
        public int x {  get; set; }
        public int y { get; set; }

        public string FacingPostion { get; set; }

        public enum Facing
        {
            North,
            South,
            East,
            West
        }

        public List<int> getPosition()
        {
            List<int> positonList = new List<int>();
            positonList.Add(x);
            positonList.Add(y);

            return positonList;
        }

        public void setPosition(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public string getFacing()
        {
            return FacingPostion;
        }

        public void setFacing(string face)
        {
           switch (face)
            {
                case "NORTH": 
                    FacingPostion = Facing.North.ToString(); break;
                case "SOUTH":
                    FacingPostion = Facing.South.ToString(); break;
                case "EAST":
                    FacingPostion = Facing.East.ToString(); break;
                case "WEST":
                    FacingPostion = Facing.West.ToString(); break;


            }
        }

    }
}
