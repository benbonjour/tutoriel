using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TestGame1
{
    class Square : AbstractShape
    {
        // Methods
        public Square(Game1 p_game, string p_textureName) : base(p_game, p_textureName)
        {
            m_nbCorners = 4;
            m_position = Vector2.Zero;
        }

        public void setPosition(float p_x, float p_y)
        {
            m_position.X = p_x;
            m_position.Y = p_y;
        }
    }
}
