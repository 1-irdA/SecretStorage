﻿namespace SecretStorage.src.models
{
    /// <summary>
    /// Class who represent a secret password
    /// </summary>
    public class Secret
    {
        #region Properties

        /// <summary>
        /// Name of secret
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Password of secret
        /// </summary>
        public string Password { get; set; }

        #endregion Properties

        #region Constructor

        /// <summary>
        /// Init a secret
        /// </summary>
        /// <param name="name">Secret name</param>
        /// <param name="password">Secret password</param>
        public Secret(string name, string password)
        {
            Name = name;
            Password = password;
        }

        #endregion Constructor
    }
}
