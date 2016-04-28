using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace Explore
{
    public class SimpleMover : Component, IUpdatable
    {
        public float Speed = 500f;

        public void update()
        {
            Vector2 direction = Vector2.Zero;

            if (Input.isKeyPressed(Keys.A))
            {
                direction.X = -1f;
            }
            else if (Input.isKeyPressed(Keys.D))
            {
                direction.X = 1f;
            }
            if (Input.isKeyPressed(Keys.W))
            {
                direction.Y = -1f;
            }
            else if (Input.isKeyPressed(Keys.S))
            {
                direction.Y = 1f;
            }

            entity.transform.position += direction * Speed * Time.deltaTime;
        }
    }
}
