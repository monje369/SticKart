﻿// -----------------------------------------------------------------------
// <copyright file="BonusOrObstacle.cs" company="None">
// Copyright Keith Cully 2012.
// </copyright>
// -----------------------------------------------------------------------

namespace SticKart.Game.Entities
{
    using System;
    using FarseerPhysics.Dynamics;
    using Microsoft.Xna.Framework.Audio;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// Defines a bonus or an obstacle.
    /// </summary>
    public class BonusOrObstacle : InteractiveEntity
    {
        /// <summary>
        /// The name of the entity.
        /// </summary>
        private string name;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BonusOrObstacle"/> class.
        /// </summary>
        /// <param name="physicsWorld">The physics world.</param>
        /// <param name="spriteBatch">The sprite batch to use for rendering.</param>
        /// <param name="contentManager">The game's content manager.</param>
        /// <param name="description">The entity description.</param>
        /// <param name="setting">The entity's settings.</param>
        public BonusOrObstacle(ref World physicsWorld, SpriteBatch spriteBatch, ContentManager contentManager, InteractiveEntityDescription description, ObstacleOrBonusSetting setting)
            : base(ref physicsWorld, description)
        {            
            this.Type = setting.IsBonus ? InteractiveEntityType.Bonus : InteractiveEntityType.Obstacle;
            this.name = setting.Name;
            this.Value = setting.Value;
            this.PhysicsBody.UserData = new InteractiveEntityUserData(this.Type, this.Value);
            this.InitializeAndLoad(spriteBatch, contentManager);
        }

        /// <summary>
        /// Gets the value of the entity.
        /// </summary>
        public float Value { get; private set; }

        /// <summary>
        /// Gets the type of the entity.
        /// </summary>
        public InteractiveEntityType Type { get; private set; }

        /// <summary>
        /// Gets the object type.
        /// </summary>
        /// <returns>The object type.</returns>
        public override Type ObjectType()
        {
            return typeof(BonusOrObstacle);
        }

        /// <summary>
        /// Initializes and loads any assets used by the entity.
        /// </summary>
        /// <param name="spriteBatch">The sprite batch to use for rendering.</param>
        /// <param name="contentManager">The game's content manager.</param>
        protected override void InitializeAndLoad(SpriteBatch spriteBatch, ContentManager contentManager)
        {
            string path = string.Empty;
            if (this.Type == InteractiveEntityType.Bonus)
            {
                path = EntityConstants.SpritesFolderPath + EntityConstants.BonusFolderSubPath;
            }
            else
            {
                path = EntityConstants.SpritesFolderPath + EntityConstants.ObstacleFolderSubPath;
            }

            this.Sound = contentManager.Load<SoundEffect>(EntityConstants.SoundEffectsFolderPath + this.name);
            this.Sprite.InitializeAndLoad(spriteBatch, contentManager, path + this.name);
        }
    }
}
