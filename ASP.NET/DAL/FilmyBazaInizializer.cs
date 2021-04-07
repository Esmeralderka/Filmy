using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Filmy.Models;
namespace Filmy.DAL
{
    public class FilmyBazaInizializer<T>:CreateDatabaseIfNotExists<FilmyContext>
    {
      
        protected override void Seed(FilmyContext context)
        {
            GatunekModels gatunek
                = new GatunekModels()
            {
                Nazwa = "Komediowy"
               
            };
            GatunekModels gatunek2
                = new GatunekModels()
                {
                    Nazwa = "Horrory"
                };
            GatunekModels gatunek3
                = new GatunekModels()
                {
                    Nazwa = "Dramat"
                };
            GatunekModels gatunek4
               = new GatunekModels()
               {
                   Nazwa = "Thriller"
               };
           
            GatunekModels gatunek6
               = new GatunekModels()
               {
                   Nazwa = "Akcji"
               };
            GatunekModels gatunek7
               = new GatunekModels()
               {
                   Nazwa = "Science-Fiction"
               };
          
            GatunekModels gatunek9
               = new GatunekModels()
               {
                   Nazwa = "Animowany"
               };





            //STUDIA
            StudioModels studio1
               = new StudioModels()
               {
                   Logo = "https://p1.hiclipart.com/preview/878/661/184/warner-bros-icon-wb-png-clipart-thumbnail.jpg",
                   Nazwa = "Warner Bros"
               };
            StudioModels studio2
              = new StudioModels()
              {
                  Logo = "https://i.pinimg.com/originals/80/e8/06/80e8063fd00b1d3cf5c6a388bf7dc201.png",
                  Nazwa = "Disney"
              };
            StudioModels studio3
            = new StudioModels()
            {
                Logo = "https://i.pinimg.com/originals/a8/fc/05/a8fc051d4df852b65f62199f093fe435.jpg",
                Nazwa = "Paramount Pictures"
            };
            StudioModels studio4
          = new StudioModels()
          {
              Logo = "https://static.hollywoodreporter.com/sites/default/files/2013/06/20th_Century_Fox_Logo_1953_1987.jpg",
              Nazwa = "20 Century Fox"
          };
            StudioModels studio5
         = new StudioModels()
         {
             Logo = "https://ef.com.au/wp-content/uploads/laurel-group-logo_500x250-01.jpg",
             Nazwa = "Laurel Group"
         };
            StudioModels studio6
           = new StudioModels()
           {
               Logo = "https://i.ytimg.com/vi/IldJ2xyuuk0/maxresdefault.jpg",
               Nazwa = "Uniwersal Pictures"
           };

            StudioModels studio7
           = new StudioModels()
           {
               Logo = "https://www.logodesignlove.com/images/identity/dc-entertainment-logo.jpg",
               Nazwa = " DC Comics"
           };


            //komedie
            FilmyModels fm = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 3,
                Tytul = "Szklanką po łapkach(1996)",
                Dlugosc = 81,
                Plakat = "https://fwcdn.pl/fpo/05/22/30522/7490271.3.jpg",
                Opis = "Agent specjalny Dick Steele powraca z emerytury, by pokrzyżować plany zagłady świata generałowi Rancorowi. "
            };
           

            FilmyModels fm3 = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 3,
                Tytul = "Czy leci z nami pilot? (1980)",
                Dlugosc = 88,
                Plakat = "https://fwcdn.pl/fpo/07/20/30720/7424431.3.jpg",
                Opis = "W związku z zatruciem załogi samolotu pasażerskiego były pilot wojskowy - Ted Striker - musi pokonać lęk przed lataniem i ponownie usiąść za sterami."
            };

