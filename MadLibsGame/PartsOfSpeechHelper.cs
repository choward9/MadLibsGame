using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MadLibsGame
{
    public static class PartsOfSpeechHelper
    {
        #region Backing Variables
        private static string[] _Nouns;
        private static string[] _PluralNouns;
        private static string[] _Verbs;
        private static string[] _Adjectives;
        private static string[] _Adverbs;
        private static string[] _PastTenseVerbs;
        private static string[] _GerundVerbs;
        private static string[] _VerbsEndingInS;
        private static string[] _Superlatives;

        private static string[] _Actors;
        private static string[] _AliveSomethings;
        private static string[] _PluralAliveSomethings;
        private static string[] _Animals;
        private static string[] _PluralAnimals;
        private static string[] _Birds;
        private static string[] _BoyNames;
        private static string[] _Buildings;
        private static string[] _Celebrities;
        private static string[] _Cities;
        private static string[] _Clothing;
        private static string[] _PluralClothing;
        private static string[] _Colors;
        private static string[] _Concepts;
        private static string[] _Containers;
        private static string[] _Countries;
        private static string[] _Diseases;
        private static string[] _Exclamations;
        private static string[] _FamousPeople;
        private static string[] _FemaleCelebrities;
        private static string[] _FirstNames;
        private static string[] _Foods;
        private static string[] _PluralFoods;
        private static string[] _Fruits;
        private static string[] _PluralFruits;
        private static string[] _Furniture;
        private static string[] _Games;
        private static string[] _GeographicalLocations;
        private static string[] _Holidays;
        private static string[] _HouseRooms;
        private static string[] _IckySomethings;
        private static string[] _ItalianWords;
        private static string[] _LastNames;
        private static string[] _Letters;
        private static string[] _Liquids;
        private static string[] _MaleCelebrities;
        private static string[] _MovieStars;
        private static string[] _Names;
        private static string[] _NonsenseWords;
        private static string[] _Occupations;
        private static string[] _PluralOccupations;
        private static string[] _PartsOfBody;
        private static string[] _Places;
        private static string[] _PluralPartsOfBody;
        private static string[] _Relatives;
        private static string[] _RoundSomethings;
        private static string[] _Schools;
        private static string[] _SillyNoises;
        private static string[] _SillyWords;
        private static string[] _PluralSillyWords;
        private static string[] _SpanishWords;
        private static string[] _Sports;
        private static string[] _Towns;
        private static string[] _TVActors;
        private static string[] _Vegetables;
        private static string[] _Vehicles;
        #endregion

        #region Properties
        private static string[] Nouns
        {
            get
            {
                if (_Nouns == null)
                {
                    _Nouns = PartsOfSpeechExamples.Nouns.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Nouns;
            }
        }
        private static string[] PluralNouns
        {
            get
            {
                if (_PluralNouns == null)
                {
                    _PluralNouns = PartsOfSpeechExamples.PluralNouns.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _PluralNouns;
            }
        }
        private static string[] Verbs
        {
            get
            {
                if (_Verbs == null)
                {
                    _Verbs = PartsOfSpeechExamples.Verbs.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Verbs;
            }
        }
        private static string[] Adjectives
        {
            get
            {
                if (_Adjectives == null)
                {
                    _Adjectives = PartsOfSpeechExamples.Adjectives.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Adjectives;
            }
        }
        private static string[] Adverbs
        {
            get
            {
                if (_Adverbs == null)
                {
                    _Adverbs = PartsOfSpeechExamples.Adverbs.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Adverbs;
            }
        }
        private static string[] PastTenseVerbs
        {
            get
            {
                if (_PastTenseVerbs == null)
                {
                    _PastTenseVerbs = PartsOfSpeechExamples.PastTenseVerbs.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _PastTenseVerbs;
            }
        }
        private static string[] GerundVerbs
        {
            get
            {
                if (_GerundVerbs == null)
                {
                    _GerundVerbs = PartsOfSpeechExamples.GerundVerbs.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _GerundVerbs;
            }
        }
        private static string[] VerbsEndingInS
        {
            get
            {
                if (_VerbsEndingInS == null) { _VerbsEndingInS = PartsOfSpeechExamples.VerbsEndingInS.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _VerbsEndingInS;
            }
        }
        private static string[] Superlatives
        {
            get
            {
                if (_Superlatives == null) { _Superlatives = PartsOfSpeechExamples.Superlatives.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Superlatives;
            }

        }

        private static string[] Actors
        {
            get
            {
                if (_Actors == null) { _Actors = PartsOfSpeechExamples.Actors.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Actors;
            }
        }
        private static string[] AliveSomethings
        {
            get
            {
                if (_AliveSomethings == null) { _AliveSomethings = PartsOfSpeechExamples.AliveSomethings.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _AliveSomethings;
            }
        }
        private static string[] PluralAliveSomethings
        {
            get
            {
                if (_PluralAliveSomethings == null) { _PluralAliveSomethings = PartsOfSpeechExamples.AliveSomethingsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralAliveSomethings;
            }
        }
        private static string[] Animals
        {
            get
            {
                if (_Animals == null)
                {
                    _Animals = PartsOfSpeechExamples.Animals.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Animals;
            }
        }
        private static string[] PluralAnimals
        {
            get
            {
                if (_PluralAnimals == null) { _PluralAnimals = PartsOfSpeechExamples.AnimalsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralAnimals;
            }
        }
        private static string[] Birds
        {
            get
            {
                if (_Birds == null) { _Birds = PartsOfSpeechExamples.Birds.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Birds;
            }
        }
        private static string[] BoyNames
        {
            get
            {
                if (_BoyNames == null) { _BoyNames = PartsOfSpeechExamples.BoyNames.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _BoyNames;
            }
        }
        private static string[] Buildings
        {
            get
            {
                if (_Buildings == null) { _Buildings = PartsOfSpeechExamples.Buildings.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Buildings;
            }
        }
        private static string[] Celebrities
        {
            get
            {
                if (_Celebrities == null) { _Celebrities = PartsOfSpeechExamples.Celebrities.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Celebrities;
            }
        }
        private static string[] Cities
        {
            get
            {
                if (_Cities == null) { _Cities = PartsOfSpeechExamples.Cities.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Cities;
            }
        }
        private static string[] Clothing
        {
            get
            {
                if (_Clothing == null)
                {
                    _Clothing = PartsOfSpeechExamples.Clothing.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Clothing;
            }
        }
        private static string[] PluralClothing
        {
            get
            {
                if (_PluralClothing == null) { _PluralClothing = PartsOfSpeechExamples.ClothingPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralClothing;
            }
        }
        private static string[] Colors
        {
            get
            {
                if (_Colors == null)
                {
                    _Colors = PartsOfSpeechExamples.Colors.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Colors;
            }
        }
        private static string[] Concepts
        {
            get
            {
                if (_Concepts == null) { _Concepts = PartsOfSpeechExamples.Concepts.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Concepts;
            }
        }
        private static string[] Containers
        {
            get
            {
                if (_Containers == null) { _Containers = PartsOfSpeechExamples.Containers.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Containers;
            }
        }
        private static string[] Countries
        {
            get
            {
                if (_Countries == null) { _Countries = PartsOfSpeechExamples.Countries.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Countries;
            }
        }
        private static string[] Diseases
        {
            get
            {
                if (_Diseases == null) { _Diseases = PartsOfSpeechExamples.Diseases.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Diseases;
            }
        }
        private static string[] Exclamations
        {
            get
            {
                if (_Exclamations == null) { _Exclamations = PartsOfSpeechExamples.Exclamations.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Exclamations;
            }
        }
        private static string[] FamousPeople
        {
            get
            {
                if (_FamousPeople == null) { _FamousPeople = PartsOfSpeechExamples.FamousPeople.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _FamousPeople;
            }
        }
        private static string[] FemaleCelebrities
        {
            get
            {
                if (_FemaleCelebrities == null) { _FemaleCelebrities = PartsOfSpeechExamples.FemaleCelebrities.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _FemaleCelebrities;
            }
        }
        private static string[] Foods
        {
            get
            {
                if (_Foods == null)
                {
                    _Foods = PartsOfSpeechExamples.Foods.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Foods;
            }
        }
        private static string[] PluralFoods
        {
            get
            {
                if (_PluralFoods == null) { _PluralFoods = PartsOfSpeechExamples.FoodsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralFoods;
            }
        }
        private static string[] FirstNames
        {
            get
            {
                if (_FirstNames == null) { _FirstNames = PartsOfSpeechExamples.FirstNames.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _FirstNames;
            }
        }
        private static string[] Fruits
        {
            get
            {
                if (_Fruits == null) { _Fruits = PartsOfSpeechExamples.Fruits.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Fruits;
            }
        }
        private static string[] PluralFruits
        {
            get
            {
                if (_PluralFruits == null) { _PluralFruits = PartsOfSpeechExamples.FruitsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralFruits;
            }
        }
        private static string[] Furniture
        {
            get
            {
                if (_Furniture == null) { _Furniture = PartsOfSpeechExamples.Furniture.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Furniture;
            }
        }
        private static string[] Games
        {
            get
            {
                if (_Games == null) { _Games = PartsOfSpeechExamples.Games.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Games;
            }
        }
        private static string[] GeographicalLocations
        {
            get
            {
                if (_GeographicalLocations == null) { _GeographicalLocations = PartsOfSpeechExamples.GeographicalLocations.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _GeographicalLocations;
            }
        }
        private static string[] Holidays
        {
            get
            {
                if (_Holidays == null) { _Holidays = PartsOfSpeechExamples.Holidays.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Holidays;
            }
        }
        private static string[] HouseRooms
        {
            get
            {
                if (_HouseRooms == null) { _HouseRooms = PartsOfSpeechExamples.HouseRooms.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _HouseRooms;
            }
        }
        private static string[] IckySomethings
        {
            get
            {
                if (_IckySomethings == null) { _IckySomethings = PartsOfSpeechExamples.IckySomethings.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _IckySomethings;
            }
        }
        private static string[] ItalianWords
        {
            get
            {
                if (_ItalianWords == null) { _ItalianWords = PartsOfSpeechExamples.ItalianWords.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _ItalianWords;
            }
        }
        private static string[] LastNames
        {
            get
            {
                if (_LastNames == null) { _LastNames = PartsOfSpeechExamples.LastNames.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _LastNames;
            }
        }
        private static string[] Letters
        {
            get
            {
                if (_Letters == null) { _Letters = PartsOfSpeechExamples.Letters.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Letters;
            }
        }
        private static string[] Liquids
        {
            get
            {
                if (_Liquids == null)
                {
                    _Liquids = PartsOfSpeechExamples.Liquids.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Liquids;
            }
        }
        private static string[] MaleCelebrities
        {
            get
            {
                if (_MaleCelebrities == null) { _MaleCelebrities = PartsOfSpeechExamples.MaleCelebrities.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _MaleCelebrities;
            }
        }
        private static string[] MovieStars
        {
            get
            {
                if (_MovieStars == null) { _MovieStars = PartsOfSpeechExamples.MovieStars.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _MovieStars;
            }
        }
        private static string[] Names
        {
            get
            {
                if (_Names == null) { _Names = PartsOfSpeechExamples.Names.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Names;
            }
        }
        private static string[] NonsenseWords
        {
            get
            {
                if (_NonsenseWords == null) { _NonsenseWords = PartsOfSpeechExamples.NonsenseWords.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _NonsenseWords;
            }
        }
        private static string[] Occupations
        {
            get
            {
                if (_Occupations == null)
                {
                    _Occupations = PartsOfSpeechExamples.Occupations.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Occupations;
            }
        }
        private static string[] PluralOccupations
        {
            get
            {
                if (_PluralOccupations == null) { _PluralOccupations = PartsOfSpeechExamples.OccupationsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralOccupations;
            }
        }
        private static string[] PartsOfBody
        {
            get
            {
                if (_PartsOfBody == null)
                {
                    _PartsOfBody = PartsOfSpeechExamples.PartsOfBody.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _PartsOfBody;
            }
        }
        private static string[] PluralBodyParts
        {
            get
            {
                if (_PluralPartsOfBody == null) { _PluralPartsOfBody = PartsOfSpeechExamples.PartsOfBodyPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralPartsOfBody;
            }
        }
        private static string[] Places
        {
            get
            {
                if (_Places == null)
                {
                    _Places = PartsOfSpeechExamples.Places.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _Places;
            }
        }
        private static string[] Relatives
        {
            get
            {
                if (_Relatives == null) { _Relatives = PartsOfSpeechExamples.Relatives.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Relatives;
            }
        }
        private static string[] RoundSomethings
        {
            get
            {
                if (_RoundSomethings == null) { _RoundSomethings = PartsOfSpeechExamples.RoundSomethings.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _RoundSomethings;
            }
        }
        private static string[] Schools
        {
            get
            {
                if (_Schools == null) { _Schools = PartsOfSpeechExamples.SchoolNames.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Schools;
            }
        }
        private static string[] SillyNoises
        {
            get
            {
                if (_SillyNoises == null) { _SillyNoises = PartsOfSpeechExamples.SillyNoises.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _SillyNoises;
            }
        }
        private static string[] SillyWords
        {
            get
            {
                if (_SillyWords == null)
                {
                    _SillyWords = PartsOfSpeechExamples.SillyWords.Split(new string[] { ", " }, StringSplitOptions.None);
                }
                return _SillyWords;
            }
        }
        private static string[] PluralSillyWords
        {
            get
            {
                if (_PluralSillyWords == null) { _PluralSillyWords = PartsOfSpeechExamples.SillyWordsPlural.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _PluralSillyWords;
            }
        }
        private static string[] SpanishWords
        {
            get
            {
                if (_SpanishWords == null) { _SpanishWords = PartsOfSpeechExamples.SpanishWords.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _SpanishWords;
            }
        }
        private static string[] Sports
        {
            get
            {
                if (_Sports == null) { _Sports = PartsOfSpeechExamples.Sports.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Sports;
            }
        }
        private static string[] Towns
        {
            get
            {
                if (_Towns == null) { _Towns = PartsOfSpeechExamples.Towns.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Towns;
            }
        }
        private static string[] TVActors
        {
            get
            {
                if (_TVActors == null) { _TVActors = PartsOfSpeechExamples.TVActors.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _TVActors;
            }
        }
        private static string[] Vegetables
        {
            get
            {
                if (_Vegetables == null) { _Vegetables = PartsOfSpeechExamples.Vegetables.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Vegetables;
            }
        }
        private static string[] Vehicles
        {
            get
            {
                if (_Vehicles == null) { _Vehicles = PartsOfSpeechExamples.Vehicles.Split(new string[] { ", " }, StringSplitOptions.None); }
                return _Vehicles;
            }
        }

        #endregion

        public static IEnumerable<string> RetrieveExampleList(string word) {
            word = word.ToLower();
            if (!word.StartsWith("something"))
            {
                if (word.StartsWith("the title") || word.StartsWith("a title"))
                {
                    word = word.Replace("the title ", string.Empty).Replace("a title ", string.Empty);
                }
                else
                {
                    Regex firstWordRegex = new Regex(@"^\w+ ");
                    word = firstWordRegex.Replace(word, "");
                    word = word.Replace("type of ", string.Empty);
                    word = word.Replace("kind of ", string.Empty);
                }
            }
            switch (word)
            {
                case "noun":
                    return Nouns.Take(3);
                case "adjective":
                    return Adjectives.Take(3);
                case "plural noun":
                case "noun (plural)":
                    return PluralNouns.Take(3);
                case "verb":
                    return Verbs.Take(3);
                case "number":
                    Random rand = new Random();
                    return new List<string>() { rand.Next(1, 999).ToString(), rand.Next(1, 999).ToString(), rand.Next(1, 999).ToString() };
                case @"verb ending in ""ing""":
                    return GerundVerbs.Take(3);
                case "adverb":
                    return Adverbs.Take(3);
                case "part of the body":
                case "body part":
                    return PartsOfBody.Take(3);
                case "liquid":
                    return Liquids.Take(3);
                case "place":
                    return Places.Take(3);
                case "animal":
                    return Animals.Take(3);
                case "food":
                    return Foods.Take(3);
                case "color":
                    return Colors.Take(3);
                case "verb (past tense)":
                    return PastTenseVerbs.Take(3);
                case "celebrity":
                    return Celebrities.Take(3);
                case "exclamation":
                    return Exclamations.Take(3);
                case "part of the body (plural)":
                case "body part (plural)":
                    return PluralBodyParts.Take(3);
                case "silly word":
                    return SillyWords.Take(3);
                case "animal (plural)":
                    return PluralAnimals.Take(3);
                case "city":
                    return Cities.Take(3);
                case "nonsense word":
                    return NonsenseWords.Take(3);
                case "famous person":
                    return FamousPeople.Take(3);
                case "article of clothing":
                    return Clothing.Take(3);
                case "vehicle":
                    return Vehicles.Take(3);
                case "something alive (plural)":
                    return PluralAliveSomethings.Take(3);
                case "geographical location":
                    return GeographicalLocations.Take(3);
                case "town":
                    return Towns.Take(3);
                case "country":
                    return Countries.Take(3);
                case "container":
                    return Containers.Take(3);
                case "last name":
                    return LastNames.Take(3);
                case "name":
                    return Names.Take(3);
                case @"verb ending in ""s""":
                    return VerbsEndingInS.Take(3);
                case "occupation":
                case "occupation or job":
                case "profession":
                    return Occupations.Take(3);
                case "silly noise":
                    return SillyNoises.Take(3);
                case "male celebrity":
                case "celebrity (male)":
                    return MaleCelebrities.Take(3);
                case "article of clothing (plural)":
                    return PluralClothing.Take(3);
                case "name of a school":
                case "school":
                    return Schools.Take(3);
                case "building":
                    return Buildings.Take(3);
                case "bird":
                    return Birds.Take(3);
                case @"adjective ending in ""est""":
                case "adjective (superlative)":
                    return Superlatives.Take(3);
                case "letter":
                    return Letters.Take(3);
                case "game":
                    return Games.Take(3);
                case "holiday":
                    return Holidays.Take(3);
                case "silly word (plural)":
                    return PluralSillyWords.Take(3);
                case "something round":
                    return RoundSomethings.Take(3);
                case "piece of furniture":
                    return Furniture.Take(3);
                case "vegetable":
                    return Vegetables.Take(3);
                case "spanish word":
                    return SpanishWords.Take(3);
                case "tv actor":
                    return TVActors.Take(3);
                case "boy's name":
                    return BoyNames.Take(3);
                case "something alive":
                    return AliveSomethings.Take(3);
                case "female celebrity":
                case "celebrity (female)":
                    return FemaleCelebrities.Take(3);
                case "italian word":
                    return ItalianWords.Take(3);
                case "occupation (plural)":
                    return PluralOccupations.Take(3);
                case "first name":
                    return FirstNames.Take(3);
                case "room in a house":
                    return HouseRooms.Take(3);
                case "relative":
                    return Relatives.Take(3);
                case "movie star":
                    return MovieStars.Take(3);
                case "disease":
                    return Diseases.Take(3);
                case "sport":
                    return Sports.Take(3);
                case "something icky":
                    return IckySomethings.Take(3);
                case "actor":
                    return Actors.Take(3);
                case "concept or ideal":
                    return Concepts.Take(3);
                default:
                    return new string[3] { string.Empty, string.Empty, string.Empty };
            }
        }

        public static string RetrieveSuggestedWord(string word)
        {
            word = word.ToLower();
            if (!word.StartsWith("something"))
            {
                Regex firstWordRegex = new Regex(@"^\w+ ");
                word = firstWordRegex.Replace(word, "");
                word = word.Replace("type of ", string.Empty);
                word = word.Replace("kind of ", string.Empty);
            }

            Random rand = new Random();
            switch (word)
            {
                case "noun":
                    return Nouns[rand.Next(3, Nouns.Length)];
                case "adjective":
                    return Adjectives[rand.Next(3, Adjectives.Length)];
                case "plural noun":
                case "noun (plural)":
                    return PluralNouns[rand.Next(3, PluralNouns.Length)];
                case "verb":
                    return Verbs[rand.Next(3, Verbs.Length)];
                case "number":
                    return rand.Next(1, 999).ToString();
                case @"verb ending in ""ing""":
                    return GerundVerbs[rand.Next(3, GerundVerbs.Length)];
                case "adverb":
                    return Adverbs[rand.Next(3, Adverbs.Length)];
                case "part of the body":
                case "body part":
                    return PartsOfBody[rand.Next(3, PartsOfBody.Length)];
                case "liquid":
                    return Liquids[rand.Next(3, Liquids.Length)];
                case "place":
                    return Places[rand.Next(3, Places.Length)];
                case "animal":
                    return Animals[rand.Next(3, Animals.Length)];
                case "food":
                    return Foods[rand.Next(3, Foods.Length)];
                case "color":
                    return Colors[rand.Next(3, Colors.Length)];
                case "verb (past tense)":
                    return PastTenseVerbs[rand.Next(3, PastTenseVerbs.Length)];
                case "celebrity":
                    return Celebrities[rand.Next(3, Celebrities.Length)];
                case "exclamation":
                    return Exclamations[rand.Next(3, Exclamations.Length)];
                case "part of the body (plural)":
                case "body part (plural)":
                    return PluralBodyParts[rand.Next(3, PluralBodyParts.Length)];
                case "silly word":
                    return SillyWords[rand.Next(3, SillyWords.Length)];
                case "animal (plural)":
                    return PluralAnimals[rand.Next(3, PluralAnimals.Length)];
                case "city":
                    return Cities[rand.Next(3, Cities.Length)];
                case "nonsense word":
                    return NonsenseWords[rand.Next(3, NonsenseWords.Length)];
                case "famous person":
                    return FamousPeople[rand.Next(3, FamousPeople.Length)];
                case "article of clothing":
                    return Clothing[rand.Next(3, Clothing.Length)];
                case "vehicle":
                    return Vehicles[rand.Next(3, Vehicles.Length)];
                case "something alive (plural)":
                    return PluralAliveSomethings[rand.Next(3, PluralAliveSomethings.Length)];
                case "geographical location":
                    return GeographicalLocations[rand.Next(3, GeographicalLocations.Length)];
                case "town":
                    return Towns[rand.Next(3, Towns.Length)];
                case "country":
                    return Countries[rand.Next(3, Countries.Length)];
                case "container":
                    return Containers[rand.Next(3, Containers.Length)];
                case "last name":
                    return LastNames[rand.Next(3, LastNames.Length)];
                case "name":
                    return Names[rand.Next(3, Names.Length)];
                case @"verb ending in ""s""":
                    return VerbsEndingInS[rand.Next(3, VerbsEndingInS.Length)];
                case "occupation":
                case "occupation or job":
                case "profession":
                    return Occupations[rand.Next(3, Occupations.Length)];
                case "silly noise":
                    return SillyNoises[rand.Next(3, SillyNoises.Length)];
                case "male celebrity":
                case "celebrity (male)":
                    return MaleCelebrities[rand.Next(3, MaleCelebrities.Length)];
                case "article of clothing (plural)":
                    return PluralClothing[rand.Next(3, FemaleCelebrities.Length)];
                case "name of a school":
                case "school":
                    return Schools[rand.Next(3, Schools.Length)];
                case "building":
                    return Buildings[rand.Next(3, Buildings.Length)];
                case "bird":
                    return Birds[rand.Next(3, Birds.Length)];
                case @"adjective ending in ""est""":
                case "adjective (superlative)":
                    return Superlatives[rand.Next(3, Superlatives.Length)];
                case "letter":
                    return Letters[rand.Next(3, Letters.Length)];
                case "game":
                    return Games[rand.Next(3, Games.Length)];
                case "holiday":
                    return Holidays[rand.Next(3, Holidays.Length)];
                case "silly word (plural)":
                    return PluralSillyWords[rand.Next(3, PluralSillyWords.Length)];
                case "something round":
                    return RoundSomethings[rand.Next(3, RoundSomethings.Length)];
                case "piece of furniture":
                    return Furniture[rand.Next(3, Furniture.Length)];
                case "vegetable":
                    return Vegetables[rand.Next(3, Vegetables.Length)];
                case "spanish word":
                    return SpanishWords[rand.Next(3, SpanishWords.Length)];
                case "tv actor":
                    return TVActors[rand.Next(3, TVActors.Length)];
                case "boy's name":
                    return BoyNames[rand.Next(3, BoyNames.Length)];
                case "something alive":
                    return AliveSomethings[rand.Next(3, AliveSomethings.Length)];
                case "female celebrity":
                case "celebrity (female)":
                    return FemaleCelebrities[rand.Next(3, FemaleCelebrities.Length)];
                case "italian word":
                    return ItalianWords[rand.Next(3, ItalianWords.Length)];
                case "occupation (plural)":
                    return PluralOccupations[rand.Next(3, PluralOccupations.Length)];
                case "first name":
                    return FirstNames[rand.Next(3, FirstNames.Length)];
                case "room in a house":
                    return HouseRooms[rand.Next(3, HouseRooms.Length)];
                case "relative":
                    return Relatives[rand.Next(3, Relatives.Length)];
                case "movie star":
                    return MovieStars[rand.Next(3, MovieStars.Length)];
                case "disease":
                    return Diseases[rand.Next(3, Diseases.Length)];
                case "sport":
                    return Sports[rand.Next(3, Sports.Length)];
                case "something icky":
                    return IckySomethings[rand.Next(3, IckySomethings.Length)];
                case "actor":
                    return Actors[rand.Next(3, Actors.Length)];
                case "concept or ideal":
                    return Concepts[rand.Next(3, Concepts.Length)];
                default:
                    return string.Empty;
            }
        }
    }
}
