using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Player : Sprite{
    public void Move(){
        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            Position.X -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            Position.X += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.W))
        {
            Position.Y -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.S))
        {
            Position.Y += Speed;
        }
        Hitbox = new Rectangle((int)Position.X, (int)Position.Y, 120,120);
    }
}