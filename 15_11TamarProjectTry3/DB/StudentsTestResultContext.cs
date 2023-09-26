using _15_11TamarProjectTry3.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15_11TamarProjectTry3.DB
{
    public class StudentsTestResultContext:DbContext
    {
        public int _counter { get; set; }
        public StudentsTestResultContext(DbContextOptions<StudentsTestResultContext> options):base(options)
        {
            _counter = 1;
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<QuizResult> QuizResults{ get; set; }
        public DbSet<QuestionOnTest> QuestionOnTests{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionOnTest>().HasData(
                new { Id = _counter++, CorrectAnswer= "see"        ,Question = "Li and her grandmother __________ one another at least once a day. ", VerbToChange = "(see)" },
                new { Id = _counter++, CorrectAnswer= "live"            , Question = "Cows live about 15 years, while elephants _______ to be about as old as humans ", VerbToChange = "(live)" },
                new { Id = _counter++, CorrectAnswer= "think"                    , Question = "I can tell by the look on your face that you _________the same thing I do.", VerbToChange = "(think)" },
                new { Id = _counter++, CorrectAnswer= "claim"                    , Question = "Many experiments ___________ that colors affect our mood.", VerbToChange = "(claim)" },
                new { Id = _counter++, CorrectAnswer= "consider"                    , Question = "Although many scientists do not _________ color therapy a science, advertisers do.", VerbToChange = "(consider)" },
                new { Id = _counter++, CorrectAnswer= "come"                    , Question = "When my mother can’t give me a ride, I usually __________ to school by bus.", VerbToChange = "(come)" },
                new { Id = _counter++, CorrectAnswer= "think"                    , Question = "Most students in the college ___________ that the history course is very good.", VerbToChange = "(think)" },
                new { Id = _counter++, CorrectAnswer= "protect"                    , Question = "If you want to maintain your health, you should _______your skin against the sun. ", VerbToChange = "(protect)" },
                new { Id = _counter++, CorrectAnswer= "play"                    , Question = "Today, many people ____________ tennis which is known as the sport of kings. ", VerbToChange = "(play)" },
                new { Id = _counter++, CorrectAnswer= "read"                    , Question = "They ___________ two books every month to enhance their academic writing skills. ", VerbToChange = "(read)" },
                new { Id = _counter++, CorrectAnswer= "happened"                    , Question = "What __________ at the board of directors’ meeting ? ", VerbToChange = "(happen)" },
                new { Id = _counter++, CorrectAnswer= "enjoyed"                    , Question = "I really ___________ your birthday party last night ", VerbToChange = "enjoy)" },
                new { Id = _counter++, CorrectAnswer= "copied"                    , Question = "He __________ the information into his notebook, last week. ", VerbToChange = "(copy)" },
                new { Id = _counter++, CorrectAnswer= "ordered"                    , Question = "Jonathan ____________ vanilla ice cream yesterday. ", VerbToChange = "(order)" },
                new { Id = _counter++, CorrectAnswer= "preferred"                    , Question = "I _____________ the color blue, when I chose balloons. ", VerbToChange = "(prefer)" },
                new { Id = _counter++, CorrectAnswer= "stopped"                    , Question = "The policeman ______________ the truck that was traveling dangerously. ", VerbToChange = "(stop)" },
                new { Id = _counter++, CorrectAnswer= "stored"                    , Question = "Benny ______________ the milk back in the fridge yesterday after dinner ", VerbToChange = "(store)" },
                new { Id = _counter++, CorrectAnswer= "dove"                    , Question = "Sharona ________ into the sea and saved the drowning dog. ", VerbToChange = "(dive)" },
                new { Id = _counter++, CorrectAnswer= "preferred"                    , Question = "I wanted to go to old Yaffo, but my friend___________ to go to Tel Aviv. ", VerbToChange = "(prefer)" },
                new { Id = _counter++, CorrectAnswer= "played"                    , Question = "When Eitan was younger, he __________ a lot of football. ", VerbToChange = "(play)" },
                new { Id = _counter++, CorrectAnswer= "was destroyed"                    , Question = "The oldest house in the neighborhood _______________ by the fire, last year. ", VerbToChange = "(destroy)" },
                new { Id = _counter++, CorrectAnswer= "was discovered"                    , Question = "Radium ___________ by the well-known scientist Marie Curie in 1898. ", VerbToChange = "(discover)" },
                new { Id = _counter++, CorrectAnswer= "was written"                    , Question = "The movie 'West Side Story' _____________ by  Leonard Bernstein. ", VerbToChange = "(write)" },
                new { Id = _counter++, CorrectAnswer= "are sold"                    , Question = "Different newspapers and magazines _____________ in our supermarket every day. ", VerbToChange = "(sell)" },
                new { Id = _counter++, CorrectAnswer= "will be chosen"                    , Question = "I wonder who ____________as United States President in the next elections. ", VerbToChange = "(choose)" },
                new { Id = _counter++, CorrectAnswer= "will be checked"                    , Question = "All the mathematics tests ____________ by this time tomorrow. ", VerbToChange = "(check)" },
                new { Id = _counter++, CorrectAnswer= "are being fed"                    , Question = "The cute babies ___________now.Please do not disturb them. ", VerbToChange = "(feed)" },
                new { Id = _counter++, CorrectAnswer= "is sent"                    , Question = "Food__________ to the starving refugees in African countries every week. ", VerbToChange = "(send)" },
                new { Id = _counter++, CorrectAnswer= "was being fixed"                    , Question = "The car ____________ when I called the mechanics at the garage. ", VerbToChange = "(fix)" },
                new { Id = _counter++, CorrectAnswer= "are being informed"                    , Question = "The police officers ___________of the crime at the moment.", VerbToChange = "(inform)" },
                new { Id = _counter++, CorrectAnswer= "eats", SecondCorrectAnswer = "will gain", Question = "If David _____(eat) too much ice cream, he __________(gain) a lot of weight.", VerbToChange = "(eat)", SecondVerbToChange = "(gain)" },
                new { Id = _counter++, CorrectAnswer= "does not come", SecondCorrectAnswer = "will miss", Question = "If Shira _____________(not come) soon, she __________(miss) the movie.", VerbToChange = "(not come)", SecondVerbToChange = "(miss)" },
                new { Id = _counter++, CorrectAnswer= "helps", SecondCorrectAnswer = "will finish", Question = "If Yoav ___________(help) me, I ___________(finish) this work on time.", VerbToChange = "(help)", SecondVerbToChange = "(finish)" },
                new { Id = _counter++, CorrectAnswer= "smoke", SecondCorrectAnswer = " will get", Question = "If you ________(smoke) too much, you ____________(get)a bad cough.", VerbToChange = "(smoke)", SecondVerbToChange = "(get)" },
                new { Id = _counter++, CorrectAnswer= "will go", SecondCorrectAnswer = "stops", Question = "We ____________(go) out to play outside if it _________(stop) raining.", VerbToChange = "(go)", SecondVerbToChange = "(stop)" },
                new { Id = _counter++, CorrectAnswer= "work", SecondCorrectAnswer = " will get", Question = "If you ______________(work) hard, you ____________(get) a good grade.", VerbToChange = "(work)", SecondVerbToChange = "(get)" },
                new { Id = _counter++, CorrectAnswer= "will burn"                    , Question = "Be careful! If you touch the hot stove, you _________(burn) yourself.", VerbToChange = "(burn)" },
                new { Id = _counter++, CorrectAnswer= "will be", SecondCorrectAnswer = "wait", Question = "The cinema ___________(be) full if we __________(wait) too much time outside.", VerbToChange = "(be)", SecondVerbToChange = "(wait)" },
                new { Id = _counter++, CorrectAnswer= "dislike", SecondCorrectAnswer = "will lose", Question = "If you ___________(dislike) the boss's suggestion, you _________(lose) your job!", VerbToChange = "(dislike)", SecondVerbToChange = "(lose)" },
                new { Id = _counter++, CorrectAnswer= "will forgiv", SecondCorrectAnswer = "apologize", Question = "I ___________(forgive) you, if you ___________ publicly(apologize) to me.", VerbToChange = "(forgive)", SecondVerbToChange = "(apologize)" },
                new { Id = _counter++, CorrectAnswer= "wears"                    , Question = "Rina __________ her red sandals in the hot summer days. ", VerbToChange = "(wear)" },
                new { Id = _counter++, CorrectAnswer= "goes"                    , Question = "Yael ___________ shopping at the mall at least once a week. ", VerbToChange = "(go)" },
                new { Id = _counter++, CorrectAnswer= "flies"                    , Question = "My uncle is an experienced pilot.He ___________ all over the world .", VerbToChange = "(fly)" },
                new { Id = _counter++, CorrectAnswer= "fixes"                    , Question = "Mr.Benny, our neighbor, ________ his old sport car weekly. ", VerbToChange = "(fix)" },
                new { Id = _counter++, CorrectAnswer= "rains"                    , Question = "In middle eastern countries, it usually________ a lot in the winter. ", VerbToChange = "(rain)" },
                new { Id = _counter++, CorrectAnswer= "comes"                    , Question = "Sam _________ to our house on Thursdays to play with my brother. ", VerbToChange = "(come)" },
                new { Id = _counter++, CorrectAnswer= "tries"                    , Question = "Ronit always ____________ to do her math homework by herself.", VerbToChange = "(try)" },
                new { Id = _counter++, CorrectAnswer= "has"                    , Question = "Liron ___________lunch at the cafeteria at one o'clock every day. ", VerbToChange = "(have)" },
                new { Id = _counter++, CorrectAnswer= "drinks"                    , Question = "Dan ___________coffee twice a day, in the morning and in the afternoon.", VerbToChange = "(drink)" },
                new { Id = _counter++, CorrectAnswer= "closes"                    , Question = "The nearest shopping center __________ at seven o'clock in the evening. ", VerbToChange = "(close)" },
                new { Id = _counter++, CorrectAnswer= "has not arrived"                    , Question = "Mr.Cohen, our manager, ___________ at his office yet. ", VerbToChange = "(not arrive)" },
                new { Id = _counter++, CorrectAnswer= "have been"                    , Question = "I ____________ at the waiting room for over half an hour. ", VerbToChange = "(be)" },
                new { Id = _counter++, CorrectAnswer= "have been living"                    , Question = "My grandparents ___________ in the country for many years. ", VerbToChange = "(live)" },
                new { Id = _counter++, CorrectAnswer= "has not learned"                    , Question = "Fifteen - year - old David __________________to swim yet. ", VerbToChange = "(not learn)" },
                new { Id = _counter++, CorrectAnswer= "has not"                    , Question = "He ___________ the award - winning Hollywood movie yet. ", VerbToChange = "(not see)" },
                new { Id = _counter++, CorrectAnswer= "has taught"                    , Question = "Mrs.Shani ____________ English at our school for over six years.", VerbToChange = "(teach)" },
                new { Id = _counter++, CorrectAnswer= "have known"                    , Question = "We ____________ each other personally since August of 2015. ", VerbToChange = "(know)" },
                new { Id = _counter++, CorrectAnswer= "have had", Question = "We _____________ our Labrador retriever since he was a puppy.", VerbToChange = "(have)" },
                new { Id = _counter++, CorrectAnswer= "have loved"                    , Question = "I __________18th century folk and country music since I was a child. ", VerbToChange = "(love)" },
                new { Id = _counter++, CorrectAnswer= "has driven"                    , Question = "The company’s manager _________a hybrid car for many years. ", VerbToChange = "(drive)" },
                new { Id = _counter++, CorrectAnswer= "apologized", SecondCorrectAnswer = "had forgotten", Question = "She ___________(apologize) to him because she ___________(forget) to call.", VerbToChange = "(apologize)", SecondVerbToChange = "(forget)" },
                new { Id = _counter++, CorrectAnswer= "saw", SecondCorrectAnswer = "had heard", Question = "I ___________(see) by his expression that he already __________(hear) the news.", VerbToChange = "(see)", SecondVerbToChange = "(hear)" },
                new { Id = _counter++, CorrectAnswer= "phoned", SecondCorrectAnswer = "had lost", Question = "Jim ____________(phone) me to say he ___________(lose) his wallet.", VerbToChange = "(phone)", SecondVerbToChange = "(lose)" },
                new { Id = _counter++, CorrectAnswer= "realized", SecondCorrectAnswer = "had been raining", Question = "By the wet streets, I ____________(realize) it ___________(rain) all night.", VerbToChange = "(realize)", SecondVerbToChange = "(rain)" },
                new { Id = _counter++, CorrectAnswer= "had finished", SecondCorrectAnswer = "strolled", Question = "When we ___________(finish) our meal, we __________(stroll) back to our hotel.", VerbToChange = "(finish)", SecondVerbToChange = "(stroll)" },
                new { Id = _counter++, CorrectAnswer= "had ended", SecondCorrectAnswer = "filled", Question = "By the time class _____________ (end), I __________(fill) my entire notebook.", VerbToChange = "(end)", SecondVerbToChange = "(fill)" },
                new { Id = _counter++, CorrectAnswer= "had finished", SecondCorrectAnswer = "cleaned", Question = "	We __________(finish) the job, so we ___________(clean) up the workshop.", VerbToChange = "(finish)", SecondVerbToChange = "(clean)" },
                new { Id = _counter++, CorrectAnswer= "arrived", SecondCorrectAnswer = "had left", Question = "	When she finally ____________(arrive), I ___________(leave) the office.", VerbToChange = "(arrive)", SecondVerbToChange = "(leave)" },
                new { Id = _counter++, CorrectAnswer= "was", SecondCorrectAnswer = "had stolen", Question = "	My car __________ (be) no longer outside because the thieves ________ (steal) it", VerbToChange = "(be)", SecondVerbToChange = "(steal)" },
                new { Id = _counter++, CorrectAnswer= "had given", SecondCorrectAnswer = "drove", Question = "	After the band _________ (give) a concert in Eilat, they _______ (drive) to TLV for another one", VerbToChange = "(give)", SecondVerbToChange = "(drive)" },
                new { Id = _counter++, CorrectAnswer= "are enjoying"                    , Question = "	We ________ this party.So stay a bit longer before we go home. ", VerbToChange = "(enjoy)" },
                new { Id = _counter++, CorrectAnswer= "is knitting"                    , Question = "	Shoshi _______ a beautiful cashmere sweater for herself now.", VerbToChange = "(knit)" },
                new { Id = _counter++, CorrectAnswer= "is lying"                    , Question = "	Anita _______on her queen bed.She is extremely tired.", VerbToChange = " (lie)" },
                new { Id = _counter++, CorrectAnswer= "is controlling"                    , Question = "	The Policewoman _____________ the traffic today.", VerbToChange = " (control)" },
                new { Id = _counter++, CorrectAnswer= "am reading"                    , Question = "	I ___________ an interesting book in English at the moment. ", VerbToChange = "(read)" },
                new { Id = _counter++, CorrectAnswer= "are leaving"                    , Question = "	The technicians __________ their home for work right now. ", VerbToChange = "(leave)" },
                new { Id = _counter++, CorrectAnswer= "are playing"                    , Question = "	The musician ___________ the piano.Everyone is listening. ", VerbToChange = "(play)" },
                new { Id = _counter++, CorrectAnswer= "is beginning"                    , Question = "	The film __________ right now.Please be quiet and do not disturb us. ", VerbToChange = "(begin)" },
                new { Id = _counter++, CorrectAnswer= "is not raining"                    , Question = "	It’s a beautiful day. The sun is shining.It ____________ .", VerbToChange = "(not rain)" },
                new { Id = _counter++, CorrectAnswer= "am eating"                    , Question = "	I can't come to the phone because I _________ breakfast now.", VerbToChange = " (eat)" },
                new { Id = _counter++, CorrectAnswer = "is opening"                     , Question = "The new Italian restaurant ____________ this coming season. (open)", VerbToChange = "(give)" },
                new { Id = _counter++, CorrectAnswer = "are giving"                     , Question = "We ____________ a party tonight in honor of our dear friend. ", VerbToChange = "(give)" }
);
            
        }
    }
}

