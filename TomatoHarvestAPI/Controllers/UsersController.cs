using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TomatoHarvestAPI.DataAccess.Repository.IRepository;
using TomatoHarvestAPI.Models;

namespace TomatoHarvestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        #region Dependency Injection
        private readonly IUnitOfWork _unitOfWork;
        public UsersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        #endregion

        #region GET All Users: api/<TransController>/Get
        [HttpGet]
        [Route("GetAllUsers")]
        public List<TbUser> GetAllUsers()
        {
            return _unitOfWork.TbUser.GetAll().ToList();
        }
        #endregion

        #region GET User By Id: api/<TransController>/Get/5
        [HttpGet("GetUserById/{id}")]
        public TbUser GetUserById(int id)
        {
            return _unitOfWork.TbUser.Get(s=>s.UserId == id);
        }
        #endregion

        #region POST New or Edit user: api/<TransController>
        [HttpPost("PostUser")]
        public IActionResult PostUser([FromBody] TbUser user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var data = _unitOfWork.TbUser.Get(s => s.UserId == user.UserId);
            if (data != null)
            {
                data.UserName = user.UserName;
                data.Password = user.Password;
                data.Email = user.Email;
                data.Phone = user.Phone;
                data.CurrentState = user.CurrentState;
                _unitOfWork.TbUser.Update(data);
            }
            else
            {
                _unitOfWork.TbUser.Add(user);
            }

            _unitOfWork.Save();

            return Ok();
        }
        #endregion

        #region POST Delte user: api/<TransController>/Delete
        [HttpPost("DeleteUser")]
        public IActionResult DeleteUser([FromBody] TbUser user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _unitOfWork.TbUser.Remove(user);
            _unitOfWork.Save();
            return Ok();
        }
        #endregion
    }
}
