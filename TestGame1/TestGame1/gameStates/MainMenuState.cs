using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestGame1
{
    class MainMenuState : AbstractState
    {
        private Square aSquare;

        public MainMenuState(Game1 p_game) : base(p_game)
        {
            aSquare = new Square(p_game, "square");
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
            if (m_game.getCurrentKeyboardState().IsKeyDown(Keys.NumPad1)) 
            {
                m_game.setGameState(new Level1State(m_game));
            }
            base.Update(gameTime);
        }
    }
}
