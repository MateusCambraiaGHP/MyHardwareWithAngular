using AutoMapper;
using MyHardware.ViewModel;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<bool> ValidatePassword(string email, string password)
        {
            var currentUser = await _userRepository.GetUserByEmailAndPassWord(email, password);
            return currentUser != null;
        }
        public async Task<UserViewModel> Save(UserViewModel model)
        {
            var userMap = _mapper.Map<UserViewModel, User>(model);
            await _userRepository.Create(userMap);
            return model;
        }

        public async Task<UserViewModel> Edit(UserViewModel model)
        {
            var userMap = _mapper.Map<UserViewModel, User>(model);
            await _userRepository.Update(userMap);
            return model;
        }

        public async Task<UserViewModel> FindById(int id)
        {
            var currentUser = await _userRepository.FindById(id) ?? new User();
            var userMap     = _mapper.Map<User, UserViewModel>(currentUser);
            return userMap;
        }

        public async Task<List<UserViewModel>> GetAll()
        {
            var listUser    = await _userRepository.GetAll() ?? new List<User>();
            var listUserMap = _mapper.Map<List<UserViewModel>>(listUser);
            return listUserMap;
        }
    }
}