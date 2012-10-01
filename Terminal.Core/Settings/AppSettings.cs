﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace Terminal.Core.Settings
{
    /// <summary>
    /// Various static application settings.
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// The logo to display on application initialization.
        /// </summary>
        public static string Logo
        {
            get
            {
                return @"
   _____ _______   _______                  _             _ 
  / ____|__   __| |__   __|                (_)           | |
 | |       | |       | | ___ _ __ _ __ ___  _ _ __   __ _| |
 | |       | |       | |/ _ \ '__| '_ ` _ \| | '_ \ / _` | |
 | |____   | |       | |  __/ |  | | | | | | | | | | (_| | |
  \_____|  |_|       |_|\___|_|  |_| |_| |_|_|_| |_|\__,_|_|";
            }
        }

        private static int _maxLineLength = 95;
        public static int MaxLineLength
        {
            get { return _maxLineLength; }
            set { _maxLineLength = value; }
        }

        public static int DividerLength
        {
            get { return _maxLineLength / 2; }
        }

        /// <summary>
        /// The number of topics to display per page.
        /// </summary>
        public static int TopicsPerPage
        {
            get { return 15; }
        }

        /// <summary>
        /// The number of replies to display per page.
        /// </summary>
        public static int RepliesPerPage
        {
            get { return 15; }
        }

        public static int MessagesPerPage
        {
            get { return 15; }
        }
    }
}
