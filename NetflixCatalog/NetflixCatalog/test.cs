using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class test : IEnumerable
    {
        List<Title> Titles = new List<Title>();
        
        public test(List<Title> Titles)
        {
            this.Titles = Titles;
        }
        public void DieHard()
        {
            Title DieHard = new Movie(131);
            
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);
        }
        public void Heat()
        {
            Title Heat = new Movie(171);
            
            Heat.name = "Heat";
            Heat.rating = 3;
            string HeatInfo;
            HeatInfo = Heat.ToString();
            Console.WriteLine(HeatInfo);
        }
        public void HotFuzz()
        {
            Title HotFuzz = new Movie(121);
            HotFuzz.name = "Hot Fuzz";
            HotFuzz.rating = 3;
            string HotFuzzInfo;
            HotFuzzInfo = HotFuzz.ToString();
            Console.WriteLine(HotFuzzInfo);

        }
        public void RushHour()
        {
            Title RushHour = new Movie(97);
            RushHour.name = "Rush Hour";
            RushHour.rating = 2;
            string RushHourInfo;
            RushHourInfo = RushHour.ToString();
            Console.WriteLine(RushHourInfo);

        }
        public void MadMax()
        {
            Title MadMax = new Movie(88);
            MadMax.name = "Mad Max";
            MadMax.rating = 2;
            string MadMaxInfo;
            MadMaxInfo = MadMax.ToString();
            Console.WriteLine(MadMaxInfo);

        }
        public void MrMrsSmith()
        {
            Title MrMrsSmith = new Movie(123);
            MrMrsSmith.name = "Mr and Mrs Smith";
            MrMrsSmith.rating = 2;
            string MrMrsSmithInfo;
            MrMrsSmithInfo = MrMrsSmith.ToString();
            Console.WriteLine(MrMrsSmithInfo);

        }
        public void KnockedUp()
        {
            Title KnockedUp = new Movie(129);
            KnockedUp.name = "Knocked Up";
            KnockedUp.rating = 2;
            string KnockedUpInfo;
            KnockedUpInfo = KnockedUp.ToString();
            Console.WriteLine(KnockedUpInfo);

        }
        public void SLP()
        {
            Title SLP = new Movie(122);
            SLP.name = "Silver Linings Playbook";
            SLP.rating = 1;
            string SLPInfo;
            SLPInfo = SLP.ToString();
            Console.WriteLine(SLPInfo);

        }
        public void PrincessBride()
        {
            Title PrincessBride = new Movie(98);
            PrincessBride.name = "The Princess Bride";
            PrincessBride.rating = 4;
            string PrincessBrideInfo;
            PrincessBrideInfo = PrincessBride.ToString();
            Console.WriteLine(PrincessBrideInfo);

        }
        public void Zoolander()
        {
            Title Zoolander = new Movie(89);
            Zoolander.name = "Zoolander";
            Zoolander.rating = 2;
            string ZoolanderInfo;
            ZoolanderInfo = Zoolander.ToString();
            Console.WriteLine(ZoolanderInfo);

        }
        public void Titanic()
        {
            Title Titanic = new Movie(194);
            Titanic.name = "Titanic";
            Titanic.rating = 1;
            string TitanicInfo;
            TitanicInfo = Titanic.ToString();
            Console.WriteLine(TitanicInfo);

        }
        public void DirtyDancing()
        {
            Title DirtyDancing = new Movie(100);
            DirtyDancing.name = "Dirty Dancing";
            DirtyDancing.rating = 4;
            string DirtyDancingInfo;
            DirtyDancingInfo = DirtyDancing.ToString();
            Console.WriteLine(DirtyDancingInfo);

        }
        public void Notebook()
        {
            Title Notebook = new Movie(121);
            Notebook.name = "The Notebook";
            Notebook.rating = 0;
            string NotebookInfo;
            NotebookInfo = Notebook.ToString();
            Console.WriteLine(NotebookInfo);
        }
        public void TwentyFour()
        {
            Title TwentyFour = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);
        }
        public void Seinfeld()
        {
            Title Seinfeld = new TV(180);
            Seinfeld.name = "Seinfeld";
            Seinfeld.rating = 3;
            string SeinfeldInfo;
            SeinfeldInfo = Seinfeld.ToString();
            Console.WriteLine(SeinfeldInfo);
        }
        public void Chuck()
        {
            Title Chuck = new TV(91);
            Chuck.name = "Chuck";
            Chuck.rating = 1;
            string ChuckInfo;
            ChuckInfo = Chuck.ToString();
            Console.WriteLine(ChuckInfo);
        }
        public void Greys()
        {
            Title Greys = new TV(255);
            Greys.name = "Grey's Anatomy";
            Greys.rating = 1;
            string GreysInfo;
            GreysInfo = Greys.ToString();
            Console.WriteLine(GreysInfo);
        }
        public void GossipGirl()
        {
            Title GossipGirl = new TV(121);
            GossipGirl.name = "Gossip Girl";
            GossipGirl.rating = 1;
            string GossipGirlInfo;
            GossipGirlInfo = GossipGirl.ToString();
            Console.WriteLine(GossipGirlInfo);
        }
        public void HIMYM()
        {
            Title HIMYM = new TV(208);
            HIMYM.name = "How I Met Your Mother";
            HIMYM.rating = 2;
            string HIMYMinfo;
            HIMYMinfo = HIMYM.ToString();
            Console.WriteLine(HIMYMinfo);
        }
        public void Buffy()
        {
            Title Buffy = new TV(144);
            Buffy.name = "Buffy the Vampire Slayer";
            Buffy.rating = 2;
            string BuffyInfo;
            BuffyInfo = Buffy.ToString();
            Console.WriteLine(BuffyInfo);
        }
        public void IASIP()
        {
            Title IASIP = new TV(141);
            IASIP.name = "It's Always Sunny in Philadelphia";
            IASIP.rating = 4;
            string IASIPinfo;
            IASIPinfo = IASIP.ToString();
            Console.WriteLine(IASIPinfo);
        }

        public IEnumerator GetEnumerator()
        {
            foreach(Title t in Titles)
            {
                yield return t;
            }
        }
    }
}

