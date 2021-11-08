using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Enemy : Sprite{
    public void Move(){
        if (Keyboard.GetState().IsKeyDown(Keys.Left))
        {
            Position.X -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Right))
        {
            Position.X += Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Up))
        {
            Position.Y -= Speed;
        }
        if (Keyboard.GetState().IsKeyDown(Keys.Down))
        {
            Position.Y += Speed;
        }
        Hitbox = new Rectangle((int)Position.X, (int)Position.Y, 180,180);
    }   
}