﻿// -----------------------------------------------------------------------
// <copyright file="NotificationFactory.cs" company="None">
// Copyright Keith Cully 2013.
// </copyright>
// -----------------------------------------------------------------------

namespace SticKart.Display.Notification
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;

    /// <summary>
    /// A factory for creating notification objects.
    /// </summary>
    public class NotificationFactory
    {
        /// <summary>
        /// The sprite batch used to render game sprites.
        /// </summary>
        private SpriteBatch spriteBatch;

        /// <summary>
        /// The content manager to use for loading assets.
        /// </summary>
        private ContentManager contentManager;

        /// <summary>
        /// The size of the game display area.
        /// </summary>
        private Vector2 displayDimensions;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationFactory"/> class.
        /// </summary>
        /// <param name="contentManager">The content manager to use for loading assets.</param>
        /// <param name="spriteBatch">The sprite batch used to render game sprites.</param>
        /// <param name="displayDimensions">The size of the game display area.</param>
        public NotificationFactory(ContentManager contentManager, SpriteBatch spriteBatch, Vector2 displayDimensions)
        {
            this.spriteBatch = spriteBatch;
            this.contentManager = contentManager;
            this.displayDimensions = displayDimensions;
        }

        /// <summary>
        /// Creates a notification of the type passed in.
        /// </summary>
        /// <param name="notificationType">The type of notification to create.</param>
        /// <returns>The new notification.</returns>
        public Notification Create(NotificationType notificationType)
        {
            Notification notification = null;
            switch (notificationType)
            {
                case NotificationType.None:
                    break;
                case NotificationType.StepBack:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 2.0f, NotificationStrings.StepBack, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.StepBack, 1, 3.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.StepForward:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 2.0f, NotificationStrings.StepForward, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.StepBack, 1, 3.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.PushGesture:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Push, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Push, 7, 0.2f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.SwipeGesture:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Swipe, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Swipe, 9, 0.075f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.VoiceCommand:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.VoiceCommand, ContentLocations.SegoeUIFontMedium, string.Empty, 0, 0.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Run:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Run, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Run, 8, 0.06f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.JumpUp:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Jump, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.JumpIcon, 8, 0.06f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.JumpDown:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.JumpDown, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Crouch, 8, 0.075f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Crouch:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Crouch, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Crouch, 8, 0.075f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Place:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Place, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Place, 10, 0.075f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Swap:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Swap, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Swap, 6, 0.125f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.ScrollingDeath:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.ScrollingDeath, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.ScrollingDeath, 7, 0.1f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Exit:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Exit, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Exit, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Cart:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Cart, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Cart, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Bonus:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Bonus, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Bonus, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Obstacle:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Obstacle, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Obstacle, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.PowerUp:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.PowerUp, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.PowerUp, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Switch:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Switch, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Switch, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                case NotificationType.Platform:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 10.0f, NotificationStrings.Platform, ContentLocations.SegoeUIFontMedium, ContentLocations.NotificationsPath + ContentLocations.Platform, 1, 11.0f, ContentLocations.NotificationsPath + ContentLocations.Background);
                    break;
                default:
                    notification = new Notification(notificationType, this.contentManager, this.spriteBatch, this.displayDimensions / 2.0f, 5.0f, string.Empty, string.Empty, string.Empty, 0, 0.0f, string.Empty);
                    break;
            }

            return notification;
        }
    }
}
