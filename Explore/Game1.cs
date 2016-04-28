using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;

namespace Explore
{
    public class Game1 : Core
    {
        public Game1() : base(width: 480, height: 320, isFullScreen: false, enableEntitySystems: false)
        {
            Window.Title = "Explore";
            Window.ClientSizeChanged += Core.onClientSizeChanged;
        }

        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowUserResizing = true;

            // create our Scene with the DefaultRenderer and a clear color of CornflowerBlue
            Scene myScene = Scene.createWithDefaultRenderer(Color.Black);

            // load a Texture. Note that the Texture is loaded via the scene.contentManager class. This works just like the standard MonoGame Content class
            // with the big difference being that it is tied to a Scene. When the Scene is unloaded so too is all the content loaded via myScene.contentManager.
            var texture1 = myScene.contentManager.Load<Texture2D>("images/1");
            var texture2 = myScene.contentManager.Load<Texture2D>("images/5");

            // setup our Scene by adding some Entities
            Entity entityOne = myScene.createEntity("entity-one");
            entityOne.addComponent(new Sprite(texture1));

            Entity entityTwo = myScene.createEntity("entity-two");
            entityTwo.addComponent(new Sprite(texture2));
            entityTwo.addComponent(new SimpleMover());

            // move entityTwo to a new location so it isn't overlapping entityOne
            entityOne.transform.position = new Vector2(64, 64);

            // move entityTwo to a new location so it isn't overlapping entityOne
            entityTwo.transform.position = new Vector2(128, 128);

            // set the scene so Nez can take over
            scene = myScene;
        }
    }
}
