﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scenes;
using SDL2;

namespace Scenes
{
    /// <summary>
    /// Defines a scene element
    /// </summary>
    public interface ISceneElement
    {
        /// <summary>
        /// Scene the element is in
        /// </summary>
        IScene scene { get; set; }

        /// <summary>
        /// X position of the element
        /// </summary>
        int x { get; set; }

        /// <summary>
        /// Y position of the element
        /// </summary>
        int y { get; set; }

        /// <summary>
        /// Draw the element
        /// </summary>
        void DrawElement();

        /// <summary>
        /// Handles events and passes it on to the correct method
        /// </summary>
        void HandleEvent(SDL.SDL_Event e);

        void OnHover(SDL.SDL_Event e)
        {

        }
    }
}