            FilmyModels fm4 = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 3,
                Tytul = "Naga broń: Z akt Wydziału Specjalnego(1988)",
                Dlugosc = 85,
                Plakat = "https://image.ceneostatic.pl/data/products/119915/i-naga-bron-z-akt-wydzialu-specjalnego-the-naked-gun-from-the-files-of-police-squad-dvd.jpg",
                Opis = "Do USA przylatuje Królowa Elżbieta II. Porucznik Frank Drebin ma za zadanie zapewnić jej bezpieczeństwo. "
            };


            FilmyModels fm5 = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 3,
                Tytul = "Dracula - wampiry bez zębów (1995)",
                Dlugosc = 90,
                Plakat = "https://www.tekstowo.pl/upload/soundtracks/20986_big.jpg",
                Opis = "Dracula przybywa do Londynu, gdzie rzuca się w wir życia towarzyskiego wyższych sfer, zbierając krwawe żniwo. "
            };

            FilmyModels fm6 = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 1,
                Tytul = "Akademia Policyjna(1984)",
                Dlugosc = 96,
                Plakat = "https://fwcdn.pl/fpo/08/31/30831/6950367.3.jpg",
                Opis = "Decyzja pani burmistrz powoduje, że do miejscowej akademii policyjnej zgłasza się każdy chętny. Nowi, często niezbyt kompetentni kandydaci zostają poddani surowemu szkoleniu."
            };

            FilmyModels fm7 = new FilmyModels()
            {
                GatunekID = 1,
                StudioID = 1,
                Tytul = "Robin Hood: Faceci w rajtuzach (1993)",
                Dlugosc = 104,
                Plakat = "https://fwcdn.pl/fpo/13/40/31340/7098587.6.jpg",
                Opis = "Historia Robin Hooda na wesoło. Banita toczy walki z okrutnym księciem, uciskającym podwładnych. ."
            };

            //horrory

            FilmyModels fm2 = new FilmyModels()
            {
                GatunekID = 2,
                StudioID = 4,
                Tytul = "Lśnienie(1980)",
                Dlugosc = 146,
                Plakat = "https://fsgk.pl/wordpress/wp-content/uploads/2019/05/poster.jpg",
                Opis = "Jack podejmuje pracę stróża odciętego od świata hotelu Overlook. Wkrótce idylla zamienia się w koszmar. "
            };


            FilmyModels fm8 = new FilmyModels()
            {
                GatunekID = 2,
                StudioID = 5,
                Tytul = "Świt żywych trupów(1978)",
                Dlugosc = 126,
                Plakat = "https://fwcdn.pl/fpo/14/06/31406/7467633.3.jpg",
                Opis = "Świat opanowały spragnione ludzkiego mięsa zombie. Grupa osób próbuje przetrwać apokalipsę w gigantycznym centrum handlowym. "
            };


            FilmyModels fm9 = new FilmyModels()
            {
                GatunekID = 2,
                StudioID = 3,
                Tytul = "Lustra(2008)",
                Dlugosc = 110,
                Plakat = "https://image.ceneostatic.pl/data/products/4550519/i-lustra-mirrors-dvd.jpg",
                Opis = "Ben rozpoczyna pracę jako stróż w opuszczonym centrum handlowym. Mężczyzna zauważa, że lustra, które się tam znajdują, nie są zwyczajne.  "
            };
            FilmyModels fm10 = new FilmyModels()
            {
                GatunekID = 2,
                StudioID = 6,
                Tytul = "Mama (2013)",
                Dlugosc = 100,
                Plakat = "http://2.bp.blogspot.com/--vJmHSVI934/UZ87pli0Y9I/AAAAAAAAIWo/SuUySZWl1e4/s1600/th+(5).jpg",
                Opis = "Dwie siostry znikają w tajemniczych okolicznościach po tym, jak ich matka zostaje zamordowana. Upływa wiele lat, gdy zostają odnalezione i trafiają pod opiekę wujka.  "
            };

            //Dramat
            FilmyModels fm11 = new FilmyModels()
            {
                GatunekID = 3,
                StudioID = 7,
                Tytul = "Joker(2019)",
                Dlugosc = 122,
                Plakat = "https://fwcdn.pl/fpo/01/67/810167/7905225.6.jpg",
                Opis = "Strudzony życiem komik popada w obłęd i staje się psychopatycznym mordercą. "
            };

            FilmyModels fm12 = new FilmyModels()
            {
                GatunekID = 3,
                StudioID = 1,
                Tytul = "Parasite (2019)",
                Dlugosc = 100,
                Plakat = "https://m.media-amazon.com/images/M/MV5BYWZjMjk3ZTItODQ2ZC00NTY5LWE0ZDYtZTI3MjcwN2Q5NTVkXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_.jpg",
                Opis = "Dwie siostry znikają w tajemniczych okolicznościach po tym, jak ich matka zostaje zamordowana. Upływa wiele lat, gdy zostają odnalezione i trafiają pod opiekę wujka.  "
            };


            FilmyModels fm13 = new FilmyModels()
            {
                GatunekID = 3,
                StudioID = 7,
                Tytul = "Boże Ciało (2019)",
                Dlugosc = 105,
                Plakat = "https://fwcdn.pl/fpo/88/63/808863/7897966.3.jpg",
                Opis = "Dwudziestoletni Daniel zostaje warunkowo zwolniony z poprawczaka. Wyjeżdża na drugi koniec Polski, żeby pracować w stolarni, ale zamiast tego zaczyna udawać księdza.  "
            };
            FilmyModels fm14 = new FilmyModels()
            {
                GatunekID = 3,
                StudioID = 6,
                Tytul = "Narodziny gwiazdy (2018)",
                Dlugosc = 135,
                Plakat = "https://fwcdn.pl/fpo/25/76/542576/7849767.3.jpg",
                Opis = "Płomienny romans między dogasającą gwiazdą muzyki country a nieznaną piosenkarką zmienia ich życie na zawsze.  "
            };
            FilmyModels fm15 = new FilmyModels()
            {
                GatunekID = 3,
                StudioID = 6,
                Tytul = "List w butelce (1999)",
                Dlugosc = 131,
                Plakat = "https://fwcdn.pl/fpo/05/85/585/7514732.3.jpg",
                Opis = "Dziennikarka znajduje na plaży list w butelce. Zauroczona jego treścią postanawia odnaleźć autora. "
            };

            //Thriller

            FilmyModels fm16 = new FilmyModels()
            {
                GatunekID = 4,
                StudioID = 3,
                Tytul = "Milczenie owiec (1991)",
                Dlugosc = 118,
                Plakat = "https://fwcdn.pl/fpo/10/47/1047/7714177.3.jpg",
                Opis = "Seryjny morderca i inteligentna agentka łączą siły, by znaleźć przestępcę obdzierającego ze skóry swoje ofiary."
            };
            FilmyModels fm17 = new FilmyModels()
            {
                GatunekID = 4,
                StudioID = 4,
                Tytul = "Siedem (1995)",
                Dlugosc = 127,
                Plakat = "https://fwcdn.pl/fpo/07/02/702/6967799.3.jpg",
                Opis = "Szeryf federalny Daniels stara się dowiedzieć, jakim sposobem z zamkniętej celi w pilnie strzeżonym szpitalu dla chorych psychicznie przestępców zniknęła pacjentka."
            };
            FilmyModels fm18 = new FilmyModels()
            {
                GatunekID = 4,
                StudioID = 1,
                Tytul = "Incepcja (2010)",
                Dlugosc = 148,
                Plakat = "https://fwcdn.pl/fpo/08/91/500891/7354571.3.jpg",
                Opis = "Czasy, gdy technologia pozwala na wchodzenie w świat snów. Złodziej Cobb ma za zadanie wszczepić myśl do śpiącego umysłu."
            };
            FilmyModels fm19 = new FilmyModels()
            {
                GatunekID = 4,
                StudioID = 6,
                Tytul = "Wyspa tajemnic (2010)",
                Dlugosc = 138,
                Plakat = "https://fwcdn.pl/fpo/42/56/464256/7317256.3.jpg",
                Opis = "Szeryf federalny Daniels stara się dowiedzieć, jakim sposobem z zamkniętej celi w pilnie strzeżonym szpitalu dla chorych psychicznie przestępców zniknęła pacjentka."
            };

            //Akcji

            FilmyModels fm20 = new FilmyModels()
            {
                GatunekID = 5,
                StudioID = 7,
                Tytul = "Avengers (2012)",
                Dlugosc = 142,
                Plakat = "https://ecsmedia.pl/c/avengers-kolekcja-marvel-b-iext54591956.jpg",
                Opis = "Grupa superbohaterów, na czele z Thorem, Iron Manem i Hulkiem, łączy siły, by obronić Ziemię przed inwazją kosmitów."
            };

            FilmyModels fm21 = new FilmyModels()
            {
                GatunekID = 5,
                StudioID = 5,
                Tytul = "Rambo: Pierwsza krew (1982)",
                Dlugosc = 93,
                Plakat = "https://fwcdn.pl/fpo/90/63/9063/7175947.3.jpg",
                Opis = "John Rambo, były komandos, weteran wojny w Wietnamie, naraża się policjantom z pewnego miasteczka. Ci nie wiedzą, jak groźnym przeciwnikiem jest ten włóczęga. "
            };

            FilmyModels fm22 = new FilmyModels()
            {
                GatunekID = 5,
                StudioID = 7,
                Tytul = "Aquaman (2018)",
                Dlugosc = 143,
                Plakat = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSO8FjLVh45yH1qLva34joY_rua14ORAEZLPHxoDINsGxajHy3i",
                Opis = "Arthur Curry niechętnie stara się przejąć władzę w podwodnym królestwie Atlantydy, żeby zapobiec wojnie z ludźmi żyjącymi na powierzchni."
            };

            FilmyModels fm23 = new FilmyModels()
            {
                GatunekID = 5,
                StudioID = 3,
                Tytul = "Pamięć absolutna (2012)",
                Dlugosc = 113,
                Plakat = "https://fwcdn.pl/fpo/72/75/537275/7480666.3.jpg",
                Opis = "Robotnik odkrywa, że jego dotychczasowe wspomnienia zostały sfabrykowane."
            };

            FilmyModels fm24 = new FilmyModels()
            {
                GatunekID = 5,
                StudioID = 5,
                Tytul = "Porwanie (2011)",
                Dlugosc = 104,
                Plakat = "https://fwcdn.pl/fpo/44/62/564462/7388408.3.jpg",
                Opis = "Nathan odkrywa swoje zdjęcie na stronie internetowej z zaginionymi dziećmi. Próbując odzyskać prawdziwą tożsamość, wpada w sam środek spisku."
            };

            //Sci_fi

            FilmyModels fm25 = new FilmyModels()
            {
                GatunekID = 6,
                StudioID = 4,
                Tytul = "Piąty element (1997)",
                Dlugosc = 126,
                Plakat = "https://fwcdn.pl/fpo/01/44/144/7003240.3.jpg",
                Opis = "Nowy Jork w XXIII w., były komandos Korben Dallas wplątany zostaje w misję ratowania świata przed siłami zła absolutnego objawiającymi się raz na pięć tysięcy lat."
            };

            FilmyModels fm26 = new FilmyModels()
            {
                GatunekID = 6,
                StudioID = 3,
                Tytul = "Terminator (1984)",
                Dlugosc = 107,
                Plakat = "https://fwcdn.pl/fpo/09/95/995/7919703.3.jpg",
                Opis = "Elektroniczny morderca zostaje wysłany z przyszłości do roku 1984, by zabić matkę przyszłego lidera rewolucji. W ślad za nim rusza Kyle Reese, który ma chronić kobietę."
            };

            FilmyModels fm27 = new FilmyModels()
            {
                GatunekID = 6,
                StudioID = 2,
                Tytul = "TRON (1982)",
                Dlugosc = 96,
                Plakat = "https://upload.wikimedia.org/wikipedia/en/1/17/Tron_poster.jpg",
                Opis = "Haker zostaje przeniesiony do wnętrza systemu komputerowego i zmuszony, by walczyć o życie. Jego jedyną nadzieją jest program Tron. "
            };

            FilmyModels fm28 = new FilmyModels()
            {
                GatunekID = 6,
                StudioID = 4,
                Tytul = "Star Trek (2009)",
                Dlugosc = 126,
                Plakat = "https://image.ceneostatic.pl/data/products/82932214/i-star-trek-discovery-next-adventure-plakat-61x91-5cm.jpg",
                Opis = "Początki załogi USS Enterprise. James Kirk i Spock łączą siły, by ocalić swoich przyjaciół przed śmiertelnym niebezpieczeństwem."
            };

            FilmyModels fm29 = new FilmyModels()
            {
                GatunekID = 6,
                StudioID = 2,
                Tytul = "Gwiezdne Wojny 1: Mroczne Widmo (1999)",
                Dlugosc = 136,
                Plakat = "https://upload.wikimedia.org/wikipedia/en/thumb/4/40/Star_Wars_Phantom_Menace_poster.jpg/220px-Star_Wars_Phantom_Menace_poster.jpg",
                Opis = "Dwaj rycerze Jedi wyruszają z misją ocalenia planety Naboo przed inwazją wojsk Federacji Handlowej. Trafiają na pustynny glob, gdzie pomoże im mały Anakin Skywalker."
            };

            //animowane
            FilmyModels fm30 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Spider-Man Uniwersum (2018)",
                Dlugosc = 107,
                Plakat = "https://fwcdn.pl/fpo/32/33/743233/7866074.3.jpg",
                Opis = "Miles Morales po ukąszeniu przez radioaktywnego pająka staje do walki z nikczemnym Kingpinem. Pomogą mu w tym Spider-Manowie z innych wymiarów."
            };
            FilmyModels fm31 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Nowe szaty króla (2000)",
                Dlugosc = 78,
                Plakat = "https://image.ceneostatic.pl/data/products/56060275/i-nowe-szaty-krola-zaczarowana-kolekcja.jpg",
                Opis = "Młody król zostaje zmieniony w lamę i wyrzucony z pałacu. Zrozpaczony władca poznaje wieśniaka, który pomaga mu ponownie zasiąść na tronie. "
            };
            FilmyModels fm32 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Król Lew (1994)",
                Dlugosc = 89,
                Plakat = "https://image.ceneostatic.pl/data/products/126926/i-krol-lew-the-lion-king-dvd.jpg",
                Opis = "Targany niesłusznymi wyrzutami sumienia po śmierci ojca mały lew Simba skazuje się na wygnanie, rezygnując z przynależnego mu miejsca na czele stada."
            };
            FilmyModels fm33 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Kraina lodu (2013)",
                Dlugosc = 108,
                Plakat = "https://fwcdn.pl/fpo/19/32/651932/7579505.3.jpg",
                Opis = "Kiedy posiadająca moc kontroli nad śniegiem i lodem Elsa sprowadza srogą zimę na swoje królestwo, Anna wyrusza w podróż, aby odszukać siostrę oraz zakończyć pogodowe anomalie."
            };
            FilmyModels fm34 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Zaplątani (2010)",
                Dlugosc = 96,
                Plakat = "https://image.ceneostatic.pl/data/products/10695918/i-zaplatani-tangled-dvd.jpg",
                Opis = "Żyjąca na odludziu Roszpunka, której włosy mają magiczną moc, marzy, by poznać świat. Jej przepustką do wolności jest czarujący łotrzyk Flynn."
            };
            FilmyModels fm35 = new FilmyModels()
            {
                GatunekID = 7,
                StudioID = 2,
                Tytul = "Zwierzogród (2016)",
                Dlugosc = 108,
                Plakat = "https://lh3.googleusercontent.com/proxy/eBw4pgYPUqhh5BbcYBBuCnlv1lOqf8TgpJB0jKRAukktGvb_25_H4SxTUf6l3cRlubTm-GzHAUoTIbTj8Bs6qNGr3j9rKheci-H_6-KqZJ8f6aKrbq7y_oIG",
                Opis = "Nick Bajer – żyjący z drobnych przekrętów szczwany lis, i Judy Hops – pierwszy w historii królik zatrudniony w policji, łączą siły, by rozwiązać pewną kryminalną zagadkę."
            };



            //base.Seed(context);
            context.Gatunek.Add(gatunek);
            context.Gatunek.Add(gatunek2);
            context.Gatunek.Add(gatunek3);
            context.Gatunek.Add(gatunek4);
            context.Gatunek.Add(gatunek6);
            context.Gatunek.Add(gatunek7);
            context.Gatunek.Add(gatunek9);
            context.SaveChanges();
            context.Studio.Add(studio1);
            context.Studio.Add(studio2);
            context.Studio.Add(studio3);
            context.Studio.Add(studio4);
            context.Studio.Add(studio5);
            context.Studio.Add(studio6);
            context.Studio.Add(studio7);
            context.SaveChanges();
            context.Film.Add(fm);
            context.Film.Add(fm2);
            context.Film.Add(fm3);
            context.Film.Add(fm4);
            context.Film.Add(fm5);
            context.Film.Add(fm6);
            context.Film.Add(fm7);
            context.Film.Add(fm8);
            context.Film.Add(fm9);
            context.Film.Add(fm10);
            context.Film.Add(fm11);
            context.Film.Add(fm12);
            context.Film.Add(fm13);
            context.Film.Add(fm14);
            context.Film.Add(fm15);
            context.Film.Add(fm16);
            context.Film.Add(fm17);
            context.Film.Add(fm18);
            context.Film.Add(fm19);
            context.Film.Add(fm20);
            context.Film.Add(fm21);
            context.Film.Add(fm22);
            context.Film.Add(fm23);
            context.Film.Add(fm24);
            context.Film.Add(fm25);
            context.Film.Add(fm26);
            context.Film.Add(fm27);
            context.Film.Add(fm28);
            context.Film.Add(fm29);
            context.Film.Add(fm30);
            context.Film.Add(fm31);
            context.Film.Add(fm32);
            context.Film.Add(fm33);
            context.Film.Add(fm34);
            context.Film.Add(fm35);
            context.SaveChanges();

       
        }
    }
}