using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("")]
        [Route("ReceiverMessage")]
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await  _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writerMessageManager.GetListReceiverMessage(p);
            return View(messagelist);
        }
        [Route("")]
        [Route("SenderMessage")]
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messagelist = writerMessageManager.GetListSenderMessage(p);
            return View(messagelist);
        }

        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
        [Route("SenderMessageDetails/{id}")]

        public IActionResult SenderMessageDetails(int id)
        {
            WriterMessage writerMessage = writerMessageManager.TGetByID(id);
            return View(writerMessage);
        }
        [HttpGet]
        [Route("SendMessage")]

        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        [Route("SendMessage")]

        public async Task<IActionResult> SendMessage(WriterMessage w)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            w.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            w.Sender = mail;
            w.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == w.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            w.ReceiverName = usernamesurname;
            writerMessageManager.TAdd(w);
            return RedirectToAction("SenderMessage");
        }
    }
}
