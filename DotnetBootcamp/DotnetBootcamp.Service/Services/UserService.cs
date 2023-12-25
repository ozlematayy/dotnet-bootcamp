using AutoMapper;
using DotnetBootcamp.Core.DTOs;
using DotnetBootcamp.Core.DTOs.Authentication;
using DotnetBootcamp.Core.Models;
using DotnetBootcamp.Core.Repositories;
using DotnetBootcamp.Core.Services;
using DotnetBootcamp.Core.UnitOfWorks;
using DotnetBootcamp.Service.Authorization.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBootcamp.Service.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IGenericRepository<User> _repository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;

        public UserService(IGenericRepository<User> repository, IUnitOfWork unitOfWork,IMapper mapper,IJwtAuthenticationManager jwtAuthenticationManager,IUserRepository userRepository) : base(repository, unitOfWork)
        {
            _repository = repository;
            _mapper = mapper;
            _jwtAuthenticationManager = jwtAuthenticationManager;
            _userRepository = userRepository;
        }

        public UserDto FindUser(string userName, string password)
        {
            string passHashed = GeneratePasswordHash(userName, password);
            var user = _repository.Where(x => x.UserName == userName && x.Password == passHashed).FirstOrDefault();
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public string GeneratePasswordHash(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException(nameof(userName));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException(nameof(userName));
            }

            byte[] userBytes = Encoding.UTF8.GetBytes(userName);
            string userByteString = Convert.ToBase64String(userBytes);
            string smallByteString = $"{userByteString.Take(2)}.{userByteString.Reverse().Take(2)}";
            byte[] smallBytes = Encoding.UTF8.GetBytes(smallByteString);
            byte[] passBytes = Encoding.UTF8.GetBytes(password);

            byte[] hashed = this.GenerateSaltedHash(passBytes, smallBytes);

            return Convert.ToBase64String(hashed);
        }

        private byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);
        }
        public AuthResponseDto Login(AuthRequestDto request)
        {
            AuthResponseDto responseDto = new AuthResponseDto();
            UserDto user = FindUser(request.UserName, request.Password);
            responseDto = _jwtAuthenticationManager.Authenticate(request.UserName, request.Password);
            responseDto.User = user;
            return responseDto;
        }

        public User SignUp(AuthRequestDto authRequestDto)
        {
            var passHashed = GeneratePasswordHash(authRequestDto.UserName, authRequestDto.Password);
            var user = AddAsync(new User
            {
                Email = authRequestDto.Email,
                Password = passHashed,
                UserName = authRequestDto.UserName,
                TeamId = 1
            });
            return user.Result;
        }
    }
}
