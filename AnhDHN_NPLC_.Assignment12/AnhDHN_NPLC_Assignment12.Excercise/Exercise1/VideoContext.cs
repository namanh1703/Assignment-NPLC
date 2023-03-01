﻿using Microsoft.EntityFrameworkCore;

namespace AnhDHN_NPLC_Assignment12.Exercise.Exercise1
{
    /// <summary>
    /// Represents a database context for managing video files.
    /// </summary>
    public class VideoContext : DbContext
    {
        /// <summary>
        /// Gets or sets a DbSet of Video objects representing the videos in the database.
        /// </summary>
        public DbSet<Video> Videos { get; set; }
    }
}
