using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

class Sprite{
    public Texture2D Texture {set; get;}
    public Vector2 Position;
    public Rectangle Hitbox {set; get;}

    public void Draw(SpriteBatch sb){
        sb.Draw(Texture, Hitbox, Color.White);
    }
    public float Speed = 2f;
}