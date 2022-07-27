using NUnit.Framework;
using IsaiahsPartOfProject;
using System;
using System.Collections.Generic;

namespace GameModelSetup.StoneAgeTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void EatOnceTest()
        {
            PlayerClass testPlayer = new PlayerClass("test");
            if (testPlayer.DeductFood() == 0)
            {
                Assert.Pass();
            }
            else 
            {
                Assert.Fail();
            }
        }

        [TestCase]
        public void EatThreeTimesTest() 
        {
            PlayerClass testPlayer = new PlayerClass("test");
            testPlayer.DeductFood();
            testPlayer.DeductFood();
            if (testPlayer.DeductFood() > 0)
            {
                Assert.Pass();
            }
            else 
            {
                Assert.Fail();
            }
        }

        [TestCase]
        public void FourPlayerTurnSwitchTest() 
        {
            List<PlayerClass> players = new List<PlayerClass>();
            bool check1, check2, check3;
            players.Add(new PlayerClass("1"));
            players.Add(new PlayerClass("2"));
            players.Add(new PlayerClass("3"));
            players.Add(new PlayerClass("4"));

            GameClass testGame = new GameClass(players);

            testGame.changeCurrentPlayer(1, 0);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check1 = true;
            }
            else 
            {
                check1 = false;
            }

            testGame.changeCurrentPlayer(0, 1);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check2 = true;
            }
            else
            {
                check2 = false;
            }

            testGame.changeCurrentPlayer(1, 3);
            if (testGame.currentPlayer.name.Equals("1"))
            {
                check3 = true;
            }
            else
            {
                check3 = false;
            }

            if (check1 && check2 && check3)
            {
                Assert.Pass();
            }
            else 
            {
                Assert.Fail();
            }

        }

        [TestCase]
        public void ThreePlayerTurnSwitchTest()
        {
            List<PlayerClass> players = new List<PlayerClass>();
            bool check1, check2, check3;
            players.Add(new PlayerClass("1"));
            players.Add(new PlayerClass("2"));
            players.Add(new PlayerClass("3"));

            GameClass testGame = new GameClass(players);

            testGame.changeCurrentPlayer(1, 0);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check1 = true;
            }
            else
            {
                check1 = false;
            }

            testGame.changeCurrentPlayer(0, 1);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check2 = true;
            }
            else
            {
                check2 = false;
            }

            testGame.changeCurrentPlayer(1, 3);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check3 = true;
            }
            else
            {
                check3 = false;
            }

            if (check1 && check2 && check3)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [TestCase]
        public void TwoPlayerTurnSwitchTest()
        {
            List<PlayerClass> players = new List<PlayerClass>();
            bool check1, check2, check3;
            players.Add(new PlayerClass("1"));
            players.Add(new PlayerClass("2"));

            GameClass testGame = new GameClass(players);

            testGame.changeCurrentPlayer(1, 0);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check1 = true;
            }
            else
            {
                check1 = false;
            }

            testGame.changeCurrentPlayer(0, 1);
            if (testGame.currentPlayer.name.Equals("2"))
            {
                check2 = true;
            }
            else
            {
                check2 = false;
            }

            testGame.changeCurrentPlayer(1, 3);
            if (testGame.currentPlayer.name.Equals("1"))
            {
                check3 = true;
            }
            else
            {
                check3 = false;
            }

            if (check1 && check2 && check3)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}