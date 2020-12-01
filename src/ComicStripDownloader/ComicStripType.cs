using System;
using System.Collections.Generic;
using System.Linq;

namespace ComicStripDownloader
{
    public class ComicStripType
    {
        public string Name { get; private set; }
        public string Key { get; private set; }
        public string Url { get; private set; }
        public string Parameter { get; private set; }
        public string HtmlImageClass { get; private set; }
        public bool IsInChildNodes { get; private set; }

        public static readonly ComicStripType AndyCapp = new ComicStripType("Andy Capp", nameof(AndyCapp), "https://www.gocomics.com/andycapp/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType BackToBC = new ComicStripType("Back to B.C.", nameof(BackToBC), "https://www.gocomics.com/back-to-bc/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType BC = new ComicStripType("B.C.", nameof(BC), "https://www.gocomics.com/bc/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType BigNate = new ComicStripType("Big Nate", nameof(BigNate), "https://www.gocomics.com/bignate/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType BigNateFirstClass = new ComicStripType("Big Nate: First Class", nameof(BigNateFirstClass), "https://www.gocomics.com/big-nate-first-class/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType BroomHilda = new ComicStripType("Broom Hilda", nameof(BroomHilda), "https://www.gocomics.com/broomhilda/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType CalvinAndHobbes = new ComicStripType("Calvin and Hobbes", nameof(CalvinAndHobbes), "https://www.gocomics.com/calvinandhobbes/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType CathyClassics = new ComicStripType("Cathy Classics", nameof(CathyClassics), "https://www.gocomics.com/cathy/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType CulDeSac = new ComicStripType("Cul de Sac", nameof(CulDeSac), "https://www.gocomics.com/culdesac/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Dilbert = new ComicStripType("Dilbert", nameof(Dilbert), "https://dilbert.com/strip/{0}", "yyyy-MM-dd", "//img[contains(@class, 'img-comic')]", false);
        public static readonly ComicStripType DilbertClassics = new ComicStripType("Dilbert Classics", nameof(DilbertClassics), "https://www.gocomics.com/dilbert-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Doonesbury = new ComicStripType("Doonesbury", nameof(Doonesbury), "https://www.gocomics.com/doonesbury/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType EyebeamClassic = new ComicStripType("Eyebeam Classic", nameof(EyebeamClassic), "https://www.gocomics.com/eyebeam-classic/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType ForBetterOrForWorse = new ComicStripType("For Better or For Worse", nameof(ForBetterOrForWorse), "https://www.gocomics.com/forbetterorforworse/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType FoxTrotClassics = new ComicStripType("FoxTrot Classics", nameof(FoxTrotClassics), "https://www.gocomics.com/foxtrotclassics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType FrankAndErnest = new ComicStripType("Frank and Ernest", nameof(FrankAndErnest), "https://www.gocomics.com/frank-and-ernest/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Frazz = new ComicStripType("Frazz", nameof(Frazz), "https://www.gocomics.com/frazz/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType FreeRange = new ComicStripType("Free Range", nameof(FreeRange), "https://www.gocomics.com/freerange/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Gardfield = new ComicStripType("Gardfield", nameof(Gardfield), "https://www.gocomics.com/garfield/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType GardfieldClassics = new ComicStripType("Gardfield Classics", nameof(GardfieldClassics), "https://www.gocomics.com/garfield-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Geech = new ComicStripType("Geech", nameof(Geech), "https://www.gocomics.com/geech/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType GetFuzzy = new ComicStripType("Get Fuzzy", nameof(GetFuzzy), "https://www.gocomics.com/getfuzzy/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType HeartOfTheCity = new ComicStripType("Heart of the City", nameof(HeartOfTheCity), "https://www.gocomics.com/heartofthecity/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Herman = new ComicStripType("Herman", nameof(Herman), "https://www.gocomics.com/herman/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Luann = new ComicStripType("Luann", nameof(Luann), "https://www.gocomics.com/luann/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType LuannAgainn = new ComicStripType("Luann Againn", nameof(LuannAgainn), "https://www.gocomics.com/luann-againn/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType MuttAndJeff = new ComicStripType("Mutt and Jeff", nameof(MuttAndJeff), "https://www.gocomics.com/muttandjeff/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType NancyClassics = new ComicStripType("Nancy Classics", nameof(NancyClassics), "https://www.gocomics.com/nancy-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType NonSequitur = new ComicStripType("Non Sequitur", nameof(NonSequitur), "https://www.gocomics.com/nonsequitur/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Peanuts = new ComicStripType("Peanuts", nameof(Peanuts), "https://www.gocomics.com/peanuts/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType PeanutsBegins = new ComicStripType("Peanuts Begins", nameof(PeanutsBegins), "https://www.gocomics.com/peanuts-begins/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType PearlsBeforeSwine = new ComicStripType("Pearls Before Swine", nameof(PearlsBeforeSwine), "https://www.gocomics.com/pearlsbeforeswine/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType PhoebeAndHerUnicorn = new ComicStripType("Phoebe and Her Unicorn", nameof(PhoebeAndHerUnicorn), "https://www.gocomics.com/phoebe-and-her-unicorn/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Pickles = new ComicStripType("Pickles", nameof(Pickles), "https://www.gocomics.com/pickles/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType RudyPark = new ComicStripType("Rudy Park", nameof(RudyPark), "https://www.gocomics.com/rudypark/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType ShirleyAndSonClassics = new ComicStripType("Shirley and Son Classics", nameof(ShirleyAndSonClassics), "https://www.gocomics.com/shirley-and-son-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Skippy = new ComicStripType("Skippy", nameof(Skippy), "https://www.gocomics.com/skippy/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType StoneSoupClassics = new ComicStripType("Stone Soup Classics", nameof(StoneSoupClassics), "https://www.gocomics.com/stone-soup-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Tarzan = new ComicStripType("Tarzan", nameof(Tarzan), "https://www.gocomics.com/tarzan/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType TheKnightLife = new ComicStripType("The Knight Life", nameof(TheKnightLife), "https://www.gocomics.com/theknightlife/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType WallaceTheBrave = new ComicStripType("Wallace the Brave", nameof(WallaceTheBrave), "https://www.gocomics.com/wallace-the-brave/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType WizardOfId = new ComicStripType("Wizard of Id", nameof(WizardOfId), "https://www.gocomics.com/wizardofid/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType WizardOfIdClassics = new ComicStripType("Wizard of Id Classics", nameof(WizardOfIdClassics), "https://www.gocomics.com/wizard-of-id-classics/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");
        public static readonly ComicStripType Ziggy = new ComicStripType("Ziggy", nameof(Ziggy), "https://www.gocomics.com/ziggy/{0}", "yyyy/MM/dd", "//picture[@class='item-comic-image']");

        private ComicStripType(string name, string key, string url, string parameter, string htmlImageClass, bool isInChildNodes = true)
        {
            Name = name;
            Key = key;
            Url = url;
            Parameter = parameter;
            HtmlImageClass = htmlImageClass;
            IsInChildNodes = isInChildNodes;
        }

        private static T ThrowException<T>(Exception ex) => throw ex;

        public static IReadOnlyCollection<ComicStripType> GetAll() =>
            new[] { AndyCapp, BackToBC, BC, BigNate, BigNateFirstClass, BroomHilda, CalvinAndHobbes, CathyClassics, CulDeSac, Dilbert, DilbertClassics, Doonesbury,
                    EyebeamClassic, ForBetterOrForWorse, FoxTrotClassics, FrankAndErnest, Frazz, FreeRange, Gardfield, GardfieldClassics, Geech, GetFuzzy, HeartOfTheCity,
                    Herman, Luann, LuannAgainn, MuttAndJeff, NancyClassics, NonSequitur, Peanuts, PeanutsBegins, PearlsBeforeSwine, PhoebeAndHerUnicorn, Pickles, RudyPark,
                    ShirleyAndSonClassics, Skippy, StoneSoupClassics, Tarzan, TheKnightLife, WallaceTheBrave, WizardOfId, WizardOfIdClassics, Ziggy };

        public static ComicStripType FindBy(string key) =>
            GetAll().SingleOrDefault(s => s.Key == key) ?? ThrowException<ComicStripType>(new KeyNotFoundException($"'{key}' not found"));
    }
}