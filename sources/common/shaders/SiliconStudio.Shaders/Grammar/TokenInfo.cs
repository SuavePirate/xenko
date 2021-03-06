﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.
namespace SiliconStudio.Shaders.Grammar
{
    /// <summary>
    /// Key terminal
    /// </summary>
    public class TokenInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenInfo"/> class.
        /// </summary>
        public TokenInfo()
        {
            IsCaseInsensitive = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenInfo"/> class.
        /// </summary>
        /// <param name="tokenCategory">The token category.</param>
        public TokenInfo(TokenCategory tokenCategory)
        {
            TokenCategory = tokenCategory;
            IsCaseInsensitive = false;
        }

        /// <summary>
        /// Gets or sets the token category.
        /// </summary>
        /// <value>
        /// The token category.
        /// </value>
        public TokenCategory TokenCategory { get; set; }

        /// <summary>
        /// Gets or sets if this token is case insensitive (default false).
        /// </summary>
        public bool IsCaseInsensitive { get; set; }

    }
}

