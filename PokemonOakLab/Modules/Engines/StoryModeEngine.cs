using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonOakLab.Modules.Engines
{
    public class StoryModeEngine
    {

        public string? mode { get; set; }

        public event EventHandler storyText;

        public void ProcessText()
        {
            if(storyText != null)
            storyText?.Invoke(this, EventArgs.Empty);
        }
    }
}
