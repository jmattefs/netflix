using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog.Tests
{
    [TestClass()]
    public class ViewTests
    {
        [TestMethod()]
        public void DieHardTest()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.AreEqual(131, movie.duration);
        }
        [TestMethod()]
        public void DieHardTest2()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.AreEqual("Die Hard: 131 minutes long and 4 thumbs up!", DieHardInfo);
        }
        [TestMethod()]
        public void DieHardTest3()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.AreEqual(4, DieHard.rating);
        }
        [TestMethod()]
        public void TwentyFourTest()
        {
            Title TwentyFour = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.AreEqual("24: 204 episodes and the Average Episode Rating is 4", TwentyFourInfo);
        }
        [TestMethod()]
        public void TwentyFourTest2()
        {
            Title TwentyFour = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.AreNotEqual(TwentyFour.name, TwentyFour.rating);
        }
        [TestMethod()]
        public void TwentyFourTest3()
        {
            Title TwentyFour = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.AreEqual("24", TwentyFour.name);
        }
        [TestMethod()]
        public void NotebookTest()
        {
            Title Notebook = new Movie(121);
            Notebook.name = "The Notebook";
            Notebook.rating = 0;
            string NotebookInfo;
            NotebookInfo = Notebook.ToString();
            Console.WriteLine(NotebookInfo);

            Assert.IsNotNull(Notebook.rating);
        }
        [TestMethod()]
        public void NotebookTest2()
        {
            Title Notebook = new Movie(121);
            Notebook.name = "The Notebook";
            Notebook.rating = 0;
            string NotebookInfo;
            NotebookInfo = Notebook.ToString();
            Console.WriteLine(NotebookInfo);

            Assert.AreEqual(NotebookInfo, Notebook.ToString());
        }
        [TestMethod()]
        public void NotebookTest3()
        {
            Title Notebook = new Movie(121);
            Notebook.name = "The Notebook";
            Notebook.rating = 0;
            string NotebookInfo;
            NotebookInfo = Notebook.ToString();
            Console.WriteLine(NotebookInfo);

            Assert.ReferenceEquals(Notebook.name, Notebook.rating);
        }
        [TestMethod()]
        public void NotebookTest4()
        {
            Title Notebook = new Movie(121);
            Notebook.name = "The Notebook";
            Notebook.rating = 0;
            string NotebookInfo;
            NotebookInfo = Notebook.ToString();
            Console.WriteLine(NotebookInfo);

            Assert.IsNotInstanceOfType(typeof(Movie),typeof(Title));
        }
        [TestMethod()]
        public void TwentyFourTest4()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.AreEqual(204, tv.episodes);
        }
        [TestMethod()]
        public void TwentyFourTest5()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.IsNotNull(TwentyFour.rating);
        }
        [TestMethod()]
        public void TwentyFourTest6()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.IsNotNull(tv.episodes);
        }
        [TestMethod()]
        public void TwentyFourTest7()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.IsInstanceOfType(TwentyFour, typeof(Title));
        }
        [TestMethod()]
        public void TwentyFourTest8()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.IsInstanceOfType(tv, typeof(TV));
        }
        [TestMethod()]
        public void TwentyFourTest9()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.IsInstanceOfType(TwentyFour, typeof(TV));
        }
        [TestMethod()]
        public void TwentyFourTest10()
        {
            Title TwentyFour = new TV(204);
            TV tv = new TV(204);
            TwentyFour.name = "24";
            TwentyFour.rating = 4;
            string TwentyFourInfo;
            TwentyFourInfo = TwentyFour.ToString();
            Console.WriteLine(TwentyFourInfo);

            Assert.AreEqual("24: 204 episodes and the Average Episode Rating is 4", TwentyFour.ToString());
        }
        [TestMethod()]
        public void DieHardTest4()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.IsInstanceOfType(DieHard, typeof(Title));
        }
        [TestMethod()]
        public void DieHardTest5()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.AreNotEqual(DieHard.rating, movie.rating);
        }
        [TestMethod()]
        public void DieHardTest6()
        {
            Title DieHard = new Movie(131);
            Movie movie = new Movie(131);
            DieHard.name = "Die Hard";
            DieHard.rating = 4;
            string DieHardInfo;
            DieHardInfo = DieHard.ToString();
            Console.WriteLine(DieHardInfo);

            Assert.AreNotEqual(DieHard.name, movie.name);
        }
    }
}