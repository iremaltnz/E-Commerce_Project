using Business.Abstract;
using Business.Aspects.Mail;
using Business.Constants;
using Business.Utilities.Hashing;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.GetById(u => u.email == email),Messages.successListed);
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = GetByMail(userForLoginDto.email);

            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(Messages.userNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.password, userToCheck.Data.password_hash, userToCheck.Data.password_salt))
            {
                return new ErrorDataResult<User>(Messages.passwordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data, Messages.successLogin);
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordSalt, passwordHash;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var user = new User
            {
                email = userForRegisterDto.email,
                first_name = userForRegisterDto.first_name,
                last_name = userForRegisterDto.last_name,
                password_hash = passwordHash,
                password_salt = passwordSalt,
                authority_id=userForRegisterDto.authority_id,
               
            };

            _userDal.Add(user);
            if (user.authority_id == 2)
            {
                EditörSendMail.SendMail(user.email,password);
            }
            return new SuccessDataResult<User>(user, Messages.successRegister);
        }
    }
    
}
