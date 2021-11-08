using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace monogameSprite
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        List<Sprite> spritelista = new List<Sprite>();
        Player xwing;
        Enemy tie;
        private Texture2D _backgroundTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.PreferredBackBufferWidth = 1920;
            
        }

        protected override void Initialize()
        {
            xwing=new Player();
            xwing.Position=new Vector2(150,250);
            xwing.Hitbox=new Rectangle((int)xwing.Position.X, (int)xwing.Position.Y, 200, 200);

            tie=new Enemy();
            tie.Position=new Vector2(150,200);
            tie.Hitbox=new Rectangle((int)tie.Position.X, (int)tie.Position.Y, 200, 200);

            spritelista.Add(xwing);
            spritelista.Add(tie);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            xwing.Texture=Content.Load<Texture2D>("xwing");
            tie.Texture=Content.Load<Texture2D>("Tie");
            _backgroundTexture = Content.Load<Texture2D>("Background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || 
                    Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            xwing.Move();
            tie.Move();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin();
            _spriteBatch.Draw(_backgroundTexture, new Vector2(0, 0), Color.White);
            foreach(Sprite element in spritelista)
            {
                element.Draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
