using Application.DTOs;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Shared.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task Delete(int id)
        {
            var entity = await _userRepository.GetByIdAsync(id);
            if (entity == null)
            {
                throw new Exception(ErrorMessagConst.NotFoundMsg);
            }

            await _userRepository.DeleteAsync(entity);
        }

        public async Task<List<UserVM>> GetAllUser()
        {
            var user = await _userRepository.GetAllAsync();
            return _mapper.Map<List<UserVM>>(user);
        }

        public async Task Create(UserVM user)
        {
            var entity = _mapper.Map<UserVM, User>(user);
            await _userRepository.AddAsync(entity);
        }

        public async Task Update(UserVM user)
        {
            var entity = await _userRepository.GetByIdAsync(user.Id);
            if (entity == null)
            {
                throw new Exception(ErrorMessagConst.NotFoundMsg);
            }
            _mapper.Map<UserVM, User>(user, entity);
            await _userRepository.UpdateAsync(entity);
            
        }
    }
}
