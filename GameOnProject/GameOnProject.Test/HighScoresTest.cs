using AutoMoq;
using GameOnProject.Shared.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Test
{
    [TestClass]
    public class HighScoresTest
    {
        private readonly AutoMoqer _mocker = new AutoMoqer();
        [TestMethod]
        public void Correct_Scores_are_being_return_in_the_right_order()
        {
            _mocker.GetMock<HighScoreViewModel>();
        }
    }
}
