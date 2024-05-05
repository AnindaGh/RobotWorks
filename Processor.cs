using RobotMovement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RobotMovement.Models.Position;

namespace RobotMovement
{
    public class Processor
    {
        private readonly IPosition _position;
        public Processor(IPosition position)
        {
          _position = position;
        }


        public void Report()
        {
            var position = _position.getPosition();
            var facing = _position.getFacing();

            Console.WriteLine("OUTPUT:" + position[0] + "," + position[1] + "," + facing);
        }

        public void Place(int x,int y, string face)
        {
            _position.setPosition(x, y);
            _position.setFacing(face);
        }

        public void Move()
        {
            var position = _position.getPosition();
            var movedPosition = position[1] + 1;

            _position.setPosition(position[0], movedPosition);
        }

        public string Left()
        {
            var facing = _position.getFacing(); 
            string facingPosition = string.Empty;

            switch (facing)
            {
                case "NORTH":
                    facingPosition = "WEST"; break;
                case "WEST":
                    facingPosition = "SOUTH"; break;
                case "SOUTH":
                    facingPosition = "EAST"; break;
                case "EAST":
                    facingPosition = "NORTH"; break;

            }

            return facingPosition;

        }

        public string Right()
        {
            var facing = _position.getFacing();
            string facingPosition = string.Empty;

            switch (facing)
            {
                case "NORTH":
                    facingPosition = "EAST"; break;
                case "EAST":
                    facingPosition = "SOUTH"; break;
                case "SOUTH":
                    facingPosition = "WEST"; break;
                case "WEST":
                    facingPosition = "NORTH"; break;

            }

            return facingPosition;

        }

    }
}
