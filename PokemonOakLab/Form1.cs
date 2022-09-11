using Newtonsoft.Json;
using PokemonOakLab.Modules.Constants;
using PokemonOakLab.Modules.Engines;
using PokemonOakLab.Modules.Pokemon;
using PokemonOakLab.Modules.PokemonTypes;
using System.Runtime.CompilerServices;

namespace PokemonOakLab
{
    public partial class Form1 : Form
    {
        public static string pokemonName = "";
        public PokeBag myBag;
        public StoryModeEngine engineText;

        public Form1()
        {
            InitializeComponent();

            InitPokemons();

            engineText = new StoryModeEngine(); 
            myBag = new PokeBag();
           
            this.InitializeBAG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pokedexImage.Image = new Bitmap(Constants.pathImage + pokemonName + ".png");
                adventureBox.Text = "you have selected " + pokemonName;
            }
            catch (Exception ex)
            {
                pokedexImage.Image = pokedexImage.ErrorImage;
            }
            
        }

        private void InitializeBAG()
        {

            int i = 0;

            foreach (PictureBox lb in myTeam.Controls)
            {
                lb.Click += ShowPokeData;
                lb.Image = new Bitmap(Constants.pathImage + myBag.MyPokemons[i].Name + ".png");
                lb.SizeMode = PictureBoxSizeMode.StretchImage;
                lb.Tag = myBag.MyPokemons[i].Name;
                i++;
            }

        }


        private void ShowPokeData(object sender, EventArgs e)
        {

            
            string x = (string)(sender as PictureBox).Tag;
            var selectedPoke = myBag.IChooseYou(x);

            if (selectedPoke != null)
            {
                if (selectedPoke is FirePokemon)
                {
                    var attack = selectedPoke.FireBall(3);
                    this.pokeInfo.Text = x + " " + attack.Item2;
                } else
                {
                    this.pokeInfo.Text = x;
                }

            } else
            {
                this.pokeInfo.Text = x;
            }

            adventureBox.Text = "you have selected " + x;
            //  engineText.storyText += (s, e) => adventureBox.Text = "you have selected " + x;

        }

        private void pokeList_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            pokemonName = (string)comboBox.SelectedItem;
        }

        private void InitPokemons()
        {
            
            using (StreamReader reader = new StreamReader(@"C:\Users\n_bry\source\repos\PokemonOakLab\PokemonOakLab\pokeData.json"))
            {
                string json = reader.ReadToEnd();
                List<PokeJson> items = JsonConvert.DeserializeObject<List<PokeJson>>(json);

                foreach (PokeJson poke in items)
                {
                    pokeList.Items.Add(poke.name.english);
                }
            }
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            engineText.ProcessText();
        }
    }

    public class PokeJson
    {
        public int id { get; set; }
        public Name name { get; set; }
        public string[] typePoke { get; set; }
        public Stats stats { get; set; }  
    }

    public class Name
    {
        public string english { get; set; }
        public string japanese { get; set; }
        public string chinese { get; set; }
        public string french { get; set; }
    }

    public class Stats
    {
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
    }
}