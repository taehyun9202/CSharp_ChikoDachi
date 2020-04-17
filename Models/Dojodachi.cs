using System.ComponentModel.DataAnnotations;
using System;

namespace Dojodachi
{
    public class Dojodachi
    {
        public int Happiness {get;set;}
        public int Fullness {get;set;}
        public int Energy {get;set;}
        public int Food {get;set;}
        public string Log {get;set;}
        public string ImgUrl {get;set;}

        public Dojodachi()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Food = 3;
            Log = "Take good Care of Chikorita!";
            ImgUrl = "https://i.pinimg.com/474x/45/63/34/45633417acf33861d83ddbfc0e4a33d1---pokemon-type-pokemon.jpg";
        }
        public void Play()
        {
            if(Energy < 5)
            {
                ImgUrl = "https://pbs.twimg.com/ext_tw_video_thumb/1250634853470650368/pu/img/MylpzUWfiW7cfZEB.jpg";
                Log = "Chikorita needs Energy and Sleep";
            }
            else
            {
                Energy -= 5;
                Random r = new Random();
                int RanValue = r.Next(5,11);
                Happiness += RanValue;
                Log = $"You Played with Chikorita!! Happiness + {RanValue}, Energy -5";
                ImgUrl ="https://i.pinimg.com/474x/f8/3f/84/f83f8440769917fb5a8195ce2217b46e--pokemon-starters-pokemon-gijinka.jpg";
                if(Happiness > 100)
                {
                    Happiness = 100;
                }
            }
            
        }
        public void Feed()
        {
            if(Food < 1)
            {
                ImgUrl = "https://pbs.twimg.com/ext_tw_video_thumb/1250634853470650368/pu/img/MylpzUWfiW7cfZEB.jpg";
                Log = "Chikorita needs Food!! Work More!";
            }
            else
            {
                Food -= 1;
                Random r = new Random();
                int RanValue = r.Next(5,11);
                Fullness += RanValue;
                Log = $"You Fed Chikorita!! Fullness + {RanValue}, Food -5";
                ImgUrl = "https://i.imgur.com/abQ126e.png";
                if(Fullness > 100)
                {
                    Fullness = 100;
                }
            }
        }
        public void Work()
        {
            if(Energy < 5)
            {
                ImgUrl = "https://pbs.twimg.com/ext_tw_video_thumb/1250634853470650368/pu/img/MylpzUWfiW7cfZEB.jpg";
                Log = "Chikorita needs Energy and Work";
            }
            else
            {
                Energy -= 5;
                Random r = new Random();
                int RanValue = r.Next(1,4);
                Food += RanValue;
                Log = $"You Worked with Chikorita!! Food + {RanValue}, Energy -5";
                ImgUrl = "https://static.pokemonpets.com/images/monsters-images-300-300/2152-Shiny-Chikorita.png";
                if(Food > 15)
                {
                    Log = "You can't have more than 15 Foods";
                    Fullness = 15;
                }
            }
        }
        public void Sleep()
        {
            if(Happiness < 5)
            {
                ImgUrl = "https://pbs.twimg.com/ext_tw_video_thumb/1250634853470650368/pu/img/MylpzUWfiW7cfZEB.jpg";
                Log = "Chikorita is NOT happy and does NOT want to go bed";
            }
            else if (Happiness == 100)
            {
                Energy += 15;
                Log = $"Chikorita Went bed...zzZ Energy + 15, Happiness -5";
                ImgUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/710d7e9e-fe22-40c6-9a20-f323e589c96b/day4tw2-5b3c7149-b32e-4a43-a048-99b7b7d72c64.png/v1/fill/w_1091,h_733,strp/chikorita_s_spring_time_nap_by_stacona_day4tw2-pre.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTI1MCIsInBhdGgiOiJcL2ZcLzcxMGQ3ZTllLWZlMjItNDBjNi05YTIwLWYzMjNlNTg5Yzk2YlwvZGF5NHR3Mi01YjNjNzE0OS1iMzJlLTRhNDMtYTA0OC05OWI3YjdkNzJjNjQucG5nIiwid2lkdGgiOiI8PTE4NjAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.FMjLgpUSoAWraDZhT-L4cdS3qAfJT1eYu-4RhyfDwfw";
                if(Energy > 100)
                {
                    Energy = 100;
                }
            }
            else
            {
                Happiness -= 5;
                Energy += 15;
                Log = $"Chikorita Went bed...zzZ Energy + 15, Happiness -5";
                ImgUrl = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/710d7e9e-fe22-40c6-9a20-f323e589c96b/day4tw2-5b3c7149-b32e-4a43-a048-99b7b7d72c64.png/v1/fill/w_1091,h_733,strp/chikorita_s_spring_time_nap_by_stacona_day4tw2-pre.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTI1MCIsInBhdGgiOiJcL2ZcLzcxMGQ3ZTllLWZlMjItNDBjNi05YTIwLWYzMjNlNTg5Yzk2YlwvZGF5NHR3Mi01YjNjNzE0OS1iMzJlLTRhNDMtYTA0OC05OWI3YjdkNzJjNjQucG5nIiwid2lkdGgiOiI8PTE4NjAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.FMjLgpUSoAWraDZhT-L4cdS3qAfJT1eYu-4RhyfDwfw";
                if(Energy > 100)
                {
                    Energy = 100;
                }
            }
        }
        public bool isWin()
        {
            if(Happiness >= 100 && Fullness >= 100 && Energy >= 100)
            {
                Log = "Congratulation!! Chikorita evolved into Bayleef";
                ImgUrl ="https://i.pinimg.com/474x/67/56/65/675665d345b44f5d041e093b87d91a40--girl-fashion-fashion-design.jpg";
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isLost()
        {
            if(Happiness <= 0 && Fullness <= 0 && Energy <= 0)
            {
                Log = "You lost... Chikolita now lost her last hair";
                ImgUrl ="https://cdn.donmai.us/original/e5/01/__chikorita_pokemon_drawn_by_alpacapala__e5017370194426c6c6f771e359c6a933.png";
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            Happiness = 20;
            Fullness = 20;
            Energy = 50;
            Food = 3;
            Log = "Take good Care of Chikorita!";
            ImgUrl = "https://i.pinimg.com/474x/45/63/34/45633417acf33861d83ddbfc0e4a33d1---pokemon-type-pokemon.jpg";
        }
    }
    
}