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
    public abstract class AbstractShape
    {
        // Attributes
        protected int m_nbCorners;
        protected string m_textureName;
        protected Texture2D m_shape;
        protected Vector2 m_position;
        protected Game1 m_game;


        // Methods
        public AbstractShape(Game1 p_game, string p_textureName)
        {
            m_game = p_game;
            m_textureName = p_textureName;
        }

        public virtual void LoadContent()
        {
            m_shape = m_game.Content.Load<Texture2D>(m_textureName);
        }

        public virtual void Draw(GameTime p_gameTime)
        {
            m_game.getSpriteBatch().Draw(m_shape, m_position, Color.White);
        }

        public int getWidth() 
        {
            return m_shape.Width;
        }

        public int getHeight() 
        {
            return m_shape.Height;
        }
    }
}
