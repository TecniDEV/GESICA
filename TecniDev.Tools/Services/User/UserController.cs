using Microsoft.Extensions.Logging;

namespace TecniDev.Tools.Services.User
{
    public class UserController
    {
        private readonly ILogger<UserController> _logger;
        private UserRepository<Data.Models.User, Int128> _userRepository { get; }

        public void Add(Data.Models.User user)
        {
            try { _userRepository.Add(user); }
            catch (Exception ex) 
            { 
                _logger.Log(LogLevel.Error, ex.Message);
            }
            finally { _userRepository.Close(); }
        }

        public void Remove(long userId)
        {
            try { _userRepository.Delete(userId); }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
            }
            finally { _userRepository.Close(); }
        }

        public void Update(Data.Models.User user) 
        {
            try { _userRepository.Update(user); }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
            }
            finally { _userRepository.Close(); }
        }

        public Data.Models.User? Get(long userId) 
        {
            try { return _userRepository.FindById(userId); }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                return null;
            }
            finally { _userRepository.Close(); }
        }

        public IEnumerable<Data.Models.User> GetUsers()
        {
            try { return _userRepository.GetAll(); }
            finally { _userRepository.Close(); }
        }

    }
}
