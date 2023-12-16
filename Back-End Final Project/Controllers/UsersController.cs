using Microsoft.AspNetCore.Mvc;
using Back_End_Final_Project.Models;
using System.Net;
using AutoMapper;
using Back_End_Final_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Back_End_Final_Project.Models.DTOS;

namespace Back_End_Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly GameDbContext _context;
        private readonly IMapper _mapper;
        private APIResponse _response;

        public UsersController(GameDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _response = new();
        }
        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetUsers()
        {
            try
            {
                List<User> users = await _context.Users.ToListAsync();
                if(users.Count == 0)
                {
                    _response.StatusCode = HttpStatusCode.NoContent;
                    _response.IsSuccess = false;
                    _response.Message = "No Users";
                    _response.Result = null;

                    return _response;
                }

                List<UsersDTO> result = _mapper.Map<List<UsersDTO>>(users);
                if (result == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Message = "Bad Request";
                    _response.Result = null;

                    return _response;
                }

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
        [HttpPost]
        public async Task<ActionResult<APIResponse>> RegisterUser(CreateUserDTO registerUser)
        {
            try
            {
                if(registerUser is null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Message = "Incorrect Data Passed";
                    _response.Result = null;
                    return _response; 
                }
                User newUser = _mapper.Map<User>(registerUser);

                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.Created;
                _response.IsSuccess = true;
                _response.Result = newUser;
            }
            catch(Exception ex) 
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Message = ex.Message;
                _response.Result = null;
            }
            return _response;
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<APIResponse>> DeleteUser(int id)
        {
            try
            {
                if (id <= 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Message = "Incorrect Data Passed";
                    _response.Result = null;
                    return _response;
                }
                User result = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);

                if (result == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsSuccess = false;
                    _response.Result = null;
                    return _response;
                }
                _context.Users.Remove(result);
                await _context.SaveChangesAsync();

                _response.StatusCode = HttpStatusCode.OK;
                _response.IsSuccess = true;
                _response.Result = result;

                
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.InternalServerError;
                _response.IsSuccess = false;
                _response.Message = ex.Message;
            }
            return _response;
        }
    }
}
