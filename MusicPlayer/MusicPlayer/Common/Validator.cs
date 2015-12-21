namespace MusicPlayer.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Validator
    {
        public static void ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return;
            }
        }
    }
}
