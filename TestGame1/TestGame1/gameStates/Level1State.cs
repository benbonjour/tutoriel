using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGame1
{
    class Level1State : AbstractState
    {
        private Square aSquare;

        public Level1State(Game1 p_game)
            : base(p_game)
        {
            aSquare = new Square(p_game, "square");
            aSquare.setPosition(50, 300);
            LoadContent();
        }

        public override void LoadContent()
        {
            aSquare.LoadContent();
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
        {
            aSquare.Draw(gameTime);
            base.Draw(gameTime);
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            if (m_game.getCurrentKeyboardState().IsKeyDown(Keys.M))
            {
                m_game.setGameState(new MainMenuState(m_game));
            }
            base.Update(gameTime);
        }
    }
}
