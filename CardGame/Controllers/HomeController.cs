using System.Web.Mvc;
using BusinessLayer;
using CardGame.Models;
using Microsoft.Ajax.Utilities;

namespace CardGame.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string cardList)
        {
            if (!cardList.IsNullOrWhiteSpace())
            {
                var inputCards = cardList.Trim().ToUpper().Split(',');

                var realCards = new RealCards(inputCards);

                if (realCards.CardValidation.IsSuccess)
                {
                    var cards = realCards.GetCardList();

                    IOperateCard operateCard = new OperateCard();

                    var score = operateCard.CalculateScore(cards);

                    ViewBag.Message = ResultMessage.YourScore + score;

                    View(ViewBag.Message);
                }
                else
                {
                    ViewBag.Message = realCards.CardValidation.Message;
                    View(ViewBag.Message);
                }
            }

            return View();
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Keerthi Jagalur Mutt";

            return View();
        }
    }
}