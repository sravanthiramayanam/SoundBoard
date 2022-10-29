using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;


namespace SoundBoard.Model
{
    internal static class SoundManager
    {
        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allsounds = getSounds();
            sounds.Clear();
            allsounds.ForEach(sound => sounds.Add(sound));

        }
        public static void GetAllSounds(ObservableCollection<Sound> sounds,SoundCategory category)
        {
            var allsounds = getSounds();
            sounds.Clear();
            var filteredSounds=allsounds.Where(sound => sound.Category == category).ToList();
            filteredSounds.ForEach(sound => sounds.Add(sound));

        }
        internal static List<Sound> getSounds()
        {
            var Sounds = new List<Sound>();
           
            Sounds.Add(new Sound("cat", SoundCategory.Animals));
            Sounds.Add(new Sound("cow", SoundCategory.Animals));
            Sounds.Add(new Sound("gun", SoundCategory.Cartoons));
            Sounds.Add(new Sound("spring.wav.mp3", SoundCategory.Cartoons));
            Sounds.Add(new Sound("alaram", SoundCategory.Warnings));
            Sounds.Add(new Sound("siren", SoundCategory.Warnings));
            return Sounds;  

        }

        

        

    }
}
